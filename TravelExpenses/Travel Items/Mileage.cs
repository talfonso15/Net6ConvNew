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
    public partial class Mileage : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        double milRate = 0;
        public Mileage()
        {
            InitializeComponent();
        }

        private void btnNextMileage_Click(object sender, EventArgs e)
        {
            bool validate = nextValidations();
            if (validate)
            {
                double totalVicinity = 0;
                CommonVariables.micl.MapMileage = Convert.ToDouble(txtMapMileageClaimed.Text);
                double totalMileageMap = Convert.ToDouble(txtMapMileageClaimed.Text) * milRate;
                if (txtVicinityMileage.Text != "")
                {
                    CommonVariables.micl.VicinityMileage = Convert.ToDouble(txtVicinityMileage.Text);
                    totalVicinity = Convert.ToDouble(txtVicinityMileage.Text) * milRate;
                }
                else
                {
                    CommonVariables.micl.VicinityMileage = 0;
                }
                double totalAmount = totalMileageMap + totalVicinity;
                CommonVariables.micl.TotalMileage = totalAmount;

                if (rbYesDistrictProvidedVehicle.Checked == true)
                {
                    CommonVariables.micl.DistricticProvidedVehicle = true;
                }
                else
                {
                    CommonVariables.micl.DistricticProvidedVehicle = false;
                    if (rbYesReimbursementMileage.Checked == true)
                    {
                        CommonVariables.micl.DirectorApprovedPersonal = true;
                    }
                    else if (rbNoReimbursementMileage.Checked)
                    {
                        CommonVariables.micl.DirectorApprovedPersonal = false;
                    }
                }
                CommonVariables.micl.Notes = txtMileageNotes.Text;


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

                    if (CommonVariables.isOtherExpenses == true)
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

        private void rbNoDistrictProvidedVehicle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoDistrictProvidedVehicle.Checked) {
                pDirectorApproved.Enabled = true;
            }
        }

        private void rbYesDistrictProvidedVehicle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesDistrictProvidedVehicle.Checked) {
                pDirectorApproved.Enabled = false;
            }
        }

        private bool nextValidations() {
            if (txtMapMileageClaimed.Text == "") {
                MessageBox.Show("Enter the Mileage Map", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnBackMileage_Click(object sender, EventArgs e)
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
            if (CommonVariables.isAirFare == true) {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "AirFare")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isCarRental == true)
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

        private void txtMapMileageClaimed_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVicinityMileage_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancelMileage_Click(object sender, EventArgs e)
        {
            CommonVariables.CancelTravel();
        }

       /* private void Mileage_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommonVariables.CancelTravel();
        }*/

        private void Mileage_Load(object sender, EventArgs e)
        {
            txtVicinityMileage.Text = "0";
            localCon.Open();
            SqlCommand mr = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[MileageRate]", localCon);
            SqlDataReader mrDR = mr.ExecuteReader();
            if (mrDR.HasRows)
            {
                while (mrDR.Read())
                {
                    milRate = Convert.ToDouble(mrDR["MileageRate"].ToString());
                }
            }
            mrDR.Close();
            localCon.Close();
            lblCurrentMileageRate.Text = "The current mileage rate is: " + milRate.ToString();
        }
    }
}
