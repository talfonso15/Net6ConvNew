namespace TravelExpenses
{
    partial class CarRentalSelection
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
            this.cbCarRentals = new System.Windows.Forms.ComboBox();
            this.lblCarRentals = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCarRentals
            // 
            this.cbCarRentals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarRentals.FormattingEnabled = true;
            this.cbCarRentals.Location = new System.Drawing.Point(35, 51);
            this.cbCarRentals.Name = "cbCarRentals";
            this.cbCarRentals.Size = new System.Drawing.Size(412, 21);
            this.cbCarRentals.TabIndex = 0;
            // 
            // lblCarRentals
            // 
            this.lblCarRentals.AutoSize = true;
            this.lblCarRentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarRentals.Location = new System.Drawing.Point(74, 24);
            this.lblCarRentals.Name = "lblCarRentals";
            this.lblCarRentals.Size = new System.Drawing.Size(335, 13);
            this.lblCarRentals.TabIndex = 1;
            this.lblCarRentals.Text = "Select the Car Rental that you wants to update the notes:";
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Green;
            this.btnOK.Location = new System.Drawing.Point(404, 86);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(45, 23);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CarRentalSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 119);
            this.ControlBox = false;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblCarRentals);
            this.Controls.Add(this.cbCarRentals);
            this.Name = "CarRentalSelection";
            this.ShowIcon = false;
            this.Text = "Car Rentals";
            this.Load += new System.EventHandler(this.CarRentalSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCarRentals;
        private System.Windows.Forms.Label lblCarRentals;
        private System.Windows.Forms.Button btnOK;
    }
}