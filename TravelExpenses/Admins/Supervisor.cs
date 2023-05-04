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
    public partial class Supervisor : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string department = "";
        string winUser = Environment.UserName;
        double travelACC = 0;
        double trainingACC = 0;
        int cantR = 0;

        DateTime depDate = DateTime.Today;
        DateTime retDate = DateTime.Today;
        string travEvent = "";
        string destination = "";
        string email = "";
        string travUserIDValue = "";

        string userTitle = "";
        string asstDirectorID = "";
        string query = "";
        string travQuery = "";
        string aprovQuery = "";

        bool hideApproved = false;

        public Supervisor()
        {
            InitializeComponent();
        }

        private void Supervisor_Load(object sender, EventArgs e)
        {
            localCon.Open();
            dgvTravels.Rows.Clear();
            

            //checking if the user is the director
            
            SqlCommand titlecmd = new SqlCommand("SELECT [Title] FROM [TravelExpenses].[dbo].[User_Email_Title] where UserID = '" + CommonVariables.user + "'",localCon);
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
                query = "SELECT b.Name as name , b.LastName as lastname, a.UserID as UserID FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User] as b on a.UserID = b.UserID inner join [TravelExpenses].[dbo].[User_Email_Title] as c on b.UserID = c.UserID where (SupervisorID = '" + CommonVariables.user + "' or SupervisorID = '" + asstDirectorID + "') AND c.Active = 1 order by b.LastName asc";
                travQuery = "SELECT c.TravelID as TravelID, c.DepartureDate as DepartureDate,c.ReturnDate as ReturnDate,c.TravelEvent as TravelEvent,c.TravelPurpose as TravelPurpose,c.Origin as Origin,c.Destination as Destination,c.TravelState as TravelState,a.UserID as UserID,c.TotalTravelAmount as TotalTravelAmount, d.Status as Status,b.Name as Name,b.LastName as LastName,b.Department as Department FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User] as b on a.UserID = b.UserID inner join TravelExpenses.dbo.Travel as c on c.UserID = a.UserID inner join TravelExpenses.dbo.TravelStatus as d on d.TravelID = c.TravelID  inner join TravelExpenses.dbo.TravelSignatures as e on c.TravelID = e.TravelID AND e.UserType = 'Accounting' inner join [TravelExpenses].[dbo].[User_Email_Title] as f on b.UserID = f.UserID where (SupervisorID =  '" + CommonVariables.user + "' or SupervisorID = '" + asstDirectorID + "') AND f.Active = 1  order by c.DepartureDate desc";
            }
            else 
            {
                query = "SELECT b.Name as name , b.LastName as lastname, a.UserID as UserID FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User] as b on a.UserID = b.UserID inner join [TravelExpenses].[dbo].[User_Email_Title] as c on b.UserID = c.UserID where SupervisorID = '" + CommonVariables.user + "' AND c.Active = 1 order by b.LastName asc";
                travQuery = "SELECT c.TravelID as TravelID, c.DepartureDate as DepartureDate,c.ReturnDate as ReturnDate,c.TravelEvent as TravelEvent,c.TravelPurpose as TravelPurpose,c.Origin as Origin,c.Destination as Destination,c.TravelState as TravelState,a.UserID as UserID,c.TotalTravelAmount as TotalTravelAmount, d.Status as Status,b.Name as Name,b.LastName as LastName,b.Department as Department FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User] as b on a.UserID = b.UserID inner join TravelExpenses.dbo.Travel as c on c.UserID = a.UserID inner join TravelExpenses.dbo.TravelStatus as d on d.TravelID = c.TravelID  inner join TravelExpenses.dbo.TravelSignatures as e on c.TravelID = e.TravelID AND e.UserType = 'Accounting' inner join [TravelExpenses].[dbo].[User_Email_Title] as f on b.UserID = f.UserID where SupervisorID =  '" + CommonVariables.user + "' AND f.Active = 1 order by c.DepartureDate desc";
            }


            SqlCommand empl = new SqlCommand(query, localCon);
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
            emplDR.Close();

            SqlCommand cmdAllDep = new SqlCommand(travQuery, localCon);
            SqlDataReader cmdAllDepDR = cmdAllDep.ExecuteReader();
            while (cmdAllDepDR.Read())
            {
                string travelID = cmdAllDepDR["TravelID"].ToString();
                DateTime depDate = Convert.ToDateTime(cmdAllDepDR["DepartureDate"].ToString());
                DateTime retDate = Convert.ToDateTime(cmdAllDepDR["ReturnDate"].ToString());
                string travEvent = cmdAllDepDR["TravelEvent"].ToString();
                string travPurpose = cmdAllDepDR["TravelPurpose"].ToString();
                string origin = cmdAllDepDR["Origin"].ToString();
                string destination = cmdAllDepDR["Destination"].ToString();
                string travTotal = cmdAllDepDR["TotalTravelAmount"].ToString();
                string status = cmdAllDepDR["Status"].ToString();
                string userID = cmdAllDepDR["UserID"].ToString();
                string name = cmdAllDepDR["Name"].ToString() + " " + cmdAllDepDR["Lastname"].ToString();
                department = cmdAllDepDR["Department"].ToString();
                //string reimb = cmdAllDepDR["TotalTravelReimbursed"].ToString();
                dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination, travTotal, travelID, userID, name, department);
            }
            cmdAllDepDR.Close();


            Guid userIDApproved = new Guid(CommonVariables.user);
            for (int i = 0; i < dgvTravels.RowCount; i++)
            {
                Guid travIDApproved = new Guid(dgvTravels.Rows[i].Cells[8].Value.ToString());


                if (userTitle == "Executive Director")
                {
                    aprovQuery = "SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' And UserType = 'Supervisor' AND TravelID = '" + travIDApproved + "' AND (UserID = '" + userIDApproved + "' or UserID = '"+ asstDirectorID + "')";
                }
                else 
                {
                    aprovQuery = "SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' And UserType = 'Supervisor' AND TravelID = '" + travIDApproved + "' AND UserID = '" + userIDApproved + "'";
                }
                SqlCommand supApproved = new SqlCommand(aprovQuery, localCon);
                SqlDataReader supApprovedDR = supApproved.ExecuteReader();
                if (supApprovedDR.HasRows)
                {
                    while (supApprovedDR.Read())
                    {
                        string test = supApprovedDR["UserID"].ToString();
                        dgvTravels.Rows[i].Cells[12].Value = "Yes";
                    }
                }
                else
                {
                    dgvTravels.Rows[i].Cells[12].Value = "No";
                }
                supApprovedDR.Close();
            }

            localCon.Close();
            cantR = dgvTravels.RowCount;

        }
        
        public void selectTravels()
        {
            localCon.Close();
            localCon.Open();
            dgvTravels.Rows.Clear();
            aprovQuery = "";
            Guid userIDTR = new Guid(cbEmployee.SelectedValue.ToString());
            SqlCommand cmdAllDep = new SqlCommand("SELECT a.TravelID as [TravelID] , a.DepartureDate as [DepartureDate] ,a.ReturnDate as [ReturnDate] ,a.TravelEvent as [TravelEvent] , a.TravelPurpose as [TravelPurpose] ,a.Origin as [Origin],a.Destination as [Destination],a.TravelState as [TravelState],a.UserID as [UserID],a.TotalTravelAmount as [TotalTravelAmount], c.Status as Status, b.Name as Name, b.LastName as Lastname,b.Department as Department FROM [TravelExpenses].[dbo].[Travel] as a  inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID inner join TravelExpenses.dbo.TravelStatus as c on a.TravelID = c.TravelID   inner join TravelExpenses.dbo.TravelSignatures as e on a.TravelID = e.TravelID AND e.UserType = 'Accounting' where b.UserID = '" + userIDTR + "' order by a.DepartureDate desc", localCon);
            SqlDataReader cmdAllDepDR = cmdAllDep.ExecuteReader();
            while (cmdAllDepDR.Read())
            {
                string travelID = cmdAllDepDR["TravelID"].ToString();
                DateTime depDate = Convert.ToDateTime(cmdAllDepDR["DepartureDate"].ToString());
                DateTime retDate = Convert.ToDateTime(cmdAllDepDR["ReturnDate"].ToString());
                string travEvent = cmdAllDepDR["TravelEvent"].ToString();
                string travPurpose = cmdAllDepDR["TravelPurpose"].ToString();
                string origin = cmdAllDepDR["Origin"].ToString();
                string destination = cmdAllDepDR["Destination"].ToString();
                string travTotal = cmdAllDepDR["TotalTravelAmount"].ToString();
                string status = cmdAllDepDR["Status"].ToString();
                string userID = cmdAllDepDR["UserID"].ToString();
                string name = cmdAllDepDR["Name"].ToString() + " " + cmdAllDepDR["Lastname"].ToString();
                department = cmdAllDepDR["Department"].ToString();
                //string reimb = cmdAllDepDR["TotalTravelReimbursed"].ToString();
                dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination, travTotal, travelID, userID, name, department);
            }
            cmdAllDepDR.Close();

            Guid userIDApproved = new Guid(CommonVariables.user);
            for (int i = 0; i < dgvTravels.RowCount; i++)
            {
                Guid travIDApproved = new Guid(dgvTravels.Rows[i].Cells[8].Value.ToString());

                if (userTitle == "Executive Director")
                {
                    aprovQuery = "SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' And UserType = 'Supervisor' AND TravelID = '" + travIDApproved + "' AND (UserID = '" + userIDApproved + "' or UserID = '"+ asstDirectorID +"')";
                }
                else 
                {
                    aprovQuery = "SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' And UserType = 'Supervisor' AND TravelID = '" + travIDApproved + "' AND UserID = '" + userIDApproved + "'";
                }
                
                SqlCommand supApproved = new SqlCommand(aprovQuery, localCon);
                SqlDataReader supApprovedDR = supApproved.ExecuteReader();
                if (supApprovedDR.HasRows)
                {
                    dgvTravels.Rows[i].Cells[12].Value = "Yes";
                }
                else
                {
                    dgvTravels.Rows[i].Cells[12].Value = "No";
                }
                supApprovedDR.Close();
            }

            localCon.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShowTravels_Click(object sender, EventArgs e)
        {
            string text = cbEmployee.SelectedValue.ToString();
            dgvTravels.Rows.Clear();
            query = "";
            aprovQuery = "";

            if (text == "-1")
            {
                if (userTitle == "Executive Director")
                {
                    query = "SELECT c.TravelID as TravelID, c.DepartureDate as DepartureDate,c.ReturnDate as ReturnDate,c.TravelEvent as TravelEvent,c.TravelPurpose as TravelPurpose,c.Origin as Origin,c.Destination as Destination,c.TravelState as TravelState,a.UserID as UserID,c.TotalTravelAmount as TotalTravelAmount, d.Status as Status,b.Name as Name,b.LastName as LastName,b.Department as Department FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User] as b on a.UserID = b.UserID inner join TravelExpenses.dbo.Travel as c on c.UserID = a.UserID inner join TravelExpenses.dbo.TravelStatus as d on d.TravelID = c.TravelID  inner join TravelExpenses.dbo.TravelSignatures as e on c.TravelID = e.TravelID AND e.UserType = 'Accounting' inner join [TravelExpenses].[dbo].[User_Email_Title] as f on b.UserID = f.UserID where (SupervisorID =  '" + CommonVariables.user + "' or SupervisorID = '" + asstDirectorID + "') AND f.Active = 1 order by c.DepartureDate desc";
                }
                else 
                {
                    query = "SELECT c.TravelID as TravelID, c.DepartureDate as DepartureDate,c.ReturnDate as ReturnDate,c.TravelEvent as TravelEvent,c.TravelPurpose as TravelPurpose,c.Origin as Origin,c.Destination as Destination,c.TravelState as TravelState,a.UserID as UserID,c.TotalTravelAmount as TotalTravelAmount, d.Status as Status,b.Name as Name,b.LastName as LastName,b.Department as Department FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User] as b on a.UserID = b.UserID inner join TravelExpenses.dbo.Travel as c on c.UserID = a.UserID inner join TravelExpenses.dbo.TravelStatus as d on d.TravelID = c.TravelID  inner join TravelExpenses.dbo.TravelSignatures as e on c.TravelID = e.TravelID AND e.UserType = 'Accounting' inner join [TravelExpenses].[dbo].[User_Email_Title] as f on b.UserID = f.UserID where SupervisorID =  '" + CommonVariables.user + "' AND f.Active = 1 order by c.DepartureDate desc";
                }

                localCon.Open();
                SqlCommand cmdAllDep = new SqlCommand(query, localCon);
                SqlDataReader cmdAllDepDR = cmdAllDep.ExecuteReader();
                while (cmdAllDepDR.Read())
                {
                    string travelID = cmdAllDepDR["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime(cmdAllDepDR["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(cmdAllDepDR["ReturnDate"].ToString());
                    string travEvent = cmdAllDepDR["TravelEvent"].ToString();
                    string travPurpose = cmdAllDepDR["TravelPurpose"].ToString();
                    string origin = cmdAllDepDR["Origin"].ToString();
                    string destination = cmdAllDepDR["Destination"].ToString();
                    string travTotal = cmdAllDepDR["TotalTravelAmount"].ToString();
                    string status = cmdAllDepDR["Status"].ToString();
                    string userID = cmdAllDepDR["UserID"].ToString();
                    string name = cmdAllDepDR["Name"].ToString() + " " + cmdAllDepDR["Lastname"].ToString();
                    department = cmdAllDepDR["Department"].ToString();
                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination, travTotal, travelID, userID, name, department);
                }
                cmdAllDepDR.Close();

                Guid userIDApproved = new Guid(CommonVariables.user);
                for (int i = 0; i < dgvTravels.RowCount; i++)
                {
                    Guid travIDApproved = new Guid(dgvTravels.Rows[i].Cells[8].Value.ToString());

                    if (userTitle == "Executive Director")
                    {
                        aprovQuery = "SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' And UserType = 'Supervisor' AND TravelID = '" + travIDApproved + "' AND (UserID = '" + userIDApproved + "' or UserID ='"+ asstDirectorID +"')";
                    }
                    else 
                    {
                        aprovQuery = "SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' And UserType = 'Supervisor' AND TravelID = '" + travIDApproved + "' AND UserID = '" + userIDApproved + "'";
                    }
                    
                    SqlCommand supApproved = new SqlCommand(aprovQuery, localCon);
                    SqlDataReader supApprovedDR = supApproved.ExecuteReader();
                    if (supApprovedDR.HasRows)
                    {
                        dgvTravels.Rows[i].Cells[12].Value = "Yes";
                    }
                    else
                    {
                        dgvTravels.Rows[i].Cells[12].Value = "No";
                    }
                    supApprovedDR.Close();
                }

                localCon.Close();

            }
            else
            {
                selectTravels();

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
          
            if (cantR > 0)
            {
                this.Hide();
                int rowIndex = dgvTravels.CurrentRow.Index;
                string travID = dgvTravels.Rows[rowIndex].Cells[8].Value.ToString();
                string userID = dgvTravels.Rows[rowIndex].Cells[9].Value.ToString();
                CommonVariables.viewTravelID = travID;
                CommonVariables.viewTravelUserID = userID;

                ViewTravel vt = new ViewTravel();
                vt.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("There are no travels on the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Supervisor_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommonVariables.viewDetails = false;
            CommonVariables.viewTravelID = "";
            CommonVariables.viewTravelUserID = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CommonVariables.viewDetails = false;
            CommonVariables.viewTravelID = "";
            CommonVariables.viewTravelUserID = "";
            this.Close();
        }

        private void btnFinalizeTravel_Click(object sender, EventArgs e)
        {
            if (cantR > 0)
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
                        MessageBox.Show("The travel status has been changed to final successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshTravels();
                    }

                }
                else
                {
                    MessageBox.Show("This travel is final already", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("There are no travels on the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void refreshTravels()
        {

            localCon.Open();
            dgvTravels.Rows.Clear();
            string text = cbEmployee.SelectedValue.ToString();
            query = "";
            aprovQuery = "";

            if (text == "-1")
            {
                if (userTitle == "Executive Director")
                {
                    query = "SELECT c.TravelID as TravelID, c.DepartureDate as DepartureDate,c.ReturnDate as ReturnDate,c.TravelEvent as TravelEvent,c.TravelPurpose as TravelPurpose,c.Origin as Origin,c.Destination as Destination,c.TravelState as TravelState,a.UserID as UserID,c.TotalTravelAmount as TotalTravelAmount, d.Status as Status,b.Name as Name,b.LastName as LastName,b.Department as Department FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User] as b on a.UserID = b.UserID inner join TravelExpenses.dbo.Travel as c on c.UserID = a.UserID inner join TravelExpenses.dbo.TravelStatus as d on d.TravelID = c.TravelID  inner join TravelExpenses.dbo.TravelSignatures as e on c.TravelID = e.TravelID AND e.UserType = 'Accounting' inner join [TravelExpenses].[dbo].[User_Email_Title] as f on b.UserID = f.UserID where (SupervisorID =  '" + CommonVariables.user + "' or SupervisorID = '"+ asstDirectorID +"') AND f.Active = 1 order by c.DepartureDate desc";
                }
                else 
                {
                    query = "SELECT c.TravelID as TravelID, c.DepartureDate as DepartureDate,c.ReturnDate as ReturnDate,c.TravelEvent as TravelEvent,c.TravelPurpose as TravelPurpose,c.Origin as Origin,c.Destination as Destination,c.TravelState as TravelState,a.UserID as UserID,c.TotalTravelAmount as TotalTravelAmount, d.Status as Status,b.Name as Name,b.LastName as LastName,b.Department as Department FROM [TravelExpenses].[dbo].[Supervisor_Employee] as a inner join [TravelExpenses].[dbo].[User] as b on a.UserID = b.UserID inner join TravelExpenses.dbo.Travel as c on c.UserID = a.UserID inner join TravelExpenses.dbo.TravelStatus as d on d.TravelID = c.TravelID  inner join TravelExpenses.dbo.TravelSignatures as e on c.TravelID = e.TravelID AND e.UserType = 'Accounting' inner join [TravelExpenses].[dbo].[User_Email_Title] as f on b.UserID = f.UserID where SupervisorID =  '" + CommonVariables.user + "' AND f.Active = 1 order by c.DepartureDate desc";
                }

                SqlCommand cmdAllDep = new SqlCommand(query, localCon);
                SqlDataReader cmdAllDepDR = cmdAllDep.ExecuteReader();
                while (cmdAllDepDR.Read())
                {
                    string travelID = cmdAllDepDR["TravelID"].ToString();
                    DateTime depDate = Convert.ToDateTime(cmdAllDepDR["DepartureDate"].ToString());
                    DateTime retDate = Convert.ToDateTime(cmdAllDepDR["ReturnDate"].ToString());
                    string travEvent = cmdAllDepDR["TravelEvent"].ToString();
                    string travPurpose = cmdAllDepDR["TravelPurpose"].ToString();
                    string origin = cmdAllDepDR["Origin"].ToString();
                    string destination = cmdAllDepDR["Destination"].ToString();
                    string travTotal = cmdAllDepDR["TotalTravelAmount"].ToString();
                    string status = cmdAllDepDR["Status"].ToString();
                    string userID = cmdAllDepDR["UserID"].ToString();
                    string name = cmdAllDepDR["Name"].ToString() + " " + cmdAllDepDR["Lastname"].ToString();
                    department = cmdAllDepDR["Department"].ToString();
                    //string reimb = cmdAllDepDR["TotalTravelReimbursed"].ToString();
                    dgvTravels.Rows.Add(depDate.ToShortDateString(), retDate.ToShortDateString(), travEvent, travPurpose, status, origin, destination, travTotal, travelID, userID, name, department);
                }
                cmdAllDepDR.Close();

                Guid userIDApproved = new Guid(CommonVariables.user);
                for (int i = 0; i < dgvTravels.RowCount; i++)
                {
                    Guid travIDApproved = new Guid(dgvTravels.Rows[i].Cells[8].Value.ToString());

                    if (userTitle == "Executive Director")
                    {
                        aprovQuery = "SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' And UserType = 'Supervisor' AND TravelID = '" + travIDApproved + "' AND (UserID = '" + userIDApproved + "' or UserID ='"+ asstDirectorID +"')";
                    }
                    else 
                    {
                        aprovQuery = "SELECT * FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' And UserType = 'Supervisor' AND TravelID = '" + travIDApproved + "' AND UserID = '" + userIDApproved + "'";
                    }


                    SqlCommand supApproved = new SqlCommand(aprovQuery, localCon);
                    SqlDataReader supApprovedDR = supApproved.ExecuteReader();
                    if (supApprovedDR.HasRows)
                    {
                        dgvTravels.Rows[i].Cells[12].Value = "Yes";
                    }
                    else
                    {
                        dgvTravels.Rows[i].Cells[12].Value = "No";
                    }
                    supApprovedDR.Close();
                }
            }
            else {
                selectTravels();
            }
            localCon.Close();
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (cantR > 0)
            {

                generatePDF();
                ViewPDF vpdf = new ViewPDF();
                vpdf.Show();
            }
            else
            {
                MessageBox.Show("There are no travels on the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSupervisorAppr_Click(object sender, EventArgs e)
        {
            if (cantR > 0)
            {
                localCon.Open();
                int rowIndex = dgvTravels.CurrentRow.Index;
                string travIDValue = dgvTravels.Rows[rowIndex].Cells[8].Value.ToString();
                travUserIDValue = dgvTravels.Rows[rowIndex].Cells[9].Value.ToString();
                depDate = Convert.ToDateTime(dgvTravels.Rows[rowIndex].Cells[0].Value.ToString());
                retDate = Convert.ToDateTime(dgvTravels.Rows[rowIndex].Cells[1].Value.ToString());
                travEvent = dgvTravels.Rows[rowIndex].Cells[2].Value.ToString();
                destination = dgvTravels.Rows[rowIndex].Cells[5].Value.ToString();
                email = "";


                Guid travID = new Guid(travIDValue);
                bool isApproved = false;
                Guid userID = new Guid(CommonVariables.user);
                Guid travUserID = new Guid(travUserIDValue);

                //get reimbursement amount
                double reimb = 0;
                SqlCommand reim = new SqlCommand("SELECT  TotalTravelReimbursed FROM [TravelExpenses].[dbo].[Travel] where TravelID = '"+ travID + "'", localCon);
                SqlDataReader reimDR = reim.ExecuteReader();
                while (reimDR.Read())
                {
                    reimb = Convert.ToDouble(reimDR["TotalTravelReimbursed"].ToString());
                }
                reimDR.Close();

                //verify if this user already approved the travel
                SqlCommand cmd = new SqlCommand("SELECT [TravelID],[UserID],[UserType],[TravelType] FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelID = '" + travID + "'  AND UserType = 'Supervisor' AND TravelType = 'Travel'", localCon);
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
                    da.InsertCommand.Parameters.Add("@UserType", SqlDbType.VarChar).Value = "Supervisor";
                    da.InsertCommand.Parameters.Add("@TravelType", SqlDbType.VarChar).Value = "Travel";
                    da.InsertCommand.Parameters.Add("@SignatureDate", SqlDbType.DateTime).Value = DateTime.Today;
                    int row = da.InsertCommand.ExecuteNonQuery();
                    if (row > 0)
                    {
                        //make travel final if there is not reimbursement
                        if (reimb <= 0)
                        {
                            SqlDataAdapter ra = new SqlDataAdapter();
                            ra.UpdateCommand = new SqlCommand("UPDATE [dbo].[TravelStatus] SET [Status] = @Status WHERE TravelID = '" + travID + "'", localCon);
                            ra.UpdateCommand.Parameters.Add("@Status", SqlDbType.VarChar).Value = "Final";
                            ra.UpdateCommand.ExecuteNonQuery();
                        }

                        pictureBox1.Visible = true;
                        lblInfo.Visible = true;
                        tableLayoutPanel2.Enabled = false;
                        dgvTravels.Enabled = false;
                        tableLayoutPanel3.Enabled = false;

                        //adding to the history trace table
                        Guid loginUser = new Guid(CommonVariables.user);
                        SqlDataAdapter tadpt = new SqlDataAdapter();
                        tadpt.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User_History_Trace] ([UserID],[Action],[Date]) VALUES (@UserID ,@Action,@Date)", localCon);
                        tadpt.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = loginUser;
                        tadpt.InsertCommand.Parameters.Add("@Action", SqlDbType.NVarChar).Value = "Travel Expense Report Approved by Supervisor";
                        tadpt.InsertCommand.Parameters.Add("@Date", SqlDbType.NVarChar).Value = DateTime.Now;
                        tadpt.InsertCommand.ExecuteNonQuery();

                        localCon.Close();
                        MessageBox.Show("This travel has been successfully approved by the Supervisor", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (backgroundWorker1.IsBusy != true)
                        {
                            backgroundWorker1.RunWorkerAsync();
                        }
                        
                    }

                }
               
            }
            else
            {
                MessageBox.Show("There are no travels on the list", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            localCon.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            sendNotifications();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Visible = false;
            lblInfo.Visible = false;
            tableLayoutPanel2.Enabled = true;
            dgvTravels.Enabled = true;
            tableLayoutPanel3.Enabled = true;
            refreshTravels();

        }

        private void sendNotifications()
        {
            
            localCon.Open();
            string username = "";
            string accEmail = "";
            Guid idUser = new Guid(travUserIDValue);
            SqlCommand userInfo = new SqlCommand("SELECT [Name],[LastName] FROM [TravelExpenses].[dbo].[User] where UserID = '"+ idUser + "'", localCon);
            SqlDataReader userInfoDR = userInfo.ExecuteReader();
            while (userInfoDR.Read())
            {
                username = userInfoDR["Name"].ToString() + " " + userInfoDR["LastName"].ToString();
            }
            userInfoDR.Close();

            SqlCommand accEmailSearch = new SqlCommand("SELECT [Email] FROM [TravelExpenses].[dbo].[User_Email_Title] where Title = 'Accounting Processor'", localCon);
            SqlDataReader accEmailSearchDR = accEmailSearch.ExecuteReader();
            if (accEmailSearchDR.HasRows)
            {
                while (accEmailSearchDR.Read())
                {
                    accEmail = accEmailSearchDR["Email"].ToString();
                }
            }
            accEmailSearchDR.Close();

            localCon.Close();

            SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org", 587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
            SmtpServer.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("travelAlert@lcmcd.org");
            mail.To.Add(email);
            mail.Subject = "Your travel was approved by your Supervisor";

            MailMessage mailAcc = new MailMessage();
            mailAcc.From = new MailAddress("travelAlert@lcmcd.org");
            mailAcc.To.Add(accEmail);
            mailAcc.Subject = "Approvals Completed travel for " + username;


            if (depDate.ToShortDateString() == retDate.ToShortDateString())
            {
                mail.Body = "Your travel for the " + depDate.ToShortDateString() + " in order to " + "attend to " + travEvent + " event, arriving to " + destination + ", was approved by your Supervisor";
                mailAcc.Body = "Travel event: " + travEvent + " on " + depDate.ToShortDateString();
            }
            else
            {
                mail.Body = "Your travel for the " + depDate.ToShortDateString() + " to " + retDate.ToShortDateString() + " in order to attend to " + travEvent + " event, arriving to " + destination + ", was approved by your Supervisor";
                mailAcc.Body = "Travel event: " + travEvent + " from " + depDate.ToShortDateString() + " to " + retDate.ToShortDateString();

            }

            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            try
            {
                SmtpServer.Send(mail);
                SmtpServer.Send(mailAcc);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnHideApproved_Click(object sender, EventArgs e)
        {
            if (hideApproved)
            {
                for (int i = 0; i < dgvTravels.RowCount; i++)
                {
                    if (dgvTravels.Rows[i].Cells[12].Value.ToString() == "Yes")
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
                    if (dgvTravels.Rows[i].Cells[12].Value.ToString() == "Yes")
                    {
                        dgvTravels.Rows[i].Visible = false;
                    }
                }
                hideApproved = true;
            }
        }
    }
}
