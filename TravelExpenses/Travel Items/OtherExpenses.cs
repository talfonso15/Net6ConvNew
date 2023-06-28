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
    public partial class OtherExpenses : Form
    {
        public OtherExpenses()
        {
            InitializeComponent();
        }

        private void btnExpenseAmount_Click(object sender, EventArgs e)
        {
            bool validate = addingValidations();
            if (validate)
            {
                dgvOtherExpenses.Rows.Add(chxPrepaid.Checked, txtExpenseDescription.Text, Convert.ToDouble(txtExpenseAmount.Text), txtExpensesNotes.Text);
                txtExpenseAmount.Text = "";
                txtExpenseDescription.Text = "";
                txtExpensesNotes.Text = "";
                chxPrepaid.Checked = false;

            }

        }

        private void btnNextExpenses_Click(object sender, EventArgs e)
        {
            bool validate = nextValidation();
            if (validate)
            {
                int rowsExp = dgvOtherExpenses.RowCount;
                if (rowsExp > CommonVariables.oxcl.Count)
                {
                    CommonVariables.oxcl.Clear();
                    for (int i = 0; i < rowsExp; i++)
                    {
                        OtherExpensescl op = new OtherExpensescl();
                        op.Prepaid = Convert.ToBoolean(dgvOtherExpenses.Rows[i].Cells[0].Value);
                        op.Description = dgvOtherExpenses.Rows[i].Cells[1].Value.ToString();
                        op.Amount = Convert.ToDouble(dgvOtherExpenses.Rows[i].Cells[2].Value);
                        op.Notes = dgvOtherExpenses.Rows[i].Cells[3].Value.ToString();
                        CommonVariables.oxcl.Add(op);
                    }
                }

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

                Summary sm = new Summary();
                sm.MdiParent = main;
                sm.Show();
                this.Hide();
            }
        }

        private bool addingValidations()
        {
            if (txtExpenseDescription.Text == "")
            {
                MessageBox.Show("Enter the Expense Description", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtExpenseAmount.Text == "")
            {
                MessageBox.Show("Enter the Expense Amount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool nextValidation()
        {
            int quantExps = dgvOtherExpenses.RowCount;
            if (quantExps <= 0)
            {
                MessageBox.Show("Add at least one Expense", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnBackExpenses_Click(object sender, EventArgs e)
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
            if (CommonVariables.isMileage == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Mileage")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isAirFare == true)
            {
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

        private void btnCancelExpenses_Click(object sender, EventArgs e)
        {
            CommonVariables.CancelTravel();
        }

        /* private void OtherExpenses_FormClosed(object sender, FormClosedEventArgs e)
         {
             CommonVariables.CancelTravel();
         }*/

        private void txtExpenseAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvOtherExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgvOtherExpenses.CurrentCell.RowIndex;
            int columnindex = dgvOtherExpenses.CurrentCell.ColumnIndex;
            if (columnindex == 4)
            {
                string description = dgvOtherExpenses.Rows[rowindex].Cells[1].Value.ToString();
                dgvOtherExpenses.Rows.RemoveAt(rowindex);
                if (CommonVariables.oxcl.Count > 0)
                {
                    for (int i = 0; i < CommonVariables.oxcl.Count; i++)
                    {
                        if (CommonVariables.oxcl[i].Description == description)
                        {
                            CommonVariables.oxcl.RemoveAt(i);
                        }
                    }
                }
            }
        }
    }
}
