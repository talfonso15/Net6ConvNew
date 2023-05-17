using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
//using iTextSharp; //commented for net6
//using iTextSharp.text; //commented for net6
//using iTextSharp.text.pdf; //commented for net6
//using iTextSharp.text.xml; //commented for net6
using System.IO;
using System.Data.SqlClient;
using System.Data.SqlTypes;
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
    class CommonVariables : EventArgs
    {
        

        public static string user = "";

        public string User { get { return user; } set { user = value; } }

        public static string addingTravelID = "";

        public string AddingTravelID { get { return addingTravelID; } set { addingTravelID = value; } }

        public static int accessLevel = 1;
        public int AccessLevel { get { return accessLevel; } set { accessLevel = value; } }

        public static bool CheckNet()
        {
            bool stats;
            //if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {
                stats = true;
            }
            else
            {
                stats = false;
            }
            return stats;
        }

        public static bool isMeals;
        public bool IsMeals { get { return isMeals; } set { isMeals = value; } }

        public static bool isRegistartion;

        public bool IsRegistration { get { return isRegistartion; } set { isRegistartion = value; } }

        public static bool isAirFare;

        public bool IsAirFare { get { return isAirFare; } set { isAirFare = value; } }

        public static bool isCarRental;
        
        public bool IsCarRental { get { return isCarRental; } set { isCarRental = value; } }

        public static bool isLodging;
        
        public bool IsLodging { get { return isLodging; } set { isLodging = value; } }

        public static bool isMileage;
        
        public bool IsMileage { get { return isMileage; } set { isMileage = value; } }

        public static bool isOtherExpenses;
        
        public bool IsOtherExpenses { get { return isOtherExpenses; } set { isOtherExpenses = value; } }

       // public static Travel travel = new Travel();

        public static DateTime travelDepartureDate = DateTime.Today;

        public DateTime TravelDepartureDate { get { return travelDepartureDate; } set { travelDepartureDate = value; } }

        public static DateTime travelReturnDate = DateTime.Today;

        public DateTime TravelReturnDate { get { return travelReturnDate; } set { travelReturnDate = value; } }

        public static String travelDepartureTime = DateTime.Now.ToShortTimeString();

        public String TravelDepartureTime { get { return travelDepartureTime; }  set { travelDepartureTime = value; } }
         
        public static String travelReturnTime = DateTime.Now.ToShortTimeString();

        public String TravelReturnTime { get { return travelReturnTime; } set { travelReturnTime = value; } }

        public static String travelEvent = "";

        public String TravelEvent { get { return travelEvent; } set { travelEvent = value; } }

        public static String travelPurpose = "";

        public String TravelPurpose { get { return travelPurpose; } set { travelPurpose = value; } }

        public static String travelOrigin = "";

        public String TravelOrigin { get { return travelOrigin; } set { travelOrigin = value; } }

        public static String travelDestination = "";

        public String TravelDestination { get { return travelDestination; } set { travelDestination = value; } }

        public static String travelState = "";

        public String TravelState { get { return travelState; } set { travelState = value; } }

        public static String travelNotes = "";

        public String TravelNotes { get { return travelNotes; } set { travelNotes = value; } }

        public static Mealscl mcl = new Mealscl();

        public Mealscl Mcl { get { return mcl; } set { mcl = value; } }

        public static List<Lodgingcl> lcl = new List<Lodgingcl>();

        public List<Lodgingcl> Lcl { get { return lcl; } set { lcl = value; } }

        public static List<CarRentalcl> crcl = new List<CarRentalcl>();

        public List<CarRentalcl> Crcl { get { return crcl; } set { crcl = value; } }

        public static List<AirFarecl> afcl = new List<AirFarecl>();

        public List<AirFarecl> Afcl { get { return afcl; } set { afcl = value; } }


        public static Mileagecl micl = new Mileagecl();

        public Mileagecl Micl { get { return micl; } set { micl = value; } }

        public static List<OtherExpensescl> oxcl = new List<OtherExpensescl>();

        public List<OtherExpensescl> Oxcl { get { return oxcl; } set { oxcl = value; } }

        public static List<MealsDatecl> mdcl = new List<MealsDatecl>();

        public List<MealsDatecl> Mdcl { get { return mdcl; } set { mdcl = value; } }

        public static Registartioncl rg = new Registartioncl();

        public Registartioncl Rg { get { return rg; } set { rg = value; } }

        public static double totalTravel = 0;

        public double TotalTravel { get { return totalTravel; } set { totalTravel = value; } }

        public static double totalReimbursement = 0;

        public double TotalReimbursement { get { return totalReimbursement; } set { totalReimbursement = value; } }

        public static double totalNotReimbursement = 0;

        public double TotalNotReimbursement { get { return totalNotReimbursement; } set { totalNotReimbursement = value; } }

        public static bool addingItems = false;

        public bool AddingItems { get { return addingItems; } set { addingItems = value; } }

        public static EstimateTravelcl et = new EstimateTravelcl();
        public EstimateTravelcl ET { get { return et; } set { et = value; } }

        public static double estimateMileageCost = 0;
        public double EstimateMileageCost { get { return estimateMileageCost; } set { estimateMileageCost = value; } }

        public static bool estimateMileagePersonal;

        public bool EstimateMileagePersonal { get { return estimateMileagePersonal; } set { estimateMileagePersonal = value; } }

        public static void CancelTravel() {

            FormCollection fc = Application.OpenForms;
            Form main = new Form();
            foreach (Form frm in fc)
            {
                string name = frm.Name;
                if (frm.Name == "Main")
                {
                    main = frm;
                    break;
                }
            }
            Form[] childs = main.MdiChildren;


            //Register Travel
            foreach (Form child in childs)
            {
                string name = child.Name;
                if (child.Name == "RegisterTravel")
                {

                    child.Close();
                    break;
                    
                }
            }
            CommonVariables.travelDepartureDate = DateTime.Today;
            CommonVariables.travelDepartureTime = "";
            CommonVariables.travelReturnDate = DateTime.Today;
            CommonVariables.travelReturnTime = "";
            CommonVariables.travelEvent = "";
            CommonVariables.travelPurpose = "";
            CommonVariables.travelOrigin = "";
            CommonVariables.travelDestination = "";
            CommonVariables.travelNotes = "";
            CommonVariables.travelState = "";
            CommonVariables.supervisorEmail = "";
            

            //Travel Items
            foreach (Form child in childs)
            {
                string name = child.Name;
                if (child.Name == "TravelItems")
                {
                    child.Close();
                    break;
                }
            }
            if (CommonVariables.isMeals) {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Meals")
                    {

                        child.Close();
                        break;

                    }
                }
                CommonVariables.mcl.Breakfast = 0;
                CommonVariables.mcl.Lunch = 0;
                CommonVariables.mcl.Dinner = 0;
                CommonVariables.mcl.MealsTotal = 0;
                CommonVariables.mcl.ProvidedMeals = false;
                CommonVariables.mcl.MealsTotal = 0;

                CommonVariables.mdcl.Clear();

            }

            if (CommonVariables.isRegistartion) {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Registration")
                    {

                        child.Close();
                        break;

                    }
                }
                CommonVariables.rg.DistrictPay = false;
                CommonVariables.rg.RegistrationAmount = 0;
                CommonVariables.rg.Notes = "";
            }
            if (CommonVariables.isLodging) {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Lodging")
                    {

                        child.Close();
                        break;

                    }
                }
                CommonVariables.lcl.Clear();
            }
            if (CommonVariables.isCarRental) {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "CarRental")
                    {
                        child.Close();
                        break;
                    }
                }
                CommonVariables.crcl.Clear();
            }
            if (CommonVariables.isAirFare) {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "AirFare")
                    {
                        child.Close();
                        break;
                    }
                }
                CommonVariables.afcl.Clear();
            }
            if (CommonVariables.isMileage) {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "Mileage")
                    {
                        child.Close();
                        break;
                    }
                }
                CommonVariables.micl.DirectorApprovedPersonal = false;
                CommonVariables.micl.DistricticProvidedVehicle = true;
                CommonVariables.micl.MapMileage = 0;
                CommonVariables.micl.VicinityMileage = 0;
                CommonVariables.micl.TotalMileage = 0;
                CommonVariables.micl.Notes = "";
            }
            if (CommonVariables.isOtherExpenses) {
                foreach (Form child in childs)
                {
                    string name = child.Name;
                    if (child.Name == "OtherExpenses")
                    {
                        child.Close();
                        break;
                    }
                }
                CommonVariables.oxcl.Clear();
            }

            foreach (Form child in childs)
            {
                string name = child.Name;
                if (child.Name == "Summary")
                {
                    child.Close();
                    break;
                }
            }

            CommonVariables.isMeals = false;
            CommonVariables.isRegistartion = false;
            CommonVariables.isLodging = false;
            CommonVariables.isCarRental = false;
            CommonVariables.isAirFare = false;
            CommonVariables.isMileage = false;
            CommonVariables.isOtherExpenses = false;
            CommonVariables.isSummary = false;
           

            CommonVariables.totalNotReimbursement = 0;
            CommonVariables.totalReimbursement = 0;
            CommonVariables.totalTravel = 0;
            CommonVariables.addingItems = false;
            CommonVariables.addingTravelID = "";
            CommonVariables.filePath = "";
            CommonVariables.detailedFilePath = "";

            CommonVariables.is_TPT = false;
            CommonVariables.isGroup = false;
            CommonVariables.usersID = new List<string>();
            CommonVariables.tpt_UserID = "";
            CommonVariables.tpt_Type = "";
        }

        public static string editTravelID = "";

        public string EditTravelID { get { return editTravelID; } set { editTravelID = value; } }

        public static string filePath = "";

        public string FilePath { get { return filePath; } set { filePath = value; } }

        public static string detailedFilePath = "";

        public string DetailedFilePath { get { return detailedFilePath; } set { detailedFilePath = value; } }

        public static string viewTravelID = "";

        public string ViewTravelID { get { return viewTravelID; } set { viewTravelID = value; } }

        public static string viewTravelUserID = "";

        public string ViewTravelUserID { get { return viewTravelUserID; } set { viewTravelUserID = value; } }

        public static bool viewDetails;

        public bool ViewDetails { get { return viewDetails; } set { viewDetails = value; } }

        public static string signatureFont = "";

        public string SignatureFont { get { return signatureFont; } set { signatureFont = value; } }

        public static string signatureText = "";

        public string SignatureText { get { return signatureText; } set { signatureText = value; } }

        public static string viewEstimateId = "";

        public string ViewEstimateId { get { return viewEstimateId; } set { viewEstimateId = value; } }

        public static bool isUserSignatureExist = false;

        public bool IsUserSignatureExist { get { return isUserSignatureExist; } set { isUserSignatureExist = value; } }

        public static string userIDSiganture = "";
        
        public string UserIDSiganture { get { return userIDSiganture; } set { userIDSiganture = value; } }

        public static bool isSupervisor = false;

        public bool IsSupervisor { get { return isSupervisor; } set { isSupervisor = value; } }

        public static string supervisorEmail = "";

        public string SupervisorEmail { get { return supervisorEmail; } set { supervisorEmail = value; } }

        public static string userEmail = "";
        public string UserEmail {get { return userEmail; } set { userEmail = value; } }

        public static void SendNotification(string userType, string email, DateTime depDate, DateTime retDate, string travEvent, string destination)
        {
            SmtpClient SmtpServer = new SmtpClient("mail.lcmcd.org", 587);
            SmtpServer.Credentials = new System.Net.NetworkCredential("xerox@lchcd.org", "Pa$$w0rd1");
            SmtpServer.EnableSsl = true;

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(email);
            mail.To.Add(email);
            mail.Subject = "Your travel was approved by " + userType;

        
            if (depDate.ToShortDateString() == retDate.ToShortDateString())
            {
                mail.Body = "Your travel for the "  + depDate.ToShortDateString() + " in order to " + "attend to " + travEvent + " event, arriving to " + destination + ", was approved by " + userType;

            }
            else
            {
                mail.Body = "Your travel for the "  + depDate.ToShortDateString() + " to " + retDate.ToShortDateString() + " in order to attend to " + travEvent + " event, arriving to " + destination + ", was approved by " + userType;
            }

            ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };

            try
            {
                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static bool isSummary = false;

        public bool IsSummary { get { return isSummary; } set { isSummary = value; } }

        public static bool is_TPT = false;

        public bool Is_TPT { get { return is_TPT; } set { is_TPT = value; } }

        public static bool isGroup = false;

        public bool IsGroup { get { return isGroup; } set { isGroup = value; } }

        public static List<string> usersID = new List<string>();

        public List<string> UsersID { get { return usersID; } set { usersID = value; } }

        public static string tpt_UserID = "";

        public string TPT_UserID { get { return tpt_UserID; } set { tpt_UserID = value; } }

        public static string tpt_Type = "";

        public string TPT_Type { get { return tpt_Type; } set { tpt_Type = value; } }

        public static bool showSignButton = false;

        public bool ShowSignButton { get { return showSignButton; } set { showSignButton = value; } }

        public static string idForPDFViewer = "";
        public string IdForPDFViewer { get { return idForPDFViewer; } set { idForPDFViewer = value; } }

        public static bool isEstimate = false;

        public bool IsEstimate { get { return isEstimate; } set { isEstimate = value; } }

        public static string carRentalSelId = "";
        
        public string CarRentalSelId { get { return carRentalSelId; } set { carRentalSelId = value; } }

        public static string airfareSelId = "";

        public string AirfareSelId { get { return airfareSelId; } set { airfareSelId = value; } }

        public static string lodgingSelId = "";

        public string LodgingSelId { get { return lodgingSelId; } set { lodgingSelId = value; } }

        public static string otherExpselId = "";

        public string OtherExpselId { get { return otherExpselId; } set { otherExpselId = value; } }

        public static void sendChangesNotification(Guid travelId) 
        {
            SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
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

            SqlCommand travelData = new SqlCommand("SELECT [ReturnDate],[DepartureDate],[TravelEvent],[Destination] FROM [TravelExpenses].[dbo].[Travel] where TravelID = '" + travelId + "'", localCon);
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
                mail.Body = "Travel Event: " + travelEvent + " on " + departureDate.ToShortDateString() + " was updated by " + username;
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

        public int TotalDaysMeals { get { return totalDaysMeals; } set { totalDaysMeals = value; } }

        public static int totalDaysMeals = 0;

    }

}
