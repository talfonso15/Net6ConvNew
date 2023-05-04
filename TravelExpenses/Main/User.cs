using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelExpenses
{
    public partial class User : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        /* Guid userID = new Guid();*/
        int accessLevel = 3;
        public User()
        {
            InitializeComponent();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            bool validate = savingValidations();
            if (validate)
            {
                localCon.Open();
                string name = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string district = cbDistrict.SelectedItem.ToString();
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string department = cbDepartment.SelectedItem.ToString();
                string email = txtEmail.Text;
                string title = "Regular Employee";
                if (chxSupervisor.Checked)
                {
                    title = "Supervisor";
                    accessLevel = 2;
                }
                else if (chxCFO.Checked)
                {
                    title = "CFO";
                    accessLevel = 1;
                }
                else if (chxDeputyDirectorMosquito.Checked)
                {
                    title = "Deputy Director Mosquito";
                    accessLevel = 1;
                }
                else if (chxDeputyDirectorHyacinth.Checked)
                {
                    title = "Deputy Director Hyacinth";
                    accessLevel = 1;
                }
                else if (chxExecutiveDirector.Checked)
                {
                    title = "Executive Director";
                    accessLevel = 1;
                }
                else if (chxAssistantDirector.Checked)
                {
                    title = "Assistant Director";
                    accessLevel = 1;
                }
                else if (chxAccountingProcessor.Checked)
                {
                    title = "Accounting Processor";
                    accessLevel = 1;
                }
                else if (chxExecutiveProcessor.Checked)
                {
                    title = "Executive Processor";
                    accessLevel = 1;
                }
                
                //int accessLevel = Convert.ToInt32(cbAccessLevel.SelectedItem.ToString());
                try
                {
                    Guid idInserted;
                    Object idInsert;
                    string id = "";
                    if (email != "")
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter();
                        cmd.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User] (Name, LastName, District, Department, Username, Password, AccessLevel) OUTPUT INSERTED.UserID,'" + email + "','"+ title +"','1' INTO [TravelExpenses].[dbo].[User_Email_Title] (UserID,Email,Title,Active) VALUES (@Name,@LastName,@District,@Department,@Username,@Password,@AccessLevel)", localCon);
                        cmd.InsertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
                        cmd.InsertCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = lastName;
                        cmd.InsertCommand.Parameters.Add("@District", SqlDbType.VarChar).Value = district;
                        cmd.InsertCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                        cmd.InsertCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                        cmd.InsertCommand.Parameters.Add("@AccessLevel", SqlDbType.Int).Value = accessLevel;
                        cmd.InsertCommand.Parameters.Add("@Department", SqlDbType.VarChar).Value = department;

                        cmd.InsertCommand.ExecuteScalar();
                        SqlCommand selectIns = new SqlCommand("SELECT  [UserID] FROM [TravelExpenses].[dbo].[User] where Name ='"+ name +"'  AND LastName ='"+ lastName +"' AND Department = '" + department + "' AND Username = '"+ username +"'", localCon);
                        SqlDataReader dr = selectIns.ExecuteReader();
                        while (dr.Read())
                        {
                            id = dr["UserID"].ToString();
                        }
                        dr.Close();
                        idInserted = new Guid(id);
                       
                        
                            if (CommonVariables.signatureText != "")
                            {
                                SqlDataAdapter cmd2 = new SqlDataAdapter();
                                cmd2.InsertCommand = new SqlCommand("INSERT INTO [dbo].[UserSignature] ([UserID],[FontType],[SignatureText]) VALUES (@UserID,@FontType,@SignatureText)", localCon);
                                cmd2.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = idInserted;
                                cmd2.InsertCommand.Parameters.Add("@FontType", SqlDbType.VarChar).Value = CommonVariables.signatureFont;
                                cmd2.InsertCommand.Parameters.Add("@SignatureText", SqlDbType.VarChar).Value = CommonVariables.signatureText;
                                cmd2.InsertCommand.ExecuteNonQuery();
                            }

                        Guid supID = new Guid(cbSupervisor.SelectedValue.ToString());
                        SqlDataAdapter sup = new SqlDataAdapter();
                        sup.InsertCommand = new SqlCommand("INSERT INTO [dbo].[Supervisor_Employee]  ([UserID] ,[SupervisorID]) VALUES (@UserID,@SupervisorID)", localCon);
                        sup.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = idInserted;
                        sup.InsertCommand.Parameters.Add("@SupervisorID", SqlDbType.UniqueIdentifier).Value = supID;
                        sup.InsertCommand.ExecuteNonQuery();

                        MessageBox.Show("User inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        
                    }
                    else
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter();
                        cmd.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User] (Name, LastName, District, Department, Username, Password, AccessLevel)  OUTPUT INSERTED.UserID VALUES (@Name,@LastName,@District,@Department,@Username,@Password,@AccessLevel) ", localCon);
                        cmd.InsertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
                        cmd.InsertCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = lastName;
                        cmd.InsertCommand.Parameters.Add("@District", SqlDbType.VarChar).Value = district;
                        cmd.InsertCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
                        cmd.InsertCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;
                        cmd.InsertCommand.Parameters.Add("@AccessLevel", SqlDbType.Int).Value = accessLevel;
                        cmd.InsertCommand.Parameters.Add("@Department", SqlDbType.VarChar).Value = department;

                        //int row = cmd.InsertCommand.ExecuteNonQuery();
                        idInsert = cmd.InsertCommand.ExecuteScalar();
                        idInserted = new Guid(idInsert.ToString());
                        if (idInsert.ToString() != "")
                        {
                            if (CommonVariables.signatureText != "")
                            {
                                SqlDataAdapter cmd2 = new SqlDataAdapter();
                                cmd2.InsertCommand = new SqlCommand("INSERT INTO [dbo].[UserSignature] ([UserID],[FontType],[SignatureText]) VALUES (@UserID,@FontType,@SignatureText)", localCon);
                                cmd2.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = idInserted;
                                cmd2.InsertCommand.Parameters.Add("@FontType", SqlDbType.VarChar).Value = CommonVariables.signatureFont;
                                cmd2.InsertCommand.Parameters.Add("@SignatureText", SqlDbType.VarChar).Value = CommonVariables.signatureText;
                                cmd2.InsertCommand.ExecuteNonQuery();
                            }

                            Guid supID = new Guid(cbSupervisor.SelectedValue.ToString());
                            SqlDataAdapter sup = new SqlDataAdapter();
                            sup.InsertCommand = new SqlCommand("INSERT INTO [dbo].[Supervisor_Employee]  ([UserID] ,[SupervisorID]) VALUES (@UserID,@SupervisorID)", localCon);
                            sup.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = idInserted;
                            sup.InsertCommand.Parameters.Add("@SupervisorID", SqlDbType.UniqueIdentifier).Value = supID;
                            sup.InsertCommand.ExecuteNonQuery();

                            MessageBox.Show("User inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                localCon.Close();
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                cbAccessLevel.SelectedIndex = -1;
                cbDistrict.SelectedIndex = -1;
                cbDepartment.SelectedIndex = -1;
                txtEmail.Text = "";
                CommonVariables.signatureFont = "";
                CommonVariables.signatureText = "";
                chxSupervisor.Checked = false;
                chxCFO.Checked = false;
                chxDeputyDirectorHyacinth.Checked = false;
                chxDeputyDirectorMosquito.Checked = false;
                chxAssistantDirector.Checked = false;
                chxExecutiveDirector.Checked = false;
                chxExecutiveProcessor.Checked = false;
                chxAccountingProcessor.Checked = false;
                accessLevel = 3;
                loadSupervisor();
            }
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool savingValidations() {
            if (txtFirstName.Text == "") {
                MessageBox.Show("Enter the First Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtLastName.Text == "") {
                MessageBox.Show("Enter the Last Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbDistrict.SelectedIndex == -1) {
                MessageBox.Show("Select a District", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbDepartment.SelectedIndex == -1) {
                MessageBox.Show("Select a Department", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtUsername.Text == "") {
                MessageBox.Show("Enter an Username", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPassword.Text == "") {
                MessageBox.Show("Enter a Password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            /*if (cbAccessLevel.Text == "") {
                MessageBox.Show("Select an Access Level", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }*/
            /*if (CommonVariables.signatureText == "")
            {
                MessageBox.Show("Create a Digital Signature");
                return false;
            }*/
            return true;
        }

        private void btnSiganture_Click(object sender, EventArgs e)
        {
            CreateSignature cs = new CreateSignature();
            cs.ShowDialog();
        }

        private void User_Load(object sender, EventArgs e)
        {
            /*string name = "";
            string id = "";
            localCon.Open();
            SqlCommand sup = new SqlCommand("SELECT  a.UserID as UserID,[Name],[LastName] FROM [dbo].[User] as a inner join User_Email_Title as b on a.UserID = b.UserID where a.AccessLevel < 3 AND b.Active = 1 order by a.Name", localCon);
            SqlDataReader drSup = sup.ExecuteReader();
            cbSupervisor.DisplayMember = "Text";
            cbSupervisor.ValueMember = "Value";
            List<Object> items = new List<object>();
            while (drSup.Read())
            {
                name = drSup["Name"].ToString() + " " + drSup["LastName"].ToString();
                id = drSup["UserID"].ToString();
                items.Add(new { Text = name, Value = id });
            }
            drSup.Close();
            cbSupervisor.DataSource = items;
            localCon.Close();*/
            loadSupervisor();
        }

        private void chxExecutiveProcessor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else if (txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void loadSupervisor() 
        {
            cbSupervisor.DataSource = null;
            string name = "";
            string id = "";
            localCon.Open();
            SqlCommand sup = new SqlCommand("SELECT  a.UserID as UserID,[Name],[LastName] FROM [dbo].[User] as a inner join User_Email_Title as b on a.UserID = b.UserID where a.AccessLevel < 3 AND b.Active = 1 order by a.Name", localCon);
            SqlDataReader drSup = sup.ExecuteReader();
            cbSupervisor.DisplayMember = "Text";
            cbSupervisor.ValueMember = "Value";
            List<Object> items = new List<object>();
            while (drSup.Read())
            {
                name = drSup["Name"].ToString() + " " + drSup["LastName"].ToString();
                id = drSup["UserID"].ToString();
                items.Add(new { Text = name, Value = id });
            }
            drSup.Close();
            cbSupervisor.DataSource = items;
            localCon.Close();

        }
    }
}
