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
using System.Globalization;

namespace TravelExpenses
{
    public partial class SelectItemsEdit : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid edittravelID;
        int quantItems = 0;
        DateTime depDate = DateTime.Today;
        DateTime retDate = DateTime.Today;
        DateTime depTime = DateTime.Today;
        DateTime retTime = DateTime.Today;
        public SelectItemsEdit()
        {
            InitializeComponent();
        }

        private void SelectItemsEdit_Load(object sender, EventArgs e)
        {
            edittravelID = new Guid(CommonVariables.editTravelID.ToString());
            localCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '"+ edittravelID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dtpDepartureDate.Value = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    dtpDepartureTime.Value  = Convert.ToDateTime(dr["DepartureTime"].ToString());
                    depTime = Convert.ToDateTime(dr["DepartureTime"].ToString());
                    dtpReturnDate.Value = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    dtpReturnTime.Value  = Convert.ToDateTime(dr["ReturnTime"].ToString());
                    retTime = Convert.ToDateTime(dr["ReturnTime"].ToString());
                    int i = cbTravelEvent.Items.Count - 1;
                    while (i > 0) {
                        if (cbTravelEvent.Items[i].ToString() == dr["TravelEvent"].ToString())
                        {
                            cbTravelEvent.SelectedItem = cbTravelEvent.Items[i];
                            break;
                        }
                        i--;
                    }
                    if (cbTravelEvent.SelectedItem == null && dr["TravelEvent"].ToString() != "")
                    {
                        txtOtherEvent.Text = dr["TravelEvent"].ToString();
                        txtOtherEvent.Enabled = true;
                        cbTravelEvent.SelectedItem = "Other";
                    }

                    int j = cbTravelPurpose.Items.Count - 1;
                    while (j > 0)
                    {
                        if (cbTravelPurpose.Items[j].ToString() == dr["TravelPurpose"].ToString())
                        {
                            cbTravelPurpose.SelectedItem = cbTravelPurpose.Items[j];
                            break;
                        }
                        j--;
                    }
                    if (cbTravelPurpose.SelectedItem == null && dr["TravelPurpose"].ToString() != "")
                    {
                        txtOtherPurpose.Text = dr["TravelPurpose"].ToString();
                        txtOtherPurpose.Enabled = true;
                        cbTravelPurpose.SelectedItem = "Other";
                    }
                    txtOrigin.Text = dr["Origin"].ToString();
                    txtDestination.Text = dr["Destination"].ToString();
                    int l = cbTravelState.Items.Count - 1;
                    while (l > 0)
                    {
                        if (cbTravelState.Items[l].ToString() == dr["TravelState"].ToString())
                        {
                            cbTravelState.SelectedItem = cbTravelState.Items[l];
                            break;
                        }
                        l--;
                    }
                    txtNotes.Text = dr["Notes"].ToString();
                    lblTravelTotalAmount.Text = dr["TotalTravelAmount"].ToString();
                    lblTravelReimbAmount.Text = dr["TotalTravelReimbursed"].ToString();

                    //Count the items in the travel
                    if (dr["Melas"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }
                    if (dr["Registration"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }
                    if (dr["Lodging"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }
                    if (dr["CarRental"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }
                    if (dr["AirFare"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }
                    if (dr["Mileage"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }
                    if (dr["OtherExpenses"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }


                    //setting the delete and edit buttons
                        if (dr["Melas"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteMeals.Enabled = true;
                        }
                        btnEditMeals.Enabled = true;
                        lblMeals.ForeColor = System.Drawing.Color.Green;
                    }
                    else {
                        lblMeals.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dr["Registration"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteRegistration.Enabled = true;
                        }
                        btnEditRegistration.Enabled = true;
                        lblRegistration.ForeColor = System.Drawing.Color.Green;
                    }
                    else {
                        lblRegistration.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dr["Lodging"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteLodging.Enabled = true;
                        }
                        btnEditLodging.Enabled = true;
                        lblLodgings.ForeColor = System.Drawing.Color.Green;
                    }
                    else {
                        lblLodgings.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dr["CarRental"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteCarRental.Enabled = true;
                        }
                        btnEditCarRental.Enabled = true;
                        lblCarRental.ForeColor = System.Drawing.Color.Green;
                    }
                    else {
                        lblCarRental.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dr["AirFare"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteAirFare.Enabled = true;
                        }
                        btnEditAirFare.Enabled = true;
                        lblAirFare.ForeColor = System.Drawing.Color.Green;
                    }
                    else {
                        lblAirFare.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dr["Mileage"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteMileage.Enabled = true;
                        }
                        btnEditMileage.Enabled = true;
                        lblMileage.ForeColor = System.Drawing.Color.Green;
                    }
                    else {
                        lblMileage.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dr["OtherExpenses"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteOtherExpenses.Enabled = true;
                        }
                        btnEditOtherExpenses.Enabled = true;
                        lblOtherExpenses.ForeColor = System.Drawing.Color.Green;
                    }
                    else {
                        lblOtherExpenses.ForeColor = System.Drawing.Color.Red;
                    }
                    if (quantItems < 7)
                    {
                        btnAddNewItem.Enabled = true;
                    }
                    
                }
            }

            localCon.Close();
        }

        private void btnDeleteMeals_Click(object sender, EventArgs e)
        {
            DialogResult meald = MessageBox.Show("Do you really want to delete the meals from your travel?","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (meald == DialogResult.Yes)
            {
                
                localCon.Open();
                double totalMeals = 0;
                double travelAmount = 0;
                double travelReim = 0;
                Guid mealID = new Guid();
                SqlCommand cmd = new SqlCommand("SELECT [TotalMeals],[MealsID] FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + edittravelID + "'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    totalMeals = Convert.ToDouble(dr["TotalMeals"].ToString());
                    mealID = new Guid(dr["MealsID"].ToString());
                }
                dr.Close();

                SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                    travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                }
                dr2.Close();

                SqlCommand delMealDate = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[MealDate] WHERE MealsID = '" + mealID + "'", localCon);
                int mdDel = delMealDate.ExecuteNonQuery();

                if (mdDel > 0)
                {

                    SqlCommand cmd1 = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[Meals] WHERE TravelID ='" + edittravelID + "'", localCon);
                    int ra = cmd1.ExecuteNonQuery();

                    if (ra > 0)
                    {
                        SqlDataAdapter upTravel = new SqlDataAdapter();
                        upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed ,[Melas] = @Melas WHERE TravelID ='" + edittravelID + "'", localCon);
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount - totalMeals;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim - totalMeals;
                        upTravel.UpdateCommand.Parameters.Add("@Melas", SqlDbType.Bit).Value = false;

                        int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                        localCon.Close();
                        if (ru > 0)
                        {
                            MessageBox.Show("The meals were deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblMeals.ForeColor = System.Drawing.Color.Red;
                            btnDeleteMeals.Enabled = false;
                            btnEditMeals.Enabled = false;
                            int items = itemsNumber();
                            if (items <= 1)
                            {
                                enableDeleteButtons();
                            }
                        }
                    }


                }
                localCon.Close();
            }
        }

        private void btnEditMeals_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditMeals em = new EditMeals();
            em.ShowDialog();
            
        }

        private void btnDeleteRegistration_Click(object sender, EventArgs e)
        {

            DialogResult meald = MessageBox.Show("Do you really want to delete the Registration from your travel?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (meald == DialogResult.Yes)
            {
                localCon.Open();
                double regAmount = 0;
                bool districtPay = true;
                double travelAmount = 0;
                double travelReim = 0;
                SqlCommand cmd = new SqlCommand("SELECT [RegistrationAMount] ,[DistrictPay] FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + edittravelID + "'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        regAmount = Convert.ToDouble(dr["RegistrationAMount"].ToString());
                        districtPay = Convert.ToBoolean(dr["DistrictPay"].ToString());
                    }
                    dr.Close();

                    SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                        travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                    }
                    dr2.Close();

                    SqlCommand cmd3 = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[Registration] WHERE TravelID = '" + edittravelID + "'", localCon);
                    int rd = cmd3.ExecuteNonQuery();
                    if (rd > 0)
                    {
                        SqlDataAdapter upTravel = new SqlDataAdapter();
                        upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed ,[Registration] = @Registration WHERE TravelID ='" + edittravelID + "'", localCon);
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount - regAmount;
                        if (!districtPay)
                        {
                            upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim - regAmount;
                        }
                        else
                        {
                            upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                        }
                        upTravel.UpdateCommand.Parameters.Add("@Registration", SqlDbType.Bit).Value = false;

                        int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                        localCon.Close();
                        if (ru > 0)
                        {
                            MessageBox.Show("The registration has been deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblRegistration.ForeColor = System.Drawing.Color.Red;
                            btnDeleteRegistration.Enabled = false;
                            btnEditRegistration.Enabled = false;

                            int items = itemsNumber();
                            if (items <= 1)
                            {
                                enableDeleteButtons();
                            }
                        }
                    }
                }
                localCon.Close();
            }
        }

        private int itemsNumber() {
            localCon.Open();
            int itemNumbers = 0;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + edittravelID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr["Melas"].ToString() == "True")
                    {
                        itemNumbers = itemNumbers + 1;
                    }
                    if (dr["Registration"].ToString() == "True")
                    {
                        itemNumbers = itemNumbers + 1;
                    }
                    if (dr["Lodging"].ToString() == "True")
                    {
                        itemNumbers = itemNumbers + 1;
                    }
                    if (dr["CarRental"].ToString() == "True")
                    {
                        itemNumbers = itemNumbers + 1;
                    }
                    if (dr["AirFare"].ToString() == "True")
                    {
                        itemNumbers = itemNumbers + 1;
                    }
                    if (dr["Mileage"].ToString() == "True")
                    {
                        itemNumbers = itemNumbers + 1;
                    }
                    if (dr["OtherExpenses"].ToString() == "True")
                    {
                        itemNumbers = itemNumbers + 1;
                    }
                }
            }
            dr.Close();

            if (itemNumbers < 7)
            {
                btnAddNewItem.Enabled = true;
            }
            else
            {
                btnAddNewItem.Enabled = false;
            }

            localCon.Close();
            return itemNumbers;
            
        }

        private void enableDeleteButtons() {
            btnDeleteMeals.Enabled = false;
            btnDeleteRegistration.Enabled = false;
            btnDeleteCarRental.Enabled = false;
            btnDeleteAirFare.Enabled = false;
            btnDeleteLodging.Enabled = false;
            btnDeleteMileage.Enabled = false;
            btnDeleteOtherExpenses.Enabled = false;
        }

        private void btnEditRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditRegistration er = new EditRegistration();
            er.ShowDialog();
        }

        private void btnSaveDetails_Click(object sender, EventArgs e)
        {
            if (validateDetails())
            {
                localCon.Open();
                bool dateChanged = false;
                double oldMealsCost = 0;
                int TotalCost = 0;
                if (depDate.ToShortDateString() != dtpDepartureDate.Value.ToShortDateString() || depTime.ToShortTimeString() != dtpDepartureTime.Value.ToShortTimeString() || retDate.ToShortDateString() != dtpReturnDate.Value.ToShortDateString() || retTime.ToShortTimeString() != dtpReturnTime.Value.ToShortTimeString())
                {
                    dateChanged = true;

                    DateTime departureDate = dtpDepartureDate.Value;
                    DateTime returnDate = dtpReturnDate.Value;
                    DateTime departureTime = dtpDepartureTime.Value;
                    DateTime returnTime = dtpReturnTime.Value;
                    int breakfast = 0;
                    int lunch = 0;
                    int dinner = 0;
                    int totalDays = 0;
                    bool firstBreakfast = false;
                    bool firstLunch = false;
                    bool firstDinner = false;
                    bool lastBreakfast = false;
                    bool lastLunch = false;
                    bool lastDinner = false;

                    TimeSpan difference = returnDate.Subtract(departureDate);
                    totalDays = (int)difference.TotalDays;
                    totalDays = totalDays + 1;


                    breakfast = totalDays;
                    lunch = totalDays;
                    dinner = totalDays;
                    


                    int departureTimeHour = Convert.ToInt32(dtpDepartureTime.Value.ToString("hh", CultureInfo.InvariantCulture));
                    int departureTimeMinutes = dtpDepartureTime.Value.Minute;
                    string dayTimeDeparture = dtpDepartureTime.Value.ToString("tt", CultureInfo.InvariantCulture);

                    int returnTimeHour = Convert.ToInt32(dtpReturnTime.Value.ToString("hh", CultureInfo.InvariantCulture));
                    int returnTimeMinutes = dtpReturnTime.Value.Minute;
                    string returnTimesDayTime = dtpReturnTime.Value.ToString("tt", CultureInfo.InvariantCulture);


                    /* Departure time calculations*/
                    if (departureTimeHour > 6 && departureTimeHour < 12 && dayTimeDeparture == "AM")
                    {
                        firstBreakfast = true;
                    }
                    if (departureTimeHour == 6 && departureTimeMinutes >= 0 && dayTimeDeparture == "AM")
                    {
                        firstBreakfast = true;
                    }
                    if (departureTimeHour <= 12 && dayTimeDeparture == "PM")
                    {
                        firstBreakfast = true;
                        firstLunch = true;

                        if (departureTimeHour >= 6 && departureTimeHour <= 11 && dayTimeDeparture == "PM")
                        {
                            firstDinner = true;
                        }
                    }
                    if (departureTimeHour == 12 && dayTimeDeparture == "PM" && departureTimeMinutes > 0)
                    {

                       firstBreakfast = true;
                       firstLunch = true;
                    }
                    if (departureTimeHour == 6 && dayTimeDeparture == "PM" && departureTimeMinutes > 0)
                    {
                        firstBreakfast = true;
                        firstLunch = true;
                        firstDinner = true;
                    }

                    /*Return time calculations*/

                    if (returnTimeHour >= 1 && returnTimeHour < 8 && returnTimesDayTime == "AM")
                    {
                        lastBreakfast = true;
                        lastLunch = true;
                        lastDinner = true;
                    }

                    if (returnTimeHour > 8 && returnTimeHour != 12 && returnTimesDayTime == "AM")
                    {
                        lastLunch = true;
                        lastDinner = true;
                    }

                    if (returnTimeHour == 12 && returnTimesDayTime == "AM")
                    {
                        lastBreakfast = true;
                        lastLunch = true;
                        lastDinner = true;
                    }
                    if (Convert.ToInt32(returnTimeHour) == 8 && returnTimesDayTime == "AM" && Convert.ToInt32(returnTimeMinutes) > 0)
                    {
                        lastLunch = true;
                        lastDinner = true;
                    }
                    else if (Convert.ToInt32(returnTimeHour) == 8 && returnTimesDayTime == "AM" && Convert.ToInt32(returnTimeMinutes) == 0)
                    {
                        lastBreakfast = true;
                        lastLunch = true;
                        lastDinner = true;
                    }

                    if (Convert.ToInt32(returnTimeHour) == 12 && returnTimesDayTime == "PM" && Convert.ToInt32(returnTimeMinutes) >= 0)
                    {
                        lastLunch = true;
                        lastDinner = true;
                    }
                    if (Convert.ToInt32(returnTimeHour) >= 1 && returnTimesDayTime == "PM" && Convert.ToInt32(returnTimeHour) < 2)
                    {
                        lastLunch = true;
                        lastDinner = true;
                    }
                    if (Convert.ToInt32(returnTimeHour) > 2 && Convert.ToInt32(returnTimeHour) < 8 && returnTimesDayTime == "PM")
                    {
                        lastDinner = true;
                    }
                    if (Convert.ToInt32(returnTimeHour) == 2 && Convert.ToInt32(returnTimeMinutes) > 0 && returnTimesDayTime == "PM")
                    {
                        lastDinner = true;
                    }
                    if (Convert.ToInt32(returnTimeHour) == 2 && returnTimesDayTime == "PM" && Convert.ToInt32(returnTimeMinutes) == 0)
                    {
                        lastLunch = true;
                        lastDinner = true;
                    }
                    if (Convert.ToInt32(returnTimeHour) == 8 && Convert.ToInt32(returnTimeMinutes) == 0 && returnTimesDayTime == "PM")
                    {
                        lastDinner = true;
                    }

                    if (firstBreakfast)
                    {
                        breakfast--;
                    }
                    if (lastBreakfast)
                    {
                        breakfast--;
                    }
                    if (firstLunch)
                    {
                        lunch--;
                    }
                    if (lastLunch)
                    {
                        lunch--;
                    }
                    if (firstDinner)
                    {
                        dinner--;
                    }
                    if (lastDinner)
                    {
                        dinner--;
                    }

                    TotalCost = (breakfast * 8) + (lunch * 12) + (dinner * 20);
                    string mealID = "";

                    SqlCommand selMID = new SqlCommand("SELECT [MealsID],[TotalMeals] FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + edittravelID + "'", localCon);
                    SqlDataReader selMIDdr = selMID.ExecuteReader();
                    while (selMIDdr.Read())
                    {
                        mealID = selMIDdr["MealsID"].ToString();
                        oldMealsCost = Convert.ToInt32(selMIDdr["TotalMeals"].ToString());
                    }
                    selMIDdr.Close();

                    SqlDataAdapter upMeals = new SqlDataAdapter();
                    upMeals.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Meals] SET [Breakfast] = @Breakfast ,[Lunch] = @Lunch ,[Dinner] = @Dinner ,[TotalMeals] = @TotalMeals WHERE MealsID = '" + mealID + "'", localCon);
                    upMeals.UpdateCommand.Parameters.Add("@Breakfast", SqlDbType.Int).Value = breakfast;
                    upMeals.UpdateCommand.Parameters.Add("@Lunch", SqlDbType.Int).Value = lunch;
                    upMeals.UpdateCommand.Parameters.Add("@Dinner", SqlDbType.Int).Value = dinner;
                    upMeals.UpdateCommand.Parameters.Add("@TotalMeals", SqlDbType.Float).Value = TotalCost;
                    int mu = upMeals.UpdateCommand.ExecuteNonQuery();
                    if (mu > 0)

                    {
                        SqlCommand delMealDate = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[MealDate] WHERE MealsID = '" + mealID + "'", localCon);
                        int delDates = delMealDate.ExecuteNonQuery();
                        DateTime mealDate = departureDate;
                        if (delDates > 0)
                        {
                            Guid mealIDdate = new Guid(mealID);
                            for(int i = 0; i < totalDays; i++)
                            {
                                SqlDataAdapter inMealDate = new SqlDataAdapter();
                                inMealDate.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[MealDate] ([MealsID],[Date],[Breaksfast],[Lunch],[Dinner]) VALUES(@MealsID,@Date,@Breaksfast,@Lunch,@Dinner)", localCon);
                                inMealDate.InsertCommand.Parameters.Add("@MealsID", SqlDbType.UniqueIdentifier).Value = mealIDdate;
                                inMealDate.InsertCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = mealDate;
                                if (i == 0)
                                {
                                    inMealDate.InsertCommand.Parameters.Add("@Breaksfast", SqlDbType.Bit).Value = !firstBreakfast;
                                    inMealDate.InsertCommand.Parameters.Add("@Lunch", SqlDbType.Bit).Value = !firstLunch;
                                    inMealDate.InsertCommand.Parameters.Add("@Dinner", SqlDbType.Bit).Value = !firstDinner;
                                }
                                else if (i == (totalDays - 1))
                                {
                                    inMealDate.InsertCommand.Parameters.Add("@Breaksfast", SqlDbType.Bit).Value = !lastBreakfast;
                                    inMealDate.InsertCommand.Parameters.Add("@Lunch", SqlDbType.Bit).Value = !lastLunch;
                                    inMealDate.InsertCommand.Parameters.Add("@Dinner", SqlDbType.Bit).Value = !lastDinner;
                                }
                                else
                                {
                                    inMealDate.InsertCommand.Parameters.Add("@Breaksfast", SqlDbType.Bit).Value = true;
                                    inMealDate.InsertCommand.Parameters.Add("@Lunch", SqlDbType.Bit).Value = true;
                                    inMealDate.InsertCommand.Parameters.Add("@Dinner", SqlDbType.Bit).Value = true;
                                }
                                inMealDate.InsertCommand.ExecuteNonQuery();
                                mealDate = mealDate.AddDays(1);
                            }

                        }

                    }
                }


                //update the travel
                SqlDataAdapter upTravDet = new SqlDataAdapter();
                if (dateChanged)
                {
                    double travCost = 0;
                    double travReimb = 0;
                    SqlCommand selTravelTotal = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + edittravelID + "'", localCon);
                    SqlDataReader dr = selTravelTotal.ExecuteReader();
                    while (dr.Read())
                    {
                        travCost = Convert.ToDouble(dr["TotalTravelAmount"].ToString());
                        travReimb = Convert.ToDouble(dr["TotalTravelReimbursed"].ToString());
                    }
                    dr.Close();

                    travCost = travCost - oldMealsCost;
                    travReimb = travReimb - oldMealsCost;

                    travCost = travCost + TotalCost;
                    travReimb = travReimb + TotalCost;

                    upTravDet.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TravelEvent] = @TravelEvent ,[TravelPurpose] = @TravelPurpose,[Origin] = @Origin,[Destination] = @Destination,[TravelState] = @TravelState,[Notes] = @Notes,[DepartureTime] = @DepartureTime,[DepartureDate] = @DepartureDate,[ReturnTime] = @ReturnTime,[ReturnDate] = @ReturnDate,[TotalTravelAmount] = @TotalTravelAmount,[TotalTravelReimbursed] = @TotalTravelReimbursed WHERE TravelID = '" + edittravelID + "'", localCon);
                    upTravDet.UpdateCommand.Parameters.Add("@DepartureTime", SqlDbType.NVarChar).Value = dtpDepartureTime.Value.ToShortTimeString();
                    upTravDet.UpdateCommand.Parameters.Add("@ReturnTime", SqlDbType.NVarChar).Value = dtpReturnTime.Value.ToShortTimeString();
                    upTravDet.UpdateCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = dtpDepartureDate.Value;
                    upTravDet.UpdateCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = dtpReturnDate.Value;
                    upTravDet.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travCost;
                    upTravDet.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travReimb;
                }
                else
                {
                    upTravDet.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TravelEvent] = @TravelEvent ,[TravelPurpose] = @TravelPurpose,[Origin] = @Origin,[Destination] = @Destination,[TravelState] = @TravelState,[Notes] = @Notes WHERE TravelID = '" + edittravelID + "'", localCon);
                }
                
                if (cbTravelEvent.SelectedItem.ToString() != "Other")
                {
                    upTravDet.UpdateCommand.Parameters.Add("@TravelEvent", SqlDbType.NVarChar).Value = cbTravelEvent.SelectedItem.ToString();
                }
                else
                {
                    upTravDet.UpdateCommand.Parameters.Add("@TravelEvent", SqlDbType.NVarChar).Value = txtOtherEvent.Text;
                }
                if (cbTravelPurpose.SelectedItem.ToString() != "Other")
                {
                    upTravDet.UpdateCommand.Parameters.Add("@TravelPurpose", SqlDbType.NVarChar).Value = cbTravelPurpose.SelectedItem.ToString();
                }
                else
                {
                    upTravDet.UpdateCommand.Parameters.Add("@TravelPurpose", SqlDbType.NVarChar).Value = txtOtherPurpose.Text;
                }
                upTravDet.UpdateCommand.Parameters.Add("@Origin", SqlDbType.NVarChar).Value = txtOrigin.Text;
                upTravDet.UpdateCommand.Parameters.Add("@Destination", SqlDbType.NVarChar).Value = txtDestination.Text;
                upTravDet.UpdateCommand.Parameters.Add("@TravelState", SqlDbType.NVarChar).Value = cbTravelState.SelectedItem.ToString();
                upTravDet.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtNotes.Text;
                int ru = upTravDet.UpdateCommand.ExecuteNonQuery();
                if (ru > 0)
                {
                    MessageBox.Show("Travel details updated successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dateChanged)
                    {
                        MessageBox.Show("Please notice that your meals expenses has been recalculated due to the changes you made on the times or dates of your travel, the edit Meals screen will be shown to you for you to uncheck your provided meals and if you do not have any just  hit cancel.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        localCon.Close();
                        refreshData();
                        EditMeals em = new EditMeals();
                        em.ShowDialog();
                    }

                }
                
                localCon.Close();
                refreshData();
            }
        }

        public void refreshData() {
            localCon.Open();
            quantItems = 0;
            SqlCommand cmd = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + edittravelID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dtpDepartureDate.Value = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    dtpDepartureTime.Value = Convert.ToDateTime(dr["DepartureTime"].ToString());
                    depTime = Convert.ToDateTime(dr["DepartureTime"].ToString());
                    dtpReturnDate.Value = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    dtpReturnTime.Value = Convert.ToDateTime(dr["ReturnTime"].ToString());
                    retTime = Convert.ToDateTime(dr["ReturnTime"].ToString());
                    int i = cbTravelEvent.Items.Count - 1;
                    while (i > 0)
                    {
                        if (cbTravelEvent.Items[i].ToString() == dr["TravelEvent"].ToString())
                        {
                            cbTravelEvent.SelectedItem = cbTravelEvent.Items[i];
                            break;
                        }
                        i--;
                    }
                    if (cbTravelEvent.SelectedItem == null && dr["TravelEvent"].ToString() != "")
                    {
                        txtOtherEvent.Text = dr["TravelEvent"].ToString();
                        txtOtherEvent.Enabled = true;
                        cbTravelEvent.SelectedItem = "Other";
                    }

                    int j = cbTravelPurpose.Items.Count - 1;
                    while (j > 0)
                    {
                        if (cbTravelPurpose.Items[j].ToString() == dr["TravelPurpose"].ToString())
                        {
                            cbTravelPurpose.SelectedItem = cbTravelPurpose.Items[j];
                            break;
                        }
                        j--;
                    }
                    if (cbTravelPurpose.SelectedItem == null && dr["TravelPurpose"].ToString() != "")
                    {
                        txtOtherPurpose.Text = dr["TravelPurpose"].ToString();
                        txtOtherPurpose.Enabled = true;
                        cbTravelPurpose.SelectedItem = "Other";
                    }
                    txtOrigin.Text = dr["Origin"].ToString();
                    txtDestination.Text = dr["Destination"].ToString();
                    int l = cbTravelState.Items.Count - 1;
                    while (l > 0)
                    {
                        if (cbTravelState.Items[l].ToString() == dr["TravelState"].ToString())
                        {
                            cbTravelState.SelectedItem = cbTravelState.Items[l];
                            break;
                        }
                        l--;
                    }
                    txtNotes.Text = dr["Notes"].ToString();
                    lblTravelTotalAmount.Text = dr["TotalTravelAmount"].ToString();
                    lblTravelReimbAmount.Text = dr["TotalTravelReimbursed"].ToString();

                    //Count the items in the travel
                    if (dr["Melas"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }
                    if (dr["Registration"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }
                    if (dr["Lodging"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }
                    if (dr["CarRental"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }
                    if (dr["AirFare"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }
                    if (dr["Mileage"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }
                    if (dr["OtherExpenses"].ToString() == "True")
                    {
                        quantItems = quantItems + 1;
                    }


                    //setting the delete and edit buttons
                    if (dr["Melas"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteMeals.Enabled = true;
                        }
                        btnEditMeals.Enabled = true;
                        lblMeals.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMeals.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dr["Registration"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteRegistration.Enabled = true;
                        }
                        btnEditRegistration.Enabled = true;
                        lblRegistration.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblRegistration.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dr["Lodging"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteLodging.Enabled = true;
                        }
                        btnEditLodging.Enabled = true;
                        lblLodgings.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblLodgings.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dr["CarRental"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteCarRental.Enabled = true;
                        }
                        btnEditCarRental.Enabled = true;
                        lblCarRental.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblCarRental.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dr["AirFare"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteAirFare.Enabled = true;
                        }
                        btnEditAirFare.Enabled = true;
                        lblAirFare.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblAirFare.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dr["Mileage"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteMileage.Enabled = true;
                        }
                        btnEditMileage.Enabled = true;
                        lblMileage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMileage.ForeColor = System.Drawing.Color.Red;
                    }
                    if (dr["OtherExpenses"].ToString() == "True")
                    {
                        if (quantItems > 1)
                        {
                            btnDeleteOtherExpenses.Enabled = true;
                        }
                        btnEditOtherExpenses.Enabled = true;
                        lblOtherExpenses.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblOtherExpenses.ForeColor = System.Drawing.Color.Red;
                    }

                }
            }

            localCon.Close();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnDeleteMileage_Click(object sender, EventArgs e)
        {
            DialogResult meald = MessageBox.Show("Do you really want to delete the Mileage from your travel?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (meald == DialogResult.Yes)
            {

                localCon.Open();
                double mileageAmount = 0;
                bool districtVehicle = true;
                bool directorApproval = false;
                double travelAmount = 0;
                double travelReim = 0;
                SqlCommand cmd = new SqlCommand("SELECT [DistrictVehicleProvided],[DirectorApprovedPersonal],[TotalMileage] FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + edittravelID + "'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        mileageAmount = Convert.ToDouble(dr["TotalMileage"].ToString());
                        districtVehicle = Convert.ToBoolean(dr["DistrictVehicleProvided"].ToString());
                        if (dr["DirectorApprovedPersonal"].ToString() != "")
                        {
                            directorApproval = Convert.ToBoolean(dr["DirectorApprovedPersonal"].ToString());
                        }
                    }
                    dr.Close();

                    SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                        travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                    }
                    dr2.Close();

                    SqlCommand cmdDelMil = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[Mileage] WHERE TravelID = '" + edittravelID + "'", localCon);
                    int rd = cmdDelMil.ExecuteNonQuery();
                    if (rd > 0)
                    {
                        SqlDataAdapter upTravel = new SqlDataAdapter();
                        upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed ,[Mileage] = @Mileage WHERE TravelID ='" + edittravelID + "'", localCon);
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount - mileageAmount;
                        if (!districtVehicle && directorApproval)
                        {
                            upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim - mileageAmount;
                        }
                        else
                        {
                            upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                        }
                        upTravel.UpdateCommand.Parameters.Add("@Mileage", SqlDbType.Bit).Value = false;

                        int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                        localCon.Close();
                        if (ru > 0)
                        {
                            MessageBox.Show("The mileage has been deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lblMileage.ForeColor = System.Drawing.Color.Red;
                            btnDeleteMileage.Enabled = false;
                            btnEditMileage.Enabled = false;

                            int items = itemsNumber();
                            if (items <= 1)
                            {
                                enableDeleteButtons();
                            }
                        }
                    }
                }

                localCon.Close();
            }
        }

        private void btnEditMileage_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditMileage em = new EditMileage();
            em.ShowDialog();
                
        }

        private void btnDeleteCarRental_Click(object sender, EventArgs e)
        {
            DialogResult meald = MessageBox.Show("Do you really want to delete the Car Rentals from your travel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (meald == DialogResult.Yes)
            {
                localCon.Open();
                double travelAmount = 0;
                double travelReim = 0;
                double travelNoReim = 0;

                SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                    travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                    travelNoReim = Convert.ToDouble(dr2["TotalTravelNoReimbursed"].ToString());
                }
                dr2.Close();

                SqlCommand cmd3 = new SqlCommand("SELECT [DistrictPay],[TotalCarRental],[PersonalUse],[PersonalAmount] FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + edittravelID + "'", localCon);
                SqlDataReader dr3 = cmd3.ExecuteReader();

                while (dr3.Read())
                {
                    travelAmount = travelAmount - Convert.ToDouble(dr3["TotalCarRental"].ToString());
                    if (dr3["DistrictPay"].ToString() == "False")
                    {
                        if (dr3["PersonalUse"].ToString() == "True")
                        {
                            double diffCRDel = Convert.ToDouble(dr3["TotalCarRental"].ToString()) - Convert.ToDouble(dr3["PersonalAmount"].ToString());
                            travelReim = travelReim - diffCRDel;
                        }
                        else
                        {
                            travelReim = travelReim - Convert.ToDouble(dr3["TotalCarRental"].ToString());
                        }

                    }
                    else
                    {
                        if (dr3["PersonalUse"].ToString() == "True")
                        {
                            travelNoReim = travelNoReim - Convert.ToDouble(dr3["PersonalAmount"].ToString());
                        }
                    }
                }
                dr3.Close();

                SqlCommand delCar = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[CarRental] WHERE TravelID = '" + edittravelID + "'", localCon);
                int rd = delCar.ExecuteNonQuery();
                if (rd > 0)
                {

                    SqlDataAdapter upTravel = new SqlDataAdapter();
                    upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed ,[TotalTravelNoReimbursed] = @TotalTravelNoReimbursed ,[CarRental] = @CarRental WHERE TravelID ='" + edittravelID + "'", localCon);
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelNoReimbursed", SqlDbType.Float).Value = travelNoReim;
                    upTravel.UpdateCommand.Parameters.Add("@CarRental", SqlDbType.Bit).Value = false;
                    int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                    localCon.Close();
                    if (ru > 0)
                    {
                        MessageBox.Show("The car rental has been deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblCarRental.ForeColor = System.Drawing.Color.Red;
                        btnDeleteCarRental.Enabled = false;
                        btnEditCarRental.Enabled = false;

                        int items = itemsNumber();
                        if (items <= 1)
                        {
                            enableDeleteButtons();
                        }

                    }

                }

                localCon.Close();
            }
        }

        private void btnDeleteLodging_Click(object sender, EventArgs e)
        {
            DialogResult meald = MessageBox.Show("Do you really want to delete the Lodgings from your travel?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (meald == DialogResult.Yes)
            {

                localCon.Open();
                double travelAmount = 0;
                double travelReim = 0;

                SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                    travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                }
                dr2.Close();

                SqlCommand cm3 = new SqlCommand("SELECT  [DistrictPay],[DirectorApproved],[TotalLodging] FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '" + edittravelID + "'", localCon);
                SqlDataReader dr3 = cm3.ExecuteReader();

                while (dr3.Read())
                {
                    travelAmount = travelAmount - Convert.ToDouble(dr3["TotalLodging"].ToString());
                    if (dr3["DistrictPay"].ToString() == "False" && dr3["DirectorApproved"].ToString() == "True")
                    {
                        travelReim = travelReim - Convert.ToDouble(dr3["TotalLodging"].ToString());
                    }
                }
                dr3.Close();

                SqlCommand delLod = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[Lodging] WHERE TravelID = '" + edittravelID + "'", localCon);
                int rd = delLod.ExecuteNonQuery();
                if (rd > 0)
                {
                    SqlDataAdapter upTravel = new SqlDataAdapter();
                    upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed ,[Lodging] = @Lodging WHERE TravelID ='" + edittravelID + "'", localCon);
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                    upTravel.UpdateCommand.Parameters.Add("@Lodging", SqlDbType.Bit).Value = false;
                    int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                    localCon.Close();
                    if (ru > 0)
                    {
                        MessageBox.Show("The lodging has been deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblLodgings.ForeColor = System.Drawing.Color.Red;
                        btnDeleteLodging.Enabled = false;
                        btnEditLodging.Enabled = false;

                        int items = itemsNumber();
                        if (items <= 1)
                        {
                            enableDeleteButtons();
                        }
                    }
                }
                
                localCon.Close();
            }
        }

        private void btnEditLodging_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditLodging el = new EditLodging();
            el.ShowDialog();
        }

        private void btnEditCarRental_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditCarRental ecr = new EditCarRental();
            ecr.ShowDialog();
        }

        private void btnDeleteAirFare_Click(object sender, EventArgs e)
        {
            DialogResult meald = MessageBox.Show("Do you really want to delete the Airfare from your travel?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (meald == DialogResult.Yes)
            {
                localCon.Open();
                double travelAmount = 0;
                double travelReim = 0;
                double travelNoReim = 0;

                SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                    travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                    travelNoReim = Convert.ToDouble(dr2["TotalTravelNoReimbursed"].ToString());
                }
                dr2.Close();

                SqlCommand cmd3 = new SqlCommand("SELECT [DistrictPay] ,[AirFareTotal],[PersonalUse],[PersonalUseAmount] FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '" + edittravelID + "'", localCon);
                SqlDataReader dr3 = cmd3.ExecuteReader();

                while (dr3.Read())
                {
                    travelAmount = travelAmount - Convert.ToDouble(dr3["AirFareTotal"].ToString());
                    if (dr3["DistrictPay"].ToString() == "False")
                    {
                        if (dr3["PersonalUse"].ToString() == "True")
                        {
                            double diffARDEL = Convert.ToDouble(dr3["AirFareTotal"].ToString()) - Convert.ToDouble(dr3["PersonalUseAmount"].ToString());
                            travelReim = travelReim - diffARDEL;
                        }
                        else
                        {
                            travelReim = travelReim - Convert.ToDouble(dr3["AirFareTotal"].ToString());
                        }
                    }
                    else
                    {
                        if (dr3["PersonalUse"].ToString() == "True")
                        {
                            travelNoReim = travelNoReim - Convert.ToDouble(dr3["PersonalUseAmount"].ToString());
                        }
                    }
                }
                dr3.Close();

                SqlCommand delFlight = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[AirFare] WHERE TravelID = '" + edittravelID + "'", localCon);
                int rd = delFlight.ExecuteNonQuery();
                if (rd > 0)
                {
                    SqlDataAdapter upTravel = new SqlDataAdapter();
                    upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed ,[TotalTravelNoReimbursed] = @TotalTravelNoReimbursed ,[AirFare] = @AirFare WHERE TravelID ='" + edittravelID + "'", localCon);
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelNoReimbursed", SqlDbType.Float).Value = travelNoReim;
                    upTravel.UpdateCommand.Parameters.Add("@AirFare", SqlDbType.Bit).Value = false;
                    int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                    localCon.Close();
                    if (ru > 0)
                    {
                        MessageBox.Show("The airfare has been deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblAirFare.ForeColor = System.Drawing.Color.Red;
                        btnDeleteAirFare.Enabled = false;
                        btnEditAirFare.Enabled = false;

                        int items = itemsNumber();
                        if (items <= 1)
                        {
                            enableDeleteButtons();
                        }
                    }
                }
                
                localCon.Close();
            }
        }

        private void btnEditAirFare_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAirFare eaf = new EditAirFare();
            eaf.ShowDialog();
        }

        private void btnDeleteOtherExpenses_Click(object sender, EventArgs e)
        {
            DialogResult meald = MessageBox.Show("Do you really want to delete the Other Expenses from your travel?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (meald == DialogResult.Yes)
            {

                localCon.Open();
                double travelAmount = 0;
                double travelReim = 0;

                SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                    travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                }
                dr2.Close();

                SqlCommand cmd3 = new SqlCommand("SELECT [Amount],[Prepaid] FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + edittravelID + "'", localCon);
                SqlDataReader dr3 = cmd3.ExecuteReader();

                while (dr3.Read())
                {
                    if (dr3["Prepaid"].ToString() == "False")
                    {
                        travelReim = travelReim - Convert.ToDouble(dr3["Amount"].ToString());
                    }
                    travelAmount = travelAmount - Convert.ToDouble(dr3["Amount"].ToString());
                }
                dr3.Close();

                SqlCommand delOE = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[OtherExpenses] WHERE TravelID = '" + edittravelID + "'", localCon);
                int rd = delOE.ExecuteNonQuery();
                if (rd > 0)
                {
                    SqlDataAdapter upTravel = new SqlDataAdapter();
                    upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed ,[OtherExpenses] = @OtherExpenses WHERE TravelID ='" + edittravelID + "'", localCon);
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                    upTravel.UpdateCommand.Parameters.Add("@OtherExpenses", SqlDbType.Bit).Value = false;
                    int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                    localCon.Close();
                    if (ru > 0)
                    {
                        MessageBox.Show("The other expense has been deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblOtherExpenses.ForeColor = System.Drawing.Color.Red;
                        btnDeleteOtherExpenses.Enabled = false;
                        btnEditOtherExpenses.Enabled = false;

                        int items = itemsNumber();
                        if (items <= 1)
                        {
                            enableDeleteButtons();
                        }
                    }
                }

                localCon.Close();
            }
        }

        private void btnEditOtherExpenses_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditOtherExpenses oe = new EditOtherExpenses();
            oe.ShowDialog();
        }

        private bool validateDetails()
        {
            if (cbTravelEvent.SelectedIndex == -1)
            {
                MessageBox.Show("Select a travel event");
                return false;
            }
            if (cbTravelPurpose.SelectedIndex == -1)
            {
                MessageBox.Show("Select a travel purpose");
                return false;
            }
            if (cbTravelEvent.SelectedItem.ToString() == "Other" && txtOtherEvent.Text == "")
            {
                MessageBox.Show("Write the event of your travel on the Other Event box");
                return false;
            }
            if (cbTravelPurpose.SelectedItem.ToString() == "Other" && txtOtherPurpose.Text == "")
            {
                MessageBox.Show("Write the purpose of your travel on the Other Purpose box");
                return false;
            }
            if (txtOrigin.Text == "")
            {
                MessageBox.Show("Provide the origin of your travel");
                return false;
            }
            if (txtDestination.Text == "")
            {
                MessageBox.Show("Provide the destination of your travel");
                return false;
            }
            if (cbTravelState.SelectedIndex == -1)
            {
                MessageBox.Show("Select the state of your travel");
                return false;
            }
            
            return true;
        }

        private void cbTravelEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTravelEvent.SelectedItem.ToString() == "Other")
            {
                txtOtherEvent.Enabled = true;
            }
            else
            {
                txtOtherEvent.Enabled = false;
                txtOtherEvent.Text = "";
            }
        }

        private void cbTravelPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTravelPurpose.SelectedItem.ToString() == "Other")
            {
                txtOtherPurpose.Enabled = true;
            }
            else
            {
                txtOtherPurpose.Enabled = false;
                txtOtherPurpose.Text = "";
            }
        }

        private void btnCloseEdit_Click(object sender, EventArgs e)
        {
            CommonVariables.editTravelID = "";
            this.Dispose();

           /* FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                }
            }
            EditTravel et = new EditTravel();
            et.MdiParent = main;
            et.Show();*/
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            CommonVariables.addingTravelID = CommonVariables.editTravelID.ToString();
            CommonVariables.addingItems = true;

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

            TravelItems ti = new TravelItems();
            ti.MdiParent = main;
            ti.Show();
            this.Close();
        }

        private void SelectItemsEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommonVariables.editTravelID = "";
            //this.Dispose();
        }
    }
}
