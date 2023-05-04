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
    public partial class AirfareSelection : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid travelID = new Guid(CommonVariables.viewTravelID);
        public AirfareSelection()
        {
            InitializeComponent();
        }

        private void AirfareSelection_Load(object sender, EventArgs e)
        {
            localCon.Open();
            SqlCommand selairfare = new SqlCommand("SELECT  [AirFareID] ,[DepartureDate] ,[ReturnDate]  FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '" + travelID +"'", localCon);
            SqlDataReader selairfaretDR = selairfare.ExecuteReader();
            if (selairfaretDR.HasRows)
            {
                cbAirdareSelection.DisplayMember = "Text";
                cbAirdareSelection.ValueMember = "Value";
                List<Object> items = new List<object>();
                while (selairfaretDR.Read())
                {
                    string displayTest = "";
                    string flightType = "";
                    string idvalue = selairfaretDR["AirFareID"].ToString();
                    DateTime startDate = Convert.ToDateTime(selairfaretDR["DepartureDate"].ToString());
                    DateTime endDate = DateTime.Today;
                    if (selairfaretDR["ReturnDate"].ToString() != "")
                    {
                        endDate = Convert.ToDateTime(selairfaretDR["ReturnDate"].ToString());
                        flightType = "Round Trip";
                    }
                    else
                    {
                        flightType = "One way";
                    }

                    if (flightType == "Round Trip")
                    {
                        displayTest = startDate.ToShortDateString() + " returning " + endDate.ToShortDateString() + ", " + flightType;
                    }
                    else
                    {
                        displayTest = startDate.ToShortDateString() + ", " + flightType;
                    }

                    
                    items.Add(new { Text = displayTest, Value = idvalue });
                }
                selairfaretDR.Close();
                cbAirdareSelection.DataSource = items;
            }
            localCon.Close();
        }

        private void btnSaveAirfareID_Click(object sender, EventArgs e)
        {
            CommonVariables.airfareSelId = cbAirdareSelection.SelectedValue.ToString();
            this.Close();
        }
    }
}
