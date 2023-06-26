
namespace TravelExpenses
{
    partial class CreateNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewAccount));
            gbUserInfo = new System.Windows.Forms.GroupBox();
            btnViewPassword = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblIsSupervisor = new System.Windows.Forms.Label();
            txtFirstName = new System.Windows.Forms.TextBox();
            cbDepartment = new System.Windows.Forms.ComboBox();
            lblLastName = new System.Windows.Forms.Label();
            txtLastName = new System.Windows.Forms.TextBox();
            lblDistrict = new System.Windows.Forms.Label();
            cbDistrict = new System.Windows.Forms.ComboBox();
            Department = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            lblDigitalSignature = new System.Windows.Forms.Label();
            btnSiganture = new System.Windows.Forms.Button();
            lblSupervisor = new System.Windows.Forms.Label();
            cbSupervisor = new System.Windows.Forms.ComboBox();
            chxSupervisor = new System.Windows.Forms.CheckBox();
            lblFirstName = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            btnSaveUser = new System.Windows.Forms.Button();
            btnCancelUser = new System.Windows.Forms.Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            lblErrorWarnings = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            gbUserInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gbUserInfo
            // 
            gbUserInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            gbUserInfo.Controls.Add(btnViewPassword);
            gbUserInfo.Controls.Add(tableLayoutPanel1);
            gbUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            gbUserInfo.Location = new System.Drawing.Point(28, 29);
            gbUserInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbUserInfo.Name = "gbUserInfo";
            gbUserInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbUserInfo.Size = new System.Drawing.Size(876, 352);
            gbUserInfo.TabIndex = 5;
            gbUserInfo.TabStop = false;
            gbUserInfo.Text = "User Info";
            // 
            // btnViewPassword
            // 
            btnViewPassword.FlatAppearance.BorderSize = 0;
            btnViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewPassword.Image = Properties.Resources._6351930_eye_password_see_view_icon;
            btnViewPassword.Location = new System.Drawing.Point(845, 172);
            btnViewPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnViewPassword.Name = "btnViewPassword";
            btnViewPassword.Size = new System.Drawing.Size(24, 22);
            btnViewPassword.TabIndex = 9;
            btnViewPassword.UseVisualStyleBackColor = true;
            btnViewPassword.Click += btnViewPassword_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.06897F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.93103F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            tableLayoutPanel1.Controls.Add(lblIsSupervisor, 2, 4);
            tableLayoutPanel1.Controls.Add(txtFirstName, 1, 0);
            tableLayoutPanel1.Controls.Add(cbDepartment, 3, 1);
            tableLayoutPanel1.Controls.Add(lblLastName, 2, 0);
            tableLayoutPanel1.Controls.Add(txtLastName, 3, 0);
            tableLayoutPanel1.Controls.Add(lblDistrict, 0, 1);
            tableLayoutPanel1.Controls.Add(cbDistrict, 1, 1);
            tableLayoutPanel1.Controls.Add(Department, 2, 1);
            tableLayoutPanel1.Controls.Add(lblUsername, 0, 2);
            tableLayoutPanel1.Controls.Add(txtUsername, 1, 2);
            tableLayoutPanel1.Controls.Add(lblPassword, 2, 2);
            tableLayoutPanel1.Controls.Add(txtPassword, 3, 2);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 3);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 3);
            tableLayoutPanel1.Controls.Add(lblDigitalSignature, 0, 4);
            tableLayoutPanel1.Controls.Add(btnSiganture, 1, 4);
            tableLayoutPanel1.Controls.Add(lblSupervisor, 2, 3);
            tableLayoutPanel1.Controls.Add(cbSupervisor, 3, 3);
            tableLayoutPanel1.Controls.Add(chxSupervisor, 3, 4);
            tableLayoutPanel1.Controls.Add(lblFirstName, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(29, 32);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            tableLayoutPanel1.Size = new System.Drawing.Size(812, 295);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblIsSupervisor
            // 
            lblIsSupervisor.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblIsSupervisor.AutoSize = true;
            lblIsSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIsSupervisor.Location = new System.Drawing.Point(409, 259);
            lblIsSupervisor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblIsSupervisor.Name = "lblIsSupervisor";
            lblIsSupervisor.Size = new System.Drawing.Size(132, 13);
            lblIsSupervisor.TabIndex = 2;
            lblIsSupervisor.Text = "Are you a Supervisor?";
            lblIsSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFirstName.Location = new System.Drawing.Point(154, 19);
            txtFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new System.Drawing.Size(233, 20);
            txtFirstName.TabIndex = 1;
            // 
            // cbDepartment
            // 
            cbDepartment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Items.AddRange(new object[] { "Accounting/Purchasing 101", "Air/Flee/Bldg & Grounds 102", "Educ & Communication 103", "Executive 104", "Field Validation 105", "Mosquito Group 106", "Pilots 107", "Scientific Intelligence 108", "Hyacinth", "Commissioners" });
            cbDepartment.Location = new System.Drawing.Point(549, 78);
            cbDepartment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new System.Drawing.Size(230, 21);
            cbDepartment.TabIndex = 13;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLastName.AutoSize = true;
            lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLastName.Location = new System.Drawing.Point(409, 23);
            lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new System.Drawing.Size(132, 13);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtLastName.Location = new System.Drawing.Point(549, 19);
            txtLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(230, 20);
            txtLastName.TabIndex = 3;
            // 
            // lblDistrict
            // 
            lblDistrict.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDistrict.AutoSize = true;
            lblDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDistrict.Location = new System.Drawing.Point(4, 82);
            lblDistrict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDistrict.Name = "lblDistrict";
            lblDistrict.Size = new System.Drawing.Size(142, 13);
            lblDistrict.TabIndex = 4;
            lblDistrict.Text = "District:";
            lblDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbDistrict
            // 
            cbDistrict.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbDistrict.FormattingEnabled = true;
            cbDistrict.Items.AddRange(new object[] { "Mosquito", "Hyacinth", "Both" });
            cbDistrict.Location = new System.Drawing.Point(154, 78);
            cbDistrict.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbDistrict.Name = "cbDistrict";
            cbDistrict.Size = new System.Drawing.Size(233, 21);
            cbDistrict.TabIndex = 5;
            // 
            // Department
            // 
            Department.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            Department.AutoSize = true;
            Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Department.Location = new System.Drawing.Point(409, 82);
            Department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Department.Name = "Department";
            Department.Size = new System.Drawing.Size(132, 13);
            Department.TabIndex = 12;
            Department.Text = "Department:";
            Department.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUsername.Location = new System.Drawing.Point(4, 141);
            lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(142, 13);
            lblUsername.TabIndex = 6;
            lblUsername.Text = "Username:";
            lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUsername.Location = new System.Drawing.Point(154, 137);
            txtUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(233, 20);
            txtUsername.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPassword.Location = new System.Drawing.Point(409, 141);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(132, 13);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPassword.Location = new System.Drawing.Point(549, 137);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(230, 20);
            txtPassword.TabIndex = 9;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEmail.Location = new System.Drawing.Point(4, 200);
            lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(142, 13);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmail.Location = new System.Drawing.Point(154, 196);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(233, 20);
            txtEmail.TabIndex = 15;
            // 
            // lblDigitalSignature
            // 
            lblDigitalSignature.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDigitalSignature.AutoSize = true;
            lblDigitalSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDigitalSignature.Location = new System.Drawing.Point(4, 259);
            lblDigitalSignature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDigitalSignature.Name = "lblDigitalSignature";
            lblDigitalSignature.Size = new System.Drawing.Size(142, 13);
            lblDigitalSignature.TabIndex = 16;
            lblDigitalSignature.Text = "Digital Signature:";
            lblDigitalSignature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSiganture
            // 
            btnSiganture.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnSiganture.FlatAppearance.BorderSize = 0;
            btnSiganture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSiganture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSiganture.Image = (System.Drawing.Image)resources.GetObject("btnSiganture.Image");
            btnSiganture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSiganture.Location = new System.Drawing.Point(154, 244);
            btnSiganture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSiganture.Name = "btnSiganture";
            btnSiganture.Size = new System.Drawing.Size(133, 42);
            btnSiganture.TabIndex = 17;
            btnSiganture.Text = "Create Signature";
            btnSiganture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSiganture.UseVisualStyleBackColor = true;
            btnSiganture.Click += btnSiganture_Click;
            // 
            // lblSupervisor
            // 
            lblSupervisor.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblSupervisor.AutoSize = true;
            lblSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSupervisor.Location = new System.Drawing.Point(409, 200);
            lblSupervisor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSupervisor.Name = "lblSupervisor";
            lblSupervisor.Size = new System.Drawing.Size(132, 13);
            lblSupervisor.TabIndex = 0;
            lblSupervisor.Text = "Supervisor:";
            lblSupervisor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbSupervisor
            // 
            cbSupervisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            cbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbSupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cbSupervisor.FormattingEnabled = true;
            cbSupervisor.Location = new System.Drawing.Point(549, 196);
            cbSupervisor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbSupervisor.Name = "cbSupervisor";
            cbSupervisor.Size = new System.Drawing.Size(230, 21);
            cbSupervisor.TabIndex = 1;
            // 
            // chxSupervisor
            // 
            chxSupervisor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            chxSupervisor.AutoSize = true;
            chxSupervisor.Location = new System.Drawing.Point(549, 258);
            chxSupervisor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chxSupervisor.Name = "chxSupervisor";
            chxSupervisor.Size = new System.Drawing.Size(15, 14);
            chxSupervisor.TabIndex = 18;
            chxSupervisor.UseVisualStyleBackColor = true;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFirstName.Location = new System.Drawing.Point(4, 23);
            lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new System.Drawing.Size(142, 13);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First and Middle Name:";
            lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.69318F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.30682F));
            tableLayoutPanel2.Controls.Add(btnSaveUser, 1, 0);
            tableLayoutPanel2.Controls.Add(btnCancelUser, 0, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(493, 387);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(411, 62);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // btnSaveUser
            // 
            btnSaveUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnSaveUser.FlatAppearance.BorderSize = 0;
            btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSaveUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSaveUser.Image = (System.Drawing.Image)resources.GetObject("btnSaveUser.Image");
            btnSaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSaveUser.Location = new System.Drawing.Point(271, 11);
            btnSaveUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSaveUser.Name = "btnSaveUser";
            btnSaveUser.Size = new System.Drawing.Size(136, 39);
            btnSaveUser.TabIndex = 0;
            btnSaveUser.Text = "Save Account";
            btnSaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSaveUser.UseVisualStyleBackColor = true;
            btnSaveUser.Click += btnSaveUser_Click;
            // 
            // btnCancelUser
            // 
            btnCancelUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnCancelUser.FlatAppearance.BorderSize = 0;
            btnCancelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelUser.Image = (System.Drawing.Image)resources.GetObject("btnCancelUser.Image");
            btnCancelUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelUser.Location = new System.Drawing.Point(131, 11);
            btnCancelUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelUser.Name = "btnCancelUser";
            btnCancelUser.Size = new System.Drawing.Size(85, 39);
            btnCancelUser.TabIndex = 1;
            btnCancelUser.Text = "Close";
            btnCancelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelUser.UseVisualStyleBackColor = true;
            btnCancelUser.Click += btnCancelUser_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblErrorWarnings
            // 
            lblErrorWarnings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblErrorWarnings.AutoSize = true;
            lblErrorWarnings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblErrorWarnings.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
            lblErrorWarnings.Location = new System.Drawing.Point(96, 412);
            lblErrorWarnings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblErrorWarnings.Name = "lblErrorWarnings";
            lblErrorWarnings.Size = new System.Drawing.Size(283, 13);
            lblErrorWarnings.TabIndex = 8;
            lblErrorWarnings.Text = "Please check the info you provided, it has errors";
            lblErrorWarnings.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(37, 398);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(51, 39);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // CreateNewAccount
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(938, 455);
            Controls.Add(lblErrorWarnings);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(gbUserInfo);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CreateNewAccount";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Create New Account";
            Load += CreateNewAccount_Load;
            gbUserInfo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblIsSupervisor;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDigitalSignature;
        private System.Windows.Forms.Button btnSiganture;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.ComboBox cbSupervisor;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.CheckBox chxSupervisor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Button btnCancelUser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblErrorWarnings;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewPassword;
    }
}