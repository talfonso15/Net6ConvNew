using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Reflection;
using System.IO;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;

namespace TravelExpenses
{
    public partial class Travel_By_Date : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        string winUser = Environment.UserName;
        string filepath = "";
        public Travel_By_Date()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            pictureBox1.Visible = true;
            btnExecute.Enabled = false;
            panel1.Enabled = false;
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            
        }

        private void GenerateExcel()
        {
            string mealsTotal = "";
            string regTotal = "";
            string lodTotal = "";
            string crTotal = "";
            string afTotal = "";
            string mlTotal = "";
            string oeTotal = "";
            int rowIndex = 10;

            Excel.Application myExcelApp;
            Excel.Workbooks myExcelWorkbooks;
            Excel.Workbook myExcelWorkbook;

            object misValue = System.Reflection.Missing.Value;


            myExcelApp = new Excel.Application();

            myExcelWorkbooks = myExcelApp.Workbooks;

            String fileName = "";
            string finalFileName = "";


            fileName = @"\\LCMHCD\Employees\Travel Temp\Travel by Date Report.xlsx";

            finalFileName = @"\\LCMHCD\Home\" + winUser + "\\" + "travel\\Travel by Date Report("+ dtpStarDate.Value.ToShortDateString()+ " to "+ dtpEndDate.Value.ToShortDateString()+").xlsx";
            finalFileName = finalFileName.Replace("/", "-");
            filepath = finalFileName;

            myExcelWorkbook = myExcelWorkbooks.Open(fileName, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
            Excel.Worksheet myExcelWorksheet = (Excel.Worksheet)myExcelWorkbook.ActiveSheet;

            myExcelWorksheet.get_Range("E4", misValue).Formula = dtpStarDate.Value.ToShortDateString();
            myExcelWorksheet.get_Range("G4", misValue).Formula = dtpEndDate.Value.ToShortDateString();

            List<Travel> travels = new List<Travel>();

            localCon.Open();
            SqlCommand travs = new SqlCommand("SELECT  a.* FROM [TravelExpenses].[dbo].[Travel]as a inner join TravelExpenses.dbo.[User] as b on a.UserID = b.UserID where a.DepartureDate BETWEEN '"+ dtpStarDate.Value.ToShortDateString()+"' AND '"+ dtpEndDate.Value.ToShortDateString() +"' order by b.Name asc", localCon);
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
                    currentTravel.DepartureDate = Convert.ToDateTime(travsDR["DepartureDate"].ToString());
                    currentTravel.ReturnDate = Convert.ToDateTime(travsDR["ReturnDate"].ToString());
                    currentTravel.TravelState = travsDR["TravelState"].ToString();
                    travels.Add(currentTravel);
                }
            }
            travsDR.Close();

            for (int i = 0; i < travels.Count; i++)
            {
                
                string employee = "";

                myExcelWorksheet.get_Range("B" + rowIndex.ToString(), misValue).Formula = travels[i].TravelEvent;
                myExcelWorksheet.get_Range("C" + rowIndex.ToString(), misValue).Formula = travels[i].Destination + ", " + travels[i].TravelState;
                myExcelWorksheet.get_Range("D" + rowIndex.ToString(), misValue).Formula = travels[i].DepartureDate.ToShortDateString();
                myExcelWorksheet.get_Range("E" + rowIndex.ToString(), misValue).Formula = travels[i].ReturnDate.ToShortDateString();
                myExcelWorksheet.get_Range("M" + rowIndex.ToString(), misValue).Formula = travels[i].TotalTravelAmount.ToString();

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

                myExcelWorksheet.get_Range("A" + rowIndex.ToString(), misValue).Formula = employee;

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
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = mealsTotal;



                }
                else
                {
                    myExcelWorksheet.get_Range("F" + rowIndex.ToString(), misValue).Formula = "-";
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

                    myExcelWorksheet.get_Range("G" + rowIndex.ToString(), misValue).Formula = regTotal;
                }
                else
                {
                    myExcelWorksheet.get_Range("G" + rowIndex.ToString(), misValue).Formula = "-";
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

                    myExcelWorksheet.get_Range("J" + rowIndex.ToString(), misValue).Formula = lodTotal;

                }
                else
                {
                    myExcelWorksheet.get_Range("J" + rowIndex.ToString(), misValue).Formula = "-";
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

                    myExcelWorksheet.get_Range("H" + rowIndex.ToString(), misValue).Formula = crTotal;

                }
                else
                {
                    myExcelWorksheet.get_Range("H" + rowIndex.ToString(), misValue).Formula = "-";
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

                    myExcelWorksheet.get_Range("I" + rowIndex.ToString(), misValue).Formula = afTotal;

                }
                else
                {
                    myExcelWorksheet.get_Range("I" + rowIndex.ToString(), misValue).Formula = "-";
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

                    myExcelWorksheet.get_Range("K" + rowIndex.ToString(), misValue).Formula = mlTotal;

                }
                else
                {
                    myExcelWorksheet.get_Range("K" + rowIndex.ToString(), misValue).Formula = "-";
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

                    myExcelWorksheet.get_Range("L" + rowIndex.ToString(), misValue).Formula = oeTotal;

                }
                else
                {
                    myExcelWorksheet.get_Range("L" + rowIndex.ToString(), misValue).Formula = "-";
                }

                rowIndex++;
            }

            myExcelWorksheet.SaveAs(finalFileName, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue, misValue);
            myExcelWorkbooks.Close();
            localCon.Close();

            

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            GenerateExcel();
           
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lblInfo.Visible = false;
            pictureBox1.Visible = false;
            btnExecute.Enabled = true;
            panel1.Enabled = true;

            MessageBox.Show("Excel Spreadsheet created successfully."+ Environment.NewLine +" It is located on: "+ Environment.NewLine + filepath, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
