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
    public partial class SupervisorList : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        public SupervisorList()
        {
            InitializeComponent();
        }

        private void SupervisorList_Load(object sender, EventArgs e)
        {
            localCon.Open();
            SqlCommand em = new SqlCommand("SELECT b.Email as Email, a.Name as Name, a.LastName as LastName, a.Department as Department  FROM [TravelExpenses].[dbo].[User] as a inner join TravelExpenses.dbo.User_Email_Title as b on b.UserID = a.UserID where AccessLevel <= 2 order by a.LastName", localCon);
            SqlDataReader emDR = em.ExecuteReader();
            if (emDR.HasRows)
            {
                cbSupervisors.DisplayMember = "Text";
                cbSupervisors.ValueMember = "Value";
                List<Object> items = new List<object>();
                while (emDR.Read())
                {
                    string name = emDR["LastName"].ToString() + " " + emDR["Name"].ToString();
                    string id = emDR["Email"].ToString();
                    items.Add(new { Text = name, Value = id });


                }
                cbSupervisors.DataSource = items;
            }

            emDR.Close();
            localCon.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CommonVariables.supervisorEmail = cbSupervisors.SelectedValue.ToString();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
