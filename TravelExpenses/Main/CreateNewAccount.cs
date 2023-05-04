using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
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
    public partial class CreateNewAccount : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        bool hasSignature = false;
        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            this.Close();
            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                if (frm.Name == "Login")
                {
                    frm.Show();
                }
            }
        }

        private void CreateNewAccount_Load(object sender, EventArgs e)
        {
            string name = "";
            string id = "";
            localCon.Open();
            SqlCommand sup = new SqlCommand("SELECT  a.UserID as UserID,[Name],[LastName] FROM [dbo].[User] as a inner join User_Email_Title as b on a.UserID = b.UserID where a.AccessLevel < 3 AND b.Active = 1 order by a.Name", localCon);
            SqlDataReader drSup = sup.ExecuteReader();
            cbSupervisor.DisplayMember = "Text";
            cbSupervisor.ValueMember = "Value";
            List<Object> items = new List<object>();
            while (drSup.Read())
            {
                name = drSup["Name"].ToString() + " " + drSup["LastName"].ToString();
                id = drSup["UserID"].ToString();
                items.Add(new { Text = name, Value = id });
            }
            drSup.Close();
            items.Add(new { Text = "Select your Supervisor", Value = "-1" });
            cbSupervisor.DataSource = items;
            cbSupervisor.SelectedValue = "-1";
            localCon.Close();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                string name = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string district = cbDistrict.SelectedItem.ToString();
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string department = cbDepartment.SelectedItem.ToString();
                string email = txtEmail.Text;
                string title = "Regular Employee";
                int accessLevel = 3;
                if (chxSupervisor.Checked)
                {
                    title = "Supervisor";
                    accessLevel = 2;
                }
                try
                {
                    Guid idInserted;
                    Object idInsert;
                    string id = "";
                    localCon.Open();
                    SqlDataAdapter cmd = new SqlDataAdapter();
                    cmd.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User] (Name, LastName, District, Department, Username, Password, AccessLevel) OUTPUT INSERTED.UserID,'" + email + "','" + title + "','0' INTO [TravelExpenses].[dbo].[User_Email_Title] (UserID,Email,Title,Active) VALUES (@Name,@LastName,@District,@Department,@Username,@Password,@AccessLevel)", localCon);
                    cmd.InsertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
                    cmd.InsertCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = lastName;
                    cmd.InsertCommand.Parameters.Add("@District", SqlDbType.VarChar).Value = district;
                    cmd.InsertCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                    cmd.InsertCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                    cmd.InsertCommand.Parameters.Add("@AccessLevel", SqlDbType.Int).Value = accessLevel;
                    cmd.InsertCommand.Parameters.Add("@Department", SqlDbType.VarChar).Value = department;

                    cmd.InsertCommand.ExecuteScalar();
                    SqlCommand selectIns = new SqlCommand("SELECT  [UserID] FROM [TravelExpenses].[dbo].[User] where Name ='" + name + "'  AND LastName ='" + lastName + "' AND Department = '" + department + "' AND Username = '" + username + "'", localCon);
                    SqlDataReader dr = selectIns.ExecuteReader();
                    while (dr.Read())
                    {
                        id = dr["UserID"].ToString();
                    }
                    dr.Close();
                    idInserted = new Guid(id);


                    if (CommonVariables.signatureText != "")
                    {
                        SqlDataAdapter cmd2 = new SqlDataAdapter();
                        cmd2.InsertCommand = new SqlCommand("INSERT INTO [dbo].[UserSignature] ([UserID],[FontType],[SignatureText]) VALUES (@UserID,@FontType,@SignatureText)", localCon);
                        cmd2.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = idInserted;
                        cmd2.InsertCommand.Parameters.Add("@FontType", SqlDbType.VarChar).Value = CommonVariables.signatureFont;
                        cmd2.InsertCommand.Parameters.Add("@SignatureText", SqlDbType.VarChar).Value = CommonVariables.signatureText;
                        cmd2.InsertCommand.ExecuteNonQuery();
                    }

                    Guid supID = new Guid(cbSupervisor.SelectedValue.ToString());
                    SqlDataAdapter sup = new SqlDataAdapter();
                    sup.InsertCommand = new SqlCommand("INSERT INTO [dbo].[Supervisor_Employee]  ([UserID] ,[SupervisorID]) VALUES (@UserID,@SupervisorID)", localCon);
                    sup.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = idInserted;
                    sup.InsertCommand.Parameters.Add("@SupervisorID", SqlDbType.UniqueIdentifier).Value = supID;
                    sup.InsertCommand.ExecuteNonQuery();

                    localCon.Close();

                    MessageBox.Show("User inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (backgroundWorker1.IsBusy != true)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                    this.Close();

                    FormCollection fc = Application.OpenForms;
                    Form main = new Form();
                    foreach (Form frm in fc)
                    {
                        if (frm.Name == "Login")
                        {
                            frm.Show();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool validateData()
        {
            if (txtFirstName.Text == "")
            {
                errorProvider1.SetError(txtFirstName, "Provide a first name.");
                pictureBox1.Visible = true;
                lblErrorWarnings.Visible = true;
                return false;
            }
            else 
            {
                errorProvider1.SetError(txtFirstName, null);
            }
            if (txtLastName.Text == "")
            {
                errorProvider1.SetError(txtLastName, "Provide a last name.");
                pictureBox1.Visible = true;
                lblErrorWarnings.Visible = true;
                return false;
            }
            else 
            {
                errorProvider1.SetError(txtLastName, null);
            }
            if (cbDistrict.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbDistrict, "Select a district.");
                pictureBox1.Visible = true;
                lblErrorWarnings.Visible = true;
                return false;
            }
            else
            {
                errorProvider1.SetError(cbDistrict, null);
            }
            if (cbDepartment.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbDepartment, "Select a department.");
                pictureBox1.Visible = true;
                lblErrorWarnings.Visible = true;
                return false;
            }
            else
            {
                errorProvider1.SetError(cbDepartment, null);
            }
            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Provide a username.");
                pictureBox1.Visible = true;
                lblErrorWarnings.Visible = true;
                return false;
            }
            else 
            {
                errorProvider1.SetError(txtUsername, null);
            }
            if (txtPassword.Text == "")
            {
                errorProvider1.SetError(txtPassword, "Provide a password.");
                pictureBox1.Visible = true;
                lblErrorWarnings.Visible = true;
                return false;
            }
            else 
            {
                errorProvider1.SetError(txtPassword, null);
            }
            if (txtEmail.Text == "")
            {
                errorProvider1.SetError(txtEmail, "Provide an email.");
                pictureBox1.Visible = true;
                lblErrorWarnings.Visible = true;
                return false;
            }
            else 
            {
                errorProvider1.SetError(txtEmail, null);
            }
            
            if (cbSupervisor.SelectedValue.ToString() == "-1")
            {
                errorProvider1.SetError(cbSupervisor, "Select a supervisor.");
                pictureBox1.Visible = true;
                lblErrorWarnings.Visible = true;
                return false;
            }
            else 
            {
                errorProvider1.SetError(cbSupervisor, null);
            }
            if (!IsValidEmail(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "The email does not have a correct format.");
                pictureBox1.Visible = true;
                lblErrorWarnings.Visible = true;
                return false;
            }
            else 
            {
                errorProvider1.SetError(txtEmail, null);
            }
            if (CommonVariables.signatureText == "")
            {
                errorProvider1.SetError(btnSiganture, "Create a signature");
                pictureBox1.Visible = true;
                lblErrorWarnings.Visible = true;
                return false;
            }
            else 
            {
                errorProvider1.SetError(btnSiganture, null);
            }
            localCon.Open();
            bool emailInUse = false;
            SqlCommand checkEmail = new SqlCommand("SELECT [UserID] FROM [TravelExpenses].[dbo].[User_Email_Title] where Email = '" + txtEmail.Text + "'", localCon);
            SqlDataReader checkEmailDR = checkEmail.ExecuteReader();
            if (checkEmailDR.HasRows)
            {
                while (checkEmailDR.Read())
                {
                    emailInUse = true;
                }
            }
            checkEmailDR.Close();
            bool usernameInUse = false;
            SqlCommand checkUsername = new SqlCommand("SELECT *  FROM [TravelExpenses].[dbo].[User] where Username = '"+ txtUsername.Text +"'", localCon);
            SqlDataReader checkUsernameDR = checkUsername.ExecuteReader();
            if (checkUsernameDR.HasRows)
            {
                while (checkUsernameDR.Read())
                {
                    usernameInUse = true;
                }
            }
            checkUsernameDR.Close();
            localCon.Close();
            if (emailInUse)
            {
                errorProvider1.SetError(txtEmail, "There is already an account with this email, please try to login or reset your password.");
                pictureBox1.Visible = true;
                lblErrorWarnings.Visible = true;
                return false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
            if (usernameInUse)
            {
                errorProvider1.SetError(txtUsername, "This username is in use, please select another one.");
                pictureBox1.Visible = true;
                lblErrorWarnings.Visible = true;
                return false;
            }
            else 
            {
                errorProvider1.SetError(txtUsername, null);
            }
            pictureBox1.Visible = false;
            lblErrorWarnings.Visible = false;
            return true;
        }

        private bool IsValidEmail(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }

        private void btnSiganture_Click(object sender, EventArgs e)
        {
            CreateSignature cs = new CreateSignature();
            cs.ShowDialog();
        }

        private void sendEmail()
        {

            SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org", 587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
            SmtpServer.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("travelAlert@lcmcd.org");
            mail.To.Add(txtEmail.Text);
            mail.Subject = "Travel Program Account Created";
            mail.Body = "Hi " + txtFirstName.Text + ", your account on the travel program was created. The admin will verify your information and activate the account, you will recive an email when it is active. Thanks";

            MailMessage mail2 = new MailMessage();
            mail2.From = new MailAddress("travelAlert@lcmcd.org");
            mail2.To.Add("alfonso@lcmcd.org");
            mail2.Subject = "Travel Program Account Needs Activation";
            mail2.Body = "A new account was created under the name: " + txtFirstName.Text + " " + txtLastName.Text + " and the email: " + txtEmail.Text + ". Please activate it.";

            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            try
            {
                SmtpServer.Send(mail);
                SmtpServer.Send(mail2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            sendEmail();
        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
