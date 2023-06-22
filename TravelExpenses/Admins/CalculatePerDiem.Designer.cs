
namespace TravelExpenses
{
    partial class CalculatePerDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatePerDiem));
            panel1 = new System.Windows.Forms.Panel();
            linkLabelMealPerDiemRate = new System.Windows.Forms.LinkLabel();
            lblInfoLink = new System.Windows.Forms.Label();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            lblMealsPerDiemRate = new System.Windows.Forms.Label();
            lblTotalPerDiemRateValue = new System.Windows.Forms.Label();
            lblBreakfast = new System.Windows.Forms.Label();
            lblTotalPerDiemRate = new System.Windows.Forms.Label();
            txtMealsPerDiemRate = new System.Windows.Forms.TextBox();
            txtDinner = new System.Windows.Forms.TextBox();
            lblDinner = new System.Windows.Forms.Label();
            lblLunch = new System.Windows.Forms.Label();
            txtLunch = new System.Windows.Forms.TextBox();
            btnCalculateMeals = new System.Windows.Forms.Button();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lblReturnDate = new System.Windows.Forms.Label();
            lblDepartureDate = new System.Windows.Forms.Label();
            dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            dtpReturnTime = new System.Windows.Forms.DateTimePicker();
            dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            lblReturnTime = new System.Windows.Forms.Label();
            lblDepartureTime = new System.Windows.Forms.Label();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            btnCancelUpdateMeals = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblMealsTotal = new System.Windows.Forms.Label();
            txtMealsTotal = new System.Windows.Forms.TextBox();
            dtgMeals = new System.Windows.Forms.DataGridView();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Breakfast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Lunch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Dinner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMeals).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(linkLabelMealPerDiemRate);
            panel1.Controls.Add(lblInfoLink);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(btnCalculateMeals);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Location = new System.Drawing.Point(23, 29);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(633, 239);
            panel1.TabIndex = 34;
            // 
            // linkLabelMealPerDiemRate
            // 
            linkLabelMealPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            linkLabelMealPerDiemRate.AutoSize = true;
            linkLabelMealPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            linkLabelMealPerDiemRate.Location = new System.Drawing.Point(285, 118);
            linkLabelMealPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            linkLabelMealPerDiemRate.Name = "linkLabelMealPerDiemRate";
            linkLabelMealPerDiemRate.Size = new System.Drawing.Size(262, 13);
            linkLabelMealPerDiemRate.TabIndex = 19;
            linkLabelMealPerDiemRate.TabStop = true;
            linkLabelMealPerDiemRate.Text = "https://www.gsa.gov/travel/plan-book/per-diem-rates";
            linkLabelMealPerDiemRate.LinkClicked += linkLabelMealPerDiemRate_LinkClicked;
            // 
            // lblInfoLink
            // 
            lblInfoLink.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblInfoLink.AutoSize = true;
            lblInfoLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblInfoLink.Location = new System.Drawing.Point(18, 118);
            lblInfoLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblInfoLink.Name = "lblInfoLink";
            lblInfoLink.Size = new System.Drawing.Size(213, 13);
            lblInfoLink.TabIndex = 18;
            lblInfoLink.Text = "Link for checking the Meals Per Diem Rate:";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            tableLayoutPanel4.ColumnCount = 5;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.76749F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.86456F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.76749F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.09029F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.28442F));
            tableLayoutPanel4.Controls.Add(lblMealsPerDiemRate, 0, 1);
            tableLayoutPanel4.Controls.Add(lblTotalPerDiemRateValue, 4, 1);
            tableLayoutPanel4.Controls.Add(lblBreakfast, 1, 0);
            tableLayoutPanel4.Controls.Add(lblTotalPerDiemRate, 4, 0);
            tableLayoutPanel4.Controls.Add(txtMealsPerDiemRate, 1, 1);
            tableLayoutPanel4.Controls.Add(txtDinner, 3, 1);
            tableLayoutPanel4.Controls.Add(lblDinner, 3, 0);
            tableLayoutPanel4.Controls.Add(lblLunch, 2, 0);
            tableLayoutPanel4.Controls.Add(txtLunch, 2, 1);
            tableLayoutPanel4.Location = new System.Drawing.Point(13, 155);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            tableLayoutPanel4.Size = new System.Drawing.Size(517, 60);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // lblMealsPerDiemRate
            // 
            lblMealsPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMealsPerDiemRate.AutoSize = true;
            lblMealsPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMealsPerDiemRate.Location = new System.Drawing.Point(7, 35);
            lblMealsPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMealsPerDiemRate.Name = "lblMealsPerDiemRate";
            lblMealsPerDiemRate.Size = new System.Drawing.Size(95, 13);
            lblMealsPerDiemRate.TabIndex = 8;
            lblMealsPerDiemRate.Text = "Per Diem Rate:";
            // 
            // lblTotalPerDiemRateValue
            // 
            lblTotalPerDiemRateValue.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTotalPerDiemRateValue.AutoSize = true;
            lblTotalPerDiemRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTotalPerDiemRateValue.Location = new System.Drawing.Point(424, 35);
            lblTotalPerDiemRateValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotalPerDiemRateValue.Name = "lblTotalPerDiemRateValue";
            lblTotalPerDiemRateValue.Size = new System.Drawing.Size(86, 13);
            lblTotalPerDiemRateValue.TabIndex = 19;
            lblTotalPerDiemRateValue.Text = "0";
            lblTotalPerDiemRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreakfast
            // 
            lblBreakfast.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblBreakfast.AutoSize = true;
            lblBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            lblBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblBreakfast.Location = new System.Drawing.Point(113, 7);
            lblBreakfast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBreakfast.Name = "lblBreakfast";
            lblBreakfast.Size = new System.Drawing.Size(91, 13);
            lblBreakfast.TabIndex = 13;
            lblBreakfast.Text = "Breakfast";
            lblBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPerDiemRate
            // 
            lblTotalPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTotalPerDiemRate.AutoSize = true;
            lblTotalPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTotalPerDiemRate.Location = new System.Drawing.Point(424, 7);
            lblTotalPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotalPerDiemRate.Name = "lblTotalPerDiemRate";
            lblTotalPerDiemRate.Size = new System.Drawing.Size(86, 13);
            lblTotalPerDiemRate.TabIndex = 18;
            lblTotalPerDiemRate.Text = "Total";
            lblTotalPerDiemRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMealsPerDiemRate
            // 
            txtMealsPerDiemRate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMealsPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtMealsPerDiemRate.Location = new System.Drawing.Point(113, 32);
            txtMealsPerDiemRate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMealsPerDiemRate.Name = "txtMealsPerDiemRate";
            txtMealsPerDiemRate.Size = new System.Drawing.Size(91, 20);
            txtMealsPerDiemRate.TabIndex = 9;
            txtMealsPerDiemRate.TextChanged += txtMealsPerDiemRate_TextChanged;
            // 
            // txtDinner
            // 
            txtDinner.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDinner.Location = new System.Drawing.Point(321, 32);
            txtDinner.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDinner.Name = "txtDinner";
            txtDinner.Size = new System.Drawing.Size(92, 20);
            txtDinner.TabIndex = 16;
            txtDinner.TextChanged += txtDinner_TextChanged;
            // 
            // lblDinner
            // 
            lblDinner.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDinner.AutoSize = true;
            lblDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDinner.Location = new System.Drawing.Point(321, 7);
            lblDinner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDinner.Name = "lblDinner";
            lblDinner.Size = new System.Drawing.Size(92, 13);
            lblDinner.TabIndex = 17;
            lblDinner.Text = "Dinner";
            lblDinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLunch
            // 
            lblLunch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblLunch.AutoSize = true;
            lblLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblLunch.Location = new System.Drawing.Point(215, 7);
            lblLunch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLunch.Name = "lblLunch";
            lblLunch.Size = new System.Drawing.Size(95, 13);
            lblLunch.TabIndex = 15;
            lblLunch.Text = "Lunch";
            lblLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLunch
            // 
            txtLunch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtLunch.Location = new System.Drawing.Point(215, 32);
            txtLunch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtLunch.Name = "txtLunch";
            txtLunch.Size = new System.Drawing.Size(95, 20);
            txtLunch.TabIndex = 14;
            txtLunch.TextChanged += txtLunch_TextChanged;
            // 
            // btnCalculateMeals
            // 
            btnCalculateMeals.Enabled = false;
            btnCalculateMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCalculateMeals.ForeColor = System.Drawing.Color.Green;
            btnCalculateMeals.Location = new System.Drawing.Point(537, 185);
            btnCalculateMeals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCalculateMeals.Name = "btnCalculateMeals";
            btnCalculateMeals.Size = new System.Drawing.Size(88, 27);
            btnCalculateMeals.TabIndex = 16;
            btnCalculateMeals.Text = "Calculate";
            btnCalculateMeals.UseVisualStyleBackColor = true;
            btnCalculateMeals.Click += btnCalculateMeals_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.23529F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.56863F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.23529F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.35294F));
            tableLayoutPanel2.Controls.Add(lblReturnDate, 0, 1);
            tableLayoutPanel2.Controls.Add(lblDepartureDate, 0, 0);
            tableLayoutPanel2.Controls.Add(dtpDepartureDate, 1, 0);
            tableLayoutPanel2.Controls.Add(dtpReturnTime, 3, 1);
            tableLayoutPanel2.Controls.Add(dtpDepartureTime, 3, 0);
            tableLayoutPanel2.Controls.Add(dtpReturnDate, 1, 1);
            tableLayoutPanel2.Controls.Add(lblReturnTime, 2, 1);
            tableLayoutPanel2.Controls.Add(lblDepartureTime, 2, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(13, 15);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(595, 80);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // lblReturnDate
            // 
            lblReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblReturnDate.AutoSize = true;
            lblReturnDate.Location = new System.Drawing.Point(4, 52);
            lblReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new System.Drawing.Size(100, 15);
            lblReturnDate.TabIndex = 15;
            lblReturnDate.Text = "Return Date:";
            // 
            // lblDepartureDate
            // 
            lblDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDepartureDate.AutoSize = true;
            lblDepartureDate.Location = new System.Drawing.Point(4, 12);
            lblDepartureDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDepartureDate.Name = "lblDepartureDate";
            lblDepartureDate.Size = new System.Drawing.Size(100, 15);
            lblDepartureDate.TabIndex = 13;
            lblDepartureDate.Text = "Departure Date:";
            // 
            // dtpDepartureDate
            // 
            dtpDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDepartureDate.Location = new System.Drawing.Point(112, 8);
            dtpDepartureDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpDepartureDate.Name = "dtpDepartureDate";
            dtpDepartureDate.Size = new System.Drawing.Size(179, 23);
            dtpDepartureDate.TabIndex = 9;
            // 
            // dtpReturnTime
            // 
            dtpReturnTime.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpReturnTime.CustomFormat = "hh:mm tt";
            dtpReturnTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpReturnTime.Location = new System.Drawing.Point(407, 48);
            dtpReturnTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpReturnTime.Name = "dtpReturnTime";
            dtpReturnTime.ShowUpDown = true;
            dtpReturnTime.Size = new System.Drawing.Size(184, 23);
            dtpReturnTime.TabIndex = 10;
            // 
            // dtpDepartureTime
            // 
            dtpDepartureTime.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpDepartureTime.CustomFormat = "hh:mm tt";
            dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDepartureTime.Location = new System.Drawing.Point(407, 8);
            dtpDepartureTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpDepartureTime.Name = "dtpDepartureTime";
            dtpDepartureTime.ShowUpDown = true;
            dtpDepartureTime.Size = new System.Drawing.Size(184, 23);
            dtpDepartureTime.TabIndex = 8;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpReturnDate.Location = new System.Drawing.Point(112, 48);
            dtpReturnDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new System.Drawing.Size(179, 23);
            dtpReturnDate.TabIndex = 11;
            // 
            // lblReturnTime
            // 
            lblReturnTime.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblReturnTime.AutoSize = true;
            lblReturnTime.Location = new System.Drawing.Point(299, 52);
            lblReturnTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReturnTime.Name = "lblReturnTime";
            lblReturnTime.Size = new System.Drawing.Size(100, 15);
            lblReturnTime.TabIndex = 14;
            lblReturnTime.Text = "Return Time:";
            lblReturnTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepartureTime
            // 
            lblDepartureTime.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDepartureTime.AutoSize = true;
            lblDepartureTime.Location = new System.Drawing.Point(299, 12);
            lblDepartureTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDepartureTime.Name = "lblDepartureTime";
            lblDepartureTime.Size = new System.Drawing.Size(100, 15);
            lblDepartureTime.TabIndex = 12;
            lblDepartureTime.Text = "Departure Time:";
            lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            tableLayoutPanel3.Controls.Add(btnCancelUpdateMeals, 0, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(544, 890);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new System.Drawing.Size(113, 62);
            tableLayoutPanel3.TabIndex = 35;
            // 
            // btnCancelUpdateMeals
            // 
            btnCancelUpdateMeals.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelUpdateMeals.FlatAppearance.BorderSize = 0;
            btnCancelUpdateMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelUpdateMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelUpdateMeals.Image = (System.Drawing.Image)resources.GetObject("btnCancelUpdateMeals.Image");
            btnCancelUpdateMeals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelUpdateMeals.Location = new System.Drawing.Point(7, 7);
            btnCancelUpdateMeals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelUpdateMeals.Name = "btnCancelUpdateMeals";
            btnCancelUpdateMeals.Size = new System.Drawing.Size(98, 48);
            btnCancelUpdateMeals.TabIndex = 1;
            btnCancelUpdateMeals.Text = "Close";
            btnCancelUpdateMeals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelUpdateMeals.UseVisualStyleBackColor = true;
            btnCancelUpdateMeals.Click += btnCancelUpdateMeals_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.68852F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.31148F));
            tableLayoutPanel1.Controls.Add(lblMealsTotal, 0, 0);
            tableLayoutPanel1.Controls.Add(txtMealsTotal, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(20, 817);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(640, 46);
            tableLayoutPanel1.TabIndex = 37;
            // 
            // lblMealsTotal
            // 
            lblMealsTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            lblMealsTotal.AutoSize = true;
            lblMealsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMealsTotal.Location = new System.Drawing.Point(445, 13);
            lblMealsTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMealsTotal.Name = "lblMealsTotal";
            lblMealsTotal.Size = new System.Drawing.Size(54, 20);
            lblMealsTotal.TabIndex = 6;
            lblMealsTotal.Text = "Total:";
            // 
            // txtMealsTotal
            // 
            txtMealsTotal.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtMealsTotal.Location = new System.Drawing.Point(507, 11);
            txtMealsTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtMealsTotal.Name = "txtMealsTotal";
            txtMealsTotal.ReadOnly = true;
            txtMealsTotal.Size = new System.Drawing.Size(129, 23);
            txtMealsTotal.TabIndex = 7;
            // 
            // dtgMeals
            // 
            dtgMeals.AllowUserToAddRows = false;
            dtgMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Date, Breakfast, Lunch, Dinner, Total });
            dtgMeals.Location = new System.Drawing.Point(20, 318);
            dtgMeals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtgMeals.Name = "dtgMeals";
            dtgMeals.RowHeadersWidth = 62;
            dtgMeals.Size = new System.Drawing.Size(640, 463);
            dtgMeals.TabIndex = 36;
            dtgMeals.CellContentClick += dtgMeals_CellContentClick;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 8;
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.Width = 150;
            // 
            // Breakfast
            // 
            Breakfast.HeaderText = "Breakfast";
            Breakfast.MinimumWidth = 8;
            Breakfast.Name = "Breakfast";
            Breakfast.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Breakfast.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Breakfast.Width = 150;
            // 
            // Lunch
            // 
            Lunch.HeaderText = "Lunch";
            Lunch.MinimumWidth = 8;
            Lunch.Name = "Lunch";
            Lunch.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Lunch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Lunch.Width = 150;
            // 
            // Dinner
            // 
            Dinner.HeaderText = "Dinner";
            Dinner.MinimumWidth = 8;
            Dinner.Name = "Dinner";
            Dinner.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Dinner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Dinner.Width = 150;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 8;
            Total.Name = "Total";
            Total.Width = 150;
            // 
            // CalculatePerDiem
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(680, 970);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dtgMeals);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CalculatePerDiem";
            ShowIcon = false;
            Text = "Calculate Per Diem";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMeals).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCancelUpdateMeals;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.DateTimePicker dtpDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpReturnTime;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblReturnTime;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblMealsPerDiemRate;
        private System.Windows.Forms.Label lblTotalPerDiemRateValue;
        private System.Windows.Forms.Label lblBreakfast;
        private System.Windows.Forms.Label lblTotalPerDiemRate;
        private System.Windows.Forms.TextBox txtMealsPerDiemRate;
        private System.Windows.Forms.TextBox txtDinner;
        private System.Windows.Forms.Label lblDinner;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.TextBox txtLunch;
        private System.Windows.Forms.Button btnCalculateMeals;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMealsTotal;
        private System.Windows.Forms.TextBox txtMealsTotal;
        private System.Windows.Forms.DataGridView dtgMeals;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Breakfast;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Lunch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dinner;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label lblInfoLink;
        private System.Windows.Forms.LinkLabel linkLabelMealPerDiemRate;
    }
}