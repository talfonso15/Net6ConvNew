using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;
using System.Data.SqlTypes;
//using iTextSharp; //commented for net6
//using iTextSharp.text; //commented for net6
//using iTextSharp.text.pdf; //commented for net6
//using iTextSharp.text.xml; //commented for net6
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;
using iText.Kernel.Pdf;
using iText.Kernel.XMP;
using iText.Kernel;
using iText.Forms;
using iText.Forms.Fields;
using iText.IO.Font;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using Microsoft.Office.Interop.Word;

namespace TravelExpenses
{
    public partial class Summary : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        bool travelSaved = false;
        bool travelUpdate = false;
        string winUser = Environment.UserName;
        double travelACC = 0;
        double trainingACC = 0;
        Guid travId;
        public Summary()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Summary_Load(object sender, EventArgs e)
        {
            double totalTravel = 0;
            double notReimbursement = 0;
            double totalReimbursement = 0;
            

            //Travel details
            if (CommonVariables.addingItems)
            {
                localCon.Open();
                Guid travAddID = new Guid(CommonVariables.addingTravelID);
                SqlCommand td = new SqlCommand("SELECT [DepartureTime],[DepartureDate],[ReturnTime],[ReturnDate],[TravelEvent],[TravelPurpose],[Origin],[Destination],[TravelState],[Notes] FROM [TravelExpenses].[dbo].[Travel] where TravelID = '"+ travAddID + "'", localCon);
                SqlDataReader dr = td.ExecuteReader();
                while (dr.Read())
                {
                    txtDepartureDateSummary.Text = dr["DepartureDate"].ToString();
                    txtDepartureTimeSummary.Text = dr["DepartureTime"].ToString();
                    txtReturnDateSummary.Text = dr["ReturnDate"].ToString();
                    txtReturnTimeSummary.Text = dr["ReturnTime"].ToString();
                    txtTravelEventSummary.Text = dr["TravelEvent"].ToString();
                    txtTravelPurposeSummary.Text = dr["TravelPurpose"].ToString();
                    txtOriginSummary.Text = dr["Origin"].ToString();
                    txtDestinationSummary.Text = dr["Destination"].ToString();
                    txtTravelStateSummary.Text = dr["TravelState"].ToString();
                    txtDetailNotesSummary.Text = dr["Notes"].ToString();
                }
                dr.Close();
                localCon.Close();
            }
            else
            {
                txtDepartureDateSummary.Text = CommonVariables.travelDepartureDate.ToShortDateString();
                txtDepartureTimeSummary.Text = CommonVariables.travelDepartureTime.ToString();
                txtReturnDateSummary.Text = CommonVariables.travelReturnDate.ToShortDateString();
                txtReturnTimeSummary.Text = CommonVariables.travelReturnTime.ToString();
                txtTravelEventSummary.Text = CommonVariables.travelEvent.ToString();
                txtTravelPurposeSummary.Text = CommonVariables.travelPurpose.ToString();
                txtOriginSummary.Text = CommonVariables.travelOrigin.ToString();
                txtDestinationSummary.Text = CommonVariables.travelDestination.ToString();
                txtTravelStateSummary.Text = CommonVariables.travelState.ToString();
                txtDetailNotesSummary.Text = CommonVariables.travelNotes.ToString();
                
            }

            //Meals
            if (CommonVariables.isMeals == true)
            {
                txtQuantBreakfast.Text = CommonVariables.mcl.Breakfast.ToString();
                txtQuantDinners.Text = CommonVariables.mcl.Dinner.ToString();
                txtQuantLunch.Text = CommonVariables.mcl.Lunch.ToString();
                double totalBreakf = Convert.ToDouble(CommonVariables.mcl.Breakfast.ToString()) * CommonVariables.mcl.BreakfastPerDiemRate;
                txtCostBreakfast.Text = totalBreakf.ToString();
                double totalLunch = Convert.ToDouble(CommonVariables.mcl.Lunch.ToString()) * CommonVariables.mcl.LunchPerDiemRate;
                txtCostLunch.Text = totalLunch.ToString();
                double totalDinner = Convert.ToDouble(CommonVariables.mcl.Dinner.ToString()) * CommonVariables.mcl.DinnerPerDiemRate;
                txtCostDinner.Text = totalDinner.ToString();
                chxProvidedMealsSummary.Checked = Convert.ToBoolean(CommonVariables.mcl.ProvidedMeals);
                txtMealsTotalAmount.Text = CommonVariables.mcl.MealsTotal.ToString();
                totalTravel = totalTravel + Convert.ToDouble(CommonVariables.mcl.MealsTotal.ToString());
                totalReimbursement = totalReimbursement + Convert.ToDouble(CommonVariables.mcl.MealsTotal.ToString());
                txtBreakfastPerDiemRate.Text = CommonVariables.mcl.BreakfastPerDiemRate.ToString();
                txtLunchPerDiemRate.Text = CommonVariables.mcl.LunchPerDiemRate.ToString();
                txtDinnerPerDiemRate.Text = CommonVariables.mcl.DinnerPerDiemRate.ToString();
                txtZipCode.Text = CommonVariables.mcl.PerDiemLoactionZipCode.ToString();
            }
            else {
                tabMeals.Visible = false;
                tcTravelSummary.TabPages.Remove(tabMeals);
            }

            //Registration
            if (CommonVariables.isRegistartion == true)
            {
                txtRegistrationCostSummary.Text = CommonVariables.rg.RegistrationAmount.ToString();
                chxDistrictPayRegistration.Checked = Convert.ToBoolean(CommonVariables.rg.DistrictPay);
                txtRegistrationNotes.Text = CommonVariables.rg.Notes.ToString();
                if (!chxDistrictPayRegistration.Checked)
                {
                    totalReimbursement = totalReimbursement + Convert.ToDouble(CommonVariables.rg.RegistrationAmount.ToString());
                }
                totalTravel = totalTravel + Convert.ToDouble(CommonVariables.rg.RegistrationAmount.ToString());
            }
            else {
                tcTravelSummary.TabPages.Remove(tabRegistration);
            }

            //Lodgings
            if (CommonVariables.isLodging == true)
            {
                int quanLodgings = CommonVariables.lcl.Count;
                int rowNumberLod = 1;
                double totalLod = 0;
                if (quanLodgings < 5)
                {
                    for (int i = 0; i < quanLodgings; i++)
                    {

                        tlpLodgings.GetControlFromPosition(0, rowNumberLod).Text = CommonVariables.lcl[i].FacilityName.ToString();
                        //tlpLodgings.GetControlFromPosition(1, rowNumberLod).Text = CommonVariables.lcl[i].NumberOfNights.ToString();
                        //tlpLodgings.GetControlFromPosition(2, rowNumberLod).Text = CommonVariables.lcl[i].CostPerNight.ToString();
                        tlpLodgings.GetControlFromPosition(1, rowNumberLod).Text = CommonVariables.lcl[i].TotalLodging.ToString();
                        totalLod = totalLod + Convert.ToDouble(CommonVariables.lcl[i].TotalLodging.ToString());
                        bool districtPay = Convert.ToBoolean(CommonVariables.lcl[i].DistrictPay);
                        bool directorApproved = Convert.ToBoolean(CommonVariables.lcl[i].DirectorApproved);
                        if (districtPay == false && directorApproved == false)
                        {
                            notReimbursement = notReimbursement + Convert.ToDouble(CommonVariables.lcl[i].TotalLodging.ToString());
                        }
                        else if (districtPay == false && directorApproved == true)
                        {
                            totalReimbursement = totalReimbursement + Convert.ToDouble(CommonVariables.lcl[i].TotalLodging.ToString());
                        }

                        rowNumberLod++;
                    }

                    tlpLodgings.GetControlFromPosition(1, 5).Text = totalLod.ToString();
                    totalTravel = totalTravel + totalLod;
                }
            }
            else {
                tcTravelSummary.TabPages.Remove(tabLodgings);
            }

            //Rental Car
            if (CommonVariables.isCarRental == true)
            {
                int quanCars = CommonVariables.crcl.Count;
                int rowNumberCar = 1;
                double totalCar = 0;
                if (quanCars < 5)
                {

                    for (int i = 0; i < quanCars; i++)
                    {
                        tlpCar.GetControlFromPosition(0, rowNumberCar).Text = CommonVariables.crcl[i].PickUpDate.ToShortDateString();
                        tlpCar.GetControlFromPosition(1, rowNumberCar).Text = CommonVariables.crcl[i].DropOffDate.ToShortDateString();
                        tlpCar.GetControlFromPosition(2, rowNumberCar).Text = CommonVariables.crcl[i].CostPerDay.ToString();
                        if (CommonVariables.crcl[i].DistrictPay == true)
                        {
                            tlpCar.GetControlFromPosition(3, rowNumberCar).Text = "Yes";
                            if (CommonVariables.crcl[i].PersonalUse == true)
                            {
                                notReimbursement = notReimbursement + Convert.ToDouble(CommonVariables.crcl[i].PersonalUseAmount.ToString());
                            }
                        }
                        else
                        {
                            tlpCar.GetControlFromPosition(3, rowNumberCar).Text = "No";
                            if (CommonVariables.crcl[i].PersonalUse == true)
                            {
                                double perUseDiff = Convert.ToDouble(CommonVariables.crcl[i].TotalCarRental.ToString()) - Convert.ToDouble(CommonVariables.crcl[i].PersonalUseAmount.ToString());
                                totalReimbursement = totalReimbursement + perUseDiff;
                            }
                            else
                            {
                                totalReimbursement = totalReimbursement + Convert.ToDouble(CommonVariables.crcl[i].TotalCarRental.ToString());
                            }
                                
                        }
                        if (CommonVariables.crcl[i].PersonalUseAmount.ToString() != "")
                        {
                            tlpCar.GetControlFromPosition(4, rowNumberCar).Text = CommonVariables.crcl[i].PersonalUseAmount.ToString();
                        }
                        else
                        {
                            tlpCar.GetControlFromPosition(4, rowNumberCar).Text = "0";
                        }
                        double insuranceCarTotal = 0;
                        double insuranceLDW = 0;
                        if (CommonVariables.crcl[i].LDWInsuranse.ToString() != "")
                        {
                            insuranceLDW = Convert.ToDouble(CommonVariables.crcl[i].LDWInsuranse.ToString());
                        }
                        double insuranceSupp = 0;
                        if (CommonVariables.crcl[i].SupplementalInsurance.ToString() != "")
                        {
                            insuranceSupp = Convert.ToDouble(CommonVariables.crcl[i].SupplementalInsurance.ToString());
                        }
                        double InsuranceExtra = 0;
                        if (CommonVariables.crcl[i].ExtraInsuranceAmount.ToString() != "")
                        {
                            InsuranceExtra = Convert.ToDouble(CommonVariables.crcl[i].ExtraInsuranceAmount.ToString());
                        }
                        insuranceCarTotal = insuranceLDW + insuranceSupp + InsuranceExtra;
                        tlpCar.GetControlFromPosition(5, rowNumberCar).Text = insuranceCarTotal.ToString();
                        tlpCar.GetControlFromPosition(6, rowNumberCar).Text = CommonVariables.crcl[i].TotalCarRental.ToString();

                        totalCar = totalCar + Convert.ToDouble(CommonVariables.crcl[i].TotalCarRental.ToString());


                        rowNumberCar++;
                    }
                    tlpCar.GetControlFromPosition(6, 5).Text = totalCar.ToString();
                    totalTravel = totalTravel + totalCar;
                }
            }
            else {
                tcTravelSummary.TabPages.Remove(tabRentalCars);
            }

            //Air Fare
            if (CommonVariables.isAirFare == true)
            {
                int quanFlights = CommonVariables.afcl.Count;
                int rowNumberFlights = 1;
                double totalFlight = 0;
                if (quanFlights < 4)
                {
                    for (int i = 0; i < quanFlights; i++)
                    {
                        tlpFlights.GetControlFromPosition(0, rowNumberFlights).Text = CommonVariables.afcl[i].DepartureDate.ToShortDateString();
                        if (CommonVariables.afcl[i].ReturnDate != null)
                        {
                            DateTime rt = Convert.ToDateTime(CommonVariables.afcl[i].ReturnDate);
                            tlpFlights.GetControlFromPosition(1, rowNumberFlights).Text = rt.ToShortDateString();
                        }
                        else
                        {
                            tlpFlights.GetControlFromPosition(1, rowNumberFlights).Text = "";
                        }
                        if (CommonVariables.afcl[i].DistrictPay == true)
                        {
                            tlpFlights.GetControlFromPosition(2, rowNumberFlights).Text = "Yes";
                            if (CommonVariables.afcl[i].PersonalUse == true)
                            {
                                notReimbursement = notReimbursement + Convert.ToDouble(CommonVariables.afcl[i].PersonalUseAmount.ToString());
                            }
                        }
                        else
                        {
                            tlpFlights.GetControlFromPosition(2, rowNumberFlights).Text = "No";
                            if (CommonVariables.afcl[i].PersonalUse == true)
                            {
                                double perUsDiffFlight = Convert.ToDouble(CommonVariables.afcl[i].TotalAirFare.ToString()) - Convert.ToDouble(CommonVariables.afcl[i].PersonalUseAmount.ToString());
                                totalReimbursement = totalReimbursement + perUsDiffFlight;
                            }
                            else
                            {
                                totalReimbursement = totalReimbursement + Convert.ToDouble(CommonVariables.afcl[i].TotalAirFare.ToString());
                            }
                                
                        }
                        if (CommonVariables.afcl[i].PersonalUseAmount.ToString() != "")
                        {
                            tlpFlights.GetControlFromPosition(3, rowNumberFlights).Text = CommonVariables.afcl[i].PersonalUseAmount.ToString();
                        }
                        else
                        {
                            tlpFlights.GetControlFromPosition(3, rowNumberFlights).Text = "0";
                        }
                        tlpFlights.GetControlFromPosition(4, rowNumberFlights).Text = CommonVariables.afcl[i].AirFareCost.ToString();
                        tlpFlights.GetControlFromPosition(5, rowNumberFlights).Text = CommonVariables.afcl[i].TotalAirFare.ToString();
                        totalFlight = totalFlight + Convert.ToDouble(CommonVariables.afcl[i].TotalAirFare.ToString());
                        rowNumberFlights++;
                    }
                    tlpFlights.GetControlFromPosition(5, 4).Text = totalFlight.ToString();
                    totalTravel = totalTravel + totalFlight;

                }


            }
            else {
                tcTravelSummary.TabPages.Remove(tabAirFare);
            }

            //Mileage
            if (CommonVariables.isMileage == true)
            {
                txtMapMileageValue.Text = CommonVariables.micl.MapMileage.ToString();
                txtVicinityMileageValue.Text = CommonVariables.micl.VicinityMileage.ToString();
                if (CommonVariables.micl.DistricticProvidedVehicle == true)
                {
                    txtProvidedVehicleMileage.Text = "Yes";
                    txtDirectorApprovalMileage.Text = "";
                }
                else
                {

                    txtProvidedVehicleMileage.Text = "No";
                    if (CommonVariables.micl.DirectorApprovedPersonal == false)
                    {
                        notReimbursement = notReimbursement + Convert.ToDouble(CommonVariables.micl.TotalMileage.ToString());
                        txtDirectorApprovalMileage.Text = "No";
                    }
                    else
                    {
                        totalReimbursement = totalReimbursement + Convert.ToDouble(CommonVariables.micl.TotalMileage.ToString());
                        txtDirectorApprovalMileage.Text = "Yes";
                    }
                }

                txtMapTotal.Text = CommonVariables.micl.TotalMileage.ToString();
                totalTravel = totalTravel + Convert.ToDouble(CommonVariables.micl.TotalMileage.ToString());
            }
            else {
                tcTravelSummary.TabPages.Remove(tabMileage);
            }


            //Other Expenses
            if (CommonVariables.isOtherExpenses == true)
            {
                int quanOtherExp = CommonVariables.oxcl.Count;
                int rowNumberExp = 1;
                double expTotal = 0;
                if (quanOtherExp <= 7)
                {
                    for (int i = 0; i < quanOtherExp; i++)
                    {
                        tlpOtherExpenses.GetControlFromPosition(0, rowNumberExp).Text = CommonVariables.oxcl[i].Description.ToString();
                        if (CommonVariables.oxcl[i].Prepaid)
                        {
                            tlpOtherExpenses.GetControlFromPosition(1, rowNumberExp).Text = "Yes";
                        }
                        else
                        {
                            tlpOtherExpenses.GetControlFromPosition(1, rowNumberExp).Text = "No";

                        }
                        tlpOtherExpenses.GetControlFromPosition(2, rowNumberExp).Text = CommonVariables.oxcl[i].Amount.ToString();
                        if (!CommonVariables.oxcl[i].Prepaid)
                        {
                            totalReimbursement = totalReimbursement + Convert.ToDouble(CommonVariables.oxcl[i].Amount.ToString());
                        }
                        expTotal = expTotal + Convert.ToDouble(CommonVariables.oxcl[i].Amount.ToString());
                        rowNumberExp++;
                    }
                    tlpOtherExpenses.GetControlFromPosition(2, 8).Text = expTotal.ToString();
                    totalTravel = totalTravel + expTotal;
                }
                

            }
            else {
                tcTravelSummary.TabPages.Remove(tabOtherExpenses);
            }

            if (CommonVariables.addingItems)
            {
                Guid travID = new Guid(CommonVariables.addingTravelID);
                localCon.Open();
                SqlCommand cmdSleTotalTravel = new SqlCommand("SELECT [TotalTravelAmount] ,[TotalTravelReimbursed] ,[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drTotals = cmdSleTotalTravel.ExecuteReader();
                while (drTotals.Read())
                {
                    string total = drTotals["TotalTravelAmount"].ToString();
                    string reim = drTotals["TotalTravelReimbursed"].ToString();
                    string totalNR = drTotals["TotalTravelNoReimbursed"].ToString();
                    totalTravel = Convert.ToDouble(total) + totalTravel;
                    totalReimbursement = Convert.ToDouble(reim) + totalReimbursement;
                    notReimbursement = Convert.ToDouble(totalNR) + notReimbursement;
                }
                drTotals.Close();
                localCon.Close();
                txtTravelTotalValue.Text = totalTravel.ToString();
                txtTotalReimbursementValue.Text = totalReimbursement.ToString();
                txtNoReimbursed.Text = notReimbursement.ToString();
            }
            else
            {
                CommonVariables.totalTravel = totalTravel;
                CommonVariables.totalReimbursement = totalReimbursement;
                CommonVariables.totalNotReimbursement = notReimbursement;
                txtTravelTotalValue.Text = CommonVariables.totalTravel.ToString();
                txtTotalReimbursementValue.Text = CommonVariables.totalReimbursement.ToString();
                txtNoReimbursed.Text = CommonVariables.totalNotReimbursement.ToString();
            }

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

       /* private void Summary_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommonVariables.CancelTravel();
        }*/

        private void btnSaveSplitTravel_Click(object sender, EventArgs e)
        {
            if (CommonVariables.addingItems)
            {
                if (travelUpdate)
                {
                    //generateDetailPDFUp();
                    //generateSummarizedPDFUp();
                    generatePDFUpd();
                }
                else
                {
                    addTravelItems();
                    // generateDetailPDFUp();
                    // generateSummarizedPDFUp();
                    generatePDFUpd();
                }

                //adding to the history trace table
                localCon.Open();
                Guid loginUser = new Guid(CommonVariables.user);
                SqlDataAdapter tadpt = new SqlDataAdapter();
                tadpt.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User_History_Trace] ([UserID],[Action],[Date]) VALUES (@UserID ,@Action,@Date)", localCon);
                tadpt.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = loginUser;
                tadpt.InsertCommand.Parameters.Add("@Action", SqlDbType.NVarChar).Value = "Item added to travel";
                tadpt.InsertCommand.Parameters.Add("@Date", SqlDbType.NVarChar).Value = DateTime.Now;
                tadpt.InsertCommand.ExecuteNonQuery();
                localCon.Close();
            }
            else
            {
                
                if (travelSaved)
                {
                    //generateSummarizedPDF();
                    //generateDetailPDF();
                    generatePDF();
                }
                else
                {
                    CommonVariables.showSignButton = true;

                    saveTravel();
                    if (!CommonVariables.is_TPT)
                    {
                        // generateSummarizedPDF();
                        // generateDetailPDF();
                        generatePDF();
                    }
                }

                //adding to the history trace table
                localCon.Open();
                Guid loginUser = new Guid(CommonVariables.user);
                SqlDataAdapter tadpt = new SqlDataAdapter();
                tadpt.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[User_History_Trace] ([UserID],[Action],[Date]) VALUES (@UserID ,@Action,@Date)", localCon);
                tadpt.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = loginUser;
                tadpt.InsertCommand.Parameters.Add("@Action", SqlDbType.NVarChar).Value = "Travel created";
                tadpt.InsertCommand.Parameters.Add("@Date", SqlDbType.NVarChar).Value = DateTime.Now;
                tadpt.InsertCommand.ExecuteNonQuery();
                localCon.Close();
            }

            CommonVariables.isSummary = false;
            //btnSaveSplitTravel.Enabled = false; commented for net6
            btnBackSummary.Enabled = false;
            if (!CommonVariables.is_TPT)
            {
                ViewPDF vpdf = new ViewPDF();
                vpdf.Show();
            }

            CommonVariables.is_TPT = false;
            CommonVariables.isGroup = false;
            CommonVariables.usersID = new List<string>();
            CommonVariables.tpt_UserID = "";
            CommonVariables.tpt_Type = "";
        }


        private void btnCancelSummary_Click(object sender, EventArgs e)
        {
            CommonVariables.CancelTravel();
            this.Close();
        }


        private void generateSummarizedPDF() {

            localCon.Open();
            string name = "";
            string lastname = "";
            string district = "";
            string department = "";
            string fullName = "";
            string username = "";

            SqlCommand cmdUser = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] where UserID = '" + CommonVariables.user + "'", localCon);
            SqlDataReader drUser = cmdUser.ExecuteReader();
            while (drUser.Read())
            {
                name = drUser["Name"].ToString();
                lastname = drUser["LastName"].ToString();
                district = drUser["District"].ToString();
                department = drUser["Department"].ToString();
                username = drUser["Username"].ToString(); 
            }
            drUser.Close();
            fullName = name + " " + lastname;



            string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form(Summarized).pdf";
            string pdfName = fullName + "_" + CommonVariables.travelDepartureDate.ToShortDateString() + "_" + "to" + "_" + CommonVariables.travelReturnDate.ToShortDateString() + ".pdf";
            pdfName = pdfName.Replace("/", "-");
            winUser = winUser.Replace("/", "-");
            string newFile = @"\\LCMHCD\Home\"+ winUser + "\\" + "travel\\travel_form(Summarized)_" + pdfName;
            CommonVariables.filePath = newFile;

            //new code for net 6
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(pdfTemplate), new PdfWriter(newFile));
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
            IDictionary<String, PdfFormField> fields = form.GetAllFormFields();
            PdfFormField toSet;
            //end of new code

            PdfReader pdfReader = new PdfReader(pdfTemplate);

            /*PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;*/



            //user details
            //pdfFormFields.SetField("Full Name", fullName); //commented for net6
            fields.TryGetValue("Full Name", out toSet);
            toSet.SetValue(fullName);

            //pdfFormFields.SetField("District", district); //commented for net6
            fields.TryGetValue("District", out toSet);
            toSet.SetValue(district);

            //pdfFormFields.SetField("Department", department); //commented for net6
            fields.TryGetValue("Department", out toSet);
            toSet.SetValue(department);

            //travel details
            //pdfFormFields.SetField("Travel Event", CommonVariables.travelEvent); //commented for net6
            fields.TryGetValue("Travel Event", out toSet);
            toSet.SetValue(CommonVariables.travelEvent);

            //pdfFormFields.SetField("Travel Purpose", CommonVariables.travelPurpose); //commented for net6
            fields.TryGetValue("Travel Purpose", out toSet);
            toSet.SetValue(CommonVariables.travelPurpose);

            //pdfFormFields.SetField("Departure Date", CommonVariables.travelDepartureDate.ToShortDateString()); //commented for net6
            fields.TryGetValue("Departure Date", out toSet);
            toSet.SetValue(CommonVariables.travelDepartureDate.ToShortDateString());

            //pdfFormFields.SetField("Departure Time", CommonVariables.travelDepartureTime); //commented for net6
            fields.TryGetValue("Departure Time", out toSet);
            toSet.SetValue(CommonVariables.travelDepartureTime);

            //pdfFormFields.SetField("Return Date", CommonVariables.travelReturnDate.ToShortDateString()); //commented for net6
            fields.TryGetValue("Return Date", out toSet);
            toSet.SetValue(CommonVariables.travelReturnDate.ToShortDateString());

            //pdfFormFields.SetField("Return Time", CommonVariables.travelReturnTime.ToString()); //commented for net6
            fields.TryGetValue("Return Time", out toSet);
            toSet.SetValue(CommonVariables.travelReturnTime.ToString());

            //pdfFormFields.SetField("Origin", CommonVariables.travelOrigin); //commented for net6
            fields.TryGetValue("Origin", out toSet);
            toSet.SetValue(CommonVariables.travelOrigin);

            //pdfFormFields.SetField("Destination", CommonVariables.travelDestination); //commented for net6
            fields.TryGetValue("Destination", out toSet);
            toSet.SetValue(CommonVariables.travelDestination);

            //pdfFormFields.SetField("Travel State", CommonVariables.travelState); //commented for net6
            fields.TryGetValue("Travel State", out toSet);
            toSet.SetValue(CommonVariables.travelState);

            //Meals Details
            if (CommonVariables.isMeals) {
                string mealCost = CommonVariables.mcl.MealsTotal.ToString("C", CultureInfo.CurrentCulture);
                mealCost = mealCost.Substring(1);
                
                //pdfFormFields.SetField("CostMeals", mealCost); //commented for net6
                fields.TryGetValue("CostMeals", out toSet);
                toSet.SetValue(mealCost);

                //pdfFormFields.SetField("NotesMeals", CommonVariables.mcl.Notes); //commented for net6
                fields.TryGetValue("NotesMeals", out toSet);
                toSet.SetValue(CommonVariables.mcl.Notes);
            }

            //Registration
            if (CommonVariables.isRegistartion) {
                string regCost = CommonVariables.rg.RegistrationAmount.ToString("C", CultureInfo.CurrentCulture);
                regCost = regCost.Substring(1);
                
                //pdfFormFields.SetField("CostRegistration", regCost); //commented for net6
                fields.TryGetValue("CostRegistration", out toSet);
                toSet.SetValue(regCost);

                //pdfFormFields.SetField("NotesRegistration", CommonVariables.rg.Notes); //commented for net6
                fields.TryGetValue("NotesRegistration", out toSet);
                toSet.SetValue(CommonVariables.rg.Notes);
            }

            //Lodgings
            if (CommonVariables.isLodging) {
                string notesLod = "";
                for (int i = 0; i < CommonVariables.lcl.Count; i++) {
                    if (CommonVariables.lcl[i].Notes != "")
                    {
                        notesLod += CommonVariables.lcl[i].Notes + ". ";
                    }
                }
                double lodCostDouble = Convert.ToDouble(txtTotalLod.Text);
                string lodCost = lodCostDouble.ToString("C", CultureInfo.CurrentCulture);
                lodCost = lodCost.Substring(1);
                
                //pdfFormFields.SetField("CostLodgings", lodCost); //commented for net6
                fields.TryGetValue("CostLodgings", out toSet);
                toSet.SetValue(lodCost);

                //pdfFormFields.SetField("NotesLodgings", notesLod); //commented for net6
                fields.TryGetValue("NotesLodgings", out toSet);
                toSet.SetValue(notesLod);
            }

            //Car Rentals
            if (CommonVariables.isCarRental) {
                string notesCar = "";
                for (int i = 0; i < CommonVariables.crcl.Count; i++) {
                    if (CommonVariables.crcl[i].Notes != "")
                    {
                        notesCar = CommonVariables.crcl[i].Notes + ". ";
                    }
                }

                double carCostDouble = Convert.ToDouble(txtTotalCar.Text);
                string carCost = carCostDouble.ToString("C", CultureInfo.CurrentCulture);
                carCost = carCost.Substring(1);
                
                //pdfFormFields.SetField("CostCar Rental", carCost); //commented for net6
                fields.TryGetValue("CostCar Rental", out toSet);
                toSet.SetValue(carCost);

                //pdfFormFields.SetField("NotesCar Rental", notesCar); //commented for net6
                fields.TryGetValue("NotesCar Rental", out toSet);
                toSet.SetValue(notesCar);
            }

            //Air Fare
            if (CommonVariables.isAirFare) {
                string notesAir = "";
                for (int i = 0; i < CommonVariables.afcl.Count; i++) {
                    if (CommonVariables.afcl[i].Notes != "")
                    {
                        notesAir += CommonVariables.afcl[i].Notes + ". ";
                    }
                }
                double flighCOstDouble = Convert.ToDouble(txtTotalFlight.Text);
                string flighCOst = flighCOstDouble.ToString("C", CultureInfo.CurrentCulture);
                flighCOst = flighCOst.Substring(1);
                
                //pdfFormFields.SetField("CostAir Fare", flighCOst); //commented for net6
                fields.TryGetValue("CostAir Fare", out toSet);
                toSet.SetValue(flighCOst);

                //pdfFormFields.SetField("NotesAir Fare", notesAir); //commented for net6
                fields.TryGetValue("NotesAir Fare", out toSet);
                toSet.SetValue(notesAir);
            }

            //Mileage
            if (CommonVariables.isMileage) {
                string milCost = CommonVariables.micl.TotalMileage.ToString("C", CultureInfo.CurrentCulture);
                milCost = milCost.Substring(1);
                
                //pdfFormFields.SetField("NotesMileage", CommonVariables.micl.Notes); //commented for net6
                fields.TryGetValue("NotesMileage", out toSet);
                toSet.SetValue(CommonVariables.micl.Notes);

                //pdfFormFields.SetField("CostMileage", milCost); //commented for net6
                fields.TryGetValue("CostMileage", out toSet);
                toSet.SetValue(milCost);
            }

            //Other Expenses
            if (CommonVariables.isOtherExpenses) {
                string notesOE = "";
                for (int i = 0; i < CommonVariables.oxcl.Count; i++) {
                    if (CommonVariables.oxcl[i].Notes != "")
                    {
                        notesOE += CommonVariables.oxcl[i].Notes + ". ";
                    }
                }
                double oeCOstDouble = Convert.ToDouble(txtTotalAmountExpenses.Text);
                string oeCOst = oeCOstDouble.ToString("C", CultureInfo.CurrentCulture);
                oeCOst = oeCOst.Substring(1);
                
                //pdfFormFields.SetField("CostOther Expenses", oeCOst); //commented for net6
                fields.TryGetValue("CostOther Expenses", out toSet);
                toSet.SetValue(oeCOst);

                //pdfFormFields.SetField("NotesOther Expenses", notesOE); //commented for net6
                fields.TryGetValue("NotesOther Expenses", out toSet);
                toSet.SetValue(notesOE);
            }

            //Tratel Totals
            string travTol = CommonVariables.totalTravel.ToString("C", CultureInfo.CurrentCulture);
            travTol = travTol.Substring(1);
            string reim = CommonVariables.totalReimbursement.ToString("C", CultureInfo.CurrentCulture);
            reim = reim.Substring(1);
            string noReim = CommonVariables.totalNotReimbursement.ToString("C", CultureInfo.CurrentCulture);
            noReim = noReim.Substring(1);
            
            //pdfFormFields.SetField("Travel Total", travTol); //commented for net6
            fields.TryGetValue("Travel Total", out toSet);
            toSet.SetValue(travTol);

            //pdfFormFields.SetField("Total Reimbursed", reim); //commented for net6
            fields.TryGetValue("Total Reimbursed", out toSet);
            toSet.SetValue(reim);

            //pdfFormFields.SetField("No Reimbursed", noReim); //commented for net6
            fields.TryGetValue("No Reimbursed", out toSet);
            toSet.SetValue(noReim);

            //Accounting accounts
            string travACC = travelACC.ToString("C", CultureInfo.CurrentCulture);
            //pdfFormFields.SetField("Travel4000", travACC); //commented for net6
            fields.TryGetValue("Travel4000", out toSet);
            toSet.SetValue(travACC);

            string trainACC = trainingACC.ToString("C", CultureInfo.CurrentCulture);
            //pdfFormFields.SetField("Training5500", trainACC); //commented for net6
            fields.TryGetValue("Travel4000", out toSet);
            toSet.SetValue(travACC);

            //Signatures
            SqlCommand cmdPDF = new SqlCommand("SELECT a.TravelID,a.UserID,a.UserType,a.TravelType,a.SignatureDate,b.FontType,b.SignatureText FROM [TravelExpenses].[dbo].[TravelSignatures] as a inner join TravelExpenses.dbo.UserSignature as b on b.UserID = a.UserID where a.TravelID = '" + travId + "'  AND a.TravelType = 'Travel'", localCon);
            SqlDataReader drPDF = cmdPDF.ExecuteReader();
            if (drPDF.HasRows)
            {
                while (drPDF.Read())
                {

                    // BaseFont bf = BaseFont.CreateFont(); //commented for net6
                    PdfFont font = PdfFontFactory.CreateFont();
                    
                    if (drPDF["FontType"].ToString() == "Mistral")
                    {
                        //bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\MISTRAL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); //commented for net6
                        font = PdfFontFactory.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\MISTRAL.TTF");
                    }
                    if (drPDF["FontType"].ToString() == "Rage Italic")
                    {
                        //bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\Rage Italic.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); //commented for net6
                        font = PdfFontFactory.CreateFont(@"\\LCMHCD\Employees\Travel Temp\Rage Italic.ttf");
                    }
                    if (drPDF["FontType"].ToString() == "MV Boli")
                    {
                        //bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\mvboli.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); //commented for net6
                        font = PdfFontFactory.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\mvboli.ttf");
                    }
                    if (drPDF["FontType"].ToString() == "Bradley Hand ITC")
                    {
                        //bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\BRADHITC.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); //commented for net6
                        font = PdfFontFactory.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\BRADHITC.TTF");
                    }
                    if (drPDF["FontType"].ToString() == "Script MT Bold")
                    {
                        //bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\SCRIPTBL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED); //commented for net6
                        font = PdfFontFactory.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\SCRIPTBL.TTF");
                    }

                    DateTime sigDate = Convert.ToDateTime(drPDF["SignatureDate"].ToString());
                    if (drPDF["UserType"].ToString() == "Accounting")
                    {
                        //pdfFormFields.SetFieldProperty("Finance Review Siganature", "textfont", bf, null); //commented for net6
                        //pdfFormFields.SetField("Finance Review Siganature", drPDF["SignatureText"].ToString()); //commented for net6
                        fields.TryGetValue("Finance Review Siganature", out toSet);
                        toSet.SetFont(font);
                        toSet.SetValue(drPDF["SignatureText"].ToString());

                        //pdfFormFields.SetField("Finance Review", sigDate.ToShortDateString()); //commented for net6
                        fields.TryGetValue("Finance Review", out toSet);
                        toSet.SetValue(sigDate.ToShortDateString());
                    }
                    if (drPDF["UserType"].ToString() == "Supervisor")
                    {
                        //pdfFormFields.SetFieldProperty("Supervisor Signature", "textfont", bf, null); //commented for net6
                        //pdfFormFields.SetField("Supervisor Signature", drPDF["SignatureText"].ToString()); //commented for net6
                        fields.TryGetValue("Supervisor Signature", out toSet);
                        toSet.SetFont(font);
                        toSet.SetValue(drPDF["SignatureText"].ToString());

                        //pdfFormFields.SetField("Supervisor Date", sigDate.ToShortDateString()); //commented for net6
                        fields.TryGetValue("Supervisor Date", out toSet);
                        toSet.SetValue(sigDate.ToShortDateString());
                    }
                    if (drPDF["UserType"].ToString() == "Employee")
                    {
                        //pdfFormFields.SetFieldProperty("Employee Signature", "textfont", bf, null); //commented for net6
                        //pdfFormFields.SetField("Employee Signature", drPDF["SignatureText"].ToString()); //commented for net6
                        fields.TryGetValue("Employee Signature", out toSet);
                        toSet.SetFont(font);
                        toSet.SetValue(drPDF["SignatureText"].ToString());

                        //pdfFormFields.SetField("Employee Date", sigDate.ToShortDateString()); //commented for net6
                        fields.TryGetValue("Employee Date", out toSet);
                        toSet.SetValue(sigDate.ToShortDateString());
                    }

                }
            }
            drPDF.Close();


            //pdfStamper.Close(); //commented for net6
            form.FlattenFields();
            pdfDoc.Close();
            localCon.Close();

           

        }

        private void generateDetailPDF() {

            localCon.Open();
            string name = "";
            string lastname = "";
            string district = "";
            string department = "";
            string fullName = "";
            string username = "";

            SqlCommand cmdUser = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] where UserID = '" + CommonVariables.user + "'", localCon);
            SqlDataReader drUser = cmdUser.ExecuteReader();
            while (drUser.Read())
            {
                name = drUser["Name"].ToString();
                lastname = drUser["LastName"].ToString();
                district = drUser["District"].ToString();
                department = drUser["Department"].ToString();
                username = drUser["Username"].ToString();
            }
            drUser.Close();
            fullName = name + " " + lastname;


            string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form(Details).pdf";
            string pdfName = fullName + "_" + CommonVariables.travelDepartureDate.ToShortDateString() + "_" + "to" + "_" + CommonVariables.travelReturnDate.ToShortDateString() + ".pdf";
            pdfName = pdfName.Replace("/", "-");
            string newFile = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\travel_form(Details)_" + pdfName;
            CommonVariables.detailedFilePath = newFile;

            //new code for net 6
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(pdfTemplate), new PdfWriter(newFile));
            PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
            IDictionary<String, PdfFormField> fields = form.GetAllFormFields();
            PdfFormField toSet;
            //end of new code

            PdfReader pdfReader = new PdfReader(pdfTemplate);

            /*PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;*/ //commented for net6



            //user details
            //pdfFormFields.SetField("Full Name", fullName); //commented for net6
            fields.TryGetValue("Full Name", out toSet);
            toSet.SetValue(fullName);

            //pdfFormFields.SetField("District", district); //commented for net6
            fields.TryGetValue("District", out toSet);
            toSet.SetValue(district);

            //pdfFormFields.SetField("Department", department); //commented for net6
            fields.TryGetValue("Department", out toSet);
            toSet.SetValue(department);


            //travel details
            //pdfFormFields.SetField("Travel Event", CommonVariables.travelEvent); //commented for net6
            fields.TryGetValue("Travel Event", out toSet);
            toSet.SetValue(CommonVariables.travelEvent);

            //pdfFormFields.SetField("Travel Purpose", CommonVariables.travelPurpose); //commented for net6
            fields.TryGetValue("Travel Purpose", out toSet);
            toSet.SetValue(CommonVariables.travelPurpose);

            //pdfFormFields.SetField("Departure_Date", CommonVariables.travelDepartureDate.ToShortDateString()); //commented for net6
            fields.TryGetValue("Departure_Date", out toSet);
            toSet.SetValue(CommonVariables.travelDepartureDate.ToShortDateString());

            //pdfFormFields.SetField("Departure_Time", CommonVariables.travelDepartureTime); //commented for net6
            fields.TryGetValue("Departure_Time", out toSet);
            toSet.SetValue(CommonVariables.travelDepartureTime);

            //pdfFormFields.SetField("Return_Date", CommonVariables.travelReturnDate.ToShortDateString()); //commented for net6
            fields.TryGetValue("Return_Date", out toSet);
            toSet.SetValue(CommonVariables.travelReturnDate.ToShortDateString());

            //pdfFormFields.SetField("Return_Time", CommonVariables.travelReturnTime.ToString()); //commented for net6
            fields.TryGetValue("Return_Time", out toSet);
            toSet.SetValue(CommonVariables.travelReturnTime.ToString());

            //pdfFormFields.SetField("Origin", CommonVariables.travelOrigin); //commented for net6
            fields.TryGetValue("Origin", out toSet);
            toSet.SetValue(CommonVariables.travelOrigin);

            //pdfFormFields.SetField("Destination", CommonVariables.travelDestination); //commented for net6
            fields.TryGetValue("Destination", out toSet);
            toSet.SetValue(CommonVariables.travelDestination);

            //pdfFormFields.SetField("Travel State", CommonVariables.travelState); //commented for net6
            fields.TryGetValue("Travel State", out toSet);
            toSet.SetValue(CommonVariables.travelState);

            //pdfFormFields.SetField("Travel Notes", CommonVariables.travelNotes); //commented for net6
            fields.TryGetValue("Travel Notes", out toSet);
            toSet.SetValue(CommonVariables.travelNotes);

            //Meals Details
            if (CommonVariables.isMeals)
            {
                //pdfFormFields.SetField("BreakfastQuantity", CommonVariables.mcl.Breakfast.ToString()); //commented for net6
                fields.TryGetValue("BreakfastQuantity", out toSet);
                toSet.SetValue(CommonVariables.mcl.Breakfast.ToString());

                //pdfFormFields.SetField("LunchQuantity", CommonVariables.mcl.Lunch.ToString()); //commented for net6
                fields.TryGetValue("LunchQuantity", out toSet);
                toSet.SetValue(CommonVariables.mcl.Lunch.ToString());

                //pdfFormFields.SetField("DinnerQuantity", CommonVariables.mcl.Dinner.ToString()); //commented for net6
                fields.TryGetValue("DinnerQuantity", out toSet);
                toSet.SetValue(CommonVariables.mcl.Dinner.ToString());

                int brekCost = CommonVariables.mcl.Breakfast * 8;
                //pdfFormFields.SetField("BreakfastCost", brekCost.ToString()); //commented for net6
                fields.TryGetValue("BreakfastCost", out toSet);
                toSet.SetValue(brekCost.ToString());

                int lunchCost = CommonVariables.mcl.Lunch * 12;
                //pdfFormFields.SetField("LunchCost", lunchCost.ToString()); //commented for net6
                fields.TryGetValue("LunchCost", out toSet);
                toSet.SetValue(lunchCost.ToString());

                int dinCost = CommonVariables.mcl.Dinner * 20;
                //pdfFormFields.SetField("DinnerCost", dinCost.ToString()); //commented for net6
                fields.TryGetValue("DinnerCost", out toSet);
                toSet.SetValue(dinCost.ToString());

                if (CommonVariables.mcl.ProvidedMeals == true)
                {
                    //pdfFormFields.SetField("Provided Meals", "Yes"); //commented for net6
                    fields.TryGetValue("Provided Meals", out toSet);
                    toSet.SetValue("Yes");
                }
                else {
                    //pdfFormFields.SetField("Provided Meals", "No"); //commented for net6
                    fields.TryGetValue("Provided Meals", out toSet);
                    toSet.SetValue("No");

                }
                //pdfFormFields.SetField("Meals_Total", CommonVariables.mcl.MealsTotal.ToString("C", CultureInfo.CurrentCulture).Substring(1)); //commented for net6
                fields.TryGetValue("Meals_Total", out toSet);
                toSet.SetValue(CommonVariables.mcl.MealsTotal.ToString("C", CultureInfo.CurrentCulture).Substring(1));
            }

            //Registration
            if (CommonVariables.isRegistartion)
            {
                //pdfFormFields.SetField("Registration Cost", CommonVariables.rg.RegistrationAmount.ToString("C", CultureInfo.CurrentCulture).Substring(1)); //commented for net6
                fields.TryGetValue("Registration Cost", out toSet);
                toSet.SetValue(CommonVariables.rg.RegistrationAmount.ToString("C", CultureInfo.CurrentCulture).Substring(1));
            }

            //Lodgings
            if (CommonVariables.isLodging)
            {
                int row = 1;
                for (int i = 0; i < CommonVariables.lcl.Count; i++)
                {
                    //pdfFormFields.SetField("Facility Name" + row, CommonVariables.lcl[i].FacilityName); //commented for net6
                    fields.TryGetValue("Facility Name" + row, out toSet);
                    toSet.SetValue(CommonVariables.lcl[i].FacilityName);

                    //pdfFormFields.SetField("Facility Total Cost" + row, CommonVariables.lcl[i].TotalLodging.ToString()); //commented for net6
                    fields.TryGetValue("Facility Total Cost" + row, out toSet);
                    toSet.SetValue(CommonVariables.lcl[i].TotalLodging.ToString());

                    //pdfFormFields.SetField("Lodging Nights" + row, CommonVariables.lcl[i].NumberOfNights.ToString()); //commented for net6
                    fields.TryGetValue("Lodging Nights" + row, out toSet);
                    toSet.SetValue(CommonVariables.lcl[i].NumberOfNights.ToString());

                    //pdfFormFields.SetField("Lodging Night Cost" + row, CommonVariables.lcl[i].CostPerNight.ToString()); //commented for net6
                    fields.TryGetValue("Lodging Night Cost" + row, out toSet);
                    toSet.SetValue(CommonVariables.lcl[i].CostPerNight.ToString());

                    //pdfFormFields.SetField("Lodging Taxes Fees" + row, CommonVariables.lcl[i].TaxesAndFees.ToString()); //commented for net6
                    fields.TryGetValue("Lodging Taxes Fees" + row, out toSet);
                    toSet.SetValue(CommonVariables.lcl[i].TaxesAndFees.ToString());

                    if (CommonVariables.lcl[i].DistrictPay)
                    {
                        //pdfFormFields.SetField("Lodging District Pay" + row, "Yes");//commented for net6
                        fields.TryGetValue("Lodging District Pay" + row, out toSet);
                        toSet.SetValue("Yes");

                        //pdfFormFields.SetField("Lodging Director Approval" + row, ""); //commented for net6
                        fields.TryGetValue("Lodging Director Approval" + row, out toSet);
                        toSet.SetValue("");
                    }
                    else {
                        //pdfFormFields.SetField("Lodging District Pay" + row, "No");//commented for net6
                        fields.TryGetValue("Lodging District Pay" + row, out toSet);
                        toSet.SetValue("No");

                        if (CommonVariables.lcl[i].DirectorApproved)
                        {
                            //pdfFormFields.SetField("Lodging Director Approval" + row, "Yes"); //commented for net6
                            fields.TryGetValue("Lodging Director Approval" + row, out toSet);
                            toSet.SetValue("Yes");
                        }
                        else
                        {
                            //pdfFormFields.SetField("Lodging Director Approval" + row, "No"); //commented for net6
                            fields.TryGetValue("Lodging Director Approval" + row, out toSet);
                            toSet.SetValue("No");
                        }
                    }
                    
                    //pdfFormFields.SetField("Facility  Notes" + row, CommonVariables.lcl[i].Notes); //commented for net6
                    fields.TryGetValue("Facility  Notes" + row, out toSet);
                    toSet.SetValue(CommonVariables.lcl[i].Notes);

                    row++;
                }
                string lodCost = Convert.ToDouble(txtTotalLod.Text).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                
                //pdfFormFields.SetField("Lodging Total", lodCost); //commented for net6
                fields.TryGetValue("Lodging Total", out toSet);
                toSet.SetValue(lodCost);
            }

            //Car Rentals
            if (CommonVariables.isCarRental)
            {
                int carRow = 1;
                for (int i = 0; i < CommonVariables.crcl.Count; i++)
                {
                    //pdfFormFields.SetField("Pick up Date" + carRow, CommonVariables.crcl[i].PickUpDate.ToShortDateString()); //commented for net6
                    fields.TryGetValue("Pick up Date" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].PickUpDate.ToShortDateString());

                    //pdfFormFields.SetField("Drop off Date" + carRow, CommonVariables.crcl[i].DropOffDate.ToShortDateString()); //commented for net6
                    fields.TryGetValue("Drop off Date" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].DropOffDate.ToShortDateString());

                    //pdfFormFields.SetField("Car_Day Cost" + carRow, CommonVariables.crcl[i].CostPerDay.ToString()); //commented for net6
                    fields.TryGetValue("Car_Day Cost" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].CostPerDay.ToString());

                    //pdfFormFields.SetField("Car Total" + carRow, CommonVariables.crcl[i].TotalCarRental.ToString()); //commented for net6
                    fields.TryGetValue("Car Total" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].TotalCarRental.ToString());

                    //pdfFormFields.SetField("Car Type" + carRow, CommonVariables.crcl[i].CarType); //commented for net6
                    fields.TryGetValue("Car Type" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].CarType);

                    //pdfFormFields.SetField("Rental Company" + carRow, CommonVariables.crcl[i].Company); //commented for net6
                    fields.TryGetValue("Rental Company" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].Company);

                    //pdfFormFields.SetField("Car Rental Days" + carRow, CommonVariables.crcl[i].Days.ToString()); //commented for net6
                    fields.TryGetValue("Car Rental Days" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].Days.ToString());

                    //pdfFormFields.SetField("Car Rental Taxes Fees" + carRow, CommonVariables.crcl[i].TaxesAndFees.ToString()); //commented for net6
                    fields.TryGetValue("Car Rental Taxes Fees" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].TaxesAndFees.ToString());

                    //pdfFormFields.SetField("LDW Insurance" + carRow, CommonVariables.crcl[i].LDWInsuranse.ToString()); //commented for net6
                    fields.TryGetValue("LDW Insurance" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].LDWInsuranse.ToString());

                    //pdfFormFields.SetField("Supplemental Insurance" + carRow, CommonVariables.crcl[i].SupplementalInsurance.ToString()); //commented for net6
                    fields.TryGetValue("Supplemental Insurance" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].SupplementalInsurance.ToString());

                    //pdfFormFields.SetField("Extra Insurance" + carRow, CommonVariables.crcl[i].ExtraInsuranceAmount.ToString()); //commented for net6
                    fields.TryGetValue("Extra Insurance" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].ExtraInsuranceAmount.ToString());

                    if (CommonVariables.crcl[i].DistrictPay)
                    {
                        //pdfFormFields.SetField("Car District Pay" + carRow, "Yes"); //commented for net6
                        fields.TryGetValue("Car District Pay" + carRow, out toSet);
                        toSet.SetValue("Yes");
                    }
                    else {
                        //pdfFormFields.SetField("Car District Pay" + carRow, "No"); //commented for net6
                        fields.TryGetValue("Car District Pay" + carRow, out toSet);
                        toSet.SetValue("No");
                    }
                    //pdfFormFields.SetField("Car Personal Amount" + carRow, CommonVariables.crcl[i].PersonalUseAmount.ToString()); //commented for net6
                    fields.TryGetValue("Car Personal Amount" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].PersonalUseAmount.ToString());

                    //pdfFormFields.SetField("Car Notes" + carRow, CommonVariables.crcl[i].Notes); //commented for net6
                    fields.TryGetValue("Car Notes" + carRow, out toSet);
                    toSet.SetValue(CommonVariables.crcl[i].Notes);

                    carRow++;
                }
                string carCost = Convert.ToDouble(txtTotalCar.Text).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                
                //pdfFormFields.SetField("Car Rental Total", carCost); //commented for net6
                fields.TryGetValue("Car Rental Total" , out toSet);
                toSet.SetValue(carCost);
            }

            //Air Fare
            if (CommonVariables.isAirFare)
            {
                int flightRow = 1;
                for (int i = 0; i < CommonVariables.afcl.Count; i++)
                {
                    //pdfFormFields.SetField("Flight_Departure Date" + flightRow, CommonVariables.afcl[i].DepartureDate.ToShortDateString()); //commented for net6
                    fields.TryGetValue("Flight_Departure Date" + flightRow, out toSet);
                    toSet.SetValue(CommonVariables.afcl[i].DepartureDate.ToShortDateString());

                    if (CommonVariables.afcl[i].ReturnDate.ToString() != "")
                    {
                        DateTime rd = Convert.ToDateTime(CommonVariables.afcl[i].ReturnDate);
                        
                        //pdfFormFields.SetField("Flight_Return Date" + flightRow, rd.ToShortDateString()); //commented for net6
                        fields.TryGetValue("Flight_Return Date" + flightRow, out toSet);
                        toSet.SetValue(rd.ToShortDateString());
                    }
                    //pdfFormFields.SetField("Flight Total" + flightRow, CommonVariables.afcl[i].TotalAirFare.ToString()); //commented for net6
                    fields.TryGetValue("Flight Total" + flightRow, out toSet);
                    toSet.SetValue(CommonVariables.afcl[i].TotalAirFare.ToString());

                    //pdfFormFields.SetField("Flight Taxes  Fees" + flightRow, CommonVariables.afcl[i].TaxesAndFees.ToString()); //commented for net6
                    fields.TryGetValue("Flight Taxes  Fees" + flightRow, out toSet);
                    toSet.SetValue(CommonVariables.afcl[i].TaxesAndFees.ToString());

                    if (CommonVariables.afcl[i].DistrictPay)
                    {
                        //pdfFormFields.SetField("Flight District Pay" + flightRow, "Yes"); //commented for net6
                        fields.TryGetValue("Flight District Pay" + flightRow, out toSet);
                        toSet.SetValue("Yes");
                    }
                    else {
                        //pdfFormFields.SetField("Flight District Pay" + flightRow, "No"); //commented for net6
                        fields.TryGetValue("Flight District Pay" + flightRow, out toSet);
                        toSet.SetValue("No");
                    }
                    //pdfFormFields.SetField("Flight Personal Amount" + flightRow, CommonVariables.afcl[i].PersonalUseAmount.ToString()); //commented for net6
                    fields.TryGetValue("Flight Personal Amount" + flightRow, out toSet);
                    toSet.SetValue(CommonVariables.afcl[i].PersonalUseAmount.ToString());

                    //pdfFormFields.SetField("Air Fare Notes" + flightRow, CommonVariables.afcl[i].Notes); //commented for net6
                    fields.TryGetValue("Air Fare Notes" + flightRow, out toSet);
                    toSet.SetValue(CommonVariables.afcl[i].Notes);

                    flightRow++;
                }
                string flightCost = Convert.ToDouble(txtTotalFlight.Text).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                
                //pdfFormFields.SetField("Air Fare Total", flightCost); //commented for net6
                fields.TryGetValue("Air Fare Total", out toSet);
                toSet.SetValue(flightCost);

            }

            //Mileage
            if (CommonVariables.isMileage)
            {
                //pdfFormFields.SetField("Map Mileage", CommonVariables.micl.MapMileage.ToString()); //commented for net6
                fields.TryGetValue("Map Mileage", out toSet);
                toSet.SetValue(CommonVariables.micl.MapMileage.ToString());

                //pdfFormFields.SetField("Vicinity Mileage", CommonVariables.micl.VicinityMileage.ToString()); //commented for net6
                fields.TryGetValue("Vicinity Mileage", out toSet);
                toSet.SetValue(CommonVariables.micl.VicinityMileage.ToString());

                //pdfFormFields.SetField("Mileage Cost", CommonVariables.micl.TotalMileage.ToString("C", CultureInfo.CurrentCulture).Substring(1)); //commented for net6
                fields.TryGetValue("Mileage Cost", out toSet);
                toSet.SetValue(CommonVariables.micl.TotalMileage.ToString("C", CultureInfo.CurrentCulture).Substring(1));

                if (CommonVariables.micl.DistricticProvidedVehicle)
                {
                    //pdfFormFields.SetField("Provided Vehicle", "Yes"); //commented for net6
                    fields.TryGetValue("Provided Vehicle", out toSet);
                    toSet.SetValue("Yes");
                }
                else {
                    //pdfFormFields.SetField("Provided Vehicle", "No"); //commented for net6
                    fields.TryGetValue("Provided Vehicle", out toSet);
                    toSet.SetValue("No");

                    if (CommonVariables.micl.DirectorApprovedPersonal)
                    {
                        //pdfFormFields.SetField("Mileage Director Approval", "Yes"); //commented for net6
                        fields.TryGetValue("Mileage Director Approval", out toSet);
                        toSet.SetValue("Yes");
                    }
                    else {
                        //pdfFormFields.SetField("Mileage Director Approval", "No"); //commented for net6
                        fields.TryGetValue("Mileage Director Approval", out toSet);
                        toSet.SetValue("No");
                    }
                }
                //pdfFormFields.SetField("Mileage Notes", CommonVariables.micl.Notes); //commented for net6
                fields.TryGetValue("Mileage Notes", out toSet);
                toSet.SetValue(CommonVariables.micl.Notes);
            }

            //Other Expenses
            if (CommonVariables.isOtherExpenses)
            {
                int oxRow = 1;
                for (int i = 0; i < CommonVariables.oxcl.Count; i++)
                {
                    //pdfFormFields.SetField("ExpDescription" + oxRow, CommonVariables.oxcl[i].Description); //commented for net6
                    fields.TryGetValue("ExpDescription" + oxRow, out toSet);
                    toSet.SetValue(CommonVariables.oxcl[i].Description);

                    //pdfFormFields.SetField("ExpCost" + oxRow, CommonVariables.oxcl[i].Amount.ToString()); //commented for net6
                    fields.TryGetValue("ExpCost" + oxRow, out toSet);
                    toSet.SetValue(CommonVariables.oxcl[i].Amount.ToString());

                    //pdfFormFields.SetField("ExpNotes" + oxRow, CommonVariables.oxcl[i].Notes); //commented for net6
                    fields.TryGetValue("ExpNotes" + oxRow, out toSet);
                    toSet.SetValue(CommonVariables.oxcl[i].Notes);
                    
                    oxRow++;
                }
                string oeCost = Convert.ToDouble(txtTotalAmountExpenses.Text).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                
                //pdfFormFields.SetField("Other Expenses Total", oeCost); //commented for net6
                fields.TryGetValue("Other Expenses Total" + oxRow, out toSet);
                toSet.SetValue(oeCost);
            }

            //Tratel Totals
            
            //pdfFormFields.SetField("Travel Total Cost", CommonVariables.totalTravel.ToString("C", CultureInfo.CurrentCulture).Substring(1)); //commented for net6
            fields.TryGetValue("Travel Total Cost", out toSet);
            toSet.SetValue(CommonVariables.totalTravel.ToString("C", CultureInfo.CurrentCulture).Substring(1));

            //pdfFormFields.SetField("Reimbursement", CommonVariables.totalReimbursement.ToString("C", CultureInfo.CurrentCulture).Substring(1)); //commented for net6
            fields.TryGetValue("Reimbursement", out toSet);
            toSet.SetValue(CommonVariables.totalReimbursement.ToString("C", CultureInfo.CurrentCulture).Substring(1));

            //pdfFormFields.SetField("No Reimbursed", CommonVariables.totalNotReimbursement.ToString("C", CultureInfo.CurrentCulture).Substring(1)); //commented for net6
            fields.TryGetValue("No Reimbursed", out toSet);
            toSet.SetValue(CommonVariables.totalNotReimbursement.ToString("C", CultureInfo.CurrentCulture).Substring(1));

            //pdfFormFields.SetField("Date", DateTime.Today.ToShortDateString()); //commented for net6
            fields.TryGetValue("Date", out toSet);
            toSet.SetValue(DateTime.Today.ToShortDateString());

            //pdfStamper.Close();
            form.FlattenFields();
            pdfDoc.Close();
            localCon.Close();
        }

        private void saveTravel() {
            localCon.Open();
            Guid userID;

            if (CommonVariables.is_TPT && CommonVariables.tpt_Type == "Travel")
            {
                if (CommonVariables.isGroup)
                {
                    for (int j = 0; j < CommonVariables.usersID.Count; j++)
                    {
                        userID = new Guid(CommonVariables.usersID[j]);
                        try
                        {
                            SqlDataAdapter cmd = new SqlDataAdapter();
                            cmd.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Travel] (DepartureTime,DepartureDate,ReturnTime,ReturnDate,TravelEvent,TravelPurpose,Origin,Destination,TravelState,UserID,TotalTravelAmount,TotalTravelReimbursed,TotalTravelNoReimbursed,Melas,AirFare,Mileage,Registration,Lodging,CarRental,OtherExpenses,Notes) VALUES (@DepartureTime,@DepartureDate,@ReturnTime,@ReturnDate,@TravelEvent,@TravelPurpose,@Origin,@Destination,@TravelState,@UserID,@TotalTravelAmount,@TotalTravelReimbursed,@TotalTravelNoReimbursed,@Melas,@AirFare,@Mileage,@Registration,@Lodging,@CarRental,@OtherExpenses,@Notes)", localCon);
                            cmd.InsertCommand.Parameters.Add("@DepartureTime", SqlDbType.VarChar).Value = CommonVariables.travelDepartureTime;
                            cmd.InsertCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = CommonVariables.travelDepartureDate;
                            cmd.InsertCommand.Parameters.Add("@ReturnTime", SqlDbType.VarChar).Value = CommonVariables.travelReturnTime;
                            cmd.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = CommonVariables.travelReturnDate;
                            cmd.InsertCommand.Parameters.Add("@TravelEvent", SqlDbType.VarChar).Value = CommonVariables.travelEvent;
                            cmd.InsertCommand.Parameters.Add("@TravelPurpose", SqlDbType.VarChar).Value = CommonVariables.travelPurpose;
                            cmd.InsertCommand.Parameters.Add("@Origin", SqlDbType.VarChar).Value = CommonVariables.travelOrigin;
                            cmd.InsertCommand.Parameters.Add("@Destination", SqlDbType.VarChar).Value = CommonVariables.travelDestination;
                            cmd.InsertCommand.Parameters.Add("@TravelState", SqlDbType.VarChar).Value = CommonVariables.travelState;
                            cmd.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userID;
                            cmd.InsertCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = CommonVariables.totalTravel;
                            cmd.InsertCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = CommonVariables.totalReimbursement;
                            cmd.InsertCommand.Parameters.Add("@TotalTravelNoReimbursed", SqlDbType.Float).Value = CommonVariables.totalNotReimbursement;
                            cmd.InsertCommand.Parameters.Add("@Melas", SqlDbType.Bit).Value = CommonVariables.isMeals;
                            cmd.InsertCommand.Parameters.Add("@AirFare", SqlDbType.Bit).Value = CommonVariables.isAirFare;
                            cmd.InsertCommand.Parameters.Add("@Mileage", SqlDbType.Bit).Value = CommonVariables.isMileage;
                            cmd.InsertCommand.Parameters.Add("@Registration", SqlDbType.Bit).Value = CommonVariables.isRegistartion;
                            cmd.InsertCommand.Parameters.Add("@Lodging", SqlDbType.Bit).Value = CommonVariables.isLodging;
                            cmd.InsertCommand.Parameters.Add("@CarRental", SqlDbType.Bit).Value = CommonVariables.isCarRental;
                            cmd.InsertCommand.Parameters.Add("@OtherExpenses", SqlDbType.Bit).Value = CommonVariables.isOtherExpenses;
                            cmd.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.travelNotes;


                            int rows = cmd.InsertCommand.ExecuteNonQuery();
                            travelACC = CommonVariables.totalTravel;

                            if (rows > 0)
                            {


                                SqlCommand cmd1 = new SqlCommand("SELECT  [TravelID] FROM [TravelExpenses].[dbo].[Travel] where UserID = '" + userID + "' AND DepartureDate = '" + CommonVariables.travelDepartureDate + "' AND ReturnDate = '" + CommonVariables.travelReturnDate + "' AND TravelEvent = '" + CommonVariables.travelEvent + "' AND TravelPurpose = '" + CommonVariables.travelPurpose + "' AND Origin = '" + CommonVariables.travelOrigin + "' AND Destination = '" + CommonVariables.travelDestination + "' And TravelState = '" + CommonVariables.travelState + "' AND DepartureTime = '" + CommonVariables.travelDepartureTime + "'", localCon);
                                SqlDataReader dr = cmd1.ExecuteReader();
                                Guid travelID = new Guid();
                                while (dr.Read())
                                {
                                    travelID = new Guid(dr["TravelID"].ToString());
                                    travId = travelID;
                                }

                                dr.Close();

                                //putting the status of the travel
                                SqlDataAdapter travStat = new SqlDataAdapter();
                                travStat.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[TravelStatus] ([TravelID],[Status]) VALUES (@TravelID,@Status)", localCon);
                                travStat.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                travStat.InsertCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Pending";
                                travStat.InsertCommand.ExecuteNonQuery();


                                if (CommonVariables.isMeals)
                                {
                                    SqlDataAdapter cmdMeals = new SqlDataAdapter();
                                    cmdMeals.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Meals]([Breakfast],[Lunch],[Dinner],[ProvidedMeal],[TotalMeals],[TravelID],[Notes],[BreakfastPerDiemRate],[LunchPerDiemRate],[DinnerPerDiemRate],[TotalPerDiemRate],[PerDiemLoactionZipCode]) VALUES (@Breakfast,@Lunch,@Dinner,@ProvidedMeal,@TotalMeals,@TravelID,@Notes,@BreakfastPerDiemRate,@LunchPerDiemRate,@DinnerPerDiemRate,@TotalPerDiemRate,@PerDiemLoactionZipCode)", localCon);
                                    cmdMeals.InsertCommand.Parameters.Add("@Breakfast", SqlDbType.Int).Value = CommonVariables.mcl.Breakfast;
                                    cmdMeals.InsertCommand.Parameters.Add("@Lunch", SqlDbType.Int).Value = CommonVariables.mcl.Lunch;
                                    cmdMeals.InsertCommand.Parameters.Add("@Dinner", SqlDbType.Int).Value = CommonVariables.mcl.Dinner;
                                    cmdMeals.InsertCommand.Parameters.Add("@ProvidedMeal", SqlDbType.Bit).Value = CommonVariables.mcl.ProvidedMeals;
                                    cmdMeals.InsertCommand.Parameters.Add("@TotalMeals", SqlDbType.Float).Value = CommonVariables.mcl.MealsTotal;
                                    cmdMeals.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                    cmdMeals.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.mcl.Notes;
                                    cmdMeals.InsertCommand.Parameters.Add("@BreakfastPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.BreakfastPerDiemRate;
                                    cmdMeals.InsertCommand.Parameters.Add("@LunchPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.LunchPerDiemRate;
                                    cmdMeals.InsertCommand.Parameters.Add("@DinnerPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.DinnerPerDiemRate;
                                    cmdMeals.InsertCommand.Parameters.Add("@TotalPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.TotalMealsPerDiemRate;
                                    cmdMeals.InsertCommand.Parameters.Add("@PerDiemLoactionZipCode", SqlDbType.NVarChar).Value = CommonVariables.mcl.PerDiemLoactionZipCode;

                                    int ri = cmdMeals.InsertCommand.ExecuteNonQuery();
                                    Guid mealID = new Guid();
                                    if (ri > 0)
                                    {
                                        SqlCommand cmdMealsID = new SqlCommand("SELECT [MealsID] FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travelID + "'", localCon);
                                        SqlDataReader drMI = cmdMealsID.ExecuteReader();
                                        while (drMI.Read())
                                        {
                                            mealID = new Guid(drMI["MealsID"].ToString());
                                        }
                                        drMI.Close();

                                        for (int i = 0; i < CommonVariables.mdcl.Count; i++)
                                        {
                                            SqlDataAdapter cmdMealsDate = new SqlDataAdapter();
                                            cmdMealsDate.InsertCommand = new SqlCommand(" INSERT INTO [TravelExpenses].[dbo].[MealDate]([MealsID],[Date],[Breaksfast],[Lunch],[Dinner]) VALUES (@MealsID,@Date,@Breaksfast,@Lunch,@Dinner)", localCon);
                                            cmdMealsDate.InsertCommand.Parameters.Add("@MealsID", SqlDbType.UniqueIdentifier).Value = mealID;
                                            cmdMealsDate.InsertCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = CommonVariables.mdcl[i].Date.ToString();
                                            cmdMealsDate.InsertCommand.Parameters.Add("@Breaksfast", SqlDbType.Bit).Value = CommonVariables.mdcl[i].Breakfast;
                                            cmdMealsDate.InsertCommand.Parameters.Add("@Lunch", SqlDbType.Bit).Value = CommonVariables.mdcl[i].Lunch;
                                            cmdMealsDate.InsertCommand.Parameters.Add("@Dinner", SqlDbType.Bit).Value = CommonVariables.mdcl[i].Dinner;
                                            cmdMealsDate.InsertCommand.ExecuteNonQuery();
                                        }
                                    }
                                }

                                if (CommonVariables.isRegistartion)
                                {
                                    SqlDataAdapter cmdRegist = new SqlDataAdapter();
                                    cmdRegist.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Registration] ([RegistrationAMount],[DistrictPay],[TravelID],[Notes]) VALUES (@RegistrationAMount,@DistrictPay,@TravelID,@Notes)", localCon);
                                    cmdRegist.InsertCommand.Parameters.Add("@RegistrationAMount", SqlDbType.Float).Value = CommonVariables.rg.RegistrationAmount;
                                    cmdRegist.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.rg.DistrictPay;
                                    cmdRegist.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                    cmdRegist.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.rg.Notes;

                                    cmdRegist.InsertCommand.ExecuteNonQuery();
                                    trainingACC = CommonVariables.rg.RegistrationAmount;
                                    travelACC = CommonVariables.totalTravel - CommonVariables.rg.RegistrationAmount;
                                    if (travelACC < 0)
                                    {
                                        travelACC = travelACC * -1;
                                    }


                                }

                                if (CommonVariables.isLodging)
                                {
                                    for (int i = 0; i < CommonVariables.lcl.Count; i++)
                                    {
                                        SqlDataAdapter cmdLodg = new SqlDataAdapter();
                                        cmdLodg.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Lodging] ([FacilityName],[NumberOfNights],[CostPerNight],[TaxesAndFees],[DistrictPay],[DirectorApproved],[TravelID],[TotalLodging],[Notes],[TaxesAndFeesPerNight]) VALUES (@FacilityName,@NumberOfNights,@CostPerNight,@TaxesAndFees,@DistrictPay,@DirectorApproved,@TravelID,@TotalLodging,@Notes,@TaxesAndFeesPerNight)", localCon);
                                        cmdLodg.InsertCommand.Parameters.Add("@FacilityName", SqlDbType.VarChar).Value = CommonVariables.lcl[i].FacilityName;
                                        cmdLodg.InsertCommand.Parameters.Add("@NumberOfNights", SqlDbType.Int).Value = CommonVariables.lcl[i].NumberOfNights;
                                        cmdLodg.InsertCommand.Parameters.Add("@CostPerNight", SqlDbType.Float).Value = CommonVariables.lcl[i].CostPerNight;
                                        cmdLodg.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = CommonVariables.lcl[i].TaxesAndFees;
                                        cmdLodg.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.lcl[i].DistrictPay;
                                        cmdLodg.InsertCommand.Parameters.Add("@DirectorApproved", SqlDbType.Bit).Value = CommonVariables.lcl[i].DirectorApproved;
                                        cmdLodg.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                        cmdLodg.InsertCommand.Parameters.Add("@TotalLodging", SqlDbType.Float).Value = CommonVariables.lcl[i].TotalLodging;
                                        cmdLodg.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.lcl[i].Notes;
                                        cmdLodg.InsertCommand.Parameters.Add("@TaxesAndFeesPerNight", SqlDbType.Float).Value = CommonVariables.lcl[i].FeesPerNight;

                                        cmdLodg.InsertCommand.ExecuteNonQuery();

                                    }
                                }

                                if (CommonVariables.isCarRental)
                                {
                                    for (int i = 0; i < CommonVariables.crcl.Count; i++)
                                    {
                                        SqlDataAdapter cmdCarR = new SqlDataAdapter();
                                        cmdCarR.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[CarRental] ([PickUPDate],[DropOffDate],[CarType],[Company],[Days],[CostPerDay],[TaxesAndFees],[LDWInsuranse],[SupplementalInsurance],[ExtarInsurance],[ExtarInsuranceAmount],[DistrictPay],[PersonalUse],[PersonalAmount],[TotalCarRental],[TravelID],[Notes])VALUES (@PickUPDate,@DropOffDate,@CarType,@Company,@Days,@CostPerDay,@TaxesAndFees,@LDWInsuranse,@SupplementalInsurance,@ExtarInsurance,@ExtarInsuranceAmount,@DistrictPay,@PersonalUse,@PersonalAmount,@TotalCarRental,@TravelID,@Notes)", localCon);
                                        cmdCarR.InsertCommand.Parameters.Add("@PickUPDate", SqlDbType.DateTime).Value = CommonVariables.crcl[i].PickUpDate;
                                        cmdCarR.InsertCommand.Parameters.Add("@DropOffDate", SqlDbType.DateTime).Value = CommonVariables.crcl[i].DropOffDate;
                                        cmdCarR.InsertCommand.Parameters.Add("@CarType", SqlDbType.NVarChar).Value = CommonVariables.crcl[i].CarType;
                                        cmdCarR.InsertCommand.Parameters.Add("@Company", SqlDbType.NVarChar).Value = CommonVariables.crcl[i].Company;
                                        cmdCarR.InsertCommand.Parameters.Add("@Days", SqlDbType.Int).Value = CommonVariables.crcl[i].Days;
                                        cmdCarR.InsertCommand.Parameters.Add("@CostPerDay", SqlDbType.Float).Value = CommonVariables.crcl[i].CostPerDay;
                                        cmdCarR.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = CommonVariables.crcl[i].TaxesAndFees;
                                        cmdCarR.InsertCommand.Parameters.Add("@LDWInsuranse", SqlDbType.Float).Value = CommonVariables.crcl[i].LDWInsuranse;
                                        cmdCarR.InsertCommand.Parameters.Add("@SupplementalInsurance", SqlDbType.Float).Value = CommonVariables.crcl[i].SupplementalInsurance;
                                        cmdCarR.InsertCommand.Parameters.Add("@ExtarInsurance", SqlDbType.Bit).Value = CommonVariables.crcl[i].ExtraInsurance;
                                        cmdCarR.InsertCommand.Parameters.Add("@ExtarInsuranceAmount", SqlDbType.Float).Value = CommonVariables.crcl[i].ExtraInsuranceAmount;
                                        cmdCarR.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.crcl[i].DistrictPay;
                                        cmdCarR.InsertCommand.Parameters.Add("@PersonalUse", SqlDbType.Bit).Value = CommonVariables.crcl[i].PersonalUse;
                                        cmdCarR.InsertCommand.Parameters.Add("@PersonalAmount", SqlDbType.Float).Value = CommonVariables.crcl[i].PersonalUseAmount;
                                        cmdCarR.InsertCommand.Parameters.Add("@TotalCarRental", SqlDbType.Float).Value = CommonVariables.crcl[i].TotalCarRental;
                                        cmdCarR.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                        cmdCarR.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.crcl[i].Notes;

                                        cmdCarR.InsertCommand.ExecuteNonQuery();

                                    }
                                }

                                if (CommonVariables.isAirFare)
                                {
                                    for (int i = 0; i < CommonVariables.afcl.Count; i++)
                                    {
                                        SqlDataAdapter cmdAirFare = new SqlDataAdapter();
                                        cmdAirFare.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[AirFare] ([DepartureDate],[ReturnDate],[AirFareCost],[TaxesAndFees],[DistrictPay],[PersonalUse],[PersonalUseAmount],[AirFareTotal],[TravelID],[Notes]) VALUES(@DepartureDate,@ReturnDate,@AirFareCost,@TaxesAndFees,@DistrictPay,@PersonalUse,@PersonalUseAmount,@AirFareTotal,@TravelID,@Notes)", localCon);
                                        cmdAirFare.InsertCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = CommonVariables.afcl[i].DepartureDate;
                                        if (CommonVariables.afcl[i].ReturnDate != null)
                                        {
                                            cmdAirFare.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = CommonVariables.afcl[i].ReturnDate;
                                        }
                                        else
                                        {

                                            cmdAirFare.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = SqlDateTime.Null;
                                        }
                                        cmdAirFare.InsertCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = CommonVariables.afcl[i].AirFareCost;
                                        cmdAirFare.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = CommonVariables.afcl[i].TaxesAndFees;
                                        cmdAirFare.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.afcl[i].DistrictPay;
                                        cmdAirFare.InsertCommand.Parameters.Add("@PersonalUse", SqlDbType.Bit).Value = CommonVariables.afcl[i].PersonalUse;
                                        cmdAirFare.InsertCommand.Parameters.Add("@PersonalUseAmount", SqlDbType.Float).Value = CommonVariables.afcl[i].PersonalUseAmount;
                                        cmdAirFare.InsertCommand.Parameters.Add("@AirFareTotal", SqlDbType.Float).Value = CommonVariables.afcl[i].TotalAirFare;
                                        cmdAirFare.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                        cmdAirFare.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.afcl[i].Notes;

                                        cmdAirFare.InsertCommand.ExecuteNonQuery();
                                    }
                                }

                                if (CommonVariables.isMileage)
                                {
                                    SqlDataAdapter cmdMileage = new SqlDataAdapter();
                                    cmdMileage.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Mileage] ([DistrictVehicleProvided],[DirectorApprovedPersonal],[MapMileage],[VicinityMileage],[TravelID],[TotalMileage],[Notes]) VALUES (@DistrictVehicleProvided,@DirectorApprovedPersonal,@MapMileage,@VicinityMileage,@TravelID,@TotalMileage,@Notes)", localCon);
                                    cmdMileage.InsertCommand.Parameters.Add("@DistrictVehicleProvided", SqlDbType.Bit).Value = CommonVariables.micl.DistricticProvidedVehicle;
                                    if (!CommonVariables.micl.DistricticProvidedVehicle)
                                    {
                                        cmdMileage.InsertCommand.Parameters.Add("@DirectorApprovedPersonal", SqlDbType.Bit).Value = CommonVariables.micl.DirectorApprovedPersonal;
                                    }
                                    else
                                    {
                                        cmdMileage.InsertCommand.Parameters.Add("@DirectorApprovedPersonal", SqlDbType.Bit).Value = SqlDateTime.Null;
                                    }
                                    cmdMileage.InsertCommand.Parameters.Add("@MapMileage", SqlDbType.Float).Value = CommonVariables.micl.MapMileage;
                                    cmdMileage.InsertCommand.Parameters.Add("@VicinityMileage", SqlDbType.Float).Value = CommonVariables.micl.VicinityMileage;
                                    cmdMileage.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                    cmdMileage.InsertCommand.Parameters.Add("@TotalMileage", SqlDbType.Float).Value = CommonVariables.micl.TotalMileage;
                                    cmdMileage.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.micl.Notes;

                                    cmdMileage.InsertCommand.ExecuteNonQuery();

                                }

                                if (CommonVariables.isOtherExpenses)
                                {
                                    for (int i = 0; i < CommonVariables.oxcl.Count; i++)
                                    {
                                        SqlDataAdapter cmdOtherEx = new SqlDataAdapter();
                                        cmdOtherEx.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[OtherExpenses] ([Description],[Amount],[Prepaid],[TravelID],[Notes]) VALUES (@Description,@Amount,@Prepaid,@TravelID,@Notes)", localCon);
                                        cmdOtherEx.InsertCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = CommonVariables.oxcl[i].Description;
                                        cmdOtherEx.InsertCommand.Parameters.Add("@Amount", SqlDbType.Float).Value = CommonVariables.oxcl[i].Amount;
                                        cmdOtherEx.InsertCommand.Parameters.Add("@Prepaid", SqlDbType.Bit).Value = CommonVariables.oxcl[i].Prepaid;
                                        cmdOtherEx.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                        cmdOtherEx.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.oxcl[i].Notes;

                                        cmdOtherEx.InsertCommand.ExecuteNonQuery();
                                    }
                                }
                                
                                travelSaved = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    MessageBox.Show("Travel inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    userID = new Guid(CommonVariables.tpt_UserID);
                    try
                    {
                        SqlDataAdapter cmd = new SqlDataAdapter();
                        cmd.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Travel] (DepartureTime,DepartureDate,ReturnTime,ReturnDate,TravelEvent,TravelPurpose,Origin,Destination,TravelState,UserID,TotalTravelAmount,TotalTravelReimbursed,TotalTravelNoReimbursed,Melas,AirFare,Mileage,Registration,Lodging,CarRental,OtherExpenses,Notes) VALUES (@DepartureTime,@DepartureDate,@ReturnTime,@ReturnDate,@TravelEvent,@TravelPurpose,@Origin,@Destination,@TravelState,@UserID,@TotalTravelAmount,@TotalTravelReimbursed,@TotalTravelNoReimbursed,@Melas,@AirFare,@Mileage,@Registration,@Lodging,@CarRental,@OtherExpenses,@Notes)", localCon);
                        cmd.InsertCommand.Parameters.Add("@DepartureTime", SqlDbType.VarChar).Value = CommonVariables.travelDepartureTime;
                        cmd.InsertCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = CommonVariables.travelDepartureDate;
                        cmd.InsertCommand.Parameters.Add("@ReturnTime", SqlDbType.VarChar).Value = CommonVariables.travelReturnTime;
                        cmd.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = CommonVariables.travelReturnDate;
                        cmd.InsertCommand.Parameters.Add("@TravelEvent", SqlDbType.VarChar).Value = CommonVariables.travelEvent;
                        cmd.InsertCommand.Parameters.Add("@TravelPurpose", SqlDbType.VarChar).Value = CommonVariables.travelPurpose;
                        cmd.InsertCommand.Parameters.Add("@Origin", SqlDbType.VarChar).Value = CommonVariables.travelOrigin;
                        cmd.InsertCommand.Parameters.Add("@Destination", SqlDbType.VarChar).Value = CommonVariables.travelDestination;
                        cmd.InsertCommand.Parameters.Add("@TravelState", SqlDbType.VarChar).Value = CommonVariables.travelState;
                        cmd.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userID;
                        cmd.InsertCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = CommonVariables.totalTravel;
                        cmd.InsertCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = CommonVariables.totalReimbursement;
                        cmd.InsertCommand.Parameters.Add("@TotalTravelNoReimbursed", SqlDbType.Float).Value = CommonVariables.totalNotReimbursement;
                        cmd.InsertCommand.Parameters.Add("@Melas", SqlDbType.Bit).Value = CommonVariables.isMeals;
                        cmd.InsertCommand.Parameters.Add("@AirFare", SqlDbType.Bit).Value = CommonVariables.isAirFare;
                        cmd.InsertCommand.Parameters.Add("@Mileage", SqlDbType.Bit).Value = CommonVariables.isMileage;
                        cmd.InsertCommand.Parameters.Add("@Registration", SqlDbType.Bit).Value = CommonVariables.isRegistartion;
                        cmd.InsertCommand.Parameters.Add("@Lodging", SqlDbType.Bit).Value = CommonVariables.isLodging;
                        cmd.InsertCommand.Parameters.Add("@CarRental", SqlDbType.Bit).Value = CommonVariables.isCarRental;
                        cmd.InsertCommand.Parameters.Add("@OtherExpenses", SqlDbType.Bit).Value = CommonVariables.isOtherExpenses;
                        cmd.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.travelNotes;


                        int rows = cmd.InsertCommand.ExecuteNonQuery();
                        travelACC = CommonVariables.totalTravel;

                        if (rows > 0)
                        {


                            SqlCommand cmd1 = new SqlCommand("SELECT  [TravelID] FROM [TravelExpenses].[dbo].[Travel] where UserID = '" + userID + "' AND DepartureDate = '" + CommonVariables.travelDepartureDate + "' AND ReturnDate = '" + CommonVariables.travelReturnDate + "' AND TravelEvent = '" + CommonVariables.travelEvent + "' AND TravelPurpose = '" + CommonVariables.travelPurpose + "' AND Origin = '" + CommonVariables.travelOrigin + "' AND Destination = '" + CommonVariables.travelDestination + "' And TravelState = '" + CommonVariables.travelState + "' AND DepartureTime = '" + CommonVariables.travelDepartureTime + "'", localCon);
                            SqlDataReader dr = cmd1.ExecuteReader();
                            Guid travelID = new Guid();
                            while (dr.Read())
                            {
                                travelID = new Guid(dr["TravelID"].ToString());
                                travId = travelID;
                            }

                            dr.Close();

                            //putting the status of the travel
                            SqlDataAdapter travStat = new SqlDataAdapter();
                            travStat.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[TravelStatus] ([TravelID],[Status]) VALUES (@TravelID,@Status)", localCon);
                            travStat.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                            travStat.InsertCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Pending";
                            travStat.InsertCommand.ExecuteNonQuery();





                            if (CommonVariables.isMeals)
                            {
                                SqlDataAdapter cmdMeals = new SqlDataAdapter();
                                cmdMeals.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Meals]([Breakfast],[Lunch],[Dinner],[ProvidedMeal],[TotalMeals],[TravelID],[Notes],[BreakfastPerDiemRate],[LunchPerDiemRate],[DinnerPerDiemRate],[TotalPerDiemRate],[PerDiemLoactionZipCode]) VALUES (@Breakfast,@Lunch,@Dinner,@ProvidedMeal,@TotalMeals,@TravelID,@Notes,@BreakfastPerDiemRate,@LunchPerDiemRate,@DinnerPerDiemRate,@TotalPerDiemRate,@PerDiemLoactionZipCode)", localCon);
                                cmdMeals.InsertCommand.Parameters.Add("@Breakfast", SqlDbType.Int).Value = CommonVariables.mcl.Breakfast;
                                cmdMeals.InsertCommand.Parameters.Add("@Lunch", SqlDbType.Int).Value = CommonVariables.mcl.Lunch;
                                cmdMeals.InsertCommand.Parameters.Add("@Dinner", SqlDbType.Int).Value = CommonVariables.mcl.Dinner;
                                cmdMeals.InsertCommand.Parameters.Add("@ProvidedMeal", SqlDbType.Bit).Value = CommonVariables.mcl.ProvidedMeals;
                                cmdMeals.InsertCommand.Parameters.Add("@TotalMeals", SqlDbType.Float).Value = CommonVariables.mcl.MealsTotal;
                                cmdMeals.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                cmdMeals.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.mcl.Notes;
                                cmdMeals.InsertCommand.Parameters.Add("@BreakfastPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.BreakfastPerDiemRate;
                                cmdMeals.InsertCommand.Parameters.Add("@LunchPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.LunchPerDiemRate;
                                cmdMeals.InsertCommand.Parameters.Add("@DinnerPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.DinnerPerDiemRate;
                                cmdMeals.InsertCommand.Parameters.Add("@TotalPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.TotalMealsPerDiemRate;
                                cmdMeals.InsertCommand.Parameters.Add("@PerDiemLoactionZipCode", SqlDbType.NVarChar).Value = CommonVariables.mcl.PerDiemLoactionZipCode;

                                int ri = cmdMeals.InsertCommand.ExecuteNonQuery();
                                Guid mealID = new Guid();
                                if (ri > 0)
                                {
                                    SqlCommand cmdMealsID = new SqlCommand("SELECT [MealsID] FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travelID + "'", localCon);
                                    SqlDataReader drMI = cmdMealsID.ExecuteReader();
                                    while (drMI.Read())
                                    {
                                        mealID = new Guid(drMI["MealsID"].ToString());
                                    }
                                    drMI.Close();

                                    for (int i = 0; i < CommonVariables.mdcl.Count; i++)
                                    {
                                        SqlDataAdapter cmdMealsDate = new SqlDataAdapter();
                                        cmdMealsDate.InsertCommand = new SqlCommand(" INSERT INTO [TravelExpenses].[dbo].[MealDate]([MealsID],[Date],[Breaksfast],[Lunch],[Dinner]) VALUES (@MealsID,@Date,@Breaksfast,@Lunch,@Dinner)", localCon);
                                        cmdMealsDate.InsertCommand.Parameters.Add("@MealsID", SqlDbType.UniqueIdentifier).Value = mealID;
                                        cmdMealsDate.InsertCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = CommonVariables.mdcl[i].Date.ToString();
                                        cmdMealsDate.InsertCommand.Parameters.Add("@Breaksfast", SqlDbType.Bit).Value = CommonVariables.mdcl[i].Breakfast;
                                        cmdMealsDate.InsertCommand.Parameters.Add("@Lunch", SqlDbType.Bit).Value = CommonVariables.mdcl[i].Lunch;
                                        cmdMealsDate.InsertCommand.Parameters.Add("@Dinner", SqlDbType.Bit).Value = CommonVariables.mdcl[i].Dinner;
                                        cmdMealsDate.InsertCommand.ExecuteNonQuery();
                                    }
                                }
                            }

                            if (CommonVariables.isRegistartion)
                            {
                                SqlDataAdapter cmdRegist = new SqlDataAdapter();
                                cmdRegist.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Registration] ([RegistrationAMount],[DistrictPay],[TravelID],[Notes]) VALUES (@RegistrationAMount,@DistrictPay,@TravelID,@Notes)", localCon);
                                cmdRegist.InsertCommand.Parameters.Add("@RegistrationAMount", SqlDbType.Float).Value = CommonVariables.rg.RegistrationAmount;
                                cmdRegist.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.rg.DistrictPay;
                                cmdRegist.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                cmdRegist.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.rg.Notes;

                                cmdRegist.InsertCommand.ExecuteNonQuery();
                                trainingACC = CommonVariables.rg.RegistrationAmount;
                                travelACC = CommonVariables.totalTravel - CommonVariables.rg.RegistrationAmount;
                                if (travelACC < 0)
                                {
                                    travelACC = travelACC * -1;
                                }


                            }

                            if (CommonVariables.isLodging)
                            {
                                for (int i = 0; i < CommonVariables.lcl.Count; i++)
                                {
                                    SqlDataAdapter cmdLodg = new SqlDataAdapter();
                                    cmdLodg.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Lodging] ([FacilityName],[NumberOfNights],[CostPerNight],[TaxesAndFees],[DistrictPay],[DirectorApproved],[TravelID],[TotalLodging],[Notes],[TaxesAndFeesPerNight]) VALUES (@FacilityName,@NumberOfNights,@CostPerNight,@TaxesAndFees,@DistrictPay,@DirectorApproved,@TravelID,@TotalLodging,@Notes,@TaxesAndFeesPerNight)", localCon);
                                    cmdLodg.InsertCommand.Parameters.Add("@FacilityName", SqlDbType.VarChar).Value = CommonVariables.lcl[i].FacilityName;
                                    cmdLodg.InsertCommand.Parameters.Add("@NumberOfNights", SqlDbType.Int).Value = CommonVariables.lcl[i].NumberOfNights;
                                    cmdLodg.InsertCommand.Parameters.Add("@CostPerNight", SqlDbType.Float).Value = CommonVariables.lcl[i].CostPerNight;
                                    cmdLodg.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = CommonVariables.lcl[i].TaxesAndFees;
                                    cmdLodg.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.lcl[i].DistrictPay;
                                    cmdLodg.InsertCommand.Parameters.Add("@DirectorApproved", SqlDbType.Bit).Value = CommonVariables.lcl[i].DirectorApproved;
                                    cmdLodg.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                    cmdLodg.InsertCommand.Parameters.Add("@TotalLodging", SqlDbType.Float).Value = CommonVariables.lcl[i].TotalLodging;
                                    cmdLodg.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.lcl[i].Notes;
                                    cmdLodg.InsertCommand.Parameters.Add("@TaxesAndFeesPerNight", SqlDbType.Float).Value = CommonVariables.lcl[i].FeesPerNight;

                                    cmdLodg.InsertCommand.ExecuteNonQuery();

                                }
                            }

                            if (CommonVariables.isCarRental)
                            {
                                for (int i = 0; i < CommonVariables.crcl.Count; i++)
                                {
                                    SqlDataAdapter cmdCarR = new SqlDataAdapter();
                                    cmdCarR.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[CarRental] ([PickUPDate],[DropOffDate],[CarType],[Company],[Days],[CostPerDay],[TaxesAndFees],[LDWInsuranse],[SupplementalInsurance],[ExtarInsurance],[ExtarInsuranceAmount],[DistrictPay],[PersonalUse],[PersonalAmount],[TotalCarRental],[TravelID],[Notes])VALUES (@PickUPDate,@DropOffDate,@CarType,@Company,@Days,@CostPerDay,@TaxesAndFees,@LDWInsuranse,@SupplementalInsurance,@ExtarInsurance,@ExtarInsuranceAmount,@DistrictPay,@PersonalUse,@PersonalAmount,@TotalCarRental,@TravelID,@Notes)", localCon);
                                    cmdCarR.InsertCommand.Parameters.Add("@PickUPDate", SqlDbType.DateTime).Value = CommonVariables.crcl[i].PickUpDate;
                                    cmdCarR.InsertCommand.Parameters.Add("@DropOffDate", SqlDbType.DateTime).Value = CommonVariables.crcl[i].DropOffDate;
                                    cmdCarR.InsertCommand.Parameters.Add("@CarType", SqlDbType.NVarChar).Value = CommonVariables.crcl[i].CarType;
                                    cmdCarR.InsertCommand.Parameters.Add("@Company", SqlDbType.NVarChar).Value = CommonVariables.crcl[i].Company;
                                    cmdCarR.InsertCommand.Parameters.Add("@Days", SqlDbType.Int).Value = CommonVariables.crcl[i].Days;
                                    cmdCarR.InsertCommand.Parameters.Add("@CostPerDay", SqlDbType.Float).Value = CommonVariables.crcl[i].CostPerDay;
                                    cmdCarR.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = CommonVariables.crcl[i].TaxesAndFees;
                                    cmdCarR.InsertCommand.Parameters.Add("@LDWInsuranse", SqlDbType.Float).Value = CommonVariables.crcl[i].LDWInsuranse;
                                    cmdCarR.InsertCommand.Parameters.Add("@SupplementalInsurance", SqlDbType.Float).Value = CommonVariables.crcl[i].SupplementalInsurance;
                                    cmdCarR.InsertCommand.Parameters.Add("@ExtarInsurance", SqlDbType.Bit).Value = CommonVariables.crcl[i].ExtraInsurance;
                                    cmdCarR.InsertCommand.Parameters.Add("@ExtarInsuranceAmount", SqlDbType.Float).Value = CommonVariables.crcl[i].ExtraInsuranceAmount;
                                    cmdCarR.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.crcl[i].DistrictPay;
                                    cmdCarR.InsertCommand.Parameters.Add("@PersonalUse", SqlDbType.Bit).Value = CommonVariables.crcl[i].PersonalUse;
                                    cmdCarR.InsertCommand.Parameters.Add("@PersonalAmount", SqlDbType.Float).Value = CommonVariables.crcl[i].PersonalUseAmount;
                                    cmdCarR.InsertCommand.Parameters.Add("@TotalCarRental", SqlDbType.Float).Value = CommonVariables.crcl[i].TotalCarRental;
                                    cmdCarR.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                    cmdCarR.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.crcl[i].Notes;

                                    cmdCarR.InsertCommand.ExecuteNonQuery();

                                }
                            }

                            if (CommonVariables.isAirFare)
                            {
                                for (int i = 0; i < CommonVariables.afcl.Count; i++)
                                {
                                    SqlDataAdapter cmdAirFare = new SqlDataAdapter();
                                    cmdAirFare.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[AirFare] ([DepartureDate],[ReturnDate],[AirFareCost],[TaxesAndFees],[DistrictPay],[PersonalUse],[PersonalUseAmount],[AirFareTotal],[TravelID],[Notes]) VALUES(@DepartureDate,@ReturnDate,@AirFareCost,@TaxesAndFees,@DistrictPay,@PersonalUse,@PersonalUseAmount,@AirFareTotal,@TravelID,@Notes)", localCon);
                                    cmdAirFare.InsertCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = CommonVariables.afcl[i].DepartureDate;
                                    if (CommonVariables.afcl[i].ReturnDate != null)
                                    {
                                        cmdAirFare.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = CommonVariables.afcl[i].ReturnDate;
                                    }
                                    else
                                    {

                                        cmdAirFare.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = SqlDateTime.Null;
                                    }
                                    cmdAirFare.InsertCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = CommonVariables.afcl[i].AirFareCost;
                                    cmdAirFare.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = CommonVariables.afcl[i].TaxesAndFees;
                                    cmdAirFare.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.afcl[i].DistrictPay;
                                    cmdAirFare.InsertCommand.Parameters.Add("@PersonalUse", SqlDbType.Bit).Value = CommonVariables.afcl[i].PersonalUse;
                                    cmdAirFare.InsertCommand.Parameters.Add("@PersonalUseAmount", SqlDbType.Float).Value = CommonVariables.afcl[i].PersonalUseAmount;
                                    cmdAirFare.InsertCommand.Parameters.Add("@AirFareTotal", SqlDbType.Float).Value = CommonVariables.afcl[i].TotalAirFare;
                                    cmdAirFare.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                    cmdAirFare.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.afcl[i].Notes;

                                    cmdAirFare.InsertCommand.ExecuteNonQuery();
                                }
                            }

                            if (CommonVariables.isMileage)
                            {
                                SqlDataAdapter cmdMileage = new SqlDataAdapter();
                                cmdMileage.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Mileage] ([DistrictVehicleProvided],[DirectorApprovedPersonal],[MapMileage],[VicinityMileage],[TravelID],[TotalMileage],[Notes]) VALUES (@DistrictVehicleProvided,@DirectorApprovedPersonal,@MapMileage,@VicinityMileage,@TravelID,@TotalMileage,@Notes)", localCon);
                                cmdMileage.InsertCommand.Parameters.Add("@DistrictVehicleProvided", SqlDbType.Bit).Value = CommonVariables.micl.DistricticProvidedVehicle;
                                if (!CommonVariables.micl.DistricticProvidedVehicle)
                                {
                                    cmdMileage.InsertCommand.Parameters.Add("@DirectorApprovedPersonal", SqlDbType.Bit).Value = CommonVariables.micl.DirectorApprovedPersonal;
                                }
                                else
                                {
                                    cmdMileage.InsertCommand.Parameters.Add("@DirectorApprovedPersonal", SqlDbType.Bit).Value = SqlDateTime.Null;
                                }
                                cmdMileage.InsertCommand.Parameters.Add("@MapMileage", SqlDbType.Float).Value = CommonVariables.micl.MapMileage;
                                cmdMileage.InsertCommand.Parameters.Add("@VicinityMileage", SqlDbType.Float).Value = CommonVariables.micl.VicinityMileage;
                                cmdMileage.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                cmdMileage.InsertCommand.Parameters.Add("@TotalMileage", SqlDbType.Float).Value = CommonVariables.micl.TotalMileage;
                                cmdMileage.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.micl.Notes;

                                cmdMileage.InsertCommand.ExecuteNonQuery();

                            }

                            if (CommonVariables.isOtherExpenses)
                            {
                                for (int i = 0; i < CommonVariables.oxcl.Count; i++)
                                {
                                    SqlDataAdapter cmdOtherEx = new SqlDataAdapter();
                                    cmdOtherEx.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[OtherExpenses] ([Description],[Amount],[Prepaid],[TravelID],[Notes]) VALUES (@Description,@Amount,@Prepaid,@TravelID,@Notes)", localCon);
                                    cmdOtherEx.InsertCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = CommonVariables.oxcl[i].Description;
                                    cmdOtherEx.InsertCommand.Parameters.Add("@Amount", SqlDbType.Float).Value = CommonVariables.oxcl[i].Amount;
                                    cmdOtherEx.InsertCommand.Parameters.Add("@Prepaid", SqlDbType.Bit).Value = CommonVariables.oxcl[i].Prepaid;
                                    cmdOtherEx.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                    cmdOtherEx.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.oxcl[i].Notes;

                                    cmdOtherEx.InsertCommand.ExecuteNonQuery();
                                }
                            }
                            localCon.Close();
                            travelSaved = true;
                            MessageBox.Show("Travel inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
            else
            {
                userID = new Guid(CommonVariables.user);
                try
                {
                    SqlDataAdapter cmd = new SqlDataAdapter();
                    cmd.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Travel] (DepartureTime,DepartureDate,ReturnTime,ReturnDate,TravelEvent,TravelPurpose,Origin,Destination,TravelState,UserID,TotalTravelAmount,TotalTravelReimbursed,TotalTravelNoReimbursed,Melas,AirFare,Mileage,Registration,Lodging,CarRental,OtherExpenses,Notes) VALUES (@DepartureTime,@DepartureDate,@ReturnTime,@ReturnDate,@TravelEvent,@TravelPurpose,@Origin,@Destination,@TravelState,@UserID,@TotalTravelAmount,@TotalTravelReimbursed,@TotalTravelNoReimbursed,@Melas,@AirFare,@Mileage,@Registration,@Lodging,@CarRental,@OtherExpenses,@Notes)", localCon);
                    cmd.InsertCommand.Parameters.Add("@DepartureTime", SqlDbType.VarChar).Value = CommonVariables.travelDepartureTime;
                    cmd.InsertCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = CommonVariables.travelDepartureDate;
                    cmd.InsertCommand.Parameters.Add("@ReturnTime", SqlDbType.VarChar).Value = CommonVariables.travelReturnTime;
                    cmd.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = CommonVariables.travelReturnDate;
                    cmd.InsertCommand.Parameters.Add("@TravelEvent", SqlDbType.VarChar).Value = CommonVariables.travelEvent;
                    cmd.InsertCommand.Parameters.Add("@TravelPurpose", SqlDbType.VarChar).Value = CommonVariables.travelPurpose;
                    cmd.InsertCommand.Parameters.Add("@Origin", SqlDbType.VarChar).Value = CommonVariables.travelOrigin;
                    cmd.InsertCommand.Parameters.Add("@Destination", SqlDbType.VarChar).Value = CommonVariables.travelDestination;
                    cmd.InsertCommand.Parameters.Add("@TravelState", SqlDbType.VarChar).Value = CommonVariables.travelState;
                    cmd.InsertCommand.Parameters.Add("@UserID", SqlDbType.UniqueIdentifier).Value = userID;
                    cmd.InsertCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = CommonVariables.totalTravel;
                    cmd.InsertCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = CommonVariables.totalReimbursement;
                    cmd.InsertCommand.Parameters.Add("@TotalTravelNoReimbursed", SqlDbType.Float).Value = CommonVariables.totalNotReimbursement;
                    cmd.InsertCommand.Parameters.Add("@Melas", SqlDbType.Bit).Value = CommonVariables.isMeals;
                    cmd.InsertCommand.Parameters.Add("@AirFare", SqlDbType.Bit).Value = CommonVariables.isAirFare;
                    cmd.InsertCommand.Parameters.Add("@Mileage", SqlDbType.Bit).Value = CommonVariables.isMileage;
                    cmd.InsertCommand.Parameters.Add("@Registration", SqlDbType.Bit).Value = CommonVariables.isRegistartion;
                    cmd.InsertCommand.Parameters.Add("@Lodging", SqlDbType.Bit).Value = CommonVariables.isLodging;
                    cmd.InsertCommand.Parameters.Add("@CarRental", SqlDbType.Bit).Value = CommonVariables.isCarRental;
                    cmd.InsertCommand.Parameters.Add("@OtherExpenses", SqlDbType.Bit).Value = CommonVariables.isOtherExpenses;
                    cmd.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.travelNotes;


                    int rows = cmd.InsertCommand.ExecuteNonQuery();
                    travelACC = CommonVariables.totalTravel;

                    if (rows > 0)
                    {

                        string idForPDFView = "";

                        SqlCommand cmd1 = new SqlCommand("SELECT  [TravelID] FROM [TravelExpenses].[dbo].[Travel] where UserID = '" + userID + "' AND DepartureDate = '" + CommonVariables.travelDepartureDate + "' AND ReturnDate = '" + CommonVariables.travelReturnDate + "' AND TravelEvent = '" + CommonVariables.travelEvent + "' AND TravelPurpose = '" + CommonVariables.travelPurpose + "' AND Origin = '" + CommonVariables.travelOrigin + "' AND Destination = '" + CommonVariables.travelDestination + "' And TravelState = '" + CommonVariables.travelState + "' AND DepartureTime = '" + CommonVariables.travelDepartureTime + "'", localCon);
                        SqlDataReader dr = cmd1.ExecuteReader();
                        Guid travelID = new Guid();
                        while (dr.Read())
                        {
                            travelID = new Guid(dr["TravelID"].ToString());
                            travId = travelID;

                            //setting the variable for pdf viewer
                            idForPDFView = dr["TravelID"].ToString();
                        }

                        dr.Close();

                        //setting common variable for PDF Viewer
                        CommonVariables.idForPDFViewer = idForPDFView;

                        //putting the status of the travel
                        SqlDataAdapter travStat = new SqlDataAdapter();
                        travStat.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[TravelStatus] ([TravelID],[Status]) VALUES (@TravelID,@Status)", localCon);
                        travStat.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                        travStat.InsertCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = "Pending";
                        travStat.InsertCommand.ExecuteNonQuery();





                        if (CommonVariables.isMeals)
                        {
                            SqlDataAdapter cmdMeals = new SqlDataAdapter();
                            cmdMeals.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Meals]([Breakfast],[Lunch],[Dinner],[ProvidedMeal],[TotalMeals],[TravelID],[Notes],[BreakfastPerDiemRate],[LunchPerDiemRate],[DinnerPerDiemRate],[TotalPerDiemRate],[PerDiemLoactionZipCode]) VALUES (@Breakfast,@Lunch,@Dinner,@ProvidedMeal,@TotalMeals,@TravelID,@Notes,@BreakfastPerDiemRate,@LunchPerDiemRate,@DinnerPerDiemRate,@TotalPerDiemRate,@PerDiemLoactionZipCode)", localCon);
                            cmdMeals.InsertCommand.Parameters.Add("@Breakfast", SqlDbType.Int).Value = CommonVariables.mcl.Breakfast;
                            cmdMeals.InsertCommand.Parameters.Add("@Lunch", SqlDbType.Int).Value = CommonVariables.mcl.Lunch;
                            cmdMeals.InsertCommand.Parameters.Add("@Dinner", SqlDbType.Int).Value = CommonVariables.mcl.Dinner;
                            cmdMeals.InsertCommand.Parameters.Add("@ProvidedMeal", SqlDbType.Bit).Value = CommonVariables.mcl.ProvidedMeals;
                            cmdMeals.InsertCommand.Parameters.Add("@TotalMeals", SqlDbType.Float).Value = CommonVariables.mcl.MealsTotal;
                            cmdMeals.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                            cmdMeals.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.mcl.Notes;
                            cmdMeals.InsertCommand.Parameters.Add("@BreakfastPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.BreakfastPerDiemRate;
                            cmdMeals.InsertCommand.Parameters.Add("@LunchPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.LunchPerDiemRate;
                            cmdMeals.InsertCommand.Parameters.Add("@DinnerPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.DinnerPerDiemRate;
                            cmdMeals.InsertCommand.Parameters.Add("@TotalPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.TotalMealsPerDiemRate;
                            cmdMeals.InsertCommand.Parameters.Add("@PerDiemLoactionZipCode", SqlDbType.NVarChar).Value = CommonVariables.mcl.PerDiemLoactionZipCode;

                            int ri = cmdMeals.InsertCommand.ExecuteNonQuery();
                            Guid mealID = new Guid();
                            if (ri > 0)
                            {
                                SqlCommand cmdMealsID = new SqlCommand("SELECT [MealsID] FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travelID + "'", localCon);
                                SqlDataReader drMI = cmdMealsID.ExecuteReader();
                                while (drMI.Read())
                                {
                                    mealID = new Guid(drMI["MealsID"].ToString());
                                }
                                drMI.Close();

                                for (int i = 0; i < CommonVariables.mdcl.Count; i++)
                                {
                                    SqlDataAdapter cmdMealsDate = new SqlDataAdapter();
                                    cmdMealsDate.InsertCommand = new SqlCommand(" INSERT INTO [TravelExpenses].[dbo].[MealDate]([MealsID],[Date],[Breaksfast],[Lunch],[Dinner]) VALUES (@MealsID,@Date,@Breaksfast,@Lunch,@Dinner)", localCon);
                                    cmdMealsDate.InsertCommand.Parameters.Add("@MealsID", SqlDbType.UniqueIdentifier).Value = mealID;
                                    cmdMealsDate.InsertCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = CommonVariables.mdcl[i].Date.ToString();
                                    cmdMealsDate.InsertCommand.Parameters.Add("@Breaksfast", SqlDbType.Bit).Value = CommonVariables.mdcl[i].Breakfast;
                                    cmdMealsDate.InsertCommand.Parameters.Add("@Lunch", SqlDbType.Bit).Value = CommonVariables.mdcl[i].Lunch;
                                    cmdMealsDate.InsertCommand.Parameters.Add("@Dinner", SqlDbType.Bit).Value = CommonVariables.mdcl[i].Dinner;
                                    cmdMealsDate.InsertCommand.ExecuteNonQuery();
                                }
                            }
                        }

                        if (CommonVariables.isRegistartion)
                        {
                            SqlDataAdapter cmdRegist = new SqlDataAdapter();
                            cmdRegist.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Registration] ([RegistrationAMount],[DistrictPay],[TravelID],[Notes]) VALUES (@RegistrationAMount,@DistrictPay,@TravelID,@Notes)", localCon);
                            cmdRegist.InsertCommand.Parameters.Add("@RegistrationAMount", SqlDbType.Float).Value = CommonVariables.rg.RegistrationAmount;
                            cmdRegist.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.rg.DistrictPay;
                            cmdRegist.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                            cmdRegist.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.rg.Notes;

                            cmdRegist.InsertCommand.ExecuteNonQuery();
                            trainingACC = CommonVariables.rg.RegistrationAmount;
                            travelACC = CommonVariables.totalTravel - CommonVariables.rg.RegistrationAmount;
                            if (travelACC < 0)
                            {
                                travelACC = travelACC * -1;
                            }


                        }

                        if (CommonVariables.isLodging)
                        {
                            for (int i = 0; i < CommonVariables.lcl.Count; i++)
                            {
                                SqlDataAdapter cmdLodg = new SqlDataAdapter();
                                cmdLodg.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Lodging] ([FacilityName],[NumberOfNights],[CostPerNight],[TaxesAndFees],[DistrictPay],[DirectorApproved],[TravelID],[TotalLodging],[Notes],[TaxesAndFeesPerNight]) VALUES (@FacilityName,@NumberOfNights,@CostPerNight,@TaxesAndFees,@DistrictPay,@DirectorApproved,@TravelID,@TotalLodging,@Notes,@TaxesAndFeesPerNight)", localCon);
                                cmdLodg.InsertCommand.Parameters.Add("@FacilityName", SqlDbType.VarChar).Value = CommonVariables.lcl[i].FacilityName;
                                cmdLodg.InsertCommand.Parameters.Add("@NumberOfNights", SqlDbType.Int).Value = CommonVariables.lcl[i].NumberOfNights;
                                cmdLodg.InsertCommand.Parameters.Add("@CostPerNight", SqlDbType.Float).Value = CommonVariables.lcl[i].CostPerNight;
                                cmdLodg.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = CommonVariables.lcl[i].TaxesAndFees;
                                cmdLodg.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.lcl[i].DistrictPay;
                                cmdLodg.InsertCommand.Parameters.Add("@DirectorApproved", SqlDbType.Bit).Value = CommonVariables.lcl[i].DirectorApproved;
                                cmdLodg.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                cmdLodg.InsertCommand.Parameters.Add("@TotalLodging", SqlDbType.Float).Value = CommonVariables.lcl[i].TotalLodging;
                                cmdLodg.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.lcl[i].Notes;
                                cmdLodg.InsertCommand.Parameters.Add("@TaxesAndFeesPerNight", SqlDbType.Float).Value = CommonVariables.lcl[i].FeesPerNight;

                                cmdLodg.InsertCommand.ExecuteNonQuery();

                            }
                        }

                        if (CommonVariables.isCarRental)
                        {
                            for (int i = 0; i < CommonVariables.crcl.Count; i++)
                            {
                                SqlDataAdapter cmdCarR = new SqlDataAdapter();
                                cmdCarR.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[CarRental] ([PickUPDate],[DropOffDate],[CarType],[Company],[Days],[CostPerDay],[TaxesAndFees],[LDWInsuranse],[SupplementalInsurance],[ExtarInsurance],[ExtarInsuranceAmount],[DistrictPay],[PersonalUse],[PersonalAmount],[TotalCarRental],[TravelID],[Notes])VALUES (@PickUPDate,@DropOffDate,@CarType,@Company,@Days,@CostPerDay,@TaxesAndFees,@LDWInsuranse,@SupplementalInsurance,@ExtarInsurance,@ExtarInsuranceAmount,@DistrictPay,@PersonalUse,@PersonalAmount,@TotalCarRental,@TravelID,@Notes)", localCon);
                                cmdCarR.InsertCommand.Parameters.Add("@PickUPDate", SqlDbType.DateTime).Value = CommonVariables.crcl[i].PickUpDate;
                                cmdCarR.InsertCommand.Parameters.Add("@DropOffDate", SqlDbType.DateTime).Value = CommonVariables.crcl[i].DropOffDate;
                                cmdCarR.InsertCommand.Parameters.Add("@CarType", SqlDbType.NVarChar).Value = CommonVariables.crcl[i].CarType;
                                cmdCarR.InsertCommand.Parameters.Add("@Company", SqlDbType.NVarChar).Value = CommonVariables.crcl[i].Company;
                                cmdCarR.InsertCommand.Parameters.Add("@Days", SqlDbType.Int).Value = CommonVariables.crcl[i].Days;
                                cmdCarR.InsertCommand.Parameters.Add("@CostPerDay", SqlDbType.Float).Value = CommonVariables.crcl[i].CostPerDay;
                                cmdCarR.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = CommonVariables.crcl[i].TaxesAndFees;
                                cmdCarR.InsertCommand.Parameters.Add("@LDWInsuranse", SqlDbType.Float).Value = CommonVariables.crcl[i].LDWInsuranse;
                                cmdCarR.InsertCommand.Parameters.Add("@SupplementalInsurance", SqlDbType.Float).Value = CommonVariables.crcl[i].SupplementalInsurance;
                                cmdCarR.InsertCommand.Parameters.Add("@ExtarInsurance", SqlDbType.Bit).Value = CommonVariables.crcl[i].ExtraInsurance;
                                cmdCarR.InsertCommand.Parameters.Add("@ExtarInsuranceAmount", SqlDbType.Float).Value = CommonVariables.crcl[i].ExtraInsuranceAmount;
                                cmdCarR.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.crcl[i].DistrictPay;
                                cmdCarR.InsertCommand.Parameters.Add("@PersonalUse", SqlDbType.Bit).Value = CommonVariables.crcl[i].PersonalUse;
                                cmdCarR.InsertCommand.Parameters.Add("@PersonalAmount", SqlDbType.Float).Value = CommonVariables.crcl[i].PersonalUseAmount;
                                cmdCarR.InsertCommand.Parameters.Add("@TotalCarRental", SqlDbType.Float).Value = CommonVariables.crcl[i].TotalCarRental;
                                cmdCarR.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                cmdCarR.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.crcl[i].Notes;

                                cmdCarR.InsertCommand.ExecuteNonQuery();

                            }
                        }

                        if (CommonVariables.isAirFare)
                        {
                            for (int i = 0; i < CommonVariables.afcl.Count; i++)
                            {
                                SqlDataAdapter cmdAirFare = new SqlDataAdapter();
                                cmdAirFare.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[AirFare] ([DepartureDate],[ReturnDate],[AirFareCost],[TaxesAndFees],[DistrictPay],[PersonalUse],[PersonalUseAmount],[AirFareTotal],[TravelID],[Notes]) VALUES(@DepartureDate,@ReturnDate,@AirFareCost,@TaxesAndFees,@DistrictPay,@PersonalUse,@PersonalUseAmount,@AirFareTotal,@TravelID,@Notes)", localCon);
                                cmdAirFare.InsertCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = CommonVariables.afcl[i].DepartureDate;
                                if (CommonVariables.afcl[i].ReturnDate != null)
                                {
                                    cmdAirFare.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = CommonVariables.afcl[i].ReturnDate;
                                }
                                else
                                {

                                    cmdAirFare.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = SqlDateTime.Null;
                                }
                                cmdAirFare.InsertCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = CommonVariables.afcl[i].AirFareCost;
                                cmdAirFare.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = CommonVariables.afcl[i].TaxesAndFees;
                                cmdAirFare.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.afcl[i].DistrictPay;
                                cmdAirFare.InsertCommand.Parameters.Add("@PersonalUse", SqlDbType.Bit).Value = CommonVariables.afcl[i].PersonalUse;
                                cmdAirFare.InsertCommand.Parameters.Add("@PersonalUseAmount", SqlDbType.Float).Value = CommonVariables.afcl[i].PersonalUseAmount;
                                cmdAirFare.InsertCommand.Parameters.Add("@AirFareTotal", SqlDbType.Float).Value = CommonVariables.afcl[i].TotalAirFare;
                                cmdAirFare.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                cmdAirFare.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.afcl[i].Notes;

                                cmdAirFare.InsertCommand.ExecuteNonQuery();
                            }
                        }

                        if (CommonVariables.isMileage)
                        {
                            SqlDataAdapter cmdMileage = new SqlDataAdapter();
                            cmdMileage.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Mileage] ([DistrictVehicleProvided],[DirectorApprovedPersonal],[MapMileage],[VicinityMileage],[TravelID],[TotalMileage],[Notes]) VALUES (@DistrictVehicleProvided,@DirectorApprovedPersonal,@MapMileage,@VicinityMileage,@TravelID,@TotalMileage,@Notes)", localCon);
                            cmdMileage.InsertCommand.Parameters.Add("@DistrictVehicleProvided", SqlDbType.Bit).Value = CommonVariables.micl.DistricticProvidedVehicle;
                            if (!CommonVariables.micl.DistricticProvidedVehicle)
                            {
                                cmdMileage.InsertCommand.Parameters.Add("@DirectorApprovedPersonal", SqlDbType.Bit).Value = CommonVariables.micl.DirectorApprovedPersonal;
                            }
                            else
                            {
                                cmdMileage.InsertCommand.Parameters.Add("@DirectorApprovedPersonal", SqlDbType.Bit).Value = SqlDateTime.Null;
                            }
                            cmdMileage.InsertCommand.Parameters.Add("@MapMileage", SqlDbType.Float).Value = CommonVariables.micl.MapMileage;
                            cmdMileage.InsertCommand.Parameters.Add("@VicinityMileage", SqlDbType.Float).Value = CommonVariables.micl.VicinityMileage;
                            cmdMileage.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                            cmdMileage.InsertCommand.Parameters.Add("@TotalMileage", SqlDbType.Float).Value = CommonVariables.micl.TotalMileage;
                            cmdMileage.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.micl.Notes;

                            cmdMileage.InsertCommand.ExecuteNonQuery();

                        }

                        if (CommonVariables.isOtherExpenses)
                        {
                            for (int i = 0; i < CommonVariables.oxcl.Count; i++)
                            {
                                SqlDataAdapter cmdOtherEx = new SqlDataAdapter();
                                cmdOtherEx.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[OtherExpenses] ([Description],[Amount],[Prepaid],[TravelID],[Notes]) VALUES (@Description,@Amount,@Prepaid,@TravelID,@Notes)", localCon);
                                cmdOtherEx.InsertCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = CommonVariables.oxcl[i].Description;
                                cmdOtherEx.InsertCommand.Parameters.Add("@Amount", SqlDbType.Float).Value = CommonVariables.oxcl[i].Amount;
                                cmdOtherEx.InsertCommand.Parameters.Add("@Prepaid", SqlDbType.Bit).Value = CommonVariables.oxcl[i].Prepaid;
                                cmdOtherEx.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travelID;
                                cmdOtherEx.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.oxcl[i].Notes;

                                cmdOtherEx.InsertCommand.ExecuteNonQuery();
                            }
                        }
                        localCon.Close();
                        travelSaved = true;
                        MessageBox.Show("Travel inserted Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            localCon.Close();
        }

        private void tsmSummarizedPDF_Click(object sender, EventArgs e)
        {
            if (CommonVariables.addingItems)
            {
                if (travelUpdate)
                {
                    generateSummarizedPDFUp();
                }
                else
                {
                    addTravelItems();
                    generateSummarizedPDFUp();
                }
            }
            else
            {
                if (travelSaved)
                {
                    generateSummarizedPDF();
                }
                else
                {
                    saveTravel();
                    generateSummarizedPDF();
                }
            }

            if (!tsmDetailed.Enabled)
            {
                btnSaveSplitTravel.Enabled = false;
            }
            else {
                tsmSummarizedPDF.Enabled = false;
            }
            btnBackSummary.Enabled = false;
        }

        private void tsmDetailed_Click(object sender, EventArgs e)
        {
            if (CommonVariables.addingItems)
            {
                if (travelUpdate)
                {
                    generateDetailPDFUp();
                }
                else {
                    addTravelItems();
                    generateDetailPDFUp();
                }
            }
            else
            {
                if (travelSaved)
                {
                    generateDetailPDF();
                }
                else
                {
                    saveTravel();
                    generateDetailPDF();
                }
            }

            if (!tsmSummarizedPDF.Enabled)
            {
                btnSaveSplitTravel.Enabled = false;
            }
            else {
                tsmDetailed.Enabled = false;
            }
            btnBackSummary.Enabled = false;
        }

        private void addTravelItems() {

             travId = new Guid(CommonVariables.addingTravelID);
            double totalTravel = 0;
            double notReimbursement = 0;
            double totalReimbursement = 0;
            
            


            localCon.Open();
            if (CommonVariables.isMeals)
            {
                SqlDataAdapter cmdMeals = new SqlDataAdapter();
                cmdMeals.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Meals]([Breakfast],[Lunch],[Dinner],[ProvidedMeal],[TotalMeals],[TravelID],[Notes],[BreakfastPerDiemRate],[LunchPerDiemRate],[DinnerPerDiemRate],[TotalPerDiemRate],[PerDiemLoactionZipCode]) VALUES (@Breakfast,@Lunch,@Dinner,@ProvidedMeal,@TotalMeals,@TravelID,@Notes,@BreakfastPerDiemRate,@LunchPerDiemRate,@DinnerPerDiemRate,@TotalPerDiemRate,@PerDiemLoactionZipCode)", localCon);
                cmdMeals.InsertCommand.Parameters.Add("@Breakfast", SqlDbType.Int).Value = CommonVariables.mcl.Breakfast;
                cmdMeals.InsertCommand.Parameters.Add("@Lunch", SqlDbType.Int).Value = CommonVariables.mcl.Lunch;
                cmdMeals.InsertCommand.Parameters.Add("@Dinner", SqlDbType.Int).Value = CommonVariables.mcl.Dinner;
                cmdMeals.InsertCommand.Parameters.Add("@ProvidedMeal", SqlDbType.Bit).Value = CommonVariables.mcl.ProvidedMeals;
                cmdMeals.InsertCommand.Parameters.Add("@TotalMeals", SqlDbType.Float).Value = CommonVariables.mcl.MealsTotal;
                cmdMeals.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travId;
                cmdMeals.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.mcl.Notes;
                cmdMeals.InsertCommand.Parameters.Add("@BreakfastPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.BreakfastPerDiemRate;
                cmdMeals.InsertCommand.Parameters.Add("@LunchPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.LunchPerDiemRate;
                cmdMeals.InsertCommand.Parameters.Add("@DinnerPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.DinnerPerDiemRate;
                cmdMeals.InsertCommand.Parameters.Add("@TotalPerDiemRate", SqlDbType.Float).Value = CommonVariables.mcl.TotalMealsPerDiemRate;
                cmdMeals.InsertCommand.Parameters.Add("@PerDiemLoactionZipCode", SqlDbType.NVarChar).Value = CommonVariables.mcl.PerDiemLoactionZipCode;

                int ri = cmdMeals.InsertCommand.ExecuteNonQuery();

                //insert on the meals date table
                Guid mealID = new Guid();
                if (ri > 0)
                {
                    SqlCommand cmdMealsID = new SqlCommand("SELECT [MealsID] FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travId + "'", localCon);
                    SqlDataReader drMI = cmdMealsID.ExecuteReader();
                    while (drMI.Read())
                    {
                        mealID = new Guid(drMI["MealsID"].ToString());
                    }
                    drMI.Close();

                    for (int i = 0; i < CommonVariables.mdcl.Count; i++)
                    {
                        SqlDataAdapter cmdMealsDate = new SqlDataAdapter();
                        cmdMealsDate.InsertCommand = new SqlCommand(" INSERT INTO [TravelExpenses].[dbo].[MealDate]([MealsID],[Date],[Breaksfast],[Lunch],[Dinner]) VALUES (@MealsID,@Date,@Breaksfast,@Lunch,@Dinner)", localCon);
                        cmdMealsDate.InsertCommand.Parameters.Add("@MealsID", SqlDbType.UniqueIdentifier).Value = mealID;
                        cmdMealsDate.InsertCommand.Parameters.Add("@Date", SqlDbType.DateTime).Value = CommonVariables.mdcl[i].Date;
                        cmdMealsDate.InsertCommand.Parameters.Add("@Breaksfast", SqlDbType.Bit).Value = CommonVariables.mdcl[i].Breakfast;
                        cmdMealsDate.InsertCommand.Parameters.Add("@Lunch", SqlDbType.Bit).Value = CommonVariables.mdcl[i].Lunch;
                        cmdMealsDate.InsertCommand.Parameters.Add("@Dinner", SqlDbType.Bit).Value = CommonVariables.mdcl[i].Dinner;
                        cmdMealsDate.InsertCommand.ExecuteNonQuery();
                    }
                }
                
                //update the total
                totalTravel = totalTravel + CommonVariables.mcl.MealsTotal;
                totalReimbursement = totalReimbursement + CommonVariables.mcl.MealsTotal;

                //Update travel table
                SqlDataAdapter cmdMealsUp = new SqlDataAdapter();
                cmdMealsUp.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET [Melas] = @Meals WHERE TravelID = '"+ travId + "'", localCon);
                cmdMealsUp.UpdateCommand.Parameters.Add("@Meals", SqlDbType.Bit).Value = CommonVariables.isMeals;
                cmdMealsUp.UpdateCommand.ExecuteNonQuery();
                
            }

            if (CommonVariables.isRegistartion)
            {
                SqlDataAdapter cmdRegist = new SqlDataAdapter();
                cmdRegist.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Registration] ([RegistrationAMount],[DistrictPay],[TravelID],[Notes]) VALUES (@RegistrationAMount,@DistrictPay,@TravelID,@Notes)", localCon);
                cmdRegist.InsertCommand.Parameters.Add("@RegistrationAMount", SqlDbType.Float).Value = CommonVariables.rg.RegistrationAmount;
                cmdRegist.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.rg.DistrictPay;
                cmdRegist.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travId;
                cmdRegist.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.rg.Notes;

                cmdRegist.InsertCommand.ExecuteNonQuery();

                //update the total
                if (!CommonVariables.rg.DistrictPay) {
                    totalReimbursement = totalReimbursement + CommonVariables.rg.RegistrationAmount;
                }
                totalTravel = totalTravel + CommonVariables.rg.RegistrationAmount;

                //update travel table
                SqlDataAdapter cmdRegistUP = new SqlDataAdapter();
                cmdRegistUP.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET Registration = @Registration WHERE TravelID = '"+ travId+"'", localCon);
                cmdRegistUP.UpdateCommand.Parameters.Add("@Registration", SqlDbType.Bit).Value = CommonVariables.isRegistartion;
                cmdRegistUP.UpdateCommand.ExecuteNonQuery();
            }

            if (CommonVariables.isLodging)
            {
                for (int i = 0; i < CommonVariables.lcl.Count; i++)
                {
                    SqlDataAdapter cmdLodg = new SqlDataAdapter();
                    cmdLodg.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Lodging] ([FacilityName],[NumberOfNights],[CostPerNight],[TaxesAndFees],[DistrictPay],[DirectorApproved],[TravelID],[TotalLodging],[Notes]) VALUES (@FacilityName,@NumberOfNights,@CostPerNight,@TaxesAndFees,@DistrictPay,@DirectorApproved,@TravelID,@TotalLodging,@Notes)", localCon);
                    cmdLodg.InsertCommand.Parameters.Add("@FacilityName", SqlDbType.VarChar).Value = CommonVariables.lcl[i].FacilityName;
                    cmdLodg.InsertCommand.Parameters.Add("@NumberOfNights", SqlDbType.Int).Value = CommonVariables.lcl[i].NumberOfNights;
                    cmdLodg.InsertCommand.Parameters.Add("@CostPerNight", SqlDbType.Float).Value = CommonVariables.lcl[i].CostPerNight;
                    cmdLodg.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = CommonVariables.lcl[i].TaxesAndFees;
                    cmdLodg.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.lcl[i].DistrictPay;
                    cmdLodg.InsertCommand.Parameters.Add("@DirectorApproved", SqlDbType.Bit).Value = CommonVariables.lcl[i].DirectorApproved;
                    cmdLodg.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travId;
                    cmdLodg.InsertCommand.Parameters.Add("@TotalLodging", SqlDbType.Float).Value = CommonVariables.lcl[i].TotalLodging;
                    cmdLodg.InsertCommand.Parameters.Add("@Notes", SqlDbType.VarChar).Value = CommonVariables.lcl[i].Notes;

                    cmdLodg.InsertCommand.ExecuteNonQuery();

                    //update the total
                    if (CommonVariables.lcl[i].DistrictPay == false && CommonVariables.lcl[i].DirectorApproved == false)
                    {
                        notReimbursement = notReimbursement + Convert.ToDouble(CommonVariables.lcl[i].TotalLodging.ToString());
                    }
                    else if (CommonVariables.lcl[i].DistrictPay == false && CommonVariables.lcl[i].DirectorApproved == true)
                    {
                        totalReimbursement = totalReimbursement + Convert.ToDouble(CommonVariables.lcl[i].TotalLodging.ToString());
                    }
                    totalTravel = totalTravel + Convert.ToDouble(CommonVariables.lcl[i].TotalLodging.ToString());

                }

                //update the travel table
                SqlDataAdapter cmdLodgUp = new SqlDataAdapter();
                cmdLodgUp.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET Lodging = @Lodging WHERE TravelID = '"+ travId+"'", localCon);
                cmdLodgUp.UpdateCommand.Parameters.Add("@Lodging", SqlDbType.Bit).Value = CommonVariables.isLodging;
                cmdLodgUp.UpdateCommand.ExecuteNonQuery();

            }

            if (CommonVariables.isCarRental)
            {
                for (int i = 0; i < CommonVariables.crcl.Count; i++)
                {
                    SqlDataAdapter cmdCarR = new SqlDataAdapter();
                    cmdCarR.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[CarRental] ([PickUPDate],[DropOffDate],[CarType],[Company],[Days],[CostPerDay],[TaxesAndFees],[LDWInsuranse],[SupplementalInsurance],[ExtarInsurance],[ExtarInsuranceAmount],[DistrictPay],[PersonalUse],[PersonalAmount],[TotalCarRental],[TravelID],[Notes])VALUES (@PickUPDate,@DropOffDate,@CarType,@Company,@Days,@CostPerDay,@TaxesAndFees,@LDWInsuranse,@SupplementalInsurance,@ExtarInsurance,@ExtarInsuranceAmount,@DistrictPay,@PersonalUse,@PersonalAmount,@TotalCarRental,@TravelID,@Notes)", localCon);
                    cmdCarR.InsertCommand.Parameters.Add("@PickUPDate", SqlDbType.DateTime).Value = CommonVariables.crcl[i].PickUpDate;
                    cmdCarR.InsertCommand.Parameters.Add("@DropOffDate", SqlDbType.DateTime).Value = CommonVariables.crcl[i].DropOffDate;
                    cmdCarR.InsertCommand.Parameters.Add("@CarType", SqlDbType.NVarChar).Value = CommonVariables.crcl[i].CarType;
                    cmdCarR.InsertCommand.Parameters.Add("@Company", SqlDbType.NVarChar).Value = CommonVariables.crcl[i].Company;
                    cmdCarR.InsertCommand.Parameters.Add("@Days", SqlDbType.Int).Value = CommonVariables.crcl[i].Days;
                    cmdCarR.InsertCommand.Parameters.Add("@CostPerDay", SqlDbType.Float).Value = CommonVariables.crcl[i].CostPerDay;
                    cmdCarR.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = CommonVariables.crcl[i].TaxesAndFees;
                    cmdCarR.InsertCommand.Parameters.Add("@LDWInsuranse", SqlDbType.Float).Value = CommonVariables.crcl[i].LDWInsuranse;
                    cmdCarR.InsertCommand.Parameters.Add("@SupplementalInsurance", SqlDbType.Float).Value = CommonVariables.crcl[i].SupplementalInsurance;
                    cmdCarR.InsertCommand.Parameters.Add("@ExtarInsurance", SqlDbType.Bit).Value = CommonVariables.crcl[i].ExtraInsurance;
                    cmdCarR.InsertCommand.Parameters.Add("@ExtarInsuranceAmount", SqlDbType.Float).Value = CommonVariables.crcl[i].ExtraInsuranceAmount;
                    cmdCarR.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.crcl[i].DistrictPay;
                    cmdCarR.InsertCommand.Parameters.Add("@PersonalUse", SqlDbType.Bit).Value = CommonVariables.crcl[i].PersonalUse;
                    cmdCarR.InsertCommand.Parameters.Add("@PersonalAmount", SqlDbType.Float).Value = CommonVariables.crcl[i].PersonalUseAmount;
                    cmdCarR.InsertCommand.Parameters.Add("@TotalCarRental", SqlDbType.Float).Value = CommonVariables.crcl[i].TotalCarRental;
                    cmdCarR.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travId;
                    cmdCarR.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.crcl[i].Notes;

                    cmdCarR.InsertCommand.ExecuteNonQuery();

                    //Update the Total
                    if (CommonVariables.crcl[i].DistrictPay == true)
                    {
                        if (CommonVariables.crcl[i].PersonalUse == true)
                        {
                            notReimbursement = notReimbursement + Convert.ToDouble(CommonVariables.crcl[i].PersonalUseAmount.ToString());
                        }
                    }
                    else
                    {
                        if (CommonVariables.crcl[i].PersonalUse == true)
                        {
                            double perUsDiffCRUp = Convert.ToDouble(CommonVariables.crcl[i].TotalCarRental.ToString()) - Convert.ToDouble(CommonVariables.crcl[i].PersonalUseAmount.ToString());
                            totalReimbursement = totalReimbursement + perUsDiffCRUp;
                        }
                        else
                        {
                            totalReimbursement = totalReimbursement + Convert.ToDouble(CommonVariables.crcl[i].TotalCarRental.ToString());
                        }
                            
                    }
                    totalTravel = totalTravel + Convert.ToDouble(CommonVariables.crcl[i].TotalCarRental.ToString()); 
                }

                //update the travel table
                SqlDataAdapter cmdCarRUp = new SqlDataAdapter();
                cmdCarRUp.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET CarRental = @CarRental WHERE TravelID = '"+ travId+"'", localCon);
                cmdCarRUp.UpdateCommand.Parameters.Add("@CarRental", SqlDbType.Bit).Value = CommonVariables.isCarRental;
                cmdCarRUp.UpdateCommand.ExecuteNonQuery();
            }

            if (CommonVariables.isAirFare)
            {
                for (int i = 0; i < CommonVariables.afcl.Count; i++)
                {
                    SqlDataAdapter cmdAirFare = new SqlDataAdapter();
                    cmdAirFare.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[AirFare] ([DepartureDate],[ReturnDate],[AirFareCost],[TaxesAndFees],[DistrictPay],[PersonalUse],[PersonalUseAmount],[AirFareTotal],[TravelID],[Notes]) VALUES(@DepartureDate,@ReturnDate,@AirFareCost,@TaxesAndFees,@DistrictPay,@PersonalUse,@PersonalUseAmount,@AirFareTotal,@TravelID,@Notes)", localCon);
                    cmdAirFare.InsertCommand.Parameters.Add("@DepartureDate", SqlDbType.DateTime).Value = CommonVariables.afcl[i].DepartureDate;
                    if (CommonVariables.afcl[i].ReturnDate != null)
                    {
                        cmdAirFare.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = CommonVariables.afcl[i].ReturnDate;
                    }
                    else
                    {

                        cmdAirFare.InsertCommand.Parameters.Add("@ReturnDate", SqlDbType.DateTime).Value = SqlDateTime.Null;
                    }
                    cmdAirFare.InsertCommand.Parameters.Add("@AirFareCost", SqlDbType.Float).Value = CommonVariables.afcl[i].AirFareCost;
                    cmdAirFare.InsertCommand.Parameters.Add("@TaxesAndFees", SqlDbType.Float).Value = CommonVariables.afcl[i].TaxesAndFees;
                    cmdAirFare.InsertCommand.Parameters.Add("@DistrictPay", SqlDbType.Bit).Value = CommonVariables.afcl[i].DistrictPay;
                    cmdAirFare.InsertCommand.Parameters.Add("@PersonalUse", SqlDbType.Bit).Value = CommonVariables.afcl[i].PersonalUse;
                    cmdAirFare.InsertCommand.Parameters.Add("@PersonalUseAmount", SqlDbType.Float).Value = CommonVariables.afcl[i].PersonalUseAmount;
                    cmdAirFare.InsertCommand.Parameters.Add("@AirFareTotal", SqlDbType.Float).Value = CommonVariables.afcl[i].TotalAirFare;
                    cmdAirFare.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travId;
                    cmdAirFare.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.afcl[i].Notes;

                    cmdAirFare.InsertCommand.ExecuteNonQuery();

                    //update the total
                    if (CommonVariables.afcl[i].DistrictPay == true)
                    {
                       
                        if (CommonVariables.afcl[i].PersonalUse == true)
                        {
                            notReimbursement = notReimbursement + Convert.ToDouble(CommonVariables.afcl[i].PersonalUseAmount.ToString());
                        }
                    }
                    else
                    {
                        if (CommonVariables.afcl[i].PersonalUse == true)
                        {
                            double perUsDiffAFUp = Convert.ToDouble(CommonVariables.afcl[i].TotalAirFare.ToString()) - Convert.ToDouble(CommonVariables.afcl[i].PersonalUseAmount.ToString());
                            totalReimbursement = totalReimbursement + perUsDiffAFUp;
                        }
                        else
                        {
                            totalReimbursement = totalReimbursement + Convert.ToDouble(CommonVariables.afcl[i].TotalAirFare.ToString());
                        }
                            
                    }
                    totalTravel = totalTravel + Convert.ToDouble(CommonVariables.afcl[i].TotalAirFare.ToString());
                }

                //update the travel table
                SqlDataAdapter cmdAirFareUP = new SqlDataAdapter();
                cmdAirFareUP.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET AirFare = @AirFare  WHERE TravelID = '"+ travId +"'", localCon);
                cmdAirFareUP.UpdateCommand.Parameters.Add("@AirFare", SqlDbType.Bit).Value = CommonVariables.isAirFare;
                cmdAirFareUP.UpdateCommand.ExecuteNonQuery();

            }

            if (CommonVariables.isMileage)
            {
                SqlDataAdapter cmdMileage = new SqlDataAdapter();
                cmdMileage.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[Mileage] ([DistrictVehicleProvided],[DirectorApprovedPersonal],[MapMileage],[VicinityMileage],[TravelID],[TotalMileage],[Notes]) VALUES (@DistrictVehicleProvided,@DirectorApprovedPersonal,@MapMileage,@VicinityMileage,@TravelID,@TotalMileage,@Notes)", localCon);
                cmdMileage.InsertCommand.Parameters.Add("@DistrictVehicleProvided", SqlDbType.Bit).Value = CommonVariables.micl.DistricticProvidedVehicle;
                if (!CommonVariables.micl.DistricticProvidedVehicle)
                {
                    cmdMileage.InsertCommand.Parameters.Add("@DirectorApprovedPersonal", SqlDbType.Bit).Value = CommonVariables.micl.DirectorApprovedPersonal;
                }
                else
                {
                    cmdMileage.InsertCommand.Parameters.Add("@DirectorApprovedPersonal", SqlDbType.Bit).Value = SqlDateTime.Null;
                }
                cmdMileage.InsertCommand.Parameters.Add("@MapMileage", SqlDbType.Float).Value = CommonVariables.micl.MapMileage;
                cmdMileage.InsertCommand.Parameters.Add("@VicinityMileage", SqlDbType.Float).Value = CommonVariables.micl.VicinityMileage;
                cmdMileage.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travId;
                cmdMileage.InsertCommand.Parameters.Add("@TotalMileage", SqlDbType.Float).Value = CommonVariables.micl.TotalMileage;
                cmdMileage.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.micl.Notes;

                cmdMileage.InsertCommand.ExecuteNonQuery();

                //update the total
                if (CommonVariables.micl.DistricticProvidedVehicle == false)
                { 

                    if (CommonVariables.micl.DirectorApprovedPersonal == false)
                    {
                        notReimbursement = notReimbursement + Convert.ToDouble(CommonVariables.micl.TotalMileage.ToString());
                    }
                    else
                    {
                        totalReimbursement = totalReimbursement + Convert.ToDouble(CommonVariables.micl.TotalMileage.ToString());
                    }
                }
                totalTravel = totalTravel + Convert.ToDouble(CommonVariables.micl.TotalMileage.ToString());

                //update the travel table
                SqlDataAdapter cmdMileageUp = new SqlDataAdapter();
                cmdMileageUp.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET Mileage = @Mileage WHERE TravelID = '"+ travId +"'", localCon);
                cmdMileageUp.UpdateCommand.Parameters.Add("@Mileage", SqlDbType.Bit).Value = CommonVariables.isMileage;
                cmdMileageUp.UpdateCommand.ExecuteNonQuery();

            }

            if (CommonVariables.isOtherExpenses)
            {
                for (int i = 0; i < CommonVariables.oxcl.Count; i++)
                {
                    SqlDataAdapter cmdOtherEx = new SqlDataAdapter();
                    cmdOtherEx.InsertCommand = new SqlCommand("INSERT INTO [TravelExpenses].[dbo].[OtherExpenses] ([Description],[Amount],[TravelID],[Notes],[Prepaid]) VALUES (@Description,@Amount,@TravelID,@Notes,@Prepaid)", localCon);
                    cmdOtherEx.InsertCommand.Parameters.Add("@Description", SqlDbType.NVarChar).Value = CommonVariables.oxcl[i].Description;
                    cmdOtherEx.InsertCommand.Parameters.Add("@Amount", SqlDbType.Float).Value = CommonVariables.oxcl[i].Amount;
                    cmdOtherEx.InsertCommand.Parameters.Add("@TravelID", SqlDbType.UniqueIdentifier).Value = travId;
                    cmdOtherEx.InsertCommand.Parameters.Add("@Prepaid", SqlDbType.Bit).Value = CommonVariables.oxcl[i].Prepaid;
                    cmdOtherEx.InsertCommand.Parameters.Add("@Notes", SqlDbType.NVarChar).Value = CommonVariables.oxcl[i].Notes;

                    cmdOtherEx.InsertCommand.ExecuteNonQuery();

                    //update the total
                    if (!CommonVariables.oxcl[i].Prepaid)
                    {
                        totalReimbursement = totalReimbursement + CommonVariables.oxcl[i].Amount;
                    }
                    totalTravel = totalTravel + CommonVariables.oxcl[i].Amount;
                }

                //update the travel table
                SqlDataAdapter cmdOtherExUp = new SqlDataAdapter();
                cmdOtherExUp.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET OtherExpenses = @OtherExpenses WHERE TravelID = '"+ travId +"'", localCon);
                cmdOtherExUp.UpdateCommand.Parameters.Add("@OtherExpenses", SqlDbType.Bit).Value = CommonVariables.isOtherExpenses;
                cmdOtherExUp.UpdateCommand.ExecuteNonQuery();
            }

            //Update the total in the travel table

            SqlCommand cmdSleTotalTravel = new SqlCommand("SELECT [TotalTravelAmount] ,[TotalTravelReimbursed] ,[TotalTravelNoReimbursed] FROM [TravelExpenses].[dbo].[Travel] where TravelID = '"+ travId +"'", localCon);
            SqlDataReader drTotals = cmdSleTotalTravel.ExecuteReader();
            while (drTotals.Read()) {
                string total = drTotals["TotalTravelAmount"].ToString();
                string reim = drTotals["TotalTravelReimbursed"].ToString();
                string totalNR = drTotals["TotalTravelNoReimbursed"].ToString();
                totalTravel = Convert.ToDouble(total) + totalTravel;
                totalReimbursement = Convert.ToDouble(reim) + totalReimbursement;
                notReimbursement = Convert.ToDouble(totalNR) + notReimbursement;
            }
            drTotals.Close();

            SqlDataAdapter cmdTravelTotalUp = new SqlDataAdapter();
            cmdTravelTotalUp.UpdateCommand = new SqlCommand("UPDATE [TravelExpenses].[dbo].[Travel] SET TotalTravelAmount = @TotalTravelAmount,TotalTravelNoReimbursed = @TotalTravelNoReimbursed,TotalTravelReimbursed = @TotalTravelReimbursed WHERE TravelID = '" + travId + "'", localCon);
            cmdTravelTotalUp.UpdateCommand.Parameters.Add("@TotalTravelAmount", SqlDbType.Float).Value = totalTravel;
            cmdTravelTotalUp.UpdateCommand.Parameters.Add("@TotalTravelNoReimbursed", SqlDbType.Float).Value = notReimbursement;
            cmdTravelTotalUp.UpdateCommand.Parameters.Add("@TotalTravelReimbursed", SqlDbType.Float).Value = totalReimbursement;
            cmdTravelTotalUp.UpdateCommand.ExecuteNonQuery();

            travelUpdate = true;

            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }

            localCon.Close();
        }

        private void generateDetailPDFUp() {

            localCon.Open();
            string name = "";
            string lastname = "";
            string district = "";
            string department = "";
            string fullName = "";
            Guid travID = new Guid(CommonVariables.addingTravelID);
            string username = "";
            string departureDate = "";
            string returnDate = "";

            SqlCommand cmdUser = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] where UserID = '" + CommonVariables.user + "'", localCon);
            SqlDataReader drUser = cmdUser.ExecuteReader();
            while (drUser.Read())
            {
                name = drUser["Name"].ToString();
                lastname = drUser["LastName"].ToString();
                district = drUser["District"].ToString();
                department = drUser["Department"].ToString();
                username = drUser["Username"].ToString();
            }
            drUser.Close();
            fullName = name + " " + lastname;

            SqlCommand cmdTDates = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
            SqlDataReader drTDates = cmdTDates.ExecuteReader();
            while (drTDates.Read())
            {
                departureDate = Convert.ToDateTime(drTDates["DepartureDate"].ToString()).ToShortDateString();
                returnDate = Convert.ToDateTime(drTDates["ReturnDate"].ToString()).ToShortDateString();
            }
            drTDates.Close();

            string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form(Details).pdf";
            string pdfName = fullName + "_" + departureDate + "_" + "to" + "_" + returnDate + ".pdf";
            pdfName = pdfName.Replace("/", "-");
            string newFile = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\travel_form(Details)_" + pdfName;
            CommonVariables.detailedFilePath = newFile;

            PdfReader pdfReader = new PdfReader(pdfTemplate);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;

            

            //user details
            pdfFormFields.SetField("Full Name", fullName);
            pdfFormFields.SetField("District", district);
            pdfFormFields.SetField("Department", department);

            //travel details
            SqlCommand cmdTD = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '"+ travID + "'", localCon);
            SqlDataReader drTD = cmdTD.ExecuteReader();
            while (drTD.Read()) {
                pdfFormFields.SetField("Travel Event", drTD["TravelEvent"].ToString());
                pdfFormFields.SetField("Travel Purpose", drTD["TravelPurpose"].ToString());
                DateTime dd = Convert.ToDateTime(drTD["DepartureDate"].ToString());
                pdfFormFields.SetField("Departure_Date", dd.ToShortDateString());
                pdfFormFields.SetField("Departure_Time", drTD["DepartureTime"].ToString());
                DateTime rd = Convert.ToDateTime(drTD["ReturnDate"].ToString());
                pdfFormFields.SetField("Return_Date", rd.ToShortDateString());
                pdfFormFields.SetField("Return_Time", drTD["ReturnTime"].ToString());
                pdfFormFields.SetField("Origin", drTD["Origin"].ToString());
                pdfFormFields.SetField("Destination", drTD["Destination"].ToString());
                pdfFormFields.SetField("Travel State", drTD["TravelState"].ToString());
                pdfFormFields.SetField("Travel Notes", drTD["Notes"].ToString());

                //Tratel Totals
                string travCost = Convert.ToDouble(drTD["TotalTravelAmount"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                string reimb = Convert.ToDouble(drTD["TotalTravelReimbursed"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                string noReimb = Convert.ToDouble(drTD["TotalTravelNoReimbursed"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);

                pdfFormFields.SetField("Travel Total Cost", travCost);
                pdfFormFields.SetField("Reimbursement", reimb);
                pdfFormFields.SetField("No Reimbursed", noReimb);
                pdfFormFields.SetField("Date", DateTime.Today.ToShortDateString());

                //set up the travel common variables
                if (drTD["Melas"].ToString() == "True") {
                    CommonVariables.isMeals = true;
                }
                if (drTD["Registration"].ToString() == "True") {
                    CommonVariables.isRegistartion = true;
                }
                if (drTD["CarRental"].ToString() == "True") {
                    CommonVariables.isCarRental = true;
                }
                if (drTD["Lodging"].ToString() == "True") {
                    CommonVariables.isLodging = true;
                }
                if (drTD["AirFare"].ToString() == "True") {
                    CommonVariables.isAirFare = true;
                }
                if (drTD["Mileage"].ToString() == "True") {
                    CommonVariables.isMileage = true;
                }
                if (drTD["OtherExpenses"].ToString() == "True") {
                    CommonVariables.isOtherExpenses = true;
                }


            }
            drTD.Close();

            //Meals Details
            if (CommonVariables.isMeals) {

                SqlCommand cmdMeals = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Meals] where TravelID = '"+ travID +"'", localCon);
                SqlDataReader drMeals = cmdMeals.ExecuteReader();

                while (drMeals.Read()) {
                    pdfFormFields.SetField("BreakfastQuantity", drMeals["Breakfast"].ToString());
                    pdfFormFields.SetField("LunchQuantity", drMeals["Lunch"].ToString());
                    pdfFormFields.SetField("DinnerQuantity", drMeals["Dinner"].ToString());
                    int brekCost = Convert.ToInt32(drMeals["Breakfast"].ToString()) * 8;
                    pdfFormFields.SetField("BreakfastCost", brekCost.ToString());
                    int lunchCost = Convert.ToInt32(drMeals["Lunch"].ToString()) * 12;
                    pdfFormFields.SetField("LunchCost", lunchCost.ToString());
                    int dinCost = Convert.ToInt32(drMeals["Dinner"].ToString()) * 20;
                    pdfFormFields.SetField("DinnerCost", dinCost.ToString());
                    if (drMeals["ProvidedMeal"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Provided Meals", "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Provided Meals", "No");
                    }
                    string mealCost = Convert.ToDouble(drMeals["TotalMeals"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Meals_Total", mealCost);
                }
                drMeals.Close();
                
            }

            //Registration Details
            if (CommonVariables.isRegistartion) {

                SqlCommand cmdRegis = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Registration] where TravelID = '"+ travID +"'", localCon);
                SqlDataReader drRegis = cmdRegis.ExecuteReader();
                while (drRegis.Read()) {
                    string regCost = Convert.ToDouble(drRegis["RegistrationAMount"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Registration Cost", regCost);
                }
                drRegis.Close();
                
            }

            //Lodging
            if (CommonVariables.isLodging) {

                SqlCommand cmdLod = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '"+ travID +"'", localCon);
                SqlDataReader drLod = cmdLod.ExecuteReader();

                int row = 1;
                double totalLod = 0;
                while (drLod.Read()) {
                    pdfFormFields.SetField("Facility Name" + row, drLod["FacilityName"].ToString());
                    pdfFormFields.SetField("Facility Total Cost" + row, drLod["TotalLodging"].ToString());
                    totalLod = totalLod + Convert.ToDouble(drLod["TotalLodging"].ToString());
                    pdfFormFields.SetField("Lodging Nights" + row, drLod["NumberOfNights"].ToString());
                    pdfFormFields.SetField("Lodging Night Cost" + row, drLod["CostPerNight"].ToString());
                    pdfFormFields.SetField("Lodging Taxes Fees" + row, drLod["TaxesAndFees"].ToString());
                    if (drLod["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Lodging District Pay" + row, "Yes");
                        pdfFormFields.SetField("Lodging Director Approval" + row, "");
                    }
                    else
                    {
                        pdfFormFields.SetField("Lodging District Pay" + row, "No");
                        if (drLod["DirectorApproved"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Lodging Director Approval" + row, "Yes");
                        }
                        else
                        {
                            pdfFormFields.SetField("Lodging Director Approval" + row, "No");
                        }
                    }
                    pdfFormFields.SetField("Facility  Notes" + row, drLod["Notes"].ToString());
                    row++;
                }
                drLod.Close();  
                pdfFormFields.SetField("Lodging Total", totalLod.ToString("C", CultureInfo.CurrentCulture).Substring(1));
            }

            //Car Rental Details
            if (CommonVariables.isCarRental) {
                SqlCommand cmdCR = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '"+ travID +"'", localCon);
                SqlDataReader drCR = cmdCR.ExecuteReader();

                int carRow = 1;
                double totalCR = 0;

                while (drCR.Read())
                {
                    pdfFormFields.SetField("Pick up Date" + carRow, drCR["PickUPDate"].ToString());
                    pdfFormFields.SetField("Drop off Date" + carRow, drCR["DropOffDate"].ToString());
                    pdfFormFields.SetField("Car_Day Cost" + carRow, drCR["CostPerDay"].ToString());
                    pdfFormFields.SetField("Car Total" + carRow, drCR["TotalCarRental"].ToString());
                    totalCR = totalCR + Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    pdfFormFields.SetField("Car Type" + carRow, drCR["CarType"].ToString());
                    pdfFormFields.SetField("Rental Company" + carRow, drCR["Company"].ToString());
                    pdfFormFields.SetField("Car Rental Days" + carRow, drCR["Days"].ToString());
                    pdfFormFields.SetField("Car Rental Taxes Fees" + carRow, drCR["TaxesAndFees"].ToString());
                    pdfFormFields.SetField("LDW Insurance" + carRow, drCR["LDWInsuranse"].ToString());
                    pdfFormFields.SetField("Supplemental Insurance" + carRow, drCR["SupplementalInsurance"].ToString());
                    pdfFormFields.SetField("Extra Insurance" + carRow, drCR["ExtarInsuranceAmount"].ToString());
                    if (drCR["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Car District Pay" + carRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Car District Pay" + carRow, "No");
                    }
                    pdfFormFields.SetField("Car Personal Amount" + carRow, drCR["PersonalAmount"].ToString());
                    pdfFormFields.SetField("Car Notes" + carRow, drCR["Notes"].ToString());

                    carRow++;
                }
                drCR.Close();
                pdfFormFields.SetField("Car Rental Total", totalCR.ToString("C", CultureInfo.CurrentCulture).Substring(1));
            }

            //AirFare Details
            if (CommonVariables.isAirFare) {
                SqlCommand cmdAF = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '"+ travID +"'", localCon);
                SqlDataReader drAF = cmdAF.ExecuteReader();

                int flightRow = 1;
                double totalAF = 0;

                while (drAF.Read())
                {
                    pdfFormFields.SetField("Flight_Departure Date" + flightRow, drAF["DepartureDate"].ToString());
                    if (drAF["ReturnDate"].ToString() != "")
                    {
                        DateTime rd = Convert.ToDateTime(drAF["ReturnDate"].ToString());
                        pdfFormFields.SetField("Flight_Return Date" + flightRow, rd.ToShortDateString());
                    }
                    pdfFormFields.SetField("Flight Total" + flightRow, drAF["AirFareTotal"].ToString());
                    totalAF = totalAF + Convert.ToDouble(drAF["AirFareTotal"].ToString());
                    pdfFormFields.SetField("Flight Taxes  Fees" + flightRow, drAF["TaxesAndFees"].ToString());
                    if (drAF["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Flight District Pay" + flightRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Flight District Pay" + flightRow, "No");
                    }
                    pdfFormFields.SetField("Flight Personal Amount" + flightRow, drAF["PersonalUseAmount"].ToString());
                    pdfFormFields.SetField("Air Fare Notes" + flightRow, drAF["Notes"].ToString());

                    flightRow++;
                }
                drAF.Close();
                pdfFormFields.SetField("Air Fare Total", totalAF.ToString("C", CultureInfo.CurrentCulture).Substring(1));
            }

            //Mileage Details
            if (CommonVariables.isMileage)
            {
                SqlCommand cmdMi = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drMi = cmdMi.ExecuteReader();

                while (drMi.Read())
                {
                    pdfFormFields.SetField("Map Mileage", drMi["MapMileage"].ToString());
                    pdfFormFields.SetField("Vicinity Mileage", drMi["VicinityMileage"].ToString());
                    string milCost = Convert.ToDouble(drMi["TotalMileage"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Mileage Cost", milCost);
                    if (drMi["DistrictVehicleProvided"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Provided Vehicle", "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Provided Vehicle", "No");
                        if (drMi["DirectorApprovedPersonal"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Mileage Director Approval", "Yes");
                        }
                        else
                        {
                            pdfFormFields.SetField("Mileage Director Approval", "No");
                        }
                    }
                    pdfFormFields.SetField("Mileage Notes", drMi["Notes"].ToString());
                }
                drMi.Close();
            }

            //Other Expenses
            if (CommonVariables.isOtherExpenses) {
                SqlCommand cmdOE = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '"+ travID +"'", localCon);
                SqlDataReader drOE = cmdOE.ExecuteReader();

                int oxRow = 1;
                double totalOE = 0;
                while (drOE.Read())
                {
                    pdfFormFields.SetField("ExpDescription" + oxRow, drOE["Description"].ToString());
                    pdfFormFields.SetField("ExpCost" + oxRow, drOE["Amount"].ToString());
                    totalOE = totalOE + Convert.ToDouble(drOE["Amount"].ToString());
                    pdfFormFields.SetField("ExpNotes" + oxRow, drOE["Notes"].ToString());
                    oxRow++;
                }
                pdfFormFields.SetField("Other Expenses Total", totalOE.ToString("C", CultureInfo.CurrentCulture).Substring(1));
                drOE.Close();
            }

            pdfStamper.Close();
            localCon.Close();
        }

        private void generateSummarizedPDFUp() {

            localCon.Open();
            string name = "";
            string lastname = "";
            string district = "";
            string department = "";
            string fullName = "";
            string username = "";
            string departureDate = "";
            string returnDate = "";

            Guid travID = new Guid(CommonVariables.addingTravelID);

            SqlCommand cmdUser = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] where UserID = '" + CommonVariables.user + "'", localCon);
            SqlDataReader drUser = cmdUser.ExecuteReader();
            while (drUser.Read())
            {
                name = drUser["Name"].ToString();
                lastname = drUser["LastName"].ToString();
                district = drUser["District"].ToString();
                department = drUser["Department"].ToString();
                username = drUser["Username"].ToString();
            }
            drUser.Close();
            fullName = name + " " + lastname;

            SqlCommand cmdTDates = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
            SqlDataReader drTDates = cmdTDates.ExecuteReader();
            while (drTDates.Read())
            {
                 departureDate = Convert.ToDateTime(drTDates["DepartureDate"].ToString()).ToShortDateString();
                 returnDate = Convert.ToDateTime(drTDates["ReturnDate"].ToString()).ToShortDateString();
            }
            drTDates.Close();

            string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form(Summarized).pdf";
            string pdfName = fullName + "_" + departureDate + "_" + "to" + "_" + returnDate + ".pdf";
            pdfName = pdfName.Replace("/", "-");
            string newFile = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\travel_form(Summarized)_" + pdfName;
            CommonVariables.filePath = newFile;

            PdfReader pdfReader = new PdfReader(pdfTemplate);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;

            

            //user details
            pdfFormFields.SetField("Full Name", fullName);
            pdfFormFields.SetField("District", district);
            pdfFormFields.SetField("Department", department);

            //travel details
            SqlCommand cmdTD = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
            SqlDataReader drTD = cmdTD.ExecuteReader();
            while (drTD.Read())
            {
                pdfFormFields.SetField("Travel Event", drTD["TravelEvent"].ToString());
                pdfFormFields.SetField("Travel Purpose", drTD["TravelPurpose"].ToString());
                DateTime dd = Convert.ToDateTime(drTD["DepartureDate"].ToString());
                pdfFormFields.SetField("Departure Date", dd.ToShortDateString());
                pdfFormFields.SetField("Departure Time", drTD["DepartureTime"].ToString());
                DateTime rd = Convert.ToDateTime(drTD["ReturnDate"].ToString());
                pdfFormFields.SetField("Return Date", rd.ToShortDateString());
                pdfFormFields.SetField("Return Time", drTD["ReturnTime"].ToString());
                pdfFormFields.SetField("Origin", drTD["Origin"].ToString());
                pdfFormFields.SetField("Destination", drTD["Destination"].ToString());
                pdfFormFields.SetField("Travel State", drTD["TravelState"].ToString());


                //Tratel Totals
                travelACC = Convert.ToDouble(drTD["TotalTravelAmount"].ToString());
                string travCost = travelACC.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                double reimValue = Convert.ToDouble(drTD["TotalTravelReimbursed"].ToString());
                string reimCost = reimValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                double noReimCostValue = Convert.ToDouble(drTD["TotalTravelNoReimbursed"].ToString());
                string noReimCost = noReimCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                pdfFormFields.SetField("Travel Total", travCost);
                pdfFormFields.SetField("Total Reimbursed", reimCost);
                pdfFormFields.SetField("No Reimbursed", noReimCost);
                

                //set up the travel common variables
                if (drTD["Melas"].ToString() == "True")
                {
                    CommonVariables.isMeals = true;
                }
                if (drTD["Registration"].ToString() == "True")
                {
                    CommonVariables.isRegistartion = true;
                }
                if (drTD["CarRental"].ToString() == "True")
                {
                    CommonVariables.isCarRental = true;
                }
                if (drTD["Lodging"].ToString() == "True")
                {
                    CommonVariables.isLodging = true;
                }
                if (drTD["AirFare"].ToString() == "True")
                {
                    CommonVariables.isAirFare = true;
                }
                if (drTD["Mileage"].ToString() == "True")
                {
                    CommonVariables.isMileage = true;
                }
                if (drTD["OtherExpenses"].ToString() == "True")
                {
                    CommonVariables.isOtherExpenses = true;
                }

                


            }
            drTD.Close();

            //Meals Details
            if (CommonVariables.isMeals)
            {
                SqlCommand cmdMeals = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drMeals = cmdMeals.ExecuteReader();
                while (drMeals.Read())
                {
                    double mealCostValue = Convert.ToDouble(drMeals["TotalMeals"].ToString());
                    string mealCost = mealCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("CostMeals", mealCost);
                    pdfFormFields.SetField("NotesMeals", drMeals["Notes"].ToString());
                }
                drMeals.Close();
            }

            //Registration Details
            if (CommonVariables.isRegistartion)
            {

                SqlCommand cmdRegis = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drRegis = cmdRegis.ExecuteReader();
                while (drRegis.Read())
                {
                    trainingACC = Convert.ToDouble(drRegis["RegistrationAMount"].ToString());
                    travelACC = travelACC - trainingACC;
                    if (travelACC < 0)
                    {
                        travelACC = travelACC * -1;
                    }
                    string totalReg = trainingACC.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("CostRegistration", totalReg);
                    pdfFormFields.SetField("NotesRegistration", drRegis["Notes"].ToString());
                }
                drRegis.Close();

            }

            //Lodging
            if (CommonVariables.isLodging)
            {

                SqlCommand cmdLod = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drLod = cmdLod.ExecuteReader();

                double totalLod = 0;
                string notes = "";
                while (drLod.Read())
                {
                    totalLod = totalLod + Convert.ToDouble(drLod["TotalLodging"].ToString());
                    if (drLod["Notes"].ToString() != "")
                    {
                        notes += drLod["Notes"].ToString() + " .";
                    }
                }
                drLod.Close();
                string lodgCost = totalLod.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostLodgings", lodgCost);
                pdfFormFields.SetField("NotesLodgings", notes);
            }

            //Car Rental Details
            if (CommonVariables.isCarRental)
            {
                SqlCommand cmdCR = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drCR = cmdCR.ExecuteReader();

                
                double totalCR = 0;
                string notesCR = "";
                while (drCR.Read())
                {
                    totalCR = totalCR + Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    if (drCR["Notes"].ToString() != "")
                    {
                        notesCR += drCR["Notes"].ToString() + " .";
                    }
                }
                drCR.Close();
                string carCost = totalCR.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostCar Rental", carCost);
                pdfFormFields.SetField("NotesCar Rental", notesCR);
            }

            //AirFare Details
            if (CommonVariables.isAirFare)
            {
                SqlCommand cmdAF = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drAF = cmdAF.ExecuteReader();
               
                double totalAF = 0;
                string notesAF = ""; 

                while (drAF.Read())
                {
                    totalAF = totalAF + Convert.ToDouble(drAF["AirFareTotal"].ToString());
                    if (drAF["Notes"].ToString() != "")
                    {
                        notesAF += drAF["Notes"].ToString() + " .";
                    }
                }
                drAF.Close();
                string flightCost = totalAF.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostAir Fare", flightCost);
                pdfFormFields.SetField("NotesAir Fare", notesAF);
            }

            //Mileage Details
            if (CommonVariables.isMileage)
            {
                SqlCommand cmdMi = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drMi = cmdMi.ExecuteReader();

                while (drMi.Read())
                {
                    double milCostValue = Convert.ToDouble(drMi["TotalMileage"].ToString());
                    string milcost = milCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("CostMileage", milcost);
                    pdfFormFields.SetField("NotesMileage", drMi["Notes"].ToString());
                }
                drMi.Close();
            }

            //Other Expenses
            if (CommonVariables.isOtherExpenses)
            {
                SqlCommand cmdOE = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drOE = cmdOE.ExecuteReader();
                
                double totalOE = 0;
                string notesOE = "";
                while (drOE.Read())
                {
                    totalOE = totalOE + Convert.ToDouble(drOE["Amount"].ToString());
                    if (drOE["Notes"].ToString() != "")
                    {
                        notesOE += drOE["Notes"].ToString() + " .";
                    }
                }
                drOE.Close();
                string oeCost = totalOE.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostOther Expenses", oeCost);
                pdfFormFields.SetField("NotesOther Expenses", notesOE);
            }

            //Accounting accounts
            string travACC = travelACC.ToString("C", CultureInfo.CurrentCulture);
            pdfFormFields.SetField("Travel4000", travACC);
            string trainACC = trainingACC.ToString("C", CultureInfo.CurrentCulture);
            pdfFormFields.SetField("Training5500", trainACC);

            //Signatures
            SqlCommand cmdPDF = new SqlCommand("SELECT a.TravelID,a.UserID,a.UserType,a.TravelType,a.SignatureDate,b.FontType,b.SignatureText FROM [TravelExpenses].[dbo].[TravelSignatures] as a inner join TravelExpenses.dbo.UserSignature as b on b.UserID = a.UserID where a.TravelID = '" + travId + "'  AND a.TravelType = 'Travel'", localCon);
            SqlDataReader drPDF = cmdPDF.ExecuteReader();
            if (drPDF.HasRows)
            {
                while (drPDF.Read())
                {

                    BaseFont bf = BaseFont.CreateFont();
                    if (drPDF["FontType"].ToString() == "Mistral")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\MISTRAL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "Rage Italic")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\Rage Italic.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "MV Boli")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\mvboli.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "Bradley Hand ITC")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\BRADHITC.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "Script MT Bold")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\SCRIPTBL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }

                    DateTime sigDate = Convert.ToDateTime(drPDF["SignatureDate"].ToString());
                    if (drPDF["UserType"].ToString() == "Accounting")
                    {
                        pdfFormFields.SetFieldProperty("Finance Review Siganature", "textfont", bf, null);
                        pdfFormFields.SetField("Finance Review Siganature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Finance Review", sigDate.ToShortDateString());
                    }
                    if (drPDF["UserType"].ToString() == "Supervisor")
                    {
                        pdfFormFields.SetFieldProperty("Supervisor Signature", "textfont", bf, null);
                        pdfFormFields.SetField("Supervisor Signature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Supervisor Date", sigDate.ToShortDateString());
                    }
                    if (drPDF["UserType"].ToString() == "Employee")
                    {
                        pdfFormFields.SetFieldProperty("Employee Signature", "textfont", bf, null);
                        pdfFormFields.SetField("Employee Signature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Employee Date", sigDate.ToShortDateString());
                    }

                }
            }
            drPDF.Close();

            pdfStamper.Close();
            localCon.Close();

           

        }

        private void btnBackSummary_Click(object sender, EventArgs e)
        {
            CommonVariables.isSummary = false;
            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                }
            }
            Form[] childs = main.MdiChildren;

            //int cant = Application.OpenForms.Count;
            bool FormFound = false;

            if (CommonVariables.isOtherExpenses == true) {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "OtherExpenses")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isMileage == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Mileage")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isAirFare == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "AirFare")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isCarRental == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "CarRental")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isLodging == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Lodging")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isRegistartion == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Registration")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isMeals == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Meals")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            else if (CommonVariables.isMeals == false)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "TravelItems")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            if (FormFound)
            {
                this.Hide();
            }
        }

        private void saveAndSendAccountingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CommonVariables.addingItems)
            {
                if (travelUpdate)
                {
                    generateDetailPDFUp();
                    generateSummarizedPDFUp();
                }
                else
                {
                    addTravelItems();
                    generateDetailPDFUp();
                    generateSummarizedPDFUp();
                }
            }
            else
            {
                if (travelSaved)
                {
                    generateSummarizedPDF();
                    generateDetailPDF();
                }
                else
                {
                    saveTravel();
                    generateSummarizedPDF();
                    generateDetailPDF();
                }
            }

            
            btnSaveSplitTravel.Enabled = false;
            btnBackSummary.Enabled = false;
            SupervisorList sl = new SupervisorList();
            sl.ShowDialog();
            ViewPDF vpdf = new ViewPDF();
            vpdf.Show();
            sendToAccounting();
        }

        public bool sendToAccounting()
        {
            localCon.Open();
            Guid userID = new Guid(CommonVariables.user);
            string email = "";
            string supEmail = "";
            string fullname = "";
            string department = "";
            
            //user
            SqlCommand user = new SqlCommand("SELECT b.Email as Email, a.Name as Name, a.LastName as LastName, a.Department as Department  FROM [TravelExpenses].[dbo].[User] as a inner join TravelExpenses.dbo.User_Email_Title as b on b.UserID = a.UserID where a.UserID = '" + userID + "'", localCon);
            SqlDataReader userDR = user.ExecuteReader();
            while (userDR.Read())
            {
                email = userDR["Email"].ToString();
                fullname = userDR["Name"].ToString() + " " + userDR["LastName"].ToString();
                department = userDR["Department"].ToString();
            }
            userDR.Close();


            /*Supervisor
            SqlCommand sup = new SqlCommand("SELECT b.Email as Email, a.Name as Name, a.LastName as LastName, a.Department FROM [TravelExpenses].[dbo].[User] as a inner join TravelExpenses.dbo.User_Email_Title as b on b.UserID = a.UserID where a.Department = '" + department + "' AND a.AccessLevel = '2'", localCon);
            SqlDataReader supDR = sup.ExecuteReader();
            while (supDR.Read())
            {
                supEmail = supDR["Email"].ToString();
                
            }
            userDR.Close();*/


            SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org",587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
            SmtpServer.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(email);
            mail.To.Add("collins@lcmcd.org," + CommonVariables.supervisorEmail);
            mail.Subject = "Review the travel of" + " " + fullname;

            if (CommonVariables.addingItems)
            {
                Guid travAddID = new Guid(CommonVariables.addingTravelID);
                DateTime depDate = DateTime.Today;
                DateTime retDate = DateTime.Today;
                string travEvent = "";
                string destination = "";
                SqlCommand td = new SqlCommand("SELECT [DepartureTime],[DepartureDate],[ReturnTime],[ReturnDate],[TravelEvent],[TravelPurpose],[Origin],[Destination],[TravelState],[Notes] FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travAddID + "'", localCon);
                SqlDataReader dr = td.ExecuteReader();
                while (dr.Read())
                {
                    depDate = Convert.ToDateTime( dr["DepartureDate"].ToString());
                    retDate = Convert.ToDateTime( dr["ReturnDate"].ToString());
                    travEvent = dr["TravelEvent"].ToString();
                    destination = dr["Destination"].ToString();
                }
                dr.Close();

                if (depDate.ToShortDateString() == retDate.ToShortDateString())
                {
                    mail.Body = "Please enter to the travel program and review the travel of" + " " + fullname + " " + "on" + " " + depDate.ToShortDateString() + " in order to " + "attend to " + travEvent + " event, arriving to " + destination;

                }
                else
                {
                    mail.Body = "Please enter to the travel program and review the travel of" + " " + fullname + " " + "on" + " " + depDate.ToShortDateString() + " to " + retDate.ToShortDateString() + " in order to attend to " + travEvent + " event, arriving to " + destination;
                }
            }
            else
            {
                if (CommonVariables.travelDepartureDate.ToShortDateString() == CommonVariables.travelReturnDate.ToShortDateString())
                {
                    mail.Body = "Please enter to the travel program and review the travel of" + " " + fullname + " " + "on" + " " + CommonVariables.travelDepartureDate.ToShortDateString() + " in order to " + "attend to " + CommonVariables.travelEvent + " event, arriving to " + CommonVariables.travelDestination;
                }
                else
                {
                    mail.Body = "Please enter to the travel program and review the travel of" + " " + fullname + " " + "on" + " " + CommonVariables.travelDepartureDate.ToShortDateString() + " to " + CommonVariables.travelReturnDate.ToShortDateString() + " in order to attend to " + CommonVariables.travelEvent + " event, arriving to " + CommonVariables.travelDestination;
                }
            }
            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment(CommonVariables.filePath);
            //mail.Attachments.Add(attachment);
            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };



            try
            {
                SmtpServer.Send(mail);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            localCon.Close();
            return true;
        }

        private void btnBackMeal_Click(object sender, EventArgs e)
        {
            CommonVariables.isSummary = true;
            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                }
            }
            Form[] childs = main.MdiChildren;

     
            bool FormFound = false;

            if (CommonVariables.isMeals == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Meals")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            if (FormFound)
            {
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonVariables.isSummary = true;
            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                }
            }
            Form[] childs = main.MdiChildren;


            bool FormFound = false;

            if (CommonVariables.isRegistartion == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Registration")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            if (FormFound)
            {
                this.Close();
            }
        }

        private void btnLodgingBack_Click(object sender, EventArgs e)
        {
            CommonVariables.isSummary = true;
            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                }
            }
            Form[] childs = main.MdiChildren;


            bool FormFound = false;

            if (CommonVariables.isLodging == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Lodging")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            if (FormFound)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CommonVariables.isSummary = true;
            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                }
            }
            Form[] childs = main.MdiChildren;


            bool FormFound = false;

            if (CommonVariables.isCarRental == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "CarRental")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            if (FormFound)
            {
                this.Close();
            }
        }

        private void btnAirfareBack_Click(object sender, EventArgs e)
        {
            CommonVariables.isSummary = true;
            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                }
            }
            Form[] childs = main.MdiChildren;


            bool FormFound = false;

            if (CommonVariables.isAirFare == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "AirFare")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            if (FormFound)
            {
                this.Close();
            }
        }

        private void btnMileageBack_Click(object sender, EventArgs e)
        {
            CommonVariables.isSummary = true;
            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                }
            }
            Form[] childs = main.MdiChildren;


            bool FormFound = false;

            if (CommonVariables.isMileage == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Mileage")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            if (FormFound)
            {
                this.Hide();
            }
        }

        private void btnOtherExpBack_Click(object sender, EventArgs e)
        {
            CommonVariables.isSummary = true;
            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                }
            }
            Form[] childs = main.MdiChildren;


            bool FormFound = false;

            if (CommonVariables.isOtherExpenses == true)
            {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "OtherExpenses")
                    {
                        child.Focus();
                        child.Show();

                        FormFound = true;
                    }
                }
            }
            if (FormFound)
            {
                this.Close();
            }
        }

        private void generatePDF()
        {

            localCon.Open();
            string name = "";
            string lastname = "";
            string district = "";
            string department = "";
            string fullName = "";
            string username = "";


            //reimbursement variables
            double mealsReimbursement = 0;
            double registratiorReimbursement = 0;
            double lodgingReimbursement = 0;
            double carRentalReimbursement = 0;
            double mileagReimbursement = 0;
            double airfareReimbursement = 0;
            double otherExpenseReimbursement = 0;

            SqlCommand cmdUser = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] where UserID = '" + CommonVariables.user + "'", localCon);
            SqlDataReader drUser = cmdUser.ExecuteReader();
            while (drUser.Read())
            {
                name = drUser["Name"].ToString();
                lastname = drUser["LastName"].ToString();
                district = drUser["District"].ToString();
                department = drUser["Department"].ToString();
                username = drUser["Username"].ToString();
            }
            drUser.Close();
            fullName = name + " " + lastname;



            string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form.pdf";
            string pdfName = fullName + "_" + CommonVariables.travelDepartureDate.ToShortDateString() + "_" + "to" + "_" + CommonVariables.travelReturnDate.ToShortDateString() + ".pdf";
            pdfName = pdfName.Replace("/", "-");
            winUser = winUser.Replace("/", "-");
            string newFile = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\travel_form_" + pdfName;
            CommonVariables.filePath = newFile;

            PdfReader pdfReader = new PdfReader(pdfTemplate);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;



            //user details
            pdfFormFields.SetField("Full Name", fullName);
            pdfFormFields.SetField("District", district);
            pdfFormFields.SetField("Department", department);

            //user details
            pdfFormFields.SetField("Full Name", fullName);
            pdfFormFields.SetField("District", district);
            pdfFormFields.SetField("Department", department);


            //travel details
            pdfFormFields.SetField("Travel Event", CommonVariables.travelEvent);
            pdfFormFields.SetField("Travel Purpose", CommonVariables.travelPurpose);
            pdfFormFields.SetField("Departure Date", CommonVariables.travelDepartureDate.ToShortDateString());
            pdfFormFields.SetField("Departure Time", CommonVariables.travelDepartureTime);
            pdfFormFields.SetField("Return Date", CommonVariables.travelReturnDate.ToShortDateString());
            pdfFormFields.SetField("Return Time", CommonVariables.travelReturnTime.ToString());
            pdfFormFields.SetField("Origin", CommonVariables.travelOrigin);
            pdfFormFields.SetField("Destination", CommonVariables.travelDestination);
            pdfFormFields.SetField("Travel State", CommonVariables.travelState);
            pdfFormFields.SetField("Travel Notes", CommonVariables.travelNotes);



            //Meals Details
            if (CommonVariables.isMeals)
            {

                //summarized
                    string mealCost = CommonVariables.mcl.MealsTotal.ToString("C", CultureInfo.CurrentCulture);
                    mealCost = mealCost.Substring(1);
                    pdfFormFields.SetField("CostMeals", mealCost);
                    pdfFormFields.SetField("NotesMeals", CommonVariables.mcl.Notes);

                //detailed
                pdfFormFields.SetField("BreakfastQuantity", CommonVariables.mcl.Breakfast.ToString());
                pdfFormFields.SetField("LunchQuantity", CommonVariables.mcl.Lunch.ToString());
                pdfFormFields.SetField("DinnerQuantity", CommonVariables.mcl.Dinner.ToString());
                double brekCost = CommonVariables.mcl.Breakfast * CommonVariables.mcl.BreakfastPerDiemRate;
                pdfFormFields.SetField("BreakfastCost", brekCost.ToString());
                double lunchCost = CommonVariables.mcl.Lunch * CommonVariables.mcl.LunchPerDiemRate;
                pdfFormFields.SetField("LunchCost", lunchCost.ToString());
                double dinCost = CommonVariables.mcl.Dinner * CommonVariables.mcl.DinnerPerDiemRate;
                pdfFormFields.SetField("DinnerCost", dinCost.ToString());
                pdfFormFields.SetField("Meals Notes", CommonVariables.mcl.Notes);
                pdfFormFields.SetField("BreakfastPerDiemRate", CommonVariables.mcl.BreakfastPerDiemRate.ToString());
                pdfFormFields.SetField("LunchPerDiemRate", CommonVariables.mcl.LunchPerDiemRate.ToString());
                pdfFormFields.SetField("DinnerPerDiemRate", CommonVariables.mcl.DinnerPerDiemRate.ToString());
                pdfFormFields.SetField("TotalMealsPerDiemRate", CommonVariables.mcl.TotalMealsPerDiemRate.ToString());
                pdfFormFields.SetField("PerDiemLoactionZipCode", CommonVariables.mcl.PerDiemLoactionZipCode.ToString());



                if (CommonVariables.mcl.ProvidedMeals == true)
                {
                    pdfFormFields.SetField("Provided Meals", "Yes");
                }
                else
                {
                    pdfFormFields.SetField("Provided Meals", "No");
                }
                pdfFormFields.SetField("Meals_Total", CommonVariables.mcl.MealsTotal.ToString("C", CultureInfo.CurrentCulture).Substring(1));

                //setting the value for the meals reimbursement
                mealsReimbursement = CommonVariables.mcl.MealsTotal;
                


                //meals dates
                int rowInc = 1;
                for (int i = 0; i < CommonVariables.mdcl.Count; i++)
                {
                    string date = CommonVariables.mdcl[i].Date.ToShortDateString();
                    bool breakfast = CommonVariables.mdcl[i].Breakfast;
                    bool lunch = CommonVariables.mdcl[i].Lunch;
                    bool dinner = CommonVariables.mdcl[i].Dinner;

                    pdfFormFields.SetField("MealDate" + rowInc, date);
                    if (breakfast)
                    {
                        String[] checkboxstates = pdfFormFields.GetAppearanceStates("Breakfast" + rowInc);
                        pdfFormFields.SetField("Breakfast" + rowInc, "Yes");
                    }
                    if (lunch)
                    {
                        String[] checkboxstates = pdfFormFields.GetAppearanceStates("Lunch" + rowInc);
                        pdfFormFields.SetField("Lunch" + rowInc, "Yes");
                    }
                    if (dinner)
                    {
                        String[] checkboxstates = pdfFormFields.GetAppearanceStates("Dinner" + rowInc);
                        pdfFormFields.SetField("Dinner" + rowInc, "Yes");
                    }
                    rowInc++;

                }

                
            }

            //Registration
            if (CommonVariables.isRegistartion)
            {
                string regCost = CommonVariables.rg.RegistrationAmount.ToString("C", CultureInfo.CurrentCulture);
                regCost = regCost.Substring(1);
                pdfFormFields.SetField("CostRegistration", regCost);
                pdfFormFields.SetField("NotesRegistration", CommonVariables.rg.Notes);

                //details
                pdfFormFields.SetField("Registration Cost", regCost); 
                pdfFormFields.SetField("Registartion Notes", CommonVariables.rg.Notes);
                if (CommonVariables.rg.DistrictPay)
                {
                    pdfFormFields.SetField("District Pay Registration", "Yes");
                }
                else
                {
                    pdfFormFields.SetField("District Pay Registration", "No");

                    //setting the value for the registration reimbursement
                    registratiorReimbursement = CommonVariables.rg.RegistrationAmount;

                }

                

            }

            //Lodgings
            if (CommonVariables.isLodging)
            {
                string notesLod = "";
                for (int i = 0; i < CommonVariables.lcl.Count; i++)
                {
                    if (CommonVariables.lcl[i].Notes != "")
                    {
                        notesLod += CommonVariables.lcl[i].Notes + ". ";
                    }
                }
                double lodCostDouble = Convert.ToDouble(txtTotalLod.Text);
                string lodCost = lodCostDouble.ToString("C", CultureInfo.CurrentCulture);
                lodCost = lodCost.Substring(1);
                pdfFormFields.SetField("CostLodgings", lodCost);
                pdfFormFields.SetField("NotesLodgings", notesLod);


                //details
                int row = 1;
                for (int i = 0; i < CommonVariables.lcl.Count; i++)
                {
                    pdfFormFields.SetField("Facility Name" + row, CommonVariables.lcl[i].FacilityName);
                    pdfFormFields.SetField("Facility Total Cost" + row, CommonVariables.lcl[i].TotalLodging.ToString());
                    pdfFormFields.SetField("Lodging Nights" + row, CommonVariables.lcl[i].NumberOfNights.ToString());
                    pdfFormFields.SetField("Lodging Night Cost" + row, CommonVariables.lcl[i].CostPerNight.ToString());
                    pdfFormFields.SetField("Lodging Taxes Fees" + row, CommonVariables.lcl[i].TaxesAndFees.ToString());
                    if (CommonVariables.lcl[i].DistrictPay)
                    {
                        pdfFormFields.SetField("Lodging District Pay" + row, "Yes");
                        pdfFormFields.SetField("Lodging Director Approval" + row, "");
                    }
                    else
                    {
                        pdfFormFields.SetField("Lodging District Pay" + row, "No");
                        if (CommonVariables.lcl[i].DirectorApproved)
                        {
                            pdfFormFields.SetField("Lodging Director Approval" + row, "Yes");

                            //setting the value of the lodging reimbursement
                            lodgingReimbursement += CommonVariables.lcl[i].TotalLodging;
                        }
                        else
                        {
                            pdfFormFields.SetField("Lodging Director Approval" + row, "No");
                        }
                    }

                    pdfFormFields.SetField("Facility  Notes" + row, CommonVariables.lcl[i].Notes);

                    row++;
                }
                //string lodCost = Convert.ToDouble(txtTotalLod.Text).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("Lodging Total", lodCost);

              
                
            }

            //Car Rentals
            if (CommonVariables.isCarRental)
            {
                string notesCar = "";
                for (int i = 0; i < CommonVariables.crcl.Count; i++)
                {
                    if (CommonVariables.crcl[i].Notes != "")
                    {
                        notesCar = CommonVariables.crcl[i].Notes + ". ";
                    }
                }

                double carCostDouble = Convert.ToDouble(txtTotalCar.Text);
                string carCost = carCostDouble.ToString("C", CultureInfo.CurrentCulture);
                carCost = carCost.Substring(1);
                pdfFormFields.SetField("CostCar Rental", carCost);
                pdfFormFields.SetField("NotesCar Rental", notesCar);

                //details
                int carRow = 1;
                for (int i = 0; i < CommonVariables.crcl.Count; i++)
                {
                    pdfFormFields.SetField("Pick up Date" + carRow, CommonVariables.crcl[i].PickUpDate.ToShortDateString());
                    pdfFormFields.SetField("Drop off Date" + carRow, CommonVariables.crcl[i].DropOffDate.ToShortDateString());
                    pdfFormFields.SetField("Car_Day Cost" + carRow, CommonVariables.crcl[i].CostPerDay.ToString());
                    pdfFormFields.SetField("Car Total" + carRow, CommonVariables.crcl[i].TotalCarRental.ToString());
                    pdfFormFields.SetField("Car Type" + carRow, CommonVariables.crcl[i].CarType);
                    pdfFormFields.SetField("Rental Company" + carRow, CommonVariables.crcl[i].Company);
                    pdfFormFields.SetField("Car Rental Days" + carRow, CommonVariables.crcl[i].Days.ToString());
                    pdfFormFields.SetField("Car Rental Taxes Fees" + carRow, CommonVariables.crcl[i].TaxesAndFees.ToString());
                    pdfFormFields.SetField("LDW Insurance" + carRow, CommonVariables.crcl[i].LDWInsuranse.ToString());
                    pdfFormFields.SetField("Supplemental Insurance" + carRow, CommonVariables.crcl[i].SupplementalInsurance.ToString());
                    pdfFormFields.SetField("Extra Insurance" + carRow, CommonVariables.crcl[i].ExtraInsuranceAmount.ToString());
                    if (CommonVariables.crcl[i].DistrictPay)
                    {
                        pdfFormFields.SetField("Car District Pay" + carRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Car District Pay" + carRow, "No");

                        //setting the value for the car rental reimbursement
                        carRentalReimbursement += CommonVariables.crcl[i].TotalCarRental;
                    }
                    pdfFormFields.SetField("Car Personal Amount" + carRow, CommonVariables.crcl[i].PersonalUseAmount.ToString());
                    pdfFormFields.SetField("Car Notes" + carRow, CommonVariables.crcl[i].Notes);

                    carRow++;
                }
                //string carCost = Convert.ToDouble(txtTotalCar.Text).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("Car Rental Total", carCost);
            }

            //Air Fare
            if (CommonVariables.isAirFare)
            {
                string notesAir = "";
                for (int i = 0; i < CommonVariables.afcl.Count; i++)
                {
                    if (CommonVariables.afcl[i].Notes != "")
                    {
                        notesAir += CommonVariables.afcl[i].Notes + ". ";
                    }
                }
                double flighCOstDouble = Convert.ToDouble(txtTotalFlight.Text);
                string flighCOst = flighCOstDouble.ToString("C", CultureInfo.CurrentCulture);
                flighCOst = flighCOst.Substring(1);
                pdfFormFields.SetField("CostAir Fare", flighCOst);
                pdfFormFields.SetField("NotesAir Fare", notesAir);

                //details
                int flightRow = 1;
                for (int i = 0; i < CommonVariables.afcl.Count; i++)
                {
                    pdfFormFields.SetField("Flight_Departure Date" + flightRow, CommonVariables.afcl[i].DepartureDate.ToShortDateString());
                    if (CommonVariables.afcl[i].ReturnDate.ToString() != "")
                    {
                        DateTime rd = Convert.ToDateTime(CommonVariables.afcl[i].ReturnDate);
                        pdfFormFields.SetField("Flight_Return Date" + flightRow, rd.ToShortDateString());
                    }
                    pdfFormFields.SetField("Flight Total" + flightRow, CommonVariables.afcl[i].TotalAirFare.ToString());
                    pdfFormFields.SetField("Flight Taxes  Fees" + flightRow, CommonVariables.afcl[i].TaxesAndFees.ToString());
                    if (CommonVariables.afcl[i].DistrictPay)
                    {
                        pdfFormFields.SetField("Flight District Pay" + flightRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Flight District Pay" + flightRow, "No");

                        //setting the value for the airfare reimbursement
                        airfareReimbursement += CommonVariables.afcl[i].TotalAirFare;
                    }
                    pdfFormFields.SetField("Flight Personal Amount" + flightRow, CommonVariables.afcl[i].PersonalUseAmount.ToString());
                    pdfFormFields.SetField("Air Fare Notes" + flightRow, CommonVariables.afcl[i].Notes);

                    flightRow++;
                }
                //string flightCost = Convert.ToDouble(txtTotalFlight.Text).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("Air Fare Total", flighCOst);
            }

            //Mileage
            if (CommonVariables.isMileage)
            {
                string milCost = CommonVariables.micl.TotalMileage.ToString("C", CultureInfo.CurrentCulture);
                milCost = milCost.Substring(1);
                pdfFormFields.SetField("NotesMileage", CommonVariables.micl.Notes);
                pdfFormFields.SetField("CostMileage", milCost);

                //details
                pdfFormFields.SetField("Map Mileage", CommonVariables.micl.MapMileage.ToString());
                pdfFormFields.SetField("Vicinity Mileage", CommonVariables.micl.VicinityMileage.ToString());
                pdfFormFields.SetField("Mileage Cost", CommonVariables.micl.TotalMileage.ToString("C", CultureInfo.CurrentCulture).Substring(1));
                if (CommonVariables.micl.DistricticProvidedVehicle)
                {
                    pdfFormFields.SetField("Provided Vehicle", "Yes");
                }
                else
                {
                    pdfFormFields.SetField("Provided Vehicle", "No");
                    if (CommonVariables.micl.DirectorApprovedPersonal)
                    {
                        pdfFormFields.SetField("Mileage Director Approval", "Yes");

                        //setting the value for the mileage reimbursement
                        mileagReimbursement = CommonVariables.micl.TotalMileage;
                    }
                    else
                    {
                        pdfFormFields.SetField("Mileage Director Approval", "No");
                    }
                }
                pdfFormFields.SetField("Mileage Notes", CommonVariables.micl.Notes);
            }

            //Other Expenses
            if (CommonVariables.isOtherExpenses)
            {
                string notesOE = "";
                for (int i = 0; i < CommonVariables.oxcl.Count; i++)
                {
                    if (CommonVariables.oxcl[i].Notes != "")
                    {
                        notesOE += CommonVariables.oxcl[i].Notes + ". ";
                    }
                }
                double oeCOstDouble = Convert.ToDouble(txtTotalAmountExpenses.Text);
                string oeCOst = oeCOstDouble.ToString("C", CultureInfo.CurrentCulture);
                oeCOst = oeCOst.Substring(1);
                pdfFormFields.SetField("CostOther Expenses", oeCOst);
                pdfFormFields.SetField("NotesOther Expenses", notesOE);

                //details
                int oxRow = 1;
                for (int i = 0; i < CommonVariables.oxcl.Count; i++)
                {
                    pdfFormFields.SetField("ExpDescription" + oxRow, CommonVariables.oxcl[i].Description);
                    pdfFormFields.SetField("ExpCost" + oxRow, CommonVariables.oxcl[i].Amount.ToString());
                    pdfFormFields.SetField("ExpNotes" + oxRow, CommonVariables.oxcl[i].Notes);
                    if (CommonVariables.oxcl[i].Prepaid)
                    {
                        pdfFormFields.SetField("ExpCard" + oxRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("ExpCard" + oxRow, "No");

                        //setting the value for the other expenses reimbursement
                        otherExpenseReimbursement += CommonVariables.oxcl[i].Amount;
                    }
                    oxRow++;
                }
                //string oeCost = Convert.ToDouble(txtTotalAmountExpenses.Text).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("Other Expenses Total", oeCOst);
            }

            //Tratel Totals
            string travTol = CommonVariables.totalTravel.ToString("C", CultureInfo.CurrentCulture);
            travTol = travTol.Substring(1);
            string reim = CommonVariables.totalReimbursement.ToString("C", CultureInfo.CurrentCulture);
            reim = reim.Substring(1);
            string noReim = CommonVariables.totalNotReimbursement.ToString("C", CultureInfo.CurrentCulture);
            noReim = noReim.Substring(1);
            pdfFormFields.SetField("Travel Total", travTol);
            pdfFormFields.SetField("Total Reimbursed", reim);
            pdfFormFields.SetField("No Reimbursed", noReim);

            pdfFormFields.SetField("Travel Total Cost", CommonVariables.totalTravel.ToString("C", CultureInfo.CurrentCulture).Substring(1));
            pdfFormFields.SetField("Reimbursement", CommonVariables.totalReimbursement.ToString("C", CultureInfo.CurrentCulture).Substring(1));
            pdfFormFields.SetField("No Reimbursed Total", CommonVariables.totalNotReimbursement.ToString("C", CultureInfo.CurrentCulture).Substring(1));
            pdfFormFields.SetField("Date", DateTime.Today.ToShortDateString());


            //Accounting accounts
            string travACC = travelACC.ToString("C", CultureInfo.CurrentCulture);
            pdfFormFields.SetField("Travel4000", travACC);
            string trainACC = trainingACC.ToString("C", CultureInfo.CurrentCulture);
            pdfFormFields.SetField("Training5500", trainACC);

            //Reimbursement Table
            pdfFormFields.SetField("Meals_Reimbursement", mealsReimbursement.ToString());
            pdfFormFields.SetField("Registration_Reimbursement", registratiorReimbursement.ToString());
            pdfFormFields.SetField("Lodgings_Reimbursement", lodgingReimbursement.ToString());
            pdfFormFields.SetField("CarRental_Reimbursement", carRentalReimbursement.ToString());
            pdfFormFields.SetField("Airfare_Reimbursement", airfareReimbursement.ToString());
            pdfFormFields.SetField("Mileage_Reimbursement", mileagReimbursement.ToString());
            pdfFormFields.SetField("OtherExpenses_Reimbursement", otherExpenseReimbursement.ToString());



            //Signatures
            SqlCommand cmdPDF = new SqlCommand("SELECT a.TravelID,a.UserID,a.UserType,a.TravelType,a.SignatureDate,b.FontType,b.SignatureText FROM [TravelExpenses].[dbo].[TravelSignatures] as a inner join TravelExpenses.dbo.UserSignature as b on b.UserID = a.UserID where a.TravelID = '" + travId + "'  AND a.TravelType = 'Travel'", localCon);
            SqlDataReader drPDF = cmdPDF.ExecuteReader();
            if (drPDF.HasRows)
            {
                while (drPDF.Read())
                {

                    BaseFont bf = BaseFont.CreateFont();
                    if (drPDF["FontType"].ToString() == "Mistral")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\MISTRAL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "Rage Italic")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\Rage Italic.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "MV Boli")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\mvboli.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "Bradley Hand ITC")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\BRADHITC.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "Script MT Bold")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\SCRIPTBL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }

                    DateTime sigDate = Convert.ToDateTime(drPDF["SignatureDate"].ToString());
                    if (drPDF["UserType"].ToString() == "Accounting")
                    {
                        pdfFormFields.SetFieldProperty("Finance Review Siganature", "textfont", bf, null);
                        pdfFormFields.SetField("Finance Review Siganature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Finance Review", sigDate.ToShortDateString());
                    }
                    if (drPDF["UserType"].ToString() == "Supervisor")
                    {
                        pdfFormFields.SetFieldProperty("Supervisor Signature", "textfont", bf, null);
                        pdfFormFields.SetField("Supervisor Signature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Supervisor Date", sigDate.ToShortDateString());
                    }
                    if (drPDF["UserType"].ToString() == "Employee")
                    {
                        pdfFormFields.SetFieldProperty("Employee Signature", "textfont", bf, null);
                        pdfFormFields.SetField("Employee Signature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Employee Date", sigDate.ToShortDateString());
                    }

                }
            }
            drPDF.Close();


            pdfStamper.Close();
            localCon.Close();

        }

        private void generatePDFUpd()
        {
            localCon.Open();
            string name = "";
            string lastname = "";
            string district = "";
            string department = "";
            string fullName = "";
            string username = "";
            string departureDate = "";
            string returnDate = "";

            //reimbursement variables
            double mealsReimbursement = 0;
            double registratiorReimbursement = 0;
            double lodgingReimbursement = 0;
            double carRentalReimbursement = 0;
            double mileagReimbursement = 0;
            double airfareReimbursement = 0;
            double otherExpenseReimbursement = 0;

            Guid travID = new Guid(CommonVariables.addingTravelID);

            SqlCommand cmdUser = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[User] where UserID = '" + CommonVariables.user + "'", localCon);
            SqlDataReader drUser = cmdUser.ExecuteReader();
            while (drUser.Read())
            {
                name = drUser["Name"].ToString();
                lastname = drUser["LastName"].ToString();
                district = drUser["District"].ToString();
                department = drUser["Department"].ToString();
                username = drUser["Username"].ToString();
            }
            drUser.Close();
            fullName = name + " " + lastname;

            SqlCommand cmdTDates = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
            SqlDataReader drTDates = cmdTDates.ExecuteReader();
            while (drTDates.Read())
            {
                departureDate = Convert.ToDateTime(drTDates["DepartureDate"].ToString()).ToShortDateString();
                returnDate = Convert.ToDateTime(drTDates["ReturnDate"].ToString()).ToShortDateString();
            }
            drTDates.Close();

            string pdfTemplate = @"\\LCMHCD\Employees\Travel Temp\travel form.pdf";
            string pdfName = fullName + "_" + departureDate + "_" + "to" + "_" + returnDate + ".pdf";
            pdfName = pdfName.Replace("/", "-");
            string newFile = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\travel_form_" + pdfName;
            CommonVariables.filePath = newFile;

            PdfReader pdfReader = new PdfReader(pdfTemplate);
            PdfStamper pdfStamper = new PdfStamper(pdfReader, new FileStream(newFile, FileMode.Create));
            AcroFields pdfFormFields = pdfStamper.AcroFields;



            //user details
            pdfFormFields.SetField("Full Name", fullName);
            pdfFormFields.SetField("District", district);
            pdfFormFields.SetField("Department", department);

            //travel details
            SqlCommand cmdTD = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travID + "'", localCon);
            SqlDataReader drTD = cmdTD.ExecuteReader();
            while (drTD.Read())
            {
                pdfFormFields.SetField("Travel Event", drTD["TravelEvent"].ToString());
                pdfFormFields.SetField("Travel Purpose", drTD["TravelPurpose"].ToString());
                DateTime dd = Convert.ToDateTime(drTD["DepartureDate"].ToString());
                pdfFormFields.SetField("Departure Date", dd.ToShortDateString());
                pdfFormFields.SetField("Departure Time", drTD["DepartureTime"].ToString());
                DateTime rd = Convert.ToDateTime(drTD["ReturnDate"].ToString());
                pdfFormFields.SetField("Return Date", rd.ToShortDateString());
                pdfFormFields.SetField("Return Time", drTD["ReturnTime"].ToString());
                pdfFormFields.SetField("Origin", drTD["Origin"].ToString());
                pdfFormFields.SetField("Destination", drTD["Destination"].ToString());
                pdfFormFields.SetField("Travel State", drTD["TravelState"].ToString());
                pdfFormFields.SetField("Travel Notes", drTD["Notes"].ToString());
                

                //Tratel Totals
                travelACC = Convert.ToDouble(drTD["TotalTravelAmount"].ToString());
                string travCost = travelACC.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                double reimValue = Convert.ToDouble(drTD["TotalTravelReimbursed"].ToString());
                string reimCost = reimValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                double noReimCostValue = Convert.ToDouble(drTD["TotalTravelNoReimbursed"].ToString());
                string noReimCost = noReimCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);

                pdfFormFields.SetField("Travel Total", travCost);
                pdfFormFields.SetField("Total Reimbursed", reimCost);
                pdfFormFields.SetField("No Reimbursed", noReimCost);

                pdfFormFields.SetField("Travel Total Cost", travCost);
                pdfFormFields.SetField("Reimbursement", reimCost);
                pdfFormFields.SetField("No Reimbursed Total", noReimCost);


                //set up the travel common variables
                if (drTD["Melas"].ToString() == "True")
                {
                    CommonVariables.isMeals = true;
                }
                if (drTD["Registration"].ToString() == "True")
                {
                    CommonVariables.isRegistartion = true;
                }
                if (drTD["CarRental"].ToString() == "True")
                {
                    CommonVariables.isCarRental = true;
                }
                if (drTD["Lodging"].ToString() == "True")
                {
                    CommonVariables.isLodging = true;
                }
                if (drTD["AirFare"].ToString() == "True")
                {
                    CommonVariables.isAirFare = true;
                }
                if (drTD["Mileage"].ToString() == "True")
                {
                    CommonVariables.isMileage = true;
                }
                if (drTD["OtherExpenses"].ToString() == "True")
                {
                    CommonVariables.isOtherExpenses = true;
                }
            }
            drTD.Close();

            //Meals Details
            if (CommonVariables.isMeals)
            {
                string mealIDvalue = "";
                SqlCommand cmdMeals = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drMeals = cmdMeals.ExecuteReader();
                while (drMeals.Read())
                {
                    double mealCostValue = Convert.ToDouble(drMeals["TotalMeals"].ToString());
                    mealIDvalue = drMeals["MealsID"].ToString();
                    string mealCost = mealCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("CostMeals", mealCost);
                    pdfFormFields.SetField("NotesMeals", drMeals["Notes"].ToString());

                    //details
                    pdfFormFields.SetField("BreakfastQuantity", drMeals["Breakfast"].ToString());
                    pdfFormFields.SetField("LunchQuantity", drMeals["Lunch"].ToString());
                    pdfFormFields.SetField("DinnerQuantity", drMeals["Dinner"].ToString());
                    int brekCost = Convert.ToInt32(drMeals["Breakfast"].ToString()) * 8;
                    pdfFormFields.SetField("BreakfastCost", brekCost.ToString());
                    int lunchCost = Convert.ToInt32(drMeals["Lunch"].ToString()) * 12;
                    pdfFormFields.SetField("LunchCost", lunchCost.ToString());
                    int dinCost = Convert.ToInt32(drMeals["Dinner"].ToString()) * 20;
                    pdfFormFields.SetField("DinnerCost", dinCost.ToString());
                    pdfFormFields.SetField("Meals Notes", drMeals["Notes"].ToString());
                    pdfFormFields.SetField("BreakfastPerDiemRate", drMeals["BreakfastPerDiemRate"].ToString());
                    pdfFormFields.SetField("LunchPerDiemRate", drMeals["LunchPerDiemRate"].ToString());
                    pdfFormFields.SetField("DinnerPerDiemRate", drMeals["DinnerPerDiemRate"].ToString());
                    pdfFormFields.SetField("TotalMealsPerDiemRate", drMeals["TotalPerDiemRate"].ToString());
                    pdfFormFields.SetField("PerDiemLoactionZipCode", drMeals["PerDiemLoactionZipCode"].ToString());


                    if (drMeals["ProvidedMeal"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Provided Meals", "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Provided Meals", "No");
                    }
                    //string mealCost = Convert.ToDouble(drMeals["TotalMeals"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Meals_Total", mealCost);

                    //setting the value for meal reimbursement
                    mealsReimbursement = mealCostValue;
                }
                drMeals.Close();



                Guid mealID = new Guid(mealIDvalue);
                int rowInc = 1;
                SqlCommand meadDate = new SqlCommand("SELECT [Date] ,[Breaksfast],[Lunch] ,[Dinner] FROM [TravelExpenses].[dbo].[MealDate] where MealsID = '"+ mealID + "' order by date asc", localCon);
                SqlDataReader meadDateDR = meadDate.ExecuteReader();
                while (meadDateDR.Read())
                {
                    DateTime date = Convert.ToDateTime(meadDateDR["Date"].ToString());
                    pdfFormFields.SetField("MealDate" + rowInc, date.ToShortDateString());
                    if(meadDateDR["Breaksfast"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Breakfast" + rowInc, "Yes");
                    }
                    if (meadDateDR["Lunch"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Lunch" + rowInc, "Yes");
                    }
                    if (meadDateDR["Dinner"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Dinner" + rowInc, "Yes");
                    }
                    rowInc++;
                }
                meadDateDR.Close();
            }

            //Registration Details
            if (CommonVariables.isRegistartion)
            {

                SqlCommand cmdRegis = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drRegis = cmdRegis.ExecuteReader();
                while (drRegis.Read())
                {
                    trainingACC = Convert.ToDouble(drRegis["RegistrationAMount"].ToString());
                    travelACC = travelACC - trainingACC;
                    if (travelACC < 0)
                    {
                        travelACC = travelACC * -1;
                    }
                    string totalReg = trainingACC.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("CostRegistration", totalReg);
                    pdfFormFields.SetField("NotesRegistration", drRegis["Notes"].ToString());

                    //details
                    pdfFormFields.SetField("Registration Cost", totalReg);
                    pdfFormFields.SetField("Registartion Notes", drRegis["Notes"].ToString());
                    if (drRegis["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("District Pay Registration", "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("District Pay Registration", "No");

                        //setting the value for the registration reimbursement
                        registratiorReimbursement = Convert.ToDouble(drRegis["RegistrationAMount"].ToString());
                    }
                }
                drRegis.Close();

            }

            //Lodging
            if (CommonVariables.isLodging)
            {

                SqlCommand cmdLod = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drLod = cmdLod.ExecuteReader();

                double totalLod = 0;
                string notes = "";
                int rowLod = 1;
                while (drLod.Read())
                {
                    totalLod = totalLod + Convert.ToDouble(drLod["TotalLodging"].ToString());
                    if (drLod["Notes"].ToString() != "")
                    {
                        notes += drLod["Notes"].ToString() + " .";
                    }

                    //details
                    pdfFormFields.SetField("Facility Name" + rowLod, drLod["FacilityName"].ToString());
                    pdfFormFields.SetField("Facility Total Cost" + rowLod, drLod["TotalLodging"].ToString());
                    //totalLod = totalLod + Convert.ToDouble(drLod["TotalLodging"].ToString());
                    pdfFormFields.SetField("Lodging Nights" + rowLod, drLod["NumberOfNights"].ToString());
                    pdfFormFields.SetField("Lodging Night Cost" + rowLod, drLod["CostPerNight"].ToString());
                    pdfFormFields.SetField("Lodging Taxes Fees" + rowLod, drLod["TaxesAndFees"].ToString());
                    if (drLod["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Lodging District Pay" + rowLod, "Yes");
                        pdfFormFields.SetField("Lodging Director Approval" + rowLod, "");
                    }
                    else
                    {
                        pdfFormFields.SetField("Lodging District Pay" + rowLod, "No");
                        if (drLod["DirectorApproved"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Lodging Director Approval" + rowLod, "Yes");

                            //setting the value for the lodging reimbursement
                            lodgingReimbursement += Convert.ToDouble(drLod["TotalLodging"].ToString());
                        }
                        else
                        {
                            pdfFormFields.SetField("Lodging Director Approval" + rowLod, "No");
                        }
                    }
                    pdfFormFields.SetField("Facility  Notes" + rowLod, drLod["Notes"].ToString());
                    rowLod++;
                }
                drLod.Close();
                string lodgCost = totalLod.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostLodgings", lodgCost);
                pdfFormFields.SetField("NotesLodgings", notes);

                pdfFormFields.SetField("Lodging Total", lodgCost);
            }

            //Car Rental Details
            if (CommonVariables.isCarRental)
            {
                SqlCommand cmdCR = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drCR = cmdCR.ExecuteReader();


                double totalCR = 0;
                string notesCR = "";
                int carRow = 1;
                while (drCR.Read())
                {
                    totalCR = totalCR + Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    if (drCR["Notes"].ToString() != "")
                    {
                        notesCR += drCR["Notes"].ToString() + " .";
                    }

                    //details
                    DateTime pickUp = Convert.ToDateTime(drCR["PickUPDate"].ToString());
                    pdfFormFields.SetField("Pick up Date" + carRow, pickUp.ToShortDateString());
                    DateTime dropOff = Convert.ToDateTime(drCR["DropOffDate"].ToString());
                    pdfFormFields.SetField("Drop off Date" + carRow, dropOff.ToShortDateString());
                    pdfFormFields.SetField("Car_Day Cost" + carRow, drCR["CostPerDay"].ToString());
                    pdfFormFields.SetField("Car Total" + carRow, drCR["TotalCarRental"].ToString());
                    //totalCR = totalCR + Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    pdfFormFields.SetField("Car Type" + carRow, drCR["CarType"].ToString());
                    pdfFormFields.SetField("Rental Company" + carRow, drCR["Company"].ToString());
                    pdfFormFields.SetField("Car Rental Days" + carRow, drCR["Days"].ToString());
                    pdfFormFields.SetField("Car Rental Taxes Fees" + carRow, drCR["TaxesAndFees"].ToString());
                    pdfFormFields.SetField("LDW Insurance" + carRow, drCR["LDWInsuranse"].ToString());
                    pdfFormFields.SetField("Supplemental Insurance" + carRow, drCR["SupplementalInsurance"].ToString());
                    pdfFormFields.SetField("Extra Insurance" + carRow, drCR["ExtarInsuranceAmount"].ToString());
                    if (drCR["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Car District Pay" + carRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Car District Pay" + carRow, "No");

                        //setting the value for the car rental reimbursement
                        carRentalReimbursement += Convert.ToDouble(drCR["TotalCarRental"].ToString());
                    }
                    pdfFormFields.SetField("Car Personal Amount" + carRow, drCR["PersonalAmount"].ToString());
                    pdfFormFields.SetField("Car Notes" + carRow, drCR["Notes"].ToString());

                    carRow++;
                }
                drCR.Close();
                string carCost = totalCR.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostCar Rental", carCost);
                pdfFormFields.SetField("NotesCar Rental", notesCR);

                pdfFormFields.SetField("Car Rental Total", carCost);
            }

            //AirFare Details
            if (CommonVariables.isAirFare)
            {
                SqlCommand cmdAF = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drAF = cmdAF.ExecuteReader();

                double totalAF = 0;
                string notesAF = "";
                int flightRow = 1;

                while (drAF.Read())
                {
                    totalAF = totalAF + Convert.ToDouble(drAF["AirFareTotal"].ToString());
                    if (drAF["Notes"].ToString() != "")
                    {
                        notesAF += drAF["Notes"].ToString() + " .";
                    }

                    //details
                    DateTime depDateFligh = Convert.ToDateTime(drAF["DepartureDate"].ToString()); 
                    pdfFormFields.SetField("Flight_Departure Date" + flightRow, depDateFligh.ToShortDateString());
                    if (drAF["ReturnDate"].ToString() != "")
                    {
                        DateTime rd = Convert.ToDateTime(drAF["ReturnDate"].ToString());
                        pdfFormFields.SetField("Flight_Return Date" + flightRow, rd.ToShortDateString());
                    }
                    pdfFormFields.SetField("Flight Total" + flightRow, drAF["AirFareTotal"].ToString());
                    //totalAF = totalAF + Convert.ToDouble(drAF["AirFareTotal"].ToString());
                    pdfFormFields.SetField("Flight Taxes  Fees" + flightRow, drAF["TaxesAndFees"].ToString());
                    if (drAF["DistrictPay"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Flight District Pay" + flightRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Flight District Pay" + flightRow, "No");

                        //setting the value for the airfare reimbursement
                        airfareReimbursement += Convert.ToDouble(drAF["AirFareTotal"].ToString());
                    }
                    pdfFormFields.SetField("Flight Personal Amount" + flightRow, drAF["PersonalUseAmount"].ToString());
                    pdfFormFields.SetField("Air Fare Notes" + flightRow, drAF["Notes"].ToString());

                    flightRow++;
                }
                drAF.Close();
                string flightCost = totalAF.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostAir Fare", flightCost);
                pdfFormFields.SetField("NotesAir Fare", notesAF);

                pdfFormFields.SetField("Air Fare Total", flightCost);
            }

            //Mileage Details
            if (CommonVariables.isMileage)
            {
                SqlCommand cmdMi = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drMi = cmdMi.ExecuteReader();

                while (drMi.Read())
                {
                    double milCostValue = Convert.ToDouble(drMi["TotalMileage"].ToString());
                    string milcost = milCostValue.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("CostMileage", milcost);
                    pdfFormFields.SetField("NotesMileage", drMi["Notes"].ToString());

                    //details
                    pdfFormFields.SetField("Map Mileage", drMi["MapMileage"].ToString());
                    pdfFormFields.SetField("Vicinity Mileage", drMi["VicinityMileage"].ToString());
                    string milCost = Convert.ToDouble(drMi["TotalMileage"].ToString()).ToString("C", CultureInfo.CurrentCulture).Substring(1);
                    pdfFormFields.SetField("Mileage Cost", milCost);
                    if (drMi["DistrictVehicleProvided"].ToString() == "True")
                    {
                        pdfFormFields.SetField("Provided Vehicle", "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("Provided Vehicle", "No");
                        if (drMi["DirectorApprovedPersonal"].ToString() == "True")
                        {
                            pdfFormFields.SetField("Mileage Director Approval", "Yes");

                            //setting the value for the mileage reimbursement
                            mileagReimbursement = Convert.ToDouble(drMi["TotalMileage"].ToString());
                        }
                        else
                        {
                            pdfFormFields.SetField("Mileage Director Approval", "No");
                        }
                    }
                    pdfFormFields.SetField("Mileage Notes", drMi["Notes"].ToString());
                }
                drMi.Close();
            }

            //Other Expenses
            if (CommonVariables.isOtherExpenses)
            {
                SqlCommand cmdOE = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + travID + "'", localCon);
                SqlDataReader drOE = cmdOE.ExecuteReader();

                double totalOE = 0;
                string notesOE = "";
                int oxRow = 1;
                while (drOE.Read())
                {
                    totalOE = totalOE + Convert.ToDouble(drOE["Amount"].ToString());
                    if (drOE["Notes"].ToString() != "")
                    {
                        notesOE += drOE["Notes"].ToString() + " .";
                    }

                    //details
                    pdfFormFields.SetField("ExpDescription" + oxRow, drOE["Description"].ToString());
                    pdfFormFields.SetField("ExpCost" + oxRow, drOE["Amount"].ToString());
                    //totalOE = totalOE + Convert.ToDouble(drOE["Amount"].ToString());
                    pdfFormFields.SetField("ExpNotes" + oxRow, drOE["Notes"].ToString());
                    if (drOE["Prepaid"].ToString() == "True")
                    {
                        pdfFormFields.SetField("ExpCard" + oxRow, "Yes");
                    }
                    else
                    {
                        pdfFormFields.SetField("ExpCard" + oxRow, "No");

                        //setting the value for the other expenses reimbursement
                        otherExpenseReimbursement += Convert.ToDouble(drOE["Amount"].ToString());
                    }
                    oxRow++;
                }
                drOE.Close();
                string oeCost = totalOE.ToString("C", CultureInfo.CurrentCulture).Substring(1);
                pdfFormFields.SetField("CostOther Expenses", oeCost);
                pdfFormFields.SetField("NotesOther Expenses", notesOE);

                pdfFormFields.SetField("Other Expenses Total", oeCost);
            }

            //Accounting accounts
            string travACC = travelACC.ToString("C", CultureInfo.CurrentCulture);
            pdfFormFields.SetField("Travel4000", travACC);
            string trainACC = trainingACC.ToString("C", CultureInfo.CurrentCulture);
            pdfFormFields.SetField("Training5500", trainACC);

            //Reimbursement Table
            pdfFormFields.SetField("Meals_Reimbursement", mealsReimbursement.ToString());
            pdfFormFields.SetField("Registration_Reimbursement", registratiorReimbursement.ToString());
            pdfFormFields.SetField("Lodgings_Reimbursement", lodgingReimbursement.ToString());
            pdfFormFields.SetField("CarRental_Reimbursement", carRentalReimbursement.ToString());
            pdfFormFields.SetField("Airfare_Reimbursement", airfareReimbursement.ToString());
            pdfFormFields.SetField("Mileage_Reimbursement", mileagReimbursement.ToString());
            pdfFormFields.SetField("OtherExpenses_Reimbursement", otherExpenseReimbursement.ToString());


            //Signatures
            SqlCommand cmdPDF = new SqlCommand("SELECT a.TravelID,a.UserID,a.UserType,a.TravelType,a.SignatureDate,b.FontType,b.SignatureText FROM [TravelExpenses].[dbo].[TravelSignatures] as a inner join TravelExpenses.dbo.UserSignature as b on b.UserID = a.UserID where a.TravelID = '" + travId + "'  AND a.TravelType = 'Travel'", localCon);
            SqlDataReader drPDF = cmdPDF.ExecuteReader();
            if (drPDF.HasRows)
            {
                while (drPDF.Read())
                {

                    BaseFont bf = BaseFont.CreateFont();
                    if (drPDF["FontType"].ToString() == "Mistral")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\MISTRAL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "Rage Italic")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\Rage Italic.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "MV Boli")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\mvboli.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "Bradley Hand ITC")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\BRADHITC.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }
                    if (drPDF["FontType"].ToString() == "Script MT Bold")
                    {
                        bf = BaseFont.CreateFont(@"\\LCMHCD\Employees\Travel Temp\fonts\SCRIPTBL.TTF", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    }

                    DateTime sigDate = Convert.ToDateTime(drPDF["SignatureDate"].ToString());
                    if (drPDF["UserType"].ToString() == "Accounting")
                    {
                        pdfFormFields.SetFieldProperty("Finance Review Siganature", "textfont", bf, null);
                        pdfFormFields.SetField("Finance Review Siganature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Finance Review", sigDate.ToShortDateString());
                    }
                    if (drPDF["UserType"].ToString() == "Supervisor")
                    {
                        pdfFormFields.SetFieldProperty("Supervisor Signature", "textfont", bf, null);
                        pdfFormFields.SetField("Supervisor Signature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Supervisor Date", sigDate.ToShortDateString());
                    }
                    if (drPDF["UserType"].ToString() == "Employee")
                    {
                        pdfFormFields.SetFieldProperty("Employee Signature", "textfont", bf, null);
                        pdfFormFields.SetField("Employee Signature", drPDF["SignatureText"].ToString());
                        pdfFormFields.SetField("Employee Date", sigDate.ToShortDateString());
                    }

                }
            }
            drPDF.Close();

            pdfStamper.Close();
            localCon.Close();


        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CommonVariables.sendChangesNotification(travId);
        }
    }
}
