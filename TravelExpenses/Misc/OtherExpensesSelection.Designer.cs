namespace TravelExpenses
{
    partial class OtherExpensesSelection
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
            this.cbOtherExpenses = new System.Windows.Forms.ComboBox();
            this.btnOtherExpId = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Other Expense that you wants to update the notes:";
            // 
            // cbOtherExpenses
            // 
            this.cbOtherExpenses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOtherExpenses.FormattingEnabled = true;
            this.cbOtherExpenses.Location = new System.Drawing.Point(32, 70);
            this.cbOtherExpenses.Name = "cbOtherExpenses";
            this.cbOtherExpenses.Size = new System.Drawing.Size(377, 21);
            this.cbOtherExpenses.TabIndex = 1;
            // 
            // btnOtherExpId
            // 
            this.btnOtherExpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherExpId.ForeColor = System.Drawing.Color.Green;
            this.btnOtherExpId.Location = new System.Drawing.Point(369, 109);
            this.btnOtherExpId.Name = "btnOtherExpId";
            this.btnOtherExpId.Size = new System.Drawing.Size(40, 23);
            this.btnOtherExpId.TabIndex = 2;
            this.btnOtherExpId.Text = "OK";
            this.btnOtherExpId.UseVisualStyleBackColor = true;
            this.btnOtherExpId.Click += new System.EventHandler(this.btnOtherExpId_Click);
            // 
            // OtherExpensesSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 144);
            this.ControlBox = false;
            this.Controls.Add(this.btnOtherExpId);
            this.Controls.Add(this.cbOtherExpenses);
            this.Controls.Add(this.label1);
            this.Name = "OtherExpensesSelection";
            this.ShowIcon = false;
            this.Text = "Other Expenses";
            this.Load += new System.EventHandler(this.OtherExpensesSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbOtherExpenses;
        private System.Windows.Forms.Button btnOtherExpId;
    }
}