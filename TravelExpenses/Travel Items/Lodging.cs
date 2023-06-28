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
    public partial class Lodging : Form
    {
        public Lodging()
        {
            InitializeComponent();
        }

        private void Lodging_Load(object sender, EventArgs e)
        {
            txtTaxesAndFees.Text = "0";
            txtOtherTaxesAndFees.Text = "0";
            nudNumberNights.Value = CommonVariables.totalDaysMeals;
        }


        private void btnAddLodging_Click(object sender, EventArgs e)
        {
            bool validate = addingValidations();
            if (validate)
            {
                bool districtPay;
                bool directorApproved;
                if (rbYesDistrictPayLodging.Checked == true)
                {
                    districtPay = true;
                }
                else
                {
                    districtPay = false;
                }
                if (rbYesApprovedLodging.Checked == true)
                {
                    directorApproved = true;
                }
                else
                {
                    directorApproved = false;
                }

                double nightCost = Convert.ToDouble(txtCostPerNight.Text) + Convert.ToDouble(txtTaxesAndFees.Text);

                dtgLodgings.Rows.Add(txtFacilityName.Text, nudNumberNights.Value.ToString(), nightCost.ToString(), txtOtherTaxesAndFees.Text, txtTotal.Text, districtPay, directorApproved, txtLodgingNotes.Text, txtTaxesAndFees.Text);
                txtFacilityName.Text = "";
                txtCostPerNight.Text = "0";
                txtCostPerNight.Text = "";
                txtTaxesAndFees.Text = "0";
                txtTotal.Text = "";
                txtLodgingNotes.Text = "";
                pnDirectorApprovedLodging.Visible = false;
                rbYesDistrictPayLodging.Checked = true;
                rbNoDistrictPayLodging.Checked = false;
                //nudNumberNights.Value = 0; this is before deleting then cost per night requested by Jessica
                txtOtherTaxesAndFees.Text = "0";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool validate = nextValidation();
            if (validate)
            {
                int rowsNumber = dtgLodgings.RowCount;
                if (rowsNumber > CommonVariables.lcl.Count)
                {
                    CommonVariables.lcl.Clear();

                    for (int i = 0; i < rowsNumber; i++)
                    {
                        Lodgingcl lod = new Lodgingcl();
                        lod.FacilityName = dtgLodgings.Rows[i].Cells[0].Value.ToString();
                        lod.NumberOfNights = Convert.ToInt32(dtgLodgings.Rows[i].Cells[1].Value);
                        lod.CostPerNight = Convert.ToDouble(dtgLodgings.Rows[i].Cells[2].Value);
                        lod.TaxesAndFees = Convert.ToDouble(dtgLodgings.Rows[i].Cells[3].Value);
                        lod.TotalLodging = Convert.ToDouble(dtgLodgings.Rows[i].Cells[4].Value);
                        lod.DistrictPay = Convert.ToBoolean(dtgLodgings.Rows[i].Cells[5].Value);
                        lod.DirectorApproved = Convert.ToBoolean(dtgLodgings.Rows[i].Cells[6].Value);
                        lod.Notes = dtgLodgings.Rows[i].Cells[7].Value.ToString();
                        lod.FeesPerNight = Convert.ToDouble(dtgLodgings.Rows[i].Cells[8].Value);
                        CommonVariables.lcl.Add(lod);
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

                    if (CommonVariables.isCarRental == true)
                    {
                        bool carFormFound = false;
                        foreach (Form child in childs)
                        {
                            string name = child.Name;
                            if (child.Name == "CarRental")
                            {
                                child.Focus();
                                child.Show();

                                carFormFound = true;
                            }
                        }
                        if (!carFormFound)
                        {
                            CarRental cr = new CarRental();
                            cr.MdiParent = main;
                            cr.Show();
                        }
                    }
                    else if (CommonVariables.isAirFare == true)
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

        private void rbNoDistrictPayLodging_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoDistrictPayLodging.Checked == true)
            {
                pnDirectorApprovedLodging.Visible = true;
            }
        }

        private void rbYesDistrictPayLodging_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesDistrictPayLodging.Checked == true)
            {

                pnDirectorApprovedLodging.Visible = false;
                rbYesApprovedLodging.Checked = false;
                rbNoApprovedLodging.Checked = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CommonVariables.CancelTravel();
        }

        private void btnBack_Click(object sender, EventArgs e)
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

            if (CommonVariables.isRegistartion == true)
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

        private bool addingValidations()
        {
            if (txtFacilityName.Text == "")
            {
                MessageBox.Show("Enter the facility name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (nudNumberNights.Value <= 0)
            {
                MessageBox.Show("Enter the number of night", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtCostPerNight.Text == "")
            {
                MessageBox.Show("Enter the cost per night", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtTaxesAndFees.Text == "")
            {
                MessageBox.Show("Enter the taxes and fees per night or if you do not have any just put zero", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtOtherTaxesAndFees.Text == "")
            {
                MessageBox.Show("Enter other taxes and fees or if you do not have any just put zero", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTotal.Text == "")
            {
                MessageBox.Show("Enter the total amount of your lodging", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool nextValidation()
        {
            int cantLodg = dtgLodgings.RowCount;
            //cantLodg = cantLodg - 1;
            if (cantLodg <= 0)
            {
                MessageBox.Show("Add at least one lodging", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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

        /* private void Lodging_FormClosed(object sender, FormClosedEventArgs e)
         {
             CommonVariables.CancelTravel();
         }*/

        private void txtTaxesAndFees_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCostPerNight.Text != "" && txtTaxesAndFees.Text != "" && nudNumberNights.Value > 0 && txtOtherTaxesAndFees.Text != "")
            {
                double totalPerNight = Convert.ToDouble(txtCostPerNight.Text) + Convert.ToDouble(txtTaxesAndFees.Text);
                double totalLod = (totalPerNight * Convert.ToInt32(nudNumberNights.Value)) + Convert.ToDouble(txtOtherTaxesAndFees.Text);
                txtTotal.Text = totalLod.ToString();
            }
        }

        private void nudNumberNights_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCostPerNight.Text != "" && txtTaxesAndFees.Text != "" && nudNumberNights.Value > 0 && txtOtherTaxesAndFees.Text != "")
            {
                double totalPerNight = Convert.ToDouble(txtCostPerNight.Text) + Convert.ToDouble(txtTaxesAndFees.Text);
                double totalLod = (totalPerNight * Convert.ToInt32(nudNumberNights.Value)) + Convert.ToDouble(txtOtherTaxesAndFees.Text);
                txtTotal.Text = totalLod.ToString();
            }
        }

        private void txtCostPerNight_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCostPerNight.Text != "" && txtTaxesAndFees.Text != "" && nudNumberNights.Value > 0 && txtOtherTaxesAndFees.Text != "")
            {
                double totalPerNight = Convert.ToDouble(txtCostPerNight.Text) + Convert.ToDouble(txtTaxesAndFees.Text);
                double totalLod = (totalPerNight * Convert.ToInt32(nudNumberNights.Value)) + Convert.ToDouble(txtOtherTaxesAndFees.Text);
                txtTotal.Text = totalLod.ToString();
            }
        }

        private void nudNumberNights_ValueChanged(object sender, EventArgs e)
        {
            if (txtCostPerNight.Text != "" && txtTaxesAndFees.Text != "" && nudNumberNights.Value > 0 && txtOtherTaxesAndFees.Text != "")
            {
                double totalPerNight = Convert.ToDouble(txtCostPerNight.Text) + Convert.ToDouble(txtTaxesAndFees.Text);
                double totalLod = (totalPerNight * Convert.ToInt32(nudNumberNights.Value)) + Convert.ToDouble(txtOtherTaxesAndFees.Text);
                txtTotal.Text = totalLod.ToString();
            }
        }

        private void txtOtherTaxesAndFees_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtCostPerNight.Text != "" && txtTaxesAndFees.Text != "" && nudNumberNights.Value > 0 && txtOtherTaxesAndFees.Text != "")
            {
                double totalPerNight = Convert.ToDouble(txtCostPerNight.Text) + Convert.ToDouble(txtTaxesAndFees.Text);
                double totalLod = (totalPerNight * Convert.ToInt32(nudNumberNights.Value)) + Convert.ToDouble(txtOtherTaxesAndFees.Text);
                txtTotal.Text = totalLod.ToString();
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

        private void txtTotal_KeyUp(object sender, KeyEventArgs e)
        {
            // if (rbYesDiffRates.Checked && nudNumberNights.Value.ToString() != "0" && txtTotal.Text != "") this is before deleting the cost per nigh requested by jessica
            if (nudNumberNights.Value.ToString() != "0" && txtTotal.Text != "")
            {
                double total = Convert.ToDouble(txtTotal.Text);
                int totalNights = Convert.ToInt32(nudNumberNights.Value.ToString());
                double costPerNight = 0;
                if (txtTaxesAndFees.Text == "0" && txtOtherTaxesAndFees.Text == "0")
                {

                    costPerNight = total / totalNights;

                }
                else if (txtOtherTaxesAndFees.Text != "0" && txtTaxesAndFees.Text == "0")
                {
                    total = total - Convert.ToDouble(txtOtherTaxesAndFees.Text);

                    costPerNight = (total / totalNights);
                }
                else if (txtOtherTaxesAndFees.Text == "0" && txtTaxesAndFees.Text != "0")
                {
                    costPerNight = (total / totalNights);
                    costPerNight = costPerNight - Convert.ToDouble(txtTaxesAndFees.Text);
                }
                else if (txtOtherTaxesAndFees.Text != "0" && txtTaxesAndFees.Text != "0")
                {
                    total = total - Convert.ToDouble(txtOtherTaxesAndFees.Text);
                    costPerNight = (total / totalNights);
                    costPerNight = costPerNight - Convert.ToDouble(txtTaxesAndFees.Text);
                }

                costPerNight = Math.Round(costPerNight, 2);
                txtCostPerNight.Text = costPerNight.ToString();
            }
        }

        private void dtgLodgings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dtgLodgings.CurrentCell.RowIndex;
            int columnindex = dtgLodgings.CurrentCell.ColumnIndex;
            if (columnindex == 9)
            {
                string facilityName = dtgLodgings.Rows[rowindex].Cells[0].Value.ToString();
                dtgLodgings.Rows.RemoveAt(rowindex);
                if (CommonVariables.lcl.Count > 0)
                {
                    for (int i = 0; i < CommonVariables.lcl.Count; i++)
                    {
                        if (CommonVariables.lcl[i].FacilityName == facilityName)
                        {
                            CommonVariables.lcl.RemoveAt(i);
                        }
                    }
                }
            }
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
