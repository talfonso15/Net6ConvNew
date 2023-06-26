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
    public partial class EditTravel : Form
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
        public EditTravel()
        {
            InitializeComponent();
        }

        private void EditTravel_Load(object sender, EventArgs e)
        {
            localCon.Open();
            userID = new Guid(CommonVariables.user.ToString());
            SqlCommand cmd = new SqlCommand("SELECT a.* FROM [TravelExpenses].[dbo].[Travel] as a Inner join TravelExpenses.dbo.TravelStatus as b on a.TravelID = b.TravelID where a.UserID = '" + userID + "' and b.Status = 'Pending'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    /*if (dr["Melas"].ToString() == "False" || dr["AirFare"].ToString() == "False" || dr["Mileage"].ToString() == "False" || dr["Registration"].ToString() == "False" || dr["Lodging"].ToString() == "False" || dr["CarRental"].ToString() == "False" || dr["OtherExpenses"].ToString() == "False")
                    {*/
                    departureDate = Convert.ToDateTime(dr["DepartureDate"].ToString()).ToShortDateString();
                    returnDate = Convert.ToDateTime(dr["ReturnDate"].ToString()).ToShortDateString();
                    travelEvent = dr["TravelEvent"].ToString();
                    travelPurpose = dr["TravelPurpose"].ToString();
                    origin = dr["Origin"].ToString();
                    destination = dr["Destination"].ToString();
                    dgvTravels.Rows.Add(dr["TravelID"].ToString(), departureDate, returnDate, travelEvent, travelPurpose, origin, destination);
                    /* }*/
                }
            }
            else
            {
                btnEditTravel.Enabled = false;
            }
            localCon.Close();
        }

        private void btnEditTravel_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvTravels.CurrentRow.Index;
            CommonVariables.editTravelID = dgvTravels.Rows[rowIndex].Cells[0].Value.ToString();

            //lodging changes requested by Jessica
            TimeSpan difference = Convert.ToDateTime(dgvTravels.Rows[rowIndex].Cells[2].Value.ToString()).Subtract(Convert.ToDateTime(dgvTravels.Rows[rowIndex].Cells[1].Value.ToString()));
            int totalDays = (int)difference.TotalDays;
            totalDays = totalDays + 1;
            CommonVariables.totalDaysMeals = totalDays;

            //this.Close();
            this.Dispose();
            SelectItemsEdit si = new SelectItemsEdit();
            si.ShowDialog();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
