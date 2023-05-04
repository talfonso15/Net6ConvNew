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
    public partial class EditMileageRate : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        public EditMileageRate()
        {
            InitializeComponent();
        }

        private void lblMileageRate_Click(object sender, EventArgs e)
        {

        }

        private void EditMileageRate_Load(object sender, EventArgs e)
        {
            localCon.Open();
            SqlCommand rate = new SqlCommand("SELECT [MileageRate] FROM [TravelExpenses].[dbo].[MileageRate]", localCon);
            SqlDataReader rateDR = rate.ExecuteReader();
            if (rateDR.HasRows)
            {
                while (rateDR.Read())
                {
                    lblCurrentMileageRateValue.Text = rateDR["MileageRate"].ToString();
                }
            }rateDR.Close();
            localCon.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            localCon.Open();
            SqlDataAdapter upRate = new SqlDataAdapter();
            upRate.UpdateCommand = new SqlCommand("UPDATE [dbo].[MileageRate] SET [MileageRate] = @MileageRate ,[DateChanged] = @DateChanged", localCon);
            upRate.UpdateCommand.Parameters.Add("@MileageRate", SqlDbType.Float).Value = Convert.ToDouble(txtMileageRate.Text);
            upRate.UpdateCommand.Parameters.Add("@DateChanged", SqlDbType.DateTime).Value = DateTime.Now;
            int updated = upRate.UpdateCommand.ExecuteNonQuery();
            if (updated > 0)
            {
                MessageBox.Show("The mileage rate was updated successfully.");
            }
            localCon.Close();
            this.Close();
        }
    }
}
