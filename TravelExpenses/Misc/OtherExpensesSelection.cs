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
    public partial class OtherExpensesSelection : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid travelID = new Guid(CommonVariables.viewTravelID);
        public OtherExpensesSelection()
        {
            InitializeComponent();
        }

        private void OtherExpensesSelection_Load(object sender, EventArgs e)
        {
            localCon.Open();
            SqlCommand selOE = new SqlCommand("SELECT  [OtherExpensesID] ,[Description] FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '"+ travelID +"'", localCon);
            SqlDataReader selOEDR = selOE.ExecuteReader();
            if (selOEDR.HasRows)
            {
                cbOtherExpenses.DisplayMember = "Text";
                cbOtherExpenses.ValueMember = "Value";
                List<Object> items = new List<object>();
                while (selOEDR.Read())
                {
                    string displayTest = "";
                    string idvalue = selOEDR["OtherExpensesID"].ToString();
                    displayTest = selOEDR["Description"].ToString();
                    items.Add(new { Text = displayTest, Value = idvalue });
                }
                selOEDR.Close();
                cbOtherExpenses.DataSource = items;
            }
            localCon.Close();
        }

        private void btnOtherExpId_Click(object sender, EventArgs e)
        {
            CommonVariables.otherExpselId = cbOtherExpenses.SelectedValue.ToString();
            this.Close();
        }
    }
}
