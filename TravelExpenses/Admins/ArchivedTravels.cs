//using iTextSharp.text.pdf; //commented for net6
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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

namespace TravelExpenses
{
    public partial class ArchivedTravels : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string winUser = Environment.UserName;
        double travelACC = 0;
        double trainingACC = 0;
        int index = 0;
        bool hideApproved = false;
        public ArchivedTravels()
        {
            InitializeComponent();
        }

        private void ArchivedTravels_Load(object sender, EventArgs e)
        {
            localCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status, a.UserID as UserID,c.Name as Name,c.LastName as Lastname FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join [TravelExpenses].[dbo].[User] as c on a.UserID = c.UserID where b.Status = 'Final' order by a.DepartureDate desc", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string travelID = dr["TravelID"].ToString();
                DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                string travEvent = dr["TravelEvent"].ToString();
                string travPurpose = dr["TravelPurpose"].ToString();
                string origin = dr["Origin"].ToString();
                string destination = dr["Destination"].ToString();
                string travTotal = dr["TotalTravelAmount"].ToString();
                string status = dr["Status"].ToString();
                string userID = dr["UserID"].ToString();
                string username = dr["Name"].ToString() + " " + dr["Lastname"].ToString();
                dgvArchivedTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination, travTotal, travelID, userID, username);
            }
            dr.Close();

            SqlCommand em = new SqlCommand("SELECT [UserID],[Name],[LastName] FROM [TravelExpenses].[dbo].[User] order by LastName", localCon);
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
                int rowcant = cbEmployee.Items.Count - 1;
                cbEmployee.SelectedIndex = rowcant;
            }

            emDR.Close();

            for (int i = 0; i < dgvArchivedTravels.RowCount; i++)
            {
                Guid travID = new Guid(dgvArchivedTravels.Rows[i].Cells[8].Value.ToString());
                Guid accUser = new Guid(CommonVariables.user);
                SqlCommand signAcc = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' And UserType = 'Accounting' AND TravelID = '" + travID + "' AND UserID = '" + accUser + "'", localCon);
                SqlDataReader signAccDR = signAcc.ExecuteReader();
                if (signAccDR.HasRows)
                {
                    dgvArchivedTravels.Rows[i].Cells[11].Value = "Yes";
                }
                else
                {
                    dgvArchivedTravels.Rows[i].Cells[11].Value = "No";
                }
                signAccDR.Close();
            }
            localCon.Close();
        }

        private void generatePDF()
        {
            localCon.Open();
            string name = "";
            string lastname = "";
            string district = "";
            string department = "";
            string fullName = "";
            string username = "";
            string departureDate = "";
            string returnDate = "";
            string travUserID = "";

            //cleaning the accounting variables
            travelACC = 0;
            trainingACC = 0;

            //reimbursement variables
            double mealsReimbursement = 0;
            double registratiorReimbursement = 0;
            double lodgingReimbursement = 0;
            double carRentalReimbursement = 0;
            double mileagReimbursement = 0;
            double airfareReimbursement = 0;
            double otherExpenseReimbursement = 0;


            int rowIndex = dgvArchivedTravels.CurrentRow.Index;
            string IdTrav = dgvArchivedTravels.Rows[rowIndex].Cells[8].Value.ToString();
            Guid travID = new Guid(IdTrav);


            SqlCommand cmdTDates = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
            SqlDataReader drTDates = cmdTDates.ExecuteReader();
            while (drTDates.Read())
            {
                departureDate = Convert.ToDateTime(drTDates["DepartureDate"].ToString()).ToShortDateString();
                returnDate = Convert.ToDateTime(drTDates["ReturnDate"].ToString()).ToShortDateString();
                travUserID = drTDates["UserID"].ToString();
            }
            drTDates.Close();

            Guid travUserIDG = new Guid(travUserID);

            SqlCommand cmdUser = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] where UserID = '" + travUserIDG + "'", localCon);
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

            

            string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form.pdf";
            string pdfName = fullName + "_" + departureDate + "_" + "to" + "_" + returnDate + ".pdf";
            pdfName = pdfName.Replace("/", "-");
            string newFile = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\travel_form_" + pdfName;
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
            SqlCommand cmdTD = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
            SqlDataReader drTD = cmdTD.ExecuteReader();
            while (drTD.Read())
            {
                //pdfFormFields.SetField("Travel Event", drTD["TravelEvent"].ToString()); //commented for net6
                fields.TryGetValue("Travel Event", out toSet);
                toSet.SetValue(drTD["TravelEvent"].ToString());

                //pdfFormFields.SetField("Travel Purpose", drTD["TravelPurpose"].ToString()); //commented for net6
                fields.TryGetValue("Travel Purpose", out toSet);
                toSet.SetValue(drTD["TravelPurpose"].ToString());

                DateTime dd = Convert.ToDateTime(drTD["DepartureDate"].ToString());
                //pdfFormFields.SetField("Departure Date", dd.ToShortDateString()); //commented for net6
                fields.TryGetValue("Departure Date", out toSet);
                toSet.SetValue(dd.ToShortDateString());

                //pdfFormFields.SetField("Departure Time", drTD["DepartureTime"].ToString()); //commented for net6
                fields.TryGetValue("Departure Time", out toSet);
                toSet.SetValue(drTD["DepartureTime"].ToString());

                DateTime rd = Convert.ToDateTime(drTD["ReturnDate"].ToString());
                //pdfFormFields.SetField("Return Date", rd.ToShortDateString()); //commented for net6
                fields.TryGetValue("Return Date", out toSet);
                toSet.SetValue(rd.ToShortDateString());

                //pdfFormFields.SetField("Return Time", drTD["ReturnTime"].ToString()); //commented for net6
                fields.TryGetValue("Return Time", out toSet);
                toSet.SetValue(drTD["ReturnTime"].ToString());

                //pdfFormFields.SetField("Origin", drTD["Origin"].ToString()); //commented for net6
                fields.TryGetValue("Origin", out toSet);
                toSet.SetValue(drTD["Origin"].ToString());

                //pdfFormFields.SetField("Destination", drTD["Destination"].ToString()); //commented for net6
                fields.TryGetValue("Destination", out toSet);
                toSet.SetValue(drTD["Destination"].ToString());

                //pdfFormFields.SetField("Travel State", drTD["TravelState"].ToString()); //commented for net6
                fields.TryGetValue("Travel State", out toSet);
                toSet.SetValue(drTD["TravelState"].ToString());

                //pdfFormFields.SetField("Travel Notes", drTD["Notes"].ToString()); //commented for net6
                fields.TryGetValue("Travel Notes", out toSet);
                toSet.SetValue(drTD["Notes"].ToString());

                //Tratel Totals
                travelACC = Convert.ToDouble(drTD["TotalTravelAmount"].ToString());
                string travCost = travelACC.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                double reimValue = Convert.ToDouble(drTD["TotalTravelReimbursed"].ToString());
                string reimCost = reimValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                double noReimCostValue = Convert.ToDouble(drTD["TotalTravelNoReimbursed"].ToString());
                string noReimCost = noReimCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                //pdfFormFields.SetField("Travel Total", travCost); //commented for net6
                fields.TryGetValue("Travel Total", out toSet);
                toSet.SetValue(travCost);

                //pdfFormFields.SetField("Total Reimbursed", reimCost); //commented for net6
                fields.TryGetValue("Total Reimbursed", out toSet);
                toSet.SetValue(reimCost);

                //pdfFormFields.SetField("No Reimbursed", noReimCost); //commented for net6
                fields.TryGetValue("No Reimbursed", out toSet);
                toSet.SetValue(noReimCost);

                //pdfFormFields.SetField("Travel Total Cost", travCost); //commented for net6
                fields.TryGetValue("Travel Total Cost", out toSet);
                toSet.SetValue(travCost);

                //pdfFormFields.SetField("Reimbursement", reimCost); //commented for net6
                fields.TryGetValue("Reimbursement", out toSet);
                toSet.SetValue(reimCost);

                //pdfFormFields.SetField("No Reimbursed Total", noReimCost); //commented for net6
                fields.TryGetValue("No Reimbursed Total", out toSet);
                toSet.SetValue(noReimCost);

                //set up the travel common variables
                if (drTD["Melas"].ToString() == "True")
                {
                    CommonVariables.isMeals = true;
                }
                if (drTD["Registration"].ToString() == "True")
                {
                    CommonVariables.isRegistartion = true;
                }
                if (drTD["CarRental"].ToString() == "True")
                {
                    CommonVariables.isCarRental = true;
                }
                if (drTD["Lodging"].ToString() == "True")
                {
                    CommonVariables.isLodging = true;
                }
                if (drTD["AirFare"].ToString() == "True")
                {
                    CommonVariables.isAirFare = true;
                }
                if (drTD["Mileage"].ToString() == "True")
                {
                    CommonVariables.isMileage = true;
                }
                if (drTD["OtherExpenses"].ToString() == "True")
                {
                    CommonVariables.isOtherExpenses = true;
                }
            }
            drTD.Close();

            //Meals Details
            if (CommonVariables.isMeals)
            {
                string mealIDvalue = "";
                SqlCommand cmdMeals = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drMeals = cmdMeals.ExecuteReader();
                while (drMeals.Read())
                {
                    double mealCostValue = Convert.ToDouble(drMeals["TotalMeals"].ToString());
                    mealIDvalue = drMeals["MealsID"].ToString();
                    string mealCost = mealCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                    //pdfFormFields.SetField("CostMeals", mealCost); //commented for net6
                    fields.TryGetValue("CostMeals", out toSet);
                    toSet.SetValue(mealCost);

                    //pdfFormFields.SetField("NotesMeals", drMeals["Notes"].ToString()); //commented for net6
                    fields.TryGetValue("NotesMeals", out toSet);
                    toSet.SetValue(drMeals["Notes"].ToString());

                    //pdfFormFields.SetField("BreakfastPerDiemRate", drMeals["BreakfastPerDiemRate"].ToString()); //commented for net6
                    fields.TryGetValue("BreakfastPerDiemRate", out toSet);
                    toSet.SetValue(drMeals["BreakfastPerDiemRate"].ToString());

                    //pdfFormFields.SetField("LunchPerDiemRate", drMeals["LunchPerDiemRate"].ToString()); //commented for net6
                    fields.TryGetValue("LunchPerDiemRate", out toSet);
                    toSet.SetValue(drMeals["LunchPerDiemRate"].ToString());

                    //pdfFormFields.SetField("DinnerPerDiemRate", drMeals["DinnerPerDiemRate"].ToString()); //commented for net6
                    fields.TryGetValue("DinnerPerDiemRate", out toSet);
                    toSet.SetValue(drMeals["DinnerPerDiemRate"].ToString());

                    //pdfFormFields.SetField("TotalMealsPerDiemRate", drMeals["TotalPerDiemRate"].ToString()); //commented for net6
                    fields.TryGetValue("TotalMealsPerDiemRate", out toSet);
                    toSet.SetValue(drMeals["TotalPerDiemRate"].ToString());

                    //pdfFormFields.SetField("PerDiemLoactionZipCode", drMeals["PerDiemLoactionZipCode"].ToString()); //commented for net6
                    fields.TryGetValue("PerDiemLoactionZipCode", out toSet);
                    toSet.SetValue(drMeals["PerDiemLoactionZipCode"].ToString());

                    //details

                    //pdfFormFields.SetField("BreakfastQuantity", drMeals["Breakfast"].ToString()); //commented for net6
                    fields.TryGetValue("BreakfastQuantity", out toSet);
                    toSet.SetValue(drMeals["Breakfast"].ToString());

                    //pdfFormFields.SetField("LunchQuantity", drMeals["Lunch"].ToString()); //commented for net6
                    fields.TryGetValue("LunchQuantity", out toSet);
                    toSet.SetValue(drMeals["Lunch"].ToString());

                    //pdfFormFields.SetField("DinnerQuantity", drMeals["Dinner"].ToString()); //commented for net6
                    fields.TryGetValue("DinnerQuantity", out toSet);
                    toSet.SetValue(drMeals["Dinner"].ToString());

                    double brekCost = Convert.ToInt32(drMeals["Breakfast"].ToString()) * Convert.ToDouble(drMeals["BreakfastPerDiemRate"].ToString());
                    //pdfFormFields.SetField("BreakfastCost", brekCost.ToString()); //commented for net6
                    fields.TryGetValue("BreakfastCost", out toSet);
                    toSet.SetValue(brekCost.ToString());

                    double lunchCost = Convert.ToInt32(drMeals["Lunch"].ToString()) * Convert.ToDouble(drMeals["LunchPerDiemRate"].ToString());
                    //pdfFormFields.SetField("LunchCost", lunchCost.ToString()); //commented for net6
                    fields.TryGetValue("LunchCost", out toSet);
                    toSet.SetValue(lunchCost.ToString());

                    double dinCost = Convert.ToInt32(drMeals["Dinner"].ToString()) * Convert.ToDouble(drMeals["DinnerPerDiemRate"].ToString());
                    //pdfFormFields.SetField("DinnerCost", dinCost.ToString()); //commented for net6
                    fields.TryGetValue("DinnerCost", out toSet);
                    toSet.SetValue(dinCost.ToString());

                    //pdfFormFields.SetField("Meals Notes", drMeals["Notes"].ToString()); //commented for net6
                    fields.TryGetValue("Meals Notes", out toSet);
                    toSet.SetValue(drMeals["Notes"].ToString());

                    if (drMeals["ProvidedMeal"].ToString() == "True")
                    {
                        //pdfFormFields.SetField("Provided Meals", "Yes"); //commented for net6
                        fields.TryGetValue("Provided Meals", out toSet);
                        toSet.SetValue("Yes");
                    }
                    else
                    {
                        //pdfFormFields.SetField("Provided Meals", "No"); //commented for net6
                        fields.TryGetValue("Provided Meals", out toSet);
                        toSet.SetValue("No");
                    }
                    //string mealCost = Convert.ToDouble(drMeals["TotalMeals"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);

                    //pdfFormFields.SetField("Meals_Total", mealCost); //commented for net6
                    fields.TryGetValue("Meals_Total", out toSet);
                    toSet.SetValue(mealCost);

                    //setting the value for meal reimbursement
                    mealsReimbursement = mealCostValue;
                }
                drMeals.Close();



                Guid mealID = new Guid(mealIDvalue);
                int rowInc = 1;
                SqlCommand meadDate = new SqlCommand("SELECT [Date] ,[Breaksfast],[Lunch] ,[Dinner] FROM [TravelExpenses].[dbo].[MealDate] where MealsID = '" + mealID + "' order by date asc", localCon);
                SqlDataReader meadDateDR = meadDate.ExecuteReader();
                while (meadDateDR.Read())
                {
                    DateTime date = Convert.ToDateTime(meadDateDR["Date"].ToString());
                    //pdfFormFields.SetField("MealDate" + rowInc, date.ToShortDateString()); //commented for net6
                    fields.TryGetValue("MealDate" + rowInc, out toSet);
                    toSet.SetValue(date.ToShortDateString());

                    if (meadDateDR["Breaksfast"].ToString() == "True")
                    {
                        //pdfFormFields.SetField("Breakfast" + rowInc, "Yes"); //commented for net6
                        fields.TryGetValue("Breakfast" + rowInc, out toSet);
                        toSet.SetValue("Yes");
                    }
                    if (meadDateDR["Lunch"].ToString() == "True")
                    {
                        //pdfFormFields.SetField("Lunch" + rowInc, "Yes"); //commented for net6
                        fields.TryGetValue("Lunch" + rowInc, out toSet);
                        toSet.SetValue("Yes");
                    }
                    if (meadDateDR["Dinner"].ToString() == "True")
                    {
                        //pdfFormFields.SetField("Dinner" + rowInc, "Yes"); //commented for net6
                        fields.TryGetValue("Dinner" + rowInc, out toSet);
                        toSet.SetValue("Yes");
                    }
                    rowInc++;
                }
                meadDateDR.Close();
            }

            //Registration Details
            if (CommonVariables.isRegistartion)
            {

                SqlCommand cmdRegis = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drRegis = cmdRegis.ExecuteReader();
                while (drRegis.Read())
                {
                    trainingACC = Convert.ToDouble(drRegis["RegistrationAMount"].ToString());
                    travelACC = travelACC - trainingACC;
                    if (travelACC < 0)
                    {
                        travelACC = travelACC * -1;
                    }
                    string totalReg = trainingACC.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                    //pdfFormFields.SetField("CostRegistration", totalReg); //commented for net6
                    fields.TryGetValue("CostRegistration", out toSet);
                    toSet.SetValue(totalReg);

                    //pdfFormFields.SetField("NotesRegistration", drRegis["Notes"].ToString()); //commented for net6
                    fields.TryGetValue("NotesRegistration", out toSet);
                    toSet.SetValue(drRegis["Notes"].ToString());

                    //details
                    //pdfFormFields.SetField("Registration Cost", totalReg); //commented for net6
                    fields.TryGetValue("Registration Cost", out toSet);
                    toSet.SetValue(totalReg);

                    //pdfFormFields.SetField("Registartion Notes", drRegis["Notes"].ToString()); //commented for net6
                    fields.TryGetValue("Registartion Notes", out toSet);
                    toSet.SetValue(drRegis["Notes"].ToString());

                    if (drRegis["DistrictPay"].ToString() == "True")
                    {
                        //pdfFormFields.SetField("District Pay Registration", "Yes"); //commented for net6
                        fields.TryGetValue("District Pay Registration", out toSet);
                        toSet.SetValue("Yes");
                    }
                    else
                    {
                        //pdfFormFields.SetField("District Pay Registration", "No"); //commented for net6
                        fields.TryGetValue("District Pay Registration", out toSet);
                        toSet.SetValue("No");

                        //setting the value for the registration reimbursement
                        registratiorReimbursement = Convert.ToDouble(drRegis["RegistrationAMount"].ToString());
                    }
                }
                drRegis.Close();

            }

            //Lodging
            if (CommonVariables.isLodging)
            {

                SqlCommand cmdLod = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drLod = cmdLod.ExecuteReader();

                double totalLod = 0;
                string notes = "";
                int rowLod = 1;
                while (drLod.Read())
                {
                    totalLod = totalLod + Convert.ToDouble(drLod["TotalLodging"].ToString());
                    if (drLod["Notes"].ToString() != "")
                    {
                        notes += drLod["Notes"].ToString() + " .";
                    }

                    //details

                    //pdfFormFields.SetField("Facility Name" + rowLod, drLod["FacilityName"].ToString()); //commented for net6
                    fields.TryGetValue("Facility Name" + rowLod, out toSet);
                    toSet.SetValue(drLod["FacilityName"].ToString());

                    //pdfFormFields.SetField("Facility Total Cost" + rowLod, drLod["TotalLodging"].ToString()); //commented for net6
                    fields.TryGetValue("Facility Total Cost" + rowLod, out toSet);
                    toSet.SetValue(drLod["TotalLodging"].ToString());

                    //totalLod = totalLod + Convert.ToDouble(drLod["TotalLodging"].ToString());

                    //pdfFormFields.SetField("Lodging Nights" + rowLod, drLod["NumberOfNights"].ToString()); //commented for net6
                    fields.TryGetValue("Lodging Nights" + rowLod, out toSet);
                    toSet.SetValue(drLod["NumberOfNights"].ToString());

                    //pdfFormFields.SetField("Lodging Night Cost" + rowLod, drLod["CostPerNight"].ToString()); //commented for net6
                    fields.TryGetValue("Lodging Night Cost" + rowLod, out toSet);
                    toSet.SetValue(drLod["CostPerNight"].ToString());

                    //pdfFormFields.SetField("Lodging Taxes Fees" + rowLod, drLod["TaxesAndFees"].ToString()); //commented for net6
                    fields.TryGetValue("Lodging Taxes Fees" + rowLod, out toSet);
                    toSet.SetValue(drLod["TaxesAndFees"].ToString());

                    if (drLod["DistrictPay"].ToString() == "True")
                    {
                        //pdfFormFields.SetField("Lodging District Pay" + rowLod, "Yes"); //commented for net6
                        fields.TryGetValue("Lodging District Pay" + rowLod, out toSet);
                        toSet.SetValue("Yes");

                        //pdfFormFields.SetField("Lodging Director Approval" + rowLod, ""); //commented for net6
                        fields.TryGetValue("Lodging Director Approval" + rowLod, out toSet);
                        toSet.SetValue("");
                    }
                    else
                    {
                        //pdfFormFields.SetField("Lodging District Pay" + rowLod, "No"); //commented for net6
                        fields.TryGetValue("Lodging District Pay" + rowLod, out toSet);
                        toSet.SetValue("No");

                        if (drLod["DirectorApproved"].ToString() == "True")
                        {
                            //pdfFormFields.SetField("Lodging Director Approval" + rowLod, "Yes"); //commented for net6
                            fields.TryGetValue("Lodging Director Approval" + rowLod, out toSet);
                            toSet.SetValue("Yes");

                            //setting the value for the lodging reimbursement
                            lodgingReimbursement += Convert.ToDouble(drLod["TotalLodging"].ToString());
                        }
                        else
                        {
                            //pdfFormFields.SetField("Lodging Director Approval" + rowLod, "No"); //commented for net6
                            fields.TryGetValue("Lodging Director Approval" + rowLod, out toSet);
                            toSet.SetValue("No");
                        }
                    }
                    //pdfFormFields.SetField("Facility  Notes" + rowLod, drLod["Notes"].ToString()); //commented for net6
                    fields.TryGetValue("Facility  Notes" + rowLod, out toSet);
                    toSet.SetValue(drLod["Notes"].ToString());

                    rowLod++;
                }
                drLod.Close();
                string lodgCost = totalLod.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                //pdfFormFields.SetField("CostLodgings", lodgCost); //commented for net6
                fields.TryGetValue("CostLodgings", out toSet);
                toSet.SetValue(lodgCost);

                //pdfFormFields.SetField("NotesLodgings", notes); //commented for net6
                fields.TryGetValue("NotesLodgings", out toSet);
                toSet.SetValue(notes);

                //pdfFormFields.SetField("Lodging Total", lodgCost); //commented for net6
                fields.TryGetValue("Lodging Total", out toSet);
                toSet.SetValue(lodgCost);
            }

            //Car Rental Details
            if (CommonVariables.isCarRental)
            {
                SqlCommand cmdCR = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drCR = cmdCR.ExecuteReader();


                double totalCR = 0;
                string notesCR = "";
                int carRow = 1;
                while (drCR.Read())
                {
                    totalCR = totalCR + Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    if (drCR["Notes"].ToString() != "")
                    {
                        notesCR += drCR["Notes"].ToString() + " .";
                    }

                    //details
                    DateTime pickUp = Convert.ToDateTime(drCR["PickUPDate"].ToString());
                    //pdfFormFields.SetField("Pick up Date" + carRow, pickUp.ToShortDateString()); //commented for net6
                    fields.TryGetValue("Pick up Date" + carRow, out toSet);
                    toSet.SetValue(pickUp.ToShortDateString());

                    DateTime dropOff = Convert.ToDateTime(drCR["DropOffDate"].ToString());
                    //pdfFormFields.SetField("Drop off Date" + carRow, dropOff.ToShortDateString()); //commented for net6
                    fields.TryGetValue("Drop off Date" + carRow, out toSet);
                    toSet.SetValue(dropOff.ToShortDateString());

                    //pdfFormFields.SetField("Car_Day Cost" + carRow, drCR["CostPerDay"].ToString()); //commented for net6
                    fields.TryGetValue("Car_Day Cost" + carRow, out toSet);
                    toSet.SetValue(drCR["CostPerDay"].ToString());

                    //pdfFormFields.SetField("Car Total" + carRow, drCR["TotalCarRental"].ToString()); //commented for net6
                    fields.TryGetValue("Car Total" + carRow, out toSet);
                    toSet.SetValue(drCR["TotalCarRental"].ToString());

                    //totalCR = totalCR + Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    //pdfFormFields.SetField("Car Type" + carRow, drCR["CarType"].ToString()); //commented for net6
                    fields.TryGetValue("Car Type" + carRow, out toSet);
                    toSet.SetValue(drCR["CarType"].ToString());

                    //pdfFormFields.SetField("Rental Company" + carRow, drCR["Company"].ToString()); //commented for net6
                    fields.TryGetValue("Rental Company" + carRow, out toSet);
                    toSet.SetValue(drCR["Company"].ToString());

                    //pdfFormFields.SetField("Car Rental Days" + carRow, drCR["Days"].ToString()); //commented for net6
                    fields.TryGetValue("Car Rental Days" + carRow, out toSet);
                    toSet.SetValue(drCR["Days"].ToString());

                    //pdfFormFields.SetField("Car Rental Taxes Fees" + carRow, drCR["TaxesAndFees"].ToString()); //commented for net6
                    fields.TryGetValue("Car Rental Taxes Fees" + carRow, out toSet);
                    toSet.SetValue(drCR["TaxesAndFees"].ToString());

                    //pdfFormFields.SetField("LDW Insurance" + carRow, drCR["LDWInsuranse"].ToString()); //commented for net6
                    fields.TryGetValue("LDW Insurance" + carRow, out toSet);
                    toSet.SetValue(drCR["LDWInsuranse"].ToString());

                    //pdfFormFields.SetField("Supplemental Insurance" + carRow, drCR["SupplementalInsurance"].ToString()); //commented for net6
                    fields.TryGetValue("Supplemental Insurance" + carRow, out toSet);
                    toSet.SetValue(drCR["SupplementalInsurance"].ToString());

                    //pdfFormFields.SetField("Extra Insurance" + carRow, drCR["ExtarInsuranceAmount"].ToString()); //commented for net6
                    fields.TryGetValue("Extra Insurance" + carRow, out toSet);
                    toSet.SetValue(drCR["ExtarInsuranceAmount"].ToString());

                    if (drCR["DistrictPay"].ToString() == "True")
                    {
                        //pdfFormFields.SetField("Car District Pay" + carRow, "Yes"); //commented for net6
                        fields.TryGetValue("Car District Pay" + carRow, out toSet);
                        toSet.SetValue("Yes");
                    }
                    else
                    {
                        //pdfFormFields.SetField("Car District Pay" + carRow, "No"); //commented for net6
                        fields.TryGetValue("Car District Pay" + carRow, out toSet);
                        toSet.SetValue("No");

                        //setting the value for the car rental reimbursement
                        carRentalReimbursement += Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    }

                    //pdfFormFields.SetField("Car Personal Amount" + carRow, drCR["PersonalAmount"].ToString()); //commented for net6
                    fields.TryGetValue("Car Personal Amount" + carRow, out toSet);
                    toSet.SetValue(drCR["PersonalAmount"].ToString());

                    //pdfFormFields.SetField("Car Notes" + carRow, drCR["Notes"].ToString()); //commented for net6
                    fields.TryGetValue("Car Notes" + carRow, out toSet);
                    toSet.SetValue(drCR["Notes"].ToString());

                    carRow++;
                }
                drCR.Close();
                string carCost = totalCR.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                //pdfFormFields.SetField("CostCar Rental", carCost); //commented for net6
                fields.TryGetValue("CostCar Rental", out toSet);
                toSet.SetValue(carCost);

                //pdfFormFields.SetField("NotesCar Rental", notesCR); //commented for net6
                fields.TryGetValue("NotesCar Rental", out toSet);
                toSet.SetValue(notesCR);

                //pdfFormFields.SetField("Car Rental Total", carCost); //commented for net6
                fields.TryGetValue("Car Rental Total", out toSet);
                toSet.SetValue(carCost);
            }

            //AirFare Details
            if (CommonVariables.isAirFare)
            {
                SqlCommand cmdAF = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drAF = cmdAF.ExecuteReader();

                double totalAF = 0;
                string notesAF = "";
                int flightRow = 1;

                while (drAF.Read())
                {
                    totalAF = totalAF + Convert.ToDouble(drAF["AirFareTotal"].ToString());
                    if (drAF["Notes"].ToString() != "")
                    {
                        notesAF += drAF["Notes"].ToString() + " .";
                    }

                    //details
                    DateTime depDateFligh = Convert.ToDateTime(drAF["DepartureDate"].ToString());
                    //pdfFormFields.SetField("Flight_Departure Date" + flightRow, depDateFligh.ToShortDateString()); //commented for net6
                    fields.TryGetValue("Flight_Departure Date" + flightRow, out toSet);
                    toSet.SetValue(depDateFligh.ToShortDateString());

                    if (drAF["ReturnDate"].ToString() != "")
                    {
                        DateTime rd = Convert.ToDateTime(drAF["ReturnDate"].ToString());
                        //pdfFormFields.SetField("Flight_Return Date" + flightRow, rd.ToShortDateString()); //commented for net6
                        fields.TryGetValue("Flight_Return Date" + flightRow, out toSet);
                        toSet.SetValue(rd.ToShortDateString());
                    }
                    //pdfFormFields.SetField("Flight Total" + flightRow, drAF["AirFareTotal"].ToString()); //commented for net6
                    fields.TryGetValue("Flight Total" + flightRow, out toSet);
                    toSet.SetValue(drAF["AirFareTotal"].ToString());

                    //totalAF = totalAF + Convert.ToDouble(drAF["AirFareTotal"].ToString());

                    //pdfFormFields.SetField("Flight Taxes  Fees" + flightRow, drAF["TaxesAndFees"].ToString()); //commented for net6
                    fields.TryGetValue("Flight Taxes  Fees" + flightRow, out toSet);
                    toSet.SetValue(drAF["TaxesAndFees"].ToString());

                    if (drAF["DistrictPay"].ToString() == "True")
                    {
                        //pdfFormFields.SetField("Flight District Pay" + flightRow, "Yes"); //commented for net6
                        fields.TryGetValue("Flight District Pay" + flightRow, out toSet);
                        toSet.SetValue("Yes");
                    }
                    else
                    {
                        //pdfFormFields.SetField("Flight District Pay" + flightRow, "No"); //commented for net6
                        fields.TryGetValue("Flight District Pay" + flightRow, out toSet);
                        toSet.SetValue("No");

                        //setting the value for the airfare reimbursement
                        airfareReimbursement += Convert.ToDouble(drAF["AirFareTotal"].ToString());
                    }

                    //pdfFormFields.SetField("Flight Personal Amount" + flightRow, drAF["PersonalUseAmount"].ToString()); //commented for net6
                    fields.TryGetValue("Flight Personal Amount" + flightRow, out toSet);
                    toSet.SetValue(drAF["PersonalUseAmount"].ToString());

                    //pdfFormFields.SetField("Air Fare Notes" + flightRow, drAF["Notes"].ToString()); //commented for net6
                    fields.TryGetValue("Air Fare Notes" + flightRow, out toSet);
                    toSet.SetValue(drAF["Notes"].ToString());

                    flightRow++;
                }
                drAF.Close();
                string flightCost = totalAF.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                //pdfFormFields.SetField("CostAir Fare", flightCost); //commented for net6
                fields.TryGetValue("CostAir Fare", out toSet);
                toSet.SetValue(flightCost);

                //pdfFormFields.SetField("NotesAir Fare", notesAF); //commented for net6
                fields.TryGetValue("NotesAir Fare", out toSet);
                toSet.SetValue(notesAF);

                //pdfFormFields.SetField("Air Fare Total", flightCost); //commented for net6
                fields.TryGetValue("Air Fare Total", out toSet);
                toSet.SetValue(flightCost);
            }

            //Mileage Details
            if (CommonVariables.isMileage)
            {
                SqlCommand cmdMi = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drMi = cmdMi.ExecuteReader();

                while (drMi.Read())
                {
                    double milCostValue = Convert.ToDouble(drMi["TotalMileage"].ToString());
                    string milcost = milCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                    //pdfFormFields.SetField("CostMileage", milcost); //commented for net6
                    fields.TryGetValue("CostMileage", out toSet);
                    toSet.SetValue(milcost);

                    //pdfFormFields.SetField("NotesMileage", drMi["Notes"].ToString()); //commented for net6
                    fields.TryGetValue("NotesMileage", out toSet);
                    toSet.SetValue(drMi["Notes"].ToString());

                    //details

                    //pdfFormFields.SetField("Map Mileage", drMi["MapMileage"].ToString()); //commented for net6
                    fields.TryGetValue("Map Mileage", out toSet);
                    toSet.SetValue(drMi["MapMileage"].ToString());

                    //pdfFormFields.SetField("Vicinity Mileage", drMi["VicinityMileage"].ToString()); //commented for net6
                    fields.TryGetValue("Vicinity Mileage", out toSet);
                    toSet.SetValue(drMi["VicinityMileage"].ToString());

                    string milCost = Convert.ToDouble(drMi["TotalMileage"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);

                    //pdfFormFields.SetField("Mileage Cost", milCost); //commented for net6
                    fields.TryGetValue("Mileage Cost", out toSet);
                    toSet.SetValue(milCost);

                    if (drMi["DistrictVehicleProvided"].ToString() == "True")
                    {
                        //pdfFormFields.SetField("Provided Vehicle", "Yes"); //commented for net6
                        fields.TryGetValue("Provided Vehicle", out toSet);
                        toSet.SetValue("Yes");
                    }
                    else
                    {
                        //pdfFormFields.SetField("Provided Vehicle", "No"); //commented for net6
                        fields.TryGetValue("Provided Vehicle", out toSet);
                        toSet.SetValue("No");

                        if (drMi["DirectorApprovedPersonal"].ToString() == "True")
                        {
                            //pdfFormFields.SetField("Mileage Director Approval", "Yes"); //commented for net6
                            fields.TryGetValue("Mileage Director Approval", out toSet);
                            toSet.SetValue("Yes");

                            //setting the value for the mileage reimbursement
                            mileagReimbursement = Convert.ToDouble(drMi["TotalMileage"].ToString());
                        }
                        else
                        {
                            //pdfFormFields.SetField("Mileage Director Approval", "No"); //commented for net6
                            fields.TryGetValue("Mileage Director Approval", out toSet);
                            toSet.SetValue("No");
                        }
                    }
                    //pdfFormFields.SetField("Mileage Notes", drMi["Notes"].ToString()); //commented for net6
                    fields.TryGetValue("Mileage Notes", out toSet);
                    toSet.SetValue(drMi["Notes"].ToString());
                }
                drMi.Close();
            }

            //Other Expenses
            if (CommonVariables.isOtherExpenses)
            {
                SqlCommand cmdOE = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drOE = cmdOE.ExecuteReader();

                double totalOE = 0;
                string notesOE = "";
                int oxRow = 1;
                while (drOE.Read())
                {
                    totalOE = totalOE + Convert.ToDouble(drOE["Amount"].ToString());
                    if (drOE["Notes"].ToString() != "")
                    {
                        notesOE += drOE["Notes"].ToString() + " .";
                    }

                    //details

                    //pdfFormFields.SetField("ExpDescription" + oxRow, drOE["Description"].ToString()); //commented for net6
                    fields.TryGetValue("ExpDescription" + oxRow, out toSet);
                    toSet.SetValue(drOE["Description"].ToString());

                    //pdfFormFields.SetField("ExpCost" + oxRow, drOE["Amount"].ToString());//commented for net6
                    fields.TryGetValue("ExpCost" + oxRow, out toSet);
                    toSet.SetValue(drOE["Amount"].ToString());

                    //totalOE = totalOE + Convert.ToDouble(drOE["Amount"].ToString());
                    //pdfFormFields.SetField("ExpNotes" + oxRow, drOE["Notes"].ToString()); //commented for net6
                    fields.TryGetValue("ExpNotes" + oxRow, out toSet);
                    toSet.SetValue(drOE["Notes"].ToString());

                    if (drOE["Prepaid"].ToString() == "True")
                    {
                        //pdfFormFields.SetField("ExpCard" + oxRow, "Yes"); //commented for net6
                        fields.TryGetValue("ExpCard" + oxRow, out toSet);
                        toSet.SetValue("Yes");
                    }
                    else
                    {
                        //pdfFormFields.SetField("ExpCard" + oxRow, "No"); //commented for net6
                        fields.TryGetValue("ExpCard" + oxRow, out toSet);
                        toSet.SetValue("No");

                        //setting the value for the other expenses reimbursement
                        otherExpenseReimbursement += Convert.ToDouble(drOE["Amount"].ToString());
                    }

                    oxRow++;
                }
                drOE.Close();
                string oeCost = totalOE.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                //pdfFormFields.SetField("CostOther Expenses", oeCost); //commented for net6
                fields.TryGetValue("CostOther Expenses", out toSet);
                toSet.SetValue(oeCost);

                //pdfFormFields.SetField("NotesOther Expenses", notesOE); //commented for net6
                fields.TryGetValue("NotesOther Expenses", out toSet);
                toSet.SetValue(notesOE);

                //pdfFormFields.SetField("Other Expenses Total", oeCost); //commented for net6
                fields.TryGetValue("Other Expenses Total", out toSet);
                toSet.SetValue(oeCost);
            }

            //Accounting accounts
            string travACC = travelACC.ToString("C", CultureInfo.CurrentCulture);

            //pdfFormFields.SetField("Travel4000", travACC); //commented for net6
            fields.TryGetValue("Travel4000", out toSet);
            toSet.SetValue(travACC);

            string trainACC = trainingACC.ToString("C", CultureInfo.CurrentCulture);

            //pdfFormFields.SetField("Training5500", trainACC); //commented for net6
            fields.TryGetValue("Training5500", out toSet);
            toSet.SetValue(trainACC);

            //Reimbursement Table

            //pdfFormFields.SetField("Meals_Reimbursement", mealsReimbursement.ToString()); //commented for net6
            fields.TryGetValue("Meals_Reimbursement", out toSet);
            toSet.SetValue(mealsReimbursement.ToString());

            //pdfFormFields.SetField("Registration_Reimbursement", registratiorReimbursement.ToString()); //commented for net6
            fields.TryGetValue("Registration_Reimbursement", out toSet);
            toSet.SetValue(registratiorReimbursement.ToString());

            //pdfFormFields.SetField("Lodgings_Reimbursement", lodgingReimbursement.ToString()); //commented for net6
            fields.TryGetValue("Lodgings_Reimbursement", out toSet);
            toSet.SetValue(lodgingReimbursement.ToString());

            //pdfFormFields.SetField("CarRental_Reimbursement", carRentalReimbursement.ToString()); //commented for net6
            fields.TryGetValue("CarRental_Reimbursement", out toSet);
            toSet.SetValue(carRentalReimbursement.ToString());

            //pdfFormFields.SetField("Airfare_Reimbursement", airfareReimbursement.ToString()); //commented for net6
            fields.TryGetValue("Airfare_Reimbursement", out toSet);
            toSet.SetValue(airfareReimbursement.ToString());

            //pdfFormFields.SetField("Mileage_Reimbursement", mileagReimbursement.ToString()); //commented for net6
            fields.TryGetValue("Mileage_Reimbursement", out toSet);
            toSet.SetValue(mileagReimbursement.ToString());

            //pdfFormFields.SetField("OtherExpenses_Reimbursement", otherExpenseReimbursement.ToString()); //commented for net6
            fields.TryGetValue("OtherExpenses_Reimbursement", out toSet);
            toSet.SetValue(otherExpenseReimbursement.ToString());

            //Signatures
            SqlCommand cmdPDF = new SqlCommand("SELECT a.TravelID,a.UserID,a.UserType,a.TravelType,a.SignatureDate,b.FontType,b.SignatureText FROM [TravelExpenses].[dbo].[TravelSignatures] as a inner join TravelExpenses.dbo.UserSignature as b on b.UserID = a.UserID where a.TravelID = '" + travID + "'  AND a.TravelType = 'Travel'", localCon);
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
                    if (drPDF["UserType"].ToString() == "Accounting")
                    {
                        //pdfFormFields.SetFieldProperty("Finance Review Siganature", "textfont", bf, null); //commented for net6
                        //pdfFormFields.SetField("Finance Review Siganature", drPDF["SignatureText"].ToString()); //commented for net6
                        fields.TryGetValue("Finance Review Siganature", out toSet);
                        toSet.SetFont(font);
                        toSet.SetValue(drPDF["SignatureText"].ToString());

                        //pdfFormFields.SetField("Finance Review", sigDate.ToShortDateString()); //commented for net6
                        fields.TryGetValue("Finance Review", out toSet);
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

                }
            }
            drPDF.Close();
            form.FlattenFields();
            pdfDoc.Close();
            //pdfStamper.Close();
            localCon.Close();


        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (dgvArchivedTravels.RowCount > 0)
            {
                generatePDF();
                ViewPDF vpdf = new ViewPDF();
                vpdf.Show();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshTravels()
        {
            localCon.Open();
            dgvArchivedTravels.Rows.Clear();
            if (cbEmployee.SelectedValue.ToString() == "-1")
            {
                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status, a.UserID as UserID,c.Name as Name,c.LastName as Lastname FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join [TravelExpenses].[dbo].[User] as c on a.UserID = c.UserID where b.Status = 'Final' order by a.DepartureDate desc", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string travelID = dr["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();
                    string origin = dr["Origin"].ToString();
                    string destination = dr["Destination"].ToString();
                    string travTotal = dr["TotalTravelAmount"].ToString();
                    string status = dr["Status"].ToString();
                    string userID = dr["UserID"].ToString();
                    string username = dr["Name"].ToString() + " " + dr["Lastname"].ToString();
                    dgvArchivedTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination, travTotal, travelID, userID, username);
                }
                dr.Close();
            }
            else
            {
                string idUser = cbEmployee.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status,a.UserID as UserID,c.Name as Name,c.LastName as Lastname FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join [TravelExpenses].[dbo].[User] as c on a.UserID = c.UserID where a.UserID = '" + idUser + "' AND b.Status = 'Final' order by a.DepartureDate desc", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string travelID = dr["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();
                    string origin = dr["Origin"].ToString();
                    string destination = dr["Destination"].ToString();
                    string travTotal = dr["TotalTravelAmount"].ToString();
                    string status = dr["Status"].ToString();
                    string userID = dr["UserID"].ToString();
                    string username = dr["Name"].ToString() + " " + dr["Lastname"].ToString();
                    dgvArchivedTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination, travTotal, travelID, userID, username);
                }
                dr.Close();
            }

            for (int i = 0; i < dgvArchivedTravels.RowCount; i++)
            {
                Guid travID = new Guid(dgvArchivedTravels.Rows[i].Cells[8].Value.ToString());
                Guid accUser = new Guid(CommonVariables.user);
                SqlCommand signAcc = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' And UserType = 'Accounting' AND TravelID = '" + travID + "' AND UserID = '" + accUser + "'", localCon);
                SqlDataReader signAccDR = signAcc.ExecuteReader();
                if (signAccDR.HasRows)
                {
                    dgvArchivedTravels.Rows[i].Cells[11].Value = "Yes";
                }
                else
                {
                    dgvArchivedTravels.Rows[i].Cells[11].Value = "No";
                }
                signAccDR.Close();
            }
            localCon.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            refreshTravels();
        }
    }
}
