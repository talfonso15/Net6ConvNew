
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelMealPerDiemRate = new System.Windows.Forms.LinkLabel();
            this.lblInfoLink = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMealsPerDiemRate = new System.Windows.Forms.Label();
            this.lblTotalPerDiemRateValue = new System.Windows.Forms.Label();
            this.lblBreakfast = new System.Windows.Forms.Label();
            this.lblTotalPerDiemRate = new System.Windows.Forms.Label();
            this.txtMealsPerDiemRate = new System.Windows.Forms.TextBox();
            this.txtDinner = new System.Windows.Forms.TextBox();
            this.lblDinner = new System.Windows.Forms.Label();
            this.lblLunch = new System.Windows.Forms.Label();
            this.txtLunch = new System.Windows.Forms.TextBox();
            this.btnCalculateMeals = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.dtpDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnTime = new System.Windows.Forms.Label();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelUpdateMeals = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMealsTotal = new System.Windows.Forms.Label();
            this.txtMealsTotal = new System.Windows.Forms.TextBox();
            this.dtgMeals = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Breakfast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Lunch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Dinner = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMeals)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabelMealPerDiemRate);
            this.panel1.Controls.Add(this.lblInfoLink);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.btnCalculateMeals);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(20, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 207);
            this.panel1.TabIndex = 34;
            // 
            // linkLabelMealPerDiemRate
            // 
            this.linkLabelMealPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelMealPerDiemRate.AutoSize = true;
            this.linkLabelMealPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelMealPerDiemRate.Location = new System.Drawing.Point(244, 102);
            this.linkLabelMealPerDiemRate.Name = "linkLabelMealPerDiemRate";
            this.linkLabelMealPerDiemRate.Size = new System.Drawing.Size(262, 13);
            this.linkLabelMealPerDiemRate.TabIndex = 19;
            this.linkLabelMealPerDiemRate.TabStop = true;
            this.linkLabelMealPerDiemRate.Text = "https://www.gsa.gov/travel/plan-book/per-diem-rates";
            this.linkLabelMealPerDiemRate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMealPerDiemRate_LinkClicked);
            // 
            // lblInfoLink
            // 
            this.lblInfoLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoLink.AutoSize = true;
            this.lblInfoLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoLink.Location = new System.Drawing.Point(15, 102);
            this.lblInfoLink.Name = "lblInfoLink";
            this.lblInfoLink.Size = new System.Drawing.Size(213, 13);
            this.lblInfoLink.TabIndex = 18;
            this.lblInfoLink.Text = "Link for checking the Meals Per Diem Rate:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.76749F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.86456F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.76749F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.09029F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.28442F));
            this.tableLayoutPanel4.Controls.Add(this.lblMealsPerDiemRate, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblTotalPerDiemRateValue, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblBreakfast, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTotalPerDiemRate, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtMealsPerDiemRate, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtDinner, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblDinner, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblLunch, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtLunch, 2, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(11, 134);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(443, 52);
            this.tableLayoutPanel4.TabIndex = 17;
            // 
            // lblMealsPerDiemRate
            // 
            this.lblMealsPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMealsPerDiemRate.AutoSize = true;
            this.lblMealsPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealsPerDiemRate.Location = new System.Drawing.Point(6, 30);
            this.lblMealsPerDiemRate.Name = "lblMealsPerDiemRate";
            this.lblMealsPerDiemRate.Size = new System.Drawing.Size(82, 13);
            this.lblMealsPerDiemRate.TabIndex = 8;
            this.lblMealsPerDiemRate.Text = "Per Diem Rate:";
            // 
            // lblTotalPerDiemRateValue
            // 
            this.lblTotalPerDiemRateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPerDiemRateValue.AutoSize = true;
            this.lblTotalPerDiemRateValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPerDiemRateValue.Location = new System.Drawing.Point(363, 30);
            this.lblTotalPerDiemRateValue.Name = "lblTotalPerDiemRateValue";
            this.lblTotalPerDiemRateValue.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPerDiemRateValue.TabIndex = 19;
            this.lblTotalPerDiemRateValue.Text = "0";
            this.lblTotalPerDiemRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBreakfast
            // 
            this.lblBreakfast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBreakfast.AutoSize = true;
            this.lblBreakfast.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblBreakfast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakfast.Location = new System.Drawing.Point(97, 5);
            this.lblBreakfast.Name = "lblBreakfast";
            this.lblBreakfast.Size = new System.Drawing.Size(78, 13);
            this.lblBreakfast.TabIndex = 13;
            this.lblBreakfast.Text = "Breakfast";
            this.lblBreakfast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalPerDiemRate
            // 
            this.lblTotalPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPerDiemRate.AutoSize = true;
            this.lblTotalPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPerDiemRate.Location = new System.Drawing.Point(363, 5);
            this.lblTotalPerDiemRate.Name = "lblTotalPerDiemRate";
            this.lblTotalPerDiemRate.Size = new System.Drawing.Size(74, 13);
            this.lblTotalPerDiemRate.TabIndex = 18;
            this.lblTotalPerDiemRate.Text = "Total";
            this.lblTotalPerDiemRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMealsPerDiemRate
            // 
            this.txtMealsPerDiemRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsPerDiemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMealsPerDiemRate.Location = new System.Drawing.Point(97, 27);
            this.txtMealsPerDiemRate.Name = "txtMealsPerDiemRate";
            this.txtMealsPerDiemRate.Size = new System.Drawing.Size(78, 20);
            this.txtMealsPerDiemRate.TabIndex = 9;
            this.txtMealsPerDiemRate.TextChanged += new System.EventHandler(this.txtMealsPerDiemRate_TextChanged);
            // 
            // txtDinner
            // 
            this.txtDinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinner.Location = new System.Drawing.Point(275, 27);
            this.txtDinner.Name = "txtDinner";
            this.txtDinner.Size = new System.Drawing.Size(79, 20);
            this.txtDinner.TabIndex = 16;
            this.txtDinner.TextChanged += new System.EventHandler(this.txtDinner_TextChanged);
            // 
            // lblDinner
            // 
            this.lblDinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDinner.AutoSize = true;
            this.lblDinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinner.Location = new System.Drawing.Point(275, 5);
            this.lblDinner.Name = "lblDinner";
            this.lblDinner.Size = new System.Drawing.Size(79, 13);
            this.lblDinner.TabIndex = 17;
            this.lblDinner.Text = "Dinner";
            this.lblDinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLunch
            // 
            this.lblLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLunch.AutoSize = true;
            this.lblLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLunch.Location = new System.Drawing.Point(184, 5);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(82, 13);
            this.lblLunch.TabIndex = 15;
            this.lblLunch.Text = "Lunch";
            this.lblLunch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLunch
            // 
            this.txtLunch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLunch.Location = new System.Drawing.Point(184, 27);
            this.txtLunch.Name = "txtLunch";
            this.txtLunch.Size = new System.Drawing.Size(82, 20);
            this.txtLunch.TabIndex = 14;
            this.txtLunch.TextChanged += new System.EventHandler(this.txtLunch_TextChanged);
            // 
            // btnCalculateMeals
            // 
            this.btnCalculateMeals.Enabled = false;
            this.btnCalculateMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateMeals.ForeColor = System.Drawing.Color.Green;
            this.btnCalculateMeals.Location = new System.Drawing.Point(460, 160);
            this.btnCalculateMeals.Name = "btnCalculateMeals";
            this.btnCalculateMeals.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateMeals.TabIndex = 16;
            this.btnCalculateMeals.Text = "Calculate";
            this.btnCalculateMeals.UseVisualStyleBackColor = true;
            this.btnCalculateMeals.Click += new System.EventHandler(this.btnCalculateMeals_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.23529F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.56863F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.23529F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.35294F));
            this.tableLayoutPanel2.Controls.Add(this.lblReturnDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDepartureDate, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpDepartureDate, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpReturnTime, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpDepartureTime, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtpReturnDate, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblReturnTime, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDepartureTime, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(510, 69);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Location = new System.Drawing.Point(3, 45);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(86, 13);
            this.lblReturnDate.TabIndex = 15;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Location = new System.Drawing.Point(3, 10);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(86, 13);
            this.lblDepartureDate.TabIndex = 13;
            this.lblDepartureDate.Text = "Departure Date:";
            // 
            // dtpDepartureDate
            // 
            this.dtpDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDepartureDate.Location = new System.Drawing.Point(95, 7);
            this.dtpDepartureDate.Name = "dtpDepartureDate";
            this.dtpDepartureDate.Size = new System.Drawing.Size(154, 20);
            this.dtpDepartureDate.TabIndex = 9;
            // 
            // dtpReturnTime
            // 
            this.dtpReturnTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReturnTime.CustomFormat = "hh:mm tt";
            this.dtpReturnTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnTime.Location = new System.Drawing.Point(347, 41);
            this.dtpReturnTime.Name = "dtpReturnTime";
            this.dtpReturnTime.ShowUpDown = true;
            this.dtpReturnTime.Size = new System.Drawing.Size(160, 20);
            this.dtpReturnTime.TabIndex = 10;
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDepartureTime.CustomFormat = "hh:mm tt";
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureTime.Location = new System.Drawing.Point(347, 7);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.ShowUpDown = true;
            this.dtpDepartureTime.Size = new System.Drawing.Size(160, 20);
            this.dtpDepartureTime.TabIndex = 8;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(95, 41);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(154, 20);
            this.dtpReturnDate.TabIndex = 11;
            // 
            // lblReturnTime
            // 
            this.lblReturnTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReturnTime.AutoSize = true;
            this.lblReturnTime.Location = new System.Drawing.Point(255, 45);
            this.lblReturnTime.Name = "lblReturnTime";
            this.lblReturnTime.Size = new System.Drawing.Size(86, 13);
            this.lblReturnTime.TabIndex = 14;
            this.lblReturnTime.Text = "Return Time:";
            this.lblReturnTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Location = new System.Drawing.Point(255, 10);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(86, 13);
            this.lblDepartureTime.TabIndex = 12;
            this.lblDepartureTime.Text = "Departure Time:";
            this.lblDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnCancelUpdateMeals, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(466, 771);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(97, 54);
            this.tableLayoutPanel3.TabIndex = 35;
            // 
            // btnCancelUpdateMeals
            // 
            this.btnCancelUpdateMeals.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelUpdateMeals.FlatAppearance.BorderSize = 0;
            this.btnCancelUpdateMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelUpdateMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUpdateMeals.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCancelUpdateMeals.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelUpdateMeals.Location = new System.Drawing.Point(6, 6);
            this.btnCancelUpdateMeals.Name = "btnCancelUpdateMeals";
            this.btnCancelUpdateMeals.Size = new System.Drawing.Size(84, 42);
            this.btnCancelUpdateMeals.TabIndex = 1;
            this.btnCancelUpdateMeals.Text = "Close";
            this.btnCancelUpdateMeals.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelUpdateMeals.UseVisualStyleBackColor = true;
            this.btnCancelUpdateMeals.Click += new System.EventHandler(this.btnCancelUpdateMeals_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.68852F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.31148F));
            this.tableLayoutPanel1.Controls.Add(this.lblMealsTotal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtMealsTotal, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 708);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 40);
            this.tableLayoutPanel1.TabIndex = 37;
            // 
            // lblMealsTotal
            // 
            this.lblMealsTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMealsTotal.AutoSize = true;
            this.lblMealsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMealsTotal.Location = new System.Drawing.Point(374, 10);
            this.lblMealsTotal.Name = "lblMealsTotal";
            this.lblMealsTotal.Size = new System.Drawing.Size(54, 20);
            this.lblMealsTotal.TabIndex = 6;
            this.lblMealsTotal.Text = "Total:";
            // 
            // txtMealsTotal
            // 
            this.txtMealsTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMealsTotal.Location = new System.Drawing.Point(434, 10);
            this.txtMealsTotal.Name = "txtMealsTotal";
            this.txtMealsTotal.ReadOnly = true;
            this.txtMealsTotal.Size = new System.Drawing.Size(112, 20);
            this.txtMealsTotal.TabIndex = 7;
            // 
            // dtgMeals
            // 
            this.dtgMeals.AllowUserToAddRows = false;
            this.dtgMeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Breakfast,
            this.Lunch,
            this.Dinner,
            this.Total});
            this.dtgMeals.Location = new System.Drawing.Point(17, 276);
            this.dtgMeals.Name = "dtgMeals";
            this.dtgMeals.RowHeadersWidth = 62;
            this.dtgMeals.Size = new System.Drawing.Size(549, 401);
            this.dtgMeals.TabIndex = 36;
            this.dtgMeals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMeals_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // Breakfast
            // 
            this.Breakfast.HeaderText = "Breakfast";
            this.Breakfast.MinimumWidth = 8;
            this.Breakfast.Name = "Breakfast";
            this.Breakfast.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Breakfast.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Breakfast.Width = 150;
            // 
            // Lunch
            // 
            this.Lunch.HeaderText = "Lunch";
            this.Lunch.MinimumWidth = 8;
            this.Lunch.Name = "Lunch";
            this.Lunch.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Lunch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Lunch.Width = 150;
            // 
            // Dinner
            // 
            this.Dinner.HeaderText = "Dinner";
            this.Dinner.MinimumWidth = 8;
            this.Dinner.Name = "Dinner";
            this.Dinner.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Dinner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Dinner.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 8;
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // CalculatePerDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 841);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dtgMeals);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.panel1);
            this.Name = "CalculatePerDiem";
            this.ShowIcon = false;
            this.Text = "Calculate Per Diem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMeals)).EndInit();
            this.ResumeLayout(false);

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