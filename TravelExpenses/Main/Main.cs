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

namespace TravelExpenses
{
    public partial class Main : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        bool logout = false;
        
        public Main()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void syncToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Sync s = new Sync();
            s.MdiParent = this;
            s.Show();
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.MdiParent = this;
            user.Show();
        }

        private void registerTravelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*this.IsMdiContainer = true;
            RegisterTravel rt = new RegisterTravel();
            rt.MdiParent = this;
            rt.Show();*/

            RegisterTravel rt = new RegisterTravel();
            rt.MdiParent = this;
            rt.Show();
        }

        private void addTravelItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTravelItem ati = new AddTravelItem();
            ati.MdiParent = this;
            ati.Show();
        }

        private void estimateTravelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstimateTravel et = new EstimateTravel();
            et.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonVariables.user = "";
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUser eu = new EditUser();
            eu.MdiParent = this;
            eu.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPassword ep = new EditPassword();
            ep.MdiParent = this;
            ep.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            localCon.Open();
            int accessLevel = 0;
            string userName = "";
            string title = "";
            bool isSup = false;
            Guid ui = new Guid(CommonVariables.user);
            SqlCommand cmdUser = new SqlCommand("SELECT a.*,b.* FROM [TravelExpenses].[dbo].[User] as a inner join [TravelExpenses].[dbo].User_Email_Title as b on b.UserID = a.UserID  where a.UserID = '" + ui + "'", localCon);
            SqlDataReader dr = cmdUser.ExecuteReader();
            while (dr.Read())
            {
                accessLevel = Convert.ToInt16(dr["AccessLevel"].ToString());
                userName = dr["Username"].ToString();
                title = dr["Title"].ToString();
            }
            localCon.Close();
            if (accessLevel > 1) {
                addUserToolStripMenuItem.Enabled = false;
                editUserToolStripMenuItem.Enabled = false;
            }
            if (accessLevel > 2)
            {
                adminToolStripMenuItem.Visible = false;
            }
            if (accessLevel == 1 && title != "Accounting Processor")
            {
                superAdminToolStripMenuItem.Visible = true;
                //mileageRateToolStripMenuItem.Visible = true;
            }
            if ((accessLevel == 1 || accessLevel == 2))
            {
                if (title == "Executive Processor"  || title == "Accounting Processor")
                {
                    isSup = false;
                    localCon.Open();
                    SqlCommand cmdsup = new SqlCommand("SELECT  [UserID],[SupervisorID] FROM [TravelExpenses].[dbo].[Supervisor_Employee] where SupervisorID = '" + ui + "'", localCon);
                    SqlDataReader supDR = cmdsup.ExecuteReader();
                    if (supDR.HasRows)
                    {
                        while (supDR.Read())
                        {
                            isSup = true;
                        }
                    }
                    supDR.Close();
                    localCon.Close();

                    if (!isSup)
                    {
                        supervisorToolStripMenuItem.Visible = false;
                        ReportStripMenuItem.Visible = false;
                    }
                    else 
                    {
                        supervisorToolStripMenuItem.Visible = true;
                        ReportStripMenuItem.Visible = true;
                    }
                }
                else
                {
                    supervisorToolStripMenuItem.Visible = true;
                    ReportStripMenuItem.Visible = true;
                }
                
            }
            if (title == "CFO")
            {
                cFOToolStripMenuItem.Visible = true;
                mileageRateToolStripMenuItem.Visible = true;
                archivedTravelsToolStripMenuItem.Visible = true;
            }
            if (title == "Accounting Processor")
            {
                accountingToolStripMenuItem.Visible = true;
                addUserToolStripMenuItem.Visible = true;
                editUserToolStripMenuItem.Visible = true;
                archivedTravelsToolStripMenuItem.Visible = true;
                mileageRateToolStripMenuItem.Visible = true;
            }
            if (title == "Executive Director" || title == "Assistant Director")
            {
                executiveDirectorToolStripMenuItem.Visible = true;
            }
            if (title == "Executive Processor" )
            {
                thirdPartyTravelToolStripMenuItem.Visible = true;
            }
           /* if (userName == "SDew")
            {
                accountPaybleToolStripMenuItem.Visible = true;
            }*/
            if (userName == "TPineda")
            {
                historyToolStripMenuItem.Visible = true;
                addUserToolStripMenuItem.Visible = true;
                editUserToolStripMenuItem.Visible = true;
                mileageRateToolStripMenuItem.Visible = true;
            }
        }

        private void editTravelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditTravel et = new EditTravel();
            et.MdiParent = this;
            et.Show();
        }

        private void allTravelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAllTravels at = new ListAllTravels();
            at.MdiParent = this;
            at.Show();
        }

        private void allEstimatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEstimates ae = new AllEstimates();
            ae.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void superAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void estimateTravelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EstimateTravel et = new EstimateTravel();
            et.MdiParent = this;
            et.Show();
        }

        private void allEstimatesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AllEstimates ae = new AllEstimates();
            ae.MdiParent = this;
            ae.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonVariables.user = "";
            logout = true;
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void supervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void videoTutorialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "file://LCMHCD/Employees/Travel Instructions/videos");
        }

        private void policyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Acrobat.exe", "//LCMHCD/Employees/Policies/Travel Policy & Procedures (revised 12-15-16).pdf");
        }

        private void travelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuperAdminTravels sat = new SuperAdminTravels();
            sat.MdiParent = this;
            sat.Show();
        }

        private void authorizationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*AdminAuthorization aa = new AdminAuthorization();
            aa.MdiParent = this;
            aa.Show();*/
            SuperAdminAuthorization saa = new SuperAdminAuthorization();
            saa.MdiParent = this;
            saa.Show();
        }

        private void addDigitalSignatureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void travelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supervisor sp = new Supervisor();
            sp.MdiParent = this;
            sp.Show();
        }

        private void authorizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonVariables.isSupervisor = true;
            AdminAuthorization aa = new AdminAuthorization();
            aa.MdiParent = this;
            aa.Show();
        }

        private void cFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CFOReview cr = new CFOReview();
            cr.MdiParent = this;
            cr.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logout)
            {
                Application.Exit();
            }
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonVariables.is_TPT = true;
            CommonVariables.isGroup = true;
            CommonVariables.tpt_Type = "Travel";
            TP_Travel_Person tp = new TP_Travel_Person();
            tp.MdiParent = this;
            tp.Show();
        }

        private void groupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonVariables.is_TPT = true;
            CommonVariables.isGroup = true;
            CommonVariables.tpt_Type = "Authorization";
            TP_Travel_Person tp = new TP_Travel_Person();
            tp.MdiParent = this;
            tp.Show();
        }

        private void personToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonVariables.is_TPT = true;
            CommonVariables.isGroup = false;
            CommonVariables.tpt_Type = "Authorization";
            TP_Travel_Person tp = new TP_Travel_Person();
            tp.MdiParent = this;
            tp.Show();
        }

        private void personToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonVariables.is_TPT = true;
            CommonVariables.isGroup = false;
            CommonVariables.tpt_Type = "Travel";
            TP_Travel_Person tp = new TP_Travel_Person();
            tp.MdiParent = this;
            tp.Show();
        }

        private void thirdPartyTravelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void authorizationsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdminAuthorization aa = new AdminAuthorization();
            aa.MdiParent = this;
            aa.Show();
        }

        private void travelsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.MdiParent = this;
            ad.Show();
        }

        private void accountPaybleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.MdiParent = this;
            ad.Show();
        }

        private void authorizationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SuperAdminAuthorization saa = new SuperAdminAuthorization();
            saa.MdiParent = this;
            saa.Show();
        }

        private void editExpenseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditThirdPartyTravel etpt = new EditThirdPartyTravel();
            etpt.MdiParent = this;
            etpt.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditThirdPartyAuthorizationForm eauth = new EditThirdPartyAuthorizationForm();
            eauth.MdiParent = this;
            eauth.Show();
        }

        private void workflowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "file://LCMHCD/Employees/Travel Instructions/Workflows/");
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserHistory uh = new UserHistory();
            uh.MdiParent = this;
            uh.Show();
        }

        private void travelsByDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Travels_by_Date_and_Employee tdep = new Travels_by_Date_and_Employee();
            tdep.MdiParent = this;
            tdep.Show();
        }

        private void travelByDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Travel_By_Date tbd = new Travel_By_Date();
            tbd.MdiParent = this;
            tbd.Show();
        }

        private void executiveDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivedTravelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void expenseReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ArchivedTravels arc = new ArchivedTravels();
            arc.MdiParent = this;
            arc.Show();
        }

        private void travelAuthorizationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArchivedAuthorizations aruth = new ArchivedAuthorizations();
            aruth.MdiParent = this;
            aruth.Show();
        }

        private void mileageRateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMileageRate emr = new EditMileageRate();
            emr.MdiParent = this;
            emr.Show();
        }

        private void checkingPerDiemValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculatePerDiem cpd = new CalculatePerDiem();
            //cpd.MdiParent = this;
            cpd.Show();
        }
    }
}
