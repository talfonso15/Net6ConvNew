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

namespace TravelExpenses
{
    public partial class EditPassword : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid ui = new Guid(CommonVariables.user);
        public EditPassword()
        {
            InitializeComponent();
        }

        private void EditPassword_Load(object sender, EventArgs e)
        {
            localCon.Open();
            
            SqlCommand cmdUser = new SqlCommand("SELECT [Username] ,[Password] FROM [TravelExpenses].[dbo].[User] where UserID = '"+ ui + "'", localCon);
            SqlDataReader dr = cmdUser.ExecuteReader();
            while (dr.Read()) {
                lblUsernameValue.Text = dr["Username"].ToString();
                txtPassword.Text = dr["Password"].ToString();
            }
            localCon.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                localCon.Open();
                SqlDataAdapter cmdEditUser = new SqlDataAdapter();
                cmdEditUser.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[User] SET [Password] = @Password  WHERE UserID = '" + ui + "'", localCon);
                cmdEditUser.UpdateCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtPassword.Text;
                int ra = cmdEditUser.UpdateCommand.ExecuteNonQuery();
                if (ra > 0)
                {
                    MessageBox.Show("Password changed successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                localCon.Close();
                this.Close();
            }
            else {
                MessageBox.Show("Your password is empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
