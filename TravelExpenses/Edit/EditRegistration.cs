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
    public partial class EditRegistration : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid edittravelID;
        double registAmount = 0;
        bool districtPay = true;

        public EditRegistration()
        {
            InitializeComponent();
        }

        private void EditRegistration_Load(object sender, EventArgs e)
        {
            localCon.Open();
            edittravelID = new Guid(CommonVariables.editTravelID.ToString());
            SqlCommand cmd = new SqlCommand("SELECT [RegistrationAMount],[DistrictPay],[Notes] FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + edittravelID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows) {
                while (dr.Read()) {
                    txtRegistrationCost.Text = dr["RegistrationAMount"].ToString();
                    registAmount = Convert.ToDouble( dr["RegistrationAMount"].ToString());
                    districtPay = Convert.ToBoolean(dr["DistrictPay"].ToString());
                    if (districtPay)
                    {
                        rbYesDistraictPay.Checked = true;
                    }
                    else {
                        rbNoDistrictPay.Checked = true;
                    }
                    txtNotes.Text = dr["Notes"].ToString();
                }
                dr.Close();
            }
            localCon.Close();
        }

        private void btnUpdateRegistration_Click(object sender, EventArgs e)
        {
            double travelAmount = 0;
            double travelReim = 0;
            bool districtpay = true;
            localCon.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
            }
            dr2.Close();

            //deleting the old registration from the travel total and reimbursement
            travelAmount = travelAmount - registAmount;
            if (!districtPay) {
                travelReim = travelReim - registAmount;
            }

            SqlDataAdapter cmdEditReg = new SqlDataAdapter();
            cmdEditReg.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Registration] SET [RegistrationAMount] = @RegistrationAMount,[DistrictPay] = @DistrictPay, [Notes] = @Notes WHERE TravelID = '"+ edittravelID +"'", localCon);
            cmdEditReg.UpdateCommand.Parameters.Add("@RegistrationAMount", SqlDbType.Float).Value = Convert.ToDouble(txtRegistrationCost.Text);
            if (rbYesDistraictPay.Checked) {
                cmdEditReg.UpdateCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = true;
            } else if (rbNoDistrictPay.Checked) {
                cmdEditReg.UpdateCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = false;
                districtpay = false;
            }
            cmdEditReg.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtNotes.Text;
            int ru = cmdEditReg.UpdateCommand.ExecuteNonQuery();

            if (ru > 0) {
                SqlDataAdapter upTravel = new SqlDataAdapter();
                upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed WHERE TravelID ='" + edittravelID + "'", localCon);
                upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount + Convert.ToDouble(txtRegistrationCost.Text);
                if (!districtpay)
                {
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim + Convert.ToDouble(txtRegistrationCost.Text);
                }
                else
                {
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                }

                int rut = upTravel.UpdateCommand.ExecuteNonQuery();
                if (rut > 0) {
                    MessageBox.Show("The registration has been updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (backgroundWorker1.IsBusy != true)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                }
            }


            localCon.Close();
            closeAll();
        }

        private void btnCancelRegistration_Click(object sender, EventArgs e)
        {
            closeAll();
        }

        public void closeAll()
        {

            this.Close();
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "SelectItemsEdit")
                {
                    frm.Focus();
                    frm.Show();
                }
            }
        }

        private void txtRegistrationCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CommonVariables.sendChangesNotification(edittravelID);
        }
    }
}
