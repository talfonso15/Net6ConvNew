namespace TravelExpenses
{
    partial class LodgingSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbLodgings = new System.Windows.Forms.ComboBox();
            this.btnLodgingID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Lodging that you wants to update the notes:";
            // 
            // cbLodgings
            // 
            this.cbLodgings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLodgings.FormattingEnabled = true;
            this.cbLodgings.Location = new System.Drawing.Point(45, 60);
            this.cbLodgings.Name = "cbLodgings";
            this.cbLodgings.Size = new System.Drawing.Size(420, 21);
            this.cbLodgings.TabIndex = 1;
            // 
            // btnLodgingID
            // 
            this.btnLodgingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLodgingID.ForeColor = System.Drawing.Color.Green;
            this.btnLodgingID.Location = new System.Drawing.Point(420, 109);
            this.btnLodgingID.Name = "btnLodgingID";
            this.btnLodgingID.Size = new System.Drawing.Size(45, 23);
            this.btnLodgingID.TabIndex = 2;
            this.btnLodgingID.Text = "OK";
            this.btnLodgingID.UseVisualStyleBackColor = true;
            this.btnLodgingID.Click += new System.EventHandler(this.btnLodgingID_Click);
            // 
            // LodgingSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 144);
            this.ControlBox = false;
            this.Controls.Add(this.btnLodgingID);
            this.Controls.Add(this.cbLodgings);
            this.Controls.Add(this.label1);
            this.Name = "LodgingSelection";
            this.ShowIcon = false;
            this.Text = "Lodgings";
            this.Load += new System.EventHandler(this.LodgingSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLodgings;
        private System.Windows.Forms.Button btnLodgingID;
    }
}