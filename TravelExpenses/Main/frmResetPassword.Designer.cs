
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResetPassword));
            gbVerificationCode = new System.Windows.Forms.GroupBox();
            btnVerifyCode = new System.Windows.Forms.Button();
            txtVerificationCOde = new System.Windows.Forms.TextBox();
            lblVerificationCode = new System.Windows.Forms.Label();
            btnSendCode = new System.Windows.Forms.Button();
            txtEmail = new System.Windows.Forms.TextBox();
            lblEmail = new System.Windows.Forms.Label();
            gbResetPassword = new System.Windows.Forms.GroupBox();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            lblConfirmNewPassword = new System.Windows.Forms.Label();
            txtNewPassword = new System.Windows.Forms.TextBox();
            lblNewPassword = new System.Windows.Forms.Label();
            btnClose = new System.Windows.Forms.Button();
            btnResetPassword = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            lblSendingEmails = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gbVerificationCode.SuspendLayout();
            gbResetPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gbVerificationCode
            // 
            gbVerificationCode.Controls.Add(btnVerifyCode);
            gbVerificationCode.Controls.Add(txtVerificationCOde);
            gbVerificationCode.Controls.Add(lblVerificationCode);
            gbVerificationCode.Controls.Add(btnSendCode);
            gbVerificationCode.Controls.Add(txtEmail);
            gbVerificationCode.Controls.Add(lblEmail);
            gbVerificationCode.Location = new System.Drawing.Point(34, 35);
            gbVerificationCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbVerificationCode.Name = "gbVerificationCode";
            gbVerificationCode.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbVerificationCode.Size = new System.Drawing.Size(554, 150);
            gbVerificationCode.TabIndex = 0;
            gbVerificationCode.TabStop = false;
            gbVerificationCode.Text = "Verification Code";
            // 
            // btnVerifyCode
            // 
            btnVerifyCode.FlatAppearance.BorderSize = 0;
            btnVerifyCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnVerifyCode.Image = Properties.Resources._4900847_card_credit_debit_payment_verify_icon;
            btnVerifyCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnVerifyCode.Location = new System.Drawing.Point(419, 88);
            btnVerifyCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnVerifyCode.Name = "btnVerifyCode";
            btnVerifyCode.Size = new System.Drawing.Size(119, 30);
            btnVerifyCode.TabIndex = 5;
            btnVerifyCode.Text = "Verify Code";
            btnVerifyCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnVerifyCode.UseVisualStyleBackColor = true;
            btnVerifyCode.Click += btnVerifyCode_Click;
            // 
            // txtVerificationCOde
            // 
            txtVerificationCOde.Location = new System.Drawing.Point(186, 92);
            txtVerificationCOde.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtVerificationCOde.Name = "txtVerificationCOde";
            txtVerificationCOde.Size = new System.Drawing.Size(208, 23);
            txtVerificationCOde.TabIndex = 4;
            // 
            // lblVerificationCode
            // 
            lblVerificationCode.AutoSize = true;
            lblVerificationCode.Location = new System.Drawing.Point(15, 96);
            lblVerificationCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblVerificationCode.Name = "lblVerificationCode";
            lblVerificationCode.Size = new System.Drawing.Size(158, 15);
            lblVerificationCode.TabIndex = 3;
            lblVerificationCode.Text = "Enter the code in your email:";
            // 
            // btnSendCode
            // 
            btnSendCode.FlatAppearance.BorderSize = 0;
            btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSendCode.Image = Properties.Resources._1737385_e_mail_email_mail_message_messagesent_icon;
            btnSendCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSendCode.Location = new System.Drawing.Point(419, 43);
            btnSendCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSendCode.Name = "btnSendCode";
            btnSendCode.Size = new System.Drawing.Size(119, 27);
            btnSendCode.TabIndex = 2;
            btnSendCode.Text = "Send Code";
            btnSendCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSendCode.UseVisualStyleBackColor = true;
            btnSendCode.Click += btnSendCode_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(186, 43);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(208, 23);
            txtEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new System.Drawing.Point(65, 46);
            lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(109, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Provide your Email:";
            // 
            // gbResetPassword
            // 
            gbResetPassword.Controls.Add(txtConfirmPassword);
            gbResetPassword.Controls.Add(lblConfirmNewPassword);
            gbResetPassword.Controls.Add(txtNewPassword);
            gbResetPassword.Controls.Add(lblNewPassword);
            gbResetPassword.Enabled = false;
            gbResetPassword.Location = new System.Drawing.Point(34, 223);
            gbResetPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbResetPassword.Name = "gbResetPassword";
            gbResetPassword.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            gbResetPassword.Size = new System.Drawing.Size(554, 158);
            gbResetPassword.TabIndex = 1;
            gbResetPassword.TabStop = false;
            gbResetPassword.Text = "Password info";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(186, 95);
            txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new System.Drawing.Size(330, 23);
            txtConfirmPassword.TabIndex = 8;
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.AutoSize = true;
            lblConfirmNewPassword.Location = new System.Drawing.Point(35, 98);
            lblConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new System.Drawing.Size(134, 15);
            lblConfirmNewPassword.TabIndex = 7;
            lblConfirmNewPassword.Text = "Confirm New Password:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new System.Drawing.Point(186, 43);
            txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.Size = new System.Drawing.Size(330, 23);
            txtNewPassword.TabIndex = 6;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Location = new System.Drawing.Point(84, 46);
            lblNewPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new System.Drawing.Size(87, 15);
            lblNewPassword.TabIndex = 0;
            lblNewPassword.Text = "New Password:";
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnClose.Image = (System.Drawing.Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnClose.Location = new System.Drawing.Point(380, 388);
            btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(92, 53);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Enabled = false;
            btnResetPassword.FlatAppearance.BorderSize = 0;
            btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnResetPassword.ForeColor = System.Drawing.Color.ForestGreen;
            btnResetPassword.Image = Properties.Resources._7023958_password_account_security_reset_safety_icon;
            btnResetPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnResetPassword.Location = new System.Drawing.Point(496, 388);
            btnResetPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new System.Drawing.Size(100, 53);
            btnResetPassword.TabIndex = 2;
            btnResetPassword.Text = "Reset";
            btnResetPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnResetPassword.UseVisualStyleBackColor = true;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblSendingEmails
            // 
            lblSendingEmails.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            lblSendingEmails.AutoSize = true;
            lblSendingEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblSendingEmails.Location = new System.Drawing.Point(99, 408);
            lblSendingEmails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSendingEmails.Name = "lblSendingEmails";
            lblSendingEmails.Size = new System.Drawing.Size(170, 13);
            lblSendingEmails.TabIndex = 6;
            lblSendingEmails.Text = "SendingVerification Code.....";
            lblSendingEmails.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            pictureBox1.Image = Properties.Resources.image_1229052;
            pictureBox1.Location = new System.Drawing.Point(41, 395);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(51, 39);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(629, 458);
            ControlBox = false;
            Controls.Add(lblSendingEmails);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(btnResetPassword);
            Controls.Add(gbResetPassword);
            Controls.Add(gbVerificationCode);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "frmResetPassword";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Reset Password";
            gbVerificationCode.ResumeLayout(false);
            gbVerificationCode.PerformLayout();
            gbResetPassword.ResumeLayout(false);
            gbResetPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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