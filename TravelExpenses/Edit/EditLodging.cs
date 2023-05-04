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
using TravelExpenses.Properties;

namespace TravelExpenses
{
    public partial class EditLodging : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid edittravelID;
        Guid editLodgingID;
        int quantityLod = 0;
        bool isNew = false;
        
        public EditLodging()
        {
            InitializeComponent();
        }

        private void EditLodging_Load(object sender, EventArgs e)
        {
            localCon.Open();
            if (CommonVariables.viewDetails)
            {
                //this is for changing the place where the button are shown.
                Control del = tlGridviewButtons.GetControlFromPosition(0, 0);
                Control lab3 = tlGridviewButtons.GetControlFromPosition(5, 0);
                tlGridviewButtons.SetCellPosition(del, new TableLayoutPanelCellPosition(5, 0));
                tlGridviewButtons.SetCellPosition(lab3, new TableLayoutPanelCellPosition(0, 0));
                TableLayoutColumnStyleCollection styles = this.tlGridviewButtons.ColumnStyles;
                foreach (ColumnStyle style in styles)
                {
                    style.Width = 50;
                }

                edittravelID = new Guid(CommonVariables.viewTravelID);
                //lblSelection.Visible = false;
                btnDeleteLod.Visible = false;
                btnAddNewLod.Visible = false;
                btnSaveLod.Visible = false;
                btnCancelEditLod.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                btnEditLod.Image = Resources.if_5_330396;
                //btnEditLod.Text = "View";
            }
            else
            {
                edittravelID = new Guid(CommonVariables.editTravelID.ToString());
            }
            
            SqlCommand cmd = new SqlCommand("SELECT [LodgingID],[FacilityName],[NumberOfNIghts],[CostPerNight],[TaxesAndFees],[TaxesAndFeesPerNight],[DistrictPay],[DirectorApproved],[TotalLodging],[Notes] FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '"+ edittravelID +"'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string lodgingID = dr["LodgingID"].ToString();
                string faciltyName = dr["FacilityName"].ToString();
                string numberNights = dr["NumberOfNIghts"].ToString();
                string costPerNight = dr["CostPerNight"].ToString();
                string otherTaxesAndFees = dr["TaxesAndFees"].ToString();
                string taxesPerNight = dr["TaxesAndFeesPerNight"].ToString();
                bool districtPay = Convert.ToBoolean(dr["DistrictPay"].ToString());
                bool directorApproved = Convert.ToBoolean(dr["DirectorApproved"].ToString());
                string totalLodging = dr["TotalLodging"].ToString();
                string notes = dr["Notes"].ToString();
                if (taxesPerNight == "")
                {
                    taxesPerNight = "0";
                }
                if (otherTaxesAndFees == "")
                {
                    otherTaxesAndFees = "0";
                }
                dgvEditLodgings.Rows.Add(faciltyName, numberNights, costPerNight, otherTaxesAndFees, totalLodging, lodgingID, taxesPerNight, districtPay, directorApproved, notes);
                quantityLod++;
            }
            dr.Close();
            if (quantityLod <= 1) {
                btnDeleteLod.Enabled = false;
            }
            this.Size = new System.Drawing.Size(731, 295);


            localCon.Close();
        }

        private void btnEditLod_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvEditLodgings.CurrentRow.Index;
            string lodID = dgvEditLodgings.Rows[rowIndex].Cells[5].Value.ToString();
            editLodgingID = new Guid(lodID);

            txtFacilityName.Text = dgvEditLodgings.Rows[rowIndex].Cells[0].Value.ToString();
            double costPerNight = Convert.ToDouble(dgvEditLodgings.Rows[rowIndex].Cells[2].Value.ToString());
            nudNumberOfNights.Value = Convert.ToInt32(dgvEditLodgings.Rows[rowIndex].Cells[1].Value.ToString());
            double taxesAndFeesPerNight = Convert.ToDouble(dgvEditLodgings.Rows[rowIndex].Cells[6].Value.ToString());
            txtTaxesAndFeesPerNight.Text = taxesAndFeesPerNight.ToString();
            txtOtherTaxesAndFees.Text = dgvEditLodgings.Rows[rowIndex].Cells[3].Value.ToString();
            txtTotalLod.Text = dgvEditLodgings.Rows[rowIndex].Cells[4].Value.ToString();
            costPerNight = costPerNight - taxesAndFeesPerNight;
            txtCostPerNight.Text = costPerNight.ToString();
            txtNotes.Text = dgvEditLodgings.Rows[rowIndex].Cells[9].Value.ToString();
            bool districtPay = Convert.ToBoolean(dgvEditLodgings.Rows[rowIndex].Cells[7].Value.ToString());
            bool directorApp = Convert.ToBoolean(dgvEditLodgings.Rows[rowIndex].Cells[8].Value.ToString());
            if (districtPay)
            {
                pDirectorApp.Enabled = false;
                rbYesDistrictPay.Checked = true;
            }
            else
            {
                pDirectorApp.Enabled = true;
                rbNoDistrictPay.Checked = true;
                if (directorApp)
                {
                    rbYesDIrectorApp.Checked = true;
                }
                else {
                    rbNoDirectorApp.Checked = true;
                }
            }

            tlGridviewButtons.Visible = false;
            this.Size = new System.Drawing.Size(731, 701);
            dgvEditLodgings.Enabled = false;


        }

        private void rbYesDistrictPay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesDistrictPay.Checked) {
                pDirectorApp.Enabled = false;
                rbYesDIrectorApp.Checked = false;
                rbNoDirectorApp.Checked = false;
            }
        }

        private void rbNoDistrictPay_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoDistrictPay.Checked)
            {
                pDirectorApp.Enabled = true;
            }
        }

        private void btnDeleteLod_Click(object sender, EventArgs e)
        {
            DialogResult delLodging = MessageBox.Show("Do you really want to delete this lodging?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delLodging == DialogResult.Yes)
            {

                int rowIndex = dgvEditLodgings.CurrentRow.Index;
                string lodID = dgvEditLodgings.Rows[rowIndex].Cells[5].Value.ToString();
                editLodgingID = new Guid(lodID);
                double lodAmount = Convert.ToDouble(dgvEditLodgings.Rows[rowIndex].Cells[4].Value.ToString());
                bool districtPay = Convert.ToBoolean(dgvEditLodgings.Rows[rowIndex].Cells[7].Value.ToString());
                bool directorApp = Convert.ToBoolean(dgvEditLodgings.Rows[rowIndex].Cells[8].Value.ToString());

                double travelAmount = 0;
                double travelReim = 0;

                localCon.Open();

                SqlCommand delLod = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[Lodging] WHERE LodgingID = '" + editLodgingID + "'", localCon);
                int rd = delLod.ExecuteNonQuery();
                if (rd > 0)
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                        travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                    }
                    dr2.Close();

                    travelAmount = travelAmount - lodAmount;
                    if (!districtPay && directorApp)
                    {
                        travelReim = travelReim - lodAmount;
                    }

                    SqlDataAdapter upTravel = new SqlDataAdapter();
                    upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed  WHERE TravelID ='" + edittravelID + "'", localCon);
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                    int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                    localCon.Close();
                    if (ru > 0)
                    {
                        MessageBox.Show("Lodging deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshLodgings();
                    }
                }

                localCon.Close();

            } 
        }

        private void refreshLodgings()
        {
            localCon.Open();
            quantityLod = 0;
            dgvEditLodgings.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT [LodgingID],[FacilityName],[NumberOfNIghts],[CostPerNight],[TaxesAndFees],[TaxesAndFeesPerNight],[DistrictPay],[DirectorApproved],[TotalLodging],[Notes] FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '" + edittravelID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string lodgingID = dr["LodgingID"].ToString();
                string faciltyName = dr["FacilityName"].ToString();
                string numberNights = dr["NumberOfNIghts"].ToString();
                string costPerNight = dr["CostPerNight"].ToString();
                string otherTaxesAndFees = dr["TaxesAndFees"].ToString();
                string taxesPerNight = dr["TaxesAndFeesPerNight"].ToString();
                bool districtPay = Convert.ToBoolean(dr["DistrictPay"].ToString());
                bool directorApproved = Convert.ToBoolean(dr["DirectorApproved"].ToString());
                string totalLodging = dr["TotalLodging"].ToString();
                string notes = dr["Notes"].ToString();
                dgvEditLodgings.Rows.Add(faciltyName, numberNights, costPerNight, otherTaxesAndFees, totalLodging, lodgingID, taxesPerNight, districtPay, directorApproved, notes);
                quantityLod++;
            }
            dr.Close();
            if (quantityLod <= 1)
            {
                btnDeleteLod.Enabled = false;
            }
            else {
                btnDeleteLod.Enabled = true;
            }
            localCon.Close();
            
        }

        private void btnSaveLod_Click(object sender, EventArgs e)
        {
            string facilityName = "";
            int numberNights = 0;
            double costNight = 0;
            double taxesNight = 0;
            double otherTaxes = 0;
            double totalLod = 0;
            string notes = "";
            bool districtPay = true;
            bool directorApp = false;
            double travelAmount = 0;
            double travelReim = 0;
            localCon.Open();
            if (validate())
            {
                if (isNew)
                {
                    facilityName = txtFacilityName.Text;
                    numberNights = Convert.ToInt32(nudNumberOfNights.Value);
                    costNight = Convert.ToDouble(txtCostPerNight.Text);
                    taxesNight = Convert.ToDouble(txtTaxesAndFeesPerNight.Text);
                    otherTaxes = Convert.ToDouble(txtOtherTaxesAndFees.Text);
                    //totalLod = (costNight * numberNights) + otherTaxes; // change in lodging requested by Jessica
                    totalLod = Convert.ToDouble(txtTotalLod.Text);
                    notes = txtNotes.Text;

                    if (rbNoDistrictPay.Checked)
                    {
                        districtPay = false;
                        if (rbYesDIrectorApp.Checked)
                        {
                            directorApp = true;
                        }
                    }

                    SqlDataAdapter addLod = new SqlDataAdapter();
                    addLod.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Lodging] ([FacilityName],[NumberOfNIghts],[CostPerNight],[TaxesAndFees],[TaxesAndFeesPerNight],[DistrictPay],[DirectorApproved],[TravelID],[TotalLodging],[Notes]) VALUES (@FacilityName,@NumberOfNIghts,@CostPerNight,@TaxesAndFees,@TaxesAndFeesPerNight,@DistrictPay,@DirectorApproved,@TravelID,@TotalLodging,@Notes)", localCon);
                    addLod.InsertCommand.Parameters.Add("@FacilityName", SqlDbType.VarChar).Value = facilityName;
                    addLod.InsertCommand.Parameters.Add("@NumberOfNIghts", SqlDbType.Int).Value = numberNights;
                    addLod.InsertCommand.Parameters.Add("@CostPerNight", SqlDbType.Float).Value = costNight;
                    addLod.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = otherTaxes;
                    addLod.InsertCommand.Parameters.Add("@TaxesAndFeesPerNight", SqlDbType.Float).Value = taxesNight;
                    addLod.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = districtPay;
                    addLod.InsertCommand.Parameters.Add("@DirectorApproved", SqlDbType.Bit).Value = directorApp;
                    addLod.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = edittravelID;
                    addLod.InsertCommand.Parameters.Add("@TotalLodging", SqlDbType.Float).Value = totalLod;
                    addLod.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = notes;
                    int ri = addLod.InsertCommand.ExecuteNonQuery();
                    if (ri > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        while (dr2.Read())
                        {
                            travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                            travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                        }
                        dr2.Close();

                        travelAmount = travelAmount + totalLod;
                        if (!districtPay && directorApp)
                        {
                            travelReim = travelReim + totalLod;
                        }

                        SqlDataAdapter upTravel = new SqlDataAdapter();
                        upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed  WHERE TravelID ='" + edittravelID + "'", localCon);
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                        int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                        localCon.Close();
                        if (ru > 0)
                        {
                            MessageBox.Show("Lodging inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshLodgings();
                            isNew = false;
                            if (backgroundWorker1.IsBusy != true)
                            {
                                backgroundWorker1.RunWorkerAsync();
                            }
                        }
                    }


                    isNew = false;
                }
                else
                {
                    bool oriDistrictPay = true;
                    bool oriDirectorApp = false;
                    double oriTotalLod = 0;

                    SqlCommand cmd = new SqlCommand("SELECT [DistrictPay],[DirectorApproved],[TotalLodging] FROM [TravelExpenses].[dbo].[Lodging] where LodgingID = '"+ editLodgingID +"'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oriDistrictPay = Convert.ToBoolean(dr["DistrictPay"].ToString());
                        oriDirectorApp = Convert.ToBoolean(dr["DirectorApproved"].ToString());
                        oriTotalLod = Convert.ToDouble(dr["TotalLodging"].ToString());
                    }
                    dr.Close();

                    SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                        travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                    }
                    dr2.Close();

                    travelAmount = travelAmount - oriTotalLod;
                    if (!oriDistrictPay && oriDirectorApp)
                    {
                        travelReim = travelReim - oriTotalLod;
                    }



                    facilityName = txtFacilityName.Text;
                    numberNights = Convert.ToInt32(nudNumberOfNights.Value);
                    costNight = Convert.ToDouble(txtCostPerNight.Text) + Convert.ToDouble(txtTaxesAndFeesPerNight.Text);
                    taxesNight = Convert.ToDouble(txtTaxesAndFeesPerNight.Text);
                    otherTaxes = Convert.ToDouble(txtOtherTaxesAndFees.Text);
                    totalLod = (costNight * numberNights) + otherTaxes;
                    notes = txtNotes.Text;

                    if (rbNoDistrictPay.Checked)
                    {
                        districtPay = false;
                        if (rbYesDIrectorApp.Checked)
                        {
                            directorApp = true;
                        }
                    }

                    SqlDataAdapter upLod = new SqlDataAdapter();
                    upLod.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Lodging] SET [FacilityName] = @FacilityName,[NumberOfNIghts] = @NumberOfNIghts,[CostPerNight] = @CostPerNight,[TaxesAndFees] = @TaxesAndFees,[TaxesAndFeesPerNight] = @TaxesAndFeesPerNight,[DistrictPay] = @DistrictPay,[DirectorApproved] = @DirectorApproved,[TotalLodging] = @TotalLodging,[Notes] = @Notes WHERE LodgingID = '"+ editLodgingID +"'", localCon);
                    upLod.UpdateCommand.Parameters.Add("@FacilityName", SqlDbType.VarChar).Value = facilityName;
                    upLod.UpdateCommand.Parameters.Add("@NumberOfNIghts", SqlDbType.Int).Value = numberNights;
                    upLod.UpdateCommand.Parameters.Add("@CostPerNight", SqlDbType.Float).Value = costNight;
                    upLod.UpdateCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = otherTaxes;
                    upLod.UpdateCommand.Parameters.Add("@TaxesAndFeesPerNight", SqlDbType.Float).Value = taxesNight;
                    upLod.UpdateCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = districtPay;
                    upLod.UpdateCommand.Parameters.Add("@DirectorApproved", SqlDbType.Bit).Value = directorApp;
                    upLod.UpdateCommand.Parameters.Add("@TotalLodging", SqlDbType.Float).Value = totalLod;
                    upLod.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = notes;
                    int ru = upLod.UpdateCommand.ExecuteNonQuery();
                    if (ru > 0) {

                        travelAmount = travelAmount + totalLod;
                        if (!districtPay && directorApp)
                        {
                            travelReim = travelReim + totalLod;
                        }

                        SqlDataAdapter upTravel = new SqlDataAdapter();
                        upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed  WHERE TravelID ='" + edittravelID + "'", localCon);
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                        int rut = upTravel.UpdateCommand.ExecuteNonQuery();
                        localCon.Close();
                        if (rut > 0)
                        {
                            MessageBox.Show("Lodging updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshLodgings();
                            if (backgroundWorker1.IsBusy != true)
                            {
                                backgroundWorker1.RunWorkerAsync();
                            }
                        }


                    }

                }

                tlGridviewButtons.Visible = true;
                this.Size = new System.Drawing.Size(731, 295);
                dgvEditLodgings.Enabled = true;
                clearData();
            }

            localCon.Close();
            
        }

        private void btnAddNewLod_Click(object sender, EventArgs e)
        {
            isNew = true;
            tlGridviewButtons.Visible = false;
            this.Size = new System.Drawing.Size(731, 701);
            dgvEditLodgings.Enabled = false;
            txtCostPerNight.Text = "0";
            txtTaxesAndFeesPerNight.Text = "0";
            txtTotalLod.Text = "0";
            txtOtherTaxesAndFees.Text = "0";
            nudNumberOfNights.Value = CommonVariables.totalDaysMeals;

        }

        private bool validate()
        {
            if (txtFacilityName.Text == "")
            {
                MessageBox.Show("Enter a facility name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nudNumberOfNights.Value <= 0)
            {
                MessageBox.Show("Enter the number of nights", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTaxesAndFeesPerNight.Text == "")
            {
                MessageBox.Show("Enter the taxes and fees per night", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!rbYesDistrictPay.Checked && !rbNoDistrictPay.Checked)
            {
                MessageBox.Show("Answer the question about the district pay or not for your lodging", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (rbNoDistrictPay.Checked && !rbYesDIrectorApp.Checked && !rbNoDirectorApp.Checked)
            {
                MessageBox.Show("Answer the question about the approval of the director", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
                return true;
        }

        private void clearData()
        {
            txtFacilityName.Text = "";
            nudNumberOfNights.Value = 0;
            txtCostPerNight.Text = "";
            txtTaxesAndFeesPerNight.Text = "";
            txtOtherTaxesAndFees.Text = "";
            txtTotalLod.Text = "";
            txtNotes.Text = "";
            rbYesDistrictPay.Checked = false;
            rbNoDistrictPay.Checked = false;
            rbYesDIrectorApp.Checked = false;
            rbNoDirectorApp.Checked = false;
            pDirectorApp.Enabled = false;
        }

        private void btnCancelEditLod_Click(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tlGridviewButtons.Visible = true;
            this.Size = new System.Drawing.Size(731, 295);
            dgvEditLodgings.Enabled = true;
            isNew = false;
            clearData();
        }

        private void nudNumberOfNights_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void calculateTotal()
        {
            if (nudNumberOfNights.Value > 0 && txtCostPerNight.Text != "" && txtTaxesAndFeesPerNight.Text != "" && txtOtherTaxesAndFees.Text != "")
            {
                double costPNight = Convert.ToDouble(txtCostPerNight.Text) + Convert.ToDouble(txtTaxesAndFeesPerNight.Text);
                double totalLod = (costPNight * Convert.ToInt32(nudNumberOfNights.Value)) + Convert.ToDouble(txtOtherTaxesAndFees.Text);
                txtTotalLod.Text = totalLod.ToString();
            }
        }

        private void txtCostPerNight_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotal();
        }

        private void txtTaxesAndFeesPerNight_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotal();
        }

        private void txtOtherTaxesAndFees_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotal();
        }

        private void nudNumberOfNights_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotal();
        }

        private void txtCostPerNight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTaxesAndFeesPerNight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtOtherTaxesAndFees_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTotalLod_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTotalLod_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalLod_KeyUp(object sender, KeyEventArgs e)
        {
            double costPerNight = 0;

            if (nudNumberOfNights.Value.ToString() != "0" && txtTotalLod.Text != "") 
            {
                costPerNight = Math.Round( Convert.ToDouble(txtTotalLod.Text) / Convert.ToInt32( nudNumberOfNights.Value.ToString()),2);
                txtCostPerNight.Text = costPerNight.ToString();
            }
        }
    }
}
