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
    public partial class EditUser : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string userIDEdit = "";
        bool email = false;
        bool supervisor = false;
        string loggedUsername = "";
        public EditUser()
        {
            InitializeComponent();
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            loadUsers();
            localCon.Open();
            string name = "";
            string id = "";

            SqlCommand loggedUser = new SqlCommand("SELECT  a.UserID as UserID,[Name],[LastName],a.Username as Username FROM [dbo].[User] as a inner join User_Email_Title as b on a.UserID = b.UserID where a.UserID = '" + CommonVariables.user +"'", localCon);
            SqlDataReader loggedUserDR = loggedUser.ExecuteReader();
            if (loggedUserDR.HasRows) 
            {
                while (loggedUserDR.Read())
                {
                    loggedUsername = loggedUserDR["Username"].ToString();
                }
            }
            loggedUserDR.Close();

            if (loggedUsername == "TPineda")
            {
                btnDeleteUser.Visible = true;
                label4.Visible = true;
            }

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

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            //cbSupervisor.SelectedValue = -1;
            int userIndex = dgvUsers.CurrentRow.Index;
            userIDEdit = dgvUsers.Rows[userIndex].Cells[3].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[userIndex].Cells[7].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[userIndex].Cells[8].Value.ToString();
            int disCOunt = cbDistrict.Items.Count;
            int index = disCOunt - 1;

            localCon.Open();
            SqlCommand sup = new SqlCommand("SELECT [SupervisorID] FROM [TravelExpenses].[dbo].[Supervisor_Employee] where UserID = '"+ userIDEdit + "'", localCon);
            SqlDataReader drSup = sup.ExecuteReader();
            if (drSup.HasRows)
            {
                supervisor = true;
                while (drSup.Read())
                {
                    cbSupervisor.SelectedValue = drSup["SupervisorID"].ToString();
                }
            }
            drSup.Close();
            localCon.Close();

            while (disCOunt > 0) {
                if (cbDistrict.Items[index].ToString() == dgvUsers.Rows[userIndex].Cells[1].Value.ToString()) {
                    cbDistrict.SelectedItem = cbDistrict.Items[index];
                    break;
                }
                disCOunt--;
                index--;
            }

            int depCount = cbDepartment.Items.Count;
            int dePIndex = depCount - 1;
            while (depCount > 0) {
                if (cbDepartment.Items[dePIndex].ToString() == dgvUsers.Rows[userIndex].Cells[2].Value.ToString()) {
                    cbDepartment.SelectedItem = cbDepartment.Items[dePIndex];
                    break;
                }
                depCount--;
                dePIndex--;
            }

            txtUsername.Text = dgvUsers.Rows[userIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[userIndex].Cells[5].Value.ToString();
            int accCount = cbAccessLevel.Items.Count;
            int accIndex = accCount - 1;
            while (accCount > 0) {
                if (cbAccessLevel.Items[accIndex].ToString() == dgvUsers.Rows[userIndex].Cells[6].Value.ToString()) {
                    cbAccessLevel.SelectedItem = cbAccessLevel.Items[accIndex];
                    break;
                }
                accCount--;
                accIndex--;
            }
            txtEmail.Text = dgvUsers.Rows[userIndex].Cells[9].Value.ToString();
            string title = dgvUsers.Rows[userIndex].Cells[11].Value.ToString();
            if (title == "Supervisor")
            {
                chxSupervisor.Checked = true;
            }
            else if (title == "CFO")
            {
                chxCFO.Checked = true;
            }
            else if (title == "Deputy Director Mosquito")
            {
                chxDeputyDirectorMosquito.Checked = true;
            }
            else if (title == "Deputy Director Hyacinth")
            {
                chxDeputyDirectorHyacinth.Checked = true;
            }
            else if (title == "Executive Director")
            {
                chxExecutiveDirector.Checked = true;
            }
            else if (title == "Assistant Director")
            {
                chxAssistantDirector.Checked = true;
            }
            else if (title == "Accounting Processor")
            {
                chxAccountinProcessor.Checked = true;
            }
            else if (title == "Executive Processor")
            {
                chxExecutiveProcessor.Checked = true;
            }
            else if (title == "Regular Employee")
            {
                chxRegularEmployee.Checked = true;
            }

            if (txtEmail.Text != "")
            {
                email = true;
            }
            chxActiveUser.Checked = Convert.ToBoolean(dgvUsers.Rows[userIndex].Cells[12].Value.ToString());

            gbUserData.Visible = true;
            gbUserData.Enabled = true;
            this.Size = new System.Drawing.Size(728, 712);
            
            dgvUsers.Enabled = false;
            tlButtons.Visible = true;
            tlSelectButtons.Visible = false;
            tlDeleteUser.Visible = false;
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Clean();
            loadUsers();
            
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (Validate()) {
                localCon.Open();
                Guid userIDEd = new Guid(userIDEdit);

                string title = "Regular Employee";
                int accessLvel = 3;
                if (chxSupervisor.Checked)
                {
                    title = "Supervisor";
                    accessLvel = 2;
                }
                else if (chxCFO.Checked)
                {
                    title = "CFO";
                    accessLvel = 1;
                }
                else if (chxDeputyDirectorMosquito.Checked)
                {
                    title = "Deputy Director Mosquito";
                    accessLvel = 1;
                }
                else if (chxDeputyDirectorHyacinth.Checked)
                {
                    title = "Deputy Director Hyacinth";
                    accessLvel = 1;
                }
                else if (chxExecutiveDirector.Checked)
                {
                    title = "Executive Director";
                    accessLvel = 1;
                }
                else if (chxAssistantDirector.Checked)
                {
                    title = "Assistant Director";
                    accessLvel = 1;
                }
                else if (chxAccountinProcessor.Checked)
                {
                    title = "Accounting Processor";
                    accessLvel = 1;
                }
                else if (chxExecutiveProcessor.Checked)
                {
                    title = "Executive Processor";
                    accessLvel = 1;
                }
                else if (chxRegularEmployee.Checked)
                {
                    title = "Regular Employee";
                    accessLvel = 3;
                }

                SqlDataAdapter cmdEditUser = new SqlDataAdapter();
                cmdEditUser.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[User] SET [Name] = @Name ,[LastName] = @LastName ,[District] = @District ,[Department] = @Department ,[Username] = @Username ,[Password] = @Password ,[AccessLevel] = @AccessLevel WHERE UserID = '"+ userIDEd + "'", localCon);
                cmdEditUser.UpdateCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtFirstName.Text;
                cmdEditUser.UpdateCommand.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = txtLastName.Text;
                cmdEditUser.UpdateCommand.Parameters.Add("@District", SqlDbType.NVarChar).Value = cbDistrict.SelectedItem.ToString();
                cmdEditUser.UpdateCommand.Parameters.Add("@Department", SqlDbType.NVarChar).Value = cbDepartment.SelectedItem.ToString();
                cmdEditUser.UpdateCommand.Parameters.Add("@Username", SqlDbType.NVarChar).Value = txtUsername.Text;
                cmdEditUser.UpdateCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = txtPassword.Text;
                cmdEditUser.UpdateCommand.Parameters.Add("@AccessLevel", SqlDbType.Int).Value = accessLvel;
                int ra = cmdEditUser.UpdateCommand.ExecuteNonQuery();

                if (email && txtEmail.Text != "")
                {
                    SqlDataAdapter cmdEditEmail = new SqlDataAdapter();
                    cmdEditEmail.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[User_Email_Title] SET [Email] = @Email WHERE[UserID] = '" + userIDEd + "'", localCon);
                    cmdEditEmail.UpdateCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                    cmdEditEmail.UpdateCommand.ExecuteNonQuery();
                }
                else if (!email && txtEmail.Text != "")
                {
                    SqlDataAdapter cmdEditEmail = new SqlDataAdapter();
                    cmdEditEmail.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User_Email_Title] ([UserID] ,[Email]) VALUES (@UserID ,@Email)", localCon);
                    cmdEditEmail.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userIDEd;
                    cmdEditEmail.InsertCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = txtEmail.Text;
                    cmdEditEmail.InsertCommand.ExecuteNonQuery();
                }
                else if (email && txtEmail.Text == "")
                {
                    SqlCommand cmdDeleteEmail = new SqlCommand("Delete from [TravelExpenses].[dbo].[User_Email_Title] where UserID = '" + userIDEd + "'", localCon);
                    cmdDeleteEmail.ExecuteNonQuery();
                }

                
                SqlDataAdapter cmdEditTitle = new SqlDataAdapter();
                cmdEditTitle.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[User_Email_Title] SET [Title] = @Title, [Active] = @Active WHERE[UserID] = '" + userIDEd + "'", localCon);
                
                
                cmdEditTitle.UpdateCommand.Parameters.Add("@Title", SqlDbType.NVarChar).Value = title;
                cmdEditTitle.UpdateCommand.Parameters.Add("@Active", SqlDbType.Bit).Value = chxActiveUser.Checked;

                cmdEditTitle.UpdateCommand.ExecuteNonQuery();


                /* if (supervisor)
                 {
                     SqlDataAdapter sup = new SqlDataAdapter();
                     Guid superv = new Guid(cbSupervisor.SelectedValue.ToString());
                     sup.UpdateCommand = new SqlCommand("UPDATE [dbo].[Supervisor_Employee] SET [SupervisorID] = @SupervisorID  WHERE UserID = '" + userIDEd + "'", localCon);
                     sup.UpdateCommand.Parameters.Add("@SupervisorID", SqlDbType.UniqueIdentifier).Value = superv;
                     sup.UpdateCommand.ExecuteNonQuery();
                 }
                 else
                 {
                     SqlDataAdapter sup = new SqlDataAdapter();
                     Guid superv = new Guid(cbSupervisor.SelectedValue.ToString());
                     sup.InsertCommand = new SqlCommand("INSERT INTO [dbo].[Supervisor_Employee]  ([UserID] ,[SupervisorID]) VALUES (@UserID,@SupervisorID)", localCon);
                     sup.InsertCommand.Parameters.Add("@SupervisorID", SqlDbType.UniqueIdentifier).Value = superv;
                     sup.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userIDEd;
                     sup.InsertCommand.ExecuteNonQuery();
                 }*/

                if (cbSupervisor.SelectedIndex != -1)
                {
                    SqlDataAdapter sup = new SqlDataAdapter();
                    Guid superv = new Guid(cbSupervisor.SelectedValue.ToString());
                    sup.UpdateCommand = new SqlCommand("UPDATE [dbo].[Supervisor_Employee] SET [SupervisorID] = @SupervisorID  WHERE UserID = '" + userIDEd + "'", localCon);
                    sup.UpdateCommand.Parameters.Add("@SupervisorID", SqlDbType.UniqueIdentifier).Value = superv;
                    sup.UpdateCommand.ExecuteNonQuery();
                }

                if (ra > 0) {
                    MessageBox.Show("User edited successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                localCon.Close();
                Clean();
                loadUsers();


            }

        }

        private bool Validate() {

            if (txtFirstName.Text == "") {
                MessageBox.Show("Please provide a First Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtLastName.Text == "") {
                MessageBox.Show("Please provide a Last Name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtUsername.Text == "") {
                MessageBox.Show("Please provide a Username", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPassword.Text == "") {
                MessageBox.Show("Please provide a Password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void Clean() {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cbDistrict.SelectedIndex = -1;
            cbDepartment.SelectedIndex = -1;
            cbAccessLevel.SelectedIndex = -1;
            userIDEdit = "";
            dgvUsers.Rows.Clear();
            loadUsers();
            gbUserData.Visible = false;
            tlButtons.Visible = false;
            tlSelectButtons.Visible = true;
            dgvUsers.Enabled = true;
            txtEmail.Text = "";
            email = false;
            supervisor = false;
            chxSupervisor.Checked = false;
            chxCFO.Checked = false;
            chxDeputyDirectorMosquito.Checked = false;
            chxDeputyDirectorHyacinth.Checked = false;
            chxExecutiveDirector.Checked = false;
            chxAssistantDirector.Checked = false;
            chxAccountinProcessor.Checked = false;
            chxExecutiveProcessor.Checked = false;
            chxRegularEmployee.Checked = false;
            txtSearch.Text = "";
            chxActiveUser.Checked = false;
            txtPassword.PasswordChar = '*';
            if (loggedUsername == "TPineda") 
            {
                tlDeleteUser.Visible = true;
            }

            //reload the supervisors
            localCon.Open();
            string name = "";
            string id = "";
            SqlCommand sup = new SqlCommand("SELECT a.UserID,a.Name,a.LastName FROM [TravelExpenses].[dbo].[User] as a inner join [TravelExpenses].[dbo].[User_Email_Title] as b on a.UserID = b.UserID where b.Active = '1' AND (b.Title = 'Supervisor' or b.Title = 'Deputy Director Mosquito' or b.Title = 'Deputy Director Hyacinth' or b.Title = 'Executive Director' or b.Title = 'Assistant Director' or b.Title = 'CFO') order by Name", localCon);
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

        private void loadUsers() {
            dgvUsers.Rows.Clear();
            localCon.Open();
            SqlCommand cmdUsers = new SqlCommand("SELECT  a.*,b.Email as Email,b.Title as Title,b.Active as Active FROM [TravelExpenses].[dbo].[User] as a LEFT JOIN TravelExpenses.dbo.User_Email_Title as b on b.UserID = a.UserID order by a.Name", localCon);
            SqlDataReader dr = cmdUsers.ExecuteReader();

            while (dr.Read())
            {
                string title = "";
                bool active =Convert.ToBoolean(dr["Active"].ToString());
                if (dr["Title"].ToString() != "")
                {
                    title = dr["Title"].ToString();
                }
                string name = dr["Name"].ToString() + " " + dr["LastName"].ToString();
                dgvUsers.Rows.Add(name, dr["District"].ToString(), dr["Department"].ToString(), dr["UserID"].ToString(), dr["Username"].ToString(), dr["Password"].ToString(), dr["AccessLevel"].ToString(), dr["Name"].ToString(), dr["LastName"].ToString(),dr["Email"].ToString(),"", title, active);
            }
            dr.Close();

            for (int i = 0; i < dgvUsers.RowCount; i++)
            {
                Guid currentID = new Guid(dgvUsers.Rows[i].Cells[3].Value.ToString());
                SqlCommand signatures = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[UserSignature] where UserID = '"+ currentID + "'", localCon);
                SqlDataReader signaturesDR = signatures.ExecuteReader();
                if (signaturesDR.HasRows)
                {
                    dgvUsers.Rows[i].Cells[10].Value = "Yes";
                }
                else
                {
                    dgvUsers.Rows[i].Cells[10].Value = "No";
                }
                signaturesDR.Close();
            }

            localCon.Close();
            this.Size = new System.Drawing.Size(728, 304);
        }

        private void btnCreateSignature_Click(object sender, EventArgs e)
        {
            int userIndex = dgvUsers.CurrentRow.Index;
            userIDEdit = dgvUsers.Rows[userIndex].Cells[3].Value.ToString();
            bool hasSignature = false;
            localCon.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[UserSignature] where UserID = '" + userIDEdit + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                MessageBox.Show("This user has a signature already", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hasSignature = true;
            }
            dr.Close();
            localCon.Close();
            if (!hasSignature)
            {
                CommonVariables.userIDSiganture = userIDEdit;
                CommonVariables.isUserSignatureExist = true;
                CreateSignature cs = new CreateSignature();
                cs.ShowDialog();
                this.Close();
            }
        }

        private void bynSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                dgvUsers.Rows.Clear();
                localCon.Open();
                SqlCommand cmdUsers = new SqlCommand("SELECT  a.*,b.Email as Email,b.Title as Title,b.Active as Active FROM [TravelExpenses].[dbo].[User] as a LEFT JOIN TravelExpenses.dbo.User_Email_Title as b on b.UserID = a.UserID where a.Name like '"+ txtSearch.Text +"%' order by a.Name", localCon);
                SqlDataReader dr = cmdUsers.ExecuteReader();

                while (dr.Read())
                {
                    string title = "";
                    if (dr["Title"].ToString() != "")
                    {
                        title = dr["Title"].ToString();
                    }
                    string name = dr["Name"].ToString() + " " + dr["LastName"].ToString();
                    bool active = Convert.ToBoolean(dr["Active"].ToString());
                    dgvUsers.Rows.Add(name, dr["District"].ToString(), dr["Department"].ToString(), dr["UserID"].ToString(), dr["Username"].ToString(), dr["Password"].ToString(), dr["AccessLevel"].ToString(), dr["Name"].ToString(), dr["LastName"].ToString(), dr["Email"].ToString(), "", title,active);
                }
                dr.Close();

                for (int i = 0; i < dgvUsers.RowCount; i++)
                {
                    Guid currentID = new Guid(dgvUsers.Rows[i].Cells[3].Value.ToString());
                    SqlCommand signatures = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[UserSignature] where UserID = '" + currentID + "'", localCon);
                    SqlDataReader signaturesDR = signatures.ExecuteReader();
                    if (signaturesDR.HasRows)
                    {
                        dgvUsers.Rows[i].Cells[10].Value = "Yes";
                    }
                    else
                    {
                        dgvUsers.Rows[i].Cells[10].Value = "No";
                    }
                    signaturesDR.Close();
                }

                localCon.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            loadUsers();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPassword.Text);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int travels = 0;
            int authorizations = 0;
            int userDelIndex = dgvUsers.CurrentRow.Index;
            string userIDDel = dgvUsers.Rows[userDelIndex].Cells[3].Value.ToString();
            localCon.Open();
            SqlCommand userAuth = new SqlCommand("SELECT COUNT(TravelEstimateID) as Authorizations FROM [TravelExpenses].[dbo].[EstimateTravel] where UserID = '" + userIDDel + "'", localCon);
            SqlDataReader userAuthDR = userAuth.ExecuteReader();
            if (userAuthDR.HasRows)
            {
                while (userAuthDR.Read())
                {
                    authorizations = Convert.ToInt32(userAuthDR["Authorizations"].ToString());
                }
            }
            userAuthDR.Close();

            SqlCommand userTrav = new SqlCommand("SELECT  Count([TravelID]) as Travels FROM [TravelExpenses].[dbo].[Travel] where UserID = '" + userIDDel + "'", localCon);
            SqlDataReader userTravDR = userTrav.ExecuteReader();
            if (userTravDR.HasRows)
            {
                while (userTravDR.Read())
                {
                    travels = Convert.ToInt32(userTravDR["Travels"].ToString());
                }
            }
            userTravDR.Close();

            localCon.Close();

            if (travels > 0 || authorizations > 0)
            {
                MessageBox.Show("This user has travels and authorizations associates with it, can't be deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                DialogResult delUser = MessageBox.Show("Do you really want to delete this user?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (delUser == DialogResult.Yes)
                {
                    localCon.Open();
                    
                    SqlCommand delSignature = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[UserSignature] WHERE UserID = '"+ userIDDel + "'", localCon);
                    delSignature.ExecuteNonQuery();

                    SqlCommand delDetails = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[User_Email_Title] WHERE UserID = '"+ userIDDel + "'", localCon);
                    delDetails.ExecuteNonQuery();

                    SqlCommand deleteUser = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[User] WHERE UserID = '"+ userIDDel + "'", localCon);
                    deleteUser.ExecuteNonQuery();
                    localCon.Close();

                    MessageBox.Show("User deleted successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadUsers();
                }
            }

            
        }

        private void tlButtons_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
