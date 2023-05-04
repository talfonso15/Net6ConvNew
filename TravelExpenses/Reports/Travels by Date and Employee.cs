using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.Globalization;

using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace TravelExpenses
{
    public partial class Travels_by_Date_and_Employee : Form
    {
        string winUser = Environment.UserName;
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string username = "";
        string supDepartment = "";
        string filepath = "";
        public Travels_by_Date_and_Employee()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            pictureBox1.Visible = true;
            btnExport.Enabled = false;
            panel1.Enabled = false;
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            
        }

        private void CreateMosquitoAllExcel()
        {
            Excel.Application myExcelApp;
            Excel.Workbooks myExcelWorkbooks;
            Excel.Workbook myExcelWorkbook;

            Excel.Sheets myExcelSheets;
           // Excel._Worksheet firstWorkSheet;

            object misValue = System.Reflection.Missing.Value;

            //string username = "";
            string totalCost = "";
            string depNumber = "";

            bool meals = false;
            bool reg = false;
            bool lod = false;
            bool cr = false;
            bool af = false;
            bool ml = false;
            bool oe = false;

            string mealsTotal = "";
            string regTotal = "";
            string lodTotal = "";
            string crTotal = "";
            string afTotal = "";
            string mlTotal = "";
            string oeTotal = "";
            int rowIndex = 10;


            myExcelApp = new Excel.Application();

            myExcelWorkbooks = myExcelApp.Workbooks;
            String fileName = "";
            string finalFileName = "";

            fileName = @"\\LCMHCD\Employees\Travel Temp\Mosquito Travel Report.xlsx";

            finalFileName = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\Mosquito Travel Report.xlsx";

            filepath = finalFileName;

            myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);

            myExcelSheets = myExcelWorkbook.Worksheets;

           

            int l = 1;
            string className = "";
            string department = "";
            string headerName = "";
            while (l < 4)
            {
                if (l == 1)
                {
                    className = "105";
                    department = "Field Validation 105";
                    headerName = "Field Validation";

                }
                else if (l == 2)
                {
                    className = "106";
                    department = "Mosquito Group 106";
                    headerName = "Mosquito Group";
                }
                else if (l == 3)
                {
                    className = "108";
                    department = "Scientific Intelligence 108";
                    headerName = "Scientific Intelligence";
                }

                Excel.Worksheet myExcelWorksheet = (Excel.Worksheet)myExcelSheets.Item[l];

                List<Travel> travels = new List<Travel>();

                myExcelWorksheet.get_Range("A4", misValue).Formula = headerName + " -  SUMMARY (" + dtpStartDate.Value.ToShortDateString() + "-" + dtpEndDate.Value.ToShortDateString() + ")";
                myExcelWorksheet.get_Range("C6", misValue).Formula = "FYE " + dtpEndDate.Value.Year + " Budget Detail";
                myExcelWorksheet.get_Range("I6", misValue).Formula = "FYE " + dtpEndDate.Value.AddYears(1).Year + " Budget Request";
                myExcelWorksheet.get_Range("G7", misValue).Formula = "FYE " + dtpEndDate.Value.AddYears(1).Year;
                myExcelWorksheet.get_Range("A3", misValue).Formula = dtpEndDate.Value.Year + " Fiscal Year Budget";

                localCon.Open();
                SqlCommand travs = new SqlCommand("SELECT a.*  FROM [TravelExpenses].[dbo].[Travel] as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID where b.Department = '" + department + "' AND a.DepartureDate BETWEEN '" + dtpStartDate.Value.ToShortDateString() + "' AND '" + dtpEndDate.Value.ToShortDateString() + "'", localCon);
                SqlDataReader travsDR = travs.ExecuteReader();
                if (travsDR.HasRows)
                {
                    while (travsDR.Read())
                    {
                        Travel currentTravel = new Travel();
                        Guid travID = new Guid(travsDR["TravelID"].ToString());
                        Guid userID = new Guid(travsDR["UserID"].ToString());
                        currentTravel.TravelID = travID;
                        currentTravel.UserID = userID;
                        currentTravel.Destination = travsDR["Destination"].ToString();
                        currentTravel.Meals = Convert.ToBoolean(travsDR["Melas"].ToString());
                        currentTravel.Registration = Convert.ToBoolean(travsDR["Registration"].ToString());
                        currentTravel.Lodgings = Convert.ToBoolean(travsDR["Lodging"].ToString());
                        currentTravel.CarRental = Convert.ToBoolean(travsDR["CarRental"].ToString());
                        currentTravel.Airfare = Convert.ToBoolean(travsDR["AirFare"].ToString());
                        currentTravel.Mileage = Convert.ToBoolean(travsDR["Mileage"].ToString());
                        currentTravel.OtherExpeses = Convert.ToBoolean(travsDR["OtherExpenses"].ToString());
                        currentTravel.TotalTravelAmount = Convert.ToDouble(travsDR["TotalTravelAmount"].ToString());
                        currentTravel.TravelEvent = travsDR["TravelEvent"].ToString();
                        travels.Add(currentTravel);
                    }
                }
                travsDR.Close();

                for (int i = 0; i < travels.Count; i++)
                {
                    string descrption = "";
                    string employee = "";

                    SqlCommand emp = new SqlCommand("SELECT Concat(Name,' ',LastName) as Employee FROM [TravelExpenses].[dbo].[User] where UserID = '" + travels[i].UserID + "'", localCon);
                    SqlDataReader empDR = emp.ExecuteReader();
                    if (empDR.HasRows)
                    {
                        while (empDR.Read())
                        {
                            employee = empDR["Employee"].ToString();
                        }
                    }
                    empDR.Close();

                    if (travels[i].Meals)
                    {
                        SqlCommand mealscmd = new SqlCommand("SELECT [TotalMeals] FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travels[i].TravelID + "'", localCon);
                        SqlDataReader mealscmdDR = mealscmd.ExecuteReader();
                        if (mealscmdDR.HasRows)
                        {
                            while (mealscmdDR.Read())
                            {
                                mealsTotal = mealscmdDR["TotalMeals"].ToString();

                            }
                        }
                        mealscmdDR.Close();
                        descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Meals";
                        myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                        myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                        myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = mealsTotal;
                        myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = className;
                        descrption = "";
                        rowIndex++;
                    }
                    if (travels[i].Registration)
                    {
                        SqlCommand regcmd = new SqlCommand("SELECT [RegistrationAMount] FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + travels[i].TravelID + "'", localCon);
                        SqlDataReader regcmdDR = regcmd.ExecuteReader();
                        if (regcmdDR.HasRows)
                        {
                            while (regcmdDR.Read())
                            {
                                regTotal = regcmdDR["RegistrationAMount"].ToString();
                            }
                        }
                        regcmdDR.Close();
                        descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Registration";
                        myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                        myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                        myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = regTotal;
                        myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = className;
                        descrption = "";
                        rowIndex++;

                    }
                    if (travels[i].Lodgings)
                    {
                        double totalLod = 0;
                        SqlCommand lodcmd = new SqlCommand("SELECT [TotalLodging] FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '" + travels[i].TravelID + "'", localCon);
                        SqlDataReader lodcmdDR = lodcmd.ExecuteReader();
                        if (lodcmdDR.HasRows)
                        {
                            while (lodcmdDR.Read())
                            {
                                totalLod += Convert.ToDouble(lodcmdDR["TotalLodging"].ToString());
                            }
                            lodTotal = totalLod.ToString();
                        }
                        lodcmdDR.Close();
                        descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Lodgings";
                        myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                        myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                        myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = lodTotal;
                        myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = className;
                        descrption = "";
                        rowIndex++;
                    }
                    if (travels[i].CarRental)
                    {
                        SqlCommand crcmd = new SqlCommand("SELECT [TotalCarRental] FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + travels[i].TravelID + "'", localCon);
                        SqlDataReader crcmdDR = crcmd.ExecuteReader();
                        if (crcmdDR.HasRows)
                        {
                            double totalCR = 0;
                            while (crcmdDR.Read())
                            {
                                totalCR += Convert.ToDouble(crcmdDR["TotalCarRental"].ToString());
                            }

                            crTotal = totalCR.ToString();
                        }
                        crcmdDR.Close();
                        descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Car Rental";
                        myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                        myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                        myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = crTotal;
                        myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = className;
                        descrption = "";
                        rowIndex++;
                    }
                    if (travels[i].Airfare)
                    {
                        SqlCommand afcmd = new SqlCommand("SELECT [AirFareTotal] FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '" + travels[i].TravelID + "'", localCon);
                        SqlDataReader afcmdDR = afcmd.ExecuteReader();
                        if (afcmdDR.HasRows)
                        {
                            double totalAF = 0;
                            while (afcmdDR.Read())
                            {
                                totalAF += Convert.ToDouble(afcmdDR["AirFareTotal"].ToString());
                            }
                            afTotal = totalAF.ToString();
                        }
                        afcmdDR.Close();
                        descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Air Fare";
                        myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                        myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                        myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = afTotal;
                        myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = className;
                        descrption = "";
                        rowIndex++;
                    }
                    if (travels[i].Mileage)
                    {
                        SqlCommand mlcmd = new SqlCommand("SELECT [TotalMileage] FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + travels[i].TravelID + "'", localCon);
                        SqlDataReader mlcmdDR = mlcmd.ExecuteReader();
                        if (mlcmdDR.HasRows)
                        {
                            while (mlcmdDR.Read())
                            {
                                mlTotal = mlcmdDR["TotalMileage"].ToString();
                            }
                        }
                        mlcmdDR.Close();
                        descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Mileage";
                        myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                        myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                        myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = mlTotal;
                        myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = className;
                        descrption = "";
                        rowIndex++;
                    }
                    if (travels[i].OtherExpeses)
                    {
                        SqlCommand oecmd = new SqlCommand("SELECT [Amount] FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + travels[i].TravelID + "'", localCon);
                        SqlDataReader oecmdDR = oecmd.ExecuteReader();
                        if (oecmdDR.HasRows)
                        {
                            double totalOE = 0;
                            while (oecmdDR.Read())
                            {
                                totalOE += Convert.ToDouble(oecmdDR["Amount"].ToString());
                            }
                            oeTotal = totalOE.ToString();
                        }
                        oecmdDR.Close();
                        descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Other Expenses";
                        myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                        myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                        myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = oeTotal;
                        myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = className;
                        descrption = "";
                        rowIndex++;
                    }
                }

                localCon.Close();


                l++;
                rowIndex = 10;
            }
            myExcelWorkbook.SaveAs(finalFileName, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlNoChange, misValue, misValue, misValue, misValue, misValue);
            myExcelWorkbooks.Close();
           // MessageBox.Show("Excel created");

        }

        private void Travels_by_Date_and_Employee_Load(object sender, EventArgs e)
        {
            localCon.Open();
            SqlCommand user = new SqlCommand("SELECT Username,Department FROM [TravelExpenses].[dbo].[User] where UserID = '" + CommonVariables.user +"'", localCon);
            SqlDataReader userDR = user.ExecuteReader();
            if (userDR.HasRows)
            {
                while (userDR.Read())
                {
                    username = userDR["Username"].ToString();
                    supDepartment = userDR["Department"].ToString();
                }
            }userDR.Close();
            localCon.Close();

            if (username == "KBaker")
            {
                cblDepartments.SetItemChecked(4, true);
                cblDepartments.SetItemChecked(5, true);
                cblDepartments.SetItemChecked(7, true);
            }
            else
            {
                for (int i = 0; i < cblDepartments.Items.Count; i++)
                {
                    if ((string)cblDepartments.Items[i] == supDepartment)
                    {
                        cblDepartments.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void CreateHyacinthExcel()
        {
            Excel.Application myExcelApp;
            Excel.Workbooks myExcelWorkbooks;
            Excel.Workbook myExcelWorkbook;
            object misValue = System.Reflection.Missing.Value;

            string username = "";
            string totalCost = "";
            string depNumber = "";

            bool meals = false;
            bool reg = false;
            bool lod = false;
            bool cr = false;
            bool af = false;
            bool ml = false;
            bool oe = false;

            string mealsTotal = "";
            string regTotal = "";
            string lodTotal = "";
            string crTotal = "";
            string afTotal = "";
            string mlTotal = "";
            string oeTotal = "";
            int rowIndex = 10;


            myExcelApp = new Excel.Application();

            myExcelWorkbooks = myExcelApp.Workbooks;
            String fileName = "";
            string finalFileName = "";

            fileName = @"\\LCMHCD\Employees\Travel Temp\Hyacinth Travel Report.xlsx";

            finalFileName = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\Hyacinth Travel Report.xlsx";

            filepath = finalFileName;

            myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
            Excel.Worksheet myExcelWorksheet = (Excel.Worksheet)myExcelWorkbook.ActiveSheet;

            myExcelWorksheet.get_Range("A4", misValue).Formula = "Hyacinth -  SUMMARY (" + dtpStartDate.Value.ToShortDateString() + "-" + dtpEndDate.Value.ToShortDateString() + ")" ;
            myExcelWorksheet.get_Range("C6", misValue).Formula = "FYE " + dtpEndDate.Value.Year + " Budget Detail";
            myExcelWorksheet.get_Range("I6", misValue).Formula = "FYE " + dtpEndDate.Value.AddYears(1).Year + " Budget Request";
            myExcelWorksheet.get_Range("G7", misValue).Formula = "FYE " + dtpEndDate.Value.AddYears(1).Year;

            List <Travel> travels = new List<Travel>();

            localCon.Open();
            SqlCommand travs = new SqlCommand("SELECT a.*  FROM [TravelExpenses].[dbo].[Travel] as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID where b.Department = 'Hyacinth' AND a.DepartureDate BETWEEN '" + dtpStartDate.Value.ToShortDateString() + "' AND '" + dtpEndDate.Value.ToShortDateString() + "'", localCon);
            SqlDataReader travsDR = travs.ExecuteReader();
            if (travsDR.HasRows)
            {
                while (travsDR.Read())
                {
                    Travel currentTravel = new Travel();
                    Guid travID = new Guid(travsDR["TravelID"].ToString());
                    Guid userID = new Guid(travsDR["UserID"].ToString());
                    currentTravel.TravelID = travID;
                    currentTravel.UserID = userID;
                    currentTravel.Destination = travsDR["Destination"].ToString();
                    currentTravel.Meals = Convert.ToBoolean(travsDR["Melas"].ToString());
                    currentTravel.Registration = Convert.ToBoolean(travsDR["Registration"].ToString());
                    currentTravel.Lodgings = Convert.ToBoolean(travsDR["Lodging"].ToString());
                    currentTravel.CarRental = Convert.ToBoolean(travsDR["CarRental"].ToString());
                    currentTravel.Airfare = Convert.ToBoolean(travsDR["AirFare"].ToString());
                    currentTravel.Mileage = Convert.ToBoolean(travsDR["Mileage"].ToString());
                    currentTravel.OtherExpeses = Convert.ToBoolean(travsDR["OtherExpenses"].ToString());
                    currentTravel.TotalTravelAmount = Convert.ToDouble(travsDR["TotalTravelAmount"].ToString());
                    currentTravel.TravelEvent = travsDR["TravelEvent"].ToString();
                    travels.Add(currentTravel);
                }
            }
            travsDR.Close();

            for (int i = 0; i < travels.Count; i++)
            {
                string descrption = "";
                string employee = "";

                SqlCommand emp = new SqlCommand("SELECT Concat(Name,' ',LastName) as Employee FROM [TravelExpenses].[dbo].[User] where UserID = '" + travels[i].UserID + "'", localCon);
                SqlDataReader empDR = emp.ExecuteReader();
                if (empDR.HasRows)
                {
                    while (empDR.Read())
                    {
                        employee = empDR["Employee"].ToString();
                    }
                }
                empDR.Close();

                if (travels[i].Meals)
                {
                    SqlCommand mealscmd = new SqlCommand("SELECT [TotalMeals] FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader mealscmdDR = mealscmd.ExecuteReader();
                    if (mealscmdDR.HasRows)
                    {
                        while (mealscmdDR.Read())
                        {
                            mealsTotal = mealscmdDR["TotalMeals"].ToString();

                        }
                    }
                    mealscmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Meals";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = mealsTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = "Hyacinth";
                    descrption = "";
                    rowIndex++;
                }
                if (travels[i].Registration)
                {
                    SqlCommand regcmd = new SqlCommand("SELECT [RegistrationAMount] FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader regcmdDR = regcmd.ExecuteReader();
                    if (regcmdDR.HasRows)
                    {
                        while (regcmdDR.Read())
                        {
                            regTotal = regcmdDR["RegistrationAMount"].ToString();
                        }
                    }
                    regcmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Registration";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = regTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = "Hyacinth";
                    descrption = "";
                    rowIndex++;

                }
                if (travels[i].Lodgings)
                {
                    double totalLod = 0;
                    SqlCommand lodcmd = new SqlCommand("SELECT [TotalLodging] FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader lodcmdDR = lodcmd.ExecuteReader();
                    if (lodcmdDR.HasRows)
                    {
                        while (lodcmdDR.Read())
                        {
                            totalLod += Convert.ToDouble(lodcmdDR["TotalLodging"].ToString());
                        }
                        lodTotal = totalLod.ToString();
                    }
                    lodcmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Lodgings";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = lodTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = "Hyacinth";
                    descrption = "";
                    rowIndex++;
                }
                if (travels[i].CarRental)
                {
                    SqlCommand crcmd = new SqlCommand("SELECT [TotalCarRental] FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader crcmdDR = crcmd.ExecuteReader();
                    if (crcmdDR.HasRows)
                    {
                        double totalCR = 0;
                        while (crcmdDR.Read())
                        {
                            totalCR += Convert.ToDouble(crcmdDR["TotalCarRental"].ToString());
                        }

                        crTotal = totalCR.ToString();
                    }
                    crcmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Car Rental";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = crTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = "Hyacinth";
                    descrption = "";
                    rowIndex++;
                }
                if (travels[i].Airfare)
                {
                    SqlCommand afcmd = new SqlCommand("SELECT [AirFareTotal] FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader afcmdDR = afcmd.ExecuteReader();
                    if (afcmdDR.HasRows)
                    {
                        double totalAF = 0;
                        while (afcmdDR.Read())
                        {
                            totalAF += Convert.ToDouble(afcmdDR["AirFareTotal"].ToString());
                        }
                        afTotal = totalAF.ToString();
                    }
                    afcmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Air Fare";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = afTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = "Hyacinth";
                    descrption = "";
                    rowIndex++;
                }
                if (travels[i].Mileage)
                {
                    SqlCommand mlcmd = new SqlCommand("SELECT [TotalMileage] FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader mlcmdDR = mlcmd.ExecuteReader();
                    if (mlcmdDR.HasRows)
                    {
                        while (mlcmdDR.Read())
                        {
                            mlTotal = mlcmdDR["TotalMileage"].ToString();
                        }
                    }
                    mlcmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Mileage";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = mlTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = "Hyacinth";
                    descrption = "";
                    rowIndex++;
                }
                if (travels[i].OtherExpeses)
                {
                    SqlCommand oecmd = new SqlCommand("SELECT [Amount] FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader oecmdDR = oecmd.ExecuteReader();
                    if (oecmdDR.HasRows)
                    {
                        double totalOE = 0;
                        while (oecmdDR.Read())
                        {
                            totalOE += Convert.ToDouble(oecmdDR["Amount"].ToString());
                        }
                        oeTotal = totalOE.ToString();
                    }
                    oecmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Other Expenses";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = oeTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = "Hyacinth";
                    descrption = "";
                    rowIndex++;
                }
            }

            localCon.Close();

            myExcelWorksheet.SaveAs(finalFileName, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
            myExcelWorkbooks.Close();
           // MessageBox.Show("Excel created");
        }

        private void CreateOtherDepExcel()
        {
            Excel.Application myExcelApp;
            Excel.Workbooks myExcelWorkbooks;
            Excel.Workbook myExcelWorkbook;
            object misValue = System.Reflection.Missing.Value;

            string username = "";
            string totalCost = "";
            string depNumber = "";

            bool meals = false;
            bool reg = false;
            bool lod = false;
            bool cr = false;
            bool af = false;
            bool ml = false;
            bool oe = false;

            string mealsTotal = "";
            string regTotal = "";
            string lodTotal = "";
            string crTotal = "";
            string afTotal = "";
            string mlTotal = "";
            string oeTotal = "";
            int rowIndex = 10;


            myExcelApp = new Excel.Application();

            myExcelWorkbooks = myExcelApp.Workbooks;
            String fileName = "";
            string finalFileName = "";

            fileName = @"\\LCMHCD\Employees\Travel Temp\Other Mosquito Dept Travel Report.xlsx";

            finalFileName = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\"+ supDepartment +" Travel Report.xlsx";
            finalFileName = finalFileName.Replace("/", "-");

            filepath = finalFileName;

            myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
            Excel.Worksheet myExcelWorksheet = (Excel.Worksheet)myExcelWorkbook.ActiveSheet;

            myExcelWorksheet.get_Range("A4", misValue).Formula = supDepartment + " -  SUMMARY (" + dtpStartDate.Value.ToShortDateString() + "-" + dtpEndDate.Value.ToShortDateString() + ")";
            myExcelWorksheet.get_Range("C6", misValue).Formula = "FYE " + dtpEndDate.Value.Year + " Budget Detail";
            myExcelWorksheet.get_Range("I6", misValue).Formula = "FYE " + dtpEndDate.Value.AddYears(1).Year + " Budget Request";
            myExcelWorksheet.get_Range("G7", misValue).Formula = "FYE " + dtpEndDate.Value.AddYears(1).Year;
            myExcelWorksheet.get_Range("A3", misValue).Formula = dtpEndDate.Value.Year + " Fiscal Year Budget";

            depNumber = supDepartment.Substring(supDepartment.Length - 3);

            List<Travel> travels = new List<Travel>();

            localCon.Open();
            SqlCommand travs = new SqlCommand("SELECT a.*  FROM [TravelExpenses].[dbo].[Travel] as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID where b.Department = '"+ supDepartment +"' AND a.DepartureDate BETWEEN '" + dtpStartDate.Value.ToShortDateString() + "' AND '" + dtpEndDate.Value.ToShortDateString() + "'", localCon);
            SqlDataReader travsDR = travs.ExecuteReader();
            if (travsDR.HasRows)
            {
                while (travsDR.Read())
                {
                    Travel currentTravel = new Travel();
                    Guid travID = new Guid(travsDR["TravelID"].ToString());
                    Guid userID = new Guid(travsDR["UserID"].ToString());
                    currentTravel.TravelID = travID;
                    currentTravel.UserID = userID;
                    currentTravel.Destination = travsDR["Destination"].ToString();
                    currentTravel.Meals = Convert.ToBoolean(travsDR["Melas"].ToString());
                    currentTravel.Registration = Convert.ToBoolean(travsDR["Registration"].ToString());
                    currentTravel.Lodgings = Convert.ToBoolean(travsDR["Lodging"].ToString());
                    currentTravel.CarRental = Convert.ToBoolean(travsDR["CarRental"].ToString());
                    currentTravel.Airfare = Convert.ToBoolean(travsDR["AirFare"].ToString());
                    currentTravel.Mileage = Convert.ToBoolean(travsDR["Mileage"].ToString());
                    currentTravel.OtherExpeses = Convert.ToBoolean(travsDR["OtherExpenses"].ToString());
                    currentTravel.TotalTravelAmount = Convert.ToDouble(travsDR["TotalTravelAmount"].ToString());
                    currentTravel.TravelEvent = travsDR["TravelEvent"].ToString();
                    travels.Add(currentTravel);
                }
            }
            travsDR.Close();

            for (int i = 0; i < travels.Count; i++)
            {
                string descrption = "";
                string employee = "";

                SqlCommand emp = new SqlCommand("SELECT Concat(Name,' ',LastName) as Employee FROM [TravelExpenses].[dbo].[User] where UserID = '" + travels[i].UserID + "'", localCon);
                SqlDataReader empDR = emp.ExecuteReader();
                if (empDR.HasRows)
                {
                    while (empDR.Read())
                    {
                        employee = empDR["Employee"].ToString();
                    }
                }
                empDR.Close();

                if (travels[i].Meals)
                {
                    SqlCommand mealscmd = new SqlCommand("SELECT [TotalMeals] FROM [TravelExpenses].[dbo].[Meals] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader mealscmdDR = mealscmd.ExecuteReader();
                    if (mealscmdDR.HasRows)
                    {
                        while (mealscmdDR.Read())
                        {
                            mealsTotal = mealscmdDR["TotalMeals"].ToString();

                        }
                    }
                    mealscmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Meals";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = mealsTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = depNumber;
                    descrption = "";
                    rowIndex++;
                }
                if (travels[i].Registration)
                {
                    SqlCommand regcmd = new SqlCommand("SELECT [RegistrationAMount] FROM [TravelExpenses].[dbo].[Registration] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader regcmdDR = regcmd.ExecuteReader();
                    if (regcmdDR.HasRows)
                    {
                        while (regcmdDR.Read())
                        {
                            regTotal = regcmdDR["RegistrationAMount"].ToString();
                        }
                    }
                    regcmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Registration";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = regTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = depNumber;
                    descrption = "";
                    rowIndex++;

                }
                if (travels[i].Lodgings)
                {
                    double totalLod = 0;
                    SqlCommand lodcmd = new SqlCommand("SELECT [TotalLodging] FROM [TravelExpenses].[dbo].[Lodging] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader lodcmdDR = lodcmd.ExecuteReader();
                    if (lodcmdDR.HasRows)
                    {
                        while (lodcmdDR.Read())
                        {
                            totalLod += Convert.ToDouble(lodcmdDR["TotalLodging"].ToString());
                        }
                        lodTotal = totalLod.ToString();
                    }
                    lodcmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Lodgings";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = lodTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = depNumber;
                    descrption = "";
                    rowIndex++;
                }
                if (travels[i].CarRental)
                {
                    SqlCommand crcmd = new SqlCommand("SELECT [TotalCarRental] FROM [TravelExpenses].[dbo].[CarRental] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader crcmdDR = crcmd.ExecuteReader();
                    if (crcmdDR.HasRows)
                    {
                        double totalCR = 0;
                        while (crcmdDR.Read())
                        {
                            totalCR += Convert.ToDouble(crcmdDR["TotalCarRental"].ToString());
                        }

                        crTotal = totalCR.ToString();
                    }
                    crcmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Car Rental";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = crTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = depNumber;
                    descrption = "";
                    rowIndex++;
                }
                if (travels[i].Airfare)
                {
                    SqlCommand afcmd = new SqlCommand("SELECT [AirFareTotal] FROM [TravelExpenses].[dbo].[AirFare] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader afcmdDR = afcmd.ExecuteReader();
                    if (afcmdDR.HasRows)
                    {
                        double totalAF = 0;
                        while (afcmdDR.Read())
                        {
                            totalAF += Convert.ToDouble(afcmdDR["AirFareTotal"].ToString());
                        }
                        afTotal = totalAF.ToString();
                    }
                    afcmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Air Fare";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = afTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = depNumber;
                    descrption = "";
                    rowIndex++;
                }
                if (travels[i].Mileage)
                {
                    SqlCommand mlcmd = new SqlCommand("SELECT [TotalMileage] FROM [TravelExpenses].[dbo].[Mileage] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader mlcmdDR = mlcmd.ExecuteReader();
                    if (mlcmdDR.HasRows)
                    {
                        while (mlcmdDR.Read())
                        {
                            mlTotal = mlcmdDR["TotalMileage"].ToString();
                        }
                    }
                    mlcmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Mileage";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = mlTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = depNumber;
                    descrption = "";
                    rowIndex++;
                }
                if (travels[i].OtherExpeses)
                {
                    SqlCommand oecmd = new SqlCommand("SELECT [Amount] FROM [TravelExpenses].[dbo].[OtherExpenses] where TravelID = '" + travels[i].TravelID + "'", localCon);
                    SqlDataReader oecmdDR = oecmd.ExecuteReader();
                    if (oecmdDR.HasRows)
                    {
                        double totalOE = 0;
                        while (oecmdDR.Read())
                        {
                            totalOE += Convert.ToDouble(oecmdDR["Amount"].ToString());
                        }
                        oeTotal = totalOE.ToString();
                    }
                    oecmdDR.Close();
                    descrption = travels[i].TravelEvent + "-" + travels[i].Destination + "-" + "Other Expenses";
                    myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = descrption;
                    myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = employee;
                    myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = oeTotal;
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = depNumber;
                    descrption = "";
                    rowIndex++;
                }
            }

            localCon.Close();

            myExcelWorksheet.SaveAs(finalFileName, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
            myExcelWorkbooks.Close();
           // MessageBox.Show("Excel created");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (username == "KBaker")
            {
                CreateMosquitoAllExcel();
            }
            else if (username == "KWatts")
            {
                CreateHyacinthExcel();
            }
            else
            {
                CreateOtherDepExcel();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblInfo.Visible = false;
            pictureBox1.Visible = false;
            btnExport.Enabled = true;
            panel1.Enabled = true;
            MessageBox.Show("Excel Spreadsheet created successfully." + Environment.NewLine + " It is located on: " + Environment.NewLine + filepath, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
