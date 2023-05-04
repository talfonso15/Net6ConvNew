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
    public partial class CarRentalSelection : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid travelID = new Guid(CommonVariables.viewTravelID);
        
        public CarRentalSelection()
        {
            InitializeComponent();
        }

        private void CarRentalSelection_Load(object sender, EventArgs e)
        {
            localCon.Open();
            SqlCommand selCarRent = new SqlCommand("SELECT [CarRentalID] ,[PickUPDate],[DropOffDate],[CarType],[Company] FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '"+ travelID + "'", localCon);
            SqlDataReader selCarRentDR = selCarRent.ExecuteReader();
            if (selCarRentDR.HasRows)
            {
                cbCarRentals.DisplayMember = "Text";
                cbCarRentals.ValueMember = "Value";
                List<Object> items = new List<object>();
                while (selCarRentDR.Read())
                {
                    string displayTest = "";
                    string idvalue = selCarRentDR["CarRentalID"].ToString();
                    DateTime startDate = Convert.ToDateTime(selCarRentDR["PickUPDate"].ToString());
                    DateTime endDate = Convert.ToDateTime(selCarRentDR["DropOffDate"].ToString());

                    displayTest = startDate.ToShortDateString() + " to " + endDate.ToShortDateString() + ", " + selCarRentDR["CarType"].ToString() + ", " + selCarRentDR["Company"].ToString();
                    items.Add(new { Text = displayTest, Value = idvalue });
                }
                selCarRentDR.Close();
                cbCarRentals.DataSource = items;
            }
            localCon.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CommonVariables.carRentalSelId = cbCarRentals.SelectedValue.ToString();
            this.Close();
        }
    }
}
