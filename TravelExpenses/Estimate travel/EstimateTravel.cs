using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
//using iTextSharp;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using iTextSharp.text.xml;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using iText.Kernel.Pdf;
using iText.Kernel.XMP;
using iText.Kernel;
using iText.Forms;
using iText.Forms.Fields;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.IO.Font.Constants;

namespace TravelExpenses
{
    public partial class EstimateTravel : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        bool travelSaved = false;
        bool pdfCreated = false;
        string winUser = Environment.UserName;
        bool loading = false;


        public EstimateTravel()
        {
            InitializeComponent();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMileageCalculator_Click(object sender, EventArgs e)
        {

            MileageCalculator mc = new MileageCalculator();
            mc.ShowDialog();
            double milcost = Math.Round( CommonVariables.estimateMileageCost,2);
            txtMileageCost.Text = milcost.ToString();

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
            }
        }

        private void chxMeals_CheckedChanged(object sender, EventArgs e)
        {
            if (!loading)
            {
                if (chxMeals.Checked && txtMealsPerDiem.Text != "")
                {
                    txtMealsCost.Enabled = true;
                    txtMealsNotes.Enabled = true;
                    txtMealsCost.Text = CalculateMealsCost().ToString();
                }
                else if (!chxMeals.Checked)
                {
                    txtMealsCost.Enabled = false;
                    txtMealsNotes.Enabled = false;
                    txtMealsCost.Text = "";
                }
                else if (txtMealsPerDiem.Text == "" && chxMeals.Checked)
                {
                    MessageBox.Show("Enter the Meals Per Diem Rate");
                    chxMeals.Checked = false;
                }
            }
        }

        private void chxRegistration_CheckedChanged(object sender, EventArgs e)
        {
            if (chxRegistration.Checked)
            {
                txtRegistrationCost.Enabled = true;
                txtRegistrationNotes.Enabled = true;
            }
            else
            {
                txtRegistrationCost.Enabled = false;
                txtRegistrationNotes.Enabled = false;
            }
        }

        private void chxLodgings_CheckedChanged(object sender, EventArgs e)
        {
            if (chxLodgings.Checked)
            {
                txtLodgingsCost.Enabled = true;
                txtLodgingNotes.Enabled = true;
            }
            else
            {
                txtLodgingsCost.Enabled = false;
                txtLodgingNotes.Enabled = false;
            }
        }

        private void chxCarRental_CheckedChanged(object sender, EventArgs e)
        {
            if (chxCarRental.Checked)
            {
                txtCarRentalCost.Enabled = true;
                txtCarRentalNotes.Enabled = true;
            }
            else
            {
                txtCarRentalCost.Enabled = false;
                txtCarRentalNotes.Enabled = false;
            }
        }

        private void chxAirFare_CheckedChanged(object sender, EventArgs e)
        {
            if (chxAirFare.Checked)
            {
                txtAirFareCost.Enabled = true;
                txtAirFareNotes.Enabled = true;
            }
            else
            {
                txtAirFareCost.Enabled = false;
                txtAirFareNotes.Enabled = false;
            }
        }

        private void chxMileage_CheckedChanged(object sender, EventArgs e)
        {
            if (chxMileage.Checked)
            {
                txtMileageCost.Enabled = true;
                txtMileageNotes.Enabled = true;
                btnMileageCalculator.Enabled = true;
            }
            else
            {
                txtMileageCost.Enabled = false;
                txtMileageNotes.Enabled = false;
                btnMileageCalculator.Enabled = false;
                txtMileageCost.Text = "";
                txtMileageNotes.Text = "";
            }
        }

        private void chxOtherExpenses_CheckedChanged(object sender, EventArgs e)
        {
            if (chxOtherExpenses.Checked)
            {
                txtOtherExpensesCost.Enabled = true;
                txtOtherExpensesNotes.Enabled = true;
            }
            else
            {
                txtOtherExpensesCost.Enabled = false;
                txtOtherExpensesNotes.Enabled = false;
            }
        }

        private void EstimateTravel_Load(object sender, EventArgs e)
        {
            if (CommonVariables.viewEstimateId != "")
            {
                loading = true;
                btnSaveEstimatedTravel.Visible = false;
                dtpDepartureDate.Enabled = false;
                dtpReturnDate.Enabled = false;
                cbTravelEvent.Enabled = false;
                cbTravelPurpose.Enabled = false;
                txtOtherEvent.ReadOnly = true;
                txtOtherPurpose.ReadOnly = true;
                txtDestination.ReadOnly = true;

                localCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT [DepartureDate],[ReturnDate],[TravelEvent],[TravelPurpose],[BudgetedTravel],[EstimatedTravelCost],[Meals],[MealsCost],[MealsNotes],[Registration],[RegistrationCost],[RegistrationNotes],[Lodgings],[LodgingsCost],[LodgingsNotes],[CarRental],[CarRentalCost],[CarRentalNotes],[AirFare],[AirFareCost],[AirFareNotes],[Mileage],[MileageCost],[MileageNotes],[MileagePersonal],[OtherExpenses],[OtherExpensesCost],[OtherExpensesNotes],[Destination],[MealPerDiem] FROM [dbo].[EstimateTravel] where TravelEstimateID = '" + CommonVariables.viewEstimateId + "'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DateTime dep = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    dtpDepartureDate.Value = dep;
                    DateTime ret = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    dtpReturnDate.Value = ret;


                    string travEvent = dr["TravelEvent"].ToString();
                    if (cbTravelEvent.Items.Contains(travEvent))
                    {
                        cbTravelEvent.SelectedItem = travEvent;
                    }
                    else
                    {
                        cbTravelEvent.SelectedItem = "Other";
                        txtOtherEvent.Text = travEvent;
                    }
                    string travPurpose = dr["TravelPurpose"].ToString();
                    if (cbTravelPurpose.Items.Contains(travPurpose))
                    {
                        cbTravelPurpose.SelectedItem = travPurpose;
                    }
                    else
                    {
                        cbTravelPurpose.SelectedItem = "Other";
                        txtOtherPurpose.Text = travPurpose;
                    }
                    bool budgeted = Convert.ToBoolean(dr["BudgetedTravel"].ToString());
                    if (budgeted)
                    {
                        rbYesBudgetedTravel.Checked = true;
                    }
                    else
                    {
                        rbNoBudgetedTravel.Checked = true;
                    }
                    bool meal = Convert.ToBoolean(dr["Meals"].ToString());
                    if (meal)
                    {
                        chxMeals.Checked = true;
                        txtMealsCost.Text = dr["MealsCost"].ToString();
                        txtMealsNotes.Text = dr["MealsNotes"].ToString();
                        txtMealsPerDiem.Text = dr["MealPerDiem"].ToString();
                    }
                    bool registration = Convert.ToBoolean(dr["Registration"].ToString());
                    if (registration)
                    {
                        chxRegistration.Checked = true;
                        txtRegistrationCost.Text = dr["RegistrationCost"].ToString();
                        txtRegistrationNotes.Text = dr["RegistrationNotes"].ToString();
                    }
                    bool lodgings = Convert.ToBoolean(dr["Lodgings"].ToString());
                    if (lodgings)
                    {
                        chxLodgings.Checked = true;
                        txtLodgingsCost.Text = dr["LodgingsCost"].ToString();
                        txtLodgingNotes.Text = dr["LodgingsNotes"].ToString();
                    }
                    bool airfare = Convert.ToBoolean(dr["AirFare"].ToString());
                    if (airfare)
                    {
                        chxAirFare.Checked = true;
                        txtAirFareCost.Text = dr["AirFareCost"].ToString();
                        txtAirFareNotes.Text = dr["AirFareNotes"].ToString();
                    }
                    bool carRental = Convert.ToBoolean(dr["CarRental"].ToString());
                    if (carRental)
                    {
                        chxCarRental.Checked = true;
                        txtCarRentalCost.Text = dr["CarRentalCost"].ToString();
                        txtCarRentalNotes.Text = dr["CarRentalNotes"].ToString();
                    }
                    bool mileage = Convert.ToBoolean(dr["Mileage"].ToString());
                    if (mileage)
                    {
                        chxMileage.Checked = true;
                        txtMileageCost.Text = dr["MileageCost"].ToString();
                        txtMileageNotes.Text = dr["MileageNotes"].ToString();
                    }
                    bool otherExp = Convert.ToBoolean(dr["OtherExpenses"].ToString());
                    if (otherExp)
                    {
                        chxOtherExpenses.Checked = true;
                        txtOtherExpensesCost.Text = dr["OtherExpensesCost"].ToString();
                        txtOtherExpensesNotes.Text = dr["OtherExpensesNotes"].ToString();
                    }
                    if (dr["Destination"].ToString() != "")
                    {
                        txtDestination.Text = dr["Destination"].ToString();

                    }

                }
                loading = false;
            }
            else
            {
                dtpReturnDate.Value = DateTime.Today.AddDays(1);
            }

        }

        private bool validateData()
        {
            if (cbTravelEvent.SelectedIndex == -1)
            {
                MessageBox.Show("Select your Travel Event", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (cbTravelEvent.SelectedItem.ToString() == "Other" && txtOtherEvent.Text == "")
            {
                MessageBox.Show("Type your Travel Event", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (cbTravelPurpose.SelectedIndex == -1)
            {
                MessageBox.Show("Select your Travel Purpose", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (cbTravelPurpose.SelectedItem.ToString() == "Other" && txtOtherPurpose.Text == "")
            {
                MessageBox.Show("Type your Travel Purpose", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (chxMeals.Checked && txtMealsCost.Text == "")
            {
                MessageBox.Show("Type your Meals Cost", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (chxRegistration.Checked && txtRegistrationCost.Text == "")
            {
                MessageBox.Show("Type your Registration Cost", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (chxLodgings.Checked && txtLodgingsCost.Text == "")
            {
                MessageBox.Show("Type your Lodgings Cost", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (chxCarRental.Checked && txtCarRentalCost.Text == "")
            {
                MessageBox.Show("Type your Car Rental Cost", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (chxAirFare.Checked && txtAirFareCost.Text == "")
            {
                MessageBox.Show("Type your AirFare Cost", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (chxMileage.Checked && txtMileageCost.Text == "")
            {
                MessageBox.Show("Make a click on the + button and enter your estimated Mileage", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (chxOtherExpenses.Checked && txtOtherExpensesCost.Text == "")
            {
                MessageBox.Show("Type your Other Expenses Cost", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!chxMeals.Checked && !chxRegistration.Checked && !chxCarRental.Checked && !chxAirFare.Checked && !chxLodgings.Checked && !chxMileage.Checked && !chxOtherExpenses.Checked)
            {
                MessageBox.Show("Select at least one item for your travel", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDestination.Text == "")
            {
                MessageBox.Show("Type the City and State of your travel", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (chxMeals.Checked && txtMealsPerDiem.Text == "")
            {
                MessageBox.Show("Type the Meals Per Diem Rate", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        private void dtpDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            if (CommonVariables.viewEstimateId == "")
            {
                dtpReturnDate.MinDate = dtpDepartureDate.Value;
            }
            if (chxMeals.Checked)
            {
                txtMealsCost.Text = "";
                txtMealsCost.Text = CalculateMealsCost().ToString();
            }
        }

        private void btnSaveEstimatedTravel_Click(object sender, EventArgs e)
        {
            if (validateData())
            {


                /*SupervisorList sl = new SupervisorList();
                sl.ShowDialog();*/
                saveEstimateTravel();
                if (!CommonVariables.is_TPT)
                {
                    createTravelEstimatePDF();
                    if (travelSaved && pdfCreated)
                    {



                        this.Close();
                        MessageBox.Show("Travel estimation inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CommonVariables.isEstimate = true;
                        CommonVariables.showSignButton = true;
                        ViewPDF vp = new ViewPDF();
                        vp.Show();


                    }
                }
                else
                {
                    this.Close();
                    if (CommonVariables.isGroup)
                    {

                        MessageBox.Show("The travel authorizations were created successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The travel authorization was created successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //adding to the history trace table
                localCon.Open();
                Guid loginUser = new Guid(CommonVariables.user);
                SqlDataAdapter tadpt = new SqlDataAdapter();
                tadpt.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User_History_Trace] ([UserID],[Action],[Date]) VALUES (@UserID ,@Action,@Date)", localCon);
                tadpt.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = loginUser;
                tadpt.InsertCommand.Parameters.Add("@Action", SqlDbType.NVarChar).Value = "Travel Authorization Created";
                tadpt.InsertCommand.Parameters.Add("@Date", SqlDbType.NVarChar).Value = DateTime.Now;
                tadpt.InsertCommand.ExecuteNonQuery();
                localCon.Close();

                cleanFields();
            }
        }

        private void txtMealsCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
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

        private void txtLodgingsCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void createTravelEstimatePDF()
        {

            localCon.Open();
            string name = "";
            string lastname = "";
            string district = "";
            string department = "";
            string fullName = "";
            string username = "";
            CommonVariables.filePath = "";

            SqlCommand cmdUser = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] where UserID = '" + CommonVariables.user + "'", localCon);
            SqlDataReader drUser = cmdUser.ExecuteReader();
            while (drUser.Read())
            {
                name = drUser["Name"].ToString();
                lastname = drUser["LastName"].ToString();
                district = drUser["District"].ToString();
                department = drUser["Department"].ToString();
                username = drUser["Username"].ToString();
            }
            drUser.Close();
            fullName = name + " " + lastname;

            string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form(Estimated).pdf";
            string pdfName = username + "_" + CommonVariables.et.DepartureDate.ToShortDateString() + "_" + "to" + "_" + CommonVariables.et.ReturnDate.ToShortDateString() + ".pdf";
            pdfName = pdfName.Replace("/", "-");
            string newFile = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\travel_form(Estimated)_" + pdfName;
            CommonVariables.filePath = newFile;

            //new code for net 6
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(pdfTemplate), new PdfWriter(newFile));
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
            IDictionary<String, PdfFormField> fields = form.GetAllFormFields();
            PdfFormField toSet;
            //end of new code

            PdfReader pdfReader = new PdfReader(pdfTemplate);

            /*PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create)); //commented for net6
            AcroFields pdfFormFields = pdfStamper.AcroFields;*/ //commented for net6


            try
            {
                //user details
                //pdfFormFields.SetField("Full Name", fullName); //commented for net6
                fields.TryGetValue("Full Name", out toSet);
                toSet.SetValue(fullName);

                //pdfFormFields.SetField("District", district); //commented for net6
                fields.TryGetValue("District", out toSet);
                toSet.SetValue(district);

                //pdfFormFields.SetField("Department", department); //commented for net6
                fields.TryGetValue("Department", out toSet);
                toSet.SetValue(department);

                //travel details
                //pdfFormFields.SetField("Travel Event", CommonVariables.et.TravelEvent); //commented for net6
                fields.TryGetValue("Travel Event", out toSet);
                toSet.SetValue(CommonVariables.et.TravelEvent);

                //pdfFormFields.SetField("Travel Purpose", CommonVariables.et.TravelPurpose); //commented for net6
                fields.TryGetValue("Travel Purpose", out toSet);
                toSet.SetValue(CommonVariables.et.TravelPurpose);

                //pdfFormFields.SetField("Departure Date", CommonVariables.et.DepartureDate.ToString()); //commented for net6
                fields.TryGetValue("Departure Date", out toSet);
                toSet.SetValue(CommonVariables.et.DepartureDate.ToString());

                //pdfFormFields.SetField("Return Date", CommonVariables.et.ReturnDate.ToString()); //commented for net6
                fields.TryGetValue("Return Date", out toSet);
                toSet.SetValue(CommonVariables.et.ReturnDate.ToString());

                //pdfFormFields.SetField("Estimated Travel Total", CommonVariables.et.TravelEstimateTotal.ToString()); //commented for net6
                fields.TryGetValue("Estimated Travel Total", out toSet);
                toSet.SetValue(CommonVariables.et.TravelEstimateTotal.ToString());

                //pdfFormFields.SetField("Destination", CommonVariables.et.Destination); //commented for net6
                fields.TryGetValue("Destination", out toSet);
                toSet.SetValue(CommonVariables.et.Destination);

                //string[] chxvalues = pdfFormFields.GetAppearanceStates("Travel_Budgeted_No"); //commented for net6
                if (CommonVariables.et.TravelBudgeted)
                {
                    //pdfFormFields.SetField("Travel_Budgeted_Yes", "Choice1"); //commented for net6
                    fields.TryGetValue("Travel_Budgeted_Yes", out toSet);
                    toSet.SetValue("Choice1");

                    //pdfFormFields.SetField("Travel_Budgeted_No", "Off"); //commented for net6
                    fields.TryGetValue("Travel_Budgeted_No", out toSet);
                    toSet.SetValue("Off");
                }
                else
                {
                    //pdfFormFields.SetField("Travel_Budgeted_No", "Choice2"); //commented for net6
                    fields.TryGetValue("Travel_Budgeted_No", out toSet);
                    toSet.SetValue("Choice2");

                    //pdfFormFields.SetField("Travel_Budgeted_Yes", "Off"); //commented for net6
                    fields.TryGetValue("Travel_Budgeted_Yes", out toSet);
                    toSet.SetValue("Off");
                }
                if (CommonVariables.et.MileagePersonal)
                {
                    //pdfFormFields.SetField("District_Vehicle_No", "Choice2"); //commented for net6
                    fields.TryGetValue("District_Vehicle_No", out toSet);
                    toSet.SetValue("Choice2");

                    //pdfFormFields.SetField("District_Vehicle_Yes", "Off"); //commented for net6
                    fields.TryGetValue("District_Vehicle_Yes", out toSet);
                    toSet.SetValue("Off");

                }
                else
                {
                    //pdfFormFields.SetField("District_Vehicle_Yes", "Choice1"); //commented for net6
                    fields.TryGetValue("District_Vehicle_Yes", out toSet);
                    toSet.SetValue("Choice1");

                    //pdfFormFields.SetField("District_Vehicle_No", "Off"); //commented for net6
                    fields.TryGetValue("District_Vehicle_No", out toSet);
                    toSet.SetValue("Off");
                }

                //travel items
                if (CommonVariables.et.Meals)
                {
                    //pdfFormFields.SetField("Estimated CostMeals", CommonVariables.et.MealsCost.ToString()); //commented for net6
                    fields.TryGetValue("Estimated CostMeals", out toSet);
                    toSet.SetValue(CommonVariables.et.MealsCost.ToString());

                    //pdfFormFields.SetField("NotesMeals", CommonVariables.et.MealsNotes.ToString()); //commented for net6
                    fields.TryGetValue("NotesMeals", out toSet);
                    toSet.SetValue(CommonVariables.et.MealsNotes.ToString());

                    //pdfFormFields.SetField("Meals Per Diem Rate", CommonVariables.et.MealPerDiem.ToString()); //commented for net6
                    fields.TryGetValue("Meals Per Diem Rate", out toSet);
                    toSet.SetValue(CommonVariables.et.MealPerDiem.ToString());

                }
                if (CommonVariables.et.Registration)
                {
                    //pdfFormFields.SetField("Estimated CostRegistration", CommonVariables.et.ResgistrationCost.ToString()); //commented for net6
                    fields.TryGetValue("Estimated CostRegistration", out toSet);
                    toSet.SetValue(CommonVariables.et.ResgistrationCost.ToString());

                    //pdfFormFields.SetField("NotesRegistration", CommonVariables.et.RegistrationNotes.ToString()); //commented for net6
                    fields.TryGetValue("NotesRegistration", out toSet);
                    toSet.SetValue(CommonVariables.et.RegistrationNotes.ToString());
                }
                if (CommonVariables.et.Lodgings)
                {
                    //pdfFormFields.SetField("Estimated CostLodgings", CommonVariables.et.LodgingsCost.ToString()); //commented for net6
                    fields.TryGetValue("Estimated CostLodgings", out toSet);
                    toSet.SetValue(CommonVariables.et.LodgingsCost.ToString());

                    //pdfFormFields.SetField("NotesLodgings", CommonVariables.et.LodgingsNotes.ToString()); //commented for net6
                    fields.TryGetValue("NotesLodgings", out toSet);
                    toSet.SetValue(CommonVariables.et.LodgingsNotes.ToString());
                }
                if (CommonVariables.et.CarRental)
                {
                    //pdfFormFields.SetField("Estimated CostCar Rental", CommonVariables.et.CarRentalCost.ToString()); //commented for net6
                    fields.TryGetValue("Estimated CostCar Rental", out toSet);
                    toSet.SetValue(CommonVariables.et.CarRentalCost.ToString());

                    //pdfFormFields.SetField("NotesCar Rental", CommonVariables.et.CarRentalNotes.ToString()); //commented for net6
                    fields.TryGetValue("NotesCar Rental", out toSet);
                    toSet.SetValue(CommonVariables.et.CarRentalNotes.ToString());
                }
                if (CommonVariables.et.AirFare)
                {
                    //pdfFormFields.SetField("Estimated CostAir Fare", CommonVariables.et.AirFareCost.ToString()); //commented for net6
                    fields.TryGetValue("Estimated CostAir Fare", out toSet);
                    toSet.SetValue(CommonVariables.et.AirFareCost.ToString());

                    //pdfFormFields.SetField("NotesAir Fare", CommonVariables.et.AirFareNotes.ToString()); //commented for net6
                    fields.TryGetValue("NotesAir Fare", out toSet);
                    toSet.SetValue(CommonVariables.et.AirFareNotes.ToString());
                }
                if (CommonVariables.et.Mileage)
                {
                    //pdfFormFields.SetField("Estimated CostMileage", CommonVariables.et.MileageCost.ToString()); //commented for net6
                    fields.TryGetValue("Estimated CostMileage", out toSet);
                    toSet.SetValue(CommonVariables.et.MileageCost.ToString());

                    //pdfFormFields.SetField("NotesMileage", CommonVariables.et.MileageNotes.ToString()); //commented for net6
                    fields.TryGetValue("NotesMileage", out toSet);
                    toSet.SetValue(CommonVariables.et.MileageNotes.ToString());
                }
                if (CommonVariables.et.OtherExpenses)
                {
                    //pdfFormFields.SetField("Estimated CostOther Expenses", CommonVariables.et.OtherExpensesCost.ToString()); //commented for net6
                    fields.TryGetValue("Estimated CostOther Expenses", out toSet);
                    toSet.SetValue(CommonVariables.et.OtherExpensesCost.ToString());

                    //pdfFormFields.SetField("NotesOther Expenses", CommonVariables.et.OtherExpensesNotes.ToString()); //commented for net6
                    fields.TryGetValue("NotesOther Expenses", out toSet);
                    toSet.SetValue(CommonVariables.et.OtherExpensesNotes.ToString());
                }


                pdfCreated = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            form.FlattenFields();
            pdfDoc.Close();
            //pdfStamper.Close(); //commented for net6
            localCon.Close();


        }

        private void saveEstimateTravel()
        {
            bool valid = validateData();
            localCon.Open();
            if (valid)
            {
                Guid userID = new Guid(CommonVariables.user);
                CommonVariables.et.DepartureDate = dtpDepartureDate.Value;
                CommonVariables.et.ReturnDate = dtpReturnDate.Value;
                double totalTravel = 0;
                if (cbTravelEvent.SelectedItem.ToString() == "Other")
                {
                    CommonVariables.et.TravelEvent = txtOtherEvent.Text;
                }
                else
                {
                    CommonVariables.et.TravelEvent = cbTravelEvent.SelectedItem.ToString();
                }
                if (cbTravelPurpose.SelectedItem.ToString() == "Other")
                {
                    CommonVariables.et.TravelPurpose = txtOtherPurpose.Text;
                }
                else
                {
                    CommonVariables.et.TravelPurpose = cbTravelPurpose.SelectedItem.ToString();
                }
                if (rbYesBudgetedTravel.Checked)
                {
                    CommonVariables.et.TravelBudgeted = true;
                }
                if (rbNoBudgetedTravel.Checked)
                {
                    CommonVariables.et.TravelBudgeted = false;
                }
                if (chxMeals.Checked)
                {
                    CommonVariables.et.Meals = true;
                    CommonVariables.et.MealsCost = Convert.ToDouble(txtMealsCost.Text);
                    totalTravel = totalTravel + Convert.ToDouble(txtMealsCost.Text);
                    CommonVariables.et.MealsNotes = txtMealsNotes.Text;
                    CommonVariables.et.MealPerDiem = Convert.ToDouble(txtMealsPerDiem.Text);
                }
                else
                {
                    CommonVariables.et.Meals = false;
                }

                if (chxRegistration.Checked)
                {
                    CommonVariables.et.Registration = true;
                    CommonVariables.et.ResgistrationCost = Convert.ToDouble(txtRegistrationCost.Text);
                    totalTravel = totalTravel + Convert.ToDouble(txtRegistrationCost.Text);
                    CommonVariables.et.RegistrationNotes = txtRegistrationNotes.Text;
                }
                else
                {
                    CommonVariables.et.Registration = false;
                }
                if (chxLodgings.Checked)
                {
                    CommonVariables.et.Lodgings = true;
                    CommonVariables.et.LodgingsCost = Convert.ToDouble(txtLodgingsCost.Text);
                    totalTravel = totalTravel + Convert.ToDouble(txtLodgingsCost.Text);
                    CommonVariables.et.LodgingsNotes = txtLodgingNotes.Text;
                }
                else
                {
                    CommonVariables.et.Lodgings = false;
                }
                if (chxCarRental.Checked)
                {
                    CommonVariables.et.CarRental = true;
                    CommonVariables.et.CarRentalCost = Convert.ToDouble(txtCarRentalCost.Text);
                    totalTravel = totalTravel + Convert.ToDouble(txtCarRentalCost.Text);
                    CommonVariables.et.CarRentalNotes = txtCarRentalNotes.Text;
                }
                else
                {
                    CommonVariables.et.CarRental = false;
                }
                if (chxAirFare.Checked)
                {
                    CommonVariables.et.AirFare = true;
                    CommonVariables.et.AirFareCost = Convert.ToDouble(txtAirFareCost.Text);
                    totalTravel = totalTravel + Convert.ToDouble(txtAirFareCost.Text);
                    CommonVariables.et.AirFareNotes = txtAirFareNotes.Text;
                }
                else
                {
                    CommonVariables.et.AirFare = false;
                }
                if (chxMileage.Checked)
                {
                    CommonVariables.et.Mileage = true;
                    CommonVariables.et.MileageCost = Convert.ToDouble(txtMileageCost.Text);
                    totalTravel = totalTravel + Convert.ToDouble(txtMileageCost.Text);
                    CommonVariables.et.MileageNotes = txtMileageNotes.Text;
                    CommonVariables.et.MileagePersonal = true;
                }
                else
                {
                    CommonVariables.et.Mileage = false;
                    CommonVariables.et.MileagePersonal = false;
                }
                if (chxOtherExpenses.Checked)
                {
                    CommonVariables.et.OtherExpenses = true;
                    CommonVariables.et.OtherExpensesCost = Convert.ToDouble(txtOtherExpensesCost.Text);
                    totalTravel = totalTravel + Convert.ToDouble(txtOtherExpensesCost.Text);
                    CommonVariables.et.OtherExpensesNotes = txtOtherExpensesNotes.Text;
                }
                else
                {
                    CommonVariables.et.OtherExpenses = false;
                }

                CommonVariables.et.Destination = txtDestination.Text;
                CommonVariables.et.TravelEstimateTotal = totalTravel;


                try
                {
                    if (CommonVariables.is_TPT)
                    {
                        if (CommonVariables.isGroup)
                        {
                            for (int i = 0; i < CommonVariables.usersID.Count; i++)
                            {
                                Guid tpUID = new Guid(CommonVariables.usersID[i]);
                                SqlDataAdapter cmdET = new SqlDataAdapter();
                                cmdET.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[EstimateTravel] ([UserID],[DepartureDate],[ReturnDate],[TravelEvent],[TravelPurpose],[BudgetedTravel],[EstimatedTravelCost],[Meals],[MealsCost],[MealsNotes],[Registration],[RegistrationCost],[RegistrationNotes],[Lodgings],[LodgingsCost],[LodgingsNotes],[CarRental],[CarRentalCost],[CarRentalNotes],[AirFare],[AirFareCost],[AirFareNotes],[Mileage],[MileageCost],[MileageNotes],[MileagePersonal],[OtherExpenses],[OtherExpensesCost],[OtherExpensesNotes],[Destination],[MealPerDiem])  OUTPUT inserted.TravelEstimateID VALUES (@UserID,@DepartureDate,@ReturnDate,@TravelEvent,@TravelPurpose,@BudgetedTravel,@EstimatedTravelCost,@Meals,@MealsCost,@MealsNotes,@Registration,@RegistrationCost,@RegistrationNotes,@Lodgings,@LodgingsCost,@LodgingsNotes,@CarRental,@CarRentalCost,@CarRentalNotes,@AirFare,@AirFareCost,@AirFareNotes,@Mileage,@MileageCost,@MileageNotes,@MileagePersonal,@OtherExpenses,@OtherExpensesCost,@OtherExpensesNotes,@Destination,@MealPerDiem)", localCon);
                                cmdET.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = tpUID;
                                cmdET.InsertCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = dtpDepartureDate.Value;
                                cmdET.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = dtpReturnDate.Value;
                                cmdET.InsertCommand.Parameters.Add("@TravelEvent", SqlDbType.NVarChar).Value = CommonVariables.et.TravelEvent;
                                cmdET.InsertCommand.Parameters.Add("@TravelPurpose", SqlDbType.NVarChar).Value = CommonVariables.et.TravelPurpose;
                                cmdET.InsertCommand.Parameters.Add("@BudgetedTravel", SqlDbType.Bit).Value = CommonVariables.et.TravelBudgeted;
                                cmdET.InsertCommand.Parameters.Add("@EstimatedTravelCost", SqlDbType.Float).Value = totalTravel;
                                cmdET.InsertCommand.Parameters.Add("@Meals", SqlDbType.Bit).Value = CommonVariables.et.Meals;
                                if (CommonVariables.et.MealsCost > 0)
                                {
                                    cmdET.InsertCommand.Parameters.Add("@MealsCost", SqlDbType.Float).Value = CommonVariables.et.MealsCost;
                                    cmdET.InsertCommand.Parameters.Add("@MealPerDiem", SqlDbType.Float).Value = CommonVariables.et.MealPerDiem;
                                }
                                else
                                {
                                    cmdET.InsertCommand.Parameters.Add("@MealsCost", SqlDbType.Float).Value = DBNull.Value;
                                    cmdET.InsertCommand.Parameters.Add("@MealPerDiem", SqlDbType.Float).Value = DBNull.Value;
                                }
                                cmdET.InsertCommand.Parameters.Add("@MealsNotes", SqlDbType.NVarChar).Value = txtMealsNotes.Text;
                                cmdET.InsertCommand.Parameters.Add("@Registration", SqlDbType.Bit).Value = CommonVariables.et.Registration;
                                if (CommonVariables.et.ResgistrationCost > 0)
                                {
                                    cmdET.InsertCommand.Parameters.Add("@RegistrationCost", SqlDbType.Float).Value = CommonVariables.et.ResgistrationCost;
                                }
                                else
                                {
                                    cmdET.InsertCommand.Parameters.Add("@RegistrationCost", SqlDbType.Float).Value = DBNull.Value;
                                }
                                cmdET.InsertCommand.Parameters.Add("@RegistrationNotes", SqlDbType.NVarChar).Value = txtRegistrationNotes.Text;
                                cmdET.InsertCommand.Parameters.Add("@Lodgings", SqlDbType.Bit).Value = CommonVariables.et.Lodgings;
                                if (CommonVariables.et.LodgingsCost > 0)
                                {
                                    cmdET.InsertCommand.Parameters.Add("@LodgingsCost", SqlDbType.Float).Value = CommonVariables.et.LodgingsCost;
                                }
                                else
                                {
                                    cmdET.InsertCommand.Parameters.Add("@LodgingsCost", SqlDbType.Float).Value = DBNull.Value;
                                }
                                cmdET.InsertCommand.Parameters.Add("@LodgingsNotes", SqlDbType.NVarChar).Value = txtLodgingNotes.Text;
                                cmdET.InsertCommand.Parameters.Add("@CarRental", SqlDbType.Bit).Value = CommonVariables.et.CarRental;
                                if (CommonVariables.et.CarRentalCost > 0)
                                {
                                    cmdET.InsertCommand.Parameters.Add("@CarRentalCost", SqlDbType.Float).Value = CommonVariables.et.CarRentalCost;
                                }
                                else
                                {
                                    cmdET.InsertCommand.Parameters.Add("@CarRentalCost", SqlDbType.Float).Value = DBNull.Value;
                                }
                                cmdET.InsertCommand.Parameters.Add("@CarRentalNotes", SqlDbType.NVarChar).Value = txtCarRentalNotes.Text;
                                cmdET.InsertCommand.Parameters.Add("@AirFare", SqlDbType.Bit).Value = CommonVariables.et.AirFare;
                                if (CommonVariables.et.AirFareCost > 0)
                                {
                                    cmdET.InsertCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = CommonVariables.et.AirFareCost;
                                }
                                else
                                {
                                    cmdET.InsertCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = DBNull.Value;
                                }
                                cmdET.InsertCommand.Parameters.Add("@AirFareNotes", SqlDbType.NVarChar).Value = txtAirFareNotes.Text;
                                cmdET.InsertCommand.Parameters.Add("@Mileage", SqlDbType.Bit).Value = CommonVariables.et.Mileage;
                                if (CommonVariables.et.MileageCost > 0)
                                {
                                    cmdET.InsertCommand.Parameters.Add("@MileageCost", SqlDbType.Float).Value = CommonVariables.et.MileageCost;
                                }
                                else
                                {
                                    cmdET.InsertCommand.Parameters.Add("@MileageCost", SqlDbType.Float).Value = DBNull.Value;
                                }
                                cmdET.InsertCommand.Parameters.Add("@MileageNotes", SqlDbType.NVarChar).Value = txtMileageNotes.Text;
                                cmdET.InsertCommand.Parameters.Add("@MileagePersonal", SqlDbType.Bit).Value = CommonVariables.et.MileagePersonal;
                                cmdET.InsertCommand.Parameters.Add("@OtherExpenses", SqlDbType.Bit).Value = CommonVariables.et.OtherExpenses;
                                if (CommonVariables.et.OtherExpensesCost > 0)
                                {
                                    cmdET.InsertCommand.Parameters.Add("@OtherExpensesCost", SqlDbType.Float).Value = CommonVariables.et.OtherExpensesCost;
                                }
                                else
                                {
                                    cmdET.InsertCommand.Parameters.Add("@OtherExpensesCost", SqlDbType.Float).Value = DBNull.Value;
                                }
                                cmdET.InsertCommand.Parameters.Add("@OtherExpensesNotes", SqlDbType.NVarChar).Value = txtOtherExpensesNotes.Text;
                                cmdET.InsertCommand.Parameters.Add("@Destination", SqlDbType.NVarChar).Value = CommonVariables.et.Destination;

                                Guid rows = new Guid();

                                rows = (Guid)cmdET.InsertCommand.ExecuteScalar();

                                SqlDataAdapter es = new SqlDataAdapter();
                                es.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[EstimateTravel_Status] ([TravelEstimateID],[Status]) VALUES (@TravelEstimateID,@Status)", localCon);
                                es.InsertCommand.Parameters.Add("@TravelEstimateID", SqlDbType.UniqueIdentifier).Value = rows;
                                es.InsertCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Pending Supervisor";
                                int status = es.InsertCommand.ExecuteNonQuery();
                                if (rows.ToString() != "" && status > 0)
                                {
                                    travelSaved = true;

                                }
                            }
                        }
                        else
                        {
                            Guid tpUID = new Guid(CommonVariables.tpt_UserID);
                            SqlDataAdapter cmdET = new SqlDataAdapter();
                            cmdET.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[EstimateTravel] ([UserID],[DepartureDate],[ReturnDate],[TravelEvent],[TravelPurpose],[BudgetedTravel],[EstimatedTravelCost],[Meals],[MealsCost],[MealsNotes],[Registration],[RegistrationCost],[RegistrationNotes],[Lodgings],[LodgingsCost],[LodgingsNotes],[CarRental],[CarRentalCost],[CarRentalNotes],[AirFare],[AirFareCost],[AirFareNotes],[Mileage],[MileageCost],[MileageNotes],[MileagePersonal],[OtherExpenses],[OtherExpensesCost],[OtherExpensesNotes],[Destination],[MealPerDiem])  OUTPUT inserted.TravelEstimateID VALUES (@UserID,@DepartureDate,@ReturnDate,@TravelEvent,@TravelPurpose,@BudgetedTravel,@EstimatedTravelCost,@Meals,@MealsCost,@MealsNotes,@Registration,@RegistrationCost,@RegistrationNotes,@Lodgings,@LodgingsCost,@LodgingsNotes,@CarRental,@CarRentalCost,@CarRentalNotes,@AirFare,@AirFareCost,@AirFareNotes,@Mileage,@MileageCost,@MileageNotes,@MileagePersonal,@OtherExpenses,@OtherExpensesCost,@OtherExpensesNotes,@Destination,@MealPerDiem)", localCon);
                            cmdET.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = tpUID;
                            cmdET.InsertCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = dtpDepartureDate.Value;
                            cmdET.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = dtpReturnDate.Value;
                            cmdET.InsertCommand.Parameters.Add("@TravelEvent", SqlDbType.NVarChar).Value = CommonVariables.et.TravelEvent;
                            cmdET.InsertCommand.Parameters.Add("@TravelPurpose", SqlDbType.NVarChar).Value = CommonVariables.et.TravelPurpose;
                            cmdET.InsertCommand.Parameters.Add("@BudgetedTravel", SqlDbType.Bit).Value = CommonVariables.et.TravelBudgeted;
                            cmdET.InsertCommand.Parameters.Add("@EstimatedTravelCost", SqlDbType.Float).Value = totalTravel;
                            cmdET.InsertCommand.Parameters.Add("@Meals", SqlDbType.Bit).Value = CommonVariables.et.Meals;
                            if (CommonVariables.et.MealsCost > 0)
                            {
                                cmdET.InsertCommand.Parameters.Add("@MealsCost", SqlDbType.Float).Value = CommonVariables.et.MealsCost;
                                cmdET.InsertCommand.Parameters.Add("@MealPerDiem", SqlDbType.Float).Value = CommonVariables.et.MealPerDiem;
                            }
                            else
                            {
                                cmdET.InsertCommand.Parameters.Add("@MealsCost", SqlDbType.Float).Value = DBNull.Value;
                                cmdET.InsertCommand.Parameters.Add("@MealPerDiem", SqlDbType.Float).Value = DBNull.Value;
                            }
                            cmdET.InsertCommand.Parameters.Add("@MealsNotes", SqlDbType.NVarChar).Value = txtMealsNotes.Text;
                            cmdET.InsertCommand.Parameters.Add("@Registration", SqlDbType.Bit).Value = CommonVariables.et.Registration;
                            if (CommonVariables.et.ResgistrationCost > 0)
                            {
                                cmdET.InsertCommand.Parameters.Add("@RegistrationCost", SqlDbType.Float).Value = CommonVariables.et.ResgistrationCost;
                            }
                            else
                            {
                                cmdET.InsertCommand.Parameters.Add("@RegistrationCost", SqlDbType.Float).Value = DBNull.Value;
                            }
                            cmdET.InsertCommand.Parameters.Add("@RegistrationNotes", SqlDbType.NVarChar).Value = txtRegistrationNotes.Text;
                            cmdET.InsertCommand.Parameters.Add("@Lodgings", SqlDbType.Bit).Value = CommonVariables.et.Lodgings;
                            if (CommonVariables.et.LodgingsCost > 0)
                            {
                                cmdET.InsertCommand.Parameters.Add("@LodgingsCost", SqlDbType.Float).Value = CommonVariables.et.LodgingsCost;
                            }
                            else
                            {
                                cmdET.InsertCommand.Parameters.Add("@LodgingsCost", SqlDbType.Float).Value = DBNull.Value;
                            }
                            cmdET.InsertCommand.Parameters.Add("@LodgingsNotes", SqlDbType.NVarChar).Value = txtLodgingNotes.Text;
                            cmdET.InsertCommand.Parameters.Add("@CarRental", SqlDbType.Bit).Value = CommonVariables.et.CarRental;
                            if (CommonVariables.et.CarRentalCost > 0)
                            {
                                cmdET.InsertCommand.Parameters.Add("@CarRentalCost", SqlDbType.Float).Value = CommonVariables.et.CarRentalCost;
                            }
                            else
                            {
                                cmdET.InsertCommand.Parameters.Add("@CarRentalCost", SqlDbType.Float).Value = DBNull.Value;
                            }
                            cmdET.InsertCommand.Parameters.Add("@CarRentalNotes", SqlDbType.NVarChar).Value = txtCarRentalNotes.Text;
                            cmdET.InsertCommand.Parameters.Add("@AirFare", SqlDbType.Bit).Value = CommonVariables.et.AirFare;
                            if (CommonVariables.et.AirFareCost > 0)
                            {
                                cmdET.InsertCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = CommonVariables.et.AirFareCost;
                            }
                            else
                            {
                                cmdET.InsertCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = DBNull.Value;
                            }
                            cmdET.InsertCommand.Parameters.Add("@AirFareNotes", SqlDbType.NVarChar).Value = txtAirFareNotes.Text;
                            cmdET.InsertCommand.Parameters.Add("@Mileage", SqlDbType.Bit).Value = CommonVariables.et.Mileage;
                            if (CommonVariables.et.MileageCost > 0)
                            {
                                cmdET.InsertCommand.Parameters.Add("@MileageCost", SqlDbType.Float).Value = CommonVariables.et.MileageCost;
                            }
                            else
                            {
                                cmdET.InsertCommand.Parameters.Add("@MileageCost", SqlDbType.Float).Value = DBNull.Value;
                            }
                            cmdET.InsertCommand.Parameters.Add("@MileageNotes", SqlDbType.NVarChar).Value = txtMileageNotes.Text;
                            cmdET.InsertCommand.Parameters.Add("@MileagePersonal", SqlDbType.Bit).Value = CommonVariables.et.MileagePersonal;
                            cmdET.InsertCommand.Parameters.Add("@OtherExpenses", SqlDbType.Bit).Value = CommonVariables.et.OtherExpenses;
                            if (CommonVariables.et.OtherExpensesCost > 0)
                            {
                                cmdET.InsertCommand.Parameters.Add("@OtherExpensesCost", SqlDbType.Float).Value = CommonVariables.et.OtherExpensesCost;
                            }
                            else
                            {
                                cmdET.InsertCommand.Parameters.Add("@OtherExpensesCost", SqlDbType.Float).Value = DBNull.Value;
                            }
                            cmdET.InsertCommand.Parameters.Add("@OtherExpensesNotes", SqlDbType.NVarChar).Value = txtOtherExpensesNotes.Text;
                            cmdET.InsertCommand.Parameters.Add("@Destination", SqlDbType.NVarChar).Value = CommonVariables.et.Destination;

                            Guid rows = new Guid();

                            rows = (Guid)cmdET.InsertCommand.ExecuteScalar();

                            SqlDataAdapter es = new SqlDataAdapter();
                            es.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[EstimateTravel_Status] ([TravelEstimateID],[Status]) VALUES (@TravelEstimateID,@Status)", localCon);
                            es.InsertCommand.Parameters.Add("@TravelEstimateID", SqlDbType.UniqueIdentifier).Value = rows;
                            es.InsertCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Pending Supervisor";
                            int status = es.InsertCommand.ExecuteNonQuery();
                            if (rows.ToString() != "" && status > 0)
                            {
                                travelSaved = true;

                            }
                        }


                    }
                    else
                    {

                        SqlDataAdapter cmdET = new SqlDataAdapter();
                        cmdET.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[EstimateTravel] ([UserID],[DepartureDate],[ReturnDate],[TravelEvent],[TravelPurpose],[BudgetedTravel],[EstimatedTravelCost],[Meals],[MealsCost],[MealsNotes],[Registration],[RegistrationCost],[RegistrationNotes],[Lodgings],[LodgingsCost],[LodgingsNotes],[CarRental],[CarRentalCost],[CarRentalNotes],[AirFare],[AirFareCost],[AirFareNotes],[Mileage],[MileageCost],[MileageNotes],[MileagePersonal],[OtherExpenses],[OtherExpensesCost],[OtherExpensesNotes],[Destination],[MealPerDiem])  OUTPUT inserted.TravelEstimateID VALUES (@UserID,@DepartureDate,@ReturnDate,@TravelEvent,@TravelPurpose,@BudgetedTravel,@EstimatedTravelCost,@Meals,@MealsCost,@MealsNotes,@Registration,@RegistrationCost,@RegistrationNotes,@Lodgings,@LodgingsCost,@LodgingsNotes,@CarRental,@CarRentalCost,@CarRentalNotes,@AirFare,@AirFareCost,@AirFareNotes,@Mileage,@MileageCost,@MileageNotes,@MileagePersonal,@OtherExpenses,@OtherExpensesCost,@OtherExpensesNotes,@Destination,@MealPerDiem)", localCon);
                        cmdET.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userID;
                        cmdET.InsertCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = dtpDepartureDate.Value;
                        cmdET.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = dtpReturnDate.Value;
                        cmdET.InsertCommand.Parameters.Add("@TravelEvent", SqlDbType.NVarChar).Value = CommonVariables.et.TravelEvent;
                        cmdET.InsertCommand.Parameters.Add("@TravelPurpose", SqlDbType.NVarChar).Value = CommonVariables.et.TravelPurpose;
                        cmdET.InsertCommand.Parameters.Add("@BudgetedTravel", SqlDbType.Bit).Value = CommonVariables.et.TravelBudgeted;
                        cmdET.InsertCommand.Parameters.Add("@EstimatedTravelCost", SqlDbType.Float).Value = totalTravel;
                        cmdET.InsertCommand.Parameters.Add("@Meals", SqlDbType.Bit).Value = CommonVariables.et.Meals;
                        if (CommonVariables.et.MealsCost > 0)
                        {
                            cmdET.InsertCommand.Parameters.Add("@MealsCost", SqlDbType.Float).Value = CommonVariables.et.MealsCost;
                            cmdET.InsertCommand.Parameters.Add("@MealPerDiem", SqlDbType.Float).Value = CommonVariables.et.MealPerDiem;
                        }
                        else
                        {
                            cmdET.InsertCommand.Parameters.Add("@MealsCost", SqlDbType.Float).Value = DBNull.Value;
                            cmdET.InsertCommand.Parameters.Add("@MealPerDiem", SqlDbType.Float).Value = DBNull.Value; ;
                        }
                        cmdET.InsertCommand.Parameters.Add("@MealsNotes", SqlDbType.NVarChar).Value = txtMealsNotes.Text;
                        cmdET.InsertCommand.Parameters.Add("@Registration", SqlDbType.Bit).Value = CommonVariables.et.Registration;
                        if (CommonVariables.et.ResgistrationCost > 0)
                        {
                            cmdET.InsertCommand.Parameters.Add("@RegistrationCost", SqlDbType.Float).Value = CommonVariables.et.ResgistrationCost;
                        }
                        else
                        {
                            cmdET.InsertCommand.Parameters.Add("@RegistrationCost", SqlDbType.Float).Value = DBNull.Value;
                        }
                        cmdET.InsertCommand.Parameters.Add("@RegistrationNotes", SqlDbType.NVarChar).Value = txtRegistrationNotes.Text;
                        cmdET.InsertCommand.Parameters.Add("@Lodgings", SqlDbType.Bit).Value = CommonVariables.et.Lodgings;
                        if (CommonVariables.et.LodgingsCost > 0)
                        {
                            cmdET.InsertCommand.Parameters.Add("@LodgingsCost", SqlDbType.Float).Value = CommonVariables.et.LodgingsCost;
                        }
                        else
                        {
                            cmdET.InsertCommand.Parameters.Add("@LodgingsCost", SqlDbType.Float).Value = DBNull.Value;
                        }
                        cmdET.InsertCommand.Parameters.Add("@LodgingsNotes", SqlDbType.NVarChar).Value = txtLodgingNotes.Text;
                        cmdET.InsertCommand.Parameters.Add("@CarRental", SqlDbType.Bit).Value = CommonVariables.et.CarRental;
                        if (CommonVariables.et.CarRentalCost > 0)
                        {
                            cmdET.InsertCommand.Parameters.Add("@CarRentalCost", SqlDbType.Float).Value = CommonVariables.et.CarRentalCost;
                        }
                        else
                        {
                            cmdET.InsertCommand.Parameters.Add("@CarRentalCost", SqlDbType.Float).Value = DBNull.Value;
                        }
                        cmdET.InsertCommand.Parameters.Add("@CarRentalNotes", SqlDbType.NVarChar).Value = txtCarRentalNotes.Text;
                        cmdET.InsertCommand.Parameters.Add("@AirFare", SqlDbType.Bit).Value = CommonVariables.et.AirFare;
                        if (CommonVariables.et.AirFareCost > 0)
                        {
                            cmdET.InsertCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = CommonVariables.et.AirFareCost;
                        }
                        else
                        {
                            cmdET.InsertCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = DBNull.Value;
                        }
                        cmdET.InsertCommand.Parameters.Add("@AirFareNotes", SqlDbType.NVarChar).Value = txtAirFareNotes.Text;
                        cmdET.InsertCommand.Parameters.Add("@Mileage", SqlDbType.Bit).Value = CommonVariables.et.Mileage;
                        if (CommonVariables.et.MileageCost > 0)
                        {
                            cmdET.InsertCommand.Parameters.Add("@MileageCost", SqlDbType.Float).Value = CommonVariables.et.MileageCost;
                        }
                        else
                        {
                            cmdET.InsertCommand.Parameters.Add("@MileageCost", SqlDbType.Float).Value = DBNull.Value;
                        }
                        cmdET.InsertCommand.Parameters.Add("@MileageNotes", SqlDbType.NVarChar).Value = txtMileageNotes.Text;
                        cmdET.InsertCommand.Parameters.Add("@MileagePersonal", SqlDbType.Bit).Value = CommonVariables.et.MileagePersonal;
                        cmdET.InsertCommand.Parameters.Add("@OtherExpenses", SqlDbType.Bit).Value = CommonVariables.et.OtherExpenses;
                        if (CommonVariables.et.OtherExpensesCost > 0)
                        {
                            cmdET.InsertCommand.Parameters.Add("@OtherExpensesCost", SqlDbType.Float).Value = CommonVariables.et.OtherExpensesCost;
                        }
                        else
                        {
                            cmdET.InsertCommand.Parameters.Add("@OtherExpensesCost", SqlDbType.Float).Value = DBNull.Value;
                        }
                        cmdET.InsertCommand.Parameters.Add("@OtherExpensesNotes", SqlDbType.NVarChar).Value = txtOtherExpensesNotes.Text;
                        cmdET.InsertCommand.Parameters.Add("@Destination", SqlDbType.NVarChar).Value = CommonVariables.et.Destination;

                        Guid rows = new Guid();

                        rows = (Guid)cmdET.InsertCommand.ExecuteScalar();

                        SqlDataAdapter es = new SqlDataAdapter();
                        es.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[EstimateTravel_Status] ([TravelEstimateID],[Status]) VALUES (@TravelEstimateID,@Status)", localCon);
                        es.InsertCommand.Parameters.Add("@TravelEstimateID", SqlDbType.UniqueIdentifier).Value = rows;
                        es.InsertCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Pending Supervisor";
                        int status = es.InsertCommand.ExecuteNonQuery();

                        if (rows.ToString() != "" && status > 0)
                        {
                            travelSaved = true;
                            CommonVariables.idForPDFViewer = rows.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            localCon.Close();

        }

        private void txtRegistrationCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void txtCarRentalCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void txtAirFareCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void txtOtherExpensesCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void cleanFields()
        {

            //form fields
            cbTravelEvent.SelectedValue = "";
            cbTravelPurpose.SelectedValue = "";
            txtOtherEvent.Text = "";
            txtOtherPurpose.Text = "";
            rbYesBudgetedTravel.Checked = true;
            rbNoBudgetedTravel.Checked = false;
            chxMeals.Checked = false;
            txtMealsCost.Text = "";
            txtMealsNotes.Text = "";
            chxRegistration.Checked = false;
            txtRegistrationCost.Text = "";
            txtRegistrationNotes.Text = "";
            chxLodgings.Checked = false;
            txtLodgingsCost.Text = "";
            txtLodgingNotes.Text = "";
            chxCarRental.Checked = false;
            txtCarRentalCost.Text = "";
            txtCarRentalNotes.Text = "";
            chxAirFare.Checked = false;
            txtAirFareCost.Text = "";
            txtAirFareNotes.Text = "";
            chxMileage.Checked = false;
            txtMileageCost.Text = "";
            txtMileageNotes.Text = "";
            chxOtherExpenses.Checked = false;
            txtOtherExpensesCost.Text = "";
            txtOtherExpensesNotes.Text = "";
            dtpDepartureDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today.AddDays(1);
            txtDestination.Text = "";

            //check variables
            travelSaved = false;
            pdfCreated = false;

            //cleanning the common variables
            CommonVariables.et = new EstimateTravelcl();
            CommonVariables.estimateMileageCost = 0;
            CommonVariables.is_TPT = false;
            CommonVariables.isGroup = false;
            CommonVariables.tpt_UserID = "";
            CommonVariables.tpt_Type = "";
            CommonVariables.usersID = new List<string>();



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            if (CommonVariables.viewEstimateId != "")
            {
                CommonVariables.viewEstimateId = "";
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
                    if (child.Name == "AdminAuthorization")
                    {
                        child.Focus();
                        child.Show();
                    }
                    else if (child.Name == "CFOReview")
                    {
                        child.Focus();
                        child.Show();
                    }
                    else if (child.Name == "SuperAdminAuthorization")
                    {
                        child.Focus();
                        child.Show();
                    }
                }

            }
            CommonVariables.et = new EstimateTravelcl();
            CommonVariables.estimateMileageCost = 0;

            CommonVariables.is_TPT = false;
            CommonVariables.isGroup = false;
            CommonVariables.usersID = new List<string>();
            CommonVariables.tpt_UserID = "";
            CommonVariables.tpt_Type = "";

        }

        private void EstimateTravel_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private double CalculateMealsCost()
        {
            double totalMeals = 0;
            double perDiemRate = 0;
            perDiemRate = Convert.ToDouble(txtMealsPerDiem.Text);
            TimeSpan difference = dtpReturnDate.Value.Subtract(dtpDepartureDate.Value);
            int totalDays = (int)difference.TotalDays;
            totalDays = totalDays + 1;
            totalMeals = totalDays * perDiemRate;
            return totalMeals;

        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            if (chxMeals.Checked && txtMealsPerDiem.Text != "")
            {
                txtMealsCost.Text = "";
                txtMealsCost.Text = CalculateMealsCost().ToString();
            }
            else if (chxMeals.Checked && txtMealsPerDiem.Text == "")
            {
                MessageBox.Show("Enter the Meals Per Diem Rate");
            }
        }

        private void sendApprovalRequest()
        {
            localCon.Open();

            Guid userID = new Guid(CommonVariables.user);
            string email = "";
            string supEmail = "";
            string fullname = "";
            string department = "";

            //user
            SqlCommand user = new SqlCommand("SELECT b.Email as Email, a.Name as Name, a.LastName as LastName, a.Department as Department  FROM [TravelExpenses].[dbo].[User] as a inner join TravelExpenses.dbo.User_Email_Title as b on b.UserID = a.UserID where a.UserID = '" + userID + "'", localCon);
            SqlDataReader userDR = user.ExecuteReader();
            while (userDR.Read())
            {
                email = userDR["Email"].ToString();
                fullname = userDR["Name"].ToString() + " " + userDR["LastName"].ToString();
                department = userDR["Department"].ToString();
            }
            userDR.Close();

            //supervisor
            SqlCommand supervisor = new SqlCommand("SELECT b.Email as Email FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join TravelExpenses.dbo.User_Email_Title as b on b.UserID = a.SupervisorID where a.UserID = '" + userID + "'", localCon);
            SqlDataReader supervisorDR = supervisor.ExecuteReader();
            while (supervisorDR.Read())
            {
                supEmail = supervisorDR["Email"].ToString();
            }
            supervisorDR.Close();

            //server
            SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org", 587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
            SmtpServer.EnableSsl = true;

            //creating the email
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("travelAlert@lcmcd.org");
            mail.To.Add(supEmail);
            mail.Subject = "Review the travel authorization of" + " " + fullname;

            DateTime depDate = CommonVariables.et.DepartureDate;
            DateTime retDate = CommonVariables.et.ReturnDate;
            string travEvent = CommonVariables.et.TravelEvent;


            if (depDate.ToShortDateString() == retDate.ToShortDateString())
            {
                mail.Body = "Please enter to the travel program and review the travel authorization of " + fullname + " on " + depDate.ToShortDateString() + " in order to " + "attend to " + travEvent + " event";

            }
            else
            {
                mail.Body = "Please enter to the travel program and review the travel authorization of " + fullname + " on " + depDate.ToShortDateString() + " to " + retDate.ToShortDateString() + " in order to attend to " + travEvent + " event";
            }

            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            try
            {
                SmtpServer.Send(mail);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            localCon.Close();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;
            sendApprovalRequest();


        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {


        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CommonVariables.et = new EstimateTravelcl();
            CommonVariables.estimateMileageCost = 0;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.gsa.gov/travel/plan-book/per-diem-rates");
        }

        private void txtMealsPerDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnlyNumbers(sender, e);
        }

        private void txtMealsPerDiem_TextChanged(object sender, EventArgs e)
        {
            if (chxMeals.Checked && txtMealsPerDiem.Text != "")
            {
                //txtMealsCost.Enabled = true;
                txtMealsCost.Text = CalculateMealsCost().ToString();
            }
            else if (chxMeals.Checked && txtMealsPerDiem.Text == "")
            {
                //txtMealsCost.Enabled = true;
                txtMealsCost.Text = "0";
            }
        }

        private void btnMealsPerHelp_Click(object sender, EventArgs e)
        {
            frmMealsPerDiemHelp mpdh = new frmMealsPerDiemHelp();
            mpdh.ShowDialog();
        }
    }
}
