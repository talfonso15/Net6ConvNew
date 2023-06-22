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
//using iTextSharp; //commented for net6
//using iTextSharp.text; //commented for net6
//using iTextSharp.text.pdf; //commented for net6
//using iTextSharp.text.xml; //commented for net6
using System.IO;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using iText.Kernel.Pdf;
using iText.Kernel.XMP;
using iText.Kernel;
using iText.Forms;
using iText.Forms.Fields;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using Microsoft.Office.Interop.Word;
using System.Speech.Recognition;

namespace TravelExpenses
{
    public partial class AdminAuthorization : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string winUser = Environment.UserName;
        string department = "";
        string userType = "";
        string userTitle = "";
        string asstDirectorID = "";
        string query = "";
        string authQuery = "";
        string aprovQuery = "";
        bool hideApproved = false;
        public AdminAuthorization()
        {
            InitializeComponent();
        }

        private void AdminAuthorization_Load(object sender, EventArgs e)
        {
            localCon.Open();

            if (CommonVariables.isSupervisor)
            {
                /*SqlCommand userDep = new SqlCommand("SELECT [Department] FROM [TravelExpenses].[dbo].[User] where UserID = '" + CommonVariables.user + "'", localCon);
                SqlDataReader userDepdr = userDep.ExecuteReader();
                while (userDepdr.Read())
                {
                    department = userDepdr["Department"].ToString();
                }
                userDepdr.Close();*/
                this.Text = "Supervisor Authorizations";
                dgvAthorizations.Columns[12].Visible = true;
                toolTip1.SetToolTip(btnApprEstimateDirector, "Supervisor Approval");
                btnHideApproved.Visible = true;
                label4.Visible = true;

                //checking if the user is the director

                SqlCommand titlecmd = new SqlCommand("SELECT [Title] FROM [TravelExpenses].[dbo].[User_Email_Title] where UserID = '" + CommonVariables.user + "'", localCon);
                SqlDataReader titlecmdDR = titlecmd.ExecuteReader();
                if (titlecmdDR.HasRows)
                {
                    while (titlecmdDR.Read())
                    {
                        userTitle = titlecmdDR["Title"].ToString();
                    }
                }
                titlecmdDR.Close();

                if (userTitle == "Executive Director")
                {
                    SqlCommand assDirID = new SqlCommand("SELECT [UserID] FROM [TravelExpenses].[dbo].[User_Email_Title] where Title = 'Assistant Director'", localCon);
                    SqlDataReader assDirIDDR = assDirID.ExecuteReader();
                    if (assDirIDDR.HasRows)
                    {
                        while (assDirIDDR.Read())
                        {
                            asstDirectorID = assDirIDDR["UserID"].ToString();
                        }
                    }
                    assDirIDDR.Close();
                    query = "SELECT concat(b.LastName,' ,', Name) as Name, a.UserID as UserID FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User] as b on a.UserID = b.UserID inner join [TravelExpenses].[dbo].[User_Email_Title] as c on b.UserID = c.UserID where (SupervisorID = '" + CommonVariables.user + "' or SupervisorID = '" + asstDirectorID + "') AND c.Active = '1' order by Name asc";
                    authQuery = "Select b.TravelEstimateID,a.UserID,b.DepartureDate,b.ReturnDate,b.TravelEvent,b.TravelPurpose,b.BudgetedTravel,b.EstimatedTravelCost,b.MileagePersonal,(c.Name + '' + c.LastName) as Name,c.District, c.Department from TravelExpenses.dbo.Supervisor_Employee as a inner join TravelExpenses.dbo.EstimateTravel as b on a.UserID = b.UserID inner join TravelExpenses.dbo.[User] as c on a.UserID = c.UserID where a.SupervisorID = '" + CommonVariables.user + "' or a.SupervisorID = '" + asstDirectorID + "' order by b.DepartureDate desc";
                }
                else
                {
                    query = "SELECT concat(b.LastName,' ,', Name) as Name, a.UserID as UserID FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User] as b on a.UserID = b.UserID inner join [TravelExpenses].[dbo].[User_Email_Title] as c on b.UserID = c.UserID where SupervisorID = '" + CommonVariables.user + "' AND c.Active = '1' order by Name asc";
                    authQuery = "Select b.TravelEstimateID,a.UserID,b.DepartureDate,b.ReturnDate,b.TravelEvent,b.TravelPurpose,b.BudgetedTravel,b.EstimatedTravelCost,b.MileagePersonal,(c.Name + '' + c.LastName) as Name,c.District, c.Department from TravelExpenses.dbo.Supervisor_Employee as a inner join TravelExpenses.dbo.EstimateTravel as b on a.UserID = b.UserID inner join TravelExpenses.dbo.[User] as c on a.UserID = c.UserID where a.SupervisorID = '" + CommonVariables.user + "' order by b.DepartureDate desc";
                }


                SqlCommand empl = new SqlCommand(query, localCon);
                SqlDataReader emplDR = empl.ExecuteReader();
                cbEmployee.DisplayMember = "Text";
                cbEmployee.ValueMember = "Value";
                List<Object> items = new List<object>();
                while (emplDR.Read())
                {
                    string name = emplDR["Name"].ToString();
                    string id = emplDR["UserID"].ToString();
                    items.Add(new { Text = name, Value = id });
                }

                items.Add(new { Text = "All", Value = "-1" });
                cbEmployee.DataSource = items;
                cbEmployee.SelectedValue = "-1";
                emplDR.Close();




                SqlCommand cmd = new SqlCommand(authQuery, localCon);
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

                for (int i = 0; i < dgvAthorizations.RowCount; i++)
                {
                    Guid idTrav = new Guid(dgvAthorizations.Rows[i].Cells[7].Value.ToString());
                    SqlCommand approval = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where UserType = 'Supervisor' AND TravelID = '" + idTrav + "'", localCon);
                    SqlDataReader approvalDR = approval.ExecuteReader();
                    if (approvalDR.HasRows)
                    {
                        dgvAthorizations.Rows[i].Cells[12].Value = "Yes";
                    }
                    else
                    {
                        dgvAthorizations.Rows[i].Cells[12].Value = "No";
                    }
                    approvalDR.Close();
                }
            }
            else
            {


                SqlCommand cmd = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status = 'Sent for Director Approval'", localCon);
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

                SqlCommand em = new SqlCommand("SELECT a.UserID,a.Name,a.LastName FROM [TravelExpenses].[dbo].[User] as a inner join [TravelExpenses].[dbo].[User_Email_Title] as b on a.UserID = b.UserID where b.Active = '1' order by LastName", localCon);
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            dgvAthorizations.Rows.Clear();
            localCon.Open();
            if (cbEmployee.SelectedValue.ToString() == "-1")
            {
                if (CommonVariables.isSupervisor)
                {
                    if (userTitle == "Executive Director")
                    {
                        query = "Select b.TravelEstimateID, a.UserID, b.DepartureDate, b.ReturnDate, b.TravelEvent, b.TravelPurpose, b.BudgetedTravel, b.EstimatedTravelCost, b.MileagePersonal, (c.Name + '' + c.LastName) as Name, c.District, c.Department from TravelExpenses.dbo.Supervisor_Employee as a inner join TravelExpenses.dbo.EstimateTravel as b on a.UserID = b.UserID inner join TravelExpenses.dbo.[User] as c on a.UserID = c.UserID where a.SupervisorID = '" + CommonVariables.user + "' or a.SupervisorID = '" + asstDirectorID + "'  order by b.DepartureDate desc";
                    }
                    else
                    {
                        query = "Select b.TravelEstimateID, a.UserID, b.DepartureDate, b.ReturnDate, b.TravelEvent, b.TravelPurpose, b.BudgetedTravel, b.EstimatedTravelCost, b.MileagePersonal, (c.Name + '' + c.LastName) as Name, c.District, c.Department from TravelExpenses.dbo.Supervisor_Employee as a inner join TravelExpenses.dbo.EstimateTravel as b on a.UserID = b.UserID inner join TravelExpenses.dbo.[User] as c on a.UserID = c.UserID where a.SupervisorID = '" + CommonVariables.user + "' order by b.DepartureDate desc";
                    }

                    SqlCommand cmd = new SqlCommand(query, localCon);
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

                    for (int i = 0; i < dgvAthorizations.RowCount; i++)
                    {
                        Guid idTrav = new Guid(dgvAthorizations.Rows[i].Cells[7].Value.ToString());
                        SqlCommand approval = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where UserType = 'Supervisor' AND TravelID = '" + idTrav + "'", localCon);
                        SqlDataReader approvalDR = approval.ExecuteReader();
                        if (approvalDR.HasRows)
                        {
                            dgvAthorizations.Rows[i].Cells[12].Value = "Yes";
                        }
                        else
                        {
                            dgvAthorizations.Rows[i].Cells[12].Value = "No";
                        }
                        approvalDR.Close();
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status = 'Sent for Director Approval'", localCon);
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
                if (CommonVariables.isSupervisor)
                {

                    if (userTitle == "Executive Director")
                    {
                        query = "Select b.TravelEstimateID, a.UserID, b.DepartureDate, b.ReturnDate, b.TravelEvent, b.TravelPurpose, b.BudgetedTravel, b.EstimatedTravelCost, b.MileagePersonal, (c.Name + '' + c.LastName) as Name, c.District, c.Department from TravelExpenses.dbo.Supervisor_Employee as a inner join TravelExpenses.dbo.EstimateTravel as b on a.UserID = b.UserID inner join TravelExpenses.dbo.[User] as c on a.UserID = c.UserID where (a.SupervisorID = '" + CommonVariables.user + "' or a.SupervisorID = '" + asstDirectorID + "') AND c.UserID = '" + cbEmployee.SelectedValue.ToString() + "' order by b.DepartureDate desc";
                    }
                    else
                    {
                        query = "Select b.TravelEstimateID, a.UserID, b.DepartureDate, b.ReturnDate, b.TravelEvent, b.TravelPurpose, b.BudgetedTravel, b.EstimatedTravelCost, b.MileagePersonal, (c.Name + '' + c.LastName) as Name, c.District, c.Department from TravelExpenses.dbo.Supervisor_Employee as a inner join TravelExpenses.dbo.EstimateTravel as b on a.UserID = b.UserID inner join TravelExpenses.dbo.[User] as c on a.UserID = c.UserID where a.SupervisorID = '" + CommonVariables.user + "' AND c.UserID = '" + cbEmployee.SelectedValue.ToString() + "' order by b.DepartureDate desc";
                    }

                    SqlCommand cmd = new SqlCommand(query, localCon);
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

                    for (int i = 0; i < dgvAthorizations.RowCount; i++)
                    {
                        Guid idTrav = new Guid(dgvAthorizations.Rows[i].Cells[7].Value.ToString());
                        SqlCommand approval = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where UserType = 'Supervisor' AND TravelID = '" + idTrav + "'", localCon);
                        SqlDataReader approvalDR = approval.ExecuteReader();
                        if (approvalDR.HasRows)
                        {
                            dgvAthorizations.Rows[i].Cells[12].Value = "Yes";
                        }
                        else
                        {
                            dgvAthorizations.Rows[i].Cells[12].Value = "No";
                        }
                        approvalDR.Close();
                    }
                }
                else
                {
                    string idvalue = cbEmployee.SelectedValue.ToString();
                    SqlCommand cmd = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID Where  a.UserID = '" + idvalue + "' AND  c.Status = 'Sent for Director Approval'", localCon);
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

                /* PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
                AcroFields pdfFormFields = pdfStamper.AcroFields;*/

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

                    //string[] chxvalues = fields.GetAppearanceStates("Travel_Budgeted_No"); //commented for net6
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
                            PdfFont font = PdfFontFactory.CreateFont();// new code for net6

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

                                //pdfFormFields.SetField("CFO Date", sigDate.ToShortDateString());
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

        private void btnApprEstimateDirector_Click(object sender, EventArgs e)
        {
            if (dgvAthorizations.RowCount > 0)
            {
                localCon.Open();

                int rowIndex = dgvAthorizations.CurrentRow.Index;
                string travID = dgvAthorizations.Rows[rowIndex].Cells[7].Value.ToString();
                Guid travIDValue = new Guid(travID);
                //string userID = dgvAthorizations.Rows[rowIndex].Cells[8].Value.ToString();
                Guid userIDValue = new Guid(CommonVariables.user);
                bool isApproved = false;
                userType = "";


                if (CommonVariables.isSupervisor)
                {
                    userType = "Supervisor";
                    SqlCommand cmd = new SqlCommand("SELECT [TravelID],[UserID],[UserType],[TravelType] FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelID = '" + travID + "'  AND UserType = 'Supervisor' AND TravelType = 'Estimate'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        isApproved = true;
                        MessageBox.Show("This travel was already approved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dr.Close();

                    if (!isApproved)
                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[TravelSignatures] ([TravelID],[UserID],[UserType],[TravelType],[SignatureDate]) VALUES (@TravelID,@UserID,@UserType,@TravelType,@SignatureDate)", localCon);
                        da.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travIDValue;
                        da.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userIDValue;
                        da.InsertCommand.Parameters.Add("@UserType", SqlDbType.VarChar).Value = "Supervisor";
                        da.InsertCommand.Parameters.Add("@TravelType", SqlDbType.VarChar).Value = "Estimate";
                        da.InsertCommand.Parameters.Add("@SignatureDate", SqlDbType.DateTime).Value = DateTime.Today;
                        int row = da.InsertCommand.ExecuteNonQuery();

                        if (row > 0)
                        {
                            //updating authorization status
                            SqlDataAdapter es = new SqlDataAdapter();
                            es.UpdateCommand = new SqlCommand("UPDATE [dbo].[EstimateTravel_Status] SET [Status] = @Status WHERE TravelEstimateID = '" + travIDValue + "'", localCon);
                            es.UpdateCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Pending CFO";
                            int status = es.UpdateCommand.ExecuteNonQuery();

                            if (status > 0)
                            {

                                //adding to the history trace table
                                Guid loginUser = new Guid(CommonVariables.user);
                                SqlDataAdapter tadpt = new SqlDataAdapter();
                                tadpt.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User_History_Trace] ([UserID],[Action],[Date]) VALUES (@UserID ,@Action,@Date)", localCon);
                                tadpt.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = loginUser;
                                tadpt.InsertCommand.Parameters.Add("@Action", SqlDbType.NVarChar).Value = "Authorization Form Approved by Supervisor";
                                tadpt.InsertCommand.Parameters.Add("@Date", SqlDbType.NVarChar).Value = DateTime.Now;
                                tadpt.InsertCommand.ExecuteNonQuery();

                                MessageBox.Show("This travel authorization has been successfully approved by the Supervisor", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }


                }
                else
                {
                    userType = "Director";
                    SqlCommand cmd = new SqlCommand("SELECT [TravelID],[UserID],[UserType],[TravelType] FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelID = '" + travID + "'  AND UserType = 'Director' AND TravelType = 'Estimate'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        isApproved = true;
                        MessageBox.Show("This travel was already approved");
                    }
                    dr.Close();

                    if (!isApproved)
                    {
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[TravelSignatures] ([TravelID],[UserID],[UserType],[TravelType],[SignatureDate]) VALUES (@TravelID,@UserID,@UserType,@TravelType,@SignatureDate)", localCon);
                        da.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travIDValue;
                        da.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userIDValue;
                        da.InsertCommand.Parameters.Add("@UserType", SqlDbType.VarChar).Value = "Director";
                        da.InsertCommand.Parameters.Add("@TravelType", SqlDbType.VarChar).Value = "Estimate";
                        da.InsertCommand.Parameters.Add("@SignatureDate", SqlDbType.DateTime).Value = DateTime.Today;
                        int row = da.InsertCommand.ExecuteNonQuery();

                        SqlDataAdapter datwo = new SqlDataAdapter();
                        datwo.UpdateCommand = new SqlCommand("UPDATE [dbo].[EstimateTravel_Status] SET [Status] = @Status WHERE TravelEstimateID = '" + travIDValue + "'", localCon);
                        datwo.UpdateCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "Final";
                        int row1 = datwo.UpdateCommand.ExecuteNonQuery();

                        if (row > 0 && row1 > 0)
                        {
                            //adding to the history trace table
                            Guid loginUser = new Guid(CommonVariables.user);
                            SqlDataAdapter tadpt = new SqlDataAdapter();
                            tadpt.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User_History_Trace] ([UserID],[Action],[Date]) VALUES (@UserID ,@Action,@Date)", localCon);
                            tadpt.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = loginUser;
                            tadpt.InsertCommand.Parameters.Add("@Action", SqlDbType.NVarChar).Value = "Authorization Form Approved by Director";
                            tadpt.InsertCommand.Parameters.Add("@Date", SqlDbType.NVarChar).Value = DateTime.Now;
                            tadpt.InsertCommand.ExecuteNonQuery();

                            MessageBox.Show("This travel authorization has been successfully approved by the director", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                localCon.Close();
                if (!isApproved)
                {
                    pictureBox1.Visible = true;
                    lblInfo.Visible = true;
                    tableLayoutPanel2.Enabled = false;
                    tableLayoutPanel3.Enabled = false;
                    dgvAthorizations.Enabled = false;
                    if (backgroundWorker1.IsBusy != true)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }

                }
            }
        }

        private void AdminAuthorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommonVariables.isSupervisor = false;
        }

        private void sendNotification(string userType)
        {
            localCon.Open();
            int rowIndex = dgvAthorizations.CurrentRow.Index;
            Guid userID = new Guid(dgvAthorizations.Rows[rowIndex].Cells[8].Value.ToString());
            DateTime depDate = Convert.ToDateTime(dgvAthorizations.Rows[rowIndex].Cells[0].Value.ToString());
            DateTime retDate = Convert.ToDateTime(dgvAthorizations.Rows[rowIndex].Cells[1].Value.ToString());
            string travEvent = dgvAthorizations.Rows[rowIndex].Cells[2].Value.ToString();
            string email = "";
            string username = "";

            //user
            SqlCommand user = new SqlCommand("SELECT  a.Email as Email, b.Name as Name, b.LastName as Lastname FROM [TravelExpenses].[dbo].[User_Email_Title] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID where a.UserID  = '" + userID + "'", localCon);
            SqlDataReader userDR = user.ExecuteReader();
            while (userDR.Read())
            {
                email = userDR["Email"].ToString();
                username = userDR["Name"].ToString() + " " + userDR["Lastname"].ToString();
            }
            userDR.Close();

            SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org", 587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
            SmtpServer.EnableSsl = true;

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();// change it for net6

            mail.From = new MailAddress("travelAlert@lcmcd.org");
            mail.To.Add(email);
            mail.Subject = "Your travel authorization was approved by " + userType;

            System.Net.Mail.MailMessage mailCFO = new System.Net.Mail.MailMessage();// change it for net6
            //CFO email
            if (userType == "Supervisor")
            {
                string cfoEmail = "";
                SqlCommand searchCFO = new SqlCommand("SELECT [Email] FROM [dbo].[User_Email_Title] where Title = 'CFO'", localCon);
                SqlDataReader searchCFODR = searchCFO.ExecuteReader();
                if (searchCFODR.HasRows)
                {
                    while (searchCFODR.Read())
                    {
                        cfoEmail = searchCFODR["Email"].ToString();
                    }
                }
                searchCFODR.Close();


                mailCFO.From = new MailAddress("travelAlert@lcmcd.org");
                mailCFO.To.Add(cfoEmail);
                mailCFO.Subject = "Travel Authorization Form Review";
                if (depDate.ToShortDateString() == retDate.ToShortDateString())
                {
                    mailCFO.Body = "The travel authorization form of " + username + " for the " + travEvent + " event on " + depDate.ToShortDateString() + " , has been approved by his supervisor, please review it, Thanks";
                }
                else
                {
                    mailCFO.Body = "The travel authorization form of " + username + " for the " + travEvent + " event from " + depDate.ToShortDateString() + " to " + retDate.ToShortDateString() + ", has been approved by his supervisor, please review it, Thanks";
                }
            }

            //Accounting Email
            System.Net.Mail.MailMessage mailAcc = new System.Net.Mail.MailMessage();
            if (userType == "Director")
            {
                /* mailAcc.From = new MailAddress("travelAlert@lcmcd.org");
                 mailAcc.To.Add("collins@lcmcd.org");
                 mailAcc.Subject = "Travel authorization form of " + username + " is completed.";
                 if (depDate.ToShortDateString() == retDate.ToShortDateString())
                 {
                     mailAcc.Body = "The travel authorization form of " + username + " for the " + travEvent + " event on " + depDate.ToShortDateString() + ", has been completed and approved by the Director.";
                 }
                 else
                 {
                     mailAcc.Body = "The travel authorization form of " + username + " for the " + travEvent + " event, from " + depDate.ToShortDateString() + " to " + retDate.ToShortDateString() + ", has been completed and approved by the Director.";
                 }*/

            }

            if (depDate.ToShortDateString() == retDate.ToShortDateString())
            {
                mail.Body = "Your travel authorization for the " + depDate.ToShortDateString() + " in order to " + "attend to " + travEvent + ", was approved by " + userType;

            }
            else
            {
                mail.Body = "Your travel authorization for the " + depDate.ToShortDateString() + " to " + retDate.ToShortDateString() + " in order to attend to " + travEvent + " event" + ", was approved by " + userType;
            }

            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            try
            {
                SmtpServer.Send(mail);
                if (userType == "Supervisor")
                {
                    SmtpServer.Send(mailCFO);
                }
                if (userType == "Director")
                {
                    //SmtpServer.Send(mailAcc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            localCon.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            CommonVariables.isSupervisor = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            sendNotification(userType);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            lblInfo.Visible = false;
            tableLayoutPanel2.Enabled = true;
            tableLayoutPanel3.Enabled = true;
            dgvAthorizations.Enabled = true;
            refreshData();
        }

        private void refreshData()
        {
            localCon.Open();
            dgvAthorizations.Rows.Clear();
            if (CommonVariables.isSupervisor)
            {

                this.Text = "Supervisor Authorizations";
                toolTip1.SetToolTip(btnApprEstimateDirector, "Supervisor Approval");

                /* SqlCommand empl = new SqlCommand("SELECT b.Name as name , b.LastName as lastname, a.UserID as UserID FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User] as b on a.UserID = b.UserID where SupervisorID = '" + CommonVariables.user + "'", localCon);
                 SqlDataReader emplDR = empl.ExecuteReader();
                 cbEmployee.DisplayMember = "Text";
                 cbEmployee.ValueMember = "Value";
                 List<Object> items = new List<object>();
                 while (emplDR.Read())
                 {
                     string name = emplDR["lastname"].ToString() + "," + emplDR["name"].ToString();
                     string id = emplDR["UserID"].ToString();
                     items.Add(new { Text = name, Value = id });
                 }

                 items.Add(new { Text = "All", Value = "-1" });
                 cbEmployee.DataSource = items;
                 cbEmployee.SelectedValue = "-1";
                 emplDR.Close();*/

                if (userTitle == "Executive Director")
                {
                    query = "Select b.TravelEstimateID,a.UserID,b.DepartureDate,b.ReturnDate,b.TravelEvent,b.TravelPurpose,b.BudgetedTravel,b.EstimatedTravelCost,b.MileagePersonal,(c.Name + '' + c.LastName) as Name,c.District, c.Department from TravelExpenses.dbo.Supervisor_Employee as a inner join TravelExpenses.dbo.EstimateTravel as b on a.UserID = b.UserID inner join TravelExpenses.dbo.[User] as c on a.UserID = c.UserID where a.SupervisorID = '" + CommonVariables.user + "' or a.SupervisorID = '" + asstDirectorID + "' order by b.DepartureDate desc";
                }
                else
                {
                    query = "Select b.TravelEstimateID,a.UserID,b.DepartureDate,b.ReturnDate,b.TravelEvent,b.TravelPurpose,b.BudgetedTravel,b.EstimatedTravelCost,b.MileagePersonal,(c.Name + '' + c.LastName) as Name,c.District, c.Department from TravelExpenses.dbo.Supervisor_Employee as a inner join TravelExpenses.dbo.EstimateTravel as b on a.UserID = b.UserID inner join TravelExpenses.dbo.[User] as c on a.UserID = c.UserID where a.SupervisorID = '" + CommonVariables.user + "' order by b.DepartureDate desc";
                }


                SqlCommand cmd = new SqlCommand(query, localCon);
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

                for (int i = 0; i < dgvAthorizations.RowCount; i++)
                {
                    Guid idTrav = new Guid(dgvAthorizations.Rows[i].Cells[7].Value.ToString());
                    SqlCommand approval = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where UserType = 'Supervisor' AND TravelID = '" + idTrav + "'", localCon);
                    SqlDataReader approvalDR = approval.ExecuteReader();
                    if (approvalDR.HasRows)
                    {
                        dgvAthorizations.Rows[i].Cells[12].Value = "Yes";
                    }
                    else
                    {
                        dgvAthorizations.Rows[i].Cells[12].Value = "No";
                    }
                    approvalDR.Close();
                }
            }
            else
            {


                SqlCommand cmd = new SqlCommand("SELECT  a.TravelEstimateID,a.UserID,a.DepartureDate,a.ReturnDate,a.TravelEvent,a.TravelPurpose,a.BudgetedTravel,a.EstimatedTravelCost,a.MileagePersonal,(b.Name + ' ' + b.LastName) as Name,b.District,b.Department FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID inner join TravelExpenses.dbo.EstimateTravel_Status as c on c.TravelEstimateID = a.TravelEstimateID where c.Status = 'Sent for Director Approval'", localCon);
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

                SqlCommand em = new SqlCommand("SELECT [UserID],[Name],[LastName] FROM [TravelExpenses].[dbo].[User]", localCon);
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

        private void btnHideApproved_Click(object sender, EventArgs e)
        {
            if (hideApproved)
            {
                for (int i = 0; i < dgvAthorizations.RowCount; i++)
                {
                    if (dgvAthorizations.Rows[i].Cells[12].Value.ToString() == "Yes")
                    {
                        dgvAthorizations.Rows[i].Visible = true;
                    }
                }
                hideApproved = false;
            }
            else
            {
                for (int i = 0; i < dgvAthorizations.RowCount; i++)
                {
                    if (dgvAthorizations.Rows[i].Cells[12].Value.ToString() == "Yes")
                    {
                        dgvAthorizations.Rows[i].Visible = false;
                    }
                }
                hideApproved = true;
            }
        }
    }
}
