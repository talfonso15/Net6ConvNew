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
    public partial class AddTravelItem : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid travelID = new Guid();
        Guid userID = new Guid();
        string departureDate = "";
        string returnDate = "";
        string travelEvent = "";
        string travelPurpose = "";
        string origin = "";
        string destination = "";

        public AddTravelItem()
        {
            InitializeComponent();
        }

        private void AddTravelItem_Load(object sender, EventArgs e)
        {
            localCon.Open();
            userID = new Guid(CommonVariables.user.ToString());
            SqlCommand cmd = new SqlCommand("SELECT a.* FROM [TravelExpenses].[dbo].[Travel] as a Inner join TravelExpenses.dbo.TravelStatus as b on a.TravelID = b.TravelID where a.UserID = '" + userID + "' and b.Status = 'Pending'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr["Melas"].ToString() == "False" || dr["AirFare"].ToString() == "False" || dr["Mileage"].ToString() == "False" || dr["Registration"].ToString() == "False" || dr["Lodging"].ToString() == "False" || dr["CarRental"].ToString() == "False" || dr["OtherExpenses"].ToString() == "False")
                    {
                        departureDate = Convert.ToDateTime(dr["DepartureDate"].ToString()).ToShortDateString();
                        returnDate = Convert.ToDateTime(dr["ReturnDate"].ToString()).ToShortDateString();
                        travelEvent = dr["TravelEvent"].ToString();
                        travelPurpose = dr["TravelPurpose"].ToString();
                        origin = dr["Origin"].ToString();
                        destination = dr["Destination"].ToString();
                        dtgTravels.Rows.Add(dr["TravelID"].ToString(), departureDate, returnDate, travelEvent, travelPurpose, origin, destination);
                    }
                }
            }
            else {
                btnAddTravelItem.Enabled = false;
            }
            localCon.Close();
        }

        private void btnAddTravelItem_Click(object sender, EventArgs e)
        {
            if (dtgTravels.RowCount > 0)
            {
                int rowIndex = dtgTravels.CurrentRow.Index;
                CommonVariables.addingTravelID = dtgTravels.Rows[rowIndex].Cells[0].Value.ToString();
                CommonVariables.addingItems = true;

                FormCollection fc = Application.OpenForms;
                Form main = new Form();
                foreach (Form frm in fc)
                {
                    string name = frm.Name;
                    if (frm.Name == "Main")
                    {
                        main = frm;
                        break;
                    }
                }
                TravelItems ti = new TravelItems();
                ti.MdiParent = main;
                ti.Show();
                this.Close();
            }
        }

        private void btnCancelAddItems_Click(object sender, EventArgs e)
        {
            CommonVariables.CancelTravel();
            this.Close();
        }

        private void AddTravelItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*CommonVariables.addingItems = false;
            CommonVariables.addingTravelID = "";*/
        }
    }
}
