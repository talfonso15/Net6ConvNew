using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace TravelExpenses
{
    public partial class frmResetPassword : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid userUp;
        bool userExist = false;
        string randomCode = "";
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {if (txtEmail.Text != "")
            {
                if (IsValidEmail(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, null);
                    try 
                    {
                        localCon.Open();
                        SqlCommand userCMD = new SqlCommand("SELECT [UserID] FROM [TravelExpenses].[dbo].[User_Email_Title] where Email = '"+ txtEmail.Text +"' AND Active = '1'", localCon);
                        SqlDataReader userDR  = userCMD.ExecuteReader();
                        if (userDR.HasRows)
                        {
                            while (userDR.Read())
                            {
                                userUp = new Guid(userDR["UserID"].ToString());
                                userExist = true;
                            }
                        }
                        userDR.Close();
                        localCon.Close();

                        if (userExist)
                        {
                            errorProvider1.SetError(txtEmail, null);
                            Random rand = new Random();
                            randomCode = (rand.Next(999999)).ToString();
                            
                            pictureBox1.Visible = true;
                            lblSendingEmails.Visible = true;
                            gbVerificationCode.Enabled = false;
                            if (backgroundWorker1.IsBusy != true)
                            {
                                backgroundWorker1.RunWorkerAsync();
                            }

                        }
                        else 
                        {
                            txtEmail.Focus();
                            errorProvider1.SetError(txtEmail, "There is not user associated with this email or the user is not active.");
                        }
                    } 
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message); 
                    }
                }
                else 
                {
                    txtEmail.Focus();
                    errorProvider1.SetError(txtEmail, "The email format is not correct.");
                }
            }
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

        private void btnClose_Click(object sender, EventArgs e)
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

        private void sendEmail()
        {

            SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org", 587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
            SmtpServer.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("travelAlert@lcmcd.org");
            mail.To.Add(txtEmail.Text);
            mail.Subject = "Travel Program Password Reset Verification Code";
            mail.Body = "The Verification Code for resetting your password is: " + randomCode + ". Please enter this code on the program in order to reset your password. Thanks";

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
            sendEmail();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblSendingEmails.Visible = false;
            pictureBox1.Visible = false;
            gbVerificationCode.Enabled = true;
        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            if (txtVerificationCOde.Text != "")
            {
                errorProvider1.SetError(txtVerificationCOde, null);
                if (txtVerificationCOde.Text == randomCode)
                {
                    gbResetPassword.Enabled = true;
                    btnResetPassword.Enabled = true;
                    gbVerificationCode.Enabled = false;
                }
                else 
                {
                    txtVerificationCOde.Focus();
                    errorProvider1.SetError(txtVerificationCOde, "The code does not match the one we sent you.");
                    gbResetPassword.Enabled = false;
                    btnResetPassword.Enabled = false;
                    gbVerificationCode.Enabled = true;
                }
            }
            else 
            {
                txtVerificationCOde.Focus();
                errorProvider1.SetError(txtVerificationCOde, "The verification code can't be empty.");
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text != "" && txtConfirmPassword.Text != "")
            {
                if (txtConfirmPassword.Text == txtNewPassword.Text)
                {
                    try
                    {
                        string currentPassword = "";
                        localCon.Open();
                        SqlCommand pass = new SqlCommand("SELECT [Password] FROM [TravelExpenses].[dbo].[User] where UserID = '" + userUp + "'", localCon);
                        SqlDataReader passDR = pass.ExecuteReader();
                        if (passDR.HasRows)
                        {
                            while (passDR.Read())
                            {
                                currentPassword = passDR["Password"].ToString();
                            }
                        }
                        passDR.Close();
                        localCon.Close();

                        if (currentPassword != "")
                        {
                            if (currentPassword == txtNewPassword.Text)
                            {
                                errorProvider1.SetError(txtNewPassword, "Your new password can't be the same as the current one.");
                            }
                            else
                            {
                                errorProvider1.SetError(txtNewPassword, null);
                                
                                    errorProvider1.SetError(txtConfirmPassword, null);
                                    SqlDataAdapter upPass = new SqlDataAdapter();
                                    localCon.Open();
                                    upPass.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[User] SET [Password] = @Password WHERE UserID = '" + userUp + "'", localCon);
                                    upPass.UpdateCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtNewPassword.Text;
                                    int updated = upPass.UpdateCommand.ExecuteNonQuery();
                                    localCon.Close();
                                    if (updated > 0)
                                    {
                                        MessageBox.Show("Password reset successfully.");
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
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else 
                {
                    txtConfirmPassword.Focus();
                    errorProvider1.SetError(txtConfirmPassword, "This password does not match with the one above.");
                }
            }
            else 
            {
                if (txtNewPassword.Text == "")
                {
                    errorProvider1.SetError(txtNewPassword, "Please provide a password.");
                }
                else 
                {
                    errorProvider1.SetError(txtNewPassword, null);
                }
                if (txtConfirmPassword.Text == "")
                {
                    errorProvider1.SetError(txtConfirmPassword, "Please confirm the password.");
                }
                else 
                {
                    errorProvider1.SetError(txtConfirmPassword, null);
                }
            }
        }
    }
}
