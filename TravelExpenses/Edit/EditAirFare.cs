using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using TravelExpenses.Properties;
//using iTextSharp;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using iTextSharp.text.xml;
using System.IO;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using iText.Kernel.Pdf;
using iText.Kernel.XMP;
using iText.Kernel;
using iText.Forms;
using iText.Forms.Fields;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.IO.Font.Constants;

namespace TravelExpenses
{
    public partial class EditAirFare : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        Guid edittravelID;
        Guid editFlightID;
        int quantityFlight = 0;
        bool isNew = false;
        public EditAirFare()
        {
            InitializeComponent();
        }

        private void EditAirFare_Load(object sender, EventArgs e)
        {
            localCon.Open();

            if (CommonVariables.viewDetails)
            {
                //this is for changing the place where the button are shown.
                Control del = tlEditFlightButtons.GetControlFromPosition(0, 0);
                Control lab3 = tlEditFlightButtons.GetControlFromPosition(5, 0);
                tlEditFlightButtons.SetCellPosition(del, new TableLayoutPanelCellPosition(5, 0));
                tlEditFlightButtons.SetCellPosition(lab3, new TableLayoutPanelCellPosition(0, 0));
                TableLayoutColumnStyleCollection styles = this.tlEditFlightButtons.ColumnStyles;
                foreach (ColumnStyle style in styles)
                {
                    style.Width = 50;
                }

                edittravelID = new Guid(CommonVariables.viewTravelID);
                //lblEditAirFare.Visible = false;
                btnDeleteFlight.Visible = false;
                btnAddFlight.Visible = false;
                btnSaveFlight.Visible = false;
                btnClose.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                btnEditFlight.Image = Resources.if_5_330396;

                //btnEditFlight.Text = "View";
            }
            else
            {
                edittravelID = new Guid(CommonVariables.editTravelID.ToString());
            }
            

            SqlCommand cmd = new SqlCommand("SELECT TOP 1000 [AirFareID],[DepartureDate],[ReturnDate],[AirFareCost],[TaxesAndFees],[DistrictPay],[PersonalUse],[PersonalUseAmount],[AirFareTotal],[Notes]FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '"+ edittravelID +"'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string departureDate = dr["DepartureDate"].ToString();
                string returnDate = dr["ReturnDate"].ToString();
                string flightCost = dr["AirFareCost"].ToString();
                string taxesAndFees = dr["TaxesAndFees"].ToString();
                bool districtPay = Convert.ToBoolean(dr["DistrictPay"].ToString());
                bool personalUse = Convert.ToBoolean(dr["PersonalUse"].ToString());
                string personalUseAmount = dr["PersonalUseAmount"].ToString();
                string flightTotal = dr["AirFareTotal"].ToString();
                string notes = dr["Notes"].ToString();
                string flightID = dr["AirFareID"].ToString();
                dgvEditAirfare.Rows.Add(departureDate, returnDate, flightCost, taxesAndFees, districtPay, flightTotal, flightID, notes, personalUse, personalUseAmount);
                quantityFlight++;
            }
            dr.Close();
            if (quantityFlight <= 1)
            {
                btnDeleteFlight.Enabled = false;
            }

            dtpReturnDate.Value = DateTime.Today.AddDays(1);
            this.Size = new System.Drawing.Size(711, 266);


            localCon.Close();
        }

        private void btnEditFlight_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvEditAirfare.CurrentRow.Index;
            string flightID = dgvEditAirfare.Rows[rowIndex].Cells[6].Value.ToString();
            editFlightID = new Guid(flightID);

            dtpDepartureDate.Value = Convert.ToDateTime(dgvEditAirfare.Rows[rowIndex].Cells[0].Value.ToString());
            if (dgvEditAirfare.Rows[rowIndex].Cells[1].Value.ToString() != "")
            {
                rbYesRoundTrip.Checked = true;
                dtpReturnDate.Enabled = true;
                dtpReturnDate.Value = Convert.ToDateTime(dgvEditAirfare.Rows[rowIndex].Cells[1].Value.ToString());

            }
            txtFlightCost.Text = dgvEditAirfare.Rows[rowIndex].Cells[2].Value.ToString();
            txtTaxesAndFees.Text = dgvEditAirfare.Rows[rowIndex].Cells[3].Value.ToString();
            txtTotalFlight.Text = dgvEditAirfare.Rows[rowIndex].Cells[5].Value.ToString();

            if (dgvEditAirfare.Rows[rowIndex].Cells[4].Value.ToString() == "True")
            {
                rbYesDistrictPay.Checked = true;
            }
            else
            {
                rbNoDistrictPay.Checked = true;
            }
            if (dgvEditAirfare.Rows[rowIndex].Cells[8].Value.ToString() == "True")
            {
                rbYesPesonalUse.Checked = true;
                pPesonalUseAmount.Enabled = true;
                txtPersonalUseAmount.Text = dgvEditAirfare.Rows[rowIndex].Cells[9].Value.ToString();
            }
            else
            {
                rbNoPersonalUse.Checked = true;
            }
            txtNotes.Text = dgvEditAirfare.Rows[rowIndex].Cells[7].Value.ToString();

            tlEditFlightButtons.Visible = false;
            dgvEditAirfare.Enabled = false;
            this.Size = new System.Drawing.Size(711, 722);

        }

        private void rbYesRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesRoundTrip.Checked)
            {
                dtpReturnDate.Enabled = true;
            }
        }

        private void rbNoRoundTrip_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoRoundTrip.Checked)
            {
                dtpReturnDate.Enabled = false;
            }
        }

        private void calculateTotal()
        {
            if (txtFlightCost.Text != "" && txtTaxesAndFees.Text != "")
            {
                double totalFlight = Convert.ToDouble(txtFlightCost.Text) + Convert.ToDouble(txtTaxesAndFees.Text);
                txtTotalFlight.Text = totalFlight.ToString();
            }
        }

        private void rbYesPesonalUse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYesPesonalUse.Checked)
            {
                pPesonalUseAmount.Enabled = true;
            }
        }

        private void rbNoPersonalUse_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoPersonalUse.Checked)
            {
                pPesonalUseAmount.Enabled = false;
                txtPersonalUseAmount.Text = "";
            }
        }

        private void txtFlightCost_KeyUp(object sender, KeyEventArgs e)
        {
            //calculateTotal();
        }

        private void txtTaxesAndFees_KeyUp(object sender, KeyEventArgs e)
        {
            //calculateTotal();
        }

        private void btnSaveFlight_Click(object sender, EventArgs e)
        {
            DateTime departureDate = DateTime.Today;
            string returnDate = "";
            double flightCost = 0;
            double taxesAndFees = 0;
            double totalFlight = 0;
            bool distirctPay = true;
            bool personalUse = false;
            double personalUseAmount = 0;
            string notes = "";
            bool roundTrip = false;
            double travelAmount = 0;
            double travelReim = 0;
            double travelNoReim = 0;
            localCon.Open();
            if (validateData())
            {
                if (isNew)
                {
                    departureDate = dtpDepartureDate.Value;
                    if (rbYesRoundTrip.Checked)
                    {
                        returnDate = dtpReturnDate.Value.ToString();
                        roundTrip = true;
                    }
                    flightCost = Convert.ToDouble(txtFlightCost.Text);
                    taxesAndFees = Convert.ToDouble(txtTaxesAndFees.Text);
                    totalFlight = flightCost + taxesAndFees;
                    if (rbNoDistrictPay.Checked)
                    {
                        distirctPay = false;
                    }
                    if (rbYesPesonalUse.Checked)
                    {
                        personalUse = true;
                        personalUseAmount = Convert.ToDouble(txtPersonalUseAmount.Text);
                    }
                    else
                    {
                        personalUse = false;
                        personalUseAmount = 0;
                    }
                    
                    notes = txtNotes.Text;

                    SqlDataAdapter addFlight = new SqlDataAdapter();
                    addFlight.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[AirFare]([DepartureDate],[ReturnDate],[AirFareCost],[TaxesAndFees],[DistrictPay],[PersonalUse],[PersonalUseAmount],[AirFareTotal],[TravelID],[Notes]) VALUES (@DepartureDate,@ReturnDate,@AirFareCost,@TaxesAndFees,@DistrictPay,@PersonalUse,@PersonalUseAmount,@AirFareTotal,@TravelID,@Notes)", localCon);
                    addFlight.InsertCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = departureDate;
                    if (roundTrip)
                    {
                        addFlight.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = returnDate;
                    }
                    else
                    {
                        addFlight.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = SqlDateTime.Null;
                    }
                    addFlight.InsertCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = flightCost;
                    addFlight.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = taxesAndFees;
                    addFlight.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = distirctPay;
                    addFlight.InsertCommand.Parameters.Add("@PersonalUse", SqlDbType.Bit).Value = personalUse;
                    addFlight.InsertCommand.Parameters.Add("@PersonalUseAmount", SqlDbType.Float).Value = personalUseAmount;
                    addFlight.InsertCommand.Parameters.Add("@AirFareTotal", SqlDbType.Float).Value = totalFlight;
                    addFlight.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = edittravelID;
                    addFlight.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = notes;
                    int ri = addFlight.InsertCommand.ExecuteNonQuery();

                    if (ri > 0)
                    {
                        SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                        SqlDataReader dr2 = cmd2.ExecuteReader();
                        while (dr2.Read())
                        {
                            travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                            travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                            travelNoReim = Convert.ToDouble(dr2["TotalTravelNoReimbursed"].ToString());
                        }
                        dr2.Close();

                        travelAmount = travelAmount + totalFlight;
                        if (!distirctPay)
                        {
                            if (personalUse)
                            {
                                double diffAFNew = totalFlight - personalUseAmount;
                                travelReim = travelReim + diffAFNew;
                            }
                            else
                            {
                                travelReim = travelReim + totalFlight;
                            }

                        }
                        else
                        {
                            if (personalUse)
                            {
                                travelNoReim = travelNoReim + personalUseAmount;
                            }
                        }

                        SqlDataAdapter upTravel = new SqlDataAdapter();
                        upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed,[TotalTravelNoReimbursed] = @TotalTravelNoReimbursed   WHERE TravelID ='" + edittravelID + "'", localCon);
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelNoReimbursed", SqlDbType.Float).Value = travelNoReim;
                        int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                        localCon.Close();
                        if (ru > 0)
                        {
                            MessageBox.Show("Airfare inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshFlights();
                            isNew = false;
                            if (backgroundWorker1.IsBusy != true)
                            {
                                backgroundWorker1.RunWorkerAsync();
                            }
                        }
                    }

                }
                else {

                    bool oriDistricPay = true;
                    double oriFlightTotal = 0;
                    bool oriPersonalUse = false;
                    double oriPersonalUseAmount = 0;


                    SqlCommand cmd = new SqlCommand("SELECT [DistrictPay],[AirFareTotal],[PersonalUse],[PersonalUseAmount] FROM [TravelExpenses].[dbo].[AirFare] where AirFareID = '" + editFlightID + "'", localCon);
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        oriDistricPay = Convert.ToBoolean(dr["DistrictPay"].ToString());
                        oriFlightTotal = Convert.ToDouble(dr["AirFareTotal"].ToString());
                        oriPersonalUse = Convert.ToBoolean(dr["PersonalUse"].ToString());
                        oriPersonalUseAmount = Convert.ToDouble(dr["PersonalUseAmount"].ToString());
                    }
                    dr.Close();

                    SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                        travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                        travelNoReim = Convert.ToDouble(dr2["TotalTravelNoReimbursed"].ToString());
                    }
                    dr2.Close();

                    travelAmount = travelAmount - oriFlightTotal;
                    if (!oriDistricPay)
                    {
                        if (oriPersonalUse)
                        {
                            double diffAFUp = oriFlightTotal - oriPersonalUseAmount;
                            travelReim = travelReim - diffAFUp;
                        }
                        else
                        {
                            travelReim = travelReim - oriFlightTotal;
                        }

                    }
                    else
                    {
                        if (oriPersonalUse)
                        {
                            travelNoReim = travelNoReim - oriPersonalUseAmount;
                        }
                    }

                    departureDate = dtpDepartureDate.Value;
                    if (rbYesRoundTrip.Checked)
                    {
                        returnDate = dtpReturnDate.Value.ToString();
                        roundTrip = true;
                    }
                    flightCost = Convert.ToDouble(txtFlightCost.Text);
                    taxesAndFees = Convert.ToDouble(txtTaxesAndFees.Text);
                    totalFlight = flightCost + taxesAndFees;
                    if (rbNoDistrictPay.Checked)
                    {
                        distirctPay = false;
                    }
                    if (rbYesPesonalUse.Checked)
                    {
                        personalUse = true;
                        personalUseAmount = Convert.ToDouble(txtPersonalUseAmount.Text);
                    }

                    notes = txtNotes.Text;

                    SqlDataAdapter upFlight = new SqlDataAdapter();
                    upFlight.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[AirFare] SET [DepartureDate] = @DepartureDate,[ReturnDate] = @ReturnDate,[AirFareCost] = @AirFareCost,[TaxesAndFees] = @TaxesAndFees,[DistrictPay] = @DistrictPay,[PersonalUse] = @PersonalUse,[PersonalUseAmount] = @PersonalUseAmount,[AirFareTotal] = @AirFareTotal,[Notes] = @Notes WHERE AirFareID =  '"+ editFlightID +"'", localCon);
                    upFlight.UpdateCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = departureDate;
                    if (roundTrip)
                    {
                        upFlight.UpdateCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = returnDate;
                    }
                    else
                    {
                        upFlight.UpdateCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = SqlDateTime.Null;
                    }
                    upFlight.UpdateCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = flightCost;
                    upFlight.UpdateCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = taxesAndFees;
                    upFlight.UpdateCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = distirctPay;
                    upFlight.UpdateCommand.Parameters.Add("@PersonalUse", SqlDbType.Bit).Value = personalUse;
                    upFlight.UpdateCommand.Parameters.Add("@PersonalUseAmount", SqlDbType.Float).Value = personalUseAmount;
                    upFlight.UpdateCommand.Parameters.Add("@AirFareTotal", SqlDbType.Float).Value = totalFlight;
                    upFlight.UpdateCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = notes;
                    int ru = upFlight.UpdateCommand.ExecuteNonQuery();
                    if (ru > 0)
                    {
                        travelAmount = travelAmount + totalFlight;
                        if (!distirctPay)
                        {
                            if (personalUse)
                            {
                                double diffARUpEdit = totalFlight - personalUseAmount;
                                travelReim = travelReim + diffARUpEdit;
                            }
                            else
                            {
                                travelReim = travelReim + totalFlight;
                            }

                        }
                        else
                        {
                            if (personalUse)
                            {
                                travelNoReim = travelNoReim + personalUseAmount;
                            }
                        }

                        SqlDataAdapter upTravel = new SqlDataAdapter();
                        upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed,[TotalTravelNoReimbursed] = @TotalTravelNoReimbursed  WHERE TravelID ='" + edittravelID + "'", localCon);
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                        upTravel.UpdateCommand.Parameters.Add("@TotalTravelNoReimbursed", SqlDbType.Float).Value = travelNoReim;
                        int rut = upTravel.UpdateCommand.ExecuteNonQuery();
                        localCon.Close();
                        if (rut > 0)
                        {
                            MessageBox.Show("Airfare updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refreshFlights();
                            if (backgroundWorker1.IsBusy != true)
                            {
                                backgroundWorker1.RunWorkerAsync();
                            }
                        }
                    }

                }
                tlEditFlightButtons.Visible = true;
                this.Size = new System.Drawing.Size(711, 266);
                dgvEditAirfare.Enabled = true;
                clearData();
            }
            localCon.Close();
        }

        private void clearData()
        {
            rbNoRoundTrip.Checked = true;
            dtpReturnDate.Enabled = false;
            dtpDepartureDate.Value = DateTime.Today;
            dtpReturnDate.Value = DateTime.Today.AddDays(1);
            txtFlightCost.Text = "";
            txtTaxesAndFees.Text = "0";
            txtTotalFlight.Text = "";
            rbYesDistrictPay.Checked = false;
            rbNoDistrictPay.Checked = false;
            rbYesPesonalUse.Checked = false;
            rbNoPersonalUse.Checked = false;
            pPesonalUseAmount.Enabled = false;
            txtPersonalUseAmount.Text = "";
            txtNotes.Text = "";
        }

        private bool validateData() {

            if (txtFlightCost.Text == "")
            {
                MessageBox.Show("Provide the flight cost", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtTaxesAndFees.Text == "")
            {
                MessageBox.Show("Provide the taxes and fees of your flight or if you do not have any just put 0", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!rbYesDistrictPay.Checked && !rbNoDistrictPay.Checked)
            {
                MessageBox.Show("Answer the question about the district pay for your flight", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!rbYesPesonalUse.Checked && !rbNoPersonalUse.Checked)
            {
                MessageBox.Show("Answer the question about the personal use of your flight", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (rbYesPesonalUse.Checked && txtPersonalUseAmount.Text == "")
            {
                MessageBox.Show("Provide the amount of the flight that you used for personal issues", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            
            return true;
        }

        private void refreshFlights()
        {
            localCon.Open();
            quantityFlight = 0;
            dgvEditAirfare.Rows.Clear();
            SqlCommand cmd = new SqlCommand("SELECT TOP 1000 [AirFareID],[DepartureDate],[ReturnDate],[AirFareCost],[TaxesAndFees],[DistrictPay],[PersonalUse],[PersonalUseAmount],[AirFareTotal],[Notes]FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '" + edittravelID + "'", localCon);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string departureDate = dr["DepartureDate"].ToString();
                string returnDate = dr["ReturnDate"].ToString();
                string flightCost = dr["AirFareCost"].ToString();
                string taxesAndFees = dr["TaxesAndFees"].ToString();
                bool districtPay = Convert.ToBoolean(dr["DistrictPay"].ToString());
                bool personalUse = Convert.ToBoolean(dr["PersonalUse"].ToString());
                string personalUseAmount = dr["PersonalUseAmount"].ToString();
                string flightTotal = dr["AirFareTotal"].ToString();
                string notes = dr["Notes"].ToString();
                string flightID = dr["AirFareID"].ToString();
                dgvEditAirfare.Rows.Add(departureDate, returnDate, flightCost, taxesAndFees, districtPay, flightTotal, flightID, notes, personalUse, personalUseAmount);
                quantityFlight++;
            }
            dr.Close();

            if (quantityFlight <= 1)
            {
                btnDeleteFlight.Enabled = false;
            }
            else {

                btnDeleteFlight.Enabled = true;
            }

            this.Size = new System.Drawing.Size(729, 266);



            localCon.Close();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            isNew = true;
            dgvEditAirfare.Enabled = false;
            tlEditFlightButtons.Visible = false;
            this.Size = new System.Drawing.Size(711, 722);
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            dgvEditAirfare.Enabled = true;
            tlEditFlightButtons.Visible = true;
            this.Size = new System.Drawing.Size(711, 266);
            clearData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            if (CommonVariables.viewDetails)
            {
                FormCollection fc = Application.OpenForms;
                Form main = new Form();
                foreach (Form frm in fc)
                {
                    string name = frm.Name;
                    if (frm.Name == "ViewTravel")
                    {
                        frm.Focus();
                        frm.Show();
                    }
                }
            }
            else
            {
                FormCollection fc = Application.OpenForms;
                foreach (Form frm in fc)
                {
                    string name = frm.Name;
                    if (frm.Name == "SelectItemsEdit")
                    {
                        frm.Focus();
                        frm.Show();
                    }
                }
            }
            
        }

        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            DialogResult delAirfaew = MessageBox.Show("Do you really want to delete this flight?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (delAirfaew == DialogResult.Yes)
            {
                int rowIndex = dgvEditAirfare.CurrentRow.Index;
                string flightId = dgvEditAirfare.Rows[rowIndex].Cells[6].Value.ToString();
                editFlightID = new Guid(flightId);
                double totalFlight = Convert.ToDouble(dgvEditAirfare.Rows[rowIndex].Cells[5].Value.ToString());
                bool districtPay = Convert.ToBoolean(dgvEditAirfare.Rows[rowIndex].Cells[4].Value.ToString());
                bool personalUse = Convert.ToBoolean(dgvEditAirfare.Rows[rowIndex].Cells[8].Value.ToString());
                double personalUseAmount = Convert.ToDouble(dgvEditAirfare.Rows[rowIndex].Cells[9].Value.ToString());

                double travelAmount = 0;
                double travelReim = 0;
                double travelNoReim = 0;

                localCon.Open();
                SqlCommand delFlight = new SqlCommand("DELETE FROM [TravelExpenses].[dbo].[AirFare] WHERE AirFareID = '" + editFlightID + "'", localCon);
                int rd = delFlight.ExecuteNonQuery();
                if (rd > 0)
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT [TotalTravelAmount],[TotalTravelReimbursed],[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID ='" + edittravelID + "'", localCon);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        travelAmount = Convert.ToDouble(dr2["TotalTravelAmount"].ToString());
                        travelReim = Convert.ToDouble(dr2["TotalTravelReimbursed"].ToString());
                        travelNoReim = Convert.ToDouble(dr2["TotalTravelNoReimbursed"].ToString());
                    }
                    dr2.Close();

                    travelAmount = travelAmount - totalFlight;
                    if (!districtPay)
                    {
                        if (personalUse)
                        {
                            double diffAFDEl = totalFlight - personalUseAmount;
                            travelReim = travelReim - diffAFDEl;
                        }
                        else
                        {
                            travelReim = travelReim - totalFlight;
                        }
                    }
                    else
                    {
                        if (personalUse)
                        {
                            travelNoReim = travelNoReim - personalUseAmount;
                        }
                    }

                    SqlDataAdapter upTravel = new SqlDataAdapter();
                    upTravel.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [TotalTravelAmount] = @TotalTravelAmount ,[TotalTravelReimbursed] = @TotalTravelReimbursed,[TotalTravelNoReimbursed] = @TotalTravelNoReimbursed  WHERE TravelID ='" + edittravelID + "'", localCon);
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = travelAmount;
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = travelReim;
                    upTravel.UpdateCommand.Parameters.Add("@TotalTravelNoReimbursed", SqlDbType.Float).Value = travelNoReim;
                    int ru = upTravel.UpdateCommand.ExecuteNonQuery();
                    localCon.Close();
                    if (ru > 0)
                    {
                        MessageBox.Show("Airfare deleted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshFlights();
                    }
                }



                localCon.Close();
            }
        }

        private void txtFlightCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTaxesAndFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTotalFlight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPersonalUseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtFlightCost_TextChanged(object sender, EventArgs e)
        {
            if (txtFlightCost.Text != "" && txtTaxesAndFees.Text != "")
            {
                txtTotalFlight.Text = txtFlightCost.Text;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            sendEmail();
        }

        private void sendEmail()
        {
            localCon.Open();
            string username = "";
            string emailEmp = "";
            string accEmail = "";
            string destination = "";
            DateTime departureDate = DateTime.Today;
            DateTime returnDate = DateTime.Today;
            string travelEvent = "";
            Guid idUser = new Guid(CommonVariables.user);

            SqlCommand userInfo = new SqlCommand("SELECT [Name],[LastName],b.Email FROM [TravelExpenses].[dbo].[User] as a inner join [TravelExpenses].[dbo].[User_Email_Title] as b on a.UserID = b.UserID where a.UserID = '" + idUser + "'", localCon);
            SqlDataReader userInfoDR = userInfo.ExecuteReader();
            while (userInfoDR.Read())
            {
                username = userInfoDR["Name"].ToString() + " " + userInfoDR["LastName"].ToString();
                emailEmp = userInfoDR["Email"].ToString();
            }
            userInfoDR.Close();

            SqlCommand travelData = new SqlCommand("SELECT [ReturnDate],[DepartureDate],[TravelEvent],[Destination] FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + edittravelID +"'", localCon);
            SqlDataReader travelDataDR = travelData.ExecuteReader();
            if (travelDataDR.HasRows)
            {
                while (travelDataDR.Read())
                {
                    departureDate = Convert.ToDateTime(travelDataDR["DepartureDate"].ToString());
                    returnDate = Convert.ToDateTime(travelDataDR["ReturnDate"].ToString());
                    destination = travelDataDR["Destination"].ToString();
                    travelEvent = travelDataDR["TravelEvent"].ToString();
                }
            }
            travelDataDR.Close();

           SqlCommand accEmailSearch = new SqlCommand("SELECT [Email] FROM [TravelExpenses].[dbo].[User_Email_Title] where Title = 'Accounting Processor'", localCon);
            SqlDataReader accEmailSearchDR = accEmailSearch.ExecuteReader();
            if (accEmailSearchDR.HasRows)
            {
                while (accEmailSearchDR.Read())
                {
                    accEmail = accEmailSearchDR["Email"].ToString();
                }
            }
            accEmailSearchDR.Close();



            localCon.Close();

            SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org", 587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
            SmtpServer.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("travelAlert@lcmcd.org");
            mail.To.Add(accEmail);
            mail.Subject = "Review travel of " + username;

           /* MailMessage empMail = new MailMessage();
            empMail.From = new MailAddress("travelAlert@lcmcd.org");
            empMail.To.Add(emailEmp);
            empMail.Subject = "Travel to " + destination;*/


            if (departureDate.ToShortDateString() == returnDate.ToShortDateString())
            {
                mail.Body = "Travel Event: " + travelEvent + " on " + departureDate.ToShortDateString() + " was updated by "+ username ;
            }
            else
            {
                mail.Body = "Travel Event: " + travelEvent + " between " + departureDate.ToShortDateString() + " and " + returnDate.ToShortDateString() + " was updated by " + username;

            }

           /* string bodyText = "In reference to the above travel that you just electronically signed, please bring to Jessica Collins all invoices/ receipts, in order for her to review your expense report(do not send them via email)." + System.Environment.NewLine + "Important: Please keep a copy of all invoices / receipts." + System.Environment.NewLine + "Thank you";
            // bodyText = bodyText.Replace("@", " " + System.Environment.NewLine);
            empMail.Body = bodyText;*/

            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            try
            {
                SmtpServer.Send(mail);
               // SmtpServer.Send(empMail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            localCon.Close();
        }
    }
}
