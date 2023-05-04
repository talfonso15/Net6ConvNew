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
            this.components = new System.ComponentModel.Container();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccessLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Signature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TItle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gbSelectYourUser = new System.Windows.Forms.GroupBox();
            this.tlDeleteUser = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.tlSelectButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateSignature = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.bynSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbUserData = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnViewPassword = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblActiveUser = new System.Windows.Forms.Label();
            this.chxActiveUser = new System.Windows.Forms.CheckBox();
            this.lblAccessLevel = new System.Windows.Forms.Label();
            this.cbAccessLevel = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbSupervisor = new System.Windows.Forms.ComboBox();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.tlButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbTitles = new System.Windows.Forms.GroupBox();
            this.chxRegularEmployee = new System.Windows.Forms.RadioButton();
            this.chxExecutiveProcessor = new System.Windows.Forms.RadioButton();
            this.chxAccountinProcessor = new System.Windows.Forms.RadioButton();
            this.chxAssistantDirector = new System.Windows.Forms.RadioButton();
            this.chxExecutiveDirector = new System.Windows.Forms.RadioButton();
            this.chxDeputyDirectorHyacinth = new System.Windows.Forms.RadioButton();
            this.chxDeputyDirectorMosquito = new System.Windows.Forms.RadioButton();
            this.chxCFO = new System.Windows.Forms.RadioButton();
            this.chxSupervisor = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.gbSelectYourUser.SuspendLayout();
            this.tlDeleteUser.SuspendLayout();
            this.tlSelectButtons.SuspendLayout();
            this.gbUserData.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlButtons.SuspendLayout();
            this.gbTitles.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.District,
            this.Department,
            this.UserID,
            this.Username,
            this.Password,
            this.AccessLevel,
            this.FirstName,
            this.LastName,
            this.Email1,
            this.Signature,
            this.TItle,
            this.Active});
            this.dgvUsers.Location = new System.Drawing.Point(9, 66);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(638, 160);
            this.dgvUsers.TabIndex = 1;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 200;
            // 
            // District
            // 
            this.District.HeaderText = "District";
            this.District.Name = "District";
            this.District.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            this.Department.Width = 150;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Visible = false;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Visible = false;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Visible = false;
            // 
            // AccessLevel
            // 
            this.AccessLevel.HeaderText = "AccessLevel";
            this.AccessLevel.Name = "AccessLevel";
            this.AccessLevel.ReadOnly = true;
            this.AccessLevel.Visible = false;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Visible = false;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Visible = false;
            // 
            // Email1
            // 
            this.Email1.HeaderText = "Email";
            this.Email1.Name = "Email1";
            this.Email1.ReadOnly = true;
            this.Email1.Visible = false;
            // 
            // Signature
            // 
            this.Signature.HeaderText = "Signature";
            this.Signature.Name = "Signature";
            this.Signature.ReadOnly = true;
            // 
            // TItle
            // 
            this.TItle.HeaderText = "Title";
            this.TItle.Name = "TItle";
            this.TItle.ReadOnly = true;
            this.TItle.Visible = false;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Visible = false;
            // 
            // gbSelectYourUser
            // 
            this.gbSelectYourUser.Controls.Add(this.tlDeleteUser);
            this.gbSelectYourUser.Controls.Add(this.btnInfo);
            this.gbSelectYourUser.Controls.Add(this.dgvUsers);
            this.gbSelectYourUser.Controls.Add(this.tlSelectButtons);
            this.gbSelectYourUser.Location = new System.Drawing.Point(33, 16);
            this.gbSelectYourUser.Name = "gbSelectYourUser";
            this.gbSelectYourUser.Size = new System.Drawing.Size(653, 232);
            this.gbSelectYourUser.TabIndex = 2;
            this.gbSelectYourUser.TabStop = false;
            // 
            // tlDeleteUser
            // 
            this.tlDeleteUser.ColumnCount = 2;
            this.tlDeleteUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.85246F));
            this.tlDeleteUser.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.14754F));
            this.tlDeleteUser.Controls.Add(this.btnDeleteUser, 0, 0);
            this.tlDeleteUser.Controls.Add(this.label4, 1, 0);
            this.tlDeleteUser.Location = new System.Drawing.Point(99, 21);
            this.tlDeleteUser.Name = "tlDeleteUser";
            this.tlDeleteUser.RowCount = 1;
            this.tlDeleteUser.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlDeleteUser.Size = new System.Drawing.Size(61, 39);
            this.tlDeleteUser.TabIndex = 6;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Image = global::TravelExpenses.Properties.Resources.if_edit_delete_118920;
            this.btnDeleteUser.Location = new System.Drawing.Point(3, 3);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(35, 33);
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDeleteUser, "Delete User");
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Visible = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "|";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.btnInfo.Location = new System.Drawing.Point(6, 41);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(20, 23);
            this.btnInfo.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnInfo, "Select a user from the list and then click on the option that you want to perform" +
        " on it.");
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // tlSelectButtons
            // 
            this.tlSelectButtons.ColumnCount = 10;
            this.tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.11111F));
            this.tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tlSelectButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlSelectButtons.Controls.Add(this.label5, 3, 0);
            this.tlSelectButtons.Controls.Add(this.label2, 5, 0);
            this.tlSelectButtons.Controls.Add(this.txtSearch, 8, 0);
            this.tlSelectButtons.Controls.Add(this.bynSearch, 9, 0);
            this.tlSelectButtons.Controls.Add(this.btnCancel, 6, 0);
            this.tlSelectButtons.Controls.Add(this.label3, 7, 0);
            this.tlSelectButtons.Controls.Add(this.label1, 1, 0);
            this.tlSelectButtons.Controls.Add(this.btnRefresh, 0, 0);
            this.tlSelectButtons.Controls.Add(this.btnCreateSignature, 2, 0);
            this.tlSelectButtons.Controls.Add(this.btnEditUser, 4, 0);
            this.tlSelectButtons.Location = new System.Drawing.Point(160, 21);
            this.tlSelectButtons.Name = "tlSelectButtons";
            this.tlSelectButtons.RowCount = 1;
            this.tlSelectButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlSelectButtons.Size = new System.Drawing.Size(489, 39);
            this.tlSelectButtons.TabIndex = 4;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.Image = global::TravelExpenses.Properties.Resources.if_General_Office_09_2530835;
            this.btnEditUser.Location = new System.Drawing.Point(118, 3);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(33, 33);
            this.btnEditUser.TabIndex = 3;
            this.btnEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEditUser, "Edit User");
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "|";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateSignature
            // 
            this.btnCreateSignature.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateSignature.FlatAppearance.BorderSize = 0;
            this.btnCreateSignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSignature.Image = global::TravelExpenses.Properties.Resources.contract__4_;
            this.btnCreateSignature.Location = new System.Drawing.Point(64, 3);
            this.btnCreateSignature.Name = "btnCreateSignature";
            this.btnCreateSignature.Size = new System.Drawing.Size(27, 33);
            this.btnCreateSignature.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnCreateSignature, "Set Signature");
            this.btnCreateSignature.UseVisualStyleBackColor = true;
            this.btnCreateSignature.Click += new System.EventHandler(this.btnCreateSignature_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(236, 9);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 20);
            this.txtSearch.TabIndex = 8;
            // 
            // bynSearch
            // 
            this.bynSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bynSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bynSearch.ForeColor = System.Drawing.Color.ForestGreen;
            this.bynSearch.Location = new System.Drawing.Point(418, 3);
            this.bynSearch.Name = "bynSearch";
            this.bynSearch.Size = new System.Drawing.Size(57, 33);
            this.bynSearch.TabIndex = 9;
            this.bynSearch.Text = "Search";
            this.bynSearch.UseVisualStyleBackColor = true;
            this.bynSearch.Click += new System.EventHandler(this.bynSearch_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(216, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "|";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = global::TravelExpenses.Properties.Resources.if_Shutdown_Box_Red_34246;
            this.btnCancel.Location = new System.Drawing.Point(176, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(34, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnCancel, "Close");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Image = global::TravelExpenses.Properties.Resources.iconfinder_Replay_2001891;
            this.btnRefresh.Location = new System.Drawing.Point(5, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 33);
            this.btnRefresh.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnRefresh, "Refresh List");
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gbUserData
            // 
            this.gbUserData.Controls.Add(this.button1);
            this.gbUserData.Controls.Add(this.btnViewPassword);
            this.gbUserData.Controls.Add(this.tableLayoutPanel1);
            this.gbUserData.Controls.Add(this.tableLayoutPanel2);
            this.gbUserData.Enabled = false;
            this.gbUserData.Location = new System.Drawing.Point(33, 290);
            this.gbUserData.Name = "gbUserData";
            this.gbUserData.Size = new System.Drawing.Size(653, 235);
            this.gbUserData.TabIndex = 5;
            this.gbUserData.TabStop = false;
            this.gbUserData.Text = "User Data";
            this.gbUserData.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::TravelExpenses.Properties.Resources.copy_icon2;
            this.button1.Location = new System.Drawing.Point(626, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 25);
            this.button1.TabIndex = 8;
            this.toolTip1.SetToolTip(this.button1, "Copy Password");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewPassword
            // 
            this.btnViewPassword.FlatAppearance.BorderSize = 0;
            this.btnViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPassword.Image = global::TravelExpenses.Properties.Resources._6351930_eye_password_see_view_icon;
            this.btnViewPassword.Location = new System.Drawing.Point(600, 114);
            this.btnViewPassword.Name = "btnViewPassword";
            this.btnViewPassword.Size = new System.Drawing.Size(21, 19);
            this.btnViewPassword.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnViewPassword, "Show/Hide Password");
            this.btnViewPassword.UseVisualStyleBackColor = true;
            this.btnViewPassword.Click += new System.EventHandler(this.btnViewPassword_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.69132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.30869F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.Controls.Add(this.lblActiveUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chxActiveUser, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAccessLevel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbAccessLevel, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 186);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 39);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblActiveUser
            // 
            this.lblActiveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActiveUser.AutoSize = true;
            this.lblActiveUser.Location = new System.Drawing.Point(3, 13);
            this.lblActiveUser.Name = "lblActiveUser";
            this.lblActiveUser.Size = new System.Drawing.Size(97, 13);
            this.lblActiveUser.TabIndex = 2;
            this.lblActiveUser.Text = "Active:";
            // 
            // chxActiveUser
            // 
            this.chxActiveUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chxActiveUser.AutoSize = true;
            this.chxActiveUser.Location = new System.Drawing.Point(106, 12);
            this.chxActiveUser.Name = "chxActiveUser";
            this.chxActiveUser.Size = new System.Drawing.Size(15, 14);
            this.chxActiveUser.TabIndex = 3;
            this.chxActiveUser.UseVisualStyleBackColor = true;
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAccessLevel.AutoSize = true;
            this.lblAccessLevel.Location = new System.Drawing.Point(292, 13);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(84, 13);
            this.lblAccessLevel.TabIndex = 6;
            this.lblAccessLevel.Text = "Access Level:";
            this.lblAccessLevel.Visible = false;
            // 
            // cbAccessLevel
            // 
            this.cbAccessLevel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbAccessLevel.FormattingEnabled = true;
            this.cbAccessLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbAccessLevel.Location = new System.Drawing.Point(382, 9);
            this.cbAccessLevel.Name = "cbAccessLevel";
            this.cbAccessLevel.Size = new System.Drawing.Size(105, 21);
            this.cbAccessLevel.TabIndex = 13;
            this.cbAccessLevel.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.65957F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.70213F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31915F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.89362F));
            this.tableLayoutPanel2.Controls.Add(this.cbSupervisor, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblSupervisor, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblFirstName, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLastName, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDistrict, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDepartment, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblUsername, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblPassword, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtFirstName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtLastName, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbDistrict, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbDepartment, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtUsername, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtPassword, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblEmail, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtEmail, 3, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.04878F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.95122F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(586, 164);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbSupervisor
            // 
            this.cbSupervisor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSupervisor.FormattingEnabled = true;
            this.cbSupervisor.Location = new System.Drawing.Point(106, 135);
            this.cbSupervisor.Name = "cbSupervisor";
            this.cbSupervisor.Size = new System.Drawing.Size(180, 21);
            this.cbSupervisor.TabIndex = 1;
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Location = new System.Drawing.Point(3, 139);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(97, 13);
            this.lblSupervisor.TabIndex = 0;
            this.lblSupervisor.Text = "Supervisor:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(3, 14);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(292, 14);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblDistrict
            // 
            this.lblDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Location = new System.Drawing.Point(3, 55);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(97, 13);
            this.lblDistrict.TabIndex = 2;
            this.lblDistrict.Text = "District:";
            // 
            // lblDepartment
            // 
            this.lblDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(292, 55);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(84, 13);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department:";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 98);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(292, 98);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.Location = new System.Drawing.Point(106, 10);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(180, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.Location = new System.Drawing.Point(382, 10);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(201, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // cbDistrict
            // 
            this.cbDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Items.AddRange(new object[] {
            "Mosquito",
            "Hyacinth",
            "Both"});
            this.cbDistrict.Location = new System.Drawing.Point(106, 51);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(180, 21);
            this.cbDistrict.TabIndex = 9;
            this.cbDistrict.SelectedIndexChanged += new System.EventHandler(this.cbDistrict_SelectedIndexChanged);
            // 
            // cbDepartment
            // 
            this.cbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Items.AddRange(new object[] {
            "Accounting/Purchasing 101",
            "Air/Flee/Bldg & Grounds 102",
            "Educ & Communication 103",
            "Executive 104",
            "Field Validation 105",
            "Mosquito Group 106",
            "Pilots 107",
            "Scientific Intelligence 108",
            "Hyacinth",
            "Commissioners"});
            this.cbDepartment.Location = new System.Drawing.Point(382, 51);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(201, 21);
            this.cbDepartment.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(106, 94);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(180, 20);
            this.txtUsername.TabIndex = 11;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(382, 94);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(201, 20);
            this.txtPassword.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(292, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(382, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // tlButtons
            // 
            this.tlButtons.ColumnCount = 1;
            this.tlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlButtons.Controls.Add(this.btnUpdateUser, 0, 0);
            this.tlButtons.Location = new System.Drawing.Point(615, 620);
            this.tlButtons.Name = "tlButtons";
            this.tlButtons.RowCount = 1;
            this.tlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlButtons.Size = new System.Drawing.Size(81, 42);
            this.tlButtons.TabIndex = 6;
            this.tlButtons.Visible = false;
            this.tlButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.tlButtons_Paint);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateUser.Image = global::TravelExpenses.Properties.Resources._1495047519_Save;
            this.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.Location = new System.Drawing.Point(3, 4);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 34);
            this.btnUpdateUser.TabIndex = 0;
            this.btnUpdateUser.Text = "Save";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            // 
            // gbTitles
            // 
            this.gbTitles.Controls.Add(this.chxRegularEmployee);
            this.gbTitles.Controls.Add(this.chxExecutiveProcessor);
            this.gbTitles.Controls.Add(this.chxAccountinProcessor);
            this.gbTitles.Controls.Add(this.chxAssistantDirector);
            this.gbTitles.Controls.Add(this.chxExecutiveDirector);
            this.gbTitles.Controls.Add(this.chxDeputyDirectorHyacinth);
            this.gbTitles.Controls.Add(this.chxDeputyDirectorMosquito);
            this.gbTitles.Controls.Add(this.chxCFO);
            this.gbTitles.Controls.Add(this.chxSupervisor);
            this.gbTitles.Location = new System.Drawing.Point(33, 531);
            this.gbTitles.Name = "gbTitles";
            this.gbTitles.Size = new System.Drawing.Size(653, 75);
            this.gbTitles.TabIndex = 2;
            this.gbTitles.TabStop = false;
            this.gbTitles.Text = "Titles";
            // 
            // chxRegularEmployee
            // 
            this.chxRegularEmployee.AutoSize = true;
            this.chxRegularEmployee.Location = new System.Drawing.Point(485, 47);
            this.chxRegularEmployee.Name = "chxRegularEmployee";
            this.chxRegularEmployee.Size = new System.Drawing.Size(111, 17);
            this.chxRegularEmployee.TabIndex = 16;
            this.chxRegularEmployee.TabStop = true;
            this.chxRegularEmployee.Text = "Regular Employee";
            this.chxRegularEmployee.UseVisualStyleBackColor = true;
            // 
            // chxExecutiveProcessor
            // 
            this.chxExecutiveProcessor.AutoSize = true;
            this.chxExecutiveProcessor.Location = new System.Drawing.Point(317, 47);
            this.chxExecutiveProcessor.Name = "chxExecutiveProcessor";
            this.chxExecutiveProcessor.Size = new System.Drawing.Size(122, 17);
            this.chxExecutiveProcessor.TabIndex = 15;
            this.chxExecutiveProcessor.TabStop = true;
            this.chxExecutiveProcessor.Text = "Executive Processor";
            this.chxExecutiveProcessor.UseVisualStyleBackColor = true;
            // 
            // chxAccountinProcessor
            // 
            this.chxAccountinProcessor.AutoSize = true;
            this.chxAccountinProcessor.Location = new System.Drawing.Point(160, 47);
            this.chxAccountinProcessor.Name = "chxAccountinProcessor";
            this.chxAccountinProcessor.Size = new System.Drawing.Size(129, 17);
            this.chxAccountinProcessor.TabIndex = 14;
            this.chxAccountinProcessor.TabStop = true;
            this.chxAccountinProcessor.Text = "Accounting Processor";
            this.chxAccountinProcessor.UseVisualStyleBackColor = true;
            // 
            // chxAssistantDirector
            // 
            this.chxAssistantDirector.AutoSize = true;
            this.chxAssistantDirector.Location = new System.Drawing.Point(15, 47);
            this.chxAssistantDirector.Name = "chxAssistantDirector";
            this.chxAssistantDirector.Size = new System.Drawing.Size(107, 17);
            this.chxAssistantDirector.TabIndex = 13;
            this.chxAssistantDirector.TabStop = true;
            this.chxAssistantDirector.Text = "Assistant Director";
            this.chxAssistantDirector.UseVisualStyleBackColor = true;
            // 
            // chxExecutiveDirector
            // 
            this.chxExecutiveDirector.AutoSize = true;
            this.chxExecutiveDirector.Location = new System.Drawing.Point(485, 18);
            this.chxExecutiveDirector.Name = "chxExecutiveDirector";
            this.chxExecutiveDirector.Size = new System.Drawing.Size(112, 17);
            this.chxExecutiveDirector.TabIndex = 12;
            this.chxExecutiveDirector.TabStop = true;
            this.chxExecutiveDirector.Text = "Executive Director";
            this.chxExecutiveDirector.UseVisualStyleBackColor = true;
            // 
            // chxDeputyDirectorHyacinth
            // 
            this.chxDeputyDirectorHyacinth.AutoSize = true;
            this.chxDeputyDirectorHyacinth.Location = new System.Drawing.Point(317, 18);
            this.chxDeputyDirectorHyacinth.Name = "chxDeputyDirectorHyacinth";
            this.chxDeputyDirectorHyacinth.Size = new System.Drawing.Size(144, 17);
            this.chxDeputyDirectorHyacinth.TabIndex = 11;
            this.chxDeputyDirectorHyacinth.TabStop = true;
            this.chxDeputyDirectorHyacinth.Text = "Deputy Director Hyacinth";
            this.chxDeputyDirectorHyacinth.UseVisualStyleBackColor = true;
            // 
            // chxDeputyDirectorMosquito
            // 
            this.chxDeputyDirectorMosquito.AutoSize = true;
            this.chxDeputyDirectorMosquito.Location = new System.Drawing.Point(160, 18);
            this.chxDeputyDirectorMosquito.Name = "chxDeputyDirectorMosquito";
            this.chxDeputyDirectorMosquito.Size = new System.Drawing.Size(145, 17);
            this.chxDeputyDirectorMosquito.TabIndex = 10;
            this.chxDeputyDirectorMosquito.TabStop = true;
            this.chxDeputyDirectorMosquito.Text = "Deputy Director Mosquito";
            this.chxDeputyDirectorMosquito.UseVisualStyleBackColor = true;
            // 
            // chxCFO
            // 
            this.chxCFO.AutoSize = true;
            this.chxCFO.Location = new System.Drawing.Point(102, 19);
            this.chxCFO.Name = "chxCFO";
            this.chxCFO.Size = new System.Drawing.Size(46, 17);
            this.chxCFO.TabIndex = 7;
            this.chxCFO.TabStop = true;
            this.chxCFO.Text = "CFO";
            this.chxCFO.UseVisualStyleBackColor = true;
            // 
            // chxSupervisor
            // 
            this.chxSupervisor.AutoSize = true;
            this.chxSupervisor.Location = new System.Drawing.Point(15, 18);
            this.chxSupervisor.Name = "chxSupervisor";
            this.chxSupervisor.Size = new System.Drawing.Size(75, 17);
            this.chxSupervisor.TabIndex = 9;
            this.chxSupervisor.TabStop = true;
            this.chxSupervisor.Text = "Supervisor";
            this.chxSupervisor.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(40, 634);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Cancel Editing";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "|";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditUser
            // 
            this.AcceptButton = this.bynSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 673);
            this.ControlBox = false;
            this.Controls.Add(this.gbTitles);
            this.Controls.Add(this.tlButtons);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbUserData);
            this.Controls.Add(this.gbSelectYourUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit User";
            this.Load += new System.EventHandler(this.EditUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.gbSelectYourUser.ResumeLayout(false);
            this.tlDeleteUser.ResumeLayout(false);
            this.tlDeleteUser.PerformLayout();
            this.tlSelectButtons.ResumeLayout(false);
            this.tlSelectButtons.PerformLayout();
            this.gbUserData.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tlButtons.ResumeLayout(false);
            this.gbTitles.ResumeLayout(false);
            this.gbTitles.PerformLayout();
            this.ResumeLayout(false);

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