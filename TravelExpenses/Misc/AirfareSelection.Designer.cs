namespace TravelExpenses
{
    partial class AirfareSelection
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
            this.lblairfareselection = new System.Windows.Forms.Label();
            this.cbAirdareSelection = new System.Windows.Forms.ComboBox();
            this.btnSaveAirfareID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblairfareselection
            // 
            this.lblairfareselection.AutoSize = true;
            this.lblairfareselection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblairfareselection.Location = new System.Drawing.Point(63, 36);
            this.lblairfareselection.Name = "lblairfareselection";
            this.lblairfareselection.Size = new System.Drawing.Size(312, 13);
            this.lblairfareselection.TabIndex = 0;
            this.lblairfareselection.Text = "Select the Airfare that you wants to update the notes:";
            // 
            // cbAirdareSelection
            // 
            this.cbAirdareSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAirdareSelection.FormattingEnabled = true;
            this.cbAirdareSelection.Location = new System.Drawing.Point(36, 66);
            this.cbAirdareSelection.Name = "cbAirdareSelection";
            this.cbAirdareSelection.Size = new System.Drawing.Size(377, 21);
            this.cbAirdareSelection.TabIndex = 1;
            // 
            // btnSaveAirfareID
            // 
            this.btnSaveAirfareID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAirfareID.ForeColor = System.Drawing.Color.Green;
            this.btnSaveAirfareID.Location = new System.Drawing.Point(371, 115);
            this.btnSaveAirfareID.Name = "btnSaveAirfareID";
            this.btnSaveAirfareID.Size = new System.Drawing.Size(42, 23);
            this.btnSaveAirfareID.TabIndex = 2;
            this.btnSaveAirfareID.Text = "OK";
            this.btnSaveAirfareID.UseVisualStyleBackColor = true;
            this.btnSaveAirfareID.Click += new System.EventHandler(this.btnSaveAirfareID_Click);
            // 
            // AirfareSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 149);
            this.ControlBox = false;
            this.Controls.Add(this.btnSaveAirfareID);
            this.Controls.Add(this.cbAirdareSelection);
            this.Controls.Add(this.lblairfareselection);
            this.Name = "AirfareSelection";
            this.ShowIcon = false;
            this.Text = "Airfares";
            this.Load += new System.EventHandler(this.AirfareSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblairfareselection;
        private System.Windows.Forms.ComboBox cbAirdareSelection;
        private System.Windows.Forms.Button btnSaveAirfareID;
    }
}