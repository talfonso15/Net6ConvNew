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
    public partial class MileageCalculator : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        double mileageRate = 0;
        public MileageCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculateMileageCost_Click(object sender, EventArgs e)
        {
            if (txtMileage.Text != "")
            {
                double mileageCost = Convert.ToDouble(txtMileage.Text) * mileageRate;
                CommonVariables.estimateMileageCost = mileageCost;
            }
            this.Close();
        }

        private void txtMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void MileageCalculator_Load(object sender, EventArgs e)
        {
            localCon.Open();
            SqlCommand mr = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[MileageRate]", localCon);
            SqlDataReader mrDR = mr.ExecuteReader();
            if (mrDR.HasRows)
            {
                while (mrDR.Read())
                {
                    mileageRate = Convert.ToDouble(mrDR["MileageRate"].ToString());
                }
            }
            mrDR.Close();
            localCon.Close();
            lblCurrentMileageRate.Text = "The current mileage rate is: " + mileageRate.ToString();
        }
    }
}
