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
    public partial class AirFare : Form
    {
        public AirFare()
        {
            InitializeComponent();
        }

        private void txtFlightTaxesAndFees_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFlightCost.Text != "" && txtFlightTaxesAndFees.Text != "")
            {
                double totalFlight = Convert.ToDouble(txtFlightCost.Text) + Convert.ToDouble(txtFlightTaxesAndFees.Text);
                txtFlightTotal.Text = totalFlight.ToString();
            }
        }

        private void rbYesPersonalUseFlight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesPersonalUseFlight.Checked == true)
            {
                txtPersonalAmountFlight.Enabled = true;
            }
            else if (rbNoPersonalUseFlight.Checked == true)
            {

                txtPersonalAmountFlight.Enabled = false;
            }
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            bool validate = addingValidations();
            if (validate)
            {
                bool districtPay = false;
                bool personalUse = false;
                string retDate = "";
                if (rbYesDistrictPayFlight.Checked == true)
                {
                    districtPay = true;
                }
                if (rbYesPersonalUseFlight.Checked == true)
                {
                    personalUse = true;
                }
                if (rbYesRoundTrip.Checked)
                {
                    retDate = dtpFlightReturnDate.Text;
                }

                dgvFlight.Rows.Add(dtpFlightDepartureDate.Text, retDate, txtFlightCost.Text, txtFlightTaxesAndFees.Text, districtPay, personalUse, txtPersonalAmountFlight.Text, txtFlightTotal.Text, txtFlightNotes.Text);

                dtpFlightDepartureDate.Value = DateTime.Today;
                dtpFlightReturnDate.Value = DateTime.Today.AddDays(1);
                txtFlightCost.Text = "";
                txtFlightTaxesAndFees.Text = "0";
                txtFlightTotal.Text = "";
                txtPersonalAmountFlight.Enabled = false;
                txtPersonalAmountFlight.Text = "";
                rbYesDistrictPayFlight.Checked = true;
                rbYesPersonalUseFlight.Checked = false;
                rbNoPersonalUseFlight.Checked = true;

            }
        }

        private void btnNextFlight_Click(object sender, EventArgs e)
        {
            bool validate = nextValidation();
            if (validate)
            {
                int rowsCount = dgvFlight.RowCount;
                if (rowsCount > CommonVariables.afcl.Count)
                {
                    CommonVariables.afcl.Clear();

                    for (int i = 0; i < rowsCount; i++)
                    {
                        AirFarecl afare = new AirFarecl();
                        afare.DepartureDate = Convert.ToDateTime(dgvFlight.Rows[i].Cells[0].Value);
                        if (dgvFlight.Rows[i].Cells[1].Value.ToString() != "")
                        {
                            afare.ReturnDate = Convert.ToDateTime(dgvFlight.Rows[i].Cells[1].Value);
                        }
                        else
                        {
                            afare.ReturnDate = null;
                        }

                        afare.AirFareCost = Convert.ToDouble(dgvFlight.Rows[i].Cells[2].Value);
                        afare.TaxesAndFees = Convert.ToDouble(dgvFlight.Rows[i].Cells[3].Value);
                        afare.DistrictPay = Convert.ToBoolean(dgvFlight.Rows[i].Cells[4].Value);
                        afare.PersonalUse = Convert.ToBoolean(dgvFlight.Rows[i].Cells[5].Value);
                        if (Convert.ToBoolean(dgvFlight.Rows[i].Cells[5].Value) == true)
                        {
                            afare.PersonalUseAmount = Convert.ToDouble(dgvFlight.Rows[i].Cells[6].Value);
                        }
                        else
                        {
                            afare.PersonalUseAmount = 0;
                        }

                        afare.TotalAirFare = Convert.ToDouble(dgvFlight.Rows[i].Cells[7].Value);
                        afare.Notes = dgvFlight.Rows[i].Cells[8].Value.ToString();

                        CommonVariables.afcl.Add(afare);
                    }
                    CommonVariables.afcl.Count();
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

                    if (CommonVariables.isMileage == true)
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

        private void rbYesRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesRoundTrip.Checked)
            {
                dtpFlightReturnDate.Enabled = true;
            }
        }

        private void rbNoRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoRoundTrip.Checked)
            {
                dtpFlightReturnDate.Enabled = false;
            }
        }

        private void rbNoPersonalUseFlight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoPersonalUseFlight.Checked)
            {
                txtPersonalAmountFlight.Enabled = false;
            }
        }

        private bool addingValidations()
        {
            if (txtFlightCost.Text == "")
            {
                MessageBox.Show("Enter the Flight Cost", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtFlightTaxesAndFees.Text == "")
            {
                MessageBox.Show("Enter the Taxes and Fees or if you do not have any just put 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (rbYesPersonalUseFlight.Checked && txtPersonalAmountFlight.Text == "")
            {
                MessageBox.Show("Enter the Personal Use Amount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtFlightTotal.Text == "")
            {
                MessageBox.Show("Enter the Total Amount of your flight", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool nextValidation()
        {
            int quantFlights = dgvFlight.RowCount;
            if (quantFlights <= 0)
            {
                MessageBox.Show("Add at least a Flight", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void AirFare_Load(object sender, EventArgs e)
        {
            dtpFlightReturnDate.Value = DateTime.Today.AddDays(1);
            txtFlightTaxesAndFees.Text = "0";
        }

        private void txtFlightCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFlightTaxesAndFees_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPersonalAmountFlight_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnBackFlight_Click(object sender, EventArgs e)
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
            if (CommonVariables.isCarRental == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "CarRental")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isLodging == true)
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

        private void btnCancelFlight_Click(object sender, EventArgs e)
        {
            CommonVariables.CancelTravel();
        }

        /* private void AirFare_FormClosed(object sender, FormClosedEventArgs e)
         {
             CommonVariables.CancelTravel();
         }*/

        private void txtFlightCost_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFlightCost.Text != "" && txtFlightTaxesAndFees.Text != "")
            {
                double totalFLight = Convert.ToDouble(txtFlightCost.Text) + Convert.ToDouble(txtFlightTaxesAndFees.Text);
                txtFlightTotal.Text = totalFLight.ToString();
            }
        }

        private void dtpFlightDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            dtpFlightReturnDate.MinDate = dtpFlightDepartureDate.Value.AddDays(1);
        }

        private void dgvFlight_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvFlight.CurrentCell.RowIndex;
            int columnindex = dgvFlight.CurrentCell.ColumnIndex;
            if (columnindex == 9)
            {
                string departureDate = dgvFlight.Rows[rowindex].Cells[0].Value.ToString();
                //string returnDate = dgvFlight.Rows[rowindex].Cells[1].Value.ToString();
                dgvFlight.Rows.RemoveAt(rowindex);
                if (CommonVariables.afcl.Count > 0)
                {
                    for (int i = 0; i < CommonVariables.afcl.Count; i++)
                    {
                        if (CommonVariables.afcl[i].DepartureDate.ToShortDateString() == departureDate)
                        {
                            CommonVariables.afcl.RemoveAt(i);
                        }
                    }
                }
            }
        }
    }

}
