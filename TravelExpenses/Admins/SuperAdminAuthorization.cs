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
//using iTextSharp;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using iTextSharp.text.xml;
using System.IO;
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
    public partial class SuperAdminAuthorization : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string winUser = Environment.UserName;
        string department = "";
        string userType = "";
        string title = "";
        string username = "";
        public SuperAdminAuthorization()
        {
            InitializeComponent();
        }

        private void SuperAdminAuthorization_Load(object sender, EventArgs e)
        {

            refreshTravels();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvAthorizations.Rows.Clear();
            localCon.Open();
            if (cbEmployee.SelectedValue.ToString() == "-1")
            {

                if (title == "Executive Processor")
                {
                    SqlCommand cmd = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status != 'Final' AND (b.Department = 'Executive 104' or b.Department = 'Commissioners' or b.Department = 'Educ & Communication 103') order by a.ReturnDate desc", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string estimateID = dr["TravelEstimateID"].ToString();
                        DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                        DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                        string travEvent = dr["TravelEvent"].ToString();
                        string travPurpose = dr["TravelPurpose"].ToString();

                        string estTotal = dr["EstimatedTravelCost"].ToString();
                        bool budgeted = Convert.ToBoolean(dr["BudgetedTravel"].ToString());
                        string userID = dr["UserID"].ToString();
                        string user = dr["Name"].ToString();
                        string district = dr["District"].ToString();
                        string department = dr["Department"].ToString();
                        bool personalMileage = Convert.ToBoolean(dr["MileagePersonal"].ToString());
                        dgvAthorizations.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, budgeted, user, estTotal, estimateID, userID, district, department, personalMileage);
                    }
                    dr.Close();
                }
                else if (title == "Deputy Director Mosquito" || title == "Assistant Director")
                {
                    SqlCommand cmd = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status != 'Final' AND (b.Department = 'Mosquito Group 106' or b.Department = 'Field Validation 105' or b.Department = 'Scientific Intelligence 108') order by a.ReturnDate desc", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string estimateID = dr["TravelEstimateID"].ToString();
                        DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                        DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                        string travEvent = dr["TravelEvent"].ToString();
                        string travPurpose = dr["TravelPurpose"].ToString();

                        string estTotal = dr["EstimatedTravelCost"].ToString();
                        bool budgeted = Convert.ToBoolean(dr["BudgetedTravel"].ToString());
                        string userID = dr["UserID"].ToString();
                        string user = dr["Name"].ToString();
                        string district = dr["District"].ToString();
                        string department = dr["Department"].ToString();
                        bool personalMileage = Convert.ToBoolean(dr["MileagePersonal"].ToString());
                        dgvAthorizations.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, budgeted, user, estTotal, estimateID, userID, district, department, personalMileage);
                    }
                    dr.Close();
                }
                else if (title == "Deputy Director Hyacinth")
                {
                    SqlCommand cmd = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status != 'Final' AND b.Department = 'Hyacinth' order by a.ReturnDate desc", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string estimateID = dr["TravelEstimateID"].ToString();
                        DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                        DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                        string travEvent = dr["TravelEvent"].ToString();
                        string travPurpose = dr["TravelPurpose"].ToString();

                        string estTotal = dr["EstimatedTravelCost"].ToString();
                        bool budgeted = Convert.ToBoolean(dr["BudgetedTravel"].ToString());
                        string userID = dr["UserID"].ToString();
                        string user = dr["Name"].ToString();
                        string district = dr["District"].ToString();
                        string department = dr["Department"].ToString();
                        bool personalMileage = Convert.ToBoolean(dr["MileagePersonal"].ToString());
                        dgvAthorizations.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, budgeted, user, estTotal, estimateID, userID, district, department, personalMileage);
                    }
                    dr.Close();
                }
                else
                {

                    SqlCommand cmd = new SqlCommand("Select b.TravelEstimateID, a.UserID, b.DepartureDate, b.ReturnDate, b.TravelEvent, b.TravelPurpose, b.BudgetedTravel, b.EstimatedTravelCost, b.MileagePersonal, (c.Name + '' + c.LastName) as Name, c.District, c.Department from TravelExpenses.dbo.Supervisor_Employee as a inner join TravelExpenses.dbo.EstimateTravel as b on a.UserID = b.UserID inner join TravelExpenses.dbo.[User] as c on a.UserID = c.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as d on b.TravelEstimateID = d.TravelEstimateID where d.Status != 'Final' order by b.ReturnDate desc", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string estimateID = dr["TravelEstimateID"].ToString();
                        DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                        DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                        string travEvent = dr["TravelEvent"].ToString();
                        string travPurpose = dr["TravelPurpose"].ToString();

                        string estTotal = dr["EstimatedTravelCost"].ToString();
                        bool budgeted = Convert.ToBoolean(dr["BudgetedTravel"].ToString());
                        string userID = dr["UserID"].ToString();
                        string user = dr["Name"].ToString();
                        string district = dr["District"].ToString();
                        string department = dr["Department"].ToString();
                        bool personalMileage = Convert.ToBoolean(dr["MileagePersonal"].ToString());
                        dgvAthorizations.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, budgeted, user, estTotal, estimateID, userID, district, department, personalMileage);
                    }
                    dr.Close();
                }
            }
            else
            {
                string idvalue = cbEmployee.SelectedValue.ToString();
                SqlCommand cmd = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID Where  a.UserID = '" + idvalue + "' AND c.Status != 'Final' order by a.ReturnDate desc", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string estimateID = dr["TravelEstimateID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();

                    string estTotal = dr["EstimatedTravelCost"].ToString();
                    bool budgeted = Convert.ToBoolean(dr["BudgetedTravel"].ToString());
                    string userID = dr["UserID"].ToString();
                    string user = dr["Name"].ToString();
                    string district = dr["District"].ToString();
                    string department = dr["Department"].ToString();
                    bool personalMileage = Convert.ToBoolean(dr["MileagePersonal"].ToString());
                    dgvAthorizations.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, budgeted, user, estTotal, estimateID, userID, district, department, personalMileage);
                }
                dr.Close();
            }
            localCon.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvAthorizations.RowCount > 0)
            {
                this.Hide();
                int rowIndex = dgvAthorizations.CurrentRow.Index;
                string estID = dgvAthorizations.Rows[rowIndex].Cells[7].Value.ToString();
                CommonVariables.viewEstimateId = estID;
                EstimateTravel et = new EstimateTravel();
                et.Text = "View Authorization Details";
                et.ShowDialog();
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgvAthorizations.RowCount > 0)
            {
                localCon.Open();

                string district = "";
                string department = "";
                string fullName = "";
                CommonVariables.filePath = "";
                string depdate = "";
                string retdate = "";
                string travevent = "";
                string travpurpose = "";
                string travTotal = "";
                string budgeted = "";
                string estID = "";
                string perMileage = "";
                string userID = "";

                int rowIndex = dgvAthorizations.CurrentRow.Index;
                fullName = dgvAthorizations.Rows[rowIndex].Cells[5].Value.ToString();
                department = dgvAthorizations.Rows[rowIndex].Cells[10].Value.ToString();
                district = dgvAthorizations.Rows[rowIndex].Cells[9].Value.ToString();
                depdate = dgvAthorizations.Rows[rowIndex].Cells[0].Value.ToString();
                retdate = dgvAthorizations.Rows[rowIndex].Cells[1].Value.ToString();
                travevent = dgvAthorizations.Rows[rowIndex].Cells[2].Value.ToString();
                travpurpose = dgvAthorizations.Rows[rowIndex].Cells[3].Value.ToString();
                travTotal = dgvAthorizations.Rows[rowIndex].Cells[6].Value.ToString();
                budgeted = dgvAthorizations.Rows[rowIndex].Cells[4].Value.ToString();
                estID = dgvAthorizations.Rows[rowIndex].Cells[7].Value.ToString();
                perMileage = dgvAthorizations.Rows[rowIndex].Cells[11].Value.ToString();
                userID = dgvAthorizations.Rows[rowIndex].Cells[8].Value.ToString();



                string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form(Estimated).pdf";
                string pdfName = fullName + "_" + depdate + "_" + "to" + "_" + retdate + ".pdf";
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

                    //pdfFormFields.SetField("Travel Event", travevent); //commented for net6
                    fields.TryGetValue("Travel Event", out toSet);
                    toSet.SetValue(travevent);

                    //pdfFormFields.SetField("Travel Purpose", travpurpose); //commented for net6
                    fields.TryGetValue("Travel Purpose", out toSet);
                    toSet.SetValue(travpurpose);

                    //pdfFormFields.SetField("Departure Date", depdate); //commented for net6
                    fields.TryGetValue("Departure Date", out toSet);
                    toSet.SetValue(depdate);

                    //pdfFormFields.SetField("Return Date", retdate); //commented for net6
                    fields.TryGetValue("Return Date", out toSet);
                    toSet.SetValue(retdate);

                    //pdfFormFields.SetField("Estimated Travel Total", travTotal); //commented for net6
                    fields.TryGetValue("Estimated Travel Total", out toSet);
                    toSet.SetValue(travTotal);

                    //string[] chxvalues = pdfFormFields.GetAppearanceStates("Travel_Budgeted_No"); //commented for net6

                    if (budgeted == "True")
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
                        fields.TryGetValue("Travel_Budgeted_No", out toSet);
                        toSet.SetValue("Off");
                    }
                    if (perMileage == "True")
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
                    SqlCommand data = new SqlCommand("SELECT [Meals],[MealsCost],[MealsNotes],[Registration],[RegistrationCost],[RegistrationNotes],[Lodgings],[LodgingsCost],[LodgingsNotes],[CarRental],[CarRentalCost],[CarRentalNotes],[AirFare],[AirFareCost],[AirFareNotes],[Mileage],[MileageCost],[MileageNotes],[MileagePersonal],[OtherExpenses],[OtherExpensesCost],[OtherExpensesNotes],[Destination],[MealPerDiem] FROM [TravelExpenses].[dbo].[EstimateTravel] where TravelEstimateID = '" + estID + "'", localCon);
                    SqlDataReader dr = data.ExecuteReader();
                    while (dr.Read())
                    {
                        //pdfFormFields.SetField("Destination", dr["Destination"].ToString()); //commented for net6
                        fields.TryGetValue("Destination", out toSet);
                        toSet.SetValue(dr["Destination"].ToString());

                        bool meals = Convert.ToBoolean(dr["Meals"].ToString());
                        if (meals)
                        {
                            //pdfFormFields.SetField("Estimated CostMeals", dr["MealsCost"].ToString()); //commented for net6
                            fields.TryGetValue("Estimated CostMeals", out toSet);
                            toSet.SetValue(dr["MealsCost"].ToString());

                            //pdfFormFields.SetField("NotesMeals", dr["MealsNotes"].ToString()); //commented for net6
                            fields.TryGetValue("NotesMeals", out toSet);
                            toSet.SetValue(dr["MealsNotes"].ToString());

                            //pdfFormFields.SetField("Meals Per Diem Rate", dr["MealPerDiem"].ToString()); //commented for net6
                            fields.TryGetValue("Meals Per Diem Rate", out toSet);
                            toSet.SetValue(dr["MealPerDiem"].ToString());
                        }
                        bool resgistartion = Convert.ToBoolean(dr["Registration"].ToString());
                        if (resgistartion)
                        {
                            //pdfFormFields.SetField("Estimated CostRegistration", dr["RegistrationCost"].ToString()); //commented for net6
                            fields.TryGetValue("Estimated CostRegistration", out toSet);
                            toSet.SetValue(dr["RegistrationCost"].ToString());

                            //pdfFormFields.SetField("NotesRegistration", dr["RegistrationNotes"].ToString()); //commented for net6
                            fields.TryGetValue("NotesRegistration", out toSet);
                            toSet.SetValue(dr["RegistrationNotes"].ToString());
                        }
                        bool losdgings = Convert.ToBoolean(dr["Lodgings"].ToString());
                        if (losdgings)
                        {
                            //pdfFormFields.SetField("Estimated CostLodgings", dr["LodgingsCost"].ToString()); //commented for net6
                            fields.TryGetValue("Estimated CostLodgings", out toSet);
                            toSet.SetValue(dr["LodgingsCost"].ToString());

                            //pdfFormFields.SetField("NotesLodgings", dr["LodgingsNotes"].ToString()); //commented for net6
                            fields.TryGetValue("NotesLodgings", out toSet);
                            toSet.SetValue(dr["LodgingsNotes"].ToString());
                        }
                        bool carRental = Convert.ToBoolean(dr["CarRental"].ToString());
                        if (carRental)
                        {
                            //pdfFormFields.SetField("Estimated CostCar Rental", dr["CarRentalCost"].ToString()); //commented for net6
                            fields.TryGetValue("Estimated CostCar Rental", out toSet);
                            toSet.SetValue(dr["CarRentalCost"].ToString());

                            //pdfFormFields.SetField("NotesCar Rental", dr["CarRentalNotes"].ToString()); //commented for net6
                            fields.TryGetValue("NotesCar Rental", out toSet);
                            toSet.SetValue(dr["CarRentalNotes"].ToString());
                        }
                        bool airfare = Convert.ToBoolean(dr["AirFare"].ToString());
                        if (airfare)
                        {
                            //pdfFormFields.SetField("Estimated CostAir Fare", dr["AirFareCost"].ToString()); //commented for net6
                            fields.TryGetValue("Estimated CostAir Fare", out toSet);
                            toSet.SetValue(dr["AirFareCost"].ToString());

                            //pdfFormFields.SetField("NotesAir Fare", dr["AirFareNotes"].ToString()); //commented for net6
                            fields.TryGetValue("NotesAir Fare", out toSet);
                            toSet.SetValue(dr["AirFareNotes"].ToString());
                        }
                        bool mileage = Convert.ToBoolean(dr["Mileage"].ToString());
                        if (mileage)
                        {
                            //pdfFormFields.SetField("Estimated CostMileage", dr["MileageCost"].ToString()); //commented for net6
                            fields.TryGetValue("Estimated CostMileage", out toSet);
                            toSet.SetValue(dr["MileageCost"].ToString());

                            //pdfFormFields.SetField("NotesMileage", dr["MileageNotes"].ToString()); //commented for net6
                            fields.TryGetValue("NotesMileage", out toSet);
                            toSet.SetValue(dr["MileageNotes"].ToString());
                        }
                        bool otherExps = Convert.ToBoolean(dr["OtherExpenses"].ToString());
                        if (otherExps)
                        {
                            //pdfFormFields.SetField("Estimated CostOther Expenses", dr["OtherExpensesCost"].ToString()); //commented for net6
                            fields.TryGetValue("Estimated CostOther Expenses", out toSet);
                            toSet.SetValue(dr["OtherExpensesCost"].ToString());

                            //pdfFormFields.SetField("NotesOther Expenses", dr["OtherExpensesNotes"].ToString()); //commented for net6
                            fields.TryGetValue("NotesOther Expenses", out toSet);
                            toSet.SetValue(dr["OtherExpensesNotes"].ToString());
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

                            //BaseFont bf = BaseFont.CreateFont(); //commented for net6 
                            PdfFont font = PdfFontFactory.CreateFont();

                            if (drPDF["FontType"].ToString() == "Mistral")
                            {
                                //bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\MISTRAL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); //commented for net6 
                                font = PdfFontFactory.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\MISTRAL.TTF");
                            }
                            if (drPDF["FontType"].ToString() == "Rage Italic")
                            {
                                //bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\Rage Italic.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); //commented for net6 
                                font = PdfFontFactory.CreateFont(@"\\LCMHCD\Employees\Travel Temp\Rage Italic.ttf");
                            }
                            if (drPDF["FontType"].ToString() == "MV Boli")
                            {
                                //bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\mvboli.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); //commented for net6 
                                font = PdfFontFactory.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\mvboli.ttf");
                            }
                            if (drPDF["FontType"].ToString() == "Bradley Hand ITC")
                            {
                                //bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\BRADHITC.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); //commented for net6
                                font = PdfFontFactory.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\BRADHITC.TTF");
                            }
                            if (drPDF["FontType"].ToString() == "Script MT Bold")
                            {
                                //bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\SCRIPTBL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); //commented for net6
                                font = PdfFontFactory.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\SCRIPTBL.TTF");
                            }
                            DateTime sigDate = Convert.ToDateTime(drPDF["SignatureDate"].ToString());
                            if (drPDF["UserType"].ToString() == "Director")
                            {
                                //pdfFormFields.SetFieldProperty("Executive Director Signature", "textfont", bf, null); //commented for net6
                                //pdfFormFields.SetField("Executive Director Signature", drPDF["SignatureText"].ToString()); //commented for net6
                                fields.TryGetValue("Executive Director Signature", out toSet);
                                toSet.SetFont(font);
                                toSet.SetValue(drPDF["SignatureText"].ToString());

                                //pdfFormFields.SetField("Director Date", sigDate.ToShortDateString()); //commented for net6
                                fields.TryGetValue("Director Date", out toSet);
                                toSet.SetValue(sigDate.ToShortDateString());
                            }
                            if (drPDF["UserType"].ToString() == "Supervisor")
                            {
                                //pdfFormFields.SetFieldProperty("Supervisor Signature", "textfont", bf, null); //commented for net6
                                //pdfFormFields.SetField("Supervisor Signature", drPDF["SignatureText"].ToString()); //commented for net6
                                fields.TryGetValue("Supervisor Signature", out toSet);
                                toSet.SetFont(font);
                                toSet.SetValue(drPDF["SignatureText"].ToString());

                                //pdfFormFields.SetField("Supervisor Date", sigDate.ToShortDateString()); //commented for net6
                                fields.TryGetValue("Supervisor Date", out toSet);
                                toSet.SetValue(sigDate.ToShortDateString());
                            }
                            if (drPDF["UserType"].ToString() == "Employee")
                            {
                                //pdfFormFields.SetFieldProperty("Employee Signature", "textfont", bf, null); //commented for net6
                                //pdfFormFields.SetField("Employee Signature", drPDF["SignatureText"].ToString()); //commented for net6
                                fields.TryGetValue("Employee Signature", out toSet);
                                toSet.SetFont(font);
                                toSet.SetValue(drPDF["SignatureText"].ToString());

                                //pdfFormFields.SetField("Employee Date", sigDate.ToShortDateString()); //commented for net6
                                fields.TryGetValue("Employee Date", out toSet);
                                toSet.SetValue(sigDate.ToShortDateString());
                            }
                            if (drPDF["UserType"].ToString() == "CFO")
                            {
                                //pdfFormFields.SetFieldProperty("CFO Signature", "textfont", bf, null); //commented for net6
                                //pdfFormFields.SetField("CFO Signature", drPDF["SignatureText"].ToString()); //commented for net6
                                fields.TryGetValue("CFO Signature", out toSet);
                                toSet.SetFont(font);
                                toSet.SetValue(drPDF["SignatureText"].ToString());

                                //pdfFormFields.SetField("CFO Date", sigDate.ToShortDateString()); //commented for net6
                                fields.TryGetValue("CFO Date", out toSet);
                                toSet.SetValue(sigDate.ToShortDateString());
                            }

                        }
                    }
                    drPDF.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //pdfStamper.Close(); //commented for net6
                form.FlattenFields();
                pdfDoc.Close();
                localCon.Close();
                ViewPDF vp = new ViewPDF();
                vp.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            DialogResult fin = MessageBox.Show("Do you really want to archive this Authorization? Archiving an authorization means no other action could be performed on it.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (fin == DialogResult.Yes)
            {
                int rowIndex = dgvAthorizations.CurrentRow.Index;
                string estID = dgvAthorizations.Rows[rowIndex].Cells[7].Value.ToString();
                localCon.Open();
                SqlDataAdapter upStatus = new SqlDataAdapter();
                upStatus.UpdateCommand = new SqlCommand("UPDATE [dbo].[EstimateTravel_Status] SET [Status] = @Status WHERE TravelEstimateID = '" + estID + "'", localCon);
                upStatus.UpdateCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Final";
                int ru = upStatus.UpdateCommand.ExecuteNonQuery();
                localCon.Close();
                if (ru > 0)
                {
                    MessageBox.Show("The travel authorization has been archived successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refreshTravels();
                }
            }


        }

        private void refreshTravels()
        {
            dgvAthorizations.Rows.Clear();

            localCon.Open();

            Guid logUser = new Guid(CommonVariables.user);
            SqlCommand userInfo = new SqlCommand("SELECT [Title],b.Username FROM [TravelExpenses].[dbo].[User_Email_Title] as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID where a.UserID = '" + logUser + "'", localCon);
            SqlDataReader userInfoDR = userInfo.ExecuteReader();
            while (userInfoDR.Read())
            {
                title = userInfoDR["Title"].ToString();
                username = userInfoDR["Username"].ToString();
            }
            userInfoDR.Close();

            if (title == "Executive Processor")
            {
                SqlCommand cmd = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status != 'Final' AND (b.Department = 'Executive 104' or b.Department = 'Commissioners' or b.Department = 'Educ & Communication 103') order by a.ReturnDate desc", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string estimateID = dr["TravelEstimateID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();

                    string estTotal = dr["EstimatedTravelCost"].ToString();
                    bool budgeted = Convert.ToBoolean(dr["BudgetedTravel"].ToString());
                    string userID = dr["UserID"].ToString();
                    string user = dr["Name"].ToString();
                    string district = dr["District"].ToString();
                    string department = dr["Department"].ToString();
                    bool personalMileage = Convert.ToBoolean(dr["MileagePersonal"].ToString());
                    dgvAthorizations.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, budgeted, user, estTotal, estimateID, userID, district, department, personalMileage);
                }
                dr.Close();

                SqlCommand em = new SqlCommand("SELECT a.UserID,a.Name,a.LastName FROM [TravelExpenses].[dbo].[User] as a inner join [TravelExpenses].[dbo].[User_Email_Title] as b on a.UserID = b.UserID where  (Department = 'Executive 104' or Department = 'Commissioners' or Department = 'Educ & Communication 103') order by LastName", localCon);
                SqlDataReader emDR = em.ExecuteReader();
                if (emDR.HasRows)
                {
                    cbEmployee.DisplayMember = "Text";
                    cbEmployee.ValueMember = "Value";
                    List<Object> items = new List<object>();
                    while (emDR.Read())
                    {
                        string name = emDR["LastName"].ToString() + "," + emDR["Name"].ToString();
                        string id = emDR["UserID"].ToString();
                        items.Add(new { Text = name, Value = id });


                    }
                    items.Add(new { Text = "All", Value = "-1" });
                    cbEmployee.DataSource = items;
                }
                cbEmployee.SelectedValue = "-1";

                emDR.Close();
            }
            else if (title == "Deputy Director Mosquito" || title == "Assistant Director")
            {
                SqlCommand cmd = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status != 'Final' AND (b.Department = 'Mosquito Group 106' or b.Department = 'Field Validation 105' or b.Department = 'Scientific Intelligence 108') order by a.ReturnDate desc", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string estimateID = dr["TravelEstimateID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();

                    string estTotal = dr["EstimatedTravelCost"].ToString();
                    bool budgeted = Convert.ToBoolean(dr["BudgetedTravel"].ToString());
                    string userID = dr["UserID"].ToString();
                    string user = dr["Name"].ToString();
                    string district = dr["District"].ToString();
                    string department = dr["Department"].ToString();
                    bool personalMileage = Convert.ToBoolean(dr["MileagePersonal"].ToString());
                    dgvAthorizations.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, budgeted, user, estTotal, estimateID, userID, district, department, personalMileage);
                }
                dr.Close();

                SqlCommand em = new SqlCommand("SELECT a.UserID,a.Name,a.LastName FROM [TravelExpenses].[dbo].[User] as a inner join [TravelExpenses].[dbo].[User_Email_Title] as b on a.UserID = b.UserID where  AND (Department = 'Mosquito Group 106' or Department = 'Field Validation 105' or Department = 'Scientific Intelligence 108') order by LastName", localCon);
                SqlDataReader emDR = em.ExecuteReader();
                if (emDR.HasRows)
                {
                    cbEmployee.DisplayMember = "Text";
                    cbEmployee.ValueMember = "Value";
                    List<Object> items = new List<object>();
                    while (emDR.Read())
                    {
                        string name = emDR["LastName"].ToString() + "," + emDR["Name"].ToString();
                        string id = emDR["UserID"].ToString();
                        items.Add(new { Text = name, Value = id });


                    }
                    items.Add(new { Text = "All", Value = "-1" });
                    cbEmployee.DataSource = items;
                }
                cbEmployee.SelectedValue = "-1";

                emDR.Close();
            }
            else if (title == "Deputy Director Hyacinth")
            {
                SqlCommand cmd = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status != 'Final' AND b.Department = 'Hyacinth' order by a.ReturnDate desc", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string estimateID = dr["TravelEstimateID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();

                    string estTotal = dr["EstimatedTravelCost"].ToString();
                    bool budgeted = Convert.ToBoolean(dr["BudgetedTravel"].ToString());
                    string userID = dr["UserID"].ToString();
                    string user = dr["Name"].ToString();
                    string district = dr["District"].ToString();
                    string department = dr["Department"].ToString();
                    bool personalMileage = Convert.ToBoolean(dr["MileagePersonal"].ToString());
                    dgvAthorizations.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, budgeted, user, estTotal, estimateID, userID, district, department, personalMileage);
                }
                dr.Close();

                SqlCommand em = new SqlCommand("SELECT a.UserID,a.Name,a.LastName FROM [TravelExpenses].[dbo].[User] as a inner join [TravelExpenses].[dbo].[User_Email_Title] as b on a.UserID = b.UserID where  AND Department = 'Hyacinth' order by LastName", localCon);
                SqlDataReader emDR = em.ExecuteReader();
                if (emDR.HasRows)
                {
                    cbEmployee.DisplayMember = "Text";
                    cbEmployee.ValueMember = "Value";
                    List<Object> items = new List<object>();
                    while (emDR.Read())
                    {
                        string name = emDR["LastName"].ToString() + "," + emDR["Name"].ToString();
                        string id = emDR["UserID"].ToString();
                        items.Add(new { Text = name, Value = id });


                    }
                    items.Add(new { Text = "All", Value = "-1" });
                    cbEmployee.DataSource = items;
                }
                cbEmployee.SelectedValue = "-1";

                emDR.Close();
            }
            else
            {
                if (title == "Accounting Processor")
                {
                    btnArchive.Visible = true;
                    label3.Visible = true;
                }

                if (username == "TPineda")
                {
                    btnArchive.Visible = true;
                    label3.Visible = true;
                    btnDelete.Visible = true;
                    label4.Visible = true;
                }

                SqlCommand cmd = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status != 'Final' order by a.ReturnDate desc", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string estimateID = dr["TravelEstimateID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();

                    string estTotal = dr["EstimatedTravelCost"].ToString();
                    bool budgeted = Convert.ToBoolean(dr["BudgetedTravel"].ToString());
                    string userID = dr["UserID"].ToString();
                    string user = dr["Name"].ToString();
                    string district = dr["District"].ToString();
                    string department = dr["Department"].ToString();
                    bool personalMileage = Convert.ToBoolean(dr["MileagePersonal"].ToString());
                    dgvAthorizations.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, budgeted, user, estTotal, estimateID, userID, district, department, personalMileage);
                }
                dr.Close();

                SqlCommand em = new SqlCommand("SELECT a.UserID,a.Name,a.LastName FROM [TravelExpenses].[dbo].[User] as a inner join [TravelExpenses].[dbo].[User_Email_Title] as b on a.UserID = b.UserID  order by LastName", localCon);
                SqlDataReader emDR = em.ExecuteReader();
                if (emDR.HasRows)
                {
                    cbEmployee.DisplayMember = "Text";
                    cbEmployee.ValueMember = "Value";
                    List<Object> items = new List<object>();
                    while (emDR.Read())
                    {
                        string name = emDR["LastName"].ToString() + "," + emDR["Name"].ToString();
                        string id = emDR["UserID"].ToString();
                        items.Add(new { Text = name, Value = id });


                    }
                    items.Add(new { Text = "All", Value = "-1" });
                    cbEmployee.DataSource = items;
                }
                cbEmployee.SelectedValue = "-1";

                emDR.Close();
            }

            localCon.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAthorizations.Rows.Count > 0)
            {
                DialogResult delAuth = MessageBox.Show("Do you really want to delete this Authorization?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delAuth == DialogResult.Yes)
                {
                    int rowIndex = dgvAthorizations.CurrentRow.Index;
                    string estID = dgvAthorizations.Rows[rowIndex].Cells[7].Value.ToString();
                    localCon.Open();

                    SqlCommand delSign = new SqlCommand("delete TravelExpenses.dbo.TravelSignatures where TravelID = '" + estID + "' AND TravelType = 'Estimate'", localCon);
                    int signRow = delSign.ExecuteNonQuery();

                    SqlCommand delStatus = new SqlCommand("delete TravelExpenses.dbo.EstimateTravel_Status where TravelEstimateID = '" + estID + "'", localCon);
                    int statusRows = delStatus.ExecuteNonQuery();

                    SqlCommand delAutho = new SqlCommand("delete [TravelExpenses].[dbo].[EstimateTravel] where TravelEstimateID = '" + estID + "'", localCon);
                    int authRows = delAutho.ExecuteNonQuery();

                    localCon.Close();

                    if (statusRows > 0 && authRows > 0)
                    {
                        MessageBox.Show("The Travel Authorization was successfully deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshTravels();
                    }


                }
            }
        }
    }
}
