using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelExpenses
{
    class Lodgingcl
    {
        private string facilityName;
        private int numberOfNights;
        private double costPerNight;
        private double taxesAndFees;
        private bool districtPay;
        private bool directorApproved;
        private double totalLodging;
        private string notes;
        private double feesPerNight;

        public string FacilityName
        {
            get { return facilityName; }
            set { facilityName = value; }
        }

        public int NumberOfNights
        {
            get { return numberOfNights; }
            set { numberOfNights = value; }
        }

        public double CostPerNight
        {
            get { return costPerNight; }
            set { costPerNight = value; }
        }

        public double TaxesAndFees
        {
            get { return taxesAndFees; }
            set { taxesAndFees = value; }
        }

        public bool DistrictPay
        {
            get { return districtPay; }
            set { districtPay = value; }
        }

        public bool DirectorApproved
        {
            get { return directorApproved; }
            set { directorApproved = value; }
        }

        public double TotalLodging
        {
            get { return totalLodging; }
            set { totalLodging = value; }
        }
        

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public double FeesPerNight
        {
            get { return feesPerNight; }
            set { feesPerNight = value; }
        }

    }
}
