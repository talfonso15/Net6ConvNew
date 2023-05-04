using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelExpenses
{
    class EstimateTravelcl
    {
        private DateTime departureDate;
        private DateTime returnDate;
        private string travelEvent;
        private string travelPurpose;
        private bool travelBudgeted;
        private double travelEstimateTotal;
        private bool meals;
        private double mealsCost;
        private string mealsNotes;
        private bool registration;
        private double registrationCost;
        private string registrationNotes;
        private bool lodgings;
        private double lodgingsCost;
        private string lodgingsNotes;
        private bool carRentals;
        private double carRentalsCost;
        private string carRentalsNotes;
        private bool airFare;
        private double airFareCost;
        private string airFareNotes;
        private bool mileage;
        private double mileageCost;
        private string mileageNotes;
        private bool mileagePersonal;
        private bool otherExpenses;
        private double otherExpensesCost;
        private string otherExpensesNotes;
        private string destination;
        private double mealPerDiem;


        public DateTime DepartureDate
        {
            get { return departureDate; }
            set { departureDate = value; }
        }
        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        public string TravelEvent
        {
            get { return travelEvent; }
            set { travelEvent = value; }
        }
        public string TravelPurpose
        {
            get { return travelPurpose; }
            set { travelPurpose = value; }
        }
        public bool TravelBudgeted
        {
            get { return travelBudgeted; }
            set { travelBudgeted = value; }
        }
        public double TravelEstimateTotal
        {
            get { return travelEstimateTotal; }
            set { travelEstimateTotal = value; }
        }
        public bool Meals
        {
            get { return meals; }
            set { meals = value; }
        }
        public double MealsCost
        {
            get { return mealsCost; }
            set { mealsCost = value; }
        }
        public string MealsNotes
        {
            get { return mealsNotes; }
            set { mealsNotes = value; }
        }
        public bool Registration
        {
            get { return registration; }
            set { registration = value; }
        }
        public double ResgistrationCost
        {
            get { return registrationCost; }
            set { registrationCost = value; }
        }
        public string RegistrationNotes
        {
            get { return registrationNotes; }
            set { registrationNotes = value; }
        }
        public bool Lodgings
        {
            get { return lodgings; }
            set { lodgings = value; }
        }
        public double LodgingsCost
        {
            get { return lodgingsCost; }
            set { lodgingsCost = value; }
        }
        public string LodgingsNotes
        {
            get { return lodgingsNotes; }
            set { lodgingsNotes = value; }
        }
        public bool CarRental
        {
            get { return carRentals; }
            set { carRentals = value; }
        }
        public double CarRentalCost
        {
            get { return carRentalsCost; }
            set { carRentalsCost = value; }
        }
        public string CarRentalNotes
        {
            get { return carRentalsNotes; }
            set { carRentalsNotes = value; }
        }
        public bool AirFare
        {
            get { return airFare; }
            set { airFare = value; }
        }
        public double AirFareCost
        {
            get { return airFareCost; }
            set { airFareCost = value; }
        }
        public string AirFareNotes
        {
            get { return airFareNotes; }
            set { airFareNotes = value; }
        }
        public bool Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }
        public double MileageCost
        {
            get { return mileageCost; }
            set { mileageCost = value; }
        }
        public string MileageNotes
        {
            get { return mileageNotes; }
            set { mileageNotes = value; }
        }
        public bool MileagePersonal
        {
            get { return mileagePersonal; }
            set { mileagePersonal = value; }
        }
        public bool OtherExpenses
        {
            get { return otherExpenses; }
            set { otherExpenses = value; }
        }
        public double OtherExpensesCost
        {
            get { return otherExpensesCost; }
            set { otherExpensesCost = value; }
        }
        public string OtherExpensesNotes
        {
            get { return otherExpensesNotes; }
            set { otherExpensesNotes = value; }
        }

        public string Destination
        {
            get { return destination; }
            set { destination = value; }
        }

        public double MealPerDiem 
        {
            get { return mealPerDiem; }
            set { mealPerDiem = value; }
        }
    }
}
