using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TravelExpenses
{
    public partial class CalculatePerDiem : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        int totalDays;
        int lastRow;
        double mealsPerDiemRate = 0;
        double breakfastPerDiemRate = 0;
        double lunchPerDiemRate = 0;
        double dinnerPerDiemRate = 0;
        public CalculatePerDiem()
        {
            InitializeComponent();
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

        public void createDatagridview(double mealsPerDiemRate, double breakfastPerDiemRate, double lunchPerDiemRate, double dinnerPerDiemRate)
        {

            if (!CommonVariables.viewDetails)
            {
                string departureDate = "";
                string returnDate = "";
                string departureTime = "";
                string returnTime = "";

                departureDate = dtpDepartureDate.Value.ToShortDateString();
                returnDate = dtpReturnDate.Value.ToShortDateString();
                departureTime = dtpDepartureTime.Value.ToShortTimeString();
                returnTime = dtpReturnTime.Value.ToShortTimeString();

                //TimeSpan difference = CommonVariables.travelReturnDate.Subtract(CommonVariables.travelDepartureDate);
                TimeSpan difference = Convert.ToDateTime(returnDate).Subtract(Convert.ToDateTime(departureDate));
                totalDays = (int)difference.TotalDays;
                totalDays = totalDays + 1;
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

        public void updateTotalMeals()
        {
            double totalMeals = 0;
            for (int i = 0; i < totalDays; i++)
            {

                totalMeals = totalMeals + Convert.ToDouble(dtgMeals.Rows[i].Cells[4].Value);
            }

            txtMealsTotal.Text = totalMeals.ToString();
        }

        private void enableCalculateButton()
        {
            if (txtMealsPerDiemRate.Text != "" && txtLunch.Text != "" && txtDinner.Text != "")
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

        private void txtMealsPerDiemRate_TextChanged(object sender, EventArgs e)
        {
            enableCalculateButton();
        }

        private void txtLunch_TextChanged(object sender, EventArgs e)
        {
            enableCalculateButton();
        }

        private void txtDinner_TextChanged(object sender, EventArgs e)
        {
            enableCalculateButton();
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
                    // pbUncheckMeal.Visible = false;

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
                    // pbUncheckMeal.Visible = false;

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
                    //pbUncheckMeal.Visible = false;

                }
            }

            dtgMeals.CurrentCell.Value = rowValue;
            updateTotalMeals();
        }

        private void btnCancelUpdateMeals_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelMealPerDiemRate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gsa.gov/travel/plan-book/per-diem-rates");
        }
    }
}
