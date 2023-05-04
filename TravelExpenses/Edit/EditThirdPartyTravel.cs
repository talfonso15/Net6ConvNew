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
    public partial class EditThirdPartyTravel : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        public EditThirdPartyTravel()
        {
            InitializeComponent();
        }

        private void EditThirdPartyTravel_Load(object sender, EventArgs e)
        {
            localCon.Open();
            dgvTravels.Rows.Clear();

            SqlCommand empl = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] order by LastName asc", localCon);
            SqlDataReader emplDR = empl.ExecuteReader();
            cbEmployee.DisplayMember = "Text";
            cbEmployee.ValueMember = "Value";
            List<Object> items = new List<object>();
            while (emplDR.Read())
            {
                string name = emplDR["LastName"].ToString() + "," + emplDR["Name"].ToString();
                string id = emplDR["UserID"].ToString();
                items.Add(new { Text = name, Value = id });
            }

            items.Add(new { Text = "All", Value = "-1" });
            cbEmployee.DataSource = items;
            cbEmployee.SelectedValue = "-1";
            emplDR.Close();

            SqlCommand travelscmd = new SqlCommand("SELECT a.TravelID,a.ReturnDate,a.DepartureDate,a.TravelEvent,a.UserID,b.Name as Name, b.LastName as lastname FROM [TravelExpenses].[dbo].[Travel] as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID order by a.DepartureDate desc", localCon);
            SqlDataReader travelscmdDR = travelscmd.ExecuteReader();
            if (travelscmdDR.HasRows)
            {
                DateTime startDate;
                DateTime endDate;
                string travelEvent = "";
                string travelID = "";
                string userID = "";
                string username = "";
                while (travelscmdDR.Read())
                {
                    startDate = Convert.ToDateTime(travelscmdDR["DepartureDate"].ToString());
                    endDate = Convert.ToDateTime(travelscmdDR["ReturnDate"].ToString());
                    travelEvent = travelscmdDR["TravelEvent"].ToString();
                    travelID = travelscmdDR["TravelID"].ToString();
                    userID = travelscmdDR["UserID"].ToString();
                    username = travelscmdDR["Name"].ToString() + " " + travelscmdDR["lastname"].ToString();
                    dgvTravels.Rows.Add(startDate.ToShortDateString(), endDate.ToShortDateString(), travelEvent, username, travelID, userID);
                }
            }
            travelscmdDR.Close();


            localCon.Close();
        }

        private void btnShowTravels_Click(object sender, EventArgs e)
        {
            refreshTravels();
        }

        private void refreshTravels()
        {
            dgvTravels.Rows.Clear();
            localCon.Open();
            if (cbEmployee.SelectedValue.ToString() == "-1")
            {
                SqlCommand travelscmd = new SqlCommand("SELECT a.TravelID,a.ReturnDate,a.DepartureDate,a.TravelEvent,a.UserID,b.Name as Name, b.LastName as lastname FROM [TravelExpenses].[dbo].[Travel] as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID order by a.DepartureDate desc", localCon);
                SqlDataReader travelscmdDR = travelscmd.ExecuteReader();
                if (travelscmdDR.HasRows)
                {
                    DateTime startDate;
                    DateTime endDate;
                    string travelEvent = "";
                    string travelID = "";
                    string userID = "";
                    string username = "";
                    while (travelscmdDR.Read())
                    {
                        startDate = Convert.ToDateTime(travelscmdDR["DepartureDate"].ToString());
                        endDate = Convert.ToDateTime(travelscmdDR["ReturnDate"].ToString());
                        travelEvent = travelscmdDR["TravelEvent"].ToString();
                        travelID = travelscmdDR["TravelID"].ToString();
                        userID = travelscmdDR["UserID"].ToString();
                        username = travelscmdDR["Name"].ToString() + " " + travelscmdDR["lastname"].ToString();
                        dgvTravels.Rows.Add(startDate.ToShortDateString(), endDate.ToShortDateString(), travelEvent, username, travelID, userID);
                    }
                }
                travelscmdDR.Close();
            }
            else
            {
                Guid userIDTR = new Guid(cbEmployee.SelectedValue.ToString());
                SqlCommand travelscmd = new SqlCommand("SELECT a.TravelID,a.ReturnDate,a.DepartureDate,a.TravelEvent,a.UserID,b.Name as Name, b.LastName as lastname FROM [TravelExpenses].[dbo].[Travel] as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID where a.UserID = '"+ userIDTR + "' order by a.DepartureDate desc", localCon);
                SqlDataReader travelscmdDR = travelscmd.ExecuteReader();
                if (travelscmdDR.HasRows)
                {
                    DateTime startDate;
                    DateTime endDate;
                    string travelEvent = "";
                    string travelID = "";
                    string userID = "";
                    string username = "";
                    while (travelscmdDR.Read())
                    {
                        startDate = Convert.ToDateTime(travelscmdDR["DepartureDate"].ToString());
                        endDate = Convert.ToDateTime(travelscmdDR["ReturnDate"].ToString());
                        travelEvent = travelscmdDR["TravelEvent"].ToString();
                        travelID = travelscmdDR["TravelID"].ToString();
                        userID = travelscmdDR["UserID"].ToString();
                        username = travelscmdDR["Name"].ToString() + " " + travelscmdDR["lastname"].ToString();
                        dgvTravels.Rows.Add(startDate.ToShortDateString(), endDate.ToShortDateString(), travelEvent, username, travelID, userID);
                    }
                }
                travelscmdDR.Close();

            }
            localCon.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditTravel_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvTravels.CurrentRow.Index;
            CommonVariables.editTravelID = dgvTravels.Rows[rowIndex].Cells[4].Value.ToString();
            //this.Close();
            this.Dispose();
            SelectItemsEdit si = new SelectItemsEdit();
            si.ShowDialog();
        }
    }
}
