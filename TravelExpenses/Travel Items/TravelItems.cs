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

namespace TravelExpenses
{
    public partial class TravelItems : Form
    {
        SqlConnection localCon = new SqlConnection(Properties.Settings.Default.TravelExpensesConnectionString);
        public TravelItems()
        {
            InitializeComponent();
        }

        private void chxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chxSelectAll.Checked == true)
            {
                chxMeals.Checked = true;
                chxMileage.Checked = true;
                chxOtherExpenses.Checked = true;
                chxLodging.Checked = true;
                chxFlight.Checked = true;
                chxRegistration.Checked = true;
                chxCarRental.Checked = true;
            }
            else {
                chxMeals.Checked = false;
                chxMileage.Checked = false;
                chxOtherExpenses.Checked = false;
                chxLodging.Checked = false;
                chxFlight.Checked = false;
                chxRegistration.Checked = false;
                chxCarRental.Checked = false;
            }
        }

        private void btnNextTravelItems_Click(object sender, EventArgs e)
        {

            bool validate = nextValidation();
            if (validate)
            {
                if (chxMeals.Checked == true)
                {
                    if (CommonVariables.addingItems)
                    {
                        if (chxMeals.Enabled)
                        {
                            CommonVariables.isMeals = true;
                        }
                    }
                    else {
                        CommonVariables.isMeals = true;
                    }
                    
                }
                else
                {
                    CommonVariables.isMeals = false;
                }
                if (chxRegistration.Checked == true)
                {
                    if (CommonVariables.addingItems)
                    {
                        if (chxRegistration.Enabled)
                        {
                            CommonVariables.isRegistartion = true;
                        }
                    }
                    else
                    {
                        CommonVariables.isRegistartion = true;
                    }
                }
                else
                {
                    CommonVariables.isRegistartion = false;
                }
                if (chxCarRental.Checked == true)
                {
                    if (CommonVariables.addingItems)
                    {
                        if (chxCarRental.Enabled)
                        {
                            CommonVariables.isCarRental = true;
                        }
                    }
                    else
                    {
                        CommonVariables.isCarRental = true;
                    }
                    
                }
                else
                {
                    CommonVariables.isCarRental = false;
                }
                if (chxFlight.Checked == true)
                {
                    if (CommonVariables.addingItems)
                    {
                        if (chxFlight.Enabled)
                        {
                            CommonVariables.isAirFare = true;
                        }
                    }
                    else
                    {
                        CommonVariables.isAirFare = true;
                    }
                }
                else
                {
                    CommonVariables.isAirFare = false;
                }
                if (chxMileage.Checked == true)
                {
                    if (CommonVariables.addingItems)
                    {
                        if (chxMileage.Enabled)
                        {
                            CommonVariables.isMileage = true;
                        }
                    }
                    else
                    {
                        CommonVariables.isMileage = true;
                    }
                }
                else
                {
                    CommonVariables.isMileage = false;
                }
                if (chxOtherExpenses.Checked == true)
                {
                    if (CommonVariables.addingItems)
                    {
                        if (chxOtherExpenses.Enabled)
                        {
                            CommonVariables.isOtherExpenses = true;
                        }
                    }
                    else
                    { 
                    CommonVariables.isOtherExpenses = true;
                    }
                }
                else
                {
                    CommonVariables.isOtherExpenses = false;
                }
                if (chxLodging.Checked == true)
                {
                    if (CommonVariables.addingItems)
                    {
                        if (chxLodging.Enabled)
                        {
                            CommonVariables.isLodging = true;
                        }
                    }
                    else
                    {
                        CommonVariables.isLodging = true;
                    }
                }
                else
                {
                    CommonVariables.isLodging = false;
                }

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

                if (CommonVariables.isMeals == true)
                {
                    bool mealsFormFound = false;
                    foreach (Form child in childs)
                    {
                        string name = child.Name;
                        if (child.Name == "Meals")
                        {
                            child.Focus();
                            child.Show();

                            mealsFormFound = true;
                        }
                    }
                    if (!mealsFormFound)
                    {
                        Meals ml = new Meals();
                        ml.MdiParent = main;
                        ml.Show();
                    }
                }
                else if (CommonVariables.isRegistartion == true)
                {
                    bool RegistrationFormFound = false;
                    foreach (Form child in childs)
                    {
                        string name = child.Name;
                        if (child.Name == "Registration")
                        {
                            child.Focus();
                            child.Show();

                            RegistrationFormFound = true;
                        }
                    }
                    if (!RegistrationFormFound)
                    {
                        Registration rg = new Registration();
                        rg.MdiParent = main;
                        rg.Show();
                    }
                }
                else if (CommonVariables.isLodging == true)
                {
                    bool lodgingFormFound = false;
                    foreach (Form child in childs)
                    {
                        string name = child.Name;
                        if (child.Name == "Lodging")
                        {
                            child.Focus();
                            child.Show();

                            lodgingFormFound = true;
                        }
                    }
                    if (!lodgingFormFound)
                    {
                        Lodging lg = new Lodging();
                        lg.MdiParent = main;
                        lg.Show();
                    }
                }
                else if (CommonVariables.isCarRental == true)
                {
                    bool carFormFound = false;
                    foreach (Form child in childs)
                    {
                        string name = child.Name;
                        if (child.Name == "CarRental")
                        {
                            child.Focus();
                            child.Show();

                            carFormFound = true;
                        }
                    }
                    if (!carFormFound)
                    {
                        CarRental cr = new CarRental();
                        cr.MdiParent = main;
                        cr.Show();
                    }
                }
                else if (CommonVariables.isAirFare == true)
                {
                    bool flightFormFound = false;
                    foreach (Form child in childs)
                    {
                        string name = child.Name;
                        if (child.Name == "AirFare")
                        {
                            child.Focus();
                            child.Show();

                            flightFormFound = true;
                        }
                    }
                    if (!flightFormFound)
                    {
                        AirFare af = new AirFare();
                        af.MdiParent = main;
                        af.Show();
                    }
                }
                else if (CommonVariables.isMileage == true)
                {
                    bool mileageFormFound = false;
                    foreach (Form child in childs)
                    {
                        string name = child.Name;
                        if (child.Name == "Mileage")
                        {
                            child.Focus();
                            child.Show();

                            mileageFormFound = true;
                        }
                    }
                    if (!mileageFormFound)
                    {
                        Mileage ml = new Mileage();
                        ml.MdiParent = main;
                        ml.Show();
                    }
                }
                else if (CommonVariables.isOtherExpenses == true)
                {
                    bool oxFormFound = false;
                    foreach (Form child in childs)
                    {
                        string name = child.Name;
                        if (child.Name == "OtherExpenses")
                        {
                            child.Focus();
                            child.Show();

                            oxFormFound = true;
                        }
                    }
                    if (!oxFormFound)
                    {
                        OtherExpenses ox = new OtherExpenses();
                        ox.MdiParent = main;
                        ox.Show();
                    }
                }
                else
                {
                    Summary sm = new Summary();
                    sm.MdiParent = main;
                    sm.Show();
                }
                this.Hide();
            }
        }

        private bool nextValidation() {
            if (!chxMeals.Checked && !chxRegistration.Checked && !chxCarRental.Checked && !chxFlight.Checked && !chxMileage.Checked && !chxLodging.Checked && !chxOtherExpenses.Checked && !chxSelectAll.Checked) {
                MessageBox.Show("Select at least one Item for your Travel", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnBackTravelItems_Click(object sender, EventArgs e)
        {
            
            FormCollection fc = Application.OpenForms;
            int cant = Application.OpenForms.Count;
            bool FormFound = false;
            foreach (Form frm in fc)
            {
                
                string name = frm.Name;
                if (frm.Name == "Main")
                {

                    Form[] childs = frm.MdiChildren;
                    foreach (Form child in childs)
                    {
                        if (child.Name == "RegisterTravel")
                        {
                            child.Focus();
                            child.Show();
                            FormFound = true;
                        }
                    }
                }
            }
            this.Hide();
        }

        private void btnCancelTravelItems_Click(object sender, EventArgs e)
        {
            CommonVariables.CancelTravel();
        }

       /* private void TravelItems_FormClosed(object sender, FormClosedEventArgs e)
        {
            CommonVariables.CancelTravel();
        }*/

        private void TravelItems_Load(object sender, EventArgs e)
        {
            
            if (CommonVariables.addingItems) {
                localCon.Open();
                Guid travID = new Guid(CommonVariables.addingTravelID);
                SqlCommand cmd = new SqlCommand("SELECT * FROM [TravelExpenses].[dbo].[Travel] where TravelID = '"+ travID + "'", localCon);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string meals = dr["Melas"].ToString();
                    if (meals == "True") {
                        chxMeals.Checked = true;
                        chxMeals.Enabled = false;
                    }
                    string registration = dr["Registration"].ToString();
                    if (registration == "True") {
                        chxRegistration.Checked = true;
                        chxRegistration.Enabled = false;
                    }
                    string lodging = dr["Lodging"].ToString();
                    if (lodging == "True") {
                        chxLodging.Checked = true;
                        chxLodging.Enabled = false;
                    }
                    string carRental = dr["CarRental"].ToString();
                    if (carRental == "True") {
                        chxCarRental.Checked = true;
                        chxCarRental.Enabled = false;
                    }
                    string airfare = dr["AirFare"].ToString();
                    if (airfare == "True") {
                        chxFlight.Checked = true;
                        chxFlight.Enabled = false;
                    }
                    string mileage = dr["Mileage"].ToString();
                    if (mileage == "True") {
                        chxMileage.Checked = true;
                        chxMileage.Enabled = false;
                    }
                    string otherExpenses = dr["OtherExpenses"].ToString();
                    if (otherExpenses == "True") {
                        chxOtherExpenses.Checked = true;
                        chxOtherExpenses.Enabled = false;
                    }
                }

                btnBackTravelItems.Enabled = false;
                chxSelectAll.Enabled = false;

                localCon.Close();
            }
        }
    }
}
