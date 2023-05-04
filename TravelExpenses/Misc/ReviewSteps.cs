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
    public partial class ReviewSteps : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid travelID = new Guid(CommonVariables.viewTravelID);
        public ReviewSteps()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReviewSteps_Load(object sender, EventArgs e)
        {
            localCon.Open();
            SqlCommand sentApp = new SqlCommand("SELECT [SignatureDate] FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' AND UserType = 'Accounting' AND TravelID = '" + travelID + "'", localCon);
            SqlDataReader sentAppDR = sentApp.ExecuteReader();
            if (sentAppDR.HasRows)
            {
                while (sentAppDR.Read())
                {
                    lblValueSentForApproval.Text = "Yes";
                    lblDateSentForApproval.Text = Convert.ToDateTime(sentAppDR["SignatureDate"].ToString()).ToShortDateString();
                }
            }
            else
            {
                lblValueSentForApproval.Text = "No";
                lblDateSentForApproval.Text = "-";
            }
            sentAppDR.Close();

            SqlCommand supApp = new SqlCommand("SELECT [SignatureDate] FROM [TravelExpenses].[dbo].[TravelSignatures] where TravelType = 'Travel' AND UserType = 'Supervisor' AND TravelID = '" + travelID + "'", localCon);
            SqlDataReader supAppDR = supApp.ExecuteReader();
            if (supAppDR.HasRows)
            {
                while (supAppDR.Read())
                {
                    lblValueSupApproval.Text = "Yes";
                    lblDateApproved.Text = Convert.ToDateTime(supAppDR["SignatureDate"].ToString()).ToShortDateString();
                }
            }
            else
            {
                lblValueSupApproval.Text = "No";
                lblDateApproved.Text = "-";
            }
            supAppDR.Close();
            localCon.Close();
        }
    }
}
