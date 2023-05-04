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
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace TravelExpenses
{
    public partial class AllEstimates : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string winUser = Environment.UserName;
        int canE = 0;
        int index = 0;
        bool loadingData = false;
        bool cleaning = false;
        public AllEstimates()
        {
            InitializeComponent();
        }

        private void AllEstimates_Load(object sender, EventArgs e)
        {
         
            localCon.Open();
            Guid userID = new Guid(CommonVariables.user);
            SqlCommand cmd = new SqlCommand("SELECT [TravelEstimateID],[DepartureDate],[ReturnDate],[TravelEvent],[TravelPurpose],[BudgetedTravel],[EstimatedTravelCost] FROM [TravelExpenses].[dbo].[EstimateTravel] where UserID = '"+ userID + "' order by DepartureDate desc", localCon);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string estimatedID = dr["TravelEstimateID"].ToString();
                DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                string travelEvent = dr["TravelEvent"].ToString();
                string travelPurpose = dr["TravelPurpose"].ToString();
                bool travelBudgeted = Convert.ToBoolean(dr["BudgetedTravel"].ToString());
                string estimatedCost = dr["EstimatedTravelCost"].ToString();

                dgvAllEstimates.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travelEvent, travelPurpose, travelBudgeted, estimatedCost, estimatedID);
            }
            dr.Close();

            for (int i = 0; i < dgvAllEstimates.RowCount; i++)
            {
                Guid idEst = new Guid(dgvAllEstimates.Rows[i].Cells[6].Value.ToString());
                SqlCommand approved = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelID = '"+ idEst + "' AND UserType = 'Employee'", localCon);
                SqlDataReader approvedDR = approved.ExecuteReader();
                if (approvedDR.HasRows)
                {
                    dgvAllEstimates.Rows[i].Cells[7].Value = "Yes";
                }
                else
                {
                    dgvAllEstimates.Rows[i].Cells[7].Value = "No";
                }
                approvedDR.Close();
            }
            localCon.Close();

            this.Size = new System.Drawing.Size(776, 254);
            canE = dgvAllEstimates.RowCount;
        }

        private void btnViewEstimate_Click(object sender, EventArgs e)
        {
            if (canE > 0)
            {
                loadingData = true;
                int rowIndex = dgvAllEstimates.CurrentRow.Index;
                string ID = dgvAllEstimates.Rows[rowIndex].Cells[6].Value.ToString();
                Guid estID = new Guid(ID);
                localCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[EstimateTravel] where TravelEstimateID = '" + estID + "'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtpDepartureDateValue.Value = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    dtpReturnDateValue.Value = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    txtTravelEvent.Text = dr["TravelEvent"].ToString();
                    txtTravelPurpose.Text = dr["TravelPurpose"].ToString();
                    txtDestination.Text = dr["Destination"].ToString();
                    if (dr["BudgetedTravel"].ToString() == "True")
                    {
                        rbYes.Checked = true;
                    }
                    else
                    {
                        rbNo.Checked = true;
                    }
                    lblEstimatedTotalValue.Text = dr["EstimatedTravelCost"].ToString();

                    if (dr["Meals"].ToString() == "True")
                    {
                        txtMealsCost.Text = dr["MealsCost"].ToString();
                        txtMealsNotes.Text = dr["MealsNotes"].ToString();
                        txtMealsPerDiemRate.Text = dr["MealPerDiem"].ToString();
                    }
                    if (dr["Registration"].ToString() == "True")
                    {
                        txtRegistrationCost.Text = dr["RegistrationCost"].ToString();
                        txtRegistrationNotes.Text = dr["RegistrationNotes"].ToString();
                    }
                    if (dr["Lodgings"].ToString() == "True")
                    {
                        txtLodgingCost.Text = dr["LodgingsCost"].ToString();
                        txtLodgingNotes.Text = dr["LodgingsNotes"].ToString();
                    }
                    if (dr["CarRental"].ToString() == "True")
                    {
                        txtCarRentalCost.Text = dr["CarRentalCost"].ToString();
                        txtCarRentalNotes.Text = dr["CarRentalNotes"].ToString();
                    }
                    if (dr["AirFare"].ToString() == "True")
                    {
                        txtAirfareCost.Text = dr["AirFareCost"].ToString();
                        txtAirfareNotes.Text = dr["AirFareNotes"].ToString();
                    }
                    if (dr["Mileage"].ToString() == "True")
                    {
                        txtMileageCost.Text = dr["MileageCost"].ToString();
                        txtMileageNotes.Text = dr["MileageNotes"].ToString();
                    }
                    if (dr["OtherExpenses"].ToString() == "True")
                    {
                        txtOtherExpensesCost.Text = dr["OtherExpensesCost"].ToString();
                        txtOtherExpNotes.Text = dr["OtherExpensesNotes"].ToString();
                    }
                }
                dr.Close();
                localCon.Close();
                this.Size = new System.Drawing.Size(776, 813);
                tlOptionButtons.Visible = false;
                dgvAllEstimates.Enabled = false;
                loadingData = false;
            }
            else
            {
                MessageBox.Show("There are no travel authorization in the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cleaning = true;
            dtpDepartureDateValue.Value = DateTime.Today;
            dtpReturnDateValue.Value = DateTime.Today.AddDays(1);
            txtTravelEvent.Text = "";
            txtTravelPurpose.Text = "";
            rbYes.Checked = false;
            rbNo.Checked = false;
            lblEstimatedTotalValue.Text = "";
            txtMealsCost.Text = "";
            txtMealsNotes.Text = "";
            txtRegistrationCost.Text = "";
            txtRegistrationNotes.Text = "";
            txtLodgingCost.Text = "";
            txtLodgingNotes.Text = "";
            txtCarRentalCost.Text = "";
            txtCarRentalNotes.Text = "";
            txtAirfareCost.Text = "";
            txtAirfareNotes.Text = "";
            txtMealsCost.Text = "";
            txtMileageNotes.Text = "";
            txtOtherExpensesCost.Text = "";
            txtOtherExpNotes.Text = "";
            txtDestination.Text = "";

            tlOptionButtons.Visible = true;
            dgvAllEstimates.Enabled = true;
            this.Size = new System.Drawing.Size(776, 254);

            dtpDepartureDateValue.Enabled = false;
            dtpReturnDateValue.Enabled = false;
            txtTravelEvent.ReadOnly = true;
            txtTravelPurpose.ReadOnly = true;
            pTravelBudget.Enabled = false;
            txtMealsCost.ReadOnly = true;
            txtMealsNotes.ReadOnly = true;
            txtRegistrationCost.ReadOnly = true;
            txtRegistrationNotes.ReadOnly = true;
            txtLodgingCost.ReadOnly = true;
            txtLodgingNotes.ReadOnly = true;
            txtCarRentalCost.ReadOnly = true;
            txtCarRentalNotes.ReadOnly = true;
            txtAirfareCost.ReadOnly = true;
            txtAirfareNotes.ReadOnly = true;
            txtMileageCost.ReadOnly = true;
            txtMileageNotes.ReadOnly = true;
            txtOtherExpensesCost.ReadOnly = true;
            txtOtherExpNotes.ReadOnly = true;
            btnUpdate.Visible = false;
            CommonVariables.estimateMileageCost = 0;
            localCon.Close();
            cleaning = false;
        }

        private void btnEstimatePDF_Click(object sender, EventArgs e)
        {
            
            if (canE > 0)
            {
                this.Hide();
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

                int rwoIndex = dgvAllEstimates.CurrentRow.Index;
                string ID = dgvAllEstimates.Rows[rwoIndex].Cells[6].Value.ToString();
                Guid estID = new Guid(ID);
                string depDate = Convert.ToDateTime(dgvAllEstimates.Rows[rwoIndex].Cells[0].Value.ToString()).ToShortDateString();
                string retDate = Convert.ToDateTime(dgvAllEstimates.Rows[rwoIndex].Cells[1].Value.ToString()).ToShortDateString();

                string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form(Estimated).pdf";
                string pdfName = fullName + "_" + depDate + "_" + "to" + "_" + retDate + ".pdf";
                pdfName = pdfName.Replace("/", "-");
                string newFile = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\travel_form(Estimated)_" + pdfName;
                CommonVariables.filePath = newFile;

                PdfReader pdfReader = new PdfReader(pdfTemplate);
                PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
                AcroFields pdfFormFields = pdfStamper.AcroFields;


                try
                {
                    //user details
                    pdfFormFields.SetField("Full Name", fullName);
                    pdfFormFields.SetField("District", district);
                    pdfFormFields.SetField("Department", department);

                    SqlCommand cmd = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[EstimateTravel] where TravelEstimateID = '" + estID + "'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {

                        //travel details
                        pdfFormFields.SetField("Travel Event", dr["TravelEvent"].ToString());
                        pdfFormFields.SetField("Travel Purpose", dr["TravelPurpose"].ToString());
                        pdfFormFields.SetField("Departure Date", depDate);
                        pdfFormFields.SetField("Return Date", retDate);
                        pdfFormFields.SetField("Estimated Travel Total", dr["EstimatedTravelCost"].ToString());
                        pdfFormFields.SetField("Destination", dr["Destination"].ToString());
                        string[] chxvalues = pdfFormFields.GetAppearanceStates("Travel_Budgeted_No");
                        if (dr["BudgetedTravel"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Travel_Budgeted_Yes", "Choice1");
                            pdfFormFields.SetField("Travel_Budgeted_No", "Off");
                        }
                        else
                        {
                            pdfFormFields.SetField("Travel_Budgeted_No", "Choice2");
                            pdfFormFields.SetField("Travel_Budgeted_Yes", "Off");
                        }
                        if (dr["MileagePersonal"].ToString() == "True")
                        {
                            pdfFormFields.SetField("District_Vehicle_No", "Choice2");
                            pdfFormFields.SetField("District_Vehicle_Yes", "Off");

                        }
                        else
                        {
                            pdfFormFields.SetField("District_Vehicle_Yes", "Choice1");
                            pdfFormFields.SetField("District_Vehicle_No", "Off");
                        }

                        //travel items
                        if (dr["Meals"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Estimated CostMeals", dr["MealsCost"].ToString());
                            pdfFormFields.SetField("NotesMeals", dr["MealsNotes"].ToString());
                            pdfFormFields.SetField("Meals Per Diem Rate", dr["MealPerDiem"].ToString());
                        }
                        if (dr["Registration"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Estimated CostRegistration", dr["RegistrationCost"].ToString());
                            pdfFormFields.SetField("NotesRegistration", dr["RegistrationNotes"].ToString());
                        }
                        if (dr["Lodgings"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Estimated CostLodgings", dr["LodgingsCost"].ToString());
                            pdfFormFields.SetField("NotesLodgings", dr["LodgingsNotes"].ToString());
                        }
                        if (dr["CarRental"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Estimated CostCar Rental", dr["CarRentalCost"].ToString());
                            pdfFormFields.SetField("NotesCar Rental", dr["CarRentalNotes"].ToString());
                        }
                        if (dr["AirFare"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Estimated CostAir Fare", dr["AirFareCost"].ToString());
                            pdfFormFields.SetField("NotesAir Fare", dr["AirFareNotes"].ToString());
                        }
                        if (dr["Mileage"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Estimated CostMileage", dr["MileageCost"].ToString());
                            pdfFormFields.SetField("NotesMileage", dr["MileageNotes"].ToString());
                        }
                        if (dr["OtherExpenses"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Estimated CostOther Expenses", dr["OtherExpensesCost"].ToString());
                            pdfFormFields.SetField("NotesOther Expenses", dr["OtherExpensesNotes"].ToString());
                        }
                    }
                    dr.Close();

                    //Signatures
                    SqlCommand cmdPDF = new SqlCommand("SELECT a.TravelID,a.UserID,a.UserType,a.TravelType,a.SignatureDate,b.FontType,b.SignatureText FROM [TravelExpenses].[dbo].[TravelSignatures] as a inner join TravelExpenses.dbo.UserSignature as b on b.UserID = a.UserID where a.TravelID = '" + estID + "'  AND a.TravelType = 'Estimate'", localCon);
                    SqlDataReader drPDF = cmdPDF.ExecuteReader();
                    if (drPDF.HasRows)
                    {
                        while (drPDF.Read())
                        {

                            BaseFont bf = BaseFont.CreateFont();
                            if (drPDF["FontType"].ToString() == "Mistral")
                            {
                                bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\MISTRAL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                            }
                            if (drPDF["FontType"].ToString() == "Rage Italic")
                            {
                                bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\Rage Italic.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                            }
                            if (drPDF["FontType"].ToString() == "MV Boli")
                            {
                                bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\mvboli.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                            }
                            if (drPDF["FontType"].ToString() == "Bradley Hand ITC")
                            {
                                bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\BRADHITC.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                            }
                            if (drPDF["FontType"].ToString() == "Script MT Bold")
                            {
                                bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\SCRIPTBL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                            }
                            DateTime sigDate = Convert.ToDateTime(drPDF["SignatureDate"].ToString());
                            if (drPDF["UserType"].ToString() == "Director")
                            {
                                pdfFormFields.SetFieldProperty("Executive Director Signature", "textfont", bf, null);
                                pdfFormFields.SetField("Executive Director Signature", drPDF["SignatureText"].ToString());
                                pdfFormFields.SetField("Director Date", sigDate.ToShortDateString());
                            }
                            if (drPDF["UserType"].ToString() == "Supervisor")
                            {
                                pdfFormFields.SetFieldProperty("Supervisor Signature", "textfont", bf, null);
                                pdfFormFields.SetField("Supervisor Signature", drPDF["SignatureText"].ToString());
                                pdfFormFields.SetField("Supervisor Date", sigDate.ToShortDateString());
                            }
                            if (drPDF["UserType"].ToString() == "Employee")
                            {
                                pdfFormFields.SetFieldProperty("Employee Signature", "textfont", bf, null);
                                pdfFormFields.SetField("Employee Signature", drPDF["SignatureText"].ToString());
                                pdfFormFields.SetField("Employee Date", sigDate.ToShortDateString());
                            }
                            if (drPDF["UserType"].ToString() == "CFO")
                            {
                                pdfFormFields.SetFieldProperty("CFO Signature", "textfont", bf, null);
                                pdfFormFields.SetField("CFO Signature", drPDF["SignatureText"].ToString());
                                pdfFormFields.SetField("CFO Date", sigDate.ToShortDateString());
                            }

                        }
                    }
                    drPDF.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pdfStamper.Close();
                localCon.Close();
                ViewPDF vp = new ViewPDF();
                vp.Show();
            }
            else
            {
                MessageBox.Show("There are no travel authorization in the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CommonVariables.estimateMileageCost = 0;
            this.Close();
        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            if (canE > 0)
            {
                int rowIndex = dgvAllEstimates.CurrentRow.Index;
                index = rowIndex;
                string estIDValue = dgvAllEstimates.Rows[rowIndex].Cells[6].Value.ToString();
                Guid estID = new Guid(estIDValue);
                Guid userID = new Guid(CommonVariables.user);
                bool isApproved = false;

                localCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT *  FROM [TravelExpenses].[dbo].[TravelSignatures] where UserID = '" + userID + "' AND TravelID = '" + estID + "' AND UserType = 'Employee' AND TravelType = 'Estimate'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    isApproved = true;
                    MessageBox.Show("This travel authorizations was already approved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                dr.Close();

                if (!isApproved)
                {

                    SqlDataAdapter da = new SqlDataAdapter();
                    da.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[TravelSignatures] ([TravelID],[UserID],[UserType],[TravelType],[SignatureDate]) VALUES (@TravelID,@UserID,@UserType,@TravelType,@SignatureDate)", localCon);
                    da.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = estID;
                    da.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userID;
                    da.InsertCommand.Parameters.Add("@UserType", SqlDbType.VarChar).Value = "Employee";
                    da.InsertCommand.Parameters.Add("@TravelType", SqlDbType.VarChar).Value = "Estimate";
                    da.InsertCommand.Parameters.Add("@SignatureDate", SqlDbType.DateTime).Value = DateTime.Today;
                    int row = da.InsertCommand.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("This travel authorization has been successfully approved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pictureBox1.Visible = true;
                        lblNotifications.Visible = true;
                        dgvAllEstimates.Enabled = false;
                        tlOptionButtons.Enabled = false;
                        if (backgroundWorker1.IsBusy != true)
                        {
                            backgroundWorker1.RunWorkerAsync();
                        }
                    }

                   
                }
                localCon.Close();
            }
            else
            {
                MessageBox.Show("There are no travel authorization in the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (canE > 0)
            {
                loadingData = true;
                dtpDepartureDateValue.Enabled = true;
                dtpReturnDateValue.Enabled = true;
                txtTravelEvent.ReadOnly = false;
                txtTravelPurpose.ReadOnly = false;
                pTravelBudget.Enabled = true;
                txtMealsCost.ReadOnly = false;
                txtMealsNotes.ReadOnly = false;
                txtRegistrationCost.ReadOnly = false;
                txtRegistrationNotes.ReadOnly = false;
                txtLodgingCost.ReadOnly = false;
                txtLodgingNotes.ReadOnly = false;
                txtCarRentalCost.ReadOnly = false;
                txtCarRentalNotes.ReadOnly = false;
                txtAirfareCost.ReadOnly = false;
                txtAirfareNotes.ReadOnly = false;
                //txtMileageCost.ReadOnly = false;
                txtMileageNotes.ReadOnly = false;
                txtOtherExpensesCost.ReadOnly = false;
                txtOtherExpNotes.ReadOnly = false;
                btnUpdate.Visible = true;
                txtDestination.ReadOnly = false;
                //button1.Enabled = true;
                txtMealsPerDiemRate.ReadOnly = false;

                int rowIndex = dgvAllEstimates.CurrentRow.Index;
                string ID = dgvAllEstimates.Rows[rowIndex].Cells[6].Value.ToString();
                Guid estID = new Guid(ID);
                localCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[EstimateTravel] where TravelEstimateID = '" + estID + "'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtpDepartureDateValue.Value = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    dtpReturnDateValue.Value = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    txtTravelEvent.Text = dr["TravelEvent"].ToString();
                    txtTravelPurpose.Text = dr["TravelPurpose"].ToString();
                    txtDestination.Text = dr["Destination"].ToString();
                    if (dr["BudgetedTravel"].ToString() == "True")
                    {
                        rbYes.Checked = true;
                    }
                    else
                    {
                        rbNo.Checked = true;
                    }
                    lblEstimatedTotalValue.Text = dr["EstimatedTravelCost"].ToString();

                    if (dr["Meals"].ToString() == "True")
                    {
                        txtMealsCost.Text = dr["MealsCost"].ToString();
                        txtMealsNotes.Text = dr["MealsNotes"].ToString();
                        txtMealsPerDiemRate.Text = dr["MealPerDiem"].ToString();
                    }
                    if (dr["Registration"].ToString() == "True")
                    {
                        txtRegistrationCost.Text = dr["RegistrationCost"].ToString();
                        txtRegistrationNotes.Text = dr["RegistrationNotes"].ToString();
                    }
                    if (dr["Lodgings"].ToString() == "True")
                    {
                        txtLodgingCost.Text = dr["LodgingsCost"].ToString();
                        txtLodgingNotes.Text = dr["LodgingsNotes"].ToString();
                    }
                    if (dr["CarRental"].ToString() == "True")
                    {
                        txtCarRentalCost.Text = dr["CarRentalCost"].ToString();
                        txtCarRentalNotes.Text = dr["CarRentalNotes"].ToString();
                    }
                    if (dr["AirFare"].ToString() == "True")
                    {
                        txtAirfareCost.Text = dr["AirFareCost"].ToString();
                        txtAirfareNotes.Text = dr["AirFareNotes"].ToString();
                    }
                    if (dr["Mileage"].ToString() == "True")
                    {
                        txtMileageCost.Text = dr["MileageCost"].ToString();
                        txtMileageNotes.Text = dr["MileageNotes"].ToString();
                    }
                    if (dr["OtherExpenses"].ToString() == "True")
                    {
                        txtOtherExpensesCost.Text = dr["OtherExpensesCost"].ToString();
                        txtOtherExpNotes.Text = dr["OtherExpensesNotes"].ToString();
                    }
                }
                dr.Close();
                localCon.Close();

                this.Size = new System.Drawing.Size(776, 813);
                tlOptionButtons.Visible = false;
                dgvAllEstimates.Enabled = false;
                loadingData = false;
            }
            else
            {
                MessageBox.Show("There are no travel authorization in the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateMealsData())
            {
                DateTime depDate = dtpDepartureDateValue.Value;
                DateTime retDate = dtpReturnDateValue.Value;
                string travEvent = txtTravelEvent.Text;
                string purpose = txtTravelPurpose.Text;
                string destination = txtDestination.Text;
                bool hasItem = false;
                bool budgeted = true;
                double mealsCost = 0;
                double registrations = 0;
                double lodgings = 0;
                double carRental = 0;
                double airfare = 0;
                double mileage = 0;
                double otherExp = 0;
                double estTotal = 0;
                //double mealsPerDiemRate = 0;



                if (rbNo.Checked)
                {
                    budgeted = false;
                }

                int rowIndex = dgvAllEstimates.CurrentRow.Index;
                string ID = dgvAllEstimates.Rows[rowIndex].Cells[6].Value.ToString();
                double milRate = 0;
                Guid estID = new Guid(ID);
                localCon.Open();

                /*searching for current mileage rate
                SqlCommand milageRate = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[MileageRate]", localCon);
                SqlDataReader milageRateDR = milageRate.ExecuteReader();
                if (milageRateDR.HasRows)
                {
                    while (milageRateDR.Read())
                    {
                        milRate = Convert.ToDouble(milageRateDR["MileageRate"].ToString());
                    }
                }
                milageRateDR.Close();*/


                SqlDataAdapter da = new SqlDataAdapter();
                da.UpdateCommand = new SqlCommand("UPDATE [dbo].[EstimateTravel] SET [DepartureDate] = @DepartureDate,[ReturnDate] = @ReturnDate ,[TravelEvent] = @TravelEvent,[TravelPurpose] = @TravelPurpose,[BudgetedTravel] = @BudgetedTravel,[EstimatedTravelCost] = @EstimatedTravelCost ,[Meals] = @Meals ,[MealsCost] = @MealsCost ,[MealsNotes] = @MealsNotes ,[Registration] = @Registration ,[RegistrationCost] = @RegistrationCost,[RegistrationNotes] = @RegistrationNotes,[Lodgings] = @Lodgings ,[LodgingsCost] = @LodgingsCost ,[LodgingsNotes] = @LodgingsNotes ,[CarRental] = @CarRental ,[CarRentalCost] = @CarRentalCost,[CarRentalNotes] = @CarRentalNotes ,[AirFare] = @AirFare,[AirFareCost] = @AirFareCost ,[AirFareNotes] = @AirFareNotes,[Mileage] = @Mileage,[MileageCost] = @MileageCost,[MileageNotes] = @MileageNotes,[MileagePersonal] = @MileagePersonal,[OtherExpenses] = @OtherExpenses ,[OtherExpensesCost] = @OtherExpensesCost,[OtherExpensesNotes] = @OtherExpensesNotes,[Destination] = @Destination,[MealPerDiem] = @MealPerDiem WHERE TravelEstimateID = '" + estID + "'", localCon);
                da.UpdateCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = depDate;
                da.UpdateCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = retDate;
                da.UpdateCommand.Parameters.Add("@TravelEvent", SqlDbType.VarChar).Value = travEvent;
                da.UpdateCommand.Parameters.Add("@TravelPurpose", SqlDbType.VarChar).Value = purpose;
                da.UpdateCommand.Parameters.Add("@BudgetedTravel", SqlDbType.Bit).Value = budgeted;
                if (txtMealsCost.Text != "")
                {
                    mealsCost = Convert.ToDouble(txtMealsCost.Text);
                    da.UpdateCommand.Parameters.Add("@Meals", SqlDbType.Bit).Value = true;
                    da.UpdateCommand.Parameters.Add("@MealsCost", SqlDbType.Float).Value = mealsCost;
                    da.UpdateCommand.Parameters.Add("@MealsNotes", SqlDbType.VarChar).Value = txtMealsNotes.Text;
                    da.UpdateCommand.Parameters.Add("@MealPerDiem", SqlDbType.Float).Value = Convert.ToDouble(txtMealsPerDiemRate.Text);
                    hasItem = true;
                }
                else
                {
                    da.UpdateCommand.Parameters.Add("@Meals", SqlDbType.Bit).Value = false;
                    da.UpdateCommand.Parameters.Add("@MealsCost", SqlDbType.Float).Value = DBNull.Value;
                    da.UpdateCommand.Parameters.Add("@MealsNotes", SqlDbType.VarChar).Value = "";
                    da.UpdateCommand.Parameters.Add("@MealPerDiem", SqlDbType.Float).Value = DBNull.Value;
                    da.UpdateCommand.Parameters.Add("@MealPerDiem", SqlDbType.Float).Value = DBNull.Value;
                }
                if (txtRegistrationCost.Text != "")
                {
                    registrations = Convert.ToDouble(txtRegistrationCost.Text);
                    da.UpdateCommand.Parameters.Add("@Registration", SqlDbType.Bit).Value = true;
                    da.UpdateCommand.Parameters.Add("@RegistrationCost", SqlDbType.Float).Value = registrations;
                    da.UpdateCommand.Parameters.Add("@RegistrationNotes", SqlDbType.VarChar).Value = txtRegistrationNotes.Text;
                    hasItem = true;
                }
                else
                {
                    da.UpdateCommand.Parameters.Add("@Registration", SqlDbType.Bit).Value = false;
                    da.UpdateCommand.Parameters.Add("@RegistrationCost", SqlDbType.Float).Value = DBNull.Value;
                    da.UpdateCommand.Parameters.Add("@RegistrationNotes", SqlDbType.VarChar).Value = "";
                }
                if (txtLodgingCost.Text != "")
                {
                    lodgings = Convert.ToDouble(txtLodgingCost.Text);
                    da.UpdateCommand.Parameters.Add("@Lodgings", SqlDbType.Bit).Value = true;
                    da.UpdateCommand.Parameters.Add("@LodgingsCost", SqlDbType.Float).Value = lodgings;
                    da.UpdateCommand.Parameters.Add("@LodgingsNotes", SqlDbType.VarChar).Value = txtLodgingNotes.Text;
                    hasItem = true;
                }
                else
                {
                    da.UpdateCommand.Parameters.Add("@Lodgings", SqlDbType.Bit).Value = false;
                    da.UpdateCommand.Parameters.Add("@LodgingsCost", SqlDbType.Float).Value = DBNull.Value;
                    da.UpdateCommand.Parameters.Add("@LodgingsNotes", SqlDbType.VarChar).Value = "";
                }
                if (txtCarRentalCost.Text != "")
                {
                    carRental = Convert.ToDouble(txtCarRentalCost.Text);
                    da.UpdateCommand.Parameters.Add("@CarRental", SqlDbType.Bit).Value = true;
                    da.UpdateCommand.Parameters.Add("@CarRentalCost", SqlDbType.Float).Value = carRental;
                    da.UpdateCommand.Parameters.Add("@CarRentalNotes", SqlDbType.VarChar).Value = txtCarRentalNotes.Text;
                    hasItem = true;
                }
                else
                {
                    da.UpdateCommand.Parameters.Add("@CarRental", SqlDbType.Bit).Value = false;
                    da.UpdateCommand.Parameters.Add("@CarRentalCost", SqlDbType.Float).Value = DBNull.Value;
                    da.UpdateCommand.Parameters.Add("@CarRentalNotes", SqlDbType.VarChar).Value = "";
                }
                if (txtAirfareCost.Text != "")
                {
                    airfare = Convert.ToDouble(txtAirfareCost.Text);
                    da.UpdateCommand.Parameters.Add("@AirFare", SqlDbType.Bit).Value = true;
                    da.UpdateCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = airfare;
                    da.UpdateCommand.Parameters.Add("@AirFareNotes", SqlDbType.VarChar).Value = txtAirfareNotes.Text;
                    hasItem = true;
                }
                else
                {
                    da.UpdateCommand.Parameters.Add("@AirFare", SqlDbType.Bit).Value = false;
                    da.UpdateCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = DBNull.Value;
                    da.UpdateCommand.Parameters.Add("@AirFareNotes", SqlDbType.VarChar).Value = "";
                }
                if (txtMileageCost.Text != "" && txtMileageCost.Text != "0")
                {
                    mileage = Convert.ToDouble(txtMileageCost.Text);
                    da.UpdateCommand.Parameters.Add("@Mileage", SqlDbType.Bit).Value = true;
                    da.UpdateCommand.Parameters.Add("@MileageCost", SqlDbType.Float).Value = mileage;
                    da.UpdateCommand.Parameters.Add("@MileageNotes", SqlDbType.VarChar).Value = txtMileageNotes.Text;
                    da.UpdateCommand.Parameters.Add("@MileagePersonal", SqlDbType.Bit).Value = true;
                    hasItem = true;
                }
                else
                {
                    da.UpdateCommand.Parameters.Add("@Mileage", SqlDbType.Bit).Value = false;
                    da.UpdateCommand.Parameters.Add("@MileageCost", SqlDbType.Float).Value = DBNull.Value;
                    da.UpdateCommand.Parameters.Add("@MileageNotes", SqlDbType.VarChar).Value = "";
                    da.UpdateCommand.Parameters.Add("@MileagePersonal", SqlDbType.Bit).Value = false;
                }
                if (txtOtherExpensesCost.Text != "")
                {
                    otherExp = Convert.ToDouble(txtOtherExpensesCost.Text);
                    da.UpdateCommand.Parameters.Add("@OtherExpenses", SqlDbType.Bit).Value = true;
                    da.UpdateCommand.Parameters.Add("@OtherExpensesCost", SqlDbType.Float).Value = otherExp;
                    da.UpdateCommand.Parameters.Add("@OtherExpensesNotes", SqlDbType.VarChar).Value = txtOtherExpNotes.Text;
                    hasItem = true;
                }
                else
                {
                    da.UpdateCommand.Parameters.Add("@OtherExpenses", SqlDbType.Bit).Value = false;
                    da.UpdateCommand.Parameters.Add("@OtherExpensesCost", SqlDbType.Float).Value = DBNull.Value;
                    da.UpdateCommand.Parameters.Add("@OtherExpensesNotes", SqlDbType.VarChar).Value = "";
                }
                estTotal = mealsCost + registrations + lodgings + carRental + airfare + mileage + otherExp;
                da.UpdateCommand.Parameters.Add("@EstimatedTravelCost", SqlDbType.Float).Value = estTotal;
                da.UpdateCommand.Parameters.Add("@Destination", SqlDbType.NVarChar).Value = destination;

                if (hasItem)
                {
                    int row = da.UpdateCommand.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Travel Authorization updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    localCon.Close();
                    tlOptionButtons.Visible = true;
                    dgvAllEstimates.Enabled = true;
                    refreshData();
                    this.Size = new System.Drawing.Size(776, 254);
                }
                else
                {
                    MessageBox.Show("Your travel must have at least one item", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    localCon.Close();
                }
            }
            
        }

        private void refreshData()
        {
            cleaning = true;
            dgvAllEstimates.Rows.Clear();
            dtpDepartureDateValue.Value = DateTime.Today;
            //dtpReturnDateValue.MinDate = dtpDepartureDateValue.Value;
            dtpReturnDateValue.Value = dtpDepartureDateValue.Value.AddDays(1);
            txtTravelEvent.Text = "";
            txtTravelPurpose.Text = "";
            rbYes.Checked = false;
            rbNo.Checked = false;
            lblEstimatedTotalValue.Text = "";
            txtMealsCost.Text = "";
            txtMealsNotes.Text = "";
            txtRegistrationCost.Text = "";
            txtRegistrationNotes.Text = "";
            txtLodgingCost.Text = "";
            txtLodgingNotes.Text = "";
            txtCarRentalCost.Text = "";
            txtCarRentalNotes.Text = "";
            txtAirfareCost.Text = "";
            txtAirfareNotes.Text = "";
            txtMealsCost.Text = "";
            txtMileageNotes.Text = "";
            txtOtherExpensesCost.Text = "";
            txtOtherExpNotes.Text = "";
            txtDestination.Text = "";
            //button1.Enabled = false;
            txtMealsPerDiemRate.Text = "";


            localCon.Open();
            Guid userID = new Guid(CommonVariables.user);
            SqlCommand cmd = new SqlCommand("SELECT [TravelEstimateID],[DepartureDate],[ReturnDate],[TravelEvent],[TravelPurpose],[BudgetedTravel],[EstimatedTravelCost] FROM [TravelExpenses].[dbo].[EstimateTravel] where UserID = '" + userID + "' order by DepartureDate desc", localCon);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string estimatedID = dr["TravelEstimateID"].ToString();
                DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                string travelEvent = dr["TravelEvent"].ToString();
                string travelPurpose = dr["TravelPurpose"].ToString();
                bool travelBudgeted = Convert.ToBoolean(dr["BudgetedTravel"].ToString());
                string estimatedCost = dr["EstimatedTravelCost"].ToString();

                dgvAllEstimates.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travelEvent, travelPurpose, travelBudgeted, estimatedCost, estimatedID);
            }
            dr.Close();

            for (int i = 0; i < dgvAllEstimates.RowCount; i++)
            {
                Guid idEst = new Guid(dgvAllEstimates.Rows[i].Cells[6].Value.ToString());
                SqlCommand approved = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelID = '" + idEst + "' AND UserType = 'Employee'", localCon);
                SqlDataReader approvedDR = approved.ExecuteReader();
                if (approvedDR.HasRows)
                {
                    dgvAllEstimates.Rows[i].Cells[7].Value = "Yes";
                }
                else
                {
                    dgvAllEstimates.Rows[i].Cells[7].Value = "No";
                }
                approvedDR.Close();
            }

            localCon.Close();

            dtpDepartureDateValue.Enabled = false;
            dtpReturnDateValue.Enabled = false;
            txtTravelEvent.ReadOnly = true;
            txtTravelPurpose.ReadOnly = true;
            pTravelBudget.Enabled = false;
            txtMealsCost.ReadOnly = true;
            txtMealsNotes.ReadOnly = true;
            txtRegistrationCost.ReadOnly = true;
            txtRegistrationNotes.ReadOnly = true;
            txtLodgingCost.ReadOnly = true;
            txtLodgingNotes.ReadOnly = true;
            txtCarRentalCost.ReadOnly = true;
            txtCarRentalNotes.ReadOnly = true;
            txtAirfareCost.ReadOnly = true;
            txtAirfareNotes.ReadOnly = true;
            txtMileageCost.ReadOnly = true;
            txtMileageNotes.ReadOnly = true;
            txtOtherExpensesCost.ReadOnly = true;
            txtOtherExpNotes.ReadOnly = true;
            btnUpdate.Visible = false;
            txtDestination.ReadOnly = true;
            CommonVariables.estimateMileageCost = 0;
            cleaning = false;
        }

        private void txtMealsCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtRegistrationCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLodgingCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCarRentalCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAirfareCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMileageCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtOtherExpensesCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void sendNotifications()
        {
            DateTime depDate = Convert.ToDateTime(dgvAllEstimates.Rows[index].Cells[0].Value.ToString());
            DateTime retDate = Convert.ToDateTime(dgvAllEstimates.Rows[index].Cells[1].Value.ToString());
            string travEvent = dgvAllEstimates.Rows[index].Cells[2].Value.ToString();
            Guid userID = new Guid(CommonVariables.user);
            string username = "";
            string emailSup = "";

            localCon.Open();
            SqlCommand userInfo = new SqlCommand("SELECT Name , LastName FROM [TravelExpenses].[dbo].[User] where UserID = '" + userID + "'", localCon);
            SqlDataReader userInfoDR = userInfo.ExecuteReader();
            while (userInfoDR.Read())
            {
                username = userInfoDR["Name"].ToString() + " " + userInfoDR["LastName"].ToString();
            }
            userInfoDR.Close();

            SqlCommand supEmail = new SqlCommand("select b.Email as Email from [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User_Email_Title] as b on b.UserID = a.SupervisorID where a.UserID = '" + userID + "'", localCon);
            SqlDataReader supEmailDR = supEmail.ExecuteReader();
            while (supEmailDR.Read())
            {
                emailSup = supEmailDR["Email"].ToString();
            }
            supEmailDR.Close();
            localCon.Close();

            SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org", 587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
            SmtpServer.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("travelAlert@lcmcd.org");
            mail.To.Add(emailSup);
            mail.Subject = "Review the travel authorization form of " + username;


            if (depDate.ToShortDateString() == retDate.ToShortDateString())
            {
                mail.Body = "Please review the travel authorization form of " + username + " on " + depDate.ToShortDateString() + " in order to " + "attend to " + travEvent + " event.";

            }
            else
            {
                mail.Body = "Please review the travel authorization form of " + username + " from "+ depDate.ToShortDateString() + " to " + retDate.ToShortDateString() + " in order to attend to " + travEvent + " event.";
            }

            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            try
            {
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            sendNotifications();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            index = 0;
            pictureBox1.Visible = false;
            lblNotifications.Visible = false;
            dgvAllEstimates.Enabled = true;
            tlOptionButtons.Enabled = true;
            refreshData();
        }

        private double CalculateMealsCost()
        {
            double totalMeals = 0;
            if (txtMealsPerDiemRate.Text != "")
            {
                
                TimeSpan difference = dtpReturnDateValue.Value.Subtract(dtpDepartureDateValue.Value);
                int totalDays = (int)difference.TotalDays;
                totalDays = totalDays + 1;
                totalMeals = totalDays * Convert.ToDouble(txtMealsPerDiemRate.Text);
                
            }
            return totalMeals;
        }

        private void dtpDepartureDateValue_ValueChanged(object sender, EventArgs e)
        {
            if (!loadingData && !cleaning)
            {
                if (txtMealsPerDiemRate.Text != "")
                {
                    //dtpReturnDateValue.MinDate = dtpDepartureDateValue.Value;
                    txtMealsCost.Text = "";
                    txtMealsCost.Text = CalculateMealsCost().ToString();
                }
                else 
                {
                    MessageBox.Show("Enter a value for the Meals Per Diem Rate.");
                }
            }
        }

        private void dtpReturnDateValue_ValueChanged(object sender, EventArgs e)
        {
            if (!loadingData && !cleaning)
            {
                if (txtMealsPerDiemRate.Text != "")
                {
                    txtMealsCost.Text = "";
                    txtMealsCost.Text = CalculateMealsCost().ToString();
                }
                else 
                {
                    MessageBox.Show("Enter a value for the Meals Per Diem Rate.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MileageCalculator mc = new MileageCalculator();
            mc.ShowDialog();
            txtMileageCost.Text = CommonVariables.estimateMileageCost.ToString();
        }

        private void txtMealsPerDiemRate_TextChanged(object sender, EventArgs e)
        {
            if (txtMealsPerDiemRate.Text != "")
            {
                txtMealsCost.Text = "";
                txtMealsCost.Text = CalculateMealsCost().ToString();
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

        private bool validateMealsData() 
        {
            if (txtMealsCost.Text != "" && txtMealsPerDiemRate.Text == "")
            {
                MessageBox.Show("Enter the Meals Per Diem Rate");
                return false;
            }
            return true;
        }
    }
}
