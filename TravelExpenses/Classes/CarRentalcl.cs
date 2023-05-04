using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelExpenses
{
    class CarRentalcl
    {
        private DateTime pickUpDate;

        public DateTime PickUpDate
        {
            get { return pickUpDate; }
            set { pickUpDate = value; }
        }

        private DateTime dropOffDate;

        public DateTime DropOffDate
        {
            get { return dropOffDate; }
            set { dropOffDate = value; }
        }

        private string carType;

        public string CarType
        {
            get { return carType; }
            set { carType = value; }
        }

        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        private int days;

        public int Days
        {
            get { return days; }
            set { days = value; }
        }

        private double costPerDay;

        public double CostPerDay
        {
            get { return costPerDay; }
            set { costPerDay = value; }
        }
        private double taxesAndFees;

        public double TaxesAndFees
        {
            get { return taxesAndFees; }
            set { taxesAndFees = value; }
        }
        private double ldwInsuranse;

        public double LDWInsuranse
        {
            get { return ldwInsuranse; }
            set { ldwInsuranse = value; }
        }

        private double supplementalInsurance;

        public double SupplementalInsurance
        {
            get { return supplementalInsurance; }
            set { supplementalInsurance = value; }
        }
        private bool extraInsurance;

        public bool ExtraInsurance
        {
            get { return extraInsurance; }
            set { extraInsurance = value; }
        }
        private double extraInsuranceAmount;

        public double ExtraInsuranceAmount
        {
            get { return extraInsuranceAmount; }
            set { extraInsuranceAmount = value; }
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

        private string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        private double totalCarRental;

        public double TotalCarRental
        {
            get { return totalCarRental; }
            set { totalCarRental = value; }
        }








    }
}
