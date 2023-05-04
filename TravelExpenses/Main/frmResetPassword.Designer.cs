
namespace TravelExpenses
{
    partial class frmResetPassword
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
            this.gbVerificationCode = new System.Windows.Forms.GroupBox();
            this.btnVerifyCode = new System.Windows.Forms.Button();
            this.txtVerificationCOde = new System.Windows.Forms.TextBox();
            this.lblVerificationCode = new System.Windows.Forms.Label();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbResetPassword = new System.Windows.Forms.GroupBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblSendingEmails = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbVerificationCode.SuspendLayout();
            this.gbResetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVerificationCode
            // 
            this.gbVerificationCode.Controls.Add(this.btnVerifyCode);
            this.gbVerificationCode.Controls.Add(this.txtVerificationCOde);
            this.gbVerificationCode.Controls.Add(this.lblVerificationCode);
            this.gbVerificationCode.Controls.Add(this.btnSendCode);
            this.gbVerificationCode.Controls.Add(this.txtEmail);
            this.gbVerificationCode.Controls.Add(this.lblEmail);
            this.gbVerificationCode.Location = new System.Drawing.Point(29, 30);
            this.gbVerificationCode.Name = "gbVerificationCode";
            this.gbVerificationCode.Size = new System.Drawing.Size(475, 130);
            this.gbVerificationCode.TabIndex = 0;
            this.gbVerificationCode.TabStop = false;
            this.gbVerificationCode.Text = "Verification Code";
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.FlatAppearance.BorderSize = 0;
            this.btnVerifyCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyCode.Image = global::TravelExpenses.Properties.Resources._4900847_card_credit_debit_payment_verify_icon;
            this.btnVerifyCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerifyCode.Location = new System.Drawing.Point(359, 76);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.Size = new System.Drawing.Size(102, 26);
            this.btnVerifyCode.TabIndex = 5;
            this.btnVerifyCode.Text = "Verify Code";
            this.btnVerifyCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerifyCode.UseVisualStyleBackColor = true;
            this.btnVerifyCode.Click += new System.EventHandler(this.btnVerifyCode_Click);
            // 
            // txtVerificationCOde
            // 
            this.txtVerificationCOde.Location = new System.Drawing.Point(159, 80);
            this.txtVerificationCOde.Name = "txtVerificationCOde";
            this.txtVerificationCOde.Size = new System.Drawing.Size(179, 20);
            this.txtVerificationCOde.TabIndex = 4;
            // 
            // lblVerificationCode
            // 
            this.lblVerificationCode.AutoSize = true;
            this.lblVerificationCode.Location = new System.Drawing.Point(13, 83);
            this.lblVerificationCode.Name = "lblVerificationCode";
            this.lblVerificationCode.Size = new System.Drawing.Size(141, 13);
            this.lblVerificationCode.TabIndex = 3;
            this.lblVerificationCode.Text = "Enter the code in your email:";
            // 
            // btnSendCode
            // 
            this.btnSendCode.FlatAppearance.BorderSize = 0;
            this.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCode.Image = global::TravelExpenses.Properties.Resources._1737385_e_mail_email_mail_message_messagesent_icon;
            this.btnSendCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendCode.Location = new System.Drawing.Point(359, 37);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(102, 23);
            this.btnSendCode.TabIndex = 2;
            this.btnSendCode.Text = "Send Code";
            this.btnSendCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.btnSendCode_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(159, 37);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(56, 40);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(97, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Provide your Email:";
            // 
            // gbResetPassword
            // 
            this.gbResetPassword.Controls.Add(this.txtConfirmPassword);
            this.gbResetPassword.Controls.Add(this.lblConfirmNewPassword);
            this.gbResetPassword.Controls.Add(this.txtNewPassword);
            this.gbResetPassword.Controls.Add(this.lblNewPassword);
            this.gbResetPassword.Enabled = false;
            this.gbResetPassword.Location = new System.Drawing.Point(29, 193);
            this.gbResetPassword.Name = "gbResetPassword";
            this.gbResetPassword.Size = new System.Drawing.Size(475, 137);
            this.gbResetPassword.TabIndex = 1;
            this.gbResetPassword.TabStop = false;
            this.gbResetPassword.Text = "Password info";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(159, 82);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(283, 20);
            this.txtConfirmPassword.TabIndex = 8;
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(30, 85);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(119, 13);
            this.lblConfirmNewPassword.TabIndex = 7;
            this.lblConfirmNewPassword.Text = "Confirm New Password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(159, 37);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(283, 20);
            this.txtNewPassword.TabIndex = 6;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(72, 40);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 13);
            this.lblNewPassword.TabIndex = 0;
            this.lblNewPassword.Text = "New Password:";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(326, 336);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 46);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Enabled = false;
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPassword.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnResetPassword.Image = global::TravelExpenses.Properties.Resources._7023958_password_account_security_reset_safety_icon;
            this.btnResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetPassword.Location = new System.Drawing.Point(425, 336);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(86, 46);
            this.btnResetPassword.TabIndex = 2;
            this.btnResetPassword.Text = "Reset";
            this.btnResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblSendingEmails
            // 
            this.lblSendingEmails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSendingEmails.AutoSize = true;
            this.lblSendingEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendingEmails.Location = new System.Drawing.Point(85, 354);
            this.lblSendingEmails.Name = "lblSendingEmails";
            this.lblSendingEmails.Size = new System.Drawing.Size(170, 13);
            this.lblSendingEmails.TabIndex = 6;
            this.lblSendingEmails.Text = "SendingVerification Code.....";
            this.lblSendingEmails.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBox1.Image = global::TravelExpenses.Properties.Resources.image_1229052;
            this.pictureBox1.Location = new System.Drawing.Point(35, 342);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 397);
            this.ControlBox = false;
            this.Controls.Add(this.lblSendingEmails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.gbResetPassword);
            this.Controls.Add(this.gbVerificationCode);
            this.Name = "frmResetPassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.gbVerificationCode.ResumeLayout(false);
            this.gbVerificationCode.PerformLayout();
            this.gbResetPassword.ResumeLayout(false);
            this.gbResetPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVerificationCode;
        private System.Windows.Forms.Button btnVerifyCode;
        private System.Windows.Forms.TextBox txtVerificationCOde;
        private System.Windows.Forms.Label lblVerificationCode;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbResetPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblSendingEmails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}