namespace TravelExpenses
{
    partial class AirFare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirFare));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            lblAirFareHeader = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            button1 = new System.Windows.Forms.Button();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblFlightCost = new System.Windows.Forms.Label();
            txtFlightCost = new System.Windows.Forms.TextBox();
            lblFlightReturnDate = new System.Windows.Forms.Label();
            dtpFlightReturnDate = new System.Windows.Forms.DateTimePicker();
            lblFlightDepartureDate = new System.Windows.Forms.Label();
            dtpFlightDepartureDate = new System.Windows.Forms.DateTimePicker();
            lblRoundTrip = new System.Windows.Forms.Label();
            panel5 = new System.Windows.Forms.Panel();
            rbNoRoundTrip = new System.Windows.Forms.RadioButton();
            rbYesRoundTrip = new System.Windows.Forms.RadioButton();
            lblFlightNotes = new System.Windows.Forms.Label();
            txtFlightNotes = new System.Windows.Forms.TextBox();
            panel2 = new System.Windows.Forms.Panel();
            rbNodistrictPayFlight = new System.Windows.Forms.RadioButton();
            rbYesDistrictPayFlight = new System.Windows.Forms.RadioButton();
            lblDistrictPayFlight = new System.Windows.Forms.Label();
            txtFlightTotal = new System.Windows.Forms.TextBox();
            lblTotal = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            txtPersonalAmountFlight = new System.Windows.Forms.TextBox();
            lblPersonalUseAmountFlight = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            rbNoPersonalUseFlight = new System.Windows.Forms.RadioButton();
            rbYesPersonalUseFlight = new System.Windows.Forms.RadioButton();
            lblPesonalUse = new System.Windows.Forms.Label();
            lblTaxesAndFees = new System.Windows.Forms.Label();
            txtFlightTaxesAndFees = new System.Windows.Forms.TextBox();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            btnAddFlight = new System.Windows.Forms.Button();
            dgvFlight = new System.Windows.Forms.DataGridView();
            DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FlightCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DistrictPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            PersonalUse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            PersonalUseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Delete = new System.Windows.Forms.DataGridViewImageColumn();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            btnNextFlight = new System.Windows.Forms.Button();
            btnBackFlight = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            lblFlightList = new System.Windows.Forms.Label();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            btnCancelFlight = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlight).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblAirFareHeader
            // 
            lblAirFareHeader.AutoSize = true;
            lblAirFareHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblAirFareHeader.Location = new System.Drawing.Point(47, 33);
            lblAirFareHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAirFareHeader.Name = "lblAirFareHeader";
            lblAirFareHeader.Size = new System.Drawing.Size(164, 20);
            lblAirFareHeader.TabIndex = 0;
            lblAirFareHeader.Text = "Enter Flight Details";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtFlightTotal);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(lblTaxesAndFees);
            panel1.Controls.Add(txtFlightTaxesAndFees);
            panel1.Location = new System.Drawing.Point(51, 60);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(640, 513);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.SteelBlue;
            button1.Image = Properties.Resources.if_information_14516;
            button1.Location = new System.Drawing.Point(268, 6);
            button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(30, 35);
            button1.TabIndex = 6;
            toolTip1.SetToolTip(button1, resources.GetString("button1.ToolTip"));
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.40096F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.59904F));
            tableLayoutPanel1.Controls.Add(lblFlightCost, 0, 3);
            tableLayoutPanel1.Controls.Add(txtFlightCost, 1, 3);
            tableLayoutPanel1.Controls.Add(lblFlightReturnDate, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpFlightReturnDate, 1, 2);
            tableLayoutPanel1.Controls.Add(lblFlightDepartureDate, 0, 1);
            tableLayoutPanel1.Controls.Add(dtpFlightDepartureDate, 1, 1);
            tableLayoutPanel1.Controls.Add(lblRoundTrip, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Controls.Add(lblFlightNotes, 0, 4);
            tableLayoutPanel1.Controls.Add(txtFlightNotes, 1, 4);
            tableLayoutPanel1.Location = new System.Drawing.Point(35, 43);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.43478F));
            tableLayoutPanel1.Size = new System.Drawing.Size(558, 243);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFlightCost
            // 
            lblFlightCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFlightCost.AutoSize = true;
            lblFlightCost.Location = new System.Drawing.Point(5, 140);
            lblFlightCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFlightCost.Name = "lblFlightCost";
            lblFlightCost.Size = new System.Drawing.Size(149, 15);
            lblFlightCost.TabIndex = 4;
            lblFlightCost.Text = "Flight Cost:";
            // 
            // txtFlightCost
            // 
            txtFlightCost.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFlightCost.Location = new System.Drawing.Point(163, 136);
            txtFlightCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFlightCost.Name = "txtFlightCost";
            txtFlightCost.Size = new System.Drawing.Size(390, 23);
            txtFlightCost.TabIndex = 5;
            txtFlightCost.KeyPress += txtFlightCost_KeyPress;
            txtFlightCost.KeyUp += txtFlightCost_KeyUp;
            // 
            // lblFlightReturnDate
            // 
            lblFlightReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFlightReturnDate.AutoSize = true;
            lblFlightReturnDate.Location = new System.Drawing.Point(5, 98);
            lblFlightReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFlightReturnDate.Name = "lblFlightReturnDate";
            lblFlightReturnDate.Size = new System.Drawing.Size(149, 15);
            lblFlightReturnDate.TabIndex = 1;
            lblFlightReturnDate.Text = "Return Date:";
            // 
            // dtpFlightReturnDate
            // 
            dtpFlightReturnDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpFlightReturnDate.Enabled = false;
            dtpFlightReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFlightReturnDate.Location = new System.Drawing.Point(163, 94);
            dtpFlightReturnDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpFlightReturnDate.Name = "dtpFlightReturnDate";
            dtpFlightReturnDate.Size = new System.Drawing.Size(390, 23);
            dtpFlightReturnDate.TabIndex = 3;
            // 
            // lblFlightDepartureDate
            // 
            lblFlightDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFlightDepartureDate.AutoSize = true;
            lblFlightDepartureDate.Location = new System.Drawing.Point(5, 56);
            lblFlightDepartureDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFlightDepartureDate.Name = "lblFlightDepartureDate";
            lblFlightDepartureDate.Size = new System.Drawing.Size(149, 15);
            lblFlightDepartureDate.TabIndex = 0;
            lblFlightDepartureDate.Text = "Departure Date:";
            // 
            // dtpFlightDepartureDate
            // 
            dtpFlightDepartureDate.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dtpFlightDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpFlightDepartureDate.Location = new System.Drawing.Point(163, 52);
            dtpFlightDepartureDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dtpFlightDepartureDate.Name = "dtpFlightDepartureDate";
            dtpFlightDepartureDate.Size = new System.Drawing.Size(390, 23);
            dtpFlightDepartureDate.TabIndex = 2;
            dtpFlightDepartureDate.ValueChanged += dtpFlightDepartureDate_ValueChanged;
            // 
            // lblRoundTrip
            // 
            lblRoundTrip.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblRoundTrip.AutoSize = true;
            lblRoundTrip.Location = new System.Drawing.Point(5, 14);
            lblRoundTrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRoundTrip.Name = "lblRoundTrip";
            lblRoundTrip.Size = new System.Drawing.Size(149, 15);
            lblRoundTrip.TabIndex = 10;
            lblRoundTrip.Text = "Round Trip:";
            // 
            // panel5
            // 
            panel5.Controls.Add(rbNoRoundTrip);
            panel5.Controls.Add(rbYesRoundTrip);
            panel5.Location = new System.Drawing.Point(163, 4);
            panel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(214, 33);
            panel5.TabIndex = 11;
            // 
            // rbNoRoundTrip
            // 
            rbNoRoundTrip.AutoSize = true;
            rbNoRoundTrip.Checked = true;
            rbNoRoundTrip.Location = new System.Drawing.Point(71, 10);
            rbNoRoundTrip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoRoundTrip.Name = "rbNoRoundTrip";
            rbNoRoundTrip.Size = new System.Drawing.Size(41, 19);
            rbNoRoundTrip.TabIndex = 1;
            rbNoRoundTrip.TabStop = true;
            rbNoRoundTrip.Text = "No";
            rbNoRoundTrip.UseVisualStyleBackColor = true;
            rbNoRoundTrip.CheckedChanged += rbNoRoundTrip_CheckedChanged;
            // 
            // rbYesRoundTrip
            // 
            rbYesRoundTrip.AutoSize = true;
            rbYesRoundTrip.Location = new System.Drawing.Point(4, 10);
            rbYesRoundTrip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesRoundTrip.Name = "rbYesRoundTrip";
            rbYesRoundTrip.Size = new System.Drawing.Size(42, 19);
            rbYesRoundTrip.TabIndex = 0;
            rbYesRoundTrip.Text = "Yes";
            rbYesRoundTrip.UseVisualStyleBackColor = true;
            rbYesRoundTrip.CheckedChanged += rbYesRoundTrip_CheckedChanged;
            // 
            // lblFlightNotes
            // 
            lblFlightNotes.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblFlightNotes.AutoSize = true;
            lblFlightNotes.Location = new System.Drawing.Point(5, 198);
            lblFlightNotes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFlightNotes.Name = "lblFlightNotes";
            lblFlightNotes.Size = new System.Drawing.Size(149, 15);
            lblFlightNotes.TabIndex = 0;
            lblFlightNotes.Text = "Notes:";
            // 
            // txtFlightNotes
            // 
            txtFlightNotes.Location = new System.Drawing.Point(163, 172);
            txtFlightNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFlightNotes.Multiline = true;
            txtFlightNotes.Name = "txtFlightNotes";
            txtFlightNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            txtFlightNotes.Size = new System.Drawing.Size(390, 67);
            txtFlightNotes.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(rbNodistrictPayFlight);
            panel2.Controls.Add(rbYesDistrictPayFlight);
            panel2.Controls.Add(lblDistrictPayFlight);
            panel2.Location = new System.Drawing.Point(35, 314);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(557, 50);
            panel2.TabIndex = 3;
            // 
            // rbNodistrictPayFlight
            // 
            rbNodistrictPayFlight.AutoSize = true;
            rbNodistrictPayFlight.Location = new System.Drawing.Point(500, 15);
            rbNodistrictPayFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNodistrictPayFlight.Name = "rbNodistrictPayFlight";
            rbNodistrictPayFlight.Size = new System.Drawing.Size(41, 19);
            rbNodistrictPayFlight.TabIndex = 2;
            rbNodistrictPayFlight.TabStop = true;
            rbNodistrictPayFlight.Text = "No";
            rbNodistrictPayFlight.UseVisualStyleBackColor = true;
            // 
            // rbYesDistrictPayFlight
            // 
            rbYesDistrictPayFlight.AutoSize = true;
            rbYesDistrictPayFlight.Checked = true;
            rbYesDistrictPayFlight.Location = new System.Drawing.Point(443, 15);
            rbYesDistrictPayFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesDistrictPayFlight.Name = "rbYesDistrictPayFlight";
            rbYesDistrictPayFlight.Size = new System.Drawing.Size(42, 19);
            rbYesDistrictPayFlight.TabIndex = 1;
            rbYesDistrictPayFlight.TabStop = true;
            rbYesDistrictPayFlight.Text = "Yes";
            rbYesDistrictPayFlight.UseVisualStyleBackColor = true;
            // 
            // lblDistrictPayFlight
            // 
            lblDistrictPayFlight.AutoSize = true;
            lblDistrictPayFlight.Location = new System.Drawing.Point(14, 17);
            lblDistrictPayFlight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDistrictPayFlight.Name = "lblDistrictPayFlight";
            lblDistrictPayFlight.Size = new System.Drawing.Size(187, 15);
            lblDistrictPayFlight.TabIndex = 0;
            lblDistrictPayFlight.Text = "Did the district pay for your flight?";
            // 
            // txtFlightTotal
            // 
            txtFlightTotal.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFlightTotal.Location = new System.Drawing.Point(224, 10);
            txtFlightTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFlightTotal.Name = "txtFlightTotal";
            txtFlightTotal.Size = new System.Drawing.Size(37, 23);
            txtFlightTotal.TabIndex = 9;
            txtFlightTotal.Visible = false;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Location = new System.Drawing.Point(177, 16);
            lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new System.Drawing.Size(35, 15);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total:";
            lblTotal.Visible = false;
            // 
            // panel4
            // 
            panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel4.Controls.Add(txtPersonalAmountFlight);
            panel4.Controls.Add(lblPersonalUseAmountFlight);
            panel4.Location = new System.Drawing.Point(35, 425);
            panel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(557, 50);
            panel4.TabIndex = 5;
            // 
            // txtPersonalAmountFlight
            // 
            txtPersonalAmountFlight.Enabled = false;
            txtPersonalAmountFlight.Location = new System.Drawing.Point(430, 13);
            txtPersonalAmountFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPersonalAmountFlight.Name = "txtPersonalAmountFlight";
            txtPersonalAmountFlight.Size = new System.Drawing.Size(116, 23);
            txtPersonalAmountFlight.TabIndex = 1;
            txtPersonalAmountFlight.KeyPress += txtPersonalAmountFlight_KeyPress;
            // 
            // lblPersonalUseAmountFlight
            // 
            lblPersonalUseAmountFlight.AutoSize = true;
            lblPersonalUseAmountFlight.Location = new System.Drawing.Point(14, 16);
            lblPersonalUseAmountFlight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPersonalUseAmountFlight.Name = "lblPersonalUseAmountFlight";
            lblPersonalUseAmountFlight.Size = new System.Drawing.Size(309, 15);
            lblPersonalUseAmountFlight.TabIndex = 0;
            lblPersonalUseAmountFlight.Text = "Please write the amount that you used for personal issues";
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(rbNoPersonalUseFlight);
            panel3.Controls.Add(rbYesPersonalUseFlight);
            panel3.Controls.Add(lblPesonalUse);
            panel3.Location = new System.Drawing.Point(35, 372);
            panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(557, 46);
            panel3.TabIndex = 4;
            // 
            // rbNoPersonalUseFlight
            // 
            rbNoPersonalUseFlight.AutoSize = true;
            rbNoPersonalUseFlight.Checked = true;
            rbNoPersonalUseFlight.Location = new System.Drawing.Point(500, 10);
            rbNoPersonalUseFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbNoPersonalUseFlight.Name = "rbNoPersonalUseFlight";
            rbNoPersonalUseFlight.Size = new System.Drawing.Size(41, 19);
            rbNoPersonalUseFlight.TabIndex = 2;
            rbNoPersonalUseFlight.TabStop = true;
            rbNoPersonalUseFlight.Text = "No";
            rbNoPersonalUseFlight.UseVisualStyleBackColor = true;
            rbNoPersonalUseFlight.CheckedChanged += rbNoPersonalUseFlight_CheckedChanged;
            // 
            // rbYesPersonalUseFlight
            // 
            rbYesPersonalUseFlight.AutoSize = true;
            rbYesPersonalUseFlight.Location = new System.Drawing.Point(443, 10);
            rbYesPersonalUseFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rbYesPersonalUseFlight.Name = "rbYesPersonalUseFlight";
            rbYesPersonalUseFlight.Size = new System.Drawing.Size(42, 19);
            rbYesPersonalUseFlight.TabIndex = 1;
            rbYesPersonalUseFlight.TabStop = true;
            rbYesPersonalUseFlight.Text = "Yes";
            rbYesPersonalUseFlight.UseVisualStyleBackColor = true;
            rbYesPersonalUseFlight.CheckedChanged += rbYesPersonalUseFlight_CheckedChanged;
            // 
            // lblPesonalUse
            // 
            lblPesonalUse.AutoSize = true;
            lblPesonalUse.Location = new System.Drawing.Point(14, 13);
            lblPesonalUse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPesonalUse.Name = "lblPesonalUse";
            lblPesonalUse.Size = new System.Drawing.Size(295, 15);
            lblPesonalUse.TabIndex = 0;
            lblPesonalUse.Text = "Did you use some part of the flight for personal issues?";
            // 
            // lblTaxesAndFees
            // 
            lblTaxesAndFees.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTaxesAndFees.AutoSize = true;
            lblTaxesAndFees.Location = new System.Drawing.Point(31, 15);
            lblTaxesAndFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTaxesAndFees.Name = "lblTaxesAndFees";
            lblTaxesAndFees.Size = new System.Drawing.Size(87, 15);
            lblTaxesAndFees.TabIndex = 6;
            lblTaxesAndFees.Text = "Taxes and Fees:";
            lblTaxesAndFees.Visible = false;
            // 
            // txtFlightTaxesAndFees
            // 
            txtFlightTaxesAndFees.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtFlightTaxesAndFees.Location = new System.Drawing.Point(139, 12);
            txtFlightTaxesAndFees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFlightTaxesAndFees.Name = "txtFlightTaxesAndFees";
            txtFlightTaxesAndFees.Size = new System.Drawing.Size(31, 23);
            txtFlightTaxesAndFees.TabIndex = 7;
            txtFlightTaxesAndFees.Text = "0";
            txtFlightTaxesAndFees.Visible = false;
            txtFlightTaxesAndFees.KeyPress += txtFlightTaxesAndFees_KeyPress;
            txtFlightTaxesAndFees.KeyUp += txtFlightTaxesAndFees_KeyUp;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnAddFlight, 1, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(201, 580);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new System.Drawing.Size(490, 54);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // btnAddFlight
            // 
            btnAddFlight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnAddFlight.BackColor = System.Drawing.Color.Azure;
            btnAddFlight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(192, 255, 192);
            btnAddFlight.FlatAppearance.BorderSize = 5;
            btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnAddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAddFlight.Image = (System.Drawing.Image)resources.GetObject("btnAddFlight.Image");
            btnAddFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAddFlight.Location = new System.Drawing.Point(301, 4);
            btnAddFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnAddFlight.Name = "btnAddFlight";
            btnAddFlight.Size = new System.Drawing.Size(185, 46);
            btnAddFlight.TabIndex = 10;
            btnAddFlight.Text = "Add Flight to the List";
            btnAddFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnAddFlight.UseVisualStyleBackColor = false;
            btnAddFlight.Click += btnAddFlight_Click;
            // 
            // dgvFlight
            // 
            dgvFlight.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvFlight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { DepartureDate, ReturnDate, FlightCost, TaxesAndFees, DistrictPay, PersonalUse, PersonalUseAmount, Total, Notes, Delete });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgvFlight.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFlight.Location = new System.Drawing.Point(51, 683);
            dgvFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dgvFlight.Name = "dgvFlight";
            dgvFlight.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvFlight.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvFlight.RowTemplate.Height = 30;
            dgvFlight.Size = new System.Drawing.Size(639, 143);
            dgvFlight.TabIndex = 2;
            dgvFlight.CellContentClick += dgvFlight_CellContentClick;
            // 
            // DepartureDate
            // 
            DepartureDate.HeaderText = "Departure";
            DepartureDate.Name = "DepartureDate";
            DepartureDate.ReadOnly = true;
            DepartureDate.Width = 130;
            // 
            // ReturnDate
            // 
            ReturnDate.HeaderText = "Return";
            ReturnDate.Name = "ReturnDate";
            ReturnDate.ReadOnly = true;
            ReturnDate.Width = 130;
            // 
            // FlightCost
            // 
            FlightCost.HeaderText = "Flight Cost";
            FlightCost.Name = "FlightCost";
            FlightCost.ReadOnly = true;
            FlightCost.Width = 120;
            // 
            // TaxesAndFees
            // 
            TaxesAndFees.HeaderText = "Taxes & Fees";
            TaxesAndFees.Name = "TaxesAndFees";
            TaxesAndFees.ReadOnly = true;
            TaxesAndFees.Visible = false;
            // 
            // DistrictPay
            // 
            DistrictPay.HeaderText = "District Pay";
            DistrictPay.Name = "DistrictPay";
            DistrictPay.ReadOnly = true;
            DistrictPay.Visible = false;
            // 
            // PersonalUse
            // 
            PersonalUse.HeaderText = "Personal Use";
            PersonalUse.Name = "PersonalUse";
            PersonalUse.ReadOnly = true;
            PersonalUse.Visible = false;
            // 
            // PersonalUseAmount
            // 
            PersonalUseAmount.HeaderText = "Personal Use Amount";
            PersonalUseAmount.Name = "PersonalUseAmount";
            PersonalUseAmount.ReadOnly = true;
            PersonalUseAmount.Visible = false;
            PersonalUseAmount.Width = 150;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Visible = false;
            // 
            // Notes
            // 
            Notes.HeaderText = "Notes";
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            Notes.Visible = false;
            // 
            // Delete
            // 
            Delete.HeaderText = "";
            Delete.Image = (System.Drawing.Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 120;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.27723F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.72277F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            tableLayoutPanel3.Controls.Add(btnNextFlight, 2, 0);
            tableLayoutPanel3.Controls.Add(btnBackFlight, 0, 0);
            tableLayoutPanel3.Controls.Add(label1, 1, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(531, 858);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new System.Drawing.Size(161, 43);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // btnNextFlight
            // 
            btnNextFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnNextFlight.FlatAppearance.BorderSize = 0;
            btnNextFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNextFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnNextFlight.Image = (System.Drawing.Image)resources.GetObject("btnNextFlight.Image");
            btnNextFlight.Location = new System.Drawing.Point(104, 5);
            btnNextFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnNextFlight.Name = "btnNextFlight";
            btnNextFlight.Size = new System.Drawing.Size(53, 33);
            btnNextFlight.TabIndex = 2;
            btnNextFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNextFlight.UseVisualStyleBackColor = true;
            btnNextFlight.Click += btnNextFlight_Click;
            // 
            // btnBackFlight
            // 
            btnBackFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnBackFlight.FlatAppearance.BorderSize = 0;
            btnBackFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBackFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnBackFlight.Image = (System.Drawing.Image)resources.GetObject("btnBackFlight.Image");
            btnBackFlight.Location = new System.Drawing.Point(5, 5);
            btnBackFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnBackFlight.Name = "btnBackFlight";
            btnBackFlight.Size = new System.Drawing.Size(62, 33);
            btnBackFlight.TabIndex = 1;
            btnBackFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnBackFlight.UseVisualStyleBackColor = true;
            btnBackFlight.Click += btnBackFlight_Click;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(77, 9);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(19, 25);
            label1.TabIndex = 3;
            label1.Text = "|";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlightList
            // 
            lblFlightList.AutoSize = true;
            lblFlightList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            lblFlightList.Location = new System.Drawing.Point(47, 657);
            lblFlightList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFlightList.Name = "lblFlightList";
            lblFlightList.Size = new System.Drawing.Size(97, 20);
            lblFlightList.TabIndex = 8;
            lblFlightList.Text = "Flights List";
            // 
            // btnCancelFlight
            // 
            btnCancelFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            btnCancelFlight.FlatAppearance.BorderSize = 0;
            btnCancelFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancelFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancelFlight.ForeColor = System.Drawing.SystemColors.ControlText;
            btnCancelFlight.Image = (System.Drawing.Image)resources.GetObject("btnCancelFlight.Image");
            btnCancelFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancelFlight.Location = new System.Drawing.Point(51, 860);
            btnCancelFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancelFlight.Name = "btnCancelFlight";
            btnCancelFlight.Size = new System.Drawing.Size(93, 39);
            btnCancelFlight.TabIndex = 0;
            btnCancelFlight.Text = "Cancel";
            btnCancelFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnCancelFlight.UseVisualStyleBackColor = true;
            btnCancelFlight.Click += btnCancelFlight_Click;
            // 
            // AirFare
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(729, 913);
            ControlBox = false;
            Controls.Add(tableLayoutPanel4);
            Controls.Add(lblFlightList);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(dgvFlight);
            Controls.Add(btnCancelFlight);
            Controls.Add(panel1);
            Controls.Add(lblAirFareHeader);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AirFare";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Air Fare";
            Load += AirFare_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFlight).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblAirFareHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFlightDepartureDate;
        private System.Windows.Forms.Label lblFlightReturnDate;
        private System.Windows.Forms.DateTimePicker dtpFlightDepartureDate;
        private System.Windows.Forms.DateTimePicker dtpFlightReturnDate;
        private System.Windows.Forms.Label lblFlightCost;
        private System.Windows.Forms.TextBox txtFlightCost;
        private System.Windows.Forms.Label lblTaxesAndFees;
        private System.Windows.Forms.TextBox txtFlightTaxesAndFees;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtFlightTotal;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.DataGridView dgvFlight;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNodistrictPayFlight;
        private System.Windows.Forms.RadioButton rbYesDistrictPayFlight;
        private System.Windows.Forms.Label lblDistrictPayFlight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbNoPersonalUseFlight;
        private System.Windows.Forms.RadioButton rbYesPersonalUseFlight;
        private System.Windows.Forms.Label lblPesonalUse;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPersonalAmountFlight;
        private System.Windows.Forms.Label lblPersonalUseAmountFlight;
        private System.Windows.Forms.Label lblFlightNotes;
        private System.Windows.Forms.TextBox txtFlightNotes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnCancelFlight;
        private System.Windows.Forms.Button btnBackFlight;
        private System.Windows.Forms.Button btnNextFlight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblRoundTrip;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbNoRoundTrip;
        private System.Windows.Forms.RadioButton rbYesRoundTrip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFlightList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlightCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxesAndFees;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DistrictPay;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PersonalUse;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonalUseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}