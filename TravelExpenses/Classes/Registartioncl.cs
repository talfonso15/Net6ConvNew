using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelExpenses
{
    class Registartioncl
    {
        private double registrationAmount;
        private bool districtPay;
        private string notes;

        public double RegistrationAmount
        {
            get { return registrationAmount; }
            set { registrationAmount = value; }
        }

        public bool DistrictPay
        {
            get { return districtPay; }
            set { districtPay = value; }
        }
        

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }




    }
}
