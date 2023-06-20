namespace TravelExpenses
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            txtPassword = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            lblHeader = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btnViewPassword = new System.Windows.Forms.Button();
            btnLogin = new System.Windows.Forms.Button();
            btnNewUser = new System.Windows.Forms.Button();
            btnSync = new System.Windows.Forms.Button();
            btnForgotPassword = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.7234F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.2766F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(lblUsername, 0, 0);
            tableLayoutPanel1.Controls.Add(txtUsername, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(lblPassword, 0, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(19, 18);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            tableLayoutPanel1.Size = new System.Drawing.Size(329, 125);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblUsername
            // 
            lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblUsername.Location = new System.Drawing.Point(4, 24);
            lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(86, 17);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtUsername.Location = new System.Drawing.Point(98, 21);
            txtUsername.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(227, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            txtPassword.Location = new System.Drawing.Point(98, 85);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(227, 23);
            txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblPassword.Location = new System.Drawing.Point(4, 88);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(86, 17);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            lblPassword.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblHeader
            // 
            lblHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblHeader.AutoSize = true;
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblHeader.Location = new System.Drawing.Point(99, 38);
            lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new System.Drawing.Size(303, 17);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Please Login with your Username and Password";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(btnViewPassword);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new System.Drawing.Point(83, 78);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(384, 203);
            panel1.TabIndex = 2;
            // 
            // btnViewPassword
            // 
            btnViewPassword.FlatAppearance.BorderSize = 0;
            btnViewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnViewPassword.Image = Properties.Resources._6351930_eye_password_see_view_icon;
            btnViewPassword.Location = new System.Drawing.Point(351, 105);
            btnViewPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnViewPassword.Name = "btnViewPassword";
            btnViewPassword.Size = new System.Drawing.Size(24, 22);
            btnViewPassword.TabIndex = 8;
            btnViewPassword.UseVisualStyleBackColor = true;
            btnViewPassword.Click += btnViewPassword_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogin.Image = (System.Drawing.Image)resources.GetObject("btnLogin.Image");
            btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnLogin.Location = new System.Drawing.Point(264, 147);
            btnLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(84, 51);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnNewUser
            // 
            btnNewUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnNewUser.FlatAppearance.BorderSize = 0;
            btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNewUser.Image = Properties.Resources._23203_add_user_new_user_user_icon__1_;
            btnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNewUser.Location = new System.Drawing.Point(231, 300);
            btnNewUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new System.Drawing.Size(136, 43);
            btnNewUser.TabIndex = 3;
            btnNewUser.Text = "Create an Account";
            btnNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnNewUser.UseVisualStyleBackColor = true;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // btnSync
            // 
            btnSync.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSync.Image = Properties.Resources._1496097664_reload;
            btnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSync.Location = new System.Drawing.Point(14, 27);
            btnSync.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSync.Name = "btnSync";
            btnSync.Size = new System.Drawing.Size(41, 28);
            btnSync.TabIndex = 2;
            btnSync.Text = "Sync";
            btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSync.UseVisualStyleBackColor = true;
            btnSync.Visible = false;
            btnSync.Click += btnSync_Click;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnForgotPassword.FlatAppearance.BorderSize = 0;
            btnForgotPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnForgotPassword.Image = Properties.Resources._4021466_lock_password_protect_security_shield_icon__2_;
            btnForgotPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnForgotPassword.Location = new System.Drawing.Point(66, 300);
            btnForgotPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new System.Drawing.Size(138, 43);
            btnForgotPassword.TabIndex = 2;
            btnForgotPassword.Text = "Forgot Password ?";
            btnForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnForgotPassword.UseVisualStyleBackColor = true;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancel.Image = Properties.Resources._1891023_cancel_cercle_close_delete_dismiss_icon;
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(399, 300);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(76, 43);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Close";
            btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Login
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(533, 357);
            ControlBox = false;
            Controls.Add(btnNewUser);
            Controls.Add(btnSync);
            Controls.Add(btnForgotPassword);
            Controls.Add(btnCancel);
            Controls.Add(panel1);
            Controls.Add(lblHeader);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnForgotPassword;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnViewPassword;
    }
}