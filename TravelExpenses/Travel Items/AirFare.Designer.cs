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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AirFare));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblAirFareHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFlightCost = new System.Windows.Forms.Label();
            this.txtFlightCost = new System.Windows.Forms.TextBox();
            this.lblFlightReturnDate = new System.Windows.Forms.Label();
            this.dtpFlightReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblFlightDepartureDate = new System.Windows.Forms.Label();
            this.dtpFlightDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.lblRoundTrip = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbNoRoundTrip = new System.Windows.Forms.RadioButton();
            this.rbYesRoundTrip = new System.Windows.Forms.RadioButton();
            this.lblFlightNotes = new System.Windows.Forms.Label();
            this.txtFlightNotes = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNodistrictPayFlight = new System.Windows.Forms.RadioButton();
            this.rbYesDistrictPayFlight = new System.Windows.Forms.RadioButton();
            this.lblDistrictPayFlight = new System.Windows.Forms.Label();
            this.txtFlightTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPersonalAmountFlight = new System.Windows.Forms.TextBox();
            this.lblPersonalUseAmountFlight = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbNoPersonalUseFlight = new System.Windows.Forms.RadioButton();
            this.rbYesPersonalUseFlight = new System.Windows.Forms.RadioButton();
            this.lblPesonalUse = new System.Windows.Forms.Label();
            this.lblTaxesAndFees = new System.Windows.Forms.Label();
            this.txtFlightTaxesAndFees = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.dgvFlight = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextFlight = new System.Windows.Forms.Button();
            this.btnBackFlight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFlightList = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancelFlight = new System.Windows.Forms.Button();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxesAndFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistrictPay = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PersonalUse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PersonalUseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlight)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAirFareHeader
            // 
            this.lblAirFareHeader.AutoSize = true;
            this.lblAirFareHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAirFareHeader.Location = new System.Drawing.Point(40, 29);
            this.lblAirFareHeader.Name = "lblAirFareHeader";
            this.lblAirFareHeader.Size = new System.Drawing.Size(164, 20);
            this.lblAirFareHeader.TabIndex = 0;
            this.lblAirFareHeader.Text = "Enter Flight Details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtFlightTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblTaxesAndFees);
            this.panel1.Controls.Add(this.txtFlightTaxesAndFees);
            this.panel1.Location = new System.Drawing.Point(44, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 445);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Image = global::TravelExpenses.Properties.Resources.if_information_14516;
            this.button1.Location = new System.Drawing.Point(230, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 30);
            this.button1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.40096F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.59904F));
            this.tableLayoutPanel1.Controls.Add(this.lblFlightCost, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtFlightCost, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblFlightReturnDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtpFlightReturnDate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFlightDepartureDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpFlightDepartureDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblRoundTrip, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFlightNotes, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtFlightNotes, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.43478F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFlightCost
            // 
            this.lblFlightCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlightCost.AutoSize = true;
            this.lblFlightCost.Location = new System.Drawing.Point(4, 120);
            this.lblFlightCost.Name = "lblFlightCost";
            this.lblFlightCost.Size = new System.Drawing.Size(128, 13);
            this.lblFlightCost.TabIndex = 4;
            this.lblFlightCost.Text = "Flight Cost:";
            // 
            // txtFlightCost
            // 
            this.txtFlightCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlightCost.Location = new System.Drawing.Point(139, 116);
            this.txtFlightCost.Name = "txtFlightCost";
            this.txtFlightCost.Size = new System.Drawing.Size(335, 20);
            this.txtFlightCost.TabIndex = 5;
            this.txtFlightCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFlightCost_KeyPress);
            this.txtFlightCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFlightCost_KeyUp);
            // 
            // lblFlightReturnDate
            // 
            this.lblFlightReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlightReturnDate.AutoSize = true;
            this.lblFlightReturnDate.Location = new System.Drawing.Point(4, 84);
            this.lblFlightReturnDate.Name = "lblFlightReturnDate";
            this.lblFlightReturnDate.Size = new System.Drawing.Size(128, 13);
            this.lblFlightReturnDate.TabIndex = 1;
            this.lblFlightReturnDate.Text = "Return Date:";
            // 
            // dtpFlightReturnDate
            // 
            this.dtpFlightReturnDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFlightReturnDate.Enabled = false;
            this.dtpFlightReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFlightReturnDate.Location = new System.Drawing.Point(139, 80);
            this.dtpFlightReturnDate.Name = "dtpFlightReturnDate";
            this.dtpFlightReturnDate.Size = new System.Drawing.Size(335, 20);
            this.dtpFlightReturnDate.TabIndex = 3;
            // 
            // lblFlightDepartureDate
            // 
            this.lblFlightDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlightDepartureDate.AutoSize = true;
            this.lblFlightDepartureDate.Location = new System.Drawing.Point(4, 48);
            this.lblFlightDepartureDate.Name = "lblFlightDepartureDate";
            this.lblFlightDepartureDate.Size = new System.Drawing.Size(128, 13);
            this.lblFlightDepartureDate.TabIndex = 0;
            this.lblFlightDepartureDate.Text = "Departure Date:";
            // 
            // dtpFlightDepartureDate
            // 
            this.dtpFlightDepartureDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFlightDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFlightDepartureDate.Location = new System.Drawing.Point(139, 44);
            this.dtpFlightDepartureDate.Name = "dtpFlightDepartureDate";
            this.dtpFlightDepartureDate.Size = new System.Drawing.Size(335, 20);
            this.dtpFlightDepartureDate.TabIndex = 2;
            this.dtpFlightDepartureDate.ValueChanged += new System.EventHandler(this.dtpFlightDepartureDate_ValueChanged);
            // 
            // lblRoundTrip
            // 
            this.lblRoundTrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoundTrip.AutoSize = true;
            this.lblRoundTrip.Location = new System.Drawing.Point(4, 12);
            this.lblRoundTrip.Name = "lblRoundTrip";
            this.lblRoundTrip.Size = new System.Drawing.Size(128, 13);
            this.lblRoundTrip.TabIndex = 10;
            this.lblRoundTrip.Text = "Round Trip:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbNoRoundTrip);
            this.panel5.Controls.Add(this.rbYesRoundTrip);
            this.panel5.Location = new System.Drawing.Point(139, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(183, 29);
            this.panel5.TabIndex = 11;
            // 
            // rbNoRoundTrip
            // 
            this.rbNoRoundTrip.AutoSize = true;
            this.rbNoRoundTrip.Checked = true;
            this.rbNoRoundTrip.Location = new System.Drawing.Point(61, 9);
            this.rbNoRoundTrip.Name = "rbNoRoundTrip";
            this.rbNoRoundTrip.Size = new System.Drawing.Size(39, 17);
            this.rbNoRoundTrip.TabIndex = 1;
            this.rbNoRoundTrip.TabStop = true;
            this.rbNoRoundTrip.Text = "No";
            this.rbNoRoundTrip.UseVisualStyleBackColor = true;
            this.rbNoRoundTrip.CheckedChanged += new System.EventHandler(this.rbNoRoundTrip_CheckedChanged);
            // 
            // rbYesRoundTrip
            // 
            this.rbYesRoundTrip.AutoSize = true;
            this.rbYesRoundTrip.Location = new System.Drawing.Point(3, 9);
            this.rbYesRoundTrip.Name = "rbYesRoundTrip";
            this.rbYesRoundTrip.Size = new System.Drawing.Size(43, 17);
            this.rbYesRoundTrip.TabIndex = 0;
            this.rbYesRoundTrip.Text = "Yes";
            this.rbYesRoundTrip.UseVisualStyleBackColor = true;
            this.rbYesRoundTrip.CheckedChanged += new System.EventHandler(this.rbYesRoundTrip_CheckedChanged);
            // 
            // lblFlightNotes
            // 
            this.lblFlightNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlightNotes.AutoSize = true;
            this.lblFlightNotes.Location = new System.Drawing.Point(4, 171);
            this.lblFlightNotes.Name = "lblFlightNotes";
            this.lblFlightNotes.Size = new System.Drawing.Size(128, 13);
            this.lblFlightNotes.TabIndex = 0;
            this.lblFlightNotes.Text = "Notes:";
            // 
            // txtFlightNotes
            // 
            this.txtFlightNotes.Location = new System.Drawing.Point(139, 148);
            this.txtFlightNotes.Multiline = true;
            this.txtFlightNotes.Name = "txtFlightNotes";
            this.txtFlightNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFlightNotes.Size = new System.Drawing.Size(335, 59);
            this.txtFlightNotes.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbNodistrictPayFlight);
            this.panel2.Controls.Add(this.rbYesDistrictPayFlight);
            this.panel2.Controls.Add(this.lblDistrictPayFlight);
            this.panel2.Location = new System.Drawing.Point(30, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 44);
            this.panel2.TabIndex = 3;
            // 
            // rbNodistrictPayFlight
            // 
            this.rbNodistrictPayFlight.AutoSize = true;
            this.rbNodistrictPayFlight.Location = new System.Drawing.Point(429, 13);
            this.rbNodistrictPayFlight.Name = "rbNodistrictPayFlight";
            this.rbNodistrictPayFlight.Size = new System.Drawing.Size(39, 17);
            this.rbNodistrictPayFlight.TabIndex = 2;
            this.rbNodistrictPayFlight.TabStop = true;
            this.rbNodistrictPayFlight.Text = "No";
            this.rbNodistrictPayFlight.UseVisualStyleBackColor = true;
            // 
            // rbYesDistrictPayFlight
            // 
            this.rbYesDistrictPayFlight.AutoSize = true;
            this.rbYesDistrictPayFlight.Checked = true;
            this.rbYesDistrictPayFlight.Location = new System.Drawing.Point(380, 13);
            this.rbYesDistrictPayFlight.Name = "rbYesDistrictPayFlight";
            this.rbYesDistrictPayFlight.Size = new System.Drawing.Size(43, 17);
            this.rbYesDistrictPayFlight.TabIndex = 1;
            this.rbYesDistrictPayFlight.TabStop = true;
            this.rbYesDistrictPayFlight.Text = "Yes";
            this.rbYesDistrictPayFlight.UseVisualStyleBackColor = true;
            // 
            // lblDistrictPayFlight
            // 
            this.lblDistrictPayFlight.AutoSize = true;
            this.lblDistrictPayFlight.Location = new System.Drawing.Point(12, 15);
            this.lblDistrictPayFlight.Name = "lblDistrictPayFlight";
            this.lblDistrictPayFlight.Size = new System.Drawing.Size(163, 13);
            this.lblDistrictPayFlight.TabIndex = 0;
            this.lblDistrictPayFlight.Text = "Did the district pay for your flight?";
            // 
            // txtFlightTotal
            // 
            this.txtFlightTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlightTotal.Location = new System.Drawing.Point(192, 9);
            this.txtFlightTotal.Name = "txtFlightTotal";
            this.txtFlightTotal.Size = new System.Drawing.Size(32, 20);
            this.txtFlightTotal.TabIndex = 9;
            this.txtFlightTotal.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(152, 14);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txtPersonalAmountFlight);
            this.panel4.Controls.Add(this.lblPersonalUseAmountFlight);
            this.panel4.Location = new System.Drawing.Point(30, 368);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(478, 44);
            this.panel4.TabIndex = 5;
            // 
            // txtPersonalAmountFlight
            // 
            this.txtPersonalAmountFlight.Enabled = false;
            this.txtPersonalAmountFlight.Location = new System.Drawing.Point(369, 11);
            this.txtPersonalAmountFlight.Name = "txtPersonalAmountFlight";
            this.txtPersonalAmountFlight.Size = new System.Drawing.Size(100, 20);
            this.txtPersonalAmountFlight.TabIndex = 1;
            this.txtPersonalAmountFlight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPersonalAmountFlight_KeyPress);
            // 
            // lblPersonalUseAmountFlight
            // 
            this.lblPersonalUseAmountFlight.AutoSize = true;
            this.lblPersonalUseAmountFlight.Location = new System.Drawing.Point(12, 14);
            this.lblPersonalUseAmountFlight.Name = "lblPersonalUseAmountFlight";
            this.lblPersonalUseAmountFlight.Size = new System.Drawing.Size(277, 13);
            this.lblPersonalUseAmountFlight.TabIndex = 0;
            this.lblPersonalUseAmountFlight.Text = "Please write the amount that you used for personal issues";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rbNoPersonalUseFlight);
            this.panel3.Controls.Add(this.rbYesPersonalUseFlight);
            this.panel3.Controls.Add(this.lblPesonalUse);
            this.panel3.Location = new System.Drawing.Point(30, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 40);
            this.panel3.TabIndex = 4;
            // 
            // rbNoPersonalUseFlight
            // 
            this.rbNoPersonalUseFlight.AutoSize = true;
            this.rbNoPersonalUseFlight.Checked = true;
            this.rbNoPersonalUseFlight.Location = new System.Drawing.Point(429, 9);
            this.rbNoPersonalUseFlight.Name = "rbNoPersonalUseFlight";
            this.rbNoPersonalUseFlight.Size = new System.Drawing.Size(39, 17);
            this.rbNoPersonalUseFlight.TabIndex = 2;
            this.rbNoPersonalUseFlight.TabStop = true;
            this.rbNoPersonalUseFlight.Text = "No";
            this.rbNoPersonalUseFlight.UseVisualStyleBackColor = true;
            this.rbNoPersonalUseFlight.CheckedChanged += new System.EventHandler(this.rbNoPersonalUseFlight_CheckedChanged);
            // 
            // rbYesPersonalUseFlight
            // 
            this.rbYesPersonalUseFlight.AutoSize = true;
            this.rbYesPersonalUseFlight.Location = new System.Drawing.Point(380, 9);
            this.rbYesPersonalUseFlight.Name = "rbYesPersonalUseFlight";
            this.rbYesPersonalUseFlight.Size = new System.Drawing.Size(43, 17);
            this.rbYesPersonalUseFlight.TabIndex = 1;
            this.rbYesPersonalUseFlight.TabStop = true;
            this.rbYesPersonalUseFlight.Text = "Yes";
            this.rbYesPersonalUseFlight.UseVisualStyleBackColor = true;
            this.rbYesPersonalUseFlight.CheckedChanged += new System.EventHandler(this.rbYesPersonalUseFlight_CheckedChanged);
            // 
            // lblPesonalUse
            // 
            this.lblPesonalUse.AutoSize = true;
            this.lblPesonalUse.Location = new System.Drawing.Point(12, 11);
            this.lblPesonalUse.Name = "lblPesonalUse";
            this.lblPesonalUse.Size = new System.Drawing.Size(263, 13);
            this.lblPesonalUse.TabIndex = 0;
            this.lblPesonalUse.Text = "Did you use some part of the flight for personal issues?";
            // 
            // lblTaxesAndFees
            // 
            this.lblTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTaxesAndFees.AutoSize = true;
            this.lblTaxesAndFees.Location = new System.Drawing.Point(27, 13);
            this.lblTaxesAndFees.Name = "lblTaxesAndFees";
            this.lblTaxesAndFees.Size = new System.Drawing.Size(86, 13);
            this.lblTaxesAndFees.TabIndex = 6;
            this.lblTaxesAndFees.Text = "Taxes and Fees:";
            this.lblTaxesAndFees.Visible = false;
            // 
            // txtFlightTaxesAndFees
            // 
            this.txtFlightTaxesAndFees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFlightTaxesAndFees.Location = new System.Drawing.Point(119, 10);
            this.txtFlightTaxesAndFees.Name = "txtFlightTaxesAndFees";
            this.txtFlightTaxesAndFees.Size = new System.Drawing.Size(27, 20);
            this.txtFlightTaxesAndFees.TabIndex = 7;
            this.txtFlightTaxesAndFees.Text = "0";
            this.txtFlightTaxesAndFees.Visible = false;
            this.txtFlightTaxesAndFees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFlightTaxesAndFees_KeyPress);
            this.txtFlightTaxesAndFees.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFlightTaxesAndFees_KeyUp);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnAddFlight, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(172, 503);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(420, 47);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddFlight.BackColor = System.Drawing.Color.Azure;
            this.btnAddFlight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddFlight.FlatAppearance.BorderSize = 5;
            this.btnAddFlight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.Image = global::TravelExpenses.Properties.Resources._1494979605_sign_add;
            this.btnAddFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFlight.Location = new System.Drawing.Point(237, 3);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(180, 40);
            this.btnAddFlight.TabIndex = 10;
            this.btnAddFlight.Text = "Add Flight to the List";
            this.btnAddFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddFlight.UseVisualStyleBackColor = false;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // dgvFlight
            // 
            this.dgvFlight.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureDate,
            this.ReturnDate,
            this.FlightCost,
            this.TaxesAndFees,
            this.DistrictPay,
            this.PersonalUse,
            this.PersonalUseAmount,
            this.Total,
            this.Notes,
            this.Delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFlight.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFlight.Location = new System.Drawing.Point(44, 592);
            this.dgvFlight.Name = "dgvFlight";
            this.dgvFlight.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFlight.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFlight.RowTemplate.Height = 30;
            this.dgvFlight.Size = new System.Drawing.Size(548, 124);
            this.dgvFlight.TabIndex = 2;
            this.dgvFlight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFlight_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.27723F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.72277F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel3.Controls.Add(this.btnNextFlight, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBackFlight, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(427, 744);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(166, 35);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // btnNextFlight
            // 
            this.btnNextFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNextFlight.FlatAppearance.BorderSize = 0;
            this.btnNextFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextFlight.Image = global::TravelExpenses.Properties.Resources.next;
            this.btnNextFlight.Location = new System.Drawing.Point(95, 3);
            this.btnNextFlight.Name = "btnNextFlight";
            this.btnNextFlight.Size = new System.Drawing.Size(59, 29);
            this.btnNextFlight.TabIndex = 2;
            this.btnNextFlight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextFlight.UseVisualStyleBackColor = true;
            this.btnNextFlight.Click += new System.EventHandler(this.btnNextFlight_Click);
            // 
            // btnBackFlight
            // 
            this.btnBackFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackFlight.FlatAppearance.BorderSize = 0;
            this.btnBackFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackFlight.Image = global::TravelExpenses.Properties.Resources.back;
            this.btnBackFlight.Location = new System.Drawing.Point(3, 3);
            this.btnBackFlight.Name = "btnBackFlight";
            this.btnBackFlight.Size = new System.Drawing.Size(55, 29);
            this.btnBackFlight.TabIndex = 1;
            this.btnBackFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackFlight.UseVisualStyleBackColor = true;
            this.btnBackFlight.Click += new System.EventHandler(this.btnBackFlight_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlightList
            // 
            this.lblFlightList.AutoSize = true;
            this.lblFlightList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightList.Location = new System.Drawing.Point(40, 569);
            this.lblFlightList.Name = "lblFlightList";
            this.lblFlightList.Size = new System.Drawing.Size(97, 20);
            this.lblFlightList.TabIndex = 8;
            this.lblFlightList.Text = "Flights List";
            // 
            // btnCancelFlight
            // 
            this.btnCancelFlight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelFlight.FlatAppearance.BorderSize = 0;
            this.btnCancelFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelFlight.Image = global::TravelExpenses.Properties.Resources.if_Close_1891023;
            this.btnCancelFlight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelFlight.Location = new System.Drawing.Point(44, 745);
            this.btnCancelFlight.Name = "btnCancelFlight";
            this.btnCancelFlight.Size = new System.Drawing.Size(97, 34);
            this.btnCancelFlight.TabIndex = 0;
            this.btnCancelFlight.Text = "Cancel";
            this.btnCancelFlight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelFlight.UseVisualStyleBackColor = true;
            this.btnCancelFlight.Click += new System.EventHandler(this.btnCancelFlight_Click);
            // 
            // DepartureDate
            // 
            this.DepartureDate.HeaderText = "Departure";
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            this.DepartureDate.Width = 130;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            this.ReturnDate.Width = 130;
            // 
            // FlightCost
            // 
            this.FlightCost.HeaderText = "Flight Cost";
            this.FlightCost.Name = "FlightCost";
            this.FlightCost.ReadOnly = true;
            this.FlightCost.Width = 120;
            // 
            // TaxesAndFees
            // 
            this.TaxesAndFees.HeaderText = "Taxes & Fees";
            this.TaxesAndFees.Name = "TaxesAndFees";
            this.TaxesAndFees.ReadOnly = true;
            this.TaxesAndFees.Visible = false;
            // 
            // DistrictPay
            // 
            this.DistrictPay.HeaderText = "District Pay";
            this.DistrictPay.Name = "DistrictPay";
            this.DistrictPay.ReadOnly = true;
            this.DistrictPay.Visible = false;
            // 
            // PersonalUse
            // 
            this.PersonalUse.HeaderText = "Personal Use";
            this.PersonalUse.Name = "PersonalUse";
            this.PersonalUse.ReadOnly = true;
            this.PersonalUse.Visible = false;
            // 
            // PersonalUseAmount
            // 
            this.PersonalUseAmount.HeaderText = "Personal Use Amount";
            this.PersonalUseAmount.Name = "PersonalUseAmount";
            this.PersonalUseAmount.ReadOnly = true;
            this.PersonalUseAmount.Visible = false;
            this.PersonalUseAmount.Width = 150;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Visible = false;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.ReadOnly = true;
            this.Notes.Visible = false;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::TravelExpenses.Properties.Resources._1493082053_1_04;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 120;
            // 
            // AirFare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 791);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.lblFlightList);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.dgvFlight);
            this.Controls.Add(this.btnCancelFlight);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAirFareHeader);
            this.Name = "AirFare";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Air Fare";
            this.Load += new System.EventHandler(this.AirFare_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlight)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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