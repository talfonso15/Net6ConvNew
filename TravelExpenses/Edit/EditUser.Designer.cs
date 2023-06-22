namespace TravelExpenses
{
    partial class EditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUser));
            dgvUsers = new System.Windows.Forms.DataGridView();
            FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AccessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Email1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Signature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TItle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            gbSelectYourUser = new System.Windows.Forms.GroupBox();
            tlDeleteUser = new System.Windows.Forms.TableLayoutPanel();
            btnDeleteUser = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            btnInfo = new System.Windows.Forms.Button();
            tlSelectButtons = new System.Windows.Forms.TableLayoutPanel();
            label5 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            bynSearch = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnRefresh = new System.Windows.Forms.Button();
            btnCreateSignature = new System.Windows.Forms.Button();
            btnEditUser = new System.Windows.Forms.Button();
            gbUserData = new System.Windows.Forms.GroupBox();
            button1 = new System.Windows.Forms.Button();
            btnViewPassword = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblActiveUser = new System.Windows.Forms.Label();
            chxActiveUser = new System.Windows.Forms.CheckBox();
            lblAccessLevel = new System.Windows.Forms.Label();
            cbAccessLevel = new System.Windows.Forms.ComboBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            cbSupervisor = new System.Windows.Forms.ComboBox();
            lblSupervisor = new System.Windows.Forms.Label();
            lblFirstName = new System.Windows.Forms.Label();
            lblLastName = new System.Windows.Forms.Label();
            lblDistrict = new System.Windows.Forms.Label();
            lblDepartment = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            lblPassword = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            cbDistrict = new System.Windows.Forms.ComboBox();
            cbDepartment = new System.Windows.Forms.ComboBox();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            tlButtons = new System.Windows.Forms.TableLayoutPanel();
            btnUpdateUser = new System.Windows.Forms.Button();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            gbTitles = new System.Windows.Forms.GroupBox();
            chxRegularEmployee = new System.Windows.Forms.RadioButton();
            chxExecutiveProcessor = new System.Windows.Forms.RadioButton();
            chxAccountinProcessor = new System.Windows.Forms.RadioButton();
            chxAssistantDirector = new System.Windows.Forms.RadioButton();
            chxExecutiveDirector = new System.Windows.Forms.RadioButton();
            chxDeputyDirectorHyacinth = new System.Windows.Forms.RadioButton();
            chxDeputyDirectorMosquito = new System.Windows.Forms.RadioButton();
            chxCFO = new System.Windows.Forms.RadioButton();
            chxSupervisor = new System.Windows.Forms.RadioButton();
            btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            gbSelectYourUser.SuspendLayout();
            tlDeleteUser.SuspendLayout();
            tlSelectButtons.SuspendLayout();
            gbUserData.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tlButtons.SuspendLayout();
            gbTitles.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { FullName, District, Department, UserID, Username, Password, AccessLevel, FirstName, LastName, Email1, Signature, TItle, Active });
            dgvUsers.Location = new System.Drawing.Point(10, 76);
            dgvUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new System.Drawing.Size(744, 185);
            dgvUsers.TabIndex = 1;
            // 
            // FullName
            // 
            FullName.HeaderText = "Name";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.Width = 200;
            // 
            // District
            // 
            District.HeaderText = "District";
            District.Name = "District";
            District.ReadOnly = true;
            // 
            // Department
            // 
            Department.HeaderText = "Department";
            Department.Name = "Department";
            Department.ReadOnly = true;
            Department.Width = 150;
            // 
            // UserID
            // 
            UserID.HeaderText = "UserID";
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Visible = false;
            // 
            // Username
            // 
            Username.HeaderText = "Username";
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Visible = false;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Visible = false;
            // 
            // AccessLevel
            // 
            AccessLevel.HeaderText = "AccessLevel";
            AccessLevel.Name = "AccessLevel";
            AccessLevel.ReadOnly = true;
            AccessLevel.Visible = false;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "FirstName";
            FirstName.Name = "FirstName";
            FirstName.ReadOnly = true;
            FirstName.Visible = false;
            // 
            // LastName
            // 
            LastName.HeaderText = "LastName";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Visible = false;
            // 
            // Email1
            // 
            Email1.HeaderText = "Email";
            Email1.Name = "Email1";
            Email1.ReadOnly = true;
            Email1.Visible = false;
            // 
            // Signature
            // 
            Signature.HeaderText = "Signature";
            Signature.Name = "Signature";
            Signature.ReadOnly = true;
            // 
            // TItle
            // 
            TItle.HeaderText = "Title";
            TItle.Name = "TItle";
            TItle.ReadOnly = true;
            TItle.Visible = false;
            // 
            // Active
            // 
            Active.HeaderText = "Active";
            Active.Name = "Active";
            Active.ReadOnly = true;
            Active.Visible = false;
            // 
            // gbSelectYourUser
            // 
            gbSelectYourUser.Controls.Add(tlDeleteUser);
            gbSelectYourUser.Controls.Add(btnInfo);
            gbSelectYourUser.Controls.Add(dgvUsers);
            gbSelectYourUser.Controls.Add(tlSelectButtons);
            gbSelectYourUser.Location = new System.Drawing.Point(38, 18);
            gbSelectYourUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbSelectYourUser.Name = "gbSelectYourUser";
            gbSelectYourUser.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbSelectYourUser.Size = new System.Drawing.Size(762, 268);
            gbSelectYourUser.TabIndex = 2;
            gbSelectYourUser.TabStop = false;
            // 
            // tlDeleteUser
            // 
            tlDeleteUser.ColumnCount = 2;
            tlDeleteUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.85246F));
            tlDeleteUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.14754F));
            tlDeleteUser.Controls.Add(btnDeleteUser, 0, 0);
            tlDeleteUser.Controls.Add(label4, 1, 0);
            tlDeleteUser.Location = new System.Drawing.Point(115, 24);
            tlDeleteUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlDeleteUser.Name = "tlDeleteUser";
            tlDeleteUser.RowCount = 1;
            tlDeleteUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlDeleteUser.Size = new System.Drawing.Size(71, 45);
            tlDeleteUser.TabIndex = 6;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDeleteUser.Image = (System.Drawing.Image)resources.GetObject("btnDeleteUser.Image");
            btnDeleteUser.Location = new System.Drawing.Point(4, 3);
            btnDeleteUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new System.Drawing.Size(40, 38);
            btnDeleteUser.TabIndex = 7;
            btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnDeleteUser, "Delete User");
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Visible = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(52, 10);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(15, 25);
            label4.TabIndex = 6;
            label4.Text = "|";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label4.Visible = false;
            // 
            // btnInfo
            // 
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnInfo.Image = Properties.Resources.if_information_14516;
            btnInfo.Location = new System.Drawing.Point(7, 47);
            btnInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new System.Drawing.Size(23, 27);
            btnInfo.TabIndex = 5;
            toolTip1.SetToolTip(btnInfo, "Select a user from the list and then click on the option that you want to perform on it.");
            btnInfo.UseVisualStyleBackColor = true;
            // 
            // tlSelectButtons
            // 
            tlSelectButtons.ColumnCount = 10;
            tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.6666641F));
            tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            tlSelectButtons.Controls.Add(label5, 3, 0);
            tlSelectButtons.Controls.Add(label2, 5, 0);
            tlSelectButtons.Controls.Add(txtSearch, 8, 0);
            tlSelectButtons.Controls.Add(bynSearch, 9, 0);
            tlSelectButtons.Controls.Add(btnCancel, 6, 0);
            tlSelectButtons.Controls.Add(label3, 7, 0);
            tlSelectButtons.Controls.Add(label1, 1, 0);
            tlSelectButtons.Controls.Add(btnRefresh, 0, 0);
            tlSelectButtons.Controls.Add(btnCreateSignature, 2, 0);
            tlSelectButtons.Controls.Add(btnEditUser, 4, 0);
            tlSelectButtons.Location = new System.Drawing.Point(187, 24);
            tlSelectButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlSelectButtons.Name = "tlSelectButtons";
            tlSelectButtons.RowCount = 1;
            tlSelectButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlSelectButtons.Size = new System.Drawing.Size(570, 45);
            tlSelectButtons.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(114, 10);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(14, 25);
            label5.TabIndex = 12;
            label5.Text = "|";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(182, 10);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(14, 25);
            label2.TabIndex = 7;
            label2.Text = "|";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtSearch.Location = new System.Drawing.Point(274, 11);
            txtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(192, 23);
            txtSearch.TabIndex = 8;
            // 
            // bynSearch
            // 
            bynSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            bynSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            bynSearch.ForeColor = System.Drawing.Color.ForestGreen;
            bynSearch.Location = new System.Drawing.Point(487, 3);
            bynSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bynSearch.Name = "bynSearch";
            bynSearch.Size = new System.Drawing.Size(66, 38);
            bynSearch.TabIndex = 9;
            bynSearch.Text = "Search";
            bynSearch.UseVisualStyleBackColor = true;
            bynSearch.Click += bynSearch_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.Image = (System.Drawing.Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new System.Drawing.Point(204, 3);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(39, 38);
            btnCancel.TabIndex = 4;
            btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnCancel, "Close");
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(251, 10);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(15, 25);
            label3.TabIndex = 10;
            label3.Text = "|";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(48, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(14, 25);
            label1.TabIndex = 5;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnRefresh.Image = Properties.Resources.iconfinder_Replay_2001891;
            btnRefresh.Location = new System.Drawing.Point(4, 3);
            btnRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(36, 38);
            btnRefresh.TabIndex = 11;
            toolTip1.SetToolTip(btnRefresh, "Refresh List");
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnCreateSignature
            // 
            btnCreateSignature.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCreateSignature.FlatAppearance.BorderSize = 0;
            btnCreateSignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCreateSignature.Image = (System.Drawing.Image)resources.GetObject("btnCreateSignature.Image");
            btnCreateSignature.Location = new System.Drawing.Point(72, 3);
            btnCreateSignature.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCreateSignature.Name = "btnCreateSignature";
            btnCreateSignature.Size = new System.Drawing.Size(31, 38);
            btnCreateSignature.TabIndex = 6;
            toolTip1.SetToolTip(btnCreateSignature, "Set Signature");
            btnCreateSignature.UseVisualStyleBackColor = true;
            btnCreateSignature.Click += btnCreateSignature_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnEditUser.FlatAppearance.BorderSize = 0;
            btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEditUser.Image = (System.Drawing.Image)resources.GetObject("btnEditUser.Image");
            btnEditUser.Location = new System.Drawing.Point(136, 3);
            btnEditUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new System.Drawing.Size(38, 38);
            btnEditUser.TabIndex = 3;
            btnEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnEditUser, "Edit User");
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // gbUserData
            // 
            gbUserData.Controls.Add(button1);
            gbUserData.Controls.Add(btnViewPassword);
            gbUserData.Controls.Add(tableLayoutPanel1);
            gbUserData.Controls.Add(tableLayoutPanel2);
            gbUserData.Enabled = false;
            gbUserData.Location = new System.Drawing.Point(38, 335);
            gbUserData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbUserData.Name = "gbUserData";
            gbUserData.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbUserData.Size = new System.Drawing.Size(762, 271);
            gbUserData.TabIndex = 5;
            gbUserData.TabStop = false;
            gbUserData.Text = "User Data";
            gbUserData.Visible = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Image = Properties.Resources.copy_icon2;
            button1.Location = new System.Drawing.Point(730, 128);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(24, 29);
            button1.TabIndex = 8;
            toolTip1.SetToolTip(button1, "Copy Password");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnViewPassword
            // 
            btnViewPassword.FlatAppearance.BorderSize = 0;
            btnViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewPassword.Image = Properties.Resources._6351930_eye_password_see_view_icon;
            btnViewPassword.Location = new System.Drawing.Point(700, 132);
            btnViewPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnViewPassword.Name = "btnViewPassword";
            btnViewPassword.Size = new System.Drawing.Size(24, 22);
            btnViewPassword.TabIndex = 7;
            toolTip1.SetToolTip(btnViewPassword, "Show/Hide Password");
            btnViewPassword.UseVisualStyleBackColor = true;
            btnViewPassword.Click += btnViewPassword_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.69132F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.30869F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            tableLayoutPanel1.Controls.Add(lblActiveUser, 0, 0);
            tableLayoutPanel1.Controls.Add(chxActiveUser, 1, 0);
            tableLayoutPanel1.Controls.Add(lblAccessLevel, 2, 0);
            tableLayoutPanel1.Controls.Add(cbAccessLevel, 3, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(13, 215);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(684, 45);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblActiveUser
            // 
            lblActiveUser.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblActiveUser.AutoSize = true;
            lblActiveUser.Location = new System.Drawing.Point(4, 15);
            lblActiveUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblActiveUser.Name = "lblActiveUser";
            lblActiveUser.Size = new System.Drawing.Size(112, 15);
            lblActiveUser.TabIndex = 2;
            lblActiveUser.Text = "Active:";
            // 
            // chxActiveUser
            // 
            chxActiveUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chxActiveUser.AutoSize = true;
            chxActiveUser.Location = new System.Drawing.Point(124, 15);
            chxActiveUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxActiveUser.Name = "chxActiveUser";
            chxActiveUser.Size = new System.Drawing.Size(15, 14);
            chxActiveUser.TabIndex = 3;
            chxActiveUser.UseVisualStyleBackColor = true;
            // 
            // lblAccessLevel
            // 
            lblAccessLevel.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblAccessLevel.AutoSize = true;
            lblAccessLevel.Location = new System.Drawing.Point(341, 15);
            lblAccessLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAccessLevel.Name = "lblAccessLevel";
            lblAccessLevel.Size = new System.Drawing.Size(97, 15);
            lblAccessLevel.TabIndex = 6;
            lblAccessLevel.Text = "Access Level:";
            lblAccessLevel.Visible = false;
            // 
            // cbAccessLevel
            // 
            cbAccessLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cbAccessLevel.FormattingEnabled = true;
            cbAccessLevel.Items.AddRange(new object[] { "1", "2", "3" });
            cbAccessLevel.Location = new System.Drawing.Point(446, 11);
            cbAccessLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbAccessLevel.Name = "cbAccessLevel";
            cbAccessLevel.Size = new System.Drawing.Size(122, 23);
            cbAccessLevel.TabIndex = 13;
            cbAccessLevel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.65957F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.70213F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31915F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.89362F));
            tableLayoutPanel2.Controls.Add(cbSupervisor, 1, 3);
            tableLayoutPanel2.Controls.Add(lblSupervisor, 0, 3);
            tableLayoutPanel2.Controls.Add(lblFirstName, 0, 0);
            tableLayoutPanel2.Controls.Add(lblLastName, 2, 0);
            tableLayoutPanel2.Controls.Add(lblDistrict, 0, 1);
            tableLayoutPanel2.Controls.Add(lblDepartment, 2, 1);
            tableLayoutPanel2.Controls.Add(lblUsername, 0, 2);
            tableLayoutPanel2.Controls.Add(lblPassword, 2, 2);
            tableLayoutPanel2.Controls.Add(txtFirstName, 1, 0);
            tableLayoutPanel2.Controls.Add(txtLastName, 3, 0);
            tableLayoutPanel2.Controls.Add(cbDistrict, 1, 1);
            tableLayoutPanel2.Controls.Add(cbDepartment, 3, 1);
            tableLayoutPanel2.Controls.Add(txtUsername, 1, 2);
            tableLayoutPanel2.Controls.Add(txtPassword, 3, 2);
            tableLayoutPanel2.Controls.Add(lblEmail, 2, 3);
            tableLayoutPanel2.Controls.Add(txtEmail, 3, 3);
            tableLayoutPanel2.Location = new System.Drawing.Point(13, 22);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.04878F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.95122F));
            tableLayoutPanel2.Size = new System.Drawing.Size(684, 189);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // cbSupervisor
            // 
            cbSupervisor.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbSupervisor.FormattingEnabled = true;
            cbSupervisor.Location = new System.Drawing.Point(125, 156);
            cbSupervisor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbSupervisor.Name = "cbSupervisor";
            cbSupervisor.Size = new System.Drawing.Size(209, 23);
            cbSupervisor.TabIndex = 1;
            // 
            // lblSupervisor
            // 
            lblSupervisor.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSupervisor.AutoSize = true;
            lblSupervisor.Location = new System.Drawing.Point(4, 160);
            lblSupervisor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSupervisor.Name = "lblSupervisor";
            lblSupervisor.Size = new System.Drawing.Size(113, 15);
            lblSupervisor.TabIndex = 0;
            lblSupervisor.Text = "Supervisor:";
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(4, 16);
            lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(113, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(342, 16);
            lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(97, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Last Name:";
            // 
            // lblDistrict
            // 
            lblDistrict.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDistrict.AutoSize = true;
            lblDistrict.Location = new System.Drawing.Point(4, 63);
            lblDistrict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new System.Drawing.Size(113, 15);
            lblDistrict.TabIndex = 2;
            lblDistrict.Text = "District:";
            // 
            // lblDepartment
            // 
            lblDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new System.Drawing.Point(342, 63);
            lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new System.Drawing.Size(97, 15);
            lblDepartment.TabIndex = 3;
            lblDepartment.Text = "Department:";
            // 
            // lblUsername
            // 
            lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(4, 113);
            lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(113, 15);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(342, 113);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(60, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFirstName.Location = new System.Drawing.Point(125, 12);
            txtFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(209, 22);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLastName.Location = new System.Drawing.Point(447, 12);
            txtLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(233, 22);
            txtLastName.TabIndex = 8;
            // 
            // cbDistrict
            // 
            cbDistrict.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbDistrict.FormattingEnabled = true;
            cbDistrict.Items.AddRange(new object[] { "Mosquito", "Hyacinth", "Both" });
            cbDistrict.Location = new System.Drawing.Point(125, 59);
            cbDistrict.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbDistrict.Name = "cbDistrict";
            cbDistrict.Size = new System.Drawing.Size(209, 23);
            cbDistrict.TabIndex = 9;
            cbDistrict.SelectedIndexChanged += cbDistrict_SelectedIndexChanged;
            // 
            // cbDepartment
            // 
            cbDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Items.AddRange(new object[] { "Accounting/Purchasing 101", "Air/Flee/Bldg & Grounds 102", "Educ & Communication 103", "Executive 104", "Field Validation 105", "Mosquito Group 106", "Pilots 107", "Scientific Intelligence 108", "Hyacinth", "Commissioners" });
            cbDepartment.Location = new System.Drawing.Point(447, 59);
            cbDepartment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new System.Drawing.Size(233, 23);
            cbDepartment.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtUsername.Location = new System.Drawing.Point(125, 109);
            txtUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(209, 23);
            txtUsername.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtPassword.Location = new System.Drawing.Point(447, 109);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(233, 23);
            txtPassword.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(342, 160);
            lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(97, 15);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtEmail.Location = new System.Drawing.Point(447, 156);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(233, 23);
            txtEmail.TabIndex = 15;
            // 
            // tlButtons
            // 
            tlButtons.ColumnCount = 1;
            tlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlButtons.Controls.Add(btnUpdateUser, 0, 0);
            tlButtons.Location = new System.Drawing.Point(709, 715);
            tlButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlButtons.Name = "tlButtons";
            tlButtons.RowCount = 1;
            tlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlButtons.Size = new System.Drawing.Size(86, 48);
            tlButtons.TabIndex = 6;
            tlButtons.Visible = false;
            tlButtons.Paint += tlButtons_Paint;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnUpdateUser.FlatAppearance.BorderSize = 0;
            btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnUpdateUser.Image = (System.Drawing.Image)resources.GetObject("btnUpdateUser.Image");
            btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUpdateUser.Location = new System.Drawing.Point(4, 4);
            btnUpdateUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new System.Drawing.Size(78, 39);
            btnUpdateUser.TabIndex = 0;
            btnUpdateUser.Text = "Save";
            btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 250;
            // 
            // gbTitles
            // 
            gbTitles.Controls.Add(chxRegularEmployee);
            gbTitles.Controls.Add(chxExecutiveProcessor);
            gbTitles.Controls.Add(chxAccountinProcessor);
            gbTitles.Controls.Add(chxAssistantDirector);
            gbTitles.Controls.Add(chxExecutiveDirector);
            gbTitles.Controls.Add(chxDeputyDirectorHyacinth);
            gbTitles.Controls.Add(chxDeputyDirectorMosquito);
            gbTitles.Controls.Add(chxCFO);
            gbTitles.Controls.Add(chxSupervisor);
            gbTitles.Location = new System.Drawing.Point(38, 613);
            gbTitles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbTitles.Name = "gbTitles";
            gbTitles.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbTitles.Size = new System.Drawing.Size(762, 87);
            gbTitles.TabIndex = 2;
            gbTitles.TabStop = false;
            gbTitles.Text = "Titles";
            // 
            // chxRegularEmployee
            // 
            chxRegularEmployee.AutoSize = true;
            chxRegularEmployee.Location = new System.Drawing.Point(566, 54);
            chxRegularEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxRegularEmployee.Name = "chxRegularEmployee";
            chxRegularEmployee.Size = new System.Drawing.Size(120, 19);
            chxRegularEmployee.TabIndex = 16;
            chxRegularEmployee.TabStop = true;
            chxRegularEmployee.Text = "Regular Employee";
            chxRegularEmployee.UseVisualStyleBackColor = true;
            // 
            // chxExecutiveProcessor
            // 
            chxExecutiveProcessor.AutoSize = true;
            chxExecutiveProcessor.Location = new System.Drawing.Point(370, 54);
            chxExecutiveProcessor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxExecutiveProcessor.Name = "chxExecutiveProcessor";
            chxExecutiveProcessor.Size = new System.Drawing.Size(129, 19);
            chxExecutiveProcessor.TabIndex = 15;
            chxExecutiveProcessor.TabStop = true;
            chxExecutiveProcessor.Text = "Executive Processor";
            chxExecutiveProcessor.UseVisualStyleBackColor = true;
            // 
            // chxAccountinProcessor
            // 
            chxAccountinProcessor.AutoSize = true;
            chxAccountinProcessor.Location = new System.Drawing.Point(187, 54);
            chxAccountinProcessor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxAccountinProcessor.Name = "chxAccountinProcessor";
            chxAccountinProcessor.Size = new System.Drawing.Size(141, 19);
            chxAccountinProcessor.TabIndex = 14;
            chxAccountinProcessor.TabStop = true;
            chxAccountinProcessor.Text = "Accounting Processor";
            chxAccountinProcessor.UseVisualStyleBackColor = true;
            // 
            // chxAssistantDirector
            // 
            chxAssistantDirector.AutoSize = true;
            chxAssistantDirector.Location = new System.Drawing.Point(18, 54);
            chxAssistantDirector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxAssistantDirector.Name = "chxAssistantDirector";
            chxAssistantDirector.Size = new System.Drawing.Size(117, 19);
            chxAssistantDirector.TabIndex = 13;
            chxAssistantDirector.TabStop = true;
            chxAssistantDirector.Text = "Assistant Director";
            chxAssistantDirector.UseVisualStyleBackColor = true;
            // 
            // chxExecutiveDirector
            // 
            chxExecutiveDirector.AutoSize = true;
            chxExecutiveDirector.Location = new System.Drawing.Point(566, 21);
            chxExecutiveDirector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxExecutiveDirector.Name = "chxExecutiveDirector";
            chxExecutiveDirector.Size = new System.Drawing.Size(120, 19);
            chxExecutiveDirector.TabIndex = 12;
            chxExecutiveDirector.TabStop = true;
            chxExecutiveDirector.Text = "Executive Director";
            chxExecutiveDirector.UseVisualStyleBackColor = true;
            // 
            // chxDeputyDirectorHyacinth
            // 
            chxDeputyDirectorHyacinth.AutoSize = true;
            chxDeputyDirectorHyacinth.Location = new System.Drawing.Point(370, 21);
            chxDeputyDirectorHyacinth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxDeputyDirectorHyacinth.Name = "chxDeputyDirectorHyacinth";
            chxDeputyDirectorHyacinth.Size = new System.Drawing.Size(159, 19);
            chxDeputyDirectorHyacinth.TabIndex = 11;
            chxDeputyDirectorHyacinth.TabStop = true;
            chxDeputyDirectorHyacinth.Text = "Deputy Director Hyacinth";
            chxDeputyDirectorHyacinth.UseVisualStyleBackColor = true;
            // 
            // chxDeputyDirectorMosquito
            // 
            chxDeputyDirectorMosquito.AutoSize = true;
            chxDeputyDirectorMosquito.Location = new System.Drawing.Point(187, 21);
            chxDeputyDirectorMosquito.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxDeputyDirectorMosquito.Name = "chxDeputyDirectorMosquito";
            chxDeputyDirectorMosquito.Size = new System.Drawing.Size(162, 19);
            chxDeputyDirectorMosquito.TabIndex = 10;
            chxDeputyDirectorMosquito.TabStop = true;
            chxDeputyDirectorMosquito.Text = "Deputy Director Mosquito";
            chxDeputyDirectorMosquito.UseVisualStyleBackColor = true;
            // 
            // chxCFO
            // 
            chxCFO.AutoSize = true;
            chxCFO.Location = new System.Drawing.Point(119, 22);
            chxCFO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxCFO.Name = "chxCFO";
            chxCFO.Size = new System.Drawing.Size(48, 19);
            chxCFO.TabIndex = 7;
            chxCFO.TabStop = true;
            chxCFO.Text = "CFO";
            chxCFO.UseVisualStyleBackColor = true;
            // 
            // chxSupervisor
            // 
            chxSupervisor.AutoSize = true;
            chxSupervisor.Location = new System.Drawing.Point(18, 21);
            chxSupervisor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxSupervisor.Name = "chxSupervisor";
            chxSupervisor.Size = new System.Drawing.Size(80, 19);
            chxSupervisor.TabIndex = 9;
            chxSupervisor.TabStop = true;
            chxSupervisor.Text = "Supervisor";
            chxSupervisor.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(31, 719);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(94, 39);
            btnClose.TabIndex = 1;
            btnClose.Text = "Cancel";
            btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // EditUser
            // 
            AcceptButton = bynSearch;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(812, 764);
            ControlBox = false;
            Controls.Add(gbTitles);
            Controls.Add(tlButtons);
            Controls.Add(btnClose);
            Controls.Add(gbUserData);
            Controls.Add(gbSelectYourUser);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EditUser";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Edit User";
            Load += EditUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            gbSelectYourUser.ResumeLayout(false);
            tlDeleteUser.ResumeLayout(false);
            tlDeleteUser.PerformLayout();
            tlSelectButtons.ResumeLayout(false);
            tlSelectButtons.PerformLayout();
            gbUserData.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tlButtons.ResumeLayout(false);
            gbTitles.ResumeLayout(false);
            gbTitles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox gbSelectYourUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.TableLayoutPanel tlSelectButtons;
        private System.Windows.Forms.GroupBox gbUserData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblAccessLevel;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cbAccessLevel;
        private System.Windows.Forms.TableLayoutPanel tlButtons;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateSignature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.ComboBox cbSupervisor;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gbTitles;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button bynSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblActiveUser;
        private System.Windows.Forms.CheckBox chxActiveUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn District;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccessLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Signature;
        private System.Windows.Forms.DataGridViewTextBoxColumn TItle;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.RadioButton chxSupervisor;
        private System.Windows.Forms.RadioButton chxRegularEmployee;
        private System.Windows.Forms.RadioButton chxExecutiveProcessor;
        private System.Windows.Forms.RadioButton chxAccountinProcessor;
        private System.Windows.Forms.RadioButton chxAssistantDirector;
        private System.Windows.Forms.RadioButton chxExecutiveDirector;
        private System.Windows.Forms.RadioButton chxDeputyDirectorHyacinth;
        private System.Windows.Forms.RadioButton chxDeputyDirectorMosquito;
        private System.Windows.Forms.RadioButton chxCFO;
        private System.Windows.Forms.Button btnViewPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tlDeleteUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}