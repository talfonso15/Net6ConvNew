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
    public partial class RegisterTravel : Form
    {
        DateTime departureDate;
        DateTime returnDate;
        String departureTime;
        String returnTime;
        String travelEvent;
        String travelPurpose;
        String travelOrigin;
        String travelDestination;
        String travelState;
        String travelNotes;
        public RegisterTravel()
        {
            InitializeComponent();
            departureDate = CommonVariables.travelDepartureDate;
            returnDate = CommonVariables.travelReturnDate;
            departureTime = CommonVariables.travelDepartureTime;
            returnTime = CommonVariables.travelReturnTime;
            travelEvent = CommonVariables.travelEvent;
            travelPurpose = CommonVariables.travelPurpose;
            travelOrigin = CommonVariables.travelOrigin;
            travelDestination = CommonVariables.travelDestination;
            travelState = CommonVariables.travelState;
            travelNotes = CommonVariables.travelNotes;
        }

        private void tlpTravel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOrigin_Click(object sender, EventArgs e)
        {

        }

        private void btnTravelNext_Click(object sender, EventArgs e)
        {
            bool validate = Validations();

            if (validate)
            {
                CommonVariables.travelDepartureDate = dtpDepartureDate.Value;
                CommonVariables.travelReturnDate = dtpReturnDate.Value;
                CommonVariables.travelDepartureTime = dtpDepartureTime.Value.ToShortTimeString();
                CommonVariables.travelReturnTime = dtpReturnTime.Value.ToShortTimeString();
                if (cbTravelEvent.SelectedItem.ToString() == "Other")
                {
                    CommonVariables.travelEvent = txtOtherEvent.Text;
                }
                else
                {
                    CommonVariables.travelEvent = cbTravelEvent.SelectedItem.ToString();
                }
                /* if (cbTravelPurpose.SelectedItem.ToString() == "Other")
                 {

                     CommonVariables.travelPurpose = txtOtherPurpose.Text;
                 }
                 else
                 {
                     CommonVariables.travelPurpose = cbTravelPurpose.SelectedItem.ToString();
                 }*/
                CommonVariables.travelOrigin = txtOrigin.Text;
                CommonVariables.travelDestination = txtDestination.Text;
                CommonVariables.travelState = cbState.SelectedItem.ToString();
                CommonVariables.travelNotes = txtNotes.Text;
                CommonVariables.travelPurpose = "Professional";

                TimeSpan difference = Convert.ToDateTime(dtpReturnDate.Value).Subtract(Convert.ToDateTime(dtpDepartureDate.Value));
                int totalDays = (int)difference.TotalDays;
                totalDays = totalDays + 1;
                CommonVariables.totalDaysMeals = totalDays;


                //checking open forms
                FormCollection fc = Application.OpenForms;
                bool tiFormFound = false;
                Form main = new Form();
                foreach (Form frm in fc)
                {
                    string name = frm.Name;
                    if (frm.Name == "Main")
                    {
                        main = frm;
                        Form[] childs = frm.MdiChildren;
                        foreach (Form child in childs)
                        {
                            if (child.Name == "TravelItems")
                            {
                                child.Focus();
                                child.Show();
                                tiFormFound = true;
                            }
                        }
                    }
                }

                if (!tiFormFound)
                {

                    TravelItems ti = new TravelItems();
                    ti.MdiParent = main;
                    ti.Show();
                }

                this.Hide();
            }
        }

        private void cbTravelEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTravelEvent.SelectedItem.ToString() == "Other")
            {
                txtOtherEvent.Enabled = true;
                lblOtherEvent.Enabled = true;
            }
            else
            {
                txtOtherEvent.Enabled = false;
                lblOtherEvent.Enabled = false;
            }
        }

        private void cbTravelPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTravelPurpose.SelectedItem.ToString() == "Other")
            {
                txtOtherPurpose.Enabled = true;
                lblOtherPurpose.Enabled = true;
            }
            else
            {
                txtOtherPurpose.Enabled = false;
                lblOtherPurpose.Enabled = false;
            }
        }

        private bool Validations()
        {
            if (cbTravelEvent.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Select your Travel Event", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (cbTravelEvent.SelectedItem.ToString() == "Other" && txtOtherEvent.Text == "")
            {

                MessageBox.Show("Write your Travel Event", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            /*if (cbTravelPurpose.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Select your Travel Purpose", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (cbTravelPurpose.SelectedItem.ToString() == "Other" && txtOtherPurpose.Text == "") {
                MessageBox.Show("Write your Travel Event", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }*/

            if (txtOrigin.Text == "")
            {
                MessageBox.Show("Enter your travel Origin", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtDestination.Text == "")
            {

                MessageBox.Show("Enter your travel Destination", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cbState.SelectedIndex.ToString() == "-1")
            {
                MessageBox.Show("Select your travel State", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void RegisterTravel_Load(object sender, EventArgs e)
        {
            dtpReturnDate.Value = DateTime.Today.AddDays(1);
            dtpReturnDate.MinDate = dtpDepartureDate.Value;

        }

        private void btnCancelTravel_Click(object sender, EventArgs e)
        {
            CommonVariables.CancelTravel();
        }

        /* private void RegisterTravel_FormClosed(object sender, FormClosedEventArgs e)
         {
             CommonVariables.CancelTravel();
         }*/

        private void dtpDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            dtpReturnDate.MinDate = dtpDepartureDate.Value;
        }
    }
}
