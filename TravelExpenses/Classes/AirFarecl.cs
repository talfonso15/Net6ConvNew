using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelExpenses
{
    class AirFarecl
    {
        private DateTime departureDate;

        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }
        private DateTime? returnDate;

        public DateTime? ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        private double airFareCost;

        public double AirFareCost
        {
            get { return airFareCost; }
            set { airFareCost = value; }
        }
        private double taxesAndFees;

        public double TaxesAndFees
        {
            get { return taxesAndFees; }
            set { taxesAndFees = value; }
        }
        private bool districtPay;

        public bool DistrictPay
        {
            get { return districtPay; }
            set { districtPay = value; }
        }

        private bool personalUse;

        public bool PersonalUse
        {
            get { return personalUse; }
            set { personalUse = value; }
        }

        private double personalUseAmount;

        public double PersonalUseAmount
        {
            get { return personalUseAmount; }
            set { personalUseAmount = value; }
        }

        private double totalAirFare;

        public double TotalAirFare
        {
            get { return totalAirFare; }
            set { totalAirFare = value; }
        }
        private string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }



    }

}
