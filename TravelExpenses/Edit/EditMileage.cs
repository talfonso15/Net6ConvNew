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
    public partial class EditMileage : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid edittravelID;
        double mileageAmount = 0;
        bool districtVehicle = true;
        bool directorApp = false;
        bool directorAppNull = true;

        bool districtVehicleOri = true;
        bool directorAppOri = false;
        bool directorAppNullOri = true;
        public EditMileage()
        {
            InitializeComponent();
        }

        private void EditMileage_Load(object sender, EventArgs e)
        {
            if (CommonVariables.viewDetails)
            {
                edittravelID = new Guid(CommonVariables.viewTravelID);
                btnUpdateMileage.Visible = false;
            }
            else
            {
                edittravelID = new Guid(CommonVariables.editTravelID.ToString());
            }
            
            localCon.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '"+ edittravelID +"'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    txtMapMileage.Text = dr["MapMileage"].ToString();
                    txtVicicnityMileage.Text = dr["VicinityMileage"].ToString();
                    mileageAmount = Convert.ToDouble( dr["TotalMileage"].ToString());
                    if (dr["DistrictVehicleProvided"].ToString() == "True")
                    {
                        rbYesDistrictVehicle.Checked = true;
                        pDirectorApp.Enabled = false;
                       
                    }
                    else if (dr["DirectorApprovedPersonal"].ToString() == "True")
                    {
                        pDirectorApp.Enabled = true;
                        rbYesDirectorApproval.Checked = true;
                        rbNoDistrictVehicle.Checked = true;
                        directorAppOri = true;
                        districtVehicleOri = false;
                        directorAppNullOri = false;
                    } else if(dr["DirectorApprovedPersonal"].ToString() == "False")
                    {
                        pDirectorApp.Enabled = true;
                        rbNoDirectorApproval.Checked = true;
                        districtVehicleOri = false;
                        directorAppNullOri = false;
                    }
                    txtNotes.Text = dr["Notes"].ToString();
                }
                dr.Close();
            }
            localCon.Close();
        }

        private void rbNoDistrictVehicle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoDistrictVehicle.Checked) {
                pDirectorApp.Enabled = true;
            }
        }

        private void rbYesDistrictVehicle_CheckedChanged(object sender, EventArgs e)
        {
            pDirectorApp.Enabled = false;
            rbYesDirectorApproval.Checked = false;
            rbNoDirectorApproval.Checked = false;
            directorAppNull = true;
        }

        private void rbYesDirectorApproval_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesDirectorApproval.Checked)
            {
                directorAppNull = false;
                directorApp = true;
            }
            
            
        }

        private void rbNoDirectorApproval_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoDirectorApproval.Checked) {
                directorAppNull = false;
                directorApp = false;
            }
        }

        private void btnUpdateMileage_Click(object sender, EventArgs e)
        {
            double travelAmount = 0;
            double travelReim = 0;
            double newMilAmount = 0;
            double milRate = 0;
            localCon.Open();
            SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
            }
            dr2.Close();

            SqlCommand milageRate = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[MileageRate]", localCon);
            SqlDataReader milageRateDR = milageRate.ExecuteReader();
            if (milageRateDR.HasRows)
            {
                while (milageRateDR.Read())
                {
                    milRate = Convert.ToDouble(milageRateDR["MileageRate"].ToString());
                }
            }
            milageRateDR.Close();

           //deleting the old mileage from the travel total and reimbursement
           travelAmount = travelAmount - mileageAmount;
            if (!districtVehicleOri && directorAppOri)
            {
                travelReim = travelReim - mileageAmount;
            }

            //Calculating the new milaege total
            double vicinity = 0;
            if (txtVicicnityMileage.Text != "") {
                vicinity = Convert.ToDouble(txtVicicnityMileage.Text);
            }

            newMilAmount = (Convert.ToDouble(txtMapMileage.Text) + vicinity) * milRate;

            SqlDataAdapter delMileage = new SqlDataAdapter();
            delMileage.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Mileage] SET [DistrictVehicleProvided] = @DistrictVehicleProvided,[DirectorApprovedPersonal] = @DirectorApprovedPersonal,[MapMileage] = @MapMileage,[VicinityMileage] = @VicinityMileage,[TotalMileage] = @TotalMileage,[Notes] = @Notes WHERE TravelID = '"+ edittravelID +"'", localCon);
            delMileage.UpdateCommand.Parameters.Add("@MapMileage", SqlDbType.Float).Value = Convert.ToDouble(txtMapMileage.Text);
            delMileage.UpdateCommand.Parameters.Add("@VicinityMileage", SqlDbType.Float).Value = vicinity;
            delMileage.UpdateCommand.Parameters.Add("@TotalMileage", SqlDbType.Float).Value = newMilAmount;
            if (rbYesDistrictVehicle.Checked)
            {
                delMileage.UpdateCommand.Parameters.Add("@DistrictVehicleProvided", SqlDbType.Bit).Value = true;
                delMileage.UpdateCommand.Parameters.Add("@DirectorApprovedPersonal", SqlDbType.Bit).Value = SqlDateTime.Null;
            }
            else if (rbYesDirectorApproval.Checked)
            {
                delMileage.UpdateCommand.Parameters.Add("@DistrictVehicleProvided", SqlDbType.Bit).Value = false;
                delMileage.UpdateCommand.Parameters.Add("@DirectorApprovedPersonal", SqlDbType.Bit).Value = true;
            }
            else if (rbNoDirectorApproval.Checked) {
                delMileage.UpdateCommand.Parameters.Add("@DistrictVehicleProvided", SqlDbType.Bit).Value = false;
                delMileage.UpdateCommand.Parameters.Add("@DirectorApprovedPersonal", SqlDbType.Bit).Value = false;
            }
            delMileage.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = txtNotes.Text;

            int ru = delMileage.UpdateCommand.ExecuteNonQuery();
            if (ru > 0) {

                SqlDataAdapter upTravel = new SqlDataAdapter();
                upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed WHERE TravelID ='" + edittravelID + "'", localCon);
                upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount + newMilAmount;
                if (!rbYesDistrictVehicle.Checked && rbYesDirectorApproval.Checked)
                {
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim + newMilAmount;
                }
                else
                {
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                }

                int rut = upTravel.UpdateCommand.ExecuteNonQuery();
                if (rut > 0)
                {
                    MessageBox.Show("The mileage has been updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (backgroundWorker1.IsBusy != true)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }

                }
            }

            
            localCon.Close();
            closeAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            closeAll();
        }

        public void closeAll()
        {

            this.Close();
            if (CommonVariables.viewDetails)
            {
                FormCollection fc = Application.OpenForms;
                Form main = new Form();
                foreach (Form frm in fc)
                {
                    string name = frm.Name;
                    if (frm.Name == "ViewTravel")
                    {
                        frm.Focus();
                        frm.Show();
                    }
                }
            }
            else
            {
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
            
        }

        private void txtMapMileage_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVicicnityMileage_KeyPress(object sender, KeyPressEventArgs e)
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
