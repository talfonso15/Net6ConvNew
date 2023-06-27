using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TravelExpenses
{
    public partial class Meals : Form
    {
        int totalDays;
        int lastRow;
        double mealsPerDiemRate = 0;
        double breakfastPerDiemRate = 0;
        double lunchPerDiemRate = 0;
        double dinnerPerDiemRate = 0;
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        public Meals()
        {
            InitializeComponent();
            if (CommonVariables.viewDetails)
            {
                ViewDetailsGridview();
            }
            else
            {
                //createDatagridview();
            }
        }

        public void createDatagridview(double mealsPerDiemRate, double breakfastPerDiemRate, double lunchPerDiemRate, double dinnerPerDiemRate)
        {

            if (!CommonVariables.viewDetails)
            {
                string departureDate = "";
                string returnDate = "";
                string departureTime = "";
                string returnTime = "";

                //asking if we are adding new items to the travel
                if (CommonVariables.addingItems)
                {
                    localCon.Open();
                    Guid travID = new Guid(CommonVariables.addingTravelID);
                    SqlCommand cmd = new SqlCommand("SELECT [DepartureTime],[DepartureDate],[ReturnTime],[ReturnDate] FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        departureDate = dr["DepartureDate"].ToString();
                        returnDate = dr["ReturnDate"].ToString();
                        departureTime = dr["DepartureTime"].ToString();
                        returnTime = dr["ReturnTime"].ToString();

                    }
                    dr.Close();
                    localCon.Close();




                }
                //this is when we are creating a new expense report
                else
                {
                    departureDate = CommonVariables.travelDepartureDate.ToShortDateString();
                    returnDate = CommonVariables.travelReturnDate.ToShortDateString();
                    departureTime = CommonVariables.travelDepartureTime.ToString();
                    returnTime = CommonVariables.travelReturnTime.ToString();
                }




                //TimeSpan difference = CommonVariables.travelReturnDate.Subtract(CommonVariables.travelDepartureDate);
                TimeSpan difference = Convert.ToDateTime(returnDate).Subtract(Convert.ToDateTime(departureDate));
                totalDays = (int)difference.TotalDays;
                totalDays = totalDays + 1;
                CommonVariables.totalDaysMeals = totalDays;// for lodging nights
                departureTime = departureTime.Trim();
                int longDepartureTime = departureTime.Length;
                string departureTimeHour;
                string departureTimeMinutes;
                if (longDepartureTime == 8)
                {
                    departureTimeHour = departureTime.Substring(0, 2).Trim();
                    departureTimeMinutes = departureTime.Substring(3, 2).Trim();
                }
                else
                {
                    departureTimeHour = departureTime.Substring(0, 1).Trim();
                    departureTimeMinutes = departureTime.Substring(2, 2).Trim();
                }


                string dayTimeDeparture = departureTime.Substring(5).Trim();

                returnTime = returnTime.Trim();
                int longReturnTime = returnTime.Length;

                string returnTimeHour;
                string returnTimeMinutes;

                if (longReturnTime == 8)
                {
                    returnTimeHour = returnTime.Substring(0, 2).Trim();
                    returnTimeMinutes = returnTime.Substring(3, 2).Trim();
                }
                else
                {
                    returnTimeHour = returnTime.Substring(0, 1).Trim();
                    returnTimeMinutes = returnTime.Substring(2, 2).Trim();
                }


                string returnTimesDayTime = returnTime.Substring(5).Trim();

                /* DataGridViewRow row = new DataGridViewRow();
                 row.Cells[0].Value = CommonVariables.travelDepartureDate.ToString();
                 row.Cells[1].Value = true;
                 row.Cells[2].Value = true;
                 row.Cells[3].Value = true;
                 row.Cells[4].Value = 40;
                 dtgMeals.Rows.Add(row);*/

                int depTLenght = Convert.ToDateTime(departureDate).Date.ToShortDateString().Length;
                if (depTLenght == 10)
                {
                    departureDate = departureDate.Substring(0, 10);

                }
                else if (depTLenght == 8)
                {
                    departureDate = departureDate.Substring(0, 8);
                }
                else
                {
                    departureDate = departureDate.Substring(0, 9);
                }

                DateTime depDate = Convert.ToDateTime(departureDate);
                int dateLenght = depTLenght;


                for (int i = 0; i < totalDays; i++)
                {
                    if (dateLenght == 8)
                    {
                        dtgMeals.Rows.Add(depDate.ToString().Substring(0, 9), true, true, true, mealsPerDiemRate.ToString());
                    }
                    else
                    {
                        dtgMeals.Rows.Add(depDate.ToString().Substring(0, 10), true, true, true, mealsPerDiemRate.ToString());
                    }

                    depDate = depDate.AddDays(1);
                    dateLenght = depDate.ToShortDateString().Length;
                }

                if (Convert.ToInt32(departureTimeHour) > 6 && Convert.ToInt32(departureTimeHour) < 12 && dayTimeDeparture == "AM")
                {

                    dtgMeals.Rows[0].Cells[1].Value = false;
                }

                if (Convert.ToInt32(departureTimeHour) == 6 && Convert.ToInt32(departureTimeMinutes) >= 0 && dayTimeDeparture == "AM")
                {

                    dtgMeals.Rows[0].Cells[1].Value = false;
                }

                if (Convert.ToInt32(departureTimeHour) <= 12 && dayTimeDeparture == "PM")
                {

                    dtgMeals.Rows[0].Cells[1].Value = false;
                    dtgMeals.Rows[0].Cells[2].Value = false;

                    if (Convert.ToInt32(departureTimeHour) >= 6 && Convert.ToInt32(departureTimeHour) <= 11 && dayTimeDeparture == "PM")
                    {
                        dtgMeals.Rows[0].Cells[3].Value = false;

                    }
                }

                if (Convert.ToInt32(departureTimeHour) == 12 && dayTimeDeparture == "PM" && Convert.ToInt32(departureTimeMinutes) > 0)
                {

                    dtgMeals.Rows[0].Cells[1].Value = false;
                    dtgMeals.Rows[0].Cells[2].Value = false;
                }
                if (Convert.ToInt32(departureTimeHour) == 6 && dayTimeDeparture == "PM" && Convert.ToInt32(departureTimeMinutes) > 0)
                {

                    dtgMeals.Rows[0].Cells[1].Value = false;
                    dtgMeals.Rows[0].Cells[2].Value = false;
                    dtgMeals.Rows[0].Cells[3].Value = false;

                }

                bool firstBreakfast = (bool)dtgMeals.Rows[0].Cells[1].Value;
                bool firstLunch = (bool)dtgMeals.Rows[0].Cells[2].Value;
                bool firstDinner = (bool)dtgMeals.Rows[0].Cells[3].Value;

                if (firstBreakfast == false && firstLunch == false && firstDinner == false)
                {
                    dtgMeals.Rows[0].Cells[4].Value = "0";
                }
                else if (firstBreakfast == true && firstLunch == false && firstDinner == false)
                {
                    dtgMeals.Rows[0].Cells[4].Value = breakfastPerDiemRate.ToString();
                }
                else if (firstBreakfast == false && firstLunch == true && firstDinner == false)
                {
                    dtgMeals.Rows[0].Cells[4].Value = lunchPerDiemRate.ToString();
                }
                else if (firstBreakfast == false && firstLunch == false && firstDinner == true)
                {
                    dtgMeals.Rows[0].Cells[4].Value = dinnerPerDiemRate.ToString();
                }
                else if (firstBreakfast == true && firstLunch == true && firstDinner == false)
                {
                    dtgMeals.Rows[0].Cells[4].Value = (breakfastPerDiemRate + lunchPerDiemRate).ToString();
                }
                else if (firstBreakfast == false && firstLunch == true && firstDinner == true)
                {
                    dtgMeals.Rows[0].Cells[4].Value = (lunchPerDiemRate + dinnerPerDiemRate).ToString();

                }
                else if (firstBreakfast == true && firstLunch == false && firstDinner == true)
                {
                    dtgMeals.Rows[0].Cells[4].Value = (breakfastPerDiemRate + dinnerPerDiemRate).ToString();
                }
                else if (firstBreakfast == true && firstLunch == true && firstDinner == true)
                {
                    dtgMeals.Rows[0].Cells[4].Value = mealsPerDiemRate.ToString();
                }

                //return Hour
                lastRow = totalDays - 1;

                if (Convert.ToInt32(returnTimeHour) >= 1 && Convert.ToInt32(returnTimeHour) < 8 && returnTimesDayTime == "AM")
                {
                    dtgMeals.Rows[lastRow].Cells[1].Value = false;
                    dtgMeals.Rows[lastRow].Cells[2].Value = false;
                    dtgMeals.Rows[lastRow].Cells[3].Value = false;
                }

                if (Convert.ToInt32(returnTimeHour) > 8 && Convert.ToInt32(returnTimeHour) != 12 && returnTimesDayTime == "AM")
                {
                    dtgMeals.Rows[lastRow].Cells[2].Value = false;
                    dtgMeals.Rows[lastRow].Cells[3].Value = false;
                }

                if (Convert.ToInt32(returnTimeHour) == 12 && returnTimesDayTime == "AM")
                {
                    dtgMeals.Rows[lastRow].Cells[1].Value = false;
                    dtgMeals.Rows[lastRow].Cells[2].Value = false;
                    dtgMeals.Rows[lastRow].Cells[3].Value = false;
                }
                if (Convert.ToInt32(returnTimeHour) == 8 && returnTimesDayTime == "AM" && Convert.ToInt32(returnTimeMinutes) > 0)
                {
                    dtgMeals.Rows[lastRow].Cells[2].Value = false;
                    dtgMeals.Rows[lastRow].Cells[3].Value = false;
                }
                else if (Convert.ToInt32(returnTimeHour) == 8 && returnTimesDayTime == "AM" && Convert.ToInt32(returnTimeMinutes) == 0)
                {
                    dtgMeals.Rows[lastRow].Cells[1].Value = false;
                    dtgMeals.Rows[lastRow].Cells[2].Value = false;
                    dtgMeals.Rows[lastRow].Cells[3].Value = false;

                }

                if (Convert.ToInt32(returnTimeHour) == 12 && returnTimesDayTime == "PM" && Convert.ToInt32(returnTimeMinutes) >= 0)
                {
                    dtgMeals.Rows[lastRow].Cells[2].Value = false;
                    dtgMeals.Rows[lastRow].Cells[3].Value = false;
                }
                if (Convert.ToInt32(returnTimeHour) >= 1 && returnTimesDayTime == "PM" && Convert.ToInt32(returnTimeHour) < 2)
                {
                    dtgMeals.Rows[lastRow].Cells[2].Value = false;
                    dtgMeals.Rows[lastRow].Cells[3].Value = false;
                }
                if (Convert.ToInt32(returnTimeHour) > 2 && Convert.ToInt32(returnTimeHour) < 8 && returnTimesDayTime == "PM")
                {
                    dtgMeals.Rows[lastRow].Cells[3].Value = false;
                }
                if (Convert.ToInt32(returnTimeHour) == 2 && Convert.ToInt32(returnTimeMinutes) > 0 && returnTimesDayTime == "PM")
                {
                    dtgMeals.Rows[lastRow].Cells[3].Value = false;
                }
                if (Convert.ToInt32(returnTimeHour) == 2 && returnTimesDayTime == "PM" && Convert.ToInt32(returnTimeMinutes) == 0)
                {
                    dtgMeals.Rows[lastRow].Cells[2].Value = false;
                    dtgMeals.Rows[lastRow].Cells[3].Value = false;
                }
                if (Convert.ToInt32(returnTimeHour) == 8 && Convert.ToInt32(returnTimeMinutes) == 0 && returnTimesDayTime == "PM")
                {
                    dtgMeals.Rows[lastRow].Cells[3].Value = false;
                }

                bool lastBreakfast = (bool)dtgMeals.Rows[lastRow].Cells[1].Value;
                bool lastLunch = (bool)dtgMeals.Rows[lastRow].Cells[2].Value;
                bool lastDinner = (bool)dtgMeals.Rows[lastRow].Cells[3].Value;

                if (lastBreakfast == false && lastLunch == false && lastDinner == false)
                {
                    dtgMeals.Rows[lastRow].Cells[4].Value = "0";
                }
                else if (lastBreakfast == true && lastLunch == false && lastDinner == false)
                {
                    dtgMeals.Rows[lastRow].Cells[4].Value = breakfastPerDiemRate.ToString();
                }
                else if (lastBreakfast == false && lastLunch == true && lastDinner == false)
                {
                    dtgMeals.Rows[lastRow].Cells[4].Value = lunchPerDiemRate.ToString();
                }
                else if (lastBreakfast == false && lastLunch == false && lastDinner == true)
                {
                    dtgMeals.Rows[lastRow].Cells[4].Value = dinnerPerDiemRate.ToString();
                }
                else if (lastBreakfast == true && lastLunch == true && lastDinner == false)
                {
                    dtgMeals.Rows[lastRow].Cells[4].Value = (breakfastPerDiemRate + lunchPerDiemRate).ToString();
                }
                else if (lastBreakfast == false && lastLunch == true && lastDinner == true)
                {
                    dtgMeals.Rows[lastRow].Cells[4].Value = (lunchPerDiemRate + dinnerPerDiemRate).ToString();

                }
                else if (lastBreakfast == true && lastLunch == false && lastDinner == true)
                {
                    dtgMeals.Rows[lastRow].Cells[4].Value = (breakfastPerDiemRate + dinnerPerDiemRate).ToString();
                }
                else if (lastBreakfast == true && lastLunch == true && lastDinner == true)
                {
                    dtgMeals.Rows[lastRow].Cells[4].Value = mealsPerDiemRate.ToString();
                }
                updateTotalMeals();
            }
        }

        private void dtgMeals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dtgMeals.CurrentCell.RowIndex;
            int columnIndex = dtgMeals.CurrentCell.ColumnIndex;
            bool rowValue = (bool)dtgMeals.CurrentCell.Value;
            if (columnIndex == 1)
            {
                if (rowValue == false)
                {
                    double rowTotal = Convert.ToInt32(dtgMeals.Rows[rowIndex].Cells[4].Value);
                    rowTotal = rowTotal + breakfastPerDiemRate;
                    dtgMeals.Rows[rowIndex].Cells[4].Value = rowTotal.ToString();
                    rowValue = true;

                }
                else
                {
                    double rowTotal = Convert.ToInt32(dtgMeals.Rows[rowIndex].Cells[4].Value);
                    rowTotal = rowTotal - breakfastPerDiemRate;
                    dtgMeals.Rows[rowIndex].Cells[4].Value = rowTotal.ToString();
                    rowValue = false;
                    //btnNextMeal.Enabled = true;
                    pbUncheckMeal.Visible = false;

                }
            }
            else if (columnIndex == 2)
            {
                if (rowValue == false)
                {
                    double rowTotal = Convert.ToInt32(dtgMeals.Rows[rowIndex].Cells[4].Value);
                    rowTotal = rowTotal + lunchPerDiemRate;
                    dtgMeals.Rows[rowIndex].Cells[4].Value = rowTotal.ToString();
                    rowValue = true;

                }
                else
                {
                    double rowTotal = Convert.ToInt32(dtgMeals.Rows[rowIndex].Cells[4].Value);
                    rowTotal = rowTotal - lunchPerDiemRate;
                    dtgMeals.Rows[rowIndex].Cells[4].Value = rowTotal.ToString();
                    rowValue = false;
                    //btnNextMeal.Enabled = true;
                    pbUncheckMeal.Visible = false;

                }

            }
            else if (columnIndex == 3)
            {

                if (rowValue == false)
                {
                    double rowTotal = Convert.ToInt32(dtgMeals.Rows[rowIndex].Cells[4].Value);
                    rowTotal = rowTotal + dinnerPerDiemRate;
                    dtgMeals.Rows[rowIndex].Cells[4].Value = rowTotal.ToString();
                    rowValue = true;

                }
                else
                {
                    double rowTotal = Convert.ToInt32(dtgMeals.Rows[rowIndex].Cells[4].Value);
                    rowTotal = rowTotal - dinnerPerDiemRate;
                    dtgMeals.Rows[rowIndex].Cells[4].Value = rowTotal.ToString();
                    rowValue = false;
                    //btnNextMeal.Enabled = true;
                    pbUncheckMeal.Visible = false;

                }
            }

            dtgMeals.CurrentCell.Value = rowValue;
            updateTotalMeals();
        }

        public void updateTotalMeals()
        {
            double totalMeals = 0;
            for (int i = 0; i < totalDays; i++)
            {

                totalMeals = totalMeals + Convert.ToDouble(dtgMeals.Rows[i].Cells[4].Value);
            }

            txtMealsTotal.Text = totalMeals.ToString();
        }

        private void rbYesProvidedMeal_CheckedChanged(object sender, EventArgs e)
        {
            pbUncheckMeal.Visible = true;
            //btnNextMeal.Enabled = false;
            CommonVariables.mcl.ProvidedMeals = true;
        }

        private void rbNoProvidedMeal_CheckedChanged(object sender, EventArgs e)
        {
            pbUncheckMeal.Visible = false;
            //btnNextMeal.Enabled = true;
        }

        private void btnNextMeal_Click(object sender, EventArgs e)
        {
            if (dtgMeals.Rows.Count > 0)
            {
                int totalBreakfast = 0;
                int totalLunch = 0;
                int totalDinner = 0;
                CommonVariables.mdcl.Clear();
                //CommonVariables.mealsClass.Lunch = 
                for (int i = 0; i < totalDays; i++)
                {
                    MealsDatecl md = new MealsDatecl();
                    md.Date = Convert.ToDateTime(dtgMeals.Rows[i].Cells[0].Value.ToString());

                    if (Convert.ToBoolean(dtgMeals.Rows[i].Cells[1].Value) == true)
                    {
                        totalBreakfast = totalBreakfast + 1;
                        md.Breakfast = true;
                    }
                    else
                    {
                        md.Breakfast = false;
                    }
                    if (Convert.ToBoolean(dtgMeals.Rows[i].Cells[2].Value) == true)
                    {
                        totalLunch = totalLunch + 1;
                        md.Lunch = true;
                    }
                    else
                    {
                        md.Lunch = false;
                    }
                    if (Convert.ToBoolean(dtgMeals.Rows[i].Cells[3].Value) == true)
                    {
                        totalDinner = totalDinner + 1;
                        md.Dinner = true;
                    }
                    else
                    {
                        md.Dinner = false;
                    }
                    CommonVariables.mdcl.Add(md);
                }

                CommonVariables.mcl.Breakfast = totalBreakfast;
                CommonVariables.mcl.Lunch = totalLunch;
                CommonVariables.mcl.Dinner = totalDinner;
                CommonVariables.mcl.ProvidedMeals = rbYesProvidedMeal.Checked;
                CommonVariables.mcl.Notes = txtMealsNotes.Text;
                CommonVariables.mcl.MealsTotal = Convert.ToDouble(txtMealsTotal.Text);
                CommonVariables.mcl.BreakfastPerDiemRate = Convert.ToDouble(txtMealsPerDiemRate.Text);
                CommonVariables.mcl.LunchPerDiemRate = Convert.ToDouble(txtLunch.Text);
                CommonVariables.mcl.DinnerPerDiemRate = Convert.ToDouble(txtDinner.Text);
                CommonVariables.mcl.TotalMealsPerDiemRate = Convert.ToDouble(lblTotalPerDiemRateValue.Text);
                CommonVariables.mcl.PerDiemLoactionZipCode = txtZipCode.Text;

                FormCollection fc = Application.OpenForms;
                Form main = new Form();
                foreach (Form frm in fc)
                {
                    string name = frm.Name;
                    if (frm.Name == "Main")
                    {
                        main = frm;
                    }
                }

                Form[] childs = main.MdiChildren;

                if (!CommonVariables.isSummary)
                {
                    if (CommonVariables.isRegistartion == true)
                    {
                        bool RegistrationFormFound = false;
                        foreach (Form child in childs)
                        {
                            string name = child.Name;
                            if (child.Name == "Registration")
                            {
                                child.Focus();
                                child.Show();

                                RegistrationFormFound = true;
                            }
                        }
                        if (!RegistrationFormFound)
                        {
                            Registration rg = new Registration();
                            rg.MdiParent = main;
                            rg.Show();
                        }
                    }
                    else if (CommonVariables.isLodging == true)
                    {
                        bool lodgingFormFound = false;
                        foreach (Form child in childs)
                        {
                            string name = child.Name;
                            if (child.Name == "Lodging")
                            {
                                child.Focus();
                                child.Show();

                                lodgingFormFound = true;
                            }
                        }
                        if (!lodgingFormFound)
                        {
                            Lodging lg = new Lodging();
                            lg.MdiParent = main;
                            lg.Show();
                        }
                    }
                    else if (CommonVariables.isCarRental == true)
                    {
                        bool carFormFound = false;
                        foreach (Form child in childs)
                        {
                            string name = child.Name;
                            if (child.Name == "CarRental")
                            {
                                child.Focus();
                                child.Show();

                                carFormFound = true;
                            }
                        }
                        if (!carFormFound)
                        {
                            CarRental cr = new CarRental();
                            cr.MdiParent = main;
                            cr.Show();
                        }
                    }
                    else if (CommonVariables.isAirFare == true)
                    {
                        bool flightFormFound = false;
                        foreach (Form child in childs)
                        {
                            string name = child.Name;
                            if (child.Name == "AirFare")
                            {
                                child.Focus();
                                child.Show();

                                flightFormFound = true;
                            }
                        }
                        if (!flightFormFound)
                        {
                            AirFare af = new AirFare();
                            af.MdiParent = main;
                            af.Show();
                        }
                    }
                    else if (CommonVariables.isMileage == true)
                    {
                        bool mileageFormFound = false;
                        foreach (Form child in childs)
                        {
                            string name = child.Name;
                            if (child.Name == "Mileage")
                            {
                                child.Focus();
                                child.Show();

                                mileageFormFound = true;
                            }
                        }
                        if (!mileageFormFound)
                        {
                            Mileage ml = new Mileage();
                            ml.MdiParent = main;
                            ml.Show();
                        }
                    }
                    else if (CommonVariables.isOtherExpenses == true)
                    {
                        bool oxFormFound = false;
                        foreach (Form child in childs)
                        {
                            string name = child.Name;
                            if (child.Name == "OtherExpenses")
                            {
                                child.Focus();
                                child.Show();

                                oxFormFound = true;
                            }
                        }
                        if (!oxFormFound)
                        {
                            OtherExpenses ox = new OtherExpenses();
                            ox.MdiParent = main;
                            ox.Show();
                        }
                    }
                    else
                    {
                        Summary sm = new Summary();
                        sm.MdiParent = main;
                        sm.Show();
                    }
                }
                else
                {
                    CommonVariables.isSummary = false;
                    Summary sm = new Summary();
                    sm.MdiParent = main;
                    sm.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter the Meals Per Diem Rate and hit Calculate");
            }
        }

        private void btnBackMeal_Click(object sender, EventArgs e)
        {
            CommonVariables.isSummary = false;
            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                }
            }

            Form[] childs = main.MdiChildren;

            int cant = Application.OpenForms.Count;
            bool FormFound = false;
            foreach (Form child in childs)
            {
                string name = child.Name;
                if (child.Name == "TravelItems")
                {
                    child.Focus();
                    child.Show();

                    FormFound = true;
                }
            }
            this.Hide();
        }

        private void btnCancelMeal_Click(object sender, EventArgs e)
        {
            CommonVariables.CancelTravel();
            if (CommonVariables.viewDetails)
            {
                this.Close();
                FormCollection fc = Application.OpenForms;
                Form main = new Form();
                foreach (Form frm in fc)
                {
                    string name = frm.Name;
                    if (frm.Name == "ViewTravel")
                    {
                        frm.Focus();
                        frm.Show();
                    }
                }
            }
        }

        /*private void Meals_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommonVariables.CancelTravel();
        }*/

        private void Meals_Load(object sender, EventArgs e)
        {
            if (CommonVariables.viewDetails)
            {
                tlNavButtons.Visible = false;

            }

        }

        public void ViewDetailsGridview()
        {
            localCon.Open();
            Guid travID = new Guid(CommonVariables.viewTravelID);
            string mealdIDString = "";
            string mealsTotal = "";
            string lunchPDR = "";
            string breakfastPDR = "";
            string dinnerPDR = "";
            string totalPDR = "";
            string zipCode = "";

            txtMealsPerDiemRate.Enabled = false;
            txtLunch.Enabled = false;
            txtDinner.Enabled = false;

            SqlCommand selMealId = new SqlCommand("SELECT [MealsID],[TotalMeals],[BreakfastPerDiemRate],[LunchPerDiemRate],[DinnerPerDiemRate],[TotalPerDiemRate],[PerDiemLoactionZipCode] FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travID + "'", localCon);
            SqlDataReader selMealIdDR = selMealId.ExecuteReader();
            if (selMealIdDR.HasRows)
            {
                while (selMealIdDR.Read())
                {
                    mealdIDString = selMealIdDR["MealsID"].ToString();
                    mealsTotal = selMealIdDR["TotalMeals"].ToString();
                    breakfastPDR = selMealIdDR["BreakfastPerDiemRate"].ToString();
                    lunchPDR = selMealIdDR["LunchPerDiemRate"].ToString();
                    dinnerPDR = selMealIdDR["DinnerPerDiemRate"].ToString();
                    totalPDR = selMealIdDR["TotalPerDiemRate"].ToString();
                    zipCode = selMealIdDR["PerDiemLoactionZipCode"].ToString();
                }
            }
            selMealIdDR.Close();
            txtMealsTotal.Text = mealsTotal;
            txtMealsPerDiemRate.Text = breakfastPDR;
            txtLunch.Text = lunchPDR;
            txtDinner.Text = dinnerPDR;
            // txtMealsTotal.Text = mealsTotal;
            txtZipCode.Text = zipCode;

            if (mealdIDString != "")
            {
                Guid mealsID = new Guid(mealdIDString);

                SqlCommand cmd = new SqlCommand("SELECT [Date],[Breaksfast],[Lunch],[Dinner],[MealDateId] FROM [TravelExpenses].[dbo].[MealDate] where MealsID = '" + mealsID + "'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    double total = 0;
                    DateTime date = Convert.ToDateTime(dr["Date"].ToString());
                    bool breakfast = Convert.ToBoolean(dr["Breaksfast"].ToString());
                    if (breakfast)
                    {
                        total = total + Convert.ToDouble(breakfastPDR);
                    }
                    bool lunch = Convert.ToBoolean(dr["Lunch"].ToString());
                    if (lunch)
                    {
                        total = total + Convert.ToDouble(lunchPDR);
                    }
                    bool dinner = Convert.ToBoolean(dr["Dinner"].ToString());
                    if (dinner)
                    {
                        total = total + Convert.ToDouble(dinnerPDR);
                    }
                    string mealdateID = dr["MealDateId"].ToString();

                    dtgMeals.Rows.Add(date.ToShortDateString(), breakfast, lunch, dinner, total, mealdateID);
                }
                dr.Close();
            }

            localCon.Close();
            btnCalculateMeals.Visible = false;
            dtgMeals.Enabled = false;
            pProvidedMeal.Enabled = false;
            tableLayoutPanel1.Enabled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            enableCalculateButton();
        }

        private void btnCalculateMeals_Click(object sender, EventArgs e)
        {
            dtgMeals.Rows.Clear();
            lunchPerDiemRate = Convert.ToDouble(txtLunch.Text);
            dinnerPerDiemRate = Convert.ToDouble(txtDinner.Text);
            breakfastPerDiemRate = Convert.ToDouble(txtMealsPerDiemRate.Text);
            mealsPerDiemRate = breakfastPerDiemRate + lunchPerDiemRate + dinnerPerDiemRate;

            if (breakfastPerDiemRate > 0 && lunchPerDiemRate > 0 && dinnerPerDiemRate > 0)
            {
                createDatagridview(mealsPerDiemRate, breakfastPerDiemRate, lunchPerDiemRate, dinnerPerDiemRate);
            }
        }

        private void enableCalculateButton()
        {
            if (txtMealsPerDiemRate.Text != "" && txtLunch.Text != "" && txtDinner.Text != "" && txtZipCode.Text != "")
            {
                btnCalculateMeals.Enabled = true;
                double perDiemTotal = Convert.ToDouble(txtMealsPerDiemRate.Text) + Convert.ToDouble(txtLunch.Text) + Convert.ToDouble(txtDinner.Text);
                lblTotalPerDiemRateValue.Text = perDiemTotal.ToString();
            }
            else
            {
                btnCalculateMeals.Enabled = false;
                lblTotalPerDiemRateValue.Text = "0";
            }
        }

        private void txtLunch_TextChanged(object sender, EventArgs e)
        {
            enableCalculateButton();
        }

        private void txtDinner_TextChanged(object sender, EventArgs e)
        {
            enableCalculateButton();
        }

        private void txtLunch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDinner_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            enableCalculateButton();
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void linkLabelMealPerDiemRate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gsa.gov/travel/plan-book/per-diem-rates");
        }

        private void Meals_VisibleChanged(object sender, EventArgs e)
        {
            if (!CommonVariables.viewDetails)
            {
                if (txtDinner.Text != "" && txtLunch.Text != "" && txtMealsPerDiemRate.Text != "" && txtZipCode.Text != "")
                {
                    dtgMeals.Rows.Clear();
                    lunchPerDiemRate = Convert.ToDouble(txtLunch.Text);
                    dinnerPerDiemRate = Convert.ToDouble(txtDinner.Text);
                    breakfastPerDiemRate = Convert.ToDouble(txtMealsPerDiemRate.Text);
                    mealsPerDiemRate = breakfastPerDiemRate + lunchPerDiemRate + dinnerPerDiemRate;

                    if (breakfastPerDiemRate > 0 && lunchPerDiemRate > 0 && dinnerPerDiemRate > 0)
                    {
                        createDatagridview(mealsPerDiemRate, breakfastPerDiemRate, lunchPerDiemRate, dinnerPerDiemRate);
                    }
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmMealsPerDiemHelp mpdr = new frmMealsPerDiemHelp();
            mpdr.ShowDialog();
        }
    }


}
