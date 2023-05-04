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
using System.Globalization;

namespace TravelExpenses
{
    public partial class SuperAdminTravels : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string winUser = Environment.UserName;
        double travelACC = 0;
        double trainingACC = 0;
        int index = 0;
        string username = "";
        public SuperAdminTravels()
        {
            InitializeComponent();
        }

        private void SuperAdminTravels_Load(object sender, EventArgs e)
        {
            localCon.Open();

            cbtravels.SelectedItem = "All";
            
            pnCriteria.Size = new System.Drawing.Size(631, 42);

            //string username = "";
            Guid logUser = new Guid(CommonVariables.user);
            SqlCommand userInfo = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] where UserID = '"+ logUser + "'", localCon);
            SqlDataReader userInfoDR = userInfo.ExecuteReader();
            while (userInfoDR.Read())
            {
                username = userInfoDR["Username"].ToString();
            }
            userInfoDR.Close();

            if (username == "TPineda")
            {
                btnDelete.Visible = true;
                label1.Visible = true;
                btnChangeStatus.Visible = true;
                label4.Visible = true;
            }

            if (username == "JamieF" || username == "SummerD")
            {
                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status, a.UserID as UserID, concat(c.Name,' ', c.LastName) as Name FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join  [TravelExpenses].[dbo].[User] as c on c.UserID = a.UserID where c.Department = 'Executive 104' or c.Department = 'Commissioners' or c.Department = 'Educ & Communication 103'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string travelID = dr["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();
                    string name = dr["Name"].ToString();
                    string destination = dr["Destination"].ToString();
                    string travTotal = dr["TotalTravelAmount"].ToString();
                    string status = dr["Status"].ToString();
                    string userID = dr["UserID"].ToString();
                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, destination, name, status, travTotal, travelID, userID);
                }
                dr.Close();

                SqlCommand em = new SqlCommand("SELECT [UserID],[Name],[LastName] FROM [TravelExpenses].[dbo].[User] where Department = 'Executive 104' or Department = 'Commissioners' or Department = 'Educ & Communication 103'  order by LastName", localCon);
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
                    cbEmployee.DataSource = items;
                }

                emDR.Close();
                cbDepartments.Items.Clear();
                cbDepartments.Items.Add("Executive 104");
                cbDepartments.Items.Add("Commissioners");
                cbDepartments.Items.Add("Educ & Communication 103");
                cbDepartments.SelectedItem = "Executive 104";

            }
            else if (username == "KBaker")
            {
                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status, a.UserID as UserID, concat(c.Name,' ', c.LastName) as Name FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join  [TravelExpenses].[dbo].[User] as c on c.UserID = a.UserID where c.Department = 'Mosquito Group 106' or c.Department = 'Field Validation 105' or c.Department = 'Scientific Intelligence 108'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string travelID = dr["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();
                    string name = dr["Name"].ToString();
                    string destination = dr["Destination"].ToString();
                    string travTotal = dr["TotalTravelAmount"].ToString();
                    string status = dr["Status"].ToString();
                    string userID = dr["UserID"].ToString();
                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, destination, name, status, travTotal, travelID, userID);
                }
                dr.Close();

                SqlCommand em = new SqlCommand("SELECT [UserID],[Name],[LastName] FROM [TravelExpenses].[dbo].[User] where Department = 'Mosquito Group 106' or Department = 'Field Validation 105' or Department = 'Scientific Intelligence 108'  order by LastName", localCon);
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
                    cbEmployee.DataSource = items;
                }

                emDR.Close();

                cbDepartments.Items.Clear();
                cbDepartments.Items.Add("Mosquito Group 106");
                cbDepartments.Items.Add("Field Validation 105");
                cbDepartments.Items.Add("Scientific Intelligence 108");
                cbDepartments.SelectedItem = "Mosquito Group 106";
            }
            else if (username == "KWatts")
            {
                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status, a.UserID as UserID, concat(c.Name,' ', c.LastName) as Name FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join  [TravelExpenses].[dbo].[User] as c on c.UserID = a.UserID where c.Department = 'Hyacinth'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string travelID = dr["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();
                    string name = dr["Name"].ToString();
                    string destination = dr["Destination"].ToString();
                    string travTotal = dr["TotalTravelAmount"].ToString();
                    string status = dr["Status"].ToString();
                    string userID = dr["UserID"].ToString();
                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, destination, name, status, travTotal, travelID, userID);
                }
                dr.Close();

                SqlCommand em = new SqlCommand("SELECT [UserID],[Name],[LastName] FROM [TravelExpenses].[dbo].[User]  where Department = 'Hyacinth' order by LastName", localCon);
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
                    cbEmployee.DataSource = items;
                }

                emDR.Close();

                cbDepartments.Items.Clear();
                cbDepartments.Items.Add("Hyacinth");
                cbDepartments.SelectedItem = "Hyacinth";

            }
            else
            {
                cbDepartments.SelectedItem = "Accounting/Purchasing 101";
                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status, a.UserID as UserID, concat(c.Name,' ', c.LastName) as Name FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join  [TravelExpenses].[dbo].[User] as c on c.UserID = a.UserID", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string travelID = dr["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();
                    string name = dr["Name"].ToString();
                    string destination = dr["Destination"].ToString();
                    string travTotal = dr["TotalTravelAmount"].ToString();
                    string status = dr["Status"].ToString();
                    string userID = dr["UserID"].ToString();
                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, destination, name, status, travTotal, travelID, userID);
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
                    cbEmployee.DataSource = items;
                }

                emDR.Close();
            }


            

            localCon.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbtravels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtravels.SelectedItem.ToString() == "Employee")
            {
                lblEmployee.Visible = true;
                cbEmployee.Visible = true;
                pnCriteria.Size = new System.Drawing.Size(631, 74);
            }
            else
            {
                lblEmployee.Visible = false;
                cbEmployee.Visible = false;
                if (cbtravels.SelectedItem.ToString() == "Department")
                {
                    pnCriteria.Size = new System.Drawing.Size(631, 109);
                }
                else if (cbtravels.SelectedItem.ToString() == "All")
                {
                    pnCriteria.Size = new System.Drawing.Size(631, 47);
                }
            }
            if (cbtravels.SelectedItem.ToString() == "Department")
            {
                lblDepartments.Visible = true;
                cbDepartments.Visible = true;
                pnCriteria.Size = new System.Drawing.Size(631, 109);
            }
            else
            {
                lblDepartments.Visible = false;
                cbDepartments.Visible = false;
                if (cbtravels.SelectedItem.ToString() == "Employee")
                {
                    pnCriteria.Size = new System.Drawing.Size(631, 74);
                }
                else if (cbtravels.SelectedItem.ToString() == "All")
                {
                    pnCriteria.Size = new System.Drawing.Size(631, 47);
                }
            }
        }

        public void refreshTravels()
        {
            localCon.Open();
            dgvTravels.Rows.Clear();
            if (cbtravels.SelectedItem.ToString() == "All")
            {
                if (username == "JamieF" || username == "SummerD")
                {
                    SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status, a.UserID as UserID, concat(c.Name,' ', c.LastName) as Name FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join  [TravelExpenses].[dbo].[User] as c on c.UserID = a.UserID where c.Department = 'Executive 104' or c.Department = 'Commissioners' or c.Department = 'Educ & Communication 103'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string travelID = dr["TravelID"].ToString();
                        DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                        DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                        string travEvent = dr["TravelEvent"].ToString();
                        string travPurpose = dr["TravelPurpose"].ToString();
                        string name = dr["Name"].ToString();
                        string destination = dr["Destination"].ToString();
                        string travTotal = dr["TotalTravelAmount"].ToString();
                        string status = dr["Status"].ToString();
                        string userID = dr["UserID"].ToString();
                        dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, destination, name, status, travTotal, travelID, userID);
                    }
                    dr.Close();
                }
                else if (username == "KBaker")
                {
                    SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status, a.UserID as UserID, concat(c.Name,' ', c.LastName) as Name FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join  [TravelExpenses].[dbo].[User] as c on c.UserID = a.UserID where c.Department = 'Mosquito Group 106' or c.Department = 'Field Validation 105' or c.Department = 'Scientific Intelligence 108'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string travelID = dr["TravelID"].ToString();
                        DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                        DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                        string travEvent = dr["TravelEvent"].ToString();
                        string travPurpose = dr["TravelPurpose"].ToString();
                        string name = dr["Name"].ToString();
                        string destination = dr["Destination"].ToString();
                        string travTotal = dr["TotalTravelAmount"].ToString();
                        string status = dr["Status"].ToString();
                        string userID = dr["UserID"].ToString();
                        dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, destination, name, status, travTotal, travelID, userID);
                    }
                    dr.Close();
                }
                else if (username == "KWatts")
                {
                    SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status, a.UserID as UserID, concat(c.Name,' ', c.LastName) as Name FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join  [TravelExpenses].[dbo].[User] as c on c.UserID = a.UserID where c.Department = 'Hyacinth'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string travelID = dr["TravelID"].ToString();
                        DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                        DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                        string travEvent = dr["TravelEvent"].ToString();
                        string travPurpose = dr["TravelPurpose"].ToString();
                        string name = dr["Name"].ToString();
                        string destination = dr["Destination"].ToString();
                        string travTotal = dr["TotalTravelAmount"].ToString();
                        string status = dr["Status"].ToString();
                        string userID = dr["UserID"].ToString();
                        dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, destination, name, status, travTotal, travelID, userID);
                    }
                    dr.Close();
                }
                else
                {


                    SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status,a.UserID as UserID , CONCAT(c.Name, ' ', c.LastName) as Name FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join [TravelExpenses].[dbo].[User] as c on c.UserID = a.UserID", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string travelID = dr["TravelID"].ToString();
                        DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                        DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                        string travEvent = dr["TravelEvent"].ToString();
                        string travPurpose = dr["TravelPurpose"].ToString();
                        string name = dr["Name"].ToString();
                        string destination = dr["Destination"].ToString();
                        string travTotal = dr["TotalTravelAmount"].ToString();
                        string status = dr["Status"].ToString();
                        string userID = dr["UserID"].ToString();
                        dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, destination, name, status, travTotal, travelID, userID);
                    }
                    dr.Close();
                }
            }
            if (cbtravels.SelectedItem.ToString() == "Employee")
            {
                string idUser = cbEmployee.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status,a.UserID as UserID , CONCAT(c.Name, ' ', c.LastName) as Name FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join  [TravelExpenses].[dbo].[User] as c on c.UserID = a.UserID where a.UserID = '" + idUser + "'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string travelID = dr["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();
                    string name = dr["Name"].ToString();
                    string destination = dr["Destination"].ToString();
                    string travTotal = dr["TotalTravelAmount"].ToString();
                    string status = dr["Status"].ToString();
                    string userID = dr["UserID"].ToString();
                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, destination,name,status, travTotal, travelID, userID);
                }
                dr.Close();

            }
            if (cbtravels.SelectedItem.ToString() == "Department")
            {
                string dept = cbDepartments.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,a.UserID as UserID,b.Status as  Status,a.UserID as UserID, CONCAT(c.Name,' ',c.LastName) as Name FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join [TravelExpenses].[dbo].[User] as c on a.UserID = c.UserID where c.Department = '" + dept + "'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string travelID = dr["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime(dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();
                    string name = dr["Name"].ToString();
                    string destination = dr["Destination"].ToString();
                    string travTotal = dr["TotalTravelAmount"].ToString();
                    string userID = dr["UserID"].ToString();
                    string status = dr["Status"].ToString();

                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, destination,name,status, travTotal, travelID, userID);

                }
                dr.Close();
            }
            localCon.Close();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            refreshTravels();
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

            //travel items variables
            bool meal = false;
            bool registartion = false;
            bool lodging = false;
            bool car = false;
            bool flight = false;
            bool mileage = false;
            bool otherExp = false;

            int rowIndex = dgvTravels.CurrentRow.Index;
            Guid userID = new Guid(dgvTravels.Rows[rowIndex].Cells[8].Value.ToString());
            Guid travID = new Guid(dgvTravels.Rows[rowIndex].Cells[7].Value.ToString());

            SqlCommand cmdUser = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] where UserID = '" + userID + "'", localCon);
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

            SqlCommand cmdTDates = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
            SqlDataReader drTDates = cmdTDates.ExecuteReader();
            while (drTDates.Read())
            {
                departureDate = Convert.ToDateTime(drTDates["DepartureDate"].ToString()).ToShortDateString();
                returnDate = Convert.ToDateTime(drTDates["ReturnDate"].ToString()).ToShortDateString();
            }
            drTDates.Close();

            string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form.pdf";
            string pdfName = fullName + "_" + departureDate + "_" + "to" + "_" + returnDate + ".pdf";
            pdfName = pdfName.Replace("/", "-");
            string newFile = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\travel_form_" + pdfName;
            CommonVariables.filePath = newFile;

            PdfReader pdfReader = new PdfReader(pdfTemplate);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;



            //user details
            pdfFormFields.SetField("Full Name", fullName);
            pdfFormFields.SetField("District", district);
            pdfFormFields.SetField("Department", department);

            //travel details
            SqlCommand cmdTD = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
            SqlDataReader drTD = cmdTD.ExecuteReader();
            while (drTD.Read())
            {
                pdfFormFields.SetField("Travel Event", drTD["TravelEvent"].ToString());
                pdfFormFields.SetField("Travel Purpose", drTD["TravelPurpose"].ToString());
                DateTime dd = Convert.ToDateTime(drTD["DepartureDate"].ToString());
                pdfFormFields.SetField("Departure Date", dd.ToShortDateString());
                pdfFormFields.SetField("Departure Time", drTD["DepartureTime"].ToString());
                DateTime rd = Convert.ToDateTime(drTD["ReturnDate"].ToString());
                pdfFormFields.SetField("Return Date", rd.ToShortDateString());
                pdfFormFields.SetField("Return Time", drTD["ReturnTime"].ToString());
                pdfFormFields.SetField("Origin", drTD["Origin"].ToString());
                pdfFormFields.SetField("Destination", drTD["Destination"].ToString());
                pdfFormFields.SetField("Travel State", drTD["TravelState"].ToString());
                pdfFormFields.SetField("Travel Notes", drTD["Notes"].ToString());


                //Tratel Totals
                travelACC = Convert.ToDouble(drTD["TotalTravelAmount"].ToString());
                string travCost = travelACC.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                double reimValue = Convert.ToDouble(drTD["TotalTravelReimbursed"].ToString());
                string reimCost = reimValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                double noReimCostValue = Convert.ToDouble(drTD["TotalTravelNoReimbursed"].ToString());
                string noReimCost = noReimCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                pdfFormFields.SetField("Travel Total", travCost);
                pdfFormFields.SetField("Total Reimbursed", reimCost);
                pdfFormFields.SetField("No Reimbursed", noReimCost);

                pdfFormFields.SetField("Travel Total Cost", travCost);
                pdfFormFields.SetField("Reimbursement", reimCost);
                pdfFormFields.SetField("No Reimbursed Total", noReimCost);


                //set up the travel common variables
                if (drTD["Melas"].ToString() == "True")
                {
                    meal = true;
                }
                if (drTD["Registration"].ToString() == "True")
                {
                    registartion = true;
                }
                if (drTD["CarRental"].ToString() == "True")
                {
                    car = true;
                }
                if (drTD["Lodging"].ToString() == "True")
                {
                    lodging = true;
                }
                if (drTD["AirFare"].ToString() == "True")
                {
                    flight = true;
                }
                if (drTD["Mileage"].ToString() == "True")
                {
                    mileage = true;
                }
                if (drTD["OtherExpenses"].ToString() == "True")
                {
                    otherExp = true;
                }
            }
            drTD.Close();

            //Meals Details
            if (meal)
            {
                string mealIDvalue = "";
                SqlCommand cmdMeals = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drMeals = cmdMeals.ExecuteReader();
                while (drMeals.Read())
                {
                    double mealCostValue = Convert.ToDouble(drMeals["TotalMeals"].ToString());
                    mealIDvalue = drMeals["MealsID"].ToString();
                    string mealCost = mealCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("CostMeals", mealCost);
                    pdfFormFields.SetField("NotesMeals", drMeals["Notes"].ToString());
                    pdfFormFields.SetField("BreakfastPerDiemRate", drMeals["BreakfastPerDiemRate"].ToString());
                    pdfFormFields.SetField("LunchPerDiemRate", drMeals["LunchPerDiemRate"].ToString());
                    pdfFormFields.SetField("DinnerPerDiemRate", drMeals["DinnerPerDiemRate"].ToString());
                    pdfFormFields.SetField("TotalMealsPerDiemRate", drMeals["TotalPerDiemRate"].ToString());
                    pdfFormFields.SetField("PerDiemLoactionZipCode", drMeals["PerDiemLoactionZipCode"].ToString());

                    //details
                    pdfFormFields.SetField("BreakfastQuantity", drMeals["Breakfast"].ToString());
                    pdfFormFields.SetField("LunchQuantity", drMeals["Lunch"].ToString());
                    pdfFormFields.SetField("DinnerQuantity", drMeals["Dinner"].ToString());
                    double brekCost = Convert.ToInt32(drMeals["Breakfast"].ToString()) * Convert.ToDouble(drMeals["BreakfastPerDiemRate"].ToString());
                    pdfFormFields.SetField("BreakfastCost", brekCost.ToString());
                    double lunchCost = Convert.ToInt32(drMeals["Lunch"].ToString()) * Convert.ToDouble(drMeals["LunchPerDiemRate"].ToString());
                    pdfFormFields.SetField("LunchCost", lunchCost.ToString());
                    double dinCost = Convert.ToInt32(drMeals["Dinner"].ToString()) * Convert.ToDouble(drMeals["DinnerPerDiemRate"].ToString());
                    pdfFormFields.SetField("DinnerCost", dinCost.ToString());
                    pdfFormFields.SetField("Meals Notes", drMeals["Notes"].ToString());
                    if (drMeals["ProvidedMeal"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Provided Meals", "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Provided Meals", "No");
                    }
                    //string mealCost = Convert.ToDouble(drMeals["TotalMeals"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Meals_Total", mealCost);

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
                    pdfFormFields.SetField("MealDate" + rowInc, date.ToShortDateString());
                    if (meadDateDR["Breaksfast"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Breakfast" + rowInc, "Yes");
                    }
                    if (meadDateDR["Lunch"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Lunch" + rowInc, "Yes");
                    }
                    if (meadDateDR["Dinner"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Dinner" + rowInc, "Yes");
                    }
                    rowInc++;
                }
                meadDateDR.Close();
            }

            //Registration Details
            if (registartion)
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
                    pdfFormFields.SetField("CostRegistration", totalReg);
                    pdfFormFields.SetField("NotesRegistration", drRegis["Notes"].ToString());

                    //details
                    pdfFormFields.SetField("Registration Cost", totalReg);
                    pdfFormFields.SetField("Registartion Notes", drRegis["Notes"].ToString());
                    if (drRegis["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("District Pay Registration", "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("District Pay Registration", "No");

                        //setting the value for the registration reimbursement
                        registratiorReimbursement = Convert.ToDouble(drRegis["RegistrationAMount"].ToString());
                    }
                }
                drRegis.Close();

            }

            //Lodging
            if (lodging)
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
                    pdfFormFields.SetField("Facility Name" + rowLod, drLod["FacilityName"].ToString());
                    pdfFormFields.SetField("Facility Total Cost" + rowLod, drLod["TotalLodging"].ToString());
                    //totalLod = totalLod + Convert.ToDouble(drLod["TotalLodging"].ToString());
                    pdfFormFields.SetField("Lodging Nights" + rowLod, drLod["NumberOfNights"].ToString());
                    pdfFormFields.SetField("Lodging Night Cost" + rowLod, drLod["CostPerNight"].ToString());
                    pdfFormFields.SetField("Lodging Taxes Fees" + rowLod, drLod["TaxesAndFees"].ToString());
                    if (drLod["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Lodging District Pay" + rowLod, "Yes");
                        pdfFormFields.SetField("Lodging Director Approval" + rowLod, "");
                    }
                    else
                    {
                        pdfFormFields.SetField("Lodging District Pay" + rowLod, "No");
                        if (drLod["DirectorApproved"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Lodging Director Approval" + rowLod, "Yes");

                            //setting the value for the lodging reimbursement
                            lodgingReimbursement += Convert.ToDouble(drLod["TotalLodging"].ToString());
                        }
                        else
                        {
                            pdfFormFields.SetField("Lodging Director Approval" + rowLod, "No");
                        }
                    }
                    pdfFormFields.SetField("Facility  Notes" + rowLod, drLod["Notes"].ToString());
                    rowLod++;
                }
                drLod.Close();
                string lodgCost = totalLod.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostLodgings", lodgCost);
                pdfFormFields.SetField("NotesLodgings", notes);

                pdfFormFields.SetField("Lodging Total", lodgCost);
            }

            //Car Rental Details
            if (car)
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
                    pdfFormFields.SetField("Pick up Date" + carRow, pickUp.ToShortDateString());
                    DateTime dropOff = Convert.ToDateTime(drCR["DropOffDate"].ToString());
                    pdfFormFields.SetField("Drop off Date" + carRow, dropOff.ToShortDateString());
                    pdfFormFields.SetField("Car_Day Cost" + carRow, drCR["CostPerDay"].ToString());
                    pdfFormFields.SetField("Car Total" + carRow, drCR["TotalCarRental"].ToString());
                    //totalCR = totalCR + Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    pdfFormFields.SetField("Car Type" + carRow, drCR["CarType"].ToString());
                    pdfFormFields.SetField("Rental Company" + carRow, drCR["Company"].ToString());
                    pdfFormFields.SetField("Car Rental Days" + carRow, drCR["Days"].ToString());
                    pdfFormFields.SetField("Car Rental Taxes Fees" + carRow, drCR["TaxesAndFees"].ToString());
                    pdfFormFields.SetField("LDW Insurance" + carRow, drCR["LDWInsuranse"].ToString());
                    pdfFormFields.SetField("Supplemental Insurance" + carRow, drCR["SupplementalInsurance"].ToString());
                    pdfFormFields.SetField("Extra Insurance" + carRow, drCR["ExtarInsuranceAmount"].ToString());
                    if (drCR["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Car District Pay" + carRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Car District Pay" + carRow, "No");

                        //setting the value for the car rental reimbursement
                        carRentalReimbursement += Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    }
                    pdfFormFields.SetField("Car Personal Amount" + carRow, drCR["PersonalAmount"].ToString());
                    pdfFormFields.SetField("Car Notes" + carRow, drCR["Notes"].ToString());

                    carRow++;
                }
                drCR.Close();
                string carCost = totalCR.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostCar Rental", carCost);
                pdfFormFields.SetField("NotesCar Rental", notesCR);

                pdfFormFields.SetField("Car Rental Total", carCost);
            }

            //AirFare Details
            if (flight)
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
                    pdfFormFields.SetField("Flight_Departure Date" + flightRow, depDateFligh.ToShortDateString());
                    if (drAF["ReturnDate"].ToString() != "")
                    {
                        DateTime rd = Convert.ToDateTime(drAF["ReturnDate"].ToString());
                        pdfFormFields.SetField("Flight_Return Date" + flightRow, rd.ToShortDateString());
                    }
                    pdfFormFields.SetField("Flight Total" + flightRow, drAF["AirFareTotal"].ToString());
                    //totalAF = totalAF + Convert.ToDouble(drAF["AirFareTotal"].ToString());
                    pdfFormFields.SetField("Flight Taxes  Fees" + flightRow, drAF["TaxesAndFees"].ToString());
                    if (drAF["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Flight District Pay" + flightRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Flight District Pay" + flightRow, "No");

                        //setting the value for the airfare reimbursement
                        airfareReimbursement += Convert.ToDouble(drAF["AirFareTotal"].ToString());
                    }
                    pdfFormFields.SetField("Flight Personal Amount" + flightRow, drAF["PersonalUseAmount"].ToString());
                    pdfFormFields.SetField("Air Fare Notes" + flightRow, drAF["Notes"].ToString());

                    flightRow++;
                }
                drAF.Close();
                string flightCost = totalAF.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostAir Fare", flightCost);
                pdfFormFields.SetField("NotesAir Fare", notesAF);

                pdfFormFields.SetField("Air Fare Total", flightCost);
            }

            //Mileage Details
            if (mileage)
            {
                SqlCommand cmdMi = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drMi = cmdMi.ExecuteReader();

                while (drMi.Read())
                {
                    double milCostValue = Convert.ToDouble(drMi["TotalMileage"].ToString());
                    string milcost = milCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("CostMileage", milcost);
                    pdfFormFields.SetField("NotesMileage", drMi["Notes"].ToString());

                    //details
                    pdfFormFields.SetField("Map Mileage", drMi["MapMileage"].ToString());
                    pdfFormFields.SetField("Vicinity Mileage", drMi["VicinityMileage"].ToString());
                    string milCost = Convert.ToDouble(drMi["TotalMileage"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Mileage Cost", milCost);
                    if (drMi["DistrictVehicleProvided"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Provided Vehicle", "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Provided Vehicle", "No");
                        if (drMi["DirectorApprovedPersonal"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Mileage Director Approval", "Yes");

                            //setting the value for the mileage reimbursement
                            mileagReimbursement = Convert.ToDouble(drMi["TotalMileage"].ToString());
                        }
                        else
                        {
                            pdfFormFields.SetField("Mileage Director Approval", "No");
                        }
                    }
                    pdfFormFields.SetField("Mileage Notes", drMi["Notes"].ToString());
                }
                drMi.Close();
            }

            //Other Expenses
            if (otherExp)
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
                    pdfFormFields.SetField("ExpDescription" + oxRow, drOE["Description"].ToString());
                    pdfFormFields.SetField("ExpCost" + oxRow, drOE["Amount"].ToString());
                    //totalOE = totalOE + Convert.ToDouble(drOE["Amount"].ToString());
                    pdfFormFields.SetField("ExpNotes" + oxRow, drOE["Notes"].ToString());

                    if (drOE["Prepaid"].ToString() == "True")
                    {
                        pdfFormFields.SetField("ExpCard" + oxRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("ExpCard" + oxRow, "No");

                        //setting the value for the other expenses reimbursement
                        otherExpenseReimbursement += Convert.ToDouble(drOE["Amount"].ToString());
                    }

                    oxRow++;
                }
                drOE.Close();
                string oeCost = totalOE.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostOther Expenses", oeCost);
                pdfFormFields.SetField("NotesOther Expenses", notesOE);

                pdfFormFields.SetField("Other Expenses Total", oeCost);
            }

            //Accounting accounts
            string travACC = travelACC.ToString("C", CultureInfo.CurrentCulture);
            pdfFormFields.SetField("Travel4000", travACC);
            string trainACC = trainingACC.ToString("C", CultureInfo.CurrentCulture);
            pdfFormFields.SetField("Training5500", trainACC);

            //Reimbursement Table
            pdfFormFields.SetField("Meals_Reimbursement", mealsReimbursement.ToString());
            pdfFormFields.SetField("Registration_Reimbursement", registratiorReimbursement.ToString());
            pdfFormFields.SetField("Lodgings_Reimbursement", lodgingReimbursement.ToString());
            pdfFormFields.SetField("CarRental_Reimbursement", carRentalReimbursement.ToString());
            pdfFormFields.SetField("Airfare_Reimbursement", airfareReimbursement.ToString());
            pdfFormFields.SetField("Mileage_Reimbursement", mileagReimbursement.ToString());
            pdfFormFields.SetField("OtherExpenses_Reimbursement", otherExpenseReimbursement.ToString());

            //Signatures
            SqlCommand cmdPDF = new SqlCommand("SELECT a.TravelID,a.UserID,a.UserType,a.TravelType,a.SignatureDate,b.FontType,b.SignatureText FROM [TravelExpenses].[dbo].[TravelSignatures] as a inner join TravelExpenses.dbo.UserSignature as b on b.UserID = a.UserID where a.TravelID = '" + travID + "'  AND a.TravelType = 'Travel'", localCon);
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
                    if (drPDF["UserType"].ToString() == "Accounting")
                    {
                        pdfFormFields.SetFieldProperty("Finance Review Siganature", "textfont", bf, null);
                        pdfFormFields.SetField("Finance Review Siganature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Finance Review", sigDate.ToShortDateString());
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

                }
            }
            drPDF.Close();

            pdfStamper.Close();
            localCon.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvTravels.Rows.Count > 0)
            {
                generatePDF();
                ViewPDF vpdf = new ViewPDF();
                vpdf.Show();
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvTravels.Rows.Count > 0)
            {
                int rowIndex = dgvTravels.CurrentRow.Index;
                string travID = dgvTravels.Rows[rowIndex].Cells[7].Value.ToString();
                string userID = dgvTravels.Rows[rowIndex].Cells[8].Value.ToString();
                CommonVariables.viewTravelID = travID;
                CommonVariables.viewTravelUserID = userID;

                ViewTravel vt = new ViewTravel();
                this.Hide();
                vt.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTravels.Rows.Count > 0)
            {

                DialogResult delTrav = MessageBox.Show("Do you really want to delete this travel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delTrav == DialogResult.Yes)
                {
                    bool meals = false;
                    bool registration = false;
                    bool lodgings = false;
                    bool carRentals = false;
                    bool airfare = false;
                    bool mileage = false;
                    bool otherExpenses = false;
                    string mealID = "";

                    int rowIndex = dgvTravels.CurrentRow.Index;
                    string travIDValue = dgvTravels.Rows[rowIndex].Cells[7].Value.ToString();
                    Guid travID = new Guid(travIDValue);

                    localCon.Open();
                    SqlCommand cmd = new SqlCommand("SELECT *  FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr["Melas"].ToString() == "True")
                        {
                            meals = true;
                        }
                        if (dr["Registration"].ToString() == "True")
                        {
                            registration = true;
                        }
                        if (dr["Lodging"].ToString() == "True")
                        {
                            lodgings = true;
                        }
                        if (dr["CarRental"].ToString() == "True")
                        {
                            carRentals = true;
                        }
                        if (dr["AirFare"].ToString() == "True")
                        {
                            airfare = true;
                        }
                        if (dr["Mileage"].ToString() == "True")
                        {
                            mileage = true;
                        }
                        if (dr["OtherExpenses"].ToString() == "True")
                        {
                            otherExpenses = true;
                        }
                    }
                    dr.Close();

                    if (meals)
                    {
                        SqlCommand cmMealdID = new SqlCommand("select MealsID from TravelExpenses.dbo.Meals where TravelID ='" + travID + "'", localCon);
                        SqlDataReader MealdIDdr = cmMealdID.ExecuteReader();
                        while (MealdIDdr.Read())
                        {
                            mealID = MealdIDdr["MealsID"].ToString();
                        }
                        MealdIDdr.Close();

                        SqlCommand delMealDates = new SqlCommand("delete from TravelExpenses.dbo.MealDate where MealsID = '" + mealID + "'", localCon);
                        delMealDates.ExecuteNonQuery();

                        SqlCommand delMeal = new SqlCommand("delete from TravelExpenses.dbo.Meals where TravelID = '" + mealID + "'", localCon);
                        delMeal.ExecuteNonQuery();

                    }
                    if (mileage)
                    {
                        SqlCommand delMile = new SqlCommand("delete from TravelExpenses.dbo.Mileage where TravelID = '" + travID + "'", localCon);
                        delMile.ExecuteNonQuery();
                    }
                    if (otherExpenses)
                    {
                        SqlCommand delOther = new SqlCommand("delete from TravelExpenses.dbo.OtherExpenses where TravelID = '" + travID + "'", localCon);
                        delOther.ExecuteNonQuery();
                    }

                    SqlCommand delStatus = new SqlCommand("delete from TravelExpenses.dbo.TravelStatus where TravelID = '" + travID + "'", localCon);
                    delStatus.ExecuteNonQuery();

                    if (airfare)
                    {
                        SqlCommand delFLight = new SqlCommand("delete from TravelExpenses.dbo.AirFare where TravelID = '" + travID + "'", localCon);
                        delFLight.ExecuteNonQuery();
                    }
                    if (registration)
                    {
                        SqlCommand delReg = new SqlCommand("delete from TravelExpenses.dbo.Registration where TravelID = '" + travID + "'", localCon);
                        delReg.ExecuteNonQuery();
                    }
                    if (lodgings)
                    {
                        SqlCommand delLodg = new SqlCommand("delete from TravelExpenses.dbo.Lodging where TravelID = '" + travID + "'", localCon);
                        delLodg.ExecuteNonQuery();
                    }
                    if (carRentals)
                    {
                        SqlCommand delCar = new SqlCommand(" delete from TravelExpenses.dbo.CarRental where TravelID = '" + travID + "'", localCon);
                        delCar.ExecuteNonQuery();
                    }

                    SqlCommand delTravel = new SqlCommand("delete from [TravelExpenses].[dbo].[Travel]  where TravelID ='" + travID + "'", localCon);
                    int row = delTravel.ExecuteNonQuery();

                    SqlCommand delSignatures = new SqlCommand("delete from TravelExpenses.dbo.TravelSignatures where TravelID ='" + travID + "'", localCon);
                    delSignatures.ExecuteNonQuery();

                    localCon.Close();

                    if (row > 0)
                    {
                        MessageBox.Show("The Travel was successfully deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshTravels();
                    }
                }
            }
            else 
            {
                MessageBox.Show("There is not a travel to delete.");
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            localCon.Open();
            DialogResult changeStatus = MessageBox.Show("Do you really want to change the status of the travel?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (changeStatus == DialogResult.Yes) 
            {
                string status = "";

                
                int rowIndex = dgvTravels.CurrentRow.Index;
                string travIDValue = dgvTravels.Rows[rowIndex].Cells[7].Value.ToString();
                Guid travID = new Guid(travIDValue);

                SqlCommand gstatus = new SqlCommand("SELECT  [Status] FROM [TravelExpenses].[dbo].[TravelStatus] where TravelID = '"+ travID + "'", localCon);
                SqlDataReader gstatusDR = gstatus.ExecuteReader();
                if (gstatusDR.HasRows) 
                {
                    while (gstatusDR.Read()) 
                    {
                        status = gstatusDR["Status"].ToString();
                    }
                }
                gstatusDR.Close();
                if (status != "Pending") 
                {
                    SqlDataAdapter updStatus = new SqlDataAdapter();
                    updStatus.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[TravelStatus] SET [Status] = 'Pending' WHERE TravelID = '"+ travID + "'", localCon);
                    int upSt = updStatus.UpdateCommand.ExecuteNonQuery();
                    localCon.Close();
                    if (upSt > 0) 
                    {
                        MessageBox.Show("The status of the travel successfully changed.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshTravels();
                    }
                }
            }
            localCon.Close();
        }
    }
}
