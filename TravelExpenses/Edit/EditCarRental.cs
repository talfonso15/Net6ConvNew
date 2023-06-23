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
    public partial class EditCarRental : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid edittravelID;
        Guid editCarRID;
        int quantityCar = 0;
        bool isNew = false;

        public EditCarRental()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditCarRental_Load(object sender, EventArgs e)
        {
            localCon.Open();
            if (CommonVariables.viewDetails)
            {
                //this is for changing the place where the button are shown.
                Control del = tlEditButtons.GetControlFromPosition(0, 0);
                Control lab3 = tlEditButtons.GetControlFromPosition(5, 0);
                tlEditButtons.SetCellPosition(del, new TableLayoutPanelCellPosition(5, 0));
                tlEditButtons.SetCellPosition(lab3, new TableLayoutPanelCellPosition(0, 0));
                TableLayoutColumnStyleCollection styles = this.tlEditButtons.ColumnStyles;
                foreach (ColumnStyle style in styles)
                {
                    style.Width = 50;
                }


                edittravelID = new Guid(CommonVariables.viewTravelID);
                btnSaveCar.Visible = false;
                btnDeleteCar.Visible = false;
                btnAddCar.Visible = false;
                //lblCarEdit.Visible = false;
                btnCancelEditCar.Visible = true;
                btnEditCar.Image = Resources.if_5_330396;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                //btnEditCar.Text = "View";

            }
            else
            {
                edittravelID = new Guid(CommonVariables.editTravelID.ToString());

            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + edittravelID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string carRentalId = dr["CarRentalID"].ToString();
                DateTime pickUpDate = Convert.ToDateTime(dr["PickUPDate"].ToString());
                DateTime dropOffDate = Convert.ToDateTime(dr["DropOffDate"].ToString());
                string carType = dr["CarType"].ToString();
                string company = dr["Company"].ToString();
                string days = dr["Days"].ToString();
                string costPerDay = dr["CostPerDay"].ToString();
                string taxAndFees = dr["TaxesAndFees"].ToString();
                string ldwInsuranse = dr["LDWInsuranse"].ToString();
                string suppInsurance = dr["SupplementalInsurance"].ToString();
                bool extraInsurance = Convert.ToBoolean(dr["ExtarInsurance"].ToString());
                string extraInsuranceAmount = "";
                if (dr["ExtarInsurance"].ToString() == "True")
                {
                    extraInsuranceAmount = dr["ExtarInsuranceAmount"].ToString();
                }
                bool districtPay = Convert.ToBoolean(dr["DistrictPay"].ToString());
                bool personalUse = Convert.ToBoolean(dr["PersonalUse"].ToString());
                string personalUseAmount = "";
                personalUseAmount = dr["PersonalAmount"].ToString();
                string totalCar = dr["TotalCarRental"].ToString();
                string notes = dr["Notes"].ToString();

                dgvEditCar.Rows.Add(pickUpDate.ToShortDateString(), dropOffDate.ToShortDateString(), costPerDay, districtPay, totalCar, carType, company, days, taxAndFees, ldwInsuranse, suppInsurance, extraInsurance, extraInsuranceAmount, personalUse, personalUseAmount, carRentalId, notes);
                quantityCar++;
            }
            dr.Close();

            if (quantityCar <= 1)
            {
                btnDeleteCar.Enabled = false;
            }
            //setting up the size of the form
            this.Size = new System.Drawing.Size(770, 241);

            //setting up the values of the datetimepickers and the number of days.
            dtpDropOffDate.Value = DateTime.Today.AddDays(1);
            setDaysAndDates();



            localCon.Close();
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            DialogResult delCarRent = MessageBox.Show("Do you really want to delete this car rental?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delCarRent == DialogResult.Yes)
            {
                int rowIndex = dgvEditCar.CurrentRow.Index;
                string carID = dgvEditCar.Rows[rowIndex].Cells[15].Value.ToString();
                editCarRID = new Guid(carID);
                double carAmount = Convert.ToDouble(dgvEditCar.Rows[rowIndex].Cells[4].Value.ToString());
                bool districtPay = Convert.ToBoolean(dgvEditCar.Rows[rowIndex].Cells[3].Value.ToString());
                bool personalUse = Convert.ToBoolean(dgvEditCar.Rows[rowIndex].Cells[13].Value.ToString());
                double personalUseAmount = Convert.ToDouble(dgvEditCar.Rows[rowIndex].Cells[14].Value.ToString());

                double travelAmount = 0;
                double travelReim = 0;
                double travelNoReim = 0;

                localCon.Open();
                SqlCommand delCar = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[CarRental] WHERE CarRentalID = '" + editCarRID + "'", localCon);
                int rd = delCar.ExecuteNonQuery();
                if (rd > 0)
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                        travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                        travelNoReim = Convert.ToDouble(dr2["TotalTravelNoReimbursed"].ToString());
                    }
                    dr2.Close();

                    travelAmount = travelAmount - carAmount;
                    if (!districtPay)
                    {
                        if (personalUse)
                        {
                            double diffCRDel = carAmount - personalUseAmount;
                            travelReim = travelReim - diffCRDel;
                        }
                        else
                        {
                            travelReim = travelReim - carAmount;
                        }

                    }
                    else
                    {
                        if (personalUse)
                        {
                            travelNoReim = travelNoReim - personalUseAmount;
                        }
                    }

                    SqlDataAdapter upTravel = new SqlDataAdapter();
                    upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed,[TotalTravelNoReimbursed] = @TotalTravelNoReimbursed  WHERE TravelID ='" + edittravelID + "'", localCon);
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelNoReimbursed", SqlDbType.Float).Value = travelNoReim;
                    int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                    localCon.Close();
                    if (ru > 0)
                    {
                        MessageBox.Show("Car Rental deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshCarRental();
                    }
                }

                localCon.Close();
            }
        }

        private void refreshCarRental()
        {
            localCon.Open();
            quantityCar = 0;
            dgvEditCar.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + edittravelID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string carRentalId = dr["CarRentalID"].ToString();
                string pickUpDate = Convert.ToDateTime(dr["PickUPDate"].ToString()).ToShortDateString();
                string dropOffDate = Convert.ToDateTime(dr["DropOffDate"].ToString()).ToShortDateString();
                string carType = dr["CarType"].ToString();
                string company = dr["Company"].ToString();
                string days = dr["Days"].ToString();
                string costPerDay = dr["CostPerDay"].ToString();
                string taxAndFees = dr["TaxesAndFees"].ToString();
                string ldwInsuranse = dr["LDWInsuranse"].ToString();
                string suppInsurance = dr["SupplementalInsurance"].ToString();
                bool extraInsurance = Convert.ToBoolean(dr["ExtarInsurance"].ToString());
                string extraInsuranceAmount = "";
                if (dr["ExtarInsurance"].ToString() == "True")
                {
                    extraInsuranceAmount = dr["ExtarInsuranceAmount"].ToString();
                }
                bool districtPay = Convert.ToBoolean(dr["DistrictPay"].ToString());
                bool personalUse = Convert.ToBoolean(dr["PersonalUse"].ToString());
                string personalUseAmount = "";
                personalUseAmount = dr["PersonalAmount"].ToString();
                string totalCar = dr["TotalCarRental"].ToString();
                string notes = dr["Notes"].ToString();

                dgvEditCar.Rows.Add(pickUpDate, dropOffDate, costPerDay, districtPay, totalCar, carType, company, days, taxAndFees, ldwInsuranse, suppInsurance, extraInsurance, extraInsuranceAmount, personalUse, personalUseAmount, carRentalId, notes);
                quantityCar++;
            }
            dr.Close();

            if (quantityCar <= 1)
            {
                btnDeleteCar.Enabled = false;
            }
            else
            {
                btnDeleteCar.Enabled = true;
            }
            this.Size = new System.Drawing.Size(770, 241);
            tlEditButtons.Visible = true;
            dgvEditCar.Enabled = true;
            clearData();




            localCon.Close();

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            isNew = true;
            tlEditButtons.Visible = false;
            this.Size = new System.Drawing.Size(770, 750);
            dgvEditCar.Enabled = false;
        }

        private void setDaysAndDates()
        {

            DateTime pickDate = dtpPickUpDate.Value;
            DateTime dropDate = dtpDropOffDate.Value;
            int diff;
            diff = (dropDate - pickDate).Days;
            diff = diff + 1;
            nudDays.Value = diff;
        }

        private void dtpDropOffDate_ValueChanged(object sender, EventArgs e)
        {
            if (!CommonVariables.viewDetails)
            {
                setDaysAndDates();
            }
        }

        private void dtpPickUpDate_ValueChanged(object sender, EventArgs e)
        {
            if (!CommonVariables.viewDetails)
            {
                dtpDropOffDate.MinDate = dtpPickUpDate.Value.AddDays(1);
                setDaysAndDates();
            }
        }

        private void calculateTotal()
        {
            if (nudDays.Value > 0 && txtCarCost.Text != "" && txtTaxesAndFees.Text != "" && txtLDWInsurance.Text != "" && txtSupplementalInsurance.Text != "")
            {
                double totalCar = 0;
                if (chxExtraInsurance.Checked && txtExtraInsuranceAmount.Text != "")
                {
                    totalCar = (Convert.ToDouble(txtCarCost.Text) * Convert.ToInt32(nudDays.Value)) + Convert.ToDouble(txtTaxesAndFees.Text) + Convert.ToDouble(txtLDWInsurance.Text) + Convert.ToDouble(txtSupplementalInsurance.Text) + Convert.ToDouble(txtExtraInsuranceAmount.Text);

                }
                else
                {
                    totalCar = (Convert.ToDouble(txtCarCost.Text) * Convert.ToInt32(nudDays.Value)) + Convert.ToDouble(txtTaxesAndFees.Text) + Convert.ToDouble(txtLDWInsurance.Text) + Convert.ToDouble(txtSupplementalInsurance.Text);
                }

                txtTotalCar.Text = totalCar.ToString();
            }
        }

        private void txtCarCost_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotal();
        }

        private void txtTaxesAndFees_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotal();
        }

        private void txtLDWInsurance_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotal();
        }

        private void txtSupplementalInsurance_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotal();
        }

        private void txtExtraInsuranceAmount_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotal();
        }

        private void nudDays_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void nudDays_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotal();
        }

        private void chxExtraInsurance_CheckedChanged(object sender, EventArgs e)
        {
            if (chxExtraInsurance.Checked)
            {
                txtExtraInsuranceAmount.Enabled = true;
            }
            else
            {
                txtExtraInsuranceAmount.Enabled = false;
                txtExtraInsuranceAmount.Text = "";
            }

            calculateTotal();
        }

        private void rbYesPeronalIssues_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesPeronalIssues.Checked)
            {
                pPersonalIssuesAmount.Enabled = true;
            }
            else
            {
                pPersonalIssuesAmount.Enabled = false;
                txtPersonalUseAmount.Text = "";
            }
        }

        private void rbNoPersonalIssues_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoPersonalIssues.Checked)
            {
                pPersonalIssuesAmount.Enabled = false;
                txtPersonalUseAmount.Text = "";
            }
        }

        private bool validateData()
        {
            if (cbCarType.SelectedIndex == -1)
            {
                MessageBox.Show("Select a car type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbRentalCompany.SelectedIndex == -1)
            {
                MessageBox.Show("Select a rental company", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCarCost.Text == "")
            {
                MessageBox.Show("Provide the car cost per day", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTaxesAndFees.Text == "")
            {
                MessageBox.Show("Provide the taxes and fees amount or if you do not have any just put 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtLDWInsurance.Text == "")
            {
                MessageBox.Show("Provide the LDW insurance amount or if it is included on the car cost just put 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSupplementalInsurance.Text == "")
            {
                MessageBox.Show("Provide the Supplemental insurance amount or if it is included on the car cost just put 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (chxExtraInsurance.Checked && txtExtraInsuranceAmount.Text == "")
            {
                MessageBox.Show("Provide the Extra insurance amount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (rbYesPeronalIssues.Checked && txtPersonalUseAmount.Text == "")
            {
                MessageBox.Show("Provide the Personal use amount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!rbYesDistrictPay.Checked && !rbNoDistrictPay.Checked)
            {
                MessageBox.Show("Answer the question about the district pay for your car", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!rbYesPeronalIssues.Checked && !rbNoPersonalIssues.Checked)
            {
                MessageBox.Show("Answer the question about the personal use of the car rental", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;

        }

        private void btnSaveCar_Click(object sender, EventArgs e)
        {
            DateTime pickUPDate;
            DateTime dropOffDate;
            string carType = "";
            string rentalCompany = "";
            int days = 0;
            double carCost = 0;
            double taxesAndFees = 0;
            double ldwInsurance = 0;
            double suppInsirance = 0;
            double extraInsAmount = 0;
            bool extraInsurance = false;
            bool districtPay = true;
            bool personalUse = false;
            double personalUseAmount = 0;
            double totalCar = 0;
            string notes = "";
            double travelAmount = 0;
            double travelReim = 0;
            double travelNoReim = 0;

            localCon.Open();
            if (validateData())
            {
                if (isNew)
                {
                    pickUPDate = dtpPickUpDate.Value;
                    dropOffDate = dtpDropOffDate.Value;
                    carType = cbCarType.SelectedItem.ToString();
                    rentalCompany = cbRentalCompany.SelectedItem.ToString();
                    days = Convert.ToInt32(nudDays.Value);
                    carCost = Convert.ToDouble(txtCarCost.Text);
                    taxesAndFees = Convert.ToDouble(txtTaxesAndFees.Text);
                    ldwInsurance = Convert.ToDouble(txtLDWInsurance.Text);
                    suppInsirance = Convert.ToDouble(txtSupplementalInsurance.Text);
                    if (chxExtraInsurance.Checked)
                    {
                        extraInsurance = true;
                        extraInsAmount = Convert.ToDouble(txtExtraInsuranceAmount.Text);
                    }
                    if (rbNoDistrictPay.Checked)
                    {
                        districtPay = false;
                    }
                    if (rbYesPeronalIssues.Checked)
                    {
                        personalUse = true;
                        personalUseAmount = Convert.ToDouble(txtPersonalUseAmount.Text);
                    }
                    else
                    {
                        personalUse = false;
                        personalUseAmount = 0;
                    }

                    totalCar = (carCost * days) + taxesAndFees + ldwInsurance + suppInsirance + extraInsAmount;
                    notes = txtNotes.Text;

                    SqlDataAdapter addCar = new SqlDataAdapter();
                    addCar.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[CarRental] ([PickUPDate],[DropOffDate] ,[CarType],[Company],[Days] ,[CostPerDay],[TaxesAndFees],[LDWInsuranse],[SupplementalInsurance],[ExtarInsurance],[ExtarInsuranceAmount],[DistrictPay],[PersonalUse],[PersonalAmount],[TotalCarRental],[TravelID],[Notes]) VALUES (@PickUPDate,@DropOffDate ,@CarType,@Company,@Days,@CostPerDay,@TaxesAndFees,@LDWInsuranse,@SupplementalInsurance,@ExtarInsurance,@ExtarInsuranceAmount,@DistrictPay,@PersonalUse,@PersonalAmount,@TotalCarRental,@TravelID,@Notes)", localCon);
                    addCar.InsertCommand.Parameters.Add("@PickUPDate", SqlDbType.DateTime).Value = pickUPDate;
                    addCar.InsertCommand.Parameters.Add("@DropOffDate", SqlDbType.DateTime).Value = dropOffDate;
                    addCar.InsertCommand.Parameters.Add("@CarType", SqlDbType.NVarChar).Value = carType;
                    addCar.InsertCommand.Parameters.Add("@Company", SqlDbType.NVarChar).Value = rentalCompany;
                    addCar.InsertCommand.Parameters.Add("@Days", SqlDbType.Int).Value = days;
                    addCar.InsertCommand.Parameters.Add("@CostPerDay", SqlDbType.Float).Value = carCost;
                    addCar.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = taxesAndFees;
                    addCar.InsertCommand.Parameters.Add("@LDWInsuranse", SqlDbType.Float).Value = ldwInsurance;
                    addCar.InsertCommand.Parameters.Add("@SupplementalInsurance", SqlDbType.Float).Value = suppInsirance;
                    addCar.InsertCommand.Parameters.Add("@ExtarInsurance", SqlDbType.Bit).Value = extraInsurance;
                    addCar.InsertCommand.Parameters.Add("@ExtarInsuranceAmount", SqlDbType.Float).Value = extraInsAmount;
                    addCar.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = districtPay;
                    addCar.InsertCommand.Parameters.Add("@PersonalUse", SqlDbType.Bit).Value = personalUse;
                    addCar.InsertCommand.Parameters.Add("@PersonalAmount", SqlDbType.Float).Value = personalUseAmount;
                    addCar.InsertCommand.Parameters.Add("@TotalCarRental", SqlDbType.Float).Value = totalCar;
                    addCar.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = edittravelID;
                    addCar.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = notes;
                    int ri = addCar.InsertCommand.ExecuteNonQuery();

                    if (ri > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        while (dr2.Read())
                        {
                            travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                            travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                            travelNoReim = Convert.ToDouble(dr2["TotalTravelNoReimbursed"].ToString());

                        }
                        dr2.Close();

                        travelAmount = travelAmount + totalCar;
                        if (!districtPay)
                        {
                            if (personalUse)
                            {
                                double diffTotalCar = totalCar - personalUseAmount;
                                travelReim = travelReim + diffTotalCar;
                            }
                            else
                            {
                                travelReim = travelReim + totalCar;
                            }

                        }
                        else
                        {
                            if (personalUse)
                            {
                                travelNoReim = travelNoReim + personalUseAmount;
                            }

                        }


                        SqlDataAdapter upTravel = new SqlDataAdapter();
                        upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed,@TotalTravelNoReimbursed = TotalTravelNoReimbursed  WHERE TravelID ='" + edittravelID + "'", localCon);
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelNoReimbursed", SqlDbType.Float).Value = travelNoReim;
                        int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                        localCon.Close();
                        if (ru > 0)
                        {
                            MessageBox.Show("Car Rental inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshCarRental();
                            isNew = false;
                            if (backgroundWorker1.IsBusy != true)
                            {
                                backgroundWorker1.RunWorkerAsync();
                            }
                        }
                    }

                }
                else
                {
                    bool oriDistricPay = true;
                    double oriCarAmount = 0;
                    bool oriPersonalUse = false;
                    double oriPersonalUseAmount = 0;

                    SqlCommand cmd = new SqlCommand("SELECT [DistrictPay],[TotalCarRental],[PersonalUse],[PersonalAmount] FROM [TravelExpenses].[dbo].[CarRental] where CarRentalID = '" + editCarRID + "'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        oriDistricPay = Convert.ToBoolean(dr["DistrictPay"].ToString());
                        oriCarAmount = Convert.ToDouble(dr["TotalCarRental"].ToString());
                        oriPersonalUse = Convert.ToBoolean(dr["PersonalUse"].ToString());
                        oriPersonalUseAmount = Convert.ToDouble(dr["PersonalAmount"].ToString());
                    }
                    dr.Close();

                    SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                        travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                        travelNoReim = Convert.ToDouble(dr2["TotalTravelNoReimbursed"].ToString());
                    }
                    dr2.Close();

                    travelAmount = travelAmount - oriCarAmount;
                    if (!oriDistricPay)
                    {
                        if (oriPersonalUse)
                        {
                            double diffCRNew = oriCarAmount - oriPersonalUseAmount;
                            travelReim = travelReim - diffCRNew;
                        }
                        else
                        {
                            travelReim = travelReim - oriCarAmount;
                        }
                    }
                    else
                    {
                        if (oriPersonalUse)
                        {
                            travelNoReim = travelNoReim - oriPersonalUseAmount;
                        }
                    }

                    pickUPDate = dtpPickUpDate.Value;
                    dropOffDate = dtpDropOffDate.Value;
                    carType = cbCarType.SelectedItem.ToString();
                    rentalCompany = cbRentalCompany.SelectedItem.ToString();
                    days = Convert.ToInt32(nudDays.Value);
                    carCost = Convert.ToDouble(txtCarCost.Text);
                    taxesAndFees = Convert.ToDouble(txtTaxesAndFees.Text);
                    ldwInsurance = Convert.ToDouble(txtLDWInsurance.Text);
                    suppInsirance = Convert.ToDouble(txtSupplementalInsurance.Text);
                    if (chxExtraInsurance.Checked)
                    {
                        extraInsurance = true;
                        extraInsAmount = Convert.ToDouble(txtExtraInsuranceAmount.Text);
                    }
                    if (rbNoDistrictPay.Checked)
                    {
                        districtPay = false;
                    }
                    if (rbYesPeronalIssues.Checked)
                    {
                        personalUse = true;
                        personalUseAmount = Convert.ToDouble(txtPersonalUseAmount.Text);
                    }

                    totalCar = (carCost * days) + taxesAndFees + ldwInsurance + suppInsirance + extraInsAmount;
                    notes = txtNotes.Text;

                    SqlDataAdapter upCar = new SqlDataAdapter();
                    upCar.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[CarRental] SET [PickUPDate] = @PickUPDate ,[DropOffDate] = @DropOffDate,[CarType] = @CarType,[Company] = @Company,[Days] = @Days,[CostPerDay] = @CostPerDay,[TaxesAndFees] = @TaxesAndFees,[LDWInsuranse] = @LDWInsuranse,[SupplementalInsurance] = @SupplementalInsurance,[ExtarInsurance] = @ExtarInsurance,[ExtarInsuranceAmount] = @ExtarInsuranceAmount,[DistrictPay] = @DistrictPay,[PersonalUse] = @PersonalUse,[PersonalAmount] = @PersonalAmount,[TotalCarRental] = @TotalCarRental,[Notes] = @Notes WHERE CarRentalID = '" + editCarRID + "'", localCon);

                    upCar.UpdateCommand.Parameters.Add("@PickUPDate", SqlDbType.DateTime).Value = pickUPDate;
                    upCar.UpdateCommand.Parameters.Add("@DropOffDate", SqlDbType.DateTime).Value = dropOffDate;
                    upCar.UpdateCommand.Parameters.Add("@CarType", SqlDbType.NVarChar).Value = carType;
                    upCar.UpdateCommand.Parameters.Add("@Company", SqlDbType.NVarChar).Value = rentalCompany;
                    upCar.UpdateCommand.Parameters.Add("@Days", SqlDbType.Int).Value = days;
                    upCar.UpdateCommand.Parameters.Add("@CostPerDay", SqlDbType.Float).Value = carCost;
                    upCar.UpdateCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = taxesAndFees;
                    upCar.UpdateCommand.Parameters.Add("@LDWInsuranse", SqlDbType.Float).Value = ldwInsurance;
                    upCar.UpdateCommand.Parameters.Add("@SupplementalInsurance", SqlDbType.Float).Value = suppInsirance;
                    upCar.UpdateCommand.Parameters.Add("@ExtarInsurance", SqlDbType.Bit).Value = extraInsurance;
                    upCar.UpdateCommand.Parameters.Add("@ExtarInsuranceAmount", SqlDbType.Float).Value = extraInsAmount;
                    upCar.UpdateCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = districtPay;
                    upCar.UpdateCommand.Parameters.Add("@PersonalUse", SqlDbType.Bit).Value = personalUse;
                    upCar.UpdateCommand.Parameters.Add("@PersonalAmount", SqlDbType.Float).Value = personalUseAmount;
                    upCar.UpdateCommand.Parameters.Add("@TotalCarRental", SqlDbType.Float).Value = totalCar;
                    upCar.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = notes;
                    int ru = upCar.UpdateCommand.ExecuteNonQuery();

                    if (ru > 0)
                    {
                        travelAmount = travelAmount + totalCar;

                        if (!districtPay)
                        {
                            if (personalUse)
                            {
                                double diffTotalCar = totalCar - personalUseAmount;
                                travelReim = travelReim + diffTotalCar;
                            }
                            else
                            {
                                travelReim = travelReim + totalCar;
                            }

                        }
                        else
                        {
                            if (personalUse)
                            {
                                travelNoReim = travelNoReim + personalUseAmount;
                            }

                        }


                        SqlDataAdapter upTravel = new SqlDataAdapter();
                        upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed,[TotalTravelNoReimbursed] = @TotalTravelNoReimbursed  WHERE TravelID ='" + edittravelID + "'", localCon);
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelNoReimbursed", SqlDbType.Float).Value = travelNoReim;
                        int rut = upTravel.UpdateCommand.ExecuteNonQuery();
                        localCon.Close();
                        if (rut > 0)
                        {
                            MessageBox.Show("Car Rental updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshCarRental();
                            if (backgroundWorker1.IsBusy != true)
                            {
                                backgroundWorker1.RunWorkerAsync();
                            }
                        }
                    }

                }


            }

            localCon.Close();
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvEditCar.CurrentRow.Index;
            string carID = dgvEditCar.Rows[rowIndex].Cells[15].Value.ToString();
            editCarRID = new Guid(carID);

            dtpPickUpDate.Value = Convert.ToDateTime(dgvEditCar.Rows[rowIndex].Cells[0].Value.ToString());
            dtpDropOffDate.Value = Convert.ToDateTime(dgvEditCar.Rows[rowIndex].Cells[1].Value.ToString());
            cbCarType.SelectedItem = dgvEditCar.Rows[rowIndex].Cells[5].Value.ToString();
            cbRentalCompany.SelectedItem = dgvEditCar.Rows[rowIndex].Cells[6].Value.ToString();
            nudDays.Value = Convert.ToInt32(dgvEditCar.Rows[rowIndex].Cells[7].Value.ToString());
            txtCarCost.Text = dgvEditCar.Rows[rowIndex].Cells[2].Value.ToString();
            txtTaxesAndFees.Text = dgvEditCar.Rows[rowIndex].Cells[8].Value.ToString();
            txtLDWInsurance.Text = dgvEditCar.Rows[rowIndex].Cells[9].Value.ToString();
            txtSupplementalInsurance.Text = dgvEditCar.Rows[rowIndex].Cells[10].Value.ToString();
            chxExtraInsurance.Checked = Convert.ToBoolean(dgvEditCar.Rows[rowIndex].Cells[11].Value);
            if (chxExtraInsurance.Checked)
            {
                txtExtraInsuranceAmount.Text = dgvEditCar.Rows[rowIndex].Cells[12].Value.ToString();
                txtExtraInsuranceAmount.Enabled = true;
            }
            txtTotalCar.Text = dgvEditCar.Rows[rowIndex].Cells[4].Value.ToString();
            if (dgvEditCar.Rows[rowIndex].Cells[3].Value.ToString() == "True")
            {
                rbYesDistrictPay.Checked = true;

            }
            else
            {
                rbNoDistrictPay.Checked = true;
            }
            if (dgvEditCar.Rows[rowIndex].Cells[13].Value.ToString() == "True")
            {
                rbYesPeronalIssues.Checked = true;
                pPersonalIssuesAmount.Enabled = true;
                txtPersonalUseAmount.Text = dgvEditCar.Rows[rowIndex].Cells[14].Value.ToString();
            }
            else
            {
                rbNoPersonalIssues.Checked = true;
            }

            txtNotes.Text = dgvEditCar.Rows[rowIndex].Cells[16].Value.ToString();


            this.Size = new System.Drawing.Size(770, 750);
            tlEditButtons.Visible = false;
            dgvEditCar.Enabled = false;

        }

        private void clearData()
        {
            dtpPickUpDate.Value = DateTime.Today;
            dtpDropOffDate.Value = DateTime.Today.AddDays(1);
            setDaysAndDates();
            cbCarType.SelectedIndex = -1;
            cbRentalCompany.SelectedIndex = -1;
            txtCarCost.Text = "";
            txtTaxesAndFees.Text = "0";
            txtLDWInsurance.Text = "0";
            txtSupplementalInsurance.Text = "0";
            chxExtraInsurance.Checked = false;
            txtExtraInsuranceAmount.Text = "";
            rbYesDistrictPay.Checked = false;
            rbNoDistrictPay.Checked = false;
            rbYesPeronalIssues.Checked = false;
            rbNoPersonalIssues.Checked = false;
            txtPersonalUseAmount.Text = "";
            pPersonalIssuesAmount.Enabled = false;
            txtTotalCar.Text = "";
            txtNotes.Text = "";

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(770, 241);
            tlEditButtons.Visible = true;
            dgvEditCar.Enabled = true;
            clearData();
        }

        private void btnCancelEditCar_Click(object sender, EventArgs e)
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

        private void txtCarCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTaxesAndFees_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLDWInsurance_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSupplementalInsurance_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtExtraInsuranceAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTotalCar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPersonalUseAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tlEditButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEditCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pCarData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CommonVariables.sendChangesNotification(edittravelID);
        }

        private void txtTotalCar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalCar_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCarCost.Text != "" && nudDays.Value > 0 && txtTotalCar.Text != "")
            {
                double totalValue = Convert.ToDouble(txtTotalCar.Text.ToString());
                double carCostValue = totalValue / Convert.ToInt32(nudDays.Value);
                txtCarCost.Text = carCostValue.ToString();
            }
        }
    }
}
