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
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace TravelExpenses
{
    public partial class Admin : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string winUser = Environment.UserName;
        double travelACC = 0;
        double trainingACC = 0;
        int index = 0;
        bool hideApproved = false;
        public Admin()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            cbtravels.SelectedItem = "All";
            cbDepartments.SelectedItem = "Accounting/Purchasing 101";
            string un = Environment.UserName;
            pnCriteria.Size = new System.Drawing.Size(631, 47);
            localCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status, a.UserID as UserID,c.Name as Name,c.LastName as Lastname FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join [TravelExpenses].[dbo].[User] as c on a.UserID = c.UserID where b.Status != 'Final' order by a.DepartureDate desc", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string travelID = dr["TravelID"].ToString();
                DateTime depDate = Convert.ToDateTime( dr["DepartureDate"].ToString());
                DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                string travEvent = dr["TravelEvent"].ToString();
                string travPurpose = dr["TravelPurpose"].ToString();
                string origin = dr["Origin"].ToString();
                string destination = dr["Destination"].ToString();
                string travTotal = dr["TotalTravelAmount"].ToString();
                string status = dr["Status"].ToString();
                string userID = dr["UserID"].ToString();
                string username = dr["Name"].ToString() + " " + dr["Lastname"].ToString();
                dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination, travTotal, travelID, userID, username);
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
                cbEmployee.DataSource = items;
             }
            
            emDR.Close();
            
            for (int i = 0; i < dgvTravels.RowCount; i++)
            {
                Guid travID = new Guid(dgvTravels.Rows[i].Cells[8].Value.ToString());
                Guid accUser = new Guid(CommonVariables.user);
                SqlCommand signAcc = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' And UserType = 'Accounting' AND TravelID = '"+ travID + "' AND UserID = '"+ accUser + "'", localCon);
                SqlDataReader signAccDR = signAcc.ExecuteReader();
                if (signAccDR.HasRows)
                {
                    dgvTravels.Rows[i].Cells[11].Value = "Yes";
                }
                else
                {
                    dgvTravels.Rows[i].Cells[11].Value = "No";
                }
                signAccDR.Close();
            }

            SqlCommand isJess = new SqlCommand("SELECT [UserID],[Name],[LastName] FROM [TravelExpenses].[dbo].[User] where UserID = '"+ CommonVariables.user +"'", localCon);
            SqlDataReader isJessDR = isJess.ExecuteReader();
            if (isJessDR.HasRows)
            {
                while (isJessDR.Read())
                {
                    if (isJessDR["Name"].ToString() == "Jessica" && isJessDR["LastName"].ToString() == "Collins")
                    {
                        btnDelete.Visible = false;
                        lblDelete.Visible = false;
                        dgvTravels.Columns[1].Visible = false;
                        dgvTravels.Columns[5].Visible = false;
                        dgvTravels.Columns[6].Visible = false;
                        dgvTravels.Columns[7].Visible = false;
                        dgvTravels.Columns[3].Visible = false;
                        dgvTravels.Columns[4].Visible = false;
                        dgvTravels.Columns[10].Visible = true;
                        dgvTravels.Columns[11].Visible = true;
                        btnSendEmails.Enabled = true;
                    }
                    else
                    {
                        btnDelete.Visible = false;
                        lblDelete.Visible = false;
                        btnAccAprr.Enabled = false;
                        btnHide.Enabled = false;
                        btnSendEmails.Enabled = false;
                    }
                }
            }
            isJessDR.Close();

                localCon.Close();



            
        }

        private void cbtravels_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtravels.SelectedItem.ToString() == "Employee")
            {
                lblEmployee.Visible = true;
                cbEmployee.Visible = true;


                lblDepartments.Visible = false;
                cbDepartments.Visible = false;
                tableLayoutPanel4.Visible = false;
                pnCriteria.Size = new System.Drawing.Size(631, 74);

            }
            else if (cbtravels.SelectedItem.ToString() == "Department")
            {
                lblDepartments.Visible = true;
                cbDepartments.Visible = true;

                lblEmployee.Visible = false;
                cbEmployee.Visible = false;
                tableLayoutPanel4.Visible = false;
                pnCriteria.Size = new System.Drawing.Size(631, 109);
            }
            else if (cbtravels.SelectedItem.ToString() == "Employee + Date Range")
            {
                tableLayoutPanel4.Visible = true;
                lblEmployee.Visible = true;
                cbEmployee.Visible = true;

                lblDepartments.Visible = false;
                cbDepartments.Visible = false;
                pnCriteria.Size = new System.Drawing.Size(631, 129);
            }
            else if (cbtravels.SelectedItem.ToString() == "Department + Date Range")
            {
                tableLayoutPanel4.Visible = true;
                lblDepartments.Visible = true;
                cbDepartments.Visible = true;

                lblEmployee.Visible = false;
                cbEmployee.Visible = false;
                pnCriteria.Size = new System.Drawing.Size(631, 129);
            }
            else if (cbtravels.SelectedItem.ToString() == "All")
            {
                tableLayoutPanel4.Visible = false;
                lblDepartments.Visible = false;
                cbDepartments.Visible = false;
                lblEmployee.Visible = false;
                cbEmployee.Visible = false;

                pnCriteria.Size = new System.Drawing.Size(631, 46);
            }
            

        }

        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            refreshTravels();
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            DialogResult fin = MessageBox.Show("Do you really want to archive this Travel? Archiving a travel means no other action could be performed on it.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (fin == DialogResult.Yes)
            {

                int rowIndex = dgvTravels.CurrentRow.Index;
                string travID = dgvTravels.Rows[rowIndex].Cells[8].Value.ToString();
                string status = dgvTravels.Rows[rowIndex].Cells[4].Value.ToString();
                Guid travelID = new Guid(travID);

                if (status == "Pending")
                {
                    localCon.Open();
                    SqlDataAdapter upStatus = new SqlDataAdapter();
                    upStatus.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[TravelStatus] SET [Status] = @Status WHERE TravelID = '" + travelID + "'", localCon);
                    upStatus.UpdateCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Final";
                    int ru = upStatus.UpdateCommand.ExecuteNonQuery();
                    localCon.Close();
                    if (ru > 0)
                    {
                        MessageBox.Show("The travel has been archived successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshTravels();
                    }
                }
                /*else
                {
                    MessageBox.Show("This travel is final already", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }*/
            }

        }

        public void refreshTravels()
        {
            localCon.Open();
            dgvTravels.Rows.Clear();
            if (cbtravels.SelectedItem.ToString() == "All")
            {

                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status,a.UserID as UserID,c.Name as Name,c.LastName as Lastname FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join [TravelExpenses].[dbo].[User] as c on a.UserID = c.UserID  where b.Status != 'Final' order by a.DepartureDate desc", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string travelID = dr["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime( dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();
                    string origin = dr["Origin"].ToString();
                    string destination = dr["Destination"].ToString();
                    string travTotal = dr["TotalTravelAmount"].ToString();
                    string status = dr["Status"].ToString();
                    string userID = dr["UserID"].ToString();
                    string username = dr["Name"].ToString() + " " + dr["Lastname"].ToString();
                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination,  travTotal, travelID, userID, username);
                }
                dr.Close();
            }
            if (cbtravels.SelectedItem.ToString() == "Employee")
            {
                string idUser = cbEmployee.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status,a.UserID as UserID,c.Name as Name,c.LastName as Lastname FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join [TravelExpenses].[dbo].[User] as c on a.UserID = c.UserID where a.UserID = '" + idUser + "' AND b.Status != 'Final' order by a.DepartureDate desc", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string travelID = dr["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime( dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime( dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();
                    string origin = dr["Origin"].ToString();
                    string destination = dr["Destination"].ToString();
                    string travTotal = dr["TotalTravelAmount"].ToString();
                    string status = dr["Status"].ToString();
                    string userID = dr["UserID"].ToString();
                    string username = dr["Name"].ToString() + " " + dr["Lastname"].ToString();
                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination,  travTotal, travelID, userID, username);
                }
                dr.Close();

            }
            if (cbtravels.SelectedItem.ToString() == "Department")
            {
                string dept = cbDepartments.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,a.UserID as UserID,b.Status as  Status,a.UserID as UserID,c.Name as Name,c.LastName as Lastname FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join [TravelExpenses].[dbo].[User] as c on a.UserID = c.UserID where c.Department = '" + dept + "' AND b.Status != 'Final' order by a.DepartureDate desc", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string travelID = dr["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime( dr["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime( dr["ReturnDate"].ToString());
                    string travEvent = dr["TravelEvent"].ToString();
                    string travPurpose = dr["TravelPurpose"].ToString();
                    string origin = dr["Origin"].ToString();
                    string destination = dr["Destination"].ToString();
                    string travTotal = dr["TotalTravelAmount"].ToString();
                    string userID = dr["UserID"].ToString();
                    string status = dr["Status"].ToString();
                    string username = dr["Name"].ToString() + " " + dr["Lastname"].ToString();

                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination,  travTotal, travelID, userID, username);

                }
                dr.Close();
            }
            if (cbtravels.SelectedItem.ToString() == "Department + Date Range")
            {
                string dept = cbDepartments.SelectedItem.ToString();
                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,a.UserID as UserID,b.Status as  Status,a.UserID as UserID,c.Name as Name,c.LastName as Lastname FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join [TravelExpenses].[dbo].[User] as c on a.UserID = c.UserID where c.Department = '"+ dept +"' AND a.DepartureDate Between '"+ dtpStartDate.Value +"' AND '"+ dtpEndDate.Value + "' AND b.Status != 'Final' order by a.DepartureDate desc", localCon);
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
                    string userID = dr["UserID"].ToString();
                    string status = dr["Status"].ToString();
                    string username = dr["Name"].ToString() + " " + dr["Lastname"].ToString();

                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination, travTotal, travelID, userID, username);

                }
                dr.Close();
            }
            if (cbtravels.SelectedItem.ToString() == "Employee + Date Range")
            {
                string idUser = cbEmployee.SelectedValue.ToString();

                SqlCommand cmd = new SqlCommand("SELECT a.TravelID as TravelID, a.DepartureDate as DepartureDate,a.ReturnDate as ReturnDate,a.TravelEvent as TravelEvent,a.TravelPurpose as TravelPurpose,a.Origin as Origin,a.Destination as Destination,a.TotalTravelAmount as TotalTravelAmount,b.Status as  Status,a.UserID as UserID,c.Name as Name,c.LastName as Lastname FROM [TravelExpenses].[dbo].[Travel] as a inner join [TravelExpenses].[dbo].TravelStatus as b on a.TravelID = b.TravelID inner join [TravelExpenses].[dbo].[User] as c on a.UserID = c.UserID where a.UserID = '"+ idUser +"' AND a.DepartureDate BETWEEN '"+ dtpStartDate.Value + "' AND '"+ dtpEndDate.Value + "' AND b.Status != 'Final' order by a.DepartureDate desc", localCon);
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
                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination, travTotal, travelID, userID, username);
                }
                dr.Close();
            }

            for (int i = 0; i < dgvTravels.RowCount; i++)
            {
                Guid travID = new Guid(dgvTravels.Rows[i].Cells[8].Value.ToString());
                Guid accUser = new Guid(CommonVariables.user);
                SqlCommand signAcc = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' And UserType = 'Accounting' AND TravelID = '" + travID + "' AND UserID = '" + accUser + "'", localCon);
                SqlDataReader signAccDR = signAcc.ExecuteReader();
                if (signAccDR.HasRows)
                {
                    dgvTravels.Rows[i].Cells[11].Value = "Yes";
                }
                else
                {
                    dgvTravels.Rows[i].Cells[11].Value = "No";
                }
                signAccDR.Close();
            }

            localCon.Close();
            hideApproved = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CommonVariables.viewDetails = false;
            CommonVariables.viewTravelID = "";
            CommonVariables.viewTravelUserID = "";
            this.Close();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            /* localCon.Open();
             string name = "";
             string lastname = "";
             string district = "";
             string department = "";
             string fullName = "";
             string username = "";

             //travel items variables
             bool meal = false;
             bool registartion = false;
             bool lodging = false;
             bool car = false;
             bool flight = false;
             bool mileage = false;
             bool otherExp = false;

             int rowIndex = dgvTravels.CurrentRow.Index;
             Guid userID = new Guid(dgvTravels.Rows[rowIndex].Cells[9].Value.ToString());
             Guid travIDPdf = new Guid(dgvTravels.Rows[rowIndex].Cells[8].Value.ToString());

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



             string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form(Summarized).pdf";
             string pdfName = fullName + "_" + CommonVariables.travelDepartureDate.ToShortDateString() + "_" + "to" + "_" + CommonVariables.travelReturnDate.ToShortDateString() + ".pdf";
             pdfName = pdfName.Replace("/", "-");
             winUser = winUser.Replace("/", "-");
             string newFile = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\travel_form(Summarized)_" + pdfName;
             CommonVariables.filePath = newFile;

             PdfReader pdfReader = new PdfReader(pdfTemplate);
             PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
             AcroFields pdfFormFields = pdfStamper.AcroFields;



             //user details
             pdfFormFields.SetField("Full Name", fullName);
             pdfFormFields.SetField("District", district);
             pdfFormFields.SetField("Department", department);

             //travel details
             SqlCommand cmdTD = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travIDPdf + "'", localCon);
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


                 //Tratel Totals
                 double travTotalValue = Convert.ToDouble(drTD["TotalTravelAmount"].ToString());
                 string travTotal = travTotalValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                 double reimValue = Convert.ToDouble(drTD["TotalTravelReimbursed"].ToString());
                 string reim = reimValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                 double noReimValue = Convert.ToDouble(drTD["TotalTravelNoReimbursed"].ToString());
                 string noReim = noReimValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                 pdfFormFields.SetField("Travel Total", travTotal);
                 pdfFormFields.SetField("Total Reimbursed", reim);
                 pdfFormFields.SetField("No Reimbursed", noReim);

                 travelACC = Convert.ToDouble(drTD["TotalTravelAmount"].ToString());

                 //set up the travel item variables
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
                 SqlCommand cmdMeals = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travIDPdf + "'", localCon);
                 SqlDataReader drMeals = cmdMeals.ExecuteReader();
                 while (drMeals.Read())
                 {
                     double mealCostValue = Convert.ToDouble(drMeals["TotalMeals"].ToString());
                     string mealCost = mealCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                     pdfFormFields.SetField("CostMeals", mealCost);
                     pdfFormFields.SetField("NotesMeals", drMeals["Notes"].ToString());
                 }
                 drMeals.Close();
             }

             //Registration Details
             if (registartion)
             {

                 SqlCommand cmdRegis = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + travIDPdf + "'", localCon);
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
                 }
                 drRegis.Close();

             }

             //Lodging
             if (lodging)
             {

                 SqlCommand cmdLod = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '" + travIDPdf + "'", localCon);
                 SqlDataReader drLod = cmdLod.ExecuteReader();

                 double totalLod = 0;
                 string notes = "";
                 while (drLod.Read())
                 {
                     totalLod = totalLod + Convert.ToDouble(drLod["TotalLodging"].ToString());
                     if (drLod["Notes"].ToString() != "")
                     {
                         notes += drLod["Notes"].ToString() + " .";
                     }
                 }
                 drLod.Close();
                 string lodgCost = totalLod.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                 pdfFormFields.SetField("CostLodgings", lodgCost);
                 pdfFormFields.SetField("NotesLodgings", notes);
             }

             //Car Rental Details
             if (car)
             {
                 SqlCommand cmdCR = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + travIDPdf + "'", localCon);
                 SqlDataReader drCR = cmdCR.ExecuteReader();


                 double totalCR = 0;
                 string notesCR = "";
                 while (drCR.Read())
                 {
                     totalCR = totalCR + Convert.ToDouble(drCR["TotalCarRental"].ToString());
                     if (drCR["Notes"].ToString() != "")
                     {
                         notesCR += drCR["Notes"].ToString() + " .";
                     }
                 }
                 drCR.Close();
                 string carCost = totalCR.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                 pdfFormFields.SetField("CostCar Rental", carCost);
                 pdfFormFields.SetField("NotesCar Rental", notesCR);
             }

             //AirFare Details
             if (flight)
             {
                 SqlCommand cmdAF = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '" + travIDPdf + "'", localCon);
                 SqlDataReader drAF = cmdAF.ExecuteReader();

                 double totalAF = 0;
                 string notesAF = "";

                 while (drAF.Read())
                 {
                     totalAF = totalAF + Convert.ToDouble(drAF["AirFareTotal"].ToString());
                     if (drAF["Notes"].ToString() != "")
                     {
                         notesAF += drAF["Notes"].ToString() + " .";
                     }
                 }
                 drAF.Close();
                 string flightCost = totalAF.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                 pdfFormFields.SetField("CostAir Fare", flightCost);
                 pdfFormFields.SetField("NotesAir Fare", notesAF);
             }

             //Mileage Details
             if (mileage)
             {
                 SqlCommand cmdMi = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + travIDPdf + "'", localCon);
                 SqlDataReader drMi = cmdMi.ExecuteReader();

                 while (drMi.Read())
                 {
                     double milCostValue = Convert.ToDouble(drMi["TotalMileage"].ToString());
                     string milcost = milCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                     pdfFormFields.SetField("CostMileage", milcost);
                     pdfFormFields.SetField("NotesMileage", drMi["Notes"].ToString());
                 }
                 drMi.Close();
             }

             //Other Expenses
             if (otherExp)
             {
                 SqlCommand cmdOE = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + travIDPdf + "'", localCon);
                 SqlDataReader drOE = cmdOE.ExecuteReader();

                 double totalOE = 0;
                 string notesOE = "";
                 while (drOE.Read())
                 {
                     totalOE = totalOE + Convert.ToDouble(drOE["Amount"].ToString());
                     if (drOE["Notes"].ToString() != "")
                     {
                         notesOE += drOE["Notes"].ToString() + " .";
                     }
                 }
                 drOE.Close();
                 string oeCost = totalOE.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                 pdfFormFields.SetField("CostOther Expenses", oeCost);
                 pdfFormFields.SetField("NotesOther Expenses", notesOE);
             }


             //Accounting accounts
             string travACC = travelACC.ToString("C", CultureInfo.CurrentCulture);
             pdfFormFields.SetField("Travel4000", travACC);
             string trainACC = trainingACC.ToString("C", CultureInfo.CurrentCulture);
             pdfFormFields.SetField("Training5500", trainACC);

             //Signatures
             SqlCommand cmdPDF = new SqlCommand("SELECT a.TravelID,a.UserID,a.UserType,a.TravelType,a.SignatureDate,b.FontType,b.SignatureText FROM [TravelExpenses].[dbo].[TravelSignatures] as a inner join TravelExpenses.dbo.UserSignature as b on b.UserID = a.UserID where a.TravelID = '" + travIDPdf + "'  AND a.TravelType = 'Travel'", localCon);
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
             localCon.Close();*/

            generatePDF();
            ViewPDF vpdf = new ViewPDF();
            vpdf.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvTravels.CurrentRow.Index;
            string travID = dgvTravels.Rows[rowIndex].Cells[8].Value.ToString();
            string userID = dgvTravels.Rows[rowIndex].Cells[9].Value.ToString();
            CommonVariables.viewTravelID = travID;
            CommonVariables.viewTravelUserID = userID;

            ViewTravel vt = new ViewTravel();
            this.Hide();
            vt.ShowDialog();
           
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommonVariables.viewDetails = false;
            CommonVariables.viewTravelID = "";
            CommonVariables.viewTravelUserID = "";
        }

        private void btnAccAprr_Click(object sender, EventArgs e)
        {
            localCon.Open();
            int rowIndex = dgvTravels.CurrentRow.Index;
            index = rowIndex;
            string travIDValue = dgvTravels.Rows[rowIndex].Cells[8].Value.ToString();
            string travUserIDValue = dgvTravels.Rows[rowIndex].Cells[9].Value.ToString();
            DateTime depDate = Convert.ToDateTime(dgvTravels.Rows[rowIndex].Cells[0].Value.ToString());
            DateTime retDate = Convert.ToDateTime(dgvTravels.Rows[rowIndex].Cells[1].Value.ToString());
            string travEvent = dgvTravels.Rows[rowIndex].Cells[2].Value.ToString();
            string destination = dgvTravels.Rows[rowIndex].Cells[6].Value.ToString();
            string email = "";


            Guid travID = new Guid(travIDValue);
            bool isApproved = false;
            Guid userID = new Guid(CommonVariables.user);
            Guid travUserID = new Guid(travUserIDValue);

            //verify if this user already approved the travel
            SqlCommand cmd = new SqlCommand("SELECT [TravelID],[UserID],[UserType],[TravelType] FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelID = '" + travID + "'  AND UserType = 'Accounting' AND TravelType = 'Travel'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                isApproved = true;
                MessageBox.Show("This travel was already approved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dr.Close();

            //recovery of the travel user email for notifications
            SqlCommand travUser = new SqlCommand("SELECT  [Email] FROM [TravelExpenses].[dbo].[User_Email_Title] where UserID = '" + travUserID + "'", localCon);
            SqlDataReader travUserDR = travUser.ExecuteReader();
            while (travUserDR.Read())
            {
                email = travUserDR["Email"].ToString();
            }
            travUserDR.Close();

            

            //insert approval
            if (!isApproved)
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[TravelSignatures] ([TravelID],[UserID],[UserType],[TravelType],[SignatureDate]) VALUES (@TravelID,@UserID,@UserType,@TravelType,@SignatureDate)", localCon);
                da.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travID;
                da.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userID;
                da.InsertCommand.Parameters.Add("@UserType", SqlDbType.VarChar).Value = "Accounting";
                da.InsertCommand.Parameters.Add("@TravelType", SqlDbType.VarChar).Value = "Travel";
                da.InsertCommand.Parameters.Add("@SignatureDate", SqlDbType.DateTime).Value = DateTime.Today;
                int row = da.InsertCommand.ExecuteNonQuery();
                if (row > 0)
                {

                    //adding to the history trace table
                    Guid loginUser = new Guid(CommonVariables.user);
                    SqlDataAdapter tadpt = new SqlDataAdapter();
                    tadpt.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User_History_Trace] ([UserID],[Action],[Date]) VALUES (@UserID ,@Action,@Date)", localCon);
                    tadpt.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = loginUser;
                    tadpt.InsertCommand.Parameters.Add("@Action", SqlDbType.NVarChar).Value = "Travel Expense Report Approved by Accounting";
                    tadpt.InsertCommand.Parameters.Add("@Date", SqlDbType.NVarChar).Value = DateTime.Now;
                    tadpt.InsertCommand.ExecuteNonQuery();

                    localCon.Close();
                    MessageBox.Show("This travel has been successfully approved by Accounting", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBox1.Visible = true;
                    lblInfo.Visible = true;
                    dgvTravels.Enabled = false;
                    tableLayoutPanel2.Enabled = false;
                    pnCriteria.Enabled = false;
                    tableLayoutPanel3.Enabled = false;

                    if (backgroundWorker1.IsBusy != true)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }

            }

            localCon.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
            string travIDValue = dgvTravels.Rows[rowIndex].Cells[8].Value.ToString();
            Guid travID = new Guid(travIDValue);

            localCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT *  FROM [TravelExpenses].[dbo].[Travel] where TravelID = '"+ travID +"'", localCon);
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
                SqlCommand cmMealdID = new SqlCommand("select MealsID from TravelExpenses.dbo.Meals where TravelID ='"+ travID + "'", localCon);
                SqlDataReader MealdIDdr = cmMealdID.ExecuteReader();
                while (MealdIDdr.Read())
                {
                    mealID = MealdIDdr["MealsID"].ToString();
                }
                MealdIDdr.Close();

                SqlCommand delMealDates = new SqlCommand("delete from TravelExpenses.dbo.MealDate where MealsID = '"+ mealID + "'", localCon);
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

            SqlCommand delStatus = new SqlCommand("delete from TravelExpenses.dbo.TravelStatus where TravelID = '"+ travID + "'", localCon);
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

            SqlCommand delTravel = new SqlCommand("delete from [TravelExpenses].[dbo].[Travel]  where TravelID ='"+ travID + "'", localCon);
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

        private void sendSupervisorEmail()
        {
            DateTime depDate = Convert.ToDateTime(dgvTravels.Rows[index].Cells[0].Value.ToString());
            DateTime retDate = Convert.ToDateTime(dgvTravels.Rows[index].Cells[1].Value.ToString());
            string travEvent = dgvTravels.Rows[index].Cells[2].Value.ToString();
            string destination = dgvTravels.Rows[index].Cells[6].Value.ToString();
            string travUserIDValue = dgvTravels.Rows[index].Cells[9].Value.ToString();
            Guid travUserID = new Guid(travUserIDValue);
            

            //recovery of the supervisor info
            string supEmail = "";
            localCon.Open();
            SqlCommand supInfo = new SqlCommand("SELECT b.Email as Email  FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User_Email_Title] as b on b.UserID = a.SupervisorID where a.UserID = '" + travUserID + "'", localCon);
            SqlDataReader supInfoDR = supInfo.ExecuteReader();
            while (supInfoDR.Read())
            {
                supEmail = supInfoDR["Email"].ToString();
            }
            supInfoDR.Close();

            //recovery of the travel user email for notifications
            string email = "";
            string username = "";
            SqlCommand travUser = new SqlCommand("SELECT a.Email as [Email], b.Name as Name, b.LastName as Lastname FROM [TravelExpenses].[dbo].[User_Email_Title] as a inner join [TravelExpenses].[dbo].[User] as b on b.UserID = a.UserID where a.UserID = '" + travUserID + "'", localCon);
            SqlDataReader travUserDR = travUser.ExecuteReader();
            while (travUserDR.Read())
            {
                email = travUserDR["Email"].ToString();
                username = travUserDR["Name"].ToString() + " " + travUserDR["Lastname"].ToString();
            }
            travUserDR.Close();
            localCon.Close();

            SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org", 587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
            SmtpServer.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("travelAlert@lcmcd.org");
            mail.To.Add(supEmail);
            mail.Subject = "Review the travel of " + username;

            MailMessage mailEmp = new MailMessage();
            mailEmp.From = new MailAddress("travelAlert@lcmcd.org");
            mailEmp.To.Add(email);
            mailEmp.Subject = "Your travel was approved by Accounting";


            if (depDate.ToShortDateString() == retDate.ToShortDateString())
            {
                mail.Body = "Please review the travel of " + username + " on " + depDate.ToShortDateString() + " in order to " + "attend to " + travEvent + " event, arriving to " + destination + ". This expense report was already reviewed and signed by accounting.";
                mailEmp.Body = "Your travel for the " + depDate.ToShortDateString() + " in order to " + "attend to " + travEvent + " event, arriving to " + destination + ", was approved by Accounting";
            }
            else
            {
                mail.Body = "Please review the travel of " + username + " from " + depDate.ToShortDateString() + " to " + retDate.ToShortDateString() + " in order to attend to " + travEvent + " event, arriving to " + destination + ". This expense report was already reviewed and signed by accounting.";
                mailEmp.Body = "Your travel for the " + depDate.ToShortDateString() + " to " + retDate.ToShortDateString() + " in order to attend to " + travEvent + " event, arriving to " + destination + ", was approved by Accounting";
            }

            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            try
            {
                SmtpServer.Send(mail);
                SmtpServer.Send(mailEmp);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            sendSupervisorEmail();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            index = 0;
            pictureBox1.Visible = false;
            lblInfo.Visible = false;
            dgvTravels.Enabled = true;
            tableLayoutPanel2.Enabled = true;
            pnCriteria.Enabled = true;
            tableLayoutPanel3.Enabled = true;
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
            Guid userID = new Guid(dgvTravels.Rows[rowIndex].Cells[9].Value.ToString());
            Guid travID = new Guid(dgvTravels.Rows[rowIndex].Cells[8].Value.ToString());

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
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\Rage Italic.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CommonVariables.viewDetails = false;
            CommonVariables.viewTravelID = "";
            CommonVariables.viewTravelUserID = "";
            this.Close();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (hideApproved)
            {
                for (int i = 0; i < dgvTravels.RowCount; i++)
                {
                    if (dgvTravels.Rows[i].Cells[11].Value.ToString() == "Yes")
                    {
                        dgvTravels.Rows[i].Visible = true;
                    }
                }
                hideApproved = false;
            }
            else
            {
                for (int i = 0; i < dgvTravels.RowCount; i++)
                {
                    if (dgvTravels.Rows[i].Cells[11].Value.ToString() == "Yes")
                    {
                        dgvTravels.Rows[i].Visible = false;
                    }
                }
                hideApproved = true;
            }
        }

        private void btnSendEmails_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            lblInfo.Visible = true;
            dgvTravels.Enabled = false;
            tableLayoutPanel2.Enabled = false;
            pnCriteria.Enabled = false;
            tableLayoutPanel3.Enabled = false;

            if (backgroundWorker2.IsBusy != true)
            {
                backgroundWorker2.RunWorkerAsync();
            }
        }

        private void ResendEmailEmployee()
        {
            localCon.Open();
            int rowIndex = dgvTravels.CurrentRow.Index;
            index = rowIndex;
            string travIDValue = dgvTravels.Rows[rowIndex].Cells[8].Value.ToString();
            string travUserIDValue = dgvTravels.Rows[rowIndex].Cells[9].Value.ToString();
            DateTime depDate = Convert.ToDateTime(dgvTravels.Rows[rowIndex].Cells[0].Value.ToString());
            DateTime retDate = Convert.ToDateTime(dgvTravels.Rows[rowIndex].Cells[1].Value.ToString());
            string travEvent = dgvTravels.Rows[rowIndex].Cells[2].Value.ToString();
            string destination = dgvTravels.Rows[rowIndex].Cells[6].Value.ToString();
            string email = "";
            string username = "";

            //recovery of the travel user email for notifications
            Guid idUser = new Guid(travUserIDValue);
            SqlCommand userInfo = new SqlCommand("SELECT [Name],[LastName],b.Email FROM [TravelExpenses].[dbo].[User] as a inner join [TravelExpenses].[dbo].[User_Email_Title] as b on a.UserID = b.UserID where a.UserID = '" + idUser + "'", localCon);
            SqlDataReader userInfoDR = userInfo.ExecuteReader();
            while (userInfoDR.Read())
            {
                username = userInfoDR["Name"].ToString() + " " + userInfoDR["LastName"].ToString();
                email = userInfoDR["Email"].ToString();
            }
            userInfoDR.Close();

            SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org", 587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
            SmtpServer.EnableSsl = true;

            MailMessage empMail = new MailMessage();
            empMail.From = new MailAddress("travelAlert@lcmcd.org");
            empMail.To.Add(email);
            empMail.Subject = "Travel to " + travEvent +  ", "+ destination;

            string bodyText = "In reference to the above travel, this is a reminder to bring to Jessica Collins all invoices/ receipts, in order for her to review your expense report( do not send them via email)." + System.Environment.NewLine + "Important: Please keep a copy of all invoices / receipts." + System.Environment.NewLine + "Thank you";
            empMail.Body = bodyText;

            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            try
            {
                SmtpServer.Send(empMail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                localCon.Close();
            }

            localCon.Close();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            ResendEmailEmployee();
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            index = 0;
            pictureBox1.Visible = false;
            lblInfo.Visible = false;
            dgvTravels.Enabled = true;
            tableLayoutPanel2.Enabled = true;
            pnCriteria.Enabled = true;
            tableLayoutPanel3.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CommonVariables.editTravelID = dgvTravels.CurrentRow.Cells[8].Value.ToString();
            this.Close();
            SelectItemsEdit si = new SelectItemsEdit();
            si.ShowDialog();
            
        }
    }
}
