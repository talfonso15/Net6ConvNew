//using Org.BouncyCastle.X509; //commented for net6
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace TravelExpenses
{
    public partial class CFOReview : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string type = "";
        int rowIndex = 0;
        bool isfirst = true;
        public CFOReview()
        {
            InitializeComponent();
        }

        private void btnEmailDirector_Click(object sender, EventArgs e)
        {
            if (dgvEstimates.RowCount > 0)
            {
                pictureBox1.Image = TravelExpenses.Properties.Resources.image_1229052;
                lblEmailSending.Text = "Sending Email to Director.....";
                pictureBox1.Visible = true;
                lblEmailSending.Visible = true;
                type = "Director";

                int index = dgvEstimates.CurrentRow.Index;
                rowIndex = index;
                Guid estID = new Guid(dgvEstimates.Rows[index].Cells[7].Value.ToString());
                localCon.Open();
                SqlDataAdapter upStat = new SqlDataAdapter();
                upStat.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[EstimateTravel_Status] SET [Status] = @Status WHERE TravelEstimateID = '" + estID + "'", localCon);
                upStat.UpdateCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Sent for Director Approval";
                int updated = upStat.UpdateCommand.ExecuteNonQuery();
                localCon.Close();

                dgvEstimates.Enabled = false;
                tlpOptions.Enabled = false;

                if (backgroundWorker1.IsBusy != true)
                {
                    backgroundWorker1.RunWorkerAsync();
                }

            }
            
        }

        private void CFOReview_Load(object sender, EventArgs e)
        {
            localCon.Open();
            DateTime departureDate = DateTime.Today;
            DateTime retDate = DateTime.Today;
            string travelEvent = "";
            string travelPurpose = "";
            string user = "";
            string userID = "";
            bool budgeted;
            string total = "";
            string estimatedID = "";
            string status = "";
            //isfirst = true;

            SqlCommand sel = new SqlCommand("SELECT a.*,b.Status as ESTIMATE_STATUS,c.UserID as USERID,c.LastName as LASTNAME,c.Name as NAME FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join TravelExpenses.dbo.EstimateTravel_Status as b on a.TravelEstimateID = b.TravelEstimateID inner join TravelExpenses.dbo.[User] as c on a.UserID = c.UserID where b.Status = 'Pending CFO' or b.Status = 'Pending Director Email'", localCon);
            SqlDataReader selDR = sel.ExecuteReader();
            while (selDR.Read())
            {
                departureDate = Convert.ToDateTime(selDR["DepartureDate"].ToString());
                retDate = Convert.ToDateTime(selDR["ReturnDate"].ToString());
                travelEvent = selDR["TravelEvent"].ToString();
                travelPurpose = selDR["TravelPurpose"].ToString();
                user = selDR["NAME"].ToString() + " " + selDR["LASTNAME"].ToString();
                userID = selDR["USERID"].ToString();
                budgeted = Convert.ToBoolean(selDR["BudgetedTravel"].ToString());
                total = selDR["EstimatedTravelCost"].ToString();
                estimatedID = selDR["TravelEstimateID"].ToString();
                status = selDR["ESTIMATE_STATUS"].ToString();

                dgvEstimates.Rows.Add(departureDate.ToShortDateString(), retDate.ToShortDateString(), travelPurpose, travelEvent, budgeted, user, total, estimatedID, userID, status);
            }
            selDR.Close();
            localCon.Close();

            if (dgvEstimates.RowCount > 0)
            {
                int index = dgvEstimates.CurrentRow.Index;
                bool budg = Convert.ToBoolean(dgvEstimates.Rows[index].Cells[4].Value.ToString());
                if (budg)
                {
                    btnEmailDirector.Enabled = false;
                }
            }
            isfirst = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCFOApproval_Click(object sender, EventArgs e)
        {
            if (dgvEstimates.Rows.Count > 0)
            {
                int index = dgvEstimates.CurrentRow.Index;
                Guid estID = new Guid(dgvEstimates.Rows[index].Cells[7].Value.ToString());
                string status = dgvEstimates.Rows[index].Cells[9].Value.ToString();
                bool budgetedTrav = Convert.ToBoolean(dgvEstimates.Rows[index].Cells[4].Value.ToString());
                Guid userID = new Guid(dgvEstimates.Rows[index].Cells[8].Value.ToString());

                if (status == "Pending Director Email")
                {
                    MessageBox.Show("This travel authorization was already reviewed by the CFO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (status == "Pending CFO")
                {
                    localCon.Open();
                    string cfoIDstr = "";
                    SqlCommand cfoIDsel = new SqlCommand("SELECT [UserID] FROM [TravelExpenses].[dbo].[User_Email_Title] where Title = 'CFO'", localCon);
                    SqlDataReader cfoIDDR = cfoIDsel.ExecuteReader();
                    while (cfoIDDR.Read())
                    {
                        cfoIDstr = cfoIDDR["UserID"].ToString();
                    }
                    cfoIDDR.Close();
                    Guid cfoID = new Guid(cfoIDstr);

                    //Insert the signature of the CFO
                    SqlDataAdapter cfoSign = new SqlDataAdapter();
                    cfoSign.InsertCommand = new SqlCommand("INSERT INTO [dbo].[TravelSignatures]([TravelID],[UserID],[UserType],[TravelType],[SignatureDate]) VALUES (@TravelID,@UserID ,@UserType ,@TravelType,@SignatureDate)", localCon);
                    cfoSign.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = estID;
                    cfoSign.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = cfoID;
                    cfoSign.InsertCommand.Parameters.Add("@UserType", SqlDbType.NVarChar).Value = "CFO";
                    cfoSign.InsertCommand.Parameters.Add("@TravelType", SqlDbType.NVarChar).Value = "Estimate";
                    cfoSign.InsertCommand.Parameters.Add("@SignatureDate", SqlDbType.DateTime).Value = DateTime.Today;
                    cfoSign.InsertCommand.ExecuteNonQuery();

                    if (budgetedTrav)
                    {
                        SqlDataAdapter upStat = new SqlDataAdapter();
                        upStat.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[EstimateTravel_Status] SET [Status] = @Status WHERE TravelEstimateID = '" + estID + "'", localCon);
                        upStat.UpdateCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Final";
                        int updated = upStat.UpdateCommand.ExecuteNonQuery();
                        if (updated > 0)
                        {
                            //adding to the history trace table
                            Guid loginUser = new Guid(CommonVariables.user);
                            SqlDataAdapter tadpt = new SqlDataAdapter();
                            tadpt.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User_History_Trace] ([UserID],[Action],[Date]) VALUES (@UserID ,@Action,@Date)", localCon);
                            tadpt.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = loginUser;
                            tadpt.InsertCommand.Parameters.Add("@Action", SqlDbType.NVarChar).Value = "CFO Approved and Signed Travel Authorization";
                            tadpt.InsertCommand.Parameters.Add("@Date", SqlDbType.NVarChar).Value = DateTime.Now;
                            tadpt.InsertCommand.ExecuteNonQuery();
                            

                            MessageBox.Show("The travel authorization has been reviewed by the CFO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                        }
                    }
                    else
                    {
                        SqlDataAdapter upStat = new SqlDataAdapter();
                        upStat.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[EstimateTravel_Status] SET [Status] = @Status WHERE TravelEstimateID = '" + estID + "'", localCon);
                        upStat.UpdateCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Sent for Director Approval";
                        int updated = upStat.UpdateCommand.ExecuteNonQuery();
                        if (updated > 0)
                        {
                            //adding to the history trace table
                            Guid loginUser = new Guid(CommonVariables.user);
                            SqlDataAdapter tadpt = new SqlDataAdapter();
                            tadpt.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User_History_Trace] ([UserID],[Action],[Date]) VALUES (@UserID ,@Action,@Date)", localCon);
                            tadpt.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = loginUser;
                            tadpt.InsertCommand.Parameters.Add("@Action", SqlDbType.NVarChar).Value = "CFO Approved and Signed Travel Authorization";
                            tadpt.InsertCommand.Parameters.Add("@Date", SqlDbType.NVarChar).Value = DateTime.Now;
                            tadpt.InsertCommand.ExecuteNonQuery();

                            MessageBox.Show("The travel authorization has been reviewed by the CFO", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                    }
                    pictureBox1.Image = TravelExpenses.Properties.Resources.image_1229052;
                    //lblEmailSending.Text = "Sending Email to Employee.....";
                    pictureBox1.Visible = true;
                    lblEmailSending.Visible = true;
                    dgvEstimates.Enabled = false;
                    tlpOptions.Enabled = false;
                    //type = "Employee";
                    localCon.Close();
                    if (backgroundWorker1.IsBusy != true)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                    
                }

            }
        }

        

        private void dgvEstimates_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void updateDGV()
        {
            dgvEstimates.Rows.Clear();
            localCon.Open();
            DateTime departureDate = DateTime.Today;
            DateTime retDate = DateTime.Today;
            string travelEvent = "";
            string travelPurpose = "";
            string user = "";
            string userID = "";
            bool budgeted;
            string total = "";
            string estimatedID = "";
            string status = "";

            SqlCommand sel = new SqlCommand("SELECT a.*,b.Status as ESTIMATE_STATUS,c.UserID as USERID,c.LastName as LASTNAME,c.Name as NAME FROM [TravelExpenses].[dbo].[EstimateTravel] as a inner join TravelExpenses.dbo.EstimateTravel_Status as b on a.TravelEstimateID = b.TravelEstimateID inner join TravelExpenses.dbo.[User] as c on a.UserID = c.UserID where b.Status = 'Pending CFO' or b.Status = 'Pending Director Email'", localCon);
            SqlDataReader selDR = sel.ExecuteReader();
            while (selDR.Read())
            {
                departureDate = Convert.ToDateTime(selDR["DepartureDate"].ToString());
                retDate = Convert.ToDateTime(selDR["ReturnDate"].ToString());
                travelEvent = selDR["TravelEvent"].ToString();
                travelPurpose = selDR["TravelPurpose"].ToString();
                user = selDR["NAME"].ToString() + " " + selDR["LASTNAME"].ToString();
                userID = selDR["USERID"].ToString();
                budgeted = Convert.ToBoolean(selDR["BudgetedTravel"].ToString());
                total = selDR["EstimatedTravelCost"].ToString();
                estimatedID = selDR["TravelEstimateID"].ToString();
                status = selDR["ESTIMATE_STATUS"].ToString();

                dgvEstimates.Rows.Add(departureDate.ToShortDateString(), retDate.ToShortDateString(), travelPurpose, travelEvent, budgeted, user, total, estimatedID, userID, status);
            }
            selDR.Close();
            localCon.Close();
            if (dgvEstimates.Rows.Count > 0)
            {
                int index = dgvEstimates.CurrentRow.Index;
                bool budg = Convert.ToBoolean(dgvEstimates.Rows[index].Cells[4].Value.ToString());
                if (budg)
                {
                    btnEmailDirector.Enabled = false;
                }
                else
                {
                    btnEmailDirector.Enabled = true;
                }
            }
        }

        private void sendEmail()
        {
            
            int index = dgvEstimates.CurrentRow.Index;
            Guid estID = new Guid(dgvEstimates.Rows[index].Cells[7].Value.ToString());
            string status = "";
            bool budgetedTrav = Convert.ToBoolean(dgvEstimates.Rows[index].Cells[4].Value.ToString());
            string fullname = dgvEstimates.Rows[index].Cells[5].Value.ToString();
            string startDate = dgvEstimates.Rows[index].Cells[0].Value.ToString();
            string endDate = dgvEstimates.Rows[index].Cells[1].Value.ToString();
            string travelEvent = dgvEstimates.Rows[index].Cells[3].Value.ToString();
            Guid userID = new Guid(dgvEstimates.Rows[index].Cells[8].Value.ToString());
            string email = "";

            localCon.Open();
            SqlCommand emplEmail = new SqlCommand("SELECT [Email] FROM [dbo].[User_Email_Title] where UserID = '" + userID + "'", localCon);
            SqlDataReader dr = emplEmail.ExecuteReader();
            while (dr.Read())
            {
                email = dr["Email"].ToString();
            }
            dr.Close();
            SqlCommand selStatus = new SqlCommand("SELECT [Status] FROM [TravelExpenses].[dbo].[EstimateTravel_Status] where TravelEstimateID = '"+ estID + "'", localCon);
            SqlDataReader selStatusDR = selStatus.ExecuteReader();
            while (selStatusDR.Read())
            {
                status = selStatusDR["Status"].ToString();
            }
            selStatusDR.Close();

            string execDirectorEmail = "";
            string asstDirectorEmail = "";
            SqlCommand execDir = new SqlCommand("SELECT [Email] FROM [TravelExpenses].[dbo].[User_Email_Title] where Title = 'Executive Director'", localCon);
            SqlDataReader execDirDR = execDir.ExecuteReader();
            if (execDirDR.HasRows)
            {
                while (execDirDR.Read())
                {
                    execDirectorEmail = execDirDR["Email"].ToString();
                }
            }
            execDirDR.Close();

            SqlCommand asstDir = new SqlCommand("SELECT [Email] FROM [TravelExpenses].[dbo].[User_Email_Title] where Title = 'Assistant Director'", localCon);
            SqlDataReader asstDirDR = asstDir.ExecuteReader();
            if (asstDirDR.HasRows)
            {
                while (asstDirDR.Read())
                {
                    asstDirectorEmail = asstDirDR["Email"].ToString();
                }
            }asstDirDR.Close();

            localCon.Close();


            SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org", 587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
            SmtpServer.EnableSsl = true;

            MailMessage maild = new MailMessage();
            maild.From = new MailAddress("travelAlert@lcmcd.org");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("travelAlert@lcmcd.org");

            //Notify accounting
            /*MailMessage mailAcc = new MailMessage();
            if (status == "Final" && budgetedTrav)
            {
                mailAcc.From = new MailAddress("travelAlert@lcmcd.org");
                mailAcc.To.Add("collins@lcmcd.org");
                mailAcc.Subject = "Travel authorization form of " + fullname + " is completed.";
                if (startDate == endDate)
                {
                    mailAcc.Body = "The travel authorization form of " + fullname + " on " + startDate + " in order to " + "attend to " + travelEvent + " event, has been completed and approved by the CFO.";
                }
                else
                {
                    mailAcc.Body = "The travel authorization form of " + fullname + " from " + startDate + " to " + endDate + " in order to " + "attend to " + travelEvent + " event, has been completed and approved by the CFO.";
                }
            }*/
            
                mail.To.Add(email);
                mail.Subject = "Your travel authorization has been reviewed by the CFO";
                if (startDate == endDate)
                {
                    mail.Body = "Your travel authorizations for the travel on " + startDate + " in order to attend to " + travelEvent + " event,has been reviewed by the CFO.";
                }
                else
                {
                    mail.Body = "Your travel authorizations for the travel on " + startDate + " to " + endDate + " in order to attend to " + travelEvent + " event,has been reviewed by the CFO.";

                }

            if (!budgetedTrav)
            {
                maild.To.Add(execDirectorEmail);
                maild.To.Add(asstDirectorEmail);
                maild.Subject = "Please review the travel authorization of" + " " + fullname;
                if (startDate == endDate)
                {
                    maild.Body = "Please enter to the travel program and review the travel authorization of " + fullname + " on " + startDate + " in order to " + "attend to " + travelEvent + " event which is not budgeted. The CFO already approved it.";
                }
                else
                {
                    maild.Body = "Please enter to the travel program and review the travel authorization of " + fullname + " on " + startDate + " to " + endDate + " in order to attend to " + travelEvent + " event which is not budgeted. The CFO already approved it.";
                }
            }


            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, System.Security.Cryptography.X509Certificates.X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            try
            {
                SmtpServer.Send(mail);
                if (!budgetedTrav) 
                {
                    SmtpServer.Send(maild);
                }
               /* if (status == "Final" && budgetedTrav)
                {
                    SmtpServer.Send(mailAcc);
                }*/
                pictureBox1.Image = Properties.Resources.if_11_330397;
                

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            sendEmail();
            rowIndex = 0;
            
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblEmailSending.Text = "Done";
            pictureBox1.Visible = false;
            lblEmailSending.Visible = false;
            updateDGV();
            dgvEstimates.Enabled = true;
            tlpOptions.Enabled = true;


        }

        private void dgvEstimates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvEstimates.CurrentRow.Index;
            bool budgeted = Convert.ToBoolean(dgvEstimates.Rows[index].Cells[4].Value.ToString());
            if (budgeted)
            {
                btnEmailDirector.Enabled = false;
            }
            else
            {
                btnEmailDirector.Enabled = true;
            }
        }

        private void dgvEstimates_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!isfirst)
            {
                if (e.ColumnIndex == 4)
                {
                    bool budget = Convert.ToBoolean(dgvEstimates.Rows[e.RowIndex].Cells[4].Value.ToString());
                    string status = dgvEstimates.Rows[e.RowIndex].Cells[9].Value.ToString();
                    Guid estiID = new Guid(dgvEstimates.Rows[e.RowIndex].Cells[7].Value.ToString());
                    localCon.Open();
                    SqlDataAdapter upBud = new SqlDataAdapter();
                    upBud.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[EstimateTravel] SET  [BudgetedTravel] = @BudgetedTravel WHERE TravelEstimateID = '" + estiID + "'", localCon);
                    upBud.UpdateCommand.Parameters.Add("@BudgetedTravel", SqlDbType.Bit).Value = budget;
                    int up = upBud.UpdateCommand.ExecuteNonQuery();

                    if (budget && status == "Pending Director Email")
                    {
                        SqlDataAdapter upStat = new SqlDataAdapter();
                        upStat.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[EstimateTravel_Status] SET [Status] = @Status WHERE TravelEstimateID = '" + estiID + "'", localCon);
                        upStat.UpdateCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Final";
                        upStat.UpdateCommand.ExecuteNonQuery();
                    }

                    localCon.Close();
                    dgvEstimates.CommitEdit(DataGridViewDataErrorContexts.Commit);
                    int index = dgvEstimates.CurrentRow.Index;
                    bool budg = Convert.ToBoolean(dgvEstimates.Rows[index].Cells[4].Value.ToString());
                    if (budg)
                    {
                        btnEmailDirector.Enabled = false;
                    }
                    else
                    {
                        btnEmailDirector.Enabled = true;
                    }

                }
            }
        }

        private void dgvEstimates_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dgvEstimates_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dgvEstimates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvEstimates.RowCount > 0)
            {
                this.Hide();
                int rowIndex = dgvEstimates.CurrentRow.Index;
                string estID = dgvEstimates.Rows[rowIndex].Cells[7].Value.ToString();
                CommonVariables.viewEstimateId = estID;
                EstimateTravel et = new EstimateTravel();
                et.Text = "View Authorization Details";
                et.ShowDialog();
            }
        }

        private void dgvEstimates_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvEstimates.IsCurrentCellDirty)
            {
                dgvEstimates.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void sendEmailToDirector() 
        {
            if (dgvEstimates.RowCount > 0)
            {
                pictureBox1.Image = TravelExpenses.Properties.Resources.image_1229052;
                lblEmailSending.Text = "Sending Email to Director.....";
                pictureBox1.Visible = true;
                lblEmailSending.Visible = true;
                type = "Director";

                int index = dgvEstimates.CurrentRow.Index;
                rowIndex = index;
                Guid estID = new Guid(dgvEstimates.Rows[index].Cells[7].Value.ToString());
               // localCon.Open();
                SqlDataAdapter upStat = new SqlDataAdapter();
                upStat.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[EstimateTravel_Status] SET [Status] = @Status WHERE TravelEstimateID = '" + estID + "'", localCon);
                upStat.UpdateCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Sent for Director Approval";
                int updated = upStat.UpdateCommand.ExecuteNonQuery();
                //localCon.Close();

                dgvEstimates.Enabled = false;
                tlpOptions.Enabled = false;

                if (backgroundWorker1.IsBusy != true)
                {
                    backgroundWorker1.RunWorkerAsync();
                }

            }
        }
    }
}
