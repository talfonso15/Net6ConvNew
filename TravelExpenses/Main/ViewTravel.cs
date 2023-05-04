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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.xml;
using System.IO;

namespace TravelExpenses
{
    public partial class ViewTravel : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid travelID = new Guid(CommonVariables.viewTravelID);
        bool meals = false;
        bool reg = false;
        bool car = false;
        bool flight = false;
        bool milage = false;
        bool otherExp = false;
        bool lodging = false;
        double travelTotal = 0;

        int carCounts = 0;
        int airfareCounts = 0;
        int lodgingsCounts = 0;
        int otherExpensesCount = 0;
        
        public ViewTravel()
        {
            InitializeComponent();
        }

        private void ViewTravel_Load(object sender, EventArgs e)
        {
            Guid userID = new Guid(CommonVariables.viewTravelUserID);
            //Guid travelID = new Guid(CommonVariables.viewTravelID);
            double travelACC = 0;
            double training = 0;
            CommonVariables.viewDetails = true;
            localCon.Open();

            SqlCommand cmdTravel = new SqlCommand("SELECT a.[TravelID] as TravelID,a.[DepartureTime] as DepartureTime ,a.[DepartureDate] as DepartureDate ,a.[ReturnTime] as ReturnTime,a.[ReturnDate] as ReturnDate ,a.[TravelEvent] as TravelEvent ,a.[TravelPurpose] as TravelPurpose,a.[Origin] as Origin,a.[Destination] as Destination,a.[TravelState] as TravelState,a.[TotalTravelAmount] as TotalTravelAmount,a.[TotalTravelReimbursed] as TotalTravelReimbursed,a.[Melas] as Melas,a.[AirFare] as AirFare,a.[Mileage] as Mileage,a.[Registration] as Registration,a.[Lodging] as Lodging,a.[CarRental] as CarRental,a.[OtherExpenses] as OtherExpenses,a.[Notes] as Notes,b.Status as Status FROM [dbo].[Travel] as a  inner join TravelExpenses.dbo.TravelStatus as b on a.TravelID = b.TravelID where a.TravelID = '" + travelID + "'", localCon);
            SqlDataReader cmdTravelDR = cmdTravel.ExecuteReader();
            while (cmdTravelDR.Read())
            {
                lblEventValue.Text = cmdTravelDR["TravelEvent"].ToString();
                lblPurposeValue.Text = cmdTravelDR["TravelPurpose"].ToString();
                DateTime depDate = Convert.ToDateTime( cmdTravelDR["DepartureDate"].ToString());
                lblDepartureDateValue.Text = depDate.ToShortDateString();
                lblDepartureTimeValue.Text = cmdTravelDR["DepartureTime"].ToString();
                DateTime retDate = Convert.ToDateTime(cmdTravelDR["ReturnDate"].ToString());
                lblReturnDateValue.Text = retDate.ToShortDateString();
                lblReturnTimeValue.Text = cmdTravelDR["ReturnTime"].ToString();
                lblOriginValue.Text = cmdTravelDR["Origin"].ToString();
                lblDestinationValue.Text = cmdTravelDR["Destination"].ToString();
                lblTravelStateValue.Text = cmdTravelDR["TravelState"].ToString();
                lblTravelStatusValue.Text = cmdTravelDR["Status"].ToString();
                lblTravelTotalValue.Text = cmdTravelDR["TotalTravelAmount"].ToString();
                travelTotal = Convert.ToDouble(cmdTravelDR["TotalTravelAmount"].ToString());
                lblReimbursementValue.Text = cmdTravelDR["TotalTravelReimbursed"].ToString();
                meals = Convert.ToBoolean(cmdTravelDR["Melas"].ToString());
                reg = Convert.ToBoolean(cmdTravelDR["Registration"].ToString());
                car = Convert.ToBoolean(cmdTravelDR["CarRental"].ToString());
                flight = Convert.ToBoolean(cmdTravelDR["AirFare"].ToString());
                milage = Convert.ToBoolean(cmdTravelDR["Mileage"].ToString());
                otherExp = Convert.ToBoolean(cmdTravelDR["OtherExpenses"].ToString());
                lodging = Convert.ToBoolean(cmdTravelDR["Lodging"].ToString());

                travelACC = travelTotal;

            }
            cmdTravelDR.Close();

            SqlCommand cmdUser = new SqlCommand("SELECT [Name],[LastName],[District],[Department] FROM [TravelExpenses].[dbo].[User] where UserID = '" + userID + "'", localCon);
            SqlDataReader cmdUserDR = cmdUser.ExecuteReader();
            while (cmdUserDR.Read())
            {
                lblNameValue.Text = cmdUserDR["Name"].ToString() + " " + cmdUserDR["LastName"].ToString();
                lblDistrictValue.Text = cmdUserDR["District"].ToString();
                lblDepartmentValue.Text = cmdUserDR["Department"].ToString();
            }
            cmdUserDR.Close();

            if (meals)
            {
                SqlCommand meals = new SqlCommand("SELECT [TotalMeals],[Notes] FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travelID +"'", localCon);
                SqlDataReader mealsDR = meals.ExecuteReader();
                while (mealsDR.Read())
                {
                    lblMealsCost.Text = mealsDR["TotalMeals"].ToString();
                    txtMealsNotes.Text = mealsDR["Notes"].ToString();
                }
                mealsDR.Close();
                lblMeals.Enabled = true;
                btnSaveMealsNotes.Visible = true;
            }
            if (reg)
            {

                SqlCommand cmdReg = new SqlCommand("SELECT [RegistrationAMount],[Notes] FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + travelID +"'", localCon);
                SqlDataReader cmdRegDR = cmdReg.ExecuteReader();
                while (cmdRegDR.Read())
                {
                    lblRegistrationCost.Text = cmdRegDR["RegistrationAMount"].ToString();
                    txtRegistrationNotes.Text = cmdRegDR["Notes"].ToString();

                    training = Convert.ToDouble(cmdRegDR["RegistrationAMount"].ToString());
                    travelACC = travelACC - training;
                    if (travelACC < 0)
                    {
                        travelACC = travelACC * -1;
                    }
                }
                cmdRegDR.Close();
                lblResgistration.Enabled = true;
                btnSaveRegistrationNotes.Visible = true;
                
            }
            if (car)
            {
                double carAmount = 0;
                string carNotes = "";

                SqlCommand cmdCar = new SqlCommand("SELECT [TotalCarRental],[Notes] FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + travelID + "'", localCon);
                SqlDataReader cmdCarDR = cmdCar.ExecuteReader();

                while (cmdCarDR.Read())
                {
                    carAmount = carAmount + Convert.ToDouble(cmdCarDR["TotalCarRental"].ToString());
                    carNotes = carNotes + " " + cmdCarDR["Notes"].ToString();
                    carCounts++;
                }
                cmdCarDR.Close();
                lblCarRentalCost.Text = carAmount.ToString();
                txtCarRentalNotes.Text = carNotes;
                lblCarRental.Enabled = true;
                btnCarNotes.Visible = true;
            }

            if (flight)
            {
                double flightAmount = 0;
                string flightNotes = "";
                SqlCommand cmdFlight = new SqlCommand("SELECT  [AirFareTotal],[Notes] FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '"+ travelID +"'", localCon);
                SqlDataReader cmdFlightDR = cmdFlight.ExecuteReader();

                while (cmdFlightDR.Read())
                {
                    flightAmount = flightAmount + Convert.ToDouble(cmdFlightDR["AirFareTotal"].ToString());
                    flightNotes = flightNotes + " " + cmdFlightDR["Notes"].ToString();
                    airfareCounts++;
                }
                cmdFlightDR.Close();
                lblAirfareCost.Text = flightAmount.ToString();
                txtFlightNotes.Text = flightNotes;
                lblAirfare.Enabled = true;
                btnAirfareNotes.Visible = true;
            }
            if (milage)
            {
                SqlCommand cmdMil = new SqlCommand("SELECT [TotalMileage] ,[Notes] FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + travelID +"'", localCon);
                SqlDataReader cmdMilDR = cmdMil.ExecuteReader();

                while (cmdMilDR.Read())
                {
                    lblMilageCost.Text = cmdMilDR["TotalMileage"].ToString();
                    txtMileageNotes.Text = cmdMilDR["Notes"].ToString();
                }
                cmdMilDR.Close();
                lblMileage.Enabled = true;
                btnMileageSaveNotes.Visible = true;
            }
            if (otherExp)
            {
                double oeTotal = 0;
                string oeNotes = "";
                SqlCommand cmdOE = new SqlCommand("SELECT [Amount] , [Notes] FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + travelID + "'", localCon);
                SqlDataReader cmdOEDR = cmdOE.ExecuteReader();

                while (cmdOEDR.Read())
                {
                    oeTotal = oeTotal + Convert.ToDouble(cmdOEDR["Amount"].ToString());
                    oeNotes = oeNotes + " " + cmdOEDR["Notes"].ToString();
                    otherExpensesCount++;
                }
                cmdOEDR.Close();
                lblOtherExpensesCost.Text = oeTotal.ToString();
                txtOtherExpensesNotes.Text = oeNotes;
                lblOtherExpenses.Enabled = true;
                btnNoteSaveOtherExpense.Visible = true;
            }
            if (lodging)
            {
                double lodTotal = 0;
                string lodNotes = "";
                SqlCommand cmdLod = new SqlCommand("SELECT [TotalLodging] ,[Notes] FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '" + travelID + "'", localCon);
                SqlDataReader cmdLodDR = cmdLod.ExecuteReader();

                while (cmdLodDR.Read())
                {
                    lodTotal = lodTotal + Convert.ToDouble( cmdLodDR["TotalLodging"].ToString());
                    lodNotes = lodNotes + " " + cmdLodDR["Notes"].ToString();
                    lodgingsCounts++;
                }
                cmdLodDR.Close();
                lblLodgingCost.Text = lodTotal.ToString();
                txtLodgingNotes.Text = lodNotes;
                lblLodging.Enabled = true;
                btnLosgingSaveNotes.Visible = true;
            }
            lblTraining5500Value.Text = training.ToString();
            lblTravel4000Value.Text = travelACC.ToString();

            SqlCommand sign = new SqlCommand("SELECT [UserType] FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' AND TravelID = '"+ travelID + "'", localCon);
            SqlDataReader signDR = sign.ExecuteReader();
            bool isFirst = true;
            while (signDR.Read())
            {
                if (isFirst)
                {
                    lblSignatures.Text = signDR["UserType"].ToString();
                    isFirst = false;
                }
                else
                {
                    lblSignatures.Text += " ," + signDR["UserType"].ToString();
                }
            }
            signDR.Close();

            localCon.Close();
        }

        private void lblMeals_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Meals ml = new Meals();
            ml.Text = "View Meals";
            ml.ShowDialog();
        }

        private void lblResgistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration rg = new Registration();
            rg.Text = "View Registration";
            rg.ShowDialog();
        }

        private void lblCarRental_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EditCarRental cr = new EditCarRental();
            cr.Text = "View Car";
            cr.ShowDialog();
        }

        private void lblAirfare_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EditAirFare af = new EditAirFare();
            af.Text = "View Airfare";
            af.ShowDialog();
        }

        private void lblLodging_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EditLodging ld = new EditLodging();
            ld.Text = "View Lodgings";
            ld.ShowDialog();
        }

        private void lblMileage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EditMileage ml = new EditMileage();
            ml.Text = "View Mileage";
            ml.ShowDialog();
        }

        private void lblOtherExpenses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            EditOtherExpenses oe = new EditOtherExpenses();
            oe.Text = "View Other Expenses";
            oe.ShowDialog();
        }

        private void ViewTravel_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            CommonVariables.viewDetails = false;
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
            foreach (Form child in childs)
            {
                string name = child.Name;
                if (child.Name == "Supervisor")
                {
                    child.Focus();
                    child.Show();
                }
                else if (child.Name == "Admin")
                {
                    child.Focus();
                    child.Show();
                }
                else if (child.Name == "ListAllTravels")
                {
                    child.Focus();
                    child.Show();
                }
                else if (child.Name == "SuperAdminTravels")
                {
                    child.Focus();
                    child.Show();
                }
            }
        }

        private void btnSaveMealsNotes_Click(object sender, EventArgs e)
        {
            try
            {
                localCon.Open();
                SqlDataAdapter upmeals = new SqlDataAdapter();
                upmeals.UpdateCommand = new SqlCommand("UPDATE [dbo].[Meals] SET [Notes] = @Notes WHERE TravelID = '" + travelID + "'", localCon);
                upmeals.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtMealsNotes.Text;
                int row = upmeals.UpdateCommand.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Meals notes updated");
                }
                localCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                localCon.Close();
            }
        }

        private void btnSaveRegistrationNotes_Click(object sender, EventArgs e)
        {
            try
            {
                localCon.Open();
                SqlDataAdapter upRegis = new SqlDataAdapter();
                upRegis.UpdateCommand = new SqlCommand("UPDATE [dbo].[Registration] SET [Notes] = @Notes WHERE TravelID = '"+ travelID +"'", localCon);
                upRegis.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtRegistrationNotes.Text;
                int row = upRegis.UpdateCommand.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Registration notes updated");
                }
                localCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCarNotes_Click(object sender, EventArgs e)
        {
            if (carCounts > 1)
            {
                CarRentalSelection cs = new CarRentalSelection();
                cs.ShowDialog();
                try
                {
                    localCon.Open();
                    SqlDataAdapter upCar = new SqlDataAdapter();
                    upCar.UpdateCommand = new SqlCommand("UPDATE [dbo].[CarRental] SET [Notes] = @Notes WHERE CarRentalID = '" + CommonVariables.carRentalSelId + "'", localCon);
                    upCar.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtCarRentalNotes.Text;
                    int row = upCar.UpdateCommand.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Car Rental notes updated");
                    }
                    localCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    localCon.Close();
                }
            }
            else
            {
                try
                {
                    localCon.Open();
                    SqlDataAdapter upCar = new SqlDataAdapter();
                    upCar.UpdateCommand = new SqlCommand("UPDATE [dbo].[CarRental] SET [Notes] = @Notes WHERE TravelID = '" + travelID + "'", localCon);
                    upCar.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtCarRentalNotes.Text;
                    int row = upCar.UpdateCommand.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Car Rental notes updated");
                    }
                    localCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    localCon.Close();
                }
            }
        }

        private void btnAirfareNotes_Click(object sender, EventArgs e)
        {
            if (airfareCounts > 1)
            {
                AirfareSelection asel = new AirfareSelection();
                asel.ShowDialog();

                try
                {
                    Guid selairid = new Guid(CommonVariables.airfareSelId);
                    localCon.Open();
                    SqlDataAdapter upFlight = new SqlDataAdapter();
                    upFlight.UpdateCommand = new SqlCommand("UPDATE [dbo].[AirFare] SET [Notes] = @Notes WHERE AirFareID = '" + selairid + "'", localCon);
                    upFlight.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtFlightNotes.Text;
                    int row = upFlight.UpdateCommand.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Airfare notes updated");
                    }
                    localCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    localCon.Close();
                }
            }
            else
            {
                try
                {
                    localCon.Open();
                    SqlDataAdapter upFlight = new SqlDataAdapter();
                    upFlight.UpdateCommand = new SqlCommand("UPDATE [dbo].[AirFare] SET [Notes] = @Notes WHERE TravelID = '" + travelID + "'", localCon);
                    upFlight.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtFlightNotes.Text;
                    int row = upFlight.UpdateCommand.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Airfare notes updated");
                    }
                    localCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    localCon.Close();
                }
            }
        }

        private void btnLosgingSaveNotes_Click(object sender, EventArgs e)
        {
            if (lodgingsCounts > 1)
            {
                LodgingSelection ls = new LodgingSelection();
                ls.ShowDialog();

                try
                {
                    localCon.Open();
                    SqlDataAdapter upLodg = new SqlDataAdapter();
                    upLodg.UpdateCommand = new SqlCommand("UPDATE [dbo].[Lodging] SET  [Notes] = @Notes WHERE LodgingID = '" + CommonVariables.lodgingSelId + "'", localCon);
                    upLodg.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtLodgingNotes.Text;
                    int row = upLodg.UpdateCommand.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Lodging notes updated");
                    }
                    localCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    localCon.Close();
                }
            }
            else
            {
                try
                {
                    localCon.Open();
                    SqlDataAdapter upLodg = new SqlDataAdapter();
                    upLodg.UpdateCommand = new SqlCommand("UPDATE [dbo].[Lodging] SET  [Notes] = @Notes WHERE TravelID = '"+ travelID +"'", localCon);
                    upLodg.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtLodgingNotes.Text;
                    int row = upLodg.UpdateCommand.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Lodging notes updated");
                    }
                    localCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    localCon.Close();
                }
            }
        }

        private void btnNoteSaveOtherExpense_Click(object sender, EventArgs e)
        {
            if (otherExpensesCount > 1)
            {
                OtherExpensesSelection oe = new OtherExpensesSelection();
                oe.ShowDialog();

                try
                {
                    localCon.Open();
                    SqlDataAdapter upOE = new SqlDataAdapter();
                    upOE.UpdateCommand = new SqlCommand("UPDATE [dbo].[OtherExpenses]  SET [Notes] = @Notes WHERE OtherExpensesID = '" + CommonVariables.otherExpselId + "'", localCon);
                    upOE.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtOtherExpensesNotes.Text;
                    int row = upOE.UpdateCommand.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Other Expenses notes updated");
                    }
                    localCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    localCon.Close();
                }
            }
            else
            {
                try
                {
                    localCon.Open();
                    SqlDataAdapter upOE = new SqlDataAdapter();
                    upOE.UpdateCommand = new SqlCommand("UPDATE [dbo].[OtherExpenses]  SET [Notes] = @Notes WHERE TravelID = '"+ travelID +"'", localCon);
                    upOE.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtOtherExpensesNotes.Text;
                    int row = upOE.UpdateCommand.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Other Expenses notes updated");
                    }
                    localCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    localCon.Close();
                }
            }
        }

        private void btnMileageSaveNotes_Click(object sender, EventArgs e)
        {
            try
            {
                localCon.Open();
                SqlDataAdapter upMileage = new SqlDataAdapter();
                upMileage.UpdateCommand = new SqlCommand("UPDATE [dbo].[Mileage] SET [Notes] = @Notes WHERE TravelID = '"+ travelID +"'", localCon);
                upMileage.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtMileageNotes.Text;
                int row = upMileage.UpdateCommand.ExecuteNonQuery();
                if (row > 0)
                {
                    MessageBox.Show("Mileage notes updated");
                }
                localCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                localCon.Close();
            }
        }

        private void btnStatusSteps_Click(object sender, EventArgs e)
        {
            ReviewSteps rs = new ReviewSteps();
            rs.ShowDialog();
        }
    }
}
