using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TravelExpenses
{
    public partial class UserHistory : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        public UserHistory()
        {
            InitializeComponent();
        }

        private void UserHistory_Load(object sender, EventArgs e)
        {
            cbUsers.DisplayMember = "Text";
            cbUsers.ValueMember = "Value";
            List<Object> items = new List<object>();
            localCon.Open();
            SqlCommand users = new SqlCommand("SELECT [UserID],[Name],[LastName] FROM [TravelExpenses].[dbo].[User] order by LastName", localCon);
            SqlDataReader usersDR = users.ExecuteReader();
            if (usersDR.HasRows)
            {
                while (usersDR.Read())
                {
                    string name = usersDR["LastName"].ToString() + "," + usersDR["Name"].ToString();
                    string id = usersDR["UserID"].ToString();
                    items.Add(new { Text = name, Value = id });
                }
            }
            usersDR.Close();
            cbUsers.DataSource = items;

            localCon.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            localCon.Open();
            SqlCommand results = new SqlCommand("SELECT a.Action,a.Date,b.Name,b.LastName FROM [TravelExpenses].[dbo].[User_History_Trace] as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID where a.UserID = '"+ cbUsers.SelectedValue.ToString() +"' AND a.Date BETWEEN '"+ dtpStartDate.Value +"' AND '"+ dtpEndDate.Value +"'", localCon);
            SqlDataReader resultsDR = results.ExecuteReader();
            if (resultsDR.HasRows)
            {
                while (resultsDR.Read())
                {
                    string user = resultsDR["Name"].ToString() + ", " + resultsDR["LastName"].ToString();
                    string action = resultsDR["Action"].ToString();
                    DateTime date = Convert.ToDateTime(resultsDR["Date"].ToString());
                    dgvResults.Rows.Add(user, action, date.ToShortDateString());
                }
            }
            resultsDR.Close();

            localCon.Close();
        }
    }
}
