using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelExpenses
{
    public partial class Login : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string user;
        int accesslevel;
        public Login()
        {
            InitializeComponent();
            user = CommonVariables.user;
            accesslevel = CommonVariables.accessLevel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            localCon.Open();
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string email = "";
            bool active = false;
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT  a.UserID as UserID, a.AccessLevel as AccessLevel,b.Email as Email,b.Active as Active FROM [TravelExpenses].[dbo].[User] as a inner join [TravelExpenses].[dbo].[User_Email_Title] as b on b.UserID = a.UserID where Username = '" + username + "' AND Password = '" + password + "' AND b.Active = '1'", localCon);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    user = dr["UserID"].ToString();
                    accesslevel = Convert.ToInt32(dr["AccessLevel"].ToString());
                    email = dr["Email"].ToString();
                    active = Convert.ToBoolean(dr["Active"].ToString());

                }
                dr.Close();

                if (user != "" && active)
                {
                    CommonVariables.user = user;
                    CommonVariables.userEmail = email;
                    Guid loginUser = new Guid(user);
                    SqlDataAdapter tadpt = new SqlDataAdapter();
                    tadpt.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User_History_Trace] ([UserID],[Action],[Date]) VALUES (@UserID ,@Action,@Date)", localCon);
                    tadpt.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = loginUser;
                    tadpt.InsertCommand.Parameters.Add("@Action", SqlDbType.NVarChar).Value = "Login";
                    tadpt.InsertCommand.Parameters.Add("@Date", SqlDbType.NVarChar).Value = DateTime.Now;
                    tadpt.InsertCommand.ExecuteNonQuery();


                    localCon.Close();
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    Main m = new Main();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    if (!active)
                    {
                        MessageBox.Show("The account is not active. Contact the administrator", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("The username or password is incorrect", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    txtPassword.Text = "";
                    txtUsername.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            localCon.Close();
            txtPassword.Text = "";
            txtUsername.Text = "";


            /* Main m = new Main();
             m.Show();
             this.Hide();*/
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            Sync sc = new Sync();
            sc.ShowDialog();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            frmResetPassword rp = new frmResetPassword();
            this.Hide();
            rp.ShowDialog();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            CreateNewAccount cna = new CreateNewAccount();
            this.Hide();
            cna.ShowDialog();
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
