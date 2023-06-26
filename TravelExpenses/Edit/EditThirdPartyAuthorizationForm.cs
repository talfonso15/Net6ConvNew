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
    public partial class EditThirdPartyAuthorizationForm : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        bool loadingForm = false;
        bool loadingData = false;
        bool cleaning = false;
        public EditThirdPartyAuthorizationForm()
        {
            InitializeComponent();
        }

        private void EditThirdPartyAuthorizationForm_Load(object sender, EventArgs e)
        {
            localCon.Open();
            dgvAuthorizations.Rows.Clear();
            loadingData = true;
            SqlCommand empl = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] order by LastName asc", localCon);
            SqlDataReader emplDR = empl.ExecuteReader();
            cbEmployee.DisplayMember = "Text";
            cbEmployee.ValueMember = "Value";
            List<Object> items = new List<object>();
            while (emplDR.Read())
            {
                string name = emplDR["LastName"].ToString() + "," + emplDR["Name"].ToString();
                string id = emplDR["UserID"].ToString();
                items.Add(new { Text = name, Value = id });
            }

            items.Add(new { Text = "All", Value = "-1" });
            cbEmployee.DataSource = items;
            cbEmployee.SelectedValue = "-1";
            emplDR.Close();


            SqlCommand autho = new SqlCommand("SELECT a.TravelEstimateID,a.UserID,[DepartureDate],[ReturnDate],[TravelEvent],[TravelPurpose],[BudgetedTravel],[EstimatedTravelCost],[Meals],[MealsCost],[MealsNotes],[Registration],[RegistrationCost],[RegistrationNotes],[Lodgings],[LodgingsCost],[LodgingsNotes],[CarRental],[CarRentalCost],[CarRentalNotes],[AirFare],[AirFareCost],[AirFareNotes],[Mileage],[MileageCost],[MileageNotes],[MileagePersonal],[OtherExpenses],[OtherExpensesCost],[OtherExpensesNotes],[Destination],b.Name,b.LastName FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID order by a.DepartureDate desc", localCon);
            SqlDataReader authoDR = autho.ExecuteReader();
            if (authoDR.HasRows)
            {
                DateTime startDate;
                DateTime endDate;
                string travelEvent = "";
                string travelPurpose = "";
                string budgeted = "";
                string total = "";
                string mealsCost = "";
                string mealsNotes = "";
                string registartionCost = "";
                string registrationNotes = "";
                string lodgingCost = "";
                string lodgingNotes = "";
                string airfareCost = "";
                string airfareNotes = "";
                string carRentalCost = "";
                string carRentalNotes = "";
                string mileageCost = "";
                string mileageNotes = "";
                string otherExpensesCost = "";
                string otherExpensesNotes = "";
                string estimateID = "";
                string userID = "";
                string username = "";
                string destination = "";

                while (authoDR.Read())
                {
                    startDate = Convert.ToDateTime(authoDR["DepartureDate"].ToString());
                    endDate = Convert.ToDateTime(authoDR["ReturnDate"].ToString());
                    travelEvent = authoDR["TravelEvent"].ToString();
                    travelPurpose = authoDR["TravelPurpose"].ToString();
                    if (authoDR["BudgetedTravel"].ToString() == "True")
                    {
                        budgeted = "Yes";
                    }
                    else
                    {
                        budgeted = "No";
                    }
                    total = authoDR["EstimatedTravelCost"].ToString();
                    if (authoDR["Meals"].ToString() == "True")
                    {
                        mealsCost = authoDR["MealsCost"].ToString();
                        mealsNotes = authoDR["MealsNotes"].ToString();
                    }
                    if (authoDR["Registration"].ToString() == "True")
                    {
                        registartionCost = authoDR["RegistrationCost"].ToString();
                        registrationNotes = authoDR["RegistrationNotes"].ToString();
                    }
                    if (authoDR["Lodgings"].ToString() == "True")
                    {
                        lodgingCost = authoDR["LodgingsCost"].ToString();
                        lodgingNotes = authoDR["LodgingsNotes"].ToString();
                    }
                    if (authoDR["CarRental"].ToString() == "True")
                    {
                        carRentalCost = authoDR["CarRentalCost"].ToString();
                        carRentalNotes = authoDR["CarRentalNotes"].ToString();
                    }
                    if (authoDR["AirFare"].ToString() == "True")
                    {
                        airfareCost = authoDR["AirFareCost"].ToString();
                        airfareNotes = authoDR["AirFareNotes"].ToString();
                    }
                    if (authoDR["Mileage"].ToString() == "True")
                    {
                        mileageCost = authoDR["MileageCost"].ToString();
                        mileageNotes = authoDR["MileageNotes"].ToString();
                    }
                    if (authoDR["OtherExpenses"].ToString() == "True")
                    {
                        otherExpensesCost = authoDR["OtherExpensesCost"].ToString();
                        otherExpensesNotes = authoDR["OtherExpensesNotes"].ToString();
                    }
                    destination = authoDR["Destination"].ToString();
                    username = authoDR["Name"].ToString() + " " + authoDR["LastName"].ToString();
                    userID = authoDR["UserID"].ToString();
                    estimateID = authoDR["TravelEstimateID"].ToString();
                    dgvAuthorizations.Rows.Add(startDate.ToShortDateString(), endDate.ToShortDateString(), travelEvent, username, travelPurpose, budgeted, total, destination, mealsCost, mealsNotes, registartionCost, registrationNotes, lodgingCost, lodgingNotes, airfareCost, airfareNotes, carRentalCost, carRentalNotes, mileageCost, mileageNotes, otherExpensesCost, otherExpensesNotes, estimateID, userID);
                }
                authoDR.Close();
            }

            localCon.Close();
            // dtpReturnDateValue.MinDate = dtpDepartureDateValue.Value;
            this.Size = new System.Drawing.Size(726, 673);
            loadingForm = false;
        }

        private void btnShowAthorizations_Click(object sender, EventArgs e)
        {
            dgvAuthorizations.Rows.Clear();

            if (cbEmployee.SelectedValue.ToString() == "-1")
            {
                localCon.Open();
                SqlCommand autho = new SqlCommand("SELECT a.TravelEstimateID,a.UserID,[DepartureDate],[ReturnDate],[TravelEvent],[TravelPurpose],[BudgetedTravel],[EstimatedTravelCost],[Meals],[MealsCost],[MealsNotes],[Registration],[RegistrationCost],[RegistrationNotes],[Lodgings],[LodgingsCost],[LodgingsNotes],[CarRental],[CarRentalCost],[CarRentalNotes],[AirFare],[AirFareCost],[AirFareNotes],[Mileage],[MileageCost],[MileageNotes],[MileagePersonal],[OtherExpenses],[OtherExpensesCost],[OtherExpensesNotes],[Destination],b.Name,b.LastName FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID order by a.DepartureDate desc", localCon);
                SqlDataReader authoDR = autho.ExecuteReader();
                if (authoDR.HasRows)
                {


                    while (authoDR.Read())
                    {
                        DateTime startDate;
                        DateTime endDate;
                        string travelEvent = "";
                        string travelPurpose = "";
                        string budgeted = "";
                        string total = "";
                        string mealsCost = "";
                        string mealsNotes = "";
                        string registartionCost = "";
                        string registrationNotes = "";
                        string lodgingCost = "";
                        string lodgingNotes = "";
                        string airfareCost = "";
                        string airfareNotes = "";
                        string carRentalCost = "";
                        string carRentalNotes = "";
                        string mileageCost = "";
                        string mileageNotes = "";
                        string otherExpensesCost = "";
                        string otherExpensesNotes = "";
                        string estimateID = "";
                        string userID = "";
                        string username = "";
                        string destination = "";

                        startDate = Convert.ToDateTime(authoDR["DepartureDate"].ToString());
                        endDate = Convert.ToDateTime(authoDR["ReturnDate"].ToString());
                        travelEvent = authoDR["TravelEvent"].ToString();
                        travelPurpose = authoDR["TravelPurpose"].ToString();
                        if (authoDR["BudgetedTravel"].ToString() == "True")
                        {
                            budgeted = "Yes";
                        }
                        else
                        {
                            budgeted = "No";
                        }
                        total = authoDR["EstimatedTravelCost"].ToString();
                        if (authoDR["Meals"].ToString() == "True")
                        {
                            mealsCost = authoDR["MealsCost"].ToString();
                            mealsNotes = authoDR["MealsNotes"].ToString();
                        }
                        if (authoDR["Registration"].ToString() == "True")
                        {
                            registartionCost = authoDR["RegistrationCost"].ToString();
                            registrationNotes = authoDR["RegistrationNotes"].ToString();
                        }
                        if (authoDR["Lodgings"].ToString() == "True")
                        {
                            lodgingCost = authoDR["LodgingsCost"].ToString();
                            lodgingNotes = authoDR["LodgingsNotes"].ToString();
                        }
                        if (authoDR["CarRental"].ToString() == "True")
                        {
                            carRentalCost = authoDR["CarRentalCost"].ToString();
                            carRentalNotes = authoDR["CarRentalNotes"].ToString();
                        }
                        if (authoDR["AirFare"].ToString() == "True")
                        {
                            airfareCost = authoDR["AirFareCost"].ToString();
                            airfareNotes = authoDR["AirFareNotes"].ToString();
                        }
                        if (authoDR["Mileage"].ToString() == "True")
                        {
                            mileageCost = authoDR["MileageCost"].ToString();
                            mileageNotes = authoDR["MileageNotes"].ToString();
                        }
                        if (authoDR["OtherExpenses"].ToString() == "True")
                        {
                            otherExpensesCost = authoDR["OtherExpensesCost"].ToString();
                            otherExpensesNotes = authoDR["OtherExpensesNotes"].ToString();
                        }
                        destination = authoDR["Destination"].ToString();
                        username = authoDR["Name"].ToString() + " " + authoDR["LastName"].ToString();
                        userID = authoDR["UserID"].ToString();
                        estimateID = authoDR["TravelEstimateID"].ToString();
                        dgvAuthorizations.Rows.Add(startDate.ToShortDateString(), endDate.ToShortDateString(), travelEvent, username, travelPurpose, budgeted, total, destination, mealsCost, mealsNotes, registartionCost, registrationNotes, lodgingCost, lodgingNotes, airfareCost, airfareNotes, carRentalCost, carRentalNotes, mileageCost, mileageNotes, otherExpensesCost, otherExpensesNotes, estimateID, userID);
                    }
                    authoDR.Close();
                }
                localCon.Close();
            }
            else
            {
                refreshAuthorizations();
            }

        }

        private void refreshAuthorizations()
        {
            if (cbEmployee.SelectedValue.ToString() != "-1")
            {
                dgvAuthorizations.Rows.Clear();
                localCon.Open();
                Guid userIDTR = new Guid(cbEmployee.SelectedValue.ToString());
                SqlCommand autho = new SqlCommand("SELECT a.TravelEstimateID,a.UserID,[DepartureDate],[ReturnDate],[TravelEvent],[TravelPurpose],[BudgetedTravel],[EstimatedTravelCost],[Meals],[MealsCost],[MealsNotes],[Registration],[RegistrationCost],[RegistrationNotes],[Lodgings],[LodgingsCost],[LodgingsNotes],[CarRental],[CarRentalCost],[CarRentalNotes],[AirFare],[AirFareCost],[AirFareNotes],[Mileage],[MileageCost],[MileageNotes],[MileagePersonal],[OtherExpenses],[OtherExpensesCost],[OtherExpensesNotes],[Destination],b.Name,b.LastName FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID where a.UserID = '" + userIDTR + "' order by a.DepartureDate desc", localCon);
                SqlDataReader authoDR = autho.ExecuteReader();
                if (authoDR.HasRows)
                {


                    while (authoDR.Read())
                    {
                        DateTime startDate;
                        DateTime endDate;
                        string travelEvent = "";
                        string travelPurpose = "";
                        string budgeted = "";
                        string total = "";
                        string mealsCost = "";
                        string mealsNotes = "";
                        string registartionCost = "";
                        string registrationNotes = "";
                        string lodgingCost = "";
                        string lodgingNotes = "";
                        string airfareCost = "";
                        string airfareNotes = "";
                        string carRentalCost = "";
                        string carRentalNotes = "";
                        string mileageCost = "";
                        string mileageNotes = "";
                        string otherExpensesCost = "";
                        string otherExpensesNotes = "";
                        string estimateID = "";
                        string userID = "";
                        string username = "";
                        string destination = "";


                        startDate = Convert.ToDateTime(authoDR["DepartureDate"].ToString());
                        endDate = Convert.ToDateTime(authoDR["ReturnDate"].ToString());
                        travelEvent = authoDR["TravelEvent"].ToString();
                        travelPurpose = authoDR["TravelPurpose"].ToString();
                        if (authoDR["BudgetedTravel"].ToString() == "True")
                        {
                            budgeted = "Yes";
                        }
                        else
                        {
                            budgeted = "No";
                        }
                        total = authoDR["EstimatedTravelCost"].ToString();
                        if (authoDR["Meals"].ToString() == "True")
                        {
                            mealsCost = authoDR["MealsCost"].ToString();
                            mealsNotes = authoDR["MealsNotes"].ToString();
                        }
                        if (authoDR["Registration"].ToString() == "True")
                        {
                            registartionCost = authoDR["RegistrationCost"].ToString();
                            registrationNotes = authoDR["RegistrationNotes"].ToString();
                        }
                        if (authoDR["Lodgings"].ToString() == "True")
                        {
                            lodgingCost = authoDR["LodgingsCost"].ToString();
                            lodgingNotes = authoDR["LodgingsNotes"].ToString();
                        }
                        if (authoDR["CarRental"].ToString() == "True")
                        {
                            carRentalCost = authoDR["CarRentalCost"].ToString();
                            carRentalNotes = authoDR["CarRentalNotes"].ToString();
                        }
                        if (authoDR["AirFare"].ToString() == "True")
                        {
                            airfareCost = authoDR["AirFareCost"].ToString();
                            airfareNotes = authoDR["AirFareNotes"].ToString();
                        }
                        if (authoDR["Mileage"].ToString() == "True")
                        {
                            mileageCost = authoDR["MileageCost"].ToString();
                            mileageNotes = authoDR["MileageNotes"].ToString();
                        }
                        if (authoDR["OtherExpenses"].ToString() == "True")
                        {
                            otherExpensesCost = authoDR["OtherExpensesCost"].ToString();
                            otherExpensesNotes = authoDR["OtherExpensesNotes"].ToString();
                        }
                        destination = authoDR["Destination"].ToString();
                        username = authoDR["Name"].ToString() + " " + authoDR["LastName"].ToString();
                        userID = authoDR["UserID"].ToString();
                        estimateID = authoDR["TravelEstimateID"].ToString();
                        dgvAuthorizations.Rows.Add(startDate.ToShortDateString(), endDate.ToShortDateString(), travelEvent, username, travelPurpose, budgeted, total, destination, mealsCost, mealsNotes, registartionCost, registrationNotes, lodgingCost, lodgingNotes, airfareCost, airfareNotes, carRentalCost, carRentalNotes, mileageCost, mileageNotes, otherExpensesCost, otherExpensesNotes, estimateID, userID);
                    }
                    authoDR.Close();
                    localCon.Close();
                }
                CommonVariables.estimateMileageCost = 0;
            }
            else 
            {
                dgvAuthorizations.Rows.Clear();
                localCon.Open();
                //Guid userIDTR = new Guid(cbEmployee.SelectedValue.ToString());
                SqlCommand autho = new SqlCommand("SELECT a.TravelEstimateID,a.UserID,[DepartureDate],[ReturnDate],[TravelEvent],[TravelPurpose],[BudgetedTravel],[EstimatedTravelCost],[Meals],[MealsCost],[MealsNotes],[Registration],[RegistrationCost],[RegistrationNotes],[Lodgings],[LodgingsCost],[LodgingsNotes],[CarRental],[CarRentalCost],[CarRentalNotes],[AirFare],[AirFareCost],[AirFareNotes],[Mileage],[MileageCost],[MileageNotes],[MileagePersonal],[OtherExpenses],[OtherExpensesCost],[OtherExpensesNotes],[Destination],b.Name,b.LastName FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID  order by a.DepartureDate desc", localCon);
                SqlDataReader authoDR = autho.ExecuteReader();
                if (authoDR.HasRows)
                {


                    while (authoDR.Read())
                    {
                        DateTime startDate;
                        DateTime endDate;
                        string travelEvent = "";
                        string travelPurpose = "";
                        string budgeted = "";
                        string total = "";
                        string mealsCost = "";
                        string mealsNotes = "";
                        string registartionCost = "";
                        string registrationNotes = "";
                        string lodgingCost = "";
                        string lodgingNotes = "";
                        string airfareCost = "";
                        string airfareNotes = "";
                        string carRentalCost = "";
                        string carRentalNotes = "";
                        string mileageCost = "";
                        string mileageNotes = "";
                        string otherExpensesCost = "";
                        string otherExpensesNotes = "";
                        string estimateID = "";
                        string userID = "";
                        string username = "";
                        string destination = "";


                        startDate = Convert.ToDateTime(authoDR["DepartureDate"].ToString());
                        endDate = Convert.ToDateTime(authoDR["ReturnDate"].ToString());
                        travelEvent = authoDR["TravelEvent"].ToString();
                        travelPurpose = authoDR["TravelPurpose"].ToString();
                        if (authoDR["BudgetedTravel"].ToString() == "True")
                        {
                            budgeted = "Yes";
                        }
                        else
                        {
                            budgeted = "No";
                        }
                        total = authoDR["EstimatedTravelCost"].ToString();
                        if (authoDR["Meals"].ToString() == "True")
                        {
                            mealsCost = authoDR["MealsCost"].ToString();
                            mealsNotes = authoDR["MealsNotes"].ToString();
                        }
                        if (authoDR["Registration"].ToString() == "True")
                        {
                            registartionCost = authoDR["RegistrationCost"].ToString();
                            registrationNotes = authoDR["RegistrationNotes"].ToString();
                        }
                        if (authoDR["Lodgings"].ToString() == "True")
                        {
                            lodgingCost = authoDR["LodgingsCost"].ToString();
                            lodgingNotes = authoDR["LodgingsNotes"].ToString();
                        }
                        if (authoDR["CarRental"].ToString() == "True")
                        {
                            carRentalCost = authoDR["CarRentalCost"].ToString();
                            carRentalNotes = authoDR["CarRentalNotes"].ToString();
                        }
                        if (authoDR["AirFare"].ToString() == "True")
                        {
                            airfareCost = authoDR["AirFareCost"].ToString();
                            airfareNotes = authoDR["AirFareNotes"].ToString();
                        }
                        if (authoDR["Mileage"].ToString() == "True")
                        {
                            mileageCost = authoDR["MileageCost"].ToString();
                            mileageNotes = authoDR["MileageNotes"].ToString();
                        }
                        if (authoDR["OtherExpenses"].ToString() == "True")
                        {
                            otherExpensesCost = authoDR["OtherExpensesCost"].ToString();
                            otherExpensesNotes = authoDR["OtherExpensesNotes"].ToString();
                        }
                        destination = authoDR["Destination"].ToString();
                        username = authoDR["Name"].ToString() + " " + authoDR["LastName"].ToString();
                        userID = authoDR["UserID"].ToString();
                        estimateID = authoDR["TravelEstimateID"].ToString();
                        dgvAuthorizations.Rows.Add(startDate.ToShortDateString(), endDate.ToShortDateString(), travelEvent, username, travelPurpose, budgeted, total, destination, mealsCost, mealsNotes, registartionCost, registrationNotes, lodgingCost, lodgingNotes, airfareCost, airfareNotes, carRentalCost, carRentalNotes, mileageCost, mileageNotes, otherExpensesCost, otherExpensesNotes, estimateID, userID);
                    }
                    authoDR.Close();
                    localCon.Close();
                }
                CommonVariables.estimateMileageCost = 0;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            loadingData = true;
            int index = dgvAuthorizations.CurrentRow.Index;
            dtpDepartureDateValue.Value = Convert.ToDateTime(dgvAuthorizations.Rows[index].Cells[0].Value.ToString());
            dtpReturnDateValue.Value = Convert.ToDateTime(dgvAuthorizations.Rows[index].Cells[1].Value.ToString());
            txtTravelEvent.Text = dgvAuthorizations.Rows[index].Cells[2].Value.ToString();
            txtTravelPurpose.Text = dgvAuthorizations.Rows[index].Cells[4].Value.ToString();
            string budgetedValue = dgvAuthorizations.Rows[index].Cells[5].Value.ToString();
            if (budgetedValue == "Yes")
            {
                rbYes.Checked = true;
            }
            else
            {
                rbNo.Checked = true;
            }
            lblEstimatedTotalValue.Text = dgvAuthorizations.Rows[index].Cells[6].Value.ToString();
            txtDestination.Text = dgvAuthorizations.Rows[index].Cells[7].Value.ToString();
            if (dgvAuthorizations.Rows[index].Cells[8].Value.ToString() != "")
            {
                txtMealsCost.Text = dgvAuthorizations.Rows[index].Cells[8].Value.ToString();
                txtMealsNotes.Text = dgvAuthorizations.Rows[index].Cells[9].Value.ToString();
            }
            if (dgvAuthorizations.Rows[index].Cells[10].Value.ToString() != "")
            {
                txtRegistrationCost.Text = dgvAuthorizations.Rows[index].Cells[10].Value.ToString();
                txtRegistrationNotes.Text = dgvAuthorizations.Rows[index].Cells[11].Value.ToString();
            }
            if (dgvAuthorizations.Rows[index].Cells[12].Value.ToString() != "")
            {
                txtLodgingCost.Text = dgvAuthorizations.Rows[index].Cells[12].Value.ToString();
                txtLodgingNotes.Text = dgvAuthorizations.Rows[index].Cells[13].Value.ToString();
            }
            if (dgvAuthorizations.Rows[index].Cells[14].Value.ToString() != "")
            {
                txtAirfareCost.Text = dgvAuthorizations.Rows[index].Cells[14].Value.ToString();
                txtAirfareNotes.Text = dgvAuthorizations.Rows[index].Cells[15].Value.ToString();
            }
            if (dgvAuthorizations.Rows[index].Cells[16].Value.ToString() != "")
            {
                txtCarRentalCost.Text = dgvAuthorizations.Rows[index].Cells[16].Value.ToString();
                txtCarRentalNotes.Text = dgvAuthorizations.Rows[index].Cells[17].Value.ToString();
            }
            if (dgvAuthorizations.Rows[index].Cells[18].Value.ToString() != "")
            {
                txtMileageCost.Text = dgvAuthorizations.Rows[index].Cells[18].Value.ToString();
                txtMileageNotes.Text = dgvAuthorizations.Rows[index].Cells[19].Value.ToString();
            }
            if (dgvAuthorizations.Rows[index].Cells[20].Value.ToString() != "")
            {
                txtOtherExpensesCost.Text = dgvAuthorizations.Rows[index].Cells[20].Value.ToString();
                txtOtherExpNotes.Text = dgvAuthorizations.Rows[index].Cells[21].Value.ToString();
            }

            this.Size = new System.Drawing.Size(1419, 673);
            panel2.Enabled = false;
            panel1.Enabled = false;
            loadingData = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(726, 673);
            // panel2.Enabled = true;
            // panel1.Enabled = true;
            cleanForm();
        }

        private void cleanForm()
        {
            cleaning = true;
            dtpDepartureDateValue.Value = DateTime.Today;
            dtpReturnDateValue.Value = DateTime.Today.AddDays(1);
            txtTravelEvent.Text = "";
            txtTravelPurpose.Text = "";
            txtDestination.Text = "";
            rbYes.Checked = false;
            rbNo.Checked = false;
            lblEstimatedTotalValue.Text = "";
            txtMealsCost.Text = "";
            txtMealsNotes.Text = "";
            txtRegistrationCost.Text = "";
            txtRegistrationNotes.Text = "";
            txtLodgingCost.Text = "";
            txtLodgingNotes.Text = "";
            txtAirfareCost.Text = "";
            txtAirfareNotes.Text = "";
            txtCarRentalCost.Text = "";
            txtCarRentalNotes.Text = "";
            txtMileageCost.Text = "";
            txtMileageNotes.Text = "";
            txtOtherExpensesCost.Text = "";
            txtOtherExpNotes.Text = "";
            panel2.Enabled = true;
            panel1.Enabled = true;
            CommonVariables.estimateMileageCost = 0;
            cleaning = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                localCon.Open();
                double mealCost = 0;
                double registrationCost = 0;
                double lodingCost = 0;
                double airfareCost = 0;
                double carrentalCost = 0;
                double mileageCost = 0;
                double otherexpCost = 0;
                double total = 0;

                bool meal = false;
                bool registration = false;
                bool lodging = false;
                bool airfare = false;
                bool carrental = false;
                bool mileage = false;
                bool otherExpenses = false;



                if (txtMealsCost.Text != "")
                {
                    meal = true;
                    mealCost = Convert.ToDouble(txtMealsCost.Text);
                }
                if (txtRegistrationCost.Text != "")
                {
                    registration = true;
                    registrationCost = Convert.ToDouble(txtRegistrationCost.Text);
                }
                if (txtLodgingCost.Text != "")
                {
                    lodging = true;
                    lodingCost = Convert.ToDouble(txtLodgingCost.Text);
                }
                if (txtCarRentalCost.Text != "")
                {
                    carrental = true;
                    carrentalCost = Convert.ToDouble(txtCarRentalCost.Text);
                }
                if (txtAirfareCost.Text != "")
                {
                    airfare = true;
                    airfareCost = Convert.ToDouble(txtAirfareCost.Text);
                }
                if (txtMileageCost.Text != "")
                {
                    mileage = true;
                    mileageCost = Convert.ToDouble(txtMileageCost.Text);
                }
                if (txtOtherExpensesCost.Text != "")
                {
                    otherExpenses = true;
                    otherexpCost = Convert.ToDouble(txtOtherExpensesCost.Text);
                }

                total = mealCost + registrationCost + lodingCost + carrentalCost + lodingCost + airfareCost + mileageCost + otherexpCost;

                int index = dgvAuthorizations.CurrentRow.Index;
                Guid estID = new Guid(dgvAuthorizations.Rows[index].Cells[22].Value.ToString());
                SqlDataAdapter upAutho = new SqlDataAdapter();
                upAutho.UpdateCommand = new SqlCommand("UPDATE [dbo].[EstimateTravel] SET [DepartureDate] = @DepartureDate,[ReturnDate] = @ReturnDate,[TravelEvent] = @TravelEvent,[TravelPurpose] = @TravelPurpose,[BudgetedTravel] = @BudgetedTravel,[EstimatedTravelCost] = @EstimatedTravelCost,[Meals] = @Meals,[MealsCost] = @MealsCost,[MealsNotes] = @MealsNotes,[Registration] = @Registration,[RegistrationCost] = @RegistrationCost,[RegistrationNotes] = @RegistrationNotes,[Lodgings] = @Lodgings,[LodgingsCost] = @LodgingsCost,[LodgingsNotes] = @LodgingsNotes,[CarRental] = @CarRental,[CarRentalCost] = @CarRentalCost,[CarRentalNotes] = @CarRentalNotes,[AirFare] = @AirFare,[AirFareCost] = @AirFareCost,[AirFareNotes] = @AirFareNotes,[Mileage] = @Mileage,[MileageCost] = @MileageCost,[MileageNotes] = @MileageNotes,[MileagePersonal] = @MileagePersonal,[OtherExpenses] = @OtherExpenses,[OtherExpensesCost] = @OtherExpensesCost,[OtherExpensesNotes] = @OtherExpensesNotes,[Destination] = @Destination WHERE TravelEstimateID = '" + estID + "'", localCon);
                upAutho.UpdateCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = dtpDepartureDateValue.Value;
                upAutho.UpdateCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = dtpReturnDateValue.Value;
                upAutho.UpdateCommand.Parameters.Add("@TravelEvent", SqlDbType.NVarChar).Value = txtTravelEvent.Text;
                upAutho.UpdateCommand.Parameters.Add("@TravelPurpose", SqlDbType.NVarChar).Value = txtTravelPurpose.Text;
                if (rbYes.Checked)
                {
                    upAutho.UpdateCommand.Parameters.Add("@BudgetedTravel", SqlDbType.Bit).Value = true;
                }
                else if (rbNo.Checked)
                {
                    upAutho.UpdateCommand.Parameters.Add("@BudgetedTravel", SqlDbType.Bit).Value = false;
                }
                upAutho.UpdateCommand.Parameters.Add("@EstimatedTravelCost", SqlDbType.Float).Value = total;
                upAutho.UpdateCommand.Parameters.Add("@Meals", SqlDbType.Bit).Value = meal;
                if (meal)
                {
                    upAutho.UpdateCommand.Parameters.Add("@MealsNotes", SqlDbType.NVarChar).Value = txtMealsNotes.Text;
                    upAutho.UpdateCommand.Parameters.Add("@MealsCost", SqlDbType.Float).Value = mealCost;
                }
                else
                {
                    upAutho.UpdateCommand.Parameters.Add("@MealsNotes", SqlDbType.NVarChar).Value = DBNull.Value;
                    upAutho.UpdateCommand.Parameters.Add("@MealsCost", SqlDbType.Float).Value = DBNull.Value;
                }
                upAutho.UpdateCommand.Parameters.Add("@Registration", SqlDbType.Bit).Value = registration;
                if (registration)
                {
                    upAutho.UpdateCommand.Parameters.Add("@RegistrationNotes", SqlDbType.NVarChar).Value = txtRegistrationNotes.Text;
                    upAutho.UpdateCommand.Parameters.Add("@RegistrationCost", SqlDbType.Float).Value = registrationCost;
                }
                else
                {
                    upAutho.UpdateCommand.Parameters.Add("@RegistrationNotes", SqlDbType.NVarChar).Value = DBNull.Value;
                    upAutho.UpdateCommand.Parameters.Add("@RegistrationCost", SqlDbType.Float).Value = DBNull.Value;
                }
                upAutho.UpdateCommand.Parameters.Add("@Lodgings", SqlDbType.Bit).Value = lodging;
                if (lodging)
                {
                    upAutho.UpdateCommand.Parameters.Add("@LodgingsNotes", SqlDbType.NVarChar).Value = txtLodgingNotes.Text;
                    upAutho.UpdateCommand.Parameters.Add("@LodgingsCost", SqlDbType.Float).Value = lodingCost;
                }
                else
                {
                    upAutho.UpdateCommand.Parameters.Add("@LodgingsNotes", SqlDbType.NVarChar).Value = DBNull.Value;
                    upAutho.UpdateCommand.Parameters.Add("@LodgingsCost", SqlDbType.Float).Value = DBNull.Value;
                }
                upAutho.UpdateCommand.Parameters.Add("@CarRental", SqlDbType.Bit).Value = carrental;
                if (carrental)
                {
                    upAutho.UpdateCommand.Parameters.Add("@CarRentalNotes", SqlDbType.NVarChar).Value = txtCarRentalNotes.Text;
                    upAutho.UpdateCommand.Parameters.Add("@CarRentalCost", SqlDbType.Float).Value = carrentalCost;
                }
                else
                {
                    upAutho.UpdateCommand.Parameters.Add("@CarRentalNotes", SqlDbType.NVarChar).Value = DBNull.Value;
                    upAutho.UpdateCommand.Parameters.Add("@CarRentalCost", SqlDbType.Float).Value = DBNull.Value;
                }
                upAutho.UpdateCommand.Parameters.Add("@AirFare", SqlDbType.Bit).Value = airfare;
                if (airfare)
                {
                    upAutho.UpdateCommand.Parameters.Add("@AirFareNotes", SqlDbType.NVarChar).Value = txtAirfareNotes.Text;
                    upAutho.UpdateCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = airfareCost;
                }
                else
                {
                    upAutho.UpdateCommand.Parameters.Add("@AirFareNotes", SqlDbType.NVarChar).Value = DBNull.Value;
                    upAutho.UpdateCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = DBNull.Value;
                }
                upAutho.UpdateCommand.Parameters.Add("@Mileage", SqlDbType.Bit).Value = mileage;
                if (mileage)
                {
                    upAutho.UpdateCommand.Parameters.Add("@MileageNotes", SqlDbType.NVarChar).Value = txtMileageNotes.Text;
                    upAutho.UpdateCommand.Parameters.Add("@MileageCost", SqlDbType.Float).Value = mileageCost;
                    upAutho.UpdateCommand.Parameters.Add("@MileagePersonal", SqlDbType.Bit).Value = true;
                }
                else
                {
                    upAutho.UpdateCommand.Parameters.Add("@MileageNotes", SqlDbType.NVarChar).Value = DBNull.Value;
                    upAutho.UpdateCommand.Parameters.Add("@MileageCost", SqlDbType.Float).Value = DBNull.Value;
                    upAutho.UpdateCommand.Parameters.Add("@MileagePersonal", SqlDbType.Bit).Value = false;
                }
                upAutho.UpdateCommand.Parameters.Add("@OtherExpenses", SqlDbType.Bit).Value = otherExpenses;
                if (otherExpenses)
                {
                    upAutho.UpdateCommand.Parameters.Add("@OtherExpensesNotes", SqlDbType.NVarChar).Value = txtOtherExpNotes.Text;
                    upAutho.UpdateCommand.Parameters.Add("@OtherExpensesCost", SqlDbType.Float).Value = otherexpCost;
                }
                else
                {
                    upAutho.UpdateCommand.Parameters.Add("@OtherExpensesNotes", SqlDbType.NVarChar).Value = DBNull.Value;
                    upAutho.UpdateCommand.Parameters.Add("@OtherExpensesCost", SqlDbType.Float).Value = DBNull.Value;
                }
                upAutho.UpdateCommand.Parameters.Add("@Destination", SqlDbType.NVarChar).Value = txtDestination.Text;
                int updated = upAutho.UpdateCommand.ExecuteNonQuery();
                if (updated > 0)
                {
                    localCon.Close();
                    MessageBox.Show("Travel aithorization updated successfully");
                    refreshAuthorizations();
                    cleanForm();
                }

                localCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                localCon.Close();
            }
            this.Size = new System.Drawing.Size(726, 673);
        }

        private void txtMileageNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private double CalculateMealsCost()
        {
            double totalMeals = 0;
            TimeSpan difference = dtpReturnDateValue.Value.Subtract(dtpDepartureDateValue.Value);
            int totalDays = (int)difference.TotalDays;
            totalDays = totalDays + 1;
            totalMeals = totalDays * 40;
            return totalMeals;

        }

        private void dtpDepartureDateValue_ValueChanged(object sender, EventArgs e)
        {
            if (!loadingData && !loadingForm && !cleaning)
            {
                dtpReturnDateValue.MinDate = dtpDepartureDateValue.Value;
                txtMealsCost.Text = "";
                txtMealsCost.Text = CalculateMealsCost().ToString();
            }
        }

        private void dtpReturnDateValue_ValueChanged(object sender, EventArgs e)
        {
            if (!loadingData && !loadingForm && !cleaning)
            {
                txtMealsCost.Text = "";
                txtMealsCost.Text = CalculateMealsCost().ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CommonVariables.estimateMileageCost = 0;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MileageCalculator mc = new MileageCalculator();
            mc.ShowDialog();
            txtMileageCost.Text = CommonVariables.estimateMileageCost.ToString();
        }
    }
}
