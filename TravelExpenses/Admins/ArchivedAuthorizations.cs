//using iTextSharp.text.pdf; //commented for net6
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Kernel.XMP;
using iText.Kernel;
using iText.Forms;
using iText.Forms.Fields;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using System.Speech.Recognition;

namespace TravelExpenses
{
    public partial class ArchivedAuthorizations : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string winUser = Environment.UserName;
        string department = "";
        string userType = "";
        string title = "";

        public ArchivedAuthorizations()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ArchivedAuthorizations_Load(object sender, EventArgs e)
        {
            localCon.Open();
            SqlCommand auth = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status = 'Final' order by a.ReturnDate desc", localCon);
            SqlDataReader authDR = auth.ExecuteReader();
            if (authDR.Read())
            {
                while (authDR.Read())
                {
                    string estimateID = authDR["TravelEstimateID"].ToString();
                    DateTime depDate = Convert.ToDateTime(authDR["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(authDR["ReturnDate"].ToString());
                    string travEvent = authDR["TravelEvent"].ToString();
                    string travPurpose = authDR["TravelPurpose"].ToString();

                    string estTotal = authDR["EstimatedTravelCost"].ToString();
                    bool budgeted = Convert.ToBoolean(authDR["BudgetedTravel"].ToString());
                    string userID = authDR["UserID"].ToString();
                    string user = authDR["Name"].ToString();
                    string district = authDR["District"].ToString();
                    string department = authDR["Department"].ToString();
                    bool personalMileage = Convert.ToBoolean(authDR["MileagePersonal"].ToString());
                    dgvAthorizations.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, budgeted, user, estTotal, estimateID, userID, district, department, personalMileage);
                }
            }
            authDR.Close();


            SqlCommand em = new SqlCommand("SELECT [UserID],[Name],[LastName] FROM [TravelExpenses].[dbo].[User]  order by LastName", localCon);
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

            localCon.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void refreshData()
        {
            dgvAthorizations.Rows.Clear();
            localCon.Open();
            if (cbEmployee.SelectedValue.ToString() == "-1")
            {
                SqlCommand auth = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status = 'Final' order by a.ReturnDate desc", localCon);
                SqlDataReader authDR = auth.ExecuteReader();
                if (authDR.HasRows)
                {
                    while (authDR.Read())
                    {
                        string estimateID = authDR["TravelEstimateID"].ToString();
                        DateTime depDate = Convert.ToDateTime(authDR["DepartureDate"].ToString());
                        DateTime retDate = Convert.ToDateTime(authDR["ReturnDate"].ToString());
                        string travEvent = authDR["TravelEvent"].ToString();
                        string travPurpose = authDR["TravelPurpose"].ToString();

                        string estTotal = authDR["EstimatedTravelCost"].ToString();
                        bool budgeted = Convert.ToBoolean(authDR["BudgetedTravel"].ToString());
                        string userID = authDR["UserID"].ToString();
                        string user = authDR["Name"].ToString();
                        string district = authDR["District"].ToString();
                        string department = authDR["Department"].ToString();
                        bool personalMileage = Convert.ToBoolean(authDR["MileagePersonal"].ToString());
                        dgvAthorizations.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, budgeted, user, estTotal, estimateID, userID, district, department, personalMileage);
                    }
                }
                authDR.Close();

            }
            else
            {
                string userIDValue = cbEmployee.SelectedValue.ToString();
                Guid useridConv = new Guid(userIDValue);

                SqlCommand auth = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status = 'Final' AND a.UserID = '" + useridConv + "' order by a.ReturnDate desc", localCon);
                SqlDataReader authDR = auth.ExecuteReader();
                if (authDR.HasRows)
                {
                    while (authDR.Read())
                    {
                        string estimateID = authDR["TravelEstimateID"].ToString();
                        DateTime depDate = Convert.ToDateTime(authDR["DepartureDate"].ToString());
                        DateTime retDate = Convert.ToDateTime(authDR["ReturnDate"].ToString());
                        string travEvent = authDR["TravelEvent"].ToString();
                        string travPurpose = authDR["TravelPurpose"].ToString();

                        string estTotal = authDR["EstimatedTravelCost"].ToString();
                        bool budgeted = Convert.ToBoolean(authDR["BudgetedTravel"].ToString());
                        string userID = authDR["UserID"].ToString();
                        string user = authDR["Name"].ToString();
                        string district = authDR["District"].ToString();
                        string department = authDR["Department"].ToString();
                        bool personalMileage = Convert.ToBoolean(authDR["MileagePersonal"].ToString());
                        dgvAthorizations.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, budgeted, user, estTotal, estimateID, userID, district, department, personalMileage);
                    }
                }
                authDR.Close();
            }
            localCon.Close();
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

                /*PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
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
                        fields.TryGetValue("Travel_Budgeted_Yes", out toSet);
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
                            fields.TryGetValue("NotesMileage", out toSet);
                            toSet.SetValue(dr["MileageNotes"].ToString());

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
                                // bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\BRADHITC.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); //commented for net6
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
                //pdfStamper.Close();
                form.FlattenFields();
                pdfDoc.Close();
                localCon.Close();
                ViewPDF vp = new ViewPDF();
                vp.Show();
            }
        }
    }
}
