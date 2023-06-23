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
    public partial class EditOtherExpenses : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid edittravelID;
        Guid editOEID;
        int quantityOE = 0;
        bool isNew = false;
        public EditOtherExpenses()
        {
            InitializeComponent();
        }

        private void EditOtherExpenses_Load(object sender, EventArgs e)
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
                /*lblEditOtherExpenses.Visible = true;
                lblEditOtherExpenses.Text = "Select the Expense you want to see the details";
                panel2.Width = 310;
                panel2.Location = new Point(160,50);

                label1.Visible = false;*/
                btnDeleteOtherExp.Visible = false;
                btnAddOtherExp.Visible = false;
                // btnEditOtherExp.Text = "VIew";
                btnSaveOtherExp.Visible = false;
                btnClose.Visible = true;
                label4.Visible = false;
                label3.Visible = false;
                label2.Visible = false;
                //panel2.Height = 25;
                btnEditOtherExp.Image = Resources.if_5_330396;
            }
            else
            {
                edittravelID = new Guid(CommonVariables.editTravelID.ToString());
            }

            SqlCommand cmd = new SqlCommand("SELECT [OtherExpensesID],[Description],[Amount],[Prepaid],[Notes] FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + edittravelID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string description = dr["Description"].ToString();
                string amount = dr["Amount"].ToString();
                bool prepaid = Convert.ToBoolean(dr["Prepaid"].ToString());
                string notes = dr["Notes"].ToString();
                string oeID = dr["OtherExpensesID"].ToString();
                dgvEditOtherExp.Rows.Add(prepaid, description, amount, notes, oeID);
                quantityOE++;
            }
            dr.Close();

            if (quantityOE <= 1)
            {
                btnDeleteOtherExp.Enabled = false;
            }
            this.Size = new System.Drawing.Size(698, 253);

            localCon.Close();
        }

        private void refreshExpenses()
        {
            localCon.Open();
            quantityOE = 0;
            dgvEditOtherExp.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT [OtherExpensesID],[Description],[Amount],[Prepaid],[Notes] FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + edittravelID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string description = dr["Description"].ToString();
                string amount = dr["Amount"].ToString();
                bool prepaid = Convert.ToBoolean(dr["Prepaid"].ToString());
                string notes = dr["Notes"].ToString();
                string oeID = dr["OtherExpensesID"].ToString();
                dgvEditOtherExp.Rows.Add(prepaid, description, amount, notes, oeID);
                quantityOE++;
            }
            dr.Close();

            if (quantityOE <= 1)
            {
                btnDeleteOtherExp.Enabled = false;
            }
            else
            {
                btnDeleteOtherExp.Enabled = true;
            }
            this.Size = new System.Drawing.Size(698, 253);
            localCon.Close();

        }

        private void clearData()
        {
            txtDescription.Text = "";
            txtAmount.Text = "";
            txtNotes.Text = "";
            chxPrepaid.Checked = false;
        }

        private bool validateData()
        {
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Provide a description for your expense", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Provide the amount of your expense", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAddOtherExp_Click(object sender, EventArgs e)
        {
            isNew = true;
            tlEditButtons.Visible = false;
            dgvEditOtherExp.Enabled = false;
            this.Size = new System.Drawing.Size(698, 557);
        }

        private void btnSaveOtherExp_Click(object sender, EventArgs e)
        {
            string description = "";
            double amount = 0;
            bool prepaid = true;
            string notes = "";
            double travelAmount = 0;
            double travelReim = 0;
            localCon.Open();
            if (validateData())
            {
                if (isNew)
                {
                    description = txtDescription.Text;
                    amount = Convert.ToDouble(txtAmount.Text);
                    prepaid = chxPrepaid.Checked;
                    notes = txtNotes.Text;

                    SqlDataAdapter addOE = new SqlDataAdapter();
                    addOE.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[OtherExpenses] ([Description],[Amount],[TravelID],[Prepaid],[Notes]) VALUES (@Description,@Amount,@TravelID,@Prepaid,@Notes)", localCon);
                    addOE.InsertCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = description;
                    addOE.InsertCommand.Parameters.Add("@Amount", SqlDbType.Float).Value = amount;
                    addOE.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = edittravelID;
                    addOE.InsertCommand.Parameters.Add("@Prepaid", SqlDbType.Bit).Value = prepaid;
                    addOE.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = notes;
                    int ri = addOE.InsertCommand.ExecuteNonQuery();
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

                        travelAmount = travelAmount + amount;
                        if (!prepaid)
                        {
                            travelReim = travelReim + amount;
                        }

                        SqlDataAdapter upTravel = new SqlDataAdapter();
                        upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed  WHERE TravelID ='" + edittravelID + "'", localCon);
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                        int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                        localCon.Close();
                        if (ru > 0)
                        {
                            MessageBox.Show("Expense inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshExpenses();
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
                    bool oriPrepaid = true;
                    double oriAmount = 0;

                    SqlCommand cmd = new SqlCommand("SELECT [Amount],[Prepaid] FROM [TravelExpenses].[dbo].[OtherExpenses] where OtherExpensesID = '" + editOEID + "'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        oriPrepaid = Convert.ToBoolean(dr["Prepaid"].ToString());
                        oriAmount = Convert.ToDouble(dr["Amount"].ToString());
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

                    travelAmount = travelAmount - oriAmount;
                    if (!oriPrepaid)
                    {
                        travelReim = travelReim - oriAmount;
                    }

                    description = txtDescription.Text;
                    amount = Convert.ToDouble(txtAmount.Text);
                    prepaid = chxPrepaid.Checked;
                    notes = txtNotes.Text;

                    SqlDataAdapter upOE = new SqlDataAdapter();
                    upOE.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[OtherExpenses] SET [Description] = @Description,[Amount] = @Amount,[Prepaid] = @Prepaid,[Notes] = @Notes WHERE OtherExpensesID = '" + editOEID + "'", localCon);
                    upOE.UpdateCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = description;
                    upOE.UpdateCommand.Parameters.Add("@Amount", SqlDbType.Float).Value = amount;
                    upOE.UpdateCommand.Parameters.Add("@Prepaid", SqlDbType.Bit).Value = prepaid;
                    upOE.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = notes;
                    int ru = upOE.UpdateCommand.ExecuteNonQuery();
                    if (ru > 0)
                    {
                        travelAmount = travelAmount + amount;
                        if (!prepaid)
                        {
                            travelReim = travelReim + amount;
                        }

                        SqlDataAdapter upTravel = new SqlDataAdapter();
                        upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed  WHERE TravelID ='" + edittravelID + "'", localCon);
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                        int rut = upTravel.UpdateCommand.ExecuteNonQuery();
                        localCon.Close();
                        if (rut > 0)
                        {
                            MessageBox.Show("Expense updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshExpenses();
                            if (backgroundWorker1.IsBusy != true)
                            {
                                backgroundWorker1.RunWorkerAsync();
                            }
                        }

                    }


                }
                tlEditButtons.Visible = true;
                this.Size = new System.Drawing.Size(698, 253);
                dgvEditOtherExp.Enabled = true;
                clearData();

            }



            localCon.Close();
        }

        private void btnEditOtherExp_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvEditOtherExp.CurrentRow.Index;
            string oeID = dgvEditOtherExp.Rows[rowIndex].Cells[4].Value.ToString();
            editOEID = new Guid(oeID);

            chxPrepaid.Checked = Convert.ToBoolean(dgvEditOtherExp.Rows[rowIndex].Cells[0].Value.ToString());
            txtDescription.Text = dgvEditOtherExp.Rows[rowIndex].Cells[1].Value.ToString();
            txtAmount.Text = dgvEditOtherExp.Rows[rowIndex].Cells[2].Value.ToString();
            txtNotes.Text = dgvEditOtherExp.Rows[rowIndex].Cells[3].Value.ToString();

            tlEditButtons.Visible = false;
            this.Size = new System.Drawing.Size(698, 557);
            dgvEditOtherExp.Enabled = false;
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            clearData();
            dgvEditOtherExp.Enabled = true;
            tlEditButtons.Visible = true;
            this.Size = new System.Drawing.Size(698, 253);
        }

        private void btnDeleteOtherExp_Click(object sender, EventArgs e)
        {
            DialogResult delOtherExp = MessageBox.Show("Do you really want to delete this expense?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delOtherExp == DialogResult.Yes)
            {
                int rowIndex = dgvEditOtherExp.CurrentRow.Index;
                string oeID = dgvEditOtherExp.Rows[rowIndex].Cells[4].Value.ToString();
                editOEID = new Guid(oeID);
                double amount = Convert.ToDouble(dgvEditOtherExp.Rows[rowIndex].Cells[2].Value.ToString());
                bool prepaid = Convert.ToBoolean(dgvEditOtherExp.Rows[rowIndex].Cells[0].Value.ToString());

                double travelAmount = 0;
                double travelReim = 0;

                localCon.Open();
                SqlCommand delOE = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[OtherExpenses] WHERE OtherExpensesID = '" + editOEID + "'", localCon);
                int rd = delOE.ExecuteNonQuery();
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

                    travelAmount = travelAmount - amount;
                    if (!prepaid)
                    {
                        travelReim = travelReim - amount;
                    }

                    SqlDataAdapter upTravel = new SqlDataAdapter();
                    upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed  WHERE TravelID ='" + edittravelID + "'", localCon);
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                    int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                    localCon.Close();
                    if (ru > 0)
                    {
                        MessageBox.Show("Expense deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshExpenses();
                    }
                }

                localCon.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
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

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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
