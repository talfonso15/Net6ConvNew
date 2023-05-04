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
    public partial class LodgingSelection : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid travelID = new Guid(CommonVariables.viewTravelID);
        public LodgingSelection()
        {
            InitializeComponent();
        }

        private void LodgingSelection_Load(object sender, EventArgs e)
        {
            localCon.Open();
            SqlCommand selLodg = new SqlCommand("SELECT  [LodgingID],[FacilityName]  FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '"+ travelID +"'", localCon);
            SqlDataReader selLodgDR = selLodg.ExecuteReader();
            if (selLodgDR.HasRows)
            {
                cbLodgings.DisplayMember = "Text";
                cbLodgings.ValueMember = "Value";
                List<Object> items = new List<object>();
                while (selLodgDR.Read())
                {
                    string displayTest = "";
                    string idvalue = selLodgDR["LodgingID"].ToString();
                    displayTest = selLodgDR["FacilityName"].ToString();
                    items.Add(new { Text = displayTest, Value = idvalue });
                }
                selLodgDR.Close();
                cbLodgings.DataSource = items;
            }
            localCon.Close();
        }

        private void btnLodgingID_Click(object sender, EventArgs e)
        {
            CommonVariables.lodgingSelId = cbLodgings.SelectedValue.ToString();
            this.Close();
        }
    }
}
