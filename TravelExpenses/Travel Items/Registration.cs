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
    public partial class Registration : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        public Registration()
        {
            InitializeComponent();
        }

        private void btnNextRegistration_Click(object sender, EventArgs e)
        {
            bool validate = nextValidations();
            if (validate)
            {
                CommonVariables.rg.RegistrationAmount = Convert.ToDouble(txtResgistrationCost.Text);

                if (rbYesRegistrationPayDistrict.Checked == true)
                {
                    CommonVariables.rg.DistrictPay = true;
                }
                else
                {
                    CommonVariables.rg.DistrictPay = false;
                }
                CommonVariables.rg.Notes = txtRegistrationNotes.Text;


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
                    if (CommonVariables.isLodging == true)
                    {
                        bool lodgingFormFound = false;
                        foreach (Form child in childs)
                        {
                            string name = child.Name;
                            if (child.Name == "Lodging")
                            {
                                child.Focus();
                                child.Show();

                                lodgingFormFound = true;
                            }
                        }
                        if (!lodgingFormFound)
                        {
                            Lodging lg = new Lodging();
                            lg.MdiParent = main;
                            lg.Show();
                        }
                    }
                    else if (CommonVariables.isCarRental == true)
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

        private bool nextValidations()
        {
            if (txtResgistrationCost.Text == "")
            {
                MessageBox.Show("Enter the Registration Cost", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnBackRegistration_Click(object sender, EventArgs e)
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
            if (CommonVariables.isMeals == true)
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

        private void txtResgistrationCost_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnCancelRegistration_Click(object sender, EventArgs e)
        {
            CommonVariables.CancelTravel();
            if (CommonVariables.viewDetails)
            {
                this.Close();
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
        }

        /* private void Registration_FormClosed(object sender, FormClosedEventArgs e)
         {
             CommonVariables.CancelTravel();
         }*/

        private void Registration_Load(object sender, EventArgs e)
        {
            if (CommonVariables.viewDetails)
            {
                localCon.Open();
                Guid viewTravId = new Guid(CommonVariables.viewTravelID);
                SqlCommand cmd = new SqlCommand("SELECT [RegistrationAMount],[DistrictPay],[Notes] FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + viewTravId + "'", localCon);
                SqlDataReader cmdDR = cmd.ExecuteReader();
                while (cmdDR.Read())
                {
                    txtResgistrationCost.Text = cmdDR["RegistrationAMount"].ToString();
                    bool dpay = Convert.ToBoolean(cmdDR["DistrictPay"].ToString());
                    if (dpay)
                    {
                        rbYesRegistrationPayDistrict.Checked = true;
                    }
                    else
                    {
                        rbNoRegistrationPayDistrict.Checked = true;
                    }
                    txtRegistrationNotes.Text = cmdDR["Notes"].ToString();
                }
                cmdDR.Close();
                localCon.Close();
                tableLayoutPanel3.Visible = false;
            }
        }
    }
}
