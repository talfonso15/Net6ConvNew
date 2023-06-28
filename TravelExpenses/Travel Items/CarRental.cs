using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TravelExpenses
{
    public partial class CarRental : Form
    {
        public CarRental()
        {
            InitializeComponent();
        }

        private void CarRental_Load(object sender, EventArgs e)
        {
            dtpDropOffDateCarRental.Value = DateTime.Today.AddDays(1);
            DateTime pickDate = dtpPickUpDateCarRental.Value;
            DateTime dropDate = dtpDropOffDateCarRental.Value;
            int diff;
            diff = (dropDate - pickDate).Days;
            diff = diff + 1;

            nudDays.Value = diff;
            txtSupplementalInsurance.Text = "0";
            txtLDWInsurance.Text = "0";
            txtCarTaxesAndFees.Text = "0";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbYesPersonalUseCarRental_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesPersonalUseCarRental.Checked == true)
            {
                pPersonalAmount.Enabled = true;
            }
        }

        private void rbNoPersonalUseCarRental_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoPersonalUseCarRental.Checked == true)
            {
                pPersonalAmount.Enabled = false;
            }
        }

        private void btnAddCarRental_Click(object sender, EventArgs e)
        {
            bool validate = addingValidations();
            if (validate)
            {
                bool districtPay = false;
                bool personalUse = false;
                double personalUseAmount = 0;
                if (rbYesDistrictPayCarRental.Checked == true)
                {
                    districtPay = true;
                }
                else if (rbNoDistrictPayCarRental.Checked == true)
                {

                    districtPay = false;
                }
                if (rbYesPersonalUseCarRental.Checked == true)
                {
                    personalUse = true;
                    personalUseAmount = Convert.ToDouble(txtPersonalAmountCarRental.Text);
                }
                else if (rbNoPersonalUseCarRental.Checked == true)
                {
                    personalUse = false;
                    personalUseAmount = 0;
                }

                DateTime pikUpDate = dtpPickUpDateCarRental.Value.Date;
                DateTime dropOffDate = dtpDropOffDateCarRental.Value.Date;
                string carType = cbCarType.SelectedItem.ToString();
                string rentalCOmpany = cbRentalCompany.SelectedItem.ToString();
                string days = nudDays.Value.ToString();
                string carCost = txtCarCost.Text;
                string taxesAndFees = txtCarTaxesAndFees.Text;
                string TotalCaRental = txtTotalCarRental.Text;
                string notes = txtNotesCarRental.Text;
                string ldwInsurance = txtLDWInsurance.Text;
                string supplementalIns = txtSupplementalInsurance.Text;
                bool extraIns = chxExtraInsurance.Checked;
                string extraInsAmount = "";
                if (extraIns == true)
                {
                    extraInsAmount = txtExtraInsuranceAmount.Text;
                }


                dgvCarRental.Rows.Add(pikUpDate.ToShortDateString(), dropOffDate.ToShortDateString(), carType, rentalCOmpany, days, carCost, taxesAndFees, districtPay, personalUse, personalUseAmount.ToString(), ldwInsurance, supplementalIns, extraIns, extraInsAmount, TotalCaRental, notes);

                dtpPickUpDateCarRental.Value = DateTime.Today;
                dtpDropOffDateCarRental.Value = DateTime.Today.AddDays(1);
                cbCarType.SelectedIndex = -1;
                cbRentalCompany.SelectedIndex = -1;
                nudDays.Value = 1;
                txtCarCost.Text = "";
                txtCarTaxesAndFees.Text = "0";
                txtTotalCarRental.Text = "";
                rbNoDistrictPayCarRental.Checked = false;
                rbYesDistrictPayCarRental.Checked = true;
                rbNoPersonalUseCarRental.Checked = true;
                rbYesPersonalUseCarRental.Checked = false;
                pPersonalAmount.Visible = false;
                txtPersonalAmountCarRental.Text = "";
                txtNotesCarRental.Text = "";
                txtLDWInsurance.Text = "0";
                txtSupplementalInsurance.Text = "0";
                chxExtraInsurance.Checked = false;
                txtExtraInsuranceAmount.Enabled = false;
                txtExtraInsuranceAmount.Text = "";


            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotalCar();
            //dailyCostCalculation();
        }

        private void btnNextCarRental_Click(object sender, EventArgs e)
        {
            bool validate = nextValidation();
            if (validate)
            {
                int rowCount = dgvCarRental.RowCount;
                if (rowCount > CommonVariables.crcl.Count)
                {
                    CommonVariables.crcl.Clear();

                    for (int i = 0; i < rowCount; i++)
                    {
                        CarRentalcl carR = new CarRentalcl();
                        carR.PickUpDate = Convert.ToDateTime(dgvCarRental.Rows[i].Cells[0].Value);
                        carR.DropOffDate = Convert.ToDateTime(dgvCarRental.Rows[i].Cells[1].Value);
                        carR.CarType = dgvCarRental.Rows[i].Cells[2].Value.ToString();
                        carR.Company = dgvCarRental.Rows[i].Cells[3].Value.ToString();
                        carR.Days = Convert.ToInt32(dgvCarRental.Rows[i].Cells[4].Value);
                        carR.CostPerDay = Convert.ToDouble(dgvCarRental.Rows[i].Cells[5].Value);
                        carR.TaxesAndFees = Convert.ToDouble(dgvCarRental.Rows[i].Cells[6].Value);
                        carR.DistrictPay = Convert.ToBoolean(dgvCarRental.Rows[i].Cells[7].Value);
                        carR.PersonalUse = Convert.ToBoolean(dgvCarRental.Rows[i].Cells[8].Value);
                        carR.PersonalUseAmount = Convert.ToDouble(dgvCarRental.Rows[i].Cells[9].Value);
                        carR.LDWInsuranse = Convert.ToDouble(dgvCarRental.Rows[i].Cells[10].Value);
                        carR.SupplementalInsurance = Convert.ToDouble(dgvCarRental.Rows[i].Cells[11].Value);
                        carR.ExtraInsurance = Convert.ToBoolean(dgvCarRental.Rows[i].Cells[12].Value);
                        if (Convert.ToBoolean(dgvCarRental.Rows[i].Cells[12].Value) == true)
                        {
                            carR.ExtraInsuranceAmount = Convert.ToDouble(dgvCarRental.Rows[i].Cells[13].Value);
                        }
                        else
                        {
                            carR.ExtraInsuranceAmount = 0;
                        }
                        carR.TotalCarRental = Convert.ToDouble(dgvCarRental.Rows[i].Cells[14].Value);
                        carR.Notes = dgvCarRental.Rows[i].Cells[15].Value.ToString();

                        CommonVariables.crcl.Add(carR);
                    }
                }


                //checking open forms
                FormCollection fc = Application.OpenForms;
                Form main = new Form();
                foreach (Form frm in fc)
                {
                    string name = frm.Name;
                    if (frm.Name == "Main")
                    {
                        main = frm;
                    }
                }
                Form[] childs = main.MdiChildren;

                if (!CommonVariables.isSummary)
                {
                    if (CommonVariables.isAirFare == true)
                    {
                        bool flightFormFound = false;
                        foreach (Form child in childs)
                        {
                            string name = child.Name;
                            if (child.Name == "AirFare")
                            {
                                child.Focus();
                                child.Show();

                                flightFormFound = true;
                            }
                        }
                        if (!flightFormFound)
                        {
                            AirFare af = new AirFare();
                            af.MdiParent = main;
                            af.Show();
                        }
                    }
                    else if (CommonVariables.isMileage == true)
                    {
                        bool mileageFormFound = false;
                        foreach (Form child in childs)
                        {
                            string name = child.Name;
                            if (child.Name == "Mileage")
                            {
                                child.Focus();
                                child.Show();

                                mileageFormFound = true;
                            }
                        }
                        if (!mileageFormFound)
                        {
                            Mileage ml = new Mileage();
                            ml.MdiParent = main;
                            ml.Show();
                        }
                    }
                    else if (CommonVariables.isOtherExpenses == true)
                    {
                        bool oxFormFound = false;
                        foreach (Form child in childs)
                        {
                            string name = child.Name;
                            if (child.Name == "OtherExpenses")
                            {
                                child.Focus();
                                child.Show();

                                oxFormFound = true;
                            }
                        }
                        if (!oxFormFound)
                        {
                            OtherExpenses ox = new OtherExpenses();
                            ox.MdiParent = main;
                            ox.Show();
                        }
                    }
                    else
                    {
                        Summary sm = new Summary();
                        sm.MdiParent = main;
                        sm.Show();
                    }
                }
                else
                {
                    CommonVariables.isSummary = false;
                    Summary sm = new Summary();
                    sm.MdiParent = main;
                    sm.Show();
                }

                this.Hide();
            }
        }

        private void chxExtraInsurance_CheckedChanged(object sender, EventArgs e)
        {
            if (chxExtraInsurance.Checked == true)
            {

                txtExtraInsuranceAmount.Enabled = true;
            }
            else
            {
                txtExtraInsuranceAmount.Enabled = false;
                txtExtraInsuranceAmount.Text = "";
            }
            //calculateTotalCar();
        }

        private void txtSupplementalInsurance_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotalCar();
            //dailyCostCalculation();
        }

        private void txtExtraInsuranceAmount_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotalCar();
            //dailyCostCalculation();
        }

        private bool addingValidations()
        {


            if (cbCarType.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Car Type", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbRentalCompany.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Rental Company", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nudDays.Value <= 0)
            {
                MessageBox.Show("Enter the number of Days", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCarCost.Text == "")
            {
                MessageBox.Show("Enter the Car Cost Per Day", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCarTaxesAndFees.Text == "")
            {
                MessageBox.Show("Enter the Taxes and Fees or if you do not have any put zero", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtLDWInsurance.Text == "")
            {
                MessageBox.Show("Enter the LDW Insurance Amount or if this amount is included on the cost per day just put zero", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSupplementalInsurance.Text == "")
            {
                MessageBox.Show("Enter the Supplemental Insurance Amount or if this amount is included on the cost per day just put zero", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (chxExtraInsurance.Checked == true && txtExtraInsuranceAmount.Text == "")
            {
                MessageBox.Show("Enter the Extra Insurance Amount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTotalCarRental.Text == "")
            {
                MessageBox.Show("Enter your travel total amount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool nextValidation()
        {
            int carCount = dgvCarRental.RowCount;
            if (carCount <= 0)
            {
                MessageBox.Show("Add at least one car rental", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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

        private void txtCarTaxesAndFees_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPersonalAmountCarRental_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dtpDropOffDateCarRental_ValueChanged(object sender, EventArgs e)
        {
            DateTime pickDate = dtpPickUpDateCarRental.Value;
            DateTime dropDate = dtpDropOffDateCarRental.Value;
            int diff;
            diff = (dropDate - pickDate).Days;
            diff = diff + 1;

            nudDays.Value = diff;
            //dailyCostCalculation();
            calculateTotalCar();
        }

        private void dtpPickUpDateCarRental_ValueChanged(object sender, EventArgs e)
        {
            dtpDropOffDateCarRental.MinDate = dtpPickUpDateCarRental.Value.AddDays(1);
            DateTime pickDate = dtpPickUpDateCarRental.Value;
            DateTime dropDate = dtpDropOffDateCarRental.Value;
            int diff;
            diff = (dropDate - pickDate).Days;
            diff = diff + 1;

            nudDays.Value = diff;
            //dailyCostCalculation();
            calculateTotalCar();
        }

        private void btnBackCarRental_Click(object sender, EventArgs e)
        {
            CommonVariables.isSummary = false;
            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                }
            }
            Form[] childs = main.MdiChildren;
            //int cant = Application.OpenForms.Count;
            bool FormFound = false;
            if (CommonVariables.isLodging == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Lodging")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isRegistartion == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Registration")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isMeals == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Meals")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isMeals == false)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "TravelItems")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            if (FormFound)
            {
                this.Hide();
            }
        }

        private void btnCancelCarRental_Click(object sender, EventArgs e)
        {
            CommonVariables.CancelTravel();
        }

        /* private void CarRental_FormClosed(object sender, FormClosedEventArgs e)
         {
             CommonVariables.CancelTravel();
         }*/

        private void calculateTotalCar()
        {
            if (nudDays.Value > 0 && txtCarCost.Text != "" && txtCarTaxesAndFees.Text != "" && txtLDWInsurance.Text != "" && txtSupplementalInsurance.Text != "")
            {
                double totalCar = 0;
                if (chxExtraInsurance.Checked && txtExtraInsuranceAmount.Text != "")
                {
                    totalCar = (Convert.ToDouble(txtCarCost.Text) * Convert.ToInt32(nudDays.Value)) + Convert.ToDouble(txtCarTaxesAndFees.Text) + Convert.ToDouble(txtLDWInsurance.Text) + Convert.ToDouble(txtSupplementalInsurance.Text) + Convert.ToDouble(txtExtraInsuranceAmount.Text);
                    txtTotalCarRental.Text = totalCar.ToString();
                }
                else
                {
                    totalCar = (Convert.ToDouble(txtCarCost.Text) * Convert.ToInt32(nudDays.Value)) + Convert.ToDouble(txtCarTaxesAndFees.Text) + Convert.ToDouble(txtLDWInsurance.Text) + Convert.ToDouble(txtSupplementalInsurance.Text);
                    txtTotalCarRental.Text = totalCar.ToString();
                }
            }
        }

        private void nudDays_ValueChanged(object sender, EventArgs e)
        {
            calculateTotalCar();
            //dailyCostCalculation();
        }

        private void nudDays_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotalCar();
            //dailyCostCalculation();
        }

        private void txtCarCost_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotalCar();

        }

        private void txtLDWInsurance_KeyUp(object sender, KeyEventArgs e)
        {
            calculateTotalCar();
            //dailyCostCalculation();
        }

        private void dailyCostCalculation()
        {
            if (txtTotalCarRental.Text != "")
            {
                /*double supIns = Convert.ToDouble(txtSupplementalInsurance.Text);
                double LDWIns = Convert.ToDouble(txtLDWInsurance.Text);
                double taxAndFees = Convert.ToDouble(txtCarTaxesAndFees.Text);
                int days = Convert.ToInt32(nudDays.Value);
                double extraInsurance = 0;
                double costPerday = 0;
                if (txtExtraInsuranceAmount.Text != "")
                {
                    extraInsurance = Convert.ToDouble(txtExtraInsuranceAmount.Text);
                }
                double carTotal = Convert.ToDouble(txtTotalCarRental.Text);
                carTotal = carTotal - supIns - LDWIns - taxAndFees - extraInsurance;
                costPerday = carTotal / days;
                costPerday = Math.Round(costPerday, 2);
                txtCarCost.Text = costPerday.ToString();*/

                int days = Convert.ToInt32(nudDays.Value);
                double costPerday = 0;
                double carTotal = Convert.ToDouble(txtTotalCarRental.Text);
                costPerday = carTotal / days;
                costPerday = Math.Round(costPerday, 2);
                txtCarCost.Text = costPerday.ToString();
            }
        }

        private void txtTotalCarRental_KeyUp(object sender, KeyEventArgs e)
        {
            dailyCostCalculation();
        }

        private void dgvCarRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvCarRental.CurrentCell.RowIndex;
            int columnindex = dgvCarRental.CurrentCell.ColumnIndex;

            if (columnindex == 16)
            {
                string pickUffDate = dgvCarRental.Rows[rowindex].Cells[0].Value.ToString();
                dgvCarRental.Rows.RemoveAt(rowindex);
                if (CommonVariables.crcl.Count > 0)
                {
                    for (int i = 0; i < CommonVariables.crcl.Count; i++)
                    {
                        if (CommonVariables.crcl[i].PickUpDate.ToShortDateString() == pickUffDate)
                        {
                            CommonVariables.crcl.RemoveAt(i);
                        }
                    }
                }
            }
        }

        private void lblCarCost_Click(object sender, EventArgs e)
        {

        }
    }
}
