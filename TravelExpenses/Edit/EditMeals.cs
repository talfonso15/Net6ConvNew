using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelExpenses
{
    public partial class EditMeals : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid edittravelID;
        Guid mealsID;
        string departuretime;
        string returnTime;
        DateTime travelDepartureDate;
        DateTime travelReturnDate;
        int totalDays;
        int lastRow;
        bool providedMeal;
        double totalTravel = 0;
        double totalReibursement = 0;
        double oldMealTotal = 0;
        double breakfastPDRate = 0;
        double lunchPDRate = 0;
        double dinnerPDRate = 0;
        double totalPDRate = 0;
        string zipCode = "";
        bool perDiemChanged = false;

        public EditMeals()
        {
            InitializeComponent();
        }



        /*   public void createDatagridview()
           {
               TimeSpan difference = travelReturnDate.Subtract(travelDepartureDate);
               totalDays = (int)difference.TotalDays;
               totalDays = totalDays + 2;
               departuretime = departuretime.Trim();
               int longDepartureTime = departuretime.Length;
               string departureTimeHour;
               string departureTimeMinutes;
               if (longDepartureTime == 8)
               {
                   departureTimeHour = departuretime.Substring(0, 2).Trim();
                   departureTimeMinutes = departuretime.Substring(3, 2).Trim();
               }
               else
               {
                   departureTimeHour = departuretime.Substring(0, 1).Trim();
                   departureTimeMinutes = departuretime.Substring(2, 2).Trim();
               }


               string dayTimeDeparture = departuretime.Substring(5).Trim();

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
                dtgMeals.Rows.Add(row);

               string departureDate = travelDepartureDate.ToString().Substring(0, 9);
               DateTime depDate = Convert.ToDateTime(departureDate);

               for (int i = 0; i < totalDays; i++)
               {
                   dgvEditMeals.Rows.Add(depDate.ToString().Substring(0, 9), true, true, true, "40");
                   depDate = depDate.AddDays(1);
               }

               if (Convert.ToInt32(departureTimeHour) > 6 && Convert.ToInt32(departureTimeHour) < 12 && dayTimeDeparture == "AM")
               {

                   dgvEditMeals.Rows[0].Cells[1].Value = false;
               }

               if (Convert.ToInt32(departureTimeHour) == 6 && Convert.ToInt32(departureTimeMinutes) >= 0 && dayTimeDeparture == "AM")
               {

                   dgvEditMeals.Rows[0].Cells[1].Value = false;
               }

               if (Convert.ToInt32(departureTimeHour) <= 12 && dayTimeDeparture == "PM")
               {

                   dgvEditMeals.Rows[0].Cells[1].Value = false;
                   dgvEditMeals.Rows[0].Cells[2].Value = false;

                   if (Convert.ToInt32(departureTimeHour) >= 6 && Convert.ToInt32(departureTimeHour) <= 11 && dayTimeDeparture == "PM")
                   {
                       dgvEditMeals.Rows[0].Cells[3].Value = false;

                   }
               }

               if (Convert.ToInt32(departureTimeHour) == 12 && dayTimeDeparture == "PM" && Convert.ToInt32(departureTimeMinutes) > 0)
               {

                   dgvEditMeals.Rows[0].Cells[1].Value = false;
                   dgvEditMeals.Rows[0].Cells[2].Value = false;
               }
               if (Convert.ToInt32(departureTimeHour) == 6 && dayTimeDeparture == "PM" && Convert.ToInt32(departureTimeMinutes) > 0)
               {

                   dgvEditMeals.Rows[0].Cells[1].Value = false;
                   dgvEditMeals.Rows[0].Cells[2].Value = false;
                   dgvEditMeals.Rows[0].Cells[3].Value = false;

               }

               bool firstBreakfast = (bool)dgvEditMeals.Rows[0].Cells[1].Value;
               bool firstLunch = (bool)dgvEditMeals.Rows[0].Cells[2].Value;
               bool firstDinner = (bool)dgvEditMeals.Rows[0].Cells[3].Value;

               if (firstBreakfast == false && firstLunch == false && firstDinner == false)
               {
                   dgvEditMeals.Rows[0].Cells[4].Value = "0";
               }
               else if (firstBreakfast == true && firstLunch == false && firstDinner == false)
               {
                   dgvEditMeals.Rows[0].Cells[4].Value = "8";
               }
               else if (firstBreakfast == false && firstLunch == true && firstDinner == false)
               {
                   dgvEditMeals.Rows[0].Cells[4].Value = "12";
               }
               else if (firstBreakfast == false && firstLunch == false && firstDinner == true)
               {
                   dgvEditMeals.Rows[0].Cells[4].Value = "20";
               }
               else if (firstBreakfast == true && firstLunch == true && firstDinner == false)
               {
                   dgvEditMeals.Rows[0].Cells[4].Value = "20";
               }
               else if (firstBreakfast == false && firstLunch == true && firstDinner == true)
               {
                   dgvEditMeals.Rows[0].Cells[4].Value = "32";

               }
               else if (firstBreakfast == true && firstLunch == false && firstDinner == true)
               {
                   dgvEditMeals.Rows[0].Cells[4].Value = "28";
               }
               else if (firstBreakfast == true && firstLunch == true && firstDinner == true)
               {
                   dgvEditMeals.Rows[0].Cells[4].Value = "40";
               }

               //return Hour
               lastRow = totalDays - 1;

               if (Convert.ToInt32(returnTimeHour) >= 1 && Convert.ToInt32(returnTimeHour) < 8 && returnTimesDayTime == "AM")
               {
                   dgvEditMeals.Rows[lastRow].Cells[1].Value = false;
                   dgvEditMeals.Rows[lastRow].Cells[2].Value = false;
                   dgvEditMeals.Rows[lastRow].Cells[3].Value = false;
               }

               if (Convert.ToInt32(returnTimeHour) > 8 && Convert.ToInt32(returnTimeHour) != 12 && returnTimesDayTime == "AM")
               {
                   dgvEditMeals.Rows[lastRow].Cells[2].Value = false;
                   dgvEditMeals.Rows[lastRow].Cells[3].Value = false;
               }

               if (Convert.ToInt32(returnTimeHour) == 12 && returnTimesDayTime == "AM")
               {
                   dgvEditMeals.Rows[lastRow].Cells[1].Value = false;
                   dgvEditMeals.Rows[lastRow].Cells[2].Value = false;
                   dgvEditMeals.Rows[lastRow].Cells[3].Value = false;
               }
               if (Convert.ToInt32(returnTimeHour) == 8 && returnTimesDayTime == "AM" && Convert.ToInt32(returnTimeMinutes) > 0)
               {
                   dgvEditMeals.Rows[lastRow].Cells[2].Value = false;
                   dgvEditMeals.Rows[lastRow].Cells[3].Value = false;
               }
               else if (Convert.ToInt32(returnTimeHour) == 8 && returnTimesDayTime == "AM" && Convert.ToInt32(returnTimeMinutes) == 0)
               {
                   dgvEditMeals.Rows[lastRow].Cells[1].Value = false;
                   dgvEditMeals.Rows[lastRow].Cells[2].Value = false;
                   dgvEditMeals.Rows[lastRow].Cells[3].Value = false;

               }

               if (Convert.ToInt32(returnTimeHour) == 12 && returnTimesDayTime == "PM" && Convert.ToInt32(returnTimeMinutes) >= 0)
               {
                   dgvEditMeals.Rows[lastRow].Cells[2].Value = false;
                   dgvEditMeals.Rows[lastRow].Cells[3].Value = false;
               }
               if (Convert.ToInt32(returnTimeHour) >= 1 && returnTimesDayTime == "PM" && Convert.ToInt32(returnTimeHour) < 2)
               {
                   dgvEditMeals.Rows[lastRow].Cells[2].Value = false;
                   dgvEditMeals.Rows[lastRow].Cells[3].Value = false;
               }
               if (Convert.ToInt32(returnTimeHour) > 2 && Convert.ToInt32(returnTimeHour) < 8 && returnTimesDayTime == "PM")
               {
                   dgvEditMeals.Rows[lastRow].Cells[3].Value = false;
               }
               if (Convert.ToInt32(returnTimeHour) == 2 && Convert.ToInt32(returnTimeMinutes) > 0 && returnTimesDayTime == "PM")
               {
                   dgvEditMeals.Rows[lastRow].Cells[3].Value = false;
               }
               if (Convert.ToInt32(returnTimeHour) == 2 && returnTimesDayTime == "PM" && Convert.ToInt32(returnTimeMinutes) == 0)
               {
                   dgvEditMeals.Rows[lastRow].Cells[2].Value = false;
                   dgvEditMeals.Rows[lastRow].Cells[3].Value = false;
               }
               if (Convert.ToInt32(returnTimeHour) == 8 && Convert.ToInt32(returnTimeMinutes) == 0 && returnTimesDayTime == "PM")
               {
                   dgvEditMeals.Rows[lastRow].Cells[3].Value = false;
               }

               bool lastBreakfast = (bool)dgvEditMeals.Rows[lastRow].Cells[1].Value;
               bool lastLunch = (bool)dgvEditMeals.Rows[lastRow].Cells[2].Value;
               bool lastDinner = (bool)dgvEditMeals.Rows[lastRow].Cells[3].Value;

               if (lastBreakfast == false && lastLunch == false && lastDinner == false)
               {
                   dgvEditMeals.Rows[lastRow].Cells[4].Value = "0";
               }
               else if (lastBreakfast == true && lastLunch == false && lastDinner == false)
               {
                   dgvEditMeals.Rows[lastRow].Cells[4].Value = "8";
               }
               else if (lastBreakfast == false && lastLunch == true && lastDinner == false)
               {
                   dgvEditMeals.Rows[lastRow].Cells[4].Value = "12";
               }
               else if (lastBreakfast == false && lastLunch == false && lastDinner == true)
               {
                   dgvEditMeals.Rows[lastRow].Cells[4].Value = "20";
               }
               else if (lastBreakfast == true && lastLunch == true && lastDinner == false)
               {
                   dgvEditMeals.Rows[lastRow].Cells[4].Value = "20";
               }
               else if (lastBreakfast == false && lastLunch == true && lastDinner == true)
               {
                   dgvEditMeals.Rows[lastRow].Cells[4].Value = "32";

               }
               else if (lastBreakfast == true && lastLunch == false && lastDinner == true)
               {
                   dgvEditMeals.Rows[lastRow].Cells[4].Value = "28";
               }
               else if (lastBreakfast == true && lastLunch == true && lastDinner == true)
               {
                   dgvEditMeals.Rows[lastRow].Cells[4].Value = "40";
               }
               updateTotalMeals();
           }*/

        public void createDatagridview() {

            localCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT [Date],[Breaksfast],[Lunch],[Dinner],[MealDateId] FROM [TravelExpenses].[dbo].[MealDate] where MealsID = '" + mealsID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                double total = 0;
                DateTime date = Convert.ToDateTime(dr["Date"].ToString());
                bool breakfast = Convert.ToBoolean(dr["Breaksfast"].ToString());
                if (breakfast)
                {
                    total = total + breakfastPDRate;
                }
                bool lunch = Convert.ToBoolean(dr["Lunch"].ToString());
                if (lunch)
                {
                    total = total + lunchPDRate;
                }
                bool dinner = Convert.ToBoolean(dr["Dinner"].ToString());
                if (dinner)
                {
                    total = total + dinnerPDRate;
                }
                string mealdateID = dr["MealDateId"].ToString();

                dgvEditMeals.Rows.Add(date.ToShortDateString(), breakfast, lunch, dinner, total, mealdateID);
            }
            dr.Close();
            localCon.Close();
        }

        public void updateTotalMeals()
        {
            int totalMeals = 0;
            for (int i = 0; i < dgvEditMeals.Rows.Count; i++)
            {

                totalMeals = totalMeals + Convert.ToInt32(dgvEditMeals.Rows[i].Cells[4].Value);
            }

            txtMealsTotal.Text = totalMeals.ToString();

        }

        private void EditMeals_Load(object sender, EventArgs e)
        {
            edittravelID = new Guid(CommonVariables.editTravelID.ToString());
            localCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + edittravelID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    travelDepartureDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    travelReturnDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    departuretime = dr["DepartureTime"].ToString();
                    returnTime = dr["ReturnTime"].ToString();
                    totalTravel = Convert.ToDouble(dr["TotalTravelAmount"].ToString());
                    totalReibursement = Convert.ToDouble(dr["TotalTravelReimbursed"].ToString());
                }
                dr.Close();
                

                SqlCommand cmd2 = new SqlCommand("SELECT [MealsID] ,[ProvidedMeal] ,[Notes],[TotalMeals],[BreakfastPerDiemRate],[LunchPerDiemRate],[DinnerPerDiemRate],[TotalPerDiemRate],[PerDiemLoactionZipCode] FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + edittravelID + "'", localCon);
                SqlDataReader dr2 = cmd2.ExecuteReader();

                while (dr2.Read()) {
                    mealsID = new Guid(dr2["MealsID"].ToString());
                    providedMeal = Convert.ToBoolean(dr2["ProvidedMeal"].ToString());
                    txtNotes.Text = dr2["Notes"].ToString();
                    txtMealsPerDiemRate.Text = dr2["BreakfastPerDiemRate"].ToString();
                    txtLunch.Text = dr2["LunchPerDiemRate"].ToString();
                    txtDinner.Text = dr2["DinnerPerDiemRate"].ToString();
                    txtMealsTotal.Text = dr2["TotalPerDiemRate"].ToString();
                    breakfastPDRate = Convert.ToDouble(dr2["BreakfastPerDiemRate"].ToString());
                    lunchPDRate = Convert.ToDouble(dr2["LunchPerDiemRate"].ToString());
                    dinnerPDRate = Convert.ToDouble(dr2["DinnerPerDiemRate"].ToString());
                    totalPDRate = Convert.ToDouble(dr2["TotalPerDiemRate"].ToString());
                    zipCode = dr2["PerDiemLoactionZipCode"].ToString();
                    txtZipCode.Text = dr2["PerDiemLoactionZipCode"].ToString();
                    if (providedMeal)
                    {
                        rbYesProvidedMeal.Checked = true;
                        pProvidedMeals.Enabled = false;
                    }
                    else {
                        rbNoProvidedMeal.Checked = true;
                    }
                    txtMealsTotal.Text = dr2["TotalMeals"].ToString();
                    oldMealTotal = Convert.ToDouble(dr2["TotalMeals"].ToString());
                }
                dr2.Close();
            }
            localCon.Close();
            createDatagridview();
        }

        private void btnUpdateMeals_Click(object sender, EventArgs e)
        {
            int totalBreakfast = 0;
            int totalLunch = 0;
            int totalDinner = 0;
            double totalMeals = 0;
            lunchPDRate = Convert.ToDouble(txtLunch.Text);
            breakfastPDRate = Convert.ToDouble(txtMealsPerDiemRate.Text);
            dinnerPDRate = Convert.ToDouble(txtDinner.Text);
            totalPDRate = Convert.ToDouble(lblTotalPerDiemRateValue.Text);

            zipCode = txtZipCode.Text;
            localCon.Open();
            for (int i = 0; i < dgvEditMeals.Rows.Count; i++)
            {
                Guid mealDateID = new Guid(dgvEditMeals.Rows[i].Cells[5].Value.ToString());
                SqlDataAdapter upMealDate = new SqlDataAdapter();
                upMealDate.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[MealDate] SET [Breaksfast] = @Breaksfast,[Lunch] = @Lunch,[Dinner] = @Dinner WHERE MealsID = '" + mealsID +"' and MealDateId = '"+ mealDateID + "'", localCon);
                upMealDate.UpdateCommand.Parameters.Add("@Breaksfast", SqlDbType.Bit).Value = Convert.ToBoolean(dgvEditMeals.Rows[i].Cells[1].Value);
                upMealDate.UpdateCommand.Parameters.Add("@Lunch", SqlDbType.Bit).Value = Convert.ToBoolean(dgvEditMeals.Rows[i].Cells[2].Value);
                upMealDate.UpdateCommand.Parameters.Add("@Dinner", SqlDbType.Bit).Value = Convert.ToBoolean(dgvEditMeals.Rows[i].Cells[3].Value);
                upMealDate.UpdateCommand.ExecuteNonQuery();



                if (Convert.ToBoolean(dgvEditMeals.Rows[i].Cells[1].Value) == true)
                {
                    totalBreakfast = totalBreakfast + 1;
                }
                if (Convert.ToBoolean(dgvEditMeals.Rows[i].Cells[2].Value) == true)
                {
                    totalLunch = totalLunch + 1;
                }
                if (Convert.ToBoolean(dgvEditMeals.Rows[i].Cells[3].Value) == true)
                {
                    totalDinner = totalDinner + 1;
                }
            }
            totalMeals = Convert.ToDouble(txtMealsTotal.Text);

            
            SqlDataAdapter cmdEditMeals = new SqlDataAdapter();
            if (perDiemChanged)
            {
                cmdEditMeals.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Meals] SET [Breakfast] = @Breakfast,[Lunch] = @Lunch,[Dinner] = @Dinner,[ProvidedMeal] = @ProvidedMeal,[TotalMeals] = @TotalMeals,[Notes] = @Notes,[BreakfastPerDiemRate] = @BreakfastPerDiemRate,[LunchPerDiemRate] = @LunchPerDiemRate,[DinnerPerDiemRate] = @DinnerPerDiemRate,[TotalPerDiemRate] = @TotalPerDiemRate,[PerDiemLoactionZipCode] = @PerDiemLoactionZipCode WHERE MealsID = '" + mealsID + "'  AND TravelID = '" + edittravelID + "'", localCon);
                cmdEditMeals.UpdateCommand.Parameters.Add("@Breakfast", SqlDbType.Int).Value = totalBreakfast;
                cmdEditMeals.UpdateCommand.Parameters.Add("@Lunch", SqlDbType.Int).Value = totalLunch;
                cmdEditMeals.UpdateCommand.Parameters.Add("@Dinner", SqlDbType.Int).Value = totalDinner;
                cmdEditMeals.UpdateCommand.Parameters.Add("@TotalMeals", SqlDbType.Float).Value = totalMeals;
                cmdEditMeals.UpdateCommand.Parameters.Add("@BreakfastPerDiemRate", SqlDbType.Float).Value = breakfastPDRate;
                cmdEditMeals.UpdateCommand.Parameters.Add("@LunchPerDiemRate", SqlDbType.Float).Value = lunchPDRate;
                cmdEditMeals.UpdateCommand.Parameters.Add("@DinnerPerDiemRate", SqlDbType.Float).Value = dinnerPDRate;
                cmdEditMeals.UpdateCommand.Parameters.Add("@TotalPerDiemRate", SqlDbType.Float).Value = totalPDRate;
                cmdEditMeals.UpdateCommand.Parameters.Add("@PerDiemLoactionZipCode", SqlDbType.NVarChar).Value = zipCode;

                if (rbYesProvidedMeal.Checked)
                {
                    cmdEditMeals.UpdateCommand.Parameters.Add("@ProvidedMeal", SqlDbType.Bit).Value = true;
                }
                else if (rbNoProvidedMeal.Checked)
                {
                    cmdEditMeals.UpdateCommand.Parameters.Add("@ProvidedMeal", SqlDbType.Bit).Value = false;
                }
                cmdEditMeals.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtNotes.Text;
            }
            else 
            {
                cmdEditMeals.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Meals] SET [Breakfast] = @Breakfast,[Lunch] = @Lunch,[Dinner] = @Dinner,[ProvidedMeal] = @ProvidedMeal,[TotalMeals] = @TotalMeals,[Notes] = @Notes,[PerDiemLoactionZipCode] = @PerDiemLoactionZipCode WHERE MealsID = '" + mealsID + "'  AND TravelID = '" + edittravelID + "'", localCon);
                cmdEditMeals.UpdateCommand.Parameters.Add("@Breakfast", SqlDbType.Int).Value = totalBreakfast;
                cmdEditMeals.UpdateCommand.Parameters.Add("@Lunch", SqlDbType.Int).Value = totalLunch;
                cmdEditMeals.UpdateCommand.Parameters.Add("@Dinner", SqlDbType.Int).Value = totalDinner;
                cmdEditMeals.UpdateCommand.Parameters.Add("@TotalMeals", SqlDbType.Float).Value = totalMeals;
                cmdEditMeals.UpdateCommand.Parameters.Add("@PerDiemLoactionZipCode", SqlDbType.NVarChar).Value = zipCode;

                if (rbYesProvidedMeal.Checked)
                {
                    cmdEditMeals.UpdateCommand.Parameters.Add("@ProvidedMeal", SqlDbType.Bit).Value = true;
                }
                else if (rbNoProvidedMeal.Checked)
                {
                    cmdEditMeals.UpdateCommand.Parameters.Add("@ProvidedMeal", SqlDbType.Bit).Value = false;
                }
                cmdEditMeals.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtNotes.Text;
            }
            int ru = cmdEditMeals.UpdateCommand.ExecuteNonQuery();
            if (ru > 0) {
                totalTravel = totalTravel - oldMealTotal;
                totalTravel = totalTravel + totalMeals;
                totalReibursement = totalReibursement - oldMealTotal;
                totalReibursement = totalReibursement + totalMeals;

                SqlDataAdapter upTravel = new SqlDataAdapter();
                upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed WHERE TravelID ='" + edittravelID + "'", localCon);
                upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = totalTravel;
                upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = totalReibursement;
                int rut = upTravel.UpdateCommand.ExecuteNonQuery();
                if (rut > 0)
                {
                    MessageBox.Show("The meals have been updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (backgroundWorker1.IsBusy != true)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
            }
            localCon.Close();
            closeAll();
        }

        private void dgvEditMeals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvEditMeals.CurrentCell.RowIndex;
            int columnIndex = dgvEditMeals.CurrentCell.ColumnIndex;
            bool rowValue = (bool)dgvEditMeals.CurrentCell.Value;
            if (columnIndex == 1)
            {
                if (rowValue == false)
                {
                    double rowTotal = Convert.ToInt32(dgvEditMeals.Rows[rowIndex].Cells[4].Value);
                    rowTotal = rowTotal + breakfastPDRate;
                    dgvEditMeals.Rows[rowIndex].Cells[4].Value = rowTotal.ToString();
                    rowValue = true;

                }
                else
                {
                    double rowTotal = Convert.ToInt32(dgvEditMeals.Rows[rowIndex].Cells[4].Value);
                    rowTotal = rowTotal - breakfastPDRate;
                    dgvEditMeals.Rows[rowIndex].Cells[4].Value = rowTotal.ToString();
                    rowValue = false;
                    
                    

                }
            }
            else if (columnIndex == 2)
            {
                if (rowValue == false)
                {
                    double rowTotal = Convert.ToInt32(dgvEditMeals.Rows[rowIndex].Cells[4].Value);
                    rowTotal = rowTotal + lunchPDRate;
                    dgvEditMeals.Rows[rowIndex].Cells[4].Value = rowTotal.ToString();
                    rowValue = true;

                }
                else
                {
                    double rowTotal = Convert.ToInt32(dgvEditMeals.Rows[rowIndex].Cells[4].Value);
                    rowTotal = rowTotal - lunchPDRate;
                    dgvEditMeals.Rows[rowIndex].Cells[4].Value = rowTotal.ToString();
                    rowValue = false;

                }

            }
            else if (columnIndex == 3)
            {

                if (rowValue == false)
                {
                    double rowTotal = Convert.ToInt32(dgvEditMeals.Rows[rowIndex].Cells[4].Value);
                    rowTotal = rowTotal + dinnerPDRate;
                    dgvEditMeals.Rows[rowIndex].Cells[4].Value = rowTotal.ToString();
                    rowValue = true;

                }
                else
                {
                    double rowTotal = Convert.ToInt32(dgvEditMeals.Rows[rowIndex].Cells[4].Value);
                    rowTotal = rowTotal - dinnerPDRate;
                    dgvEditMeals.Rows[rowIndex].Cells[4].Value = rowTotal.ToString();
                    rowValue = false;
                    

                }
            }

            dgvEditMeals.CurrentCell.Value = rowValue;
            updateTotalMeals();
        }

        private void btnCancelUpdateMeals_Click(object sender, EventArgs e)
        {
            closeAll();
        }

        public void closeAll()
        {

            this.Close();
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "SelectItemsEdit")
                {
                    frm.Focus();
                    frm.Show();
                }
            }
        }

        private void txtMealsPerDiemRate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMealsPerDiemRate_TextChanged(object sender, EventArgs e)
        {
            perDiemChanged = false;
            enableCalculateButton();

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

        private void txtLunch_TextChanged(object sender, EventArgs e)
        {
            perDiemChanged = false;
            enableCalculateButton();
        }

        private void txtDinner_TextChanged(object sender, EventArgs e)
        {
            perDiemChanged = false;
            enableCalculateButton();
        }

        private void btnCalculateMeals_Click(object sender, EventArgs e)
        {
            breakfastPDRate = Convert.ToDouble(txtMealsPerDiemRate.Text);
            lunchPDRate = Convert.ToDouble(txtLunch.Text);
            dinnerPDRate = Convert.ToDouble(txtDinner.Text);
            totalPDRate = Convert.ToDouble(txtMealsTotal.Text);
            double grandTotal = 0;

            for (int i = 0; i < dgvEditMeals.Rows.Count; i++)
            {
                double rowTotal = 0;
                bool breakfastChecked = Convert.ToBoolean(dgvEditMeals.Rows[i].Cells[1].Value);
                if (breakfastChecked)
                {
                    rowTotal += breakfastPDRate;
                }
                bool lunchChecked = Convert.ToBoolean(dgvEditMeals.Rows[i].Cells[2].Value);
                if (lunchChecked)
                {
                    rowTotal += lunchPDRate;
                }
                bool dinnerChecked = Convert.ToBoolean(dgvEditMeals.Rows[i].Cells[3].Value);
                if (dinnerChecked)
                {
                    rowTotal += dinnerPDRate;
                }
                dgvEditMeals.Rows[i].Cells[4].Value = rowTotal.ToString();
                grandTotal += rowTotal;
            }

            txtMealsTotal.Text = grandTotal.ToString();
            perDiemChanged = true;
        }

        private void linkLabelMealPerDiemRate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gsa.gov/travel/plan-book/per-diem-rates");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CommonVariables.sendChangesNotification(edittravelID);
        }
    }
}
