using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelExpenses
{
    class Mealscl
    {
        private int breakfast;
        private int lunch;
        private int dinner;
        private bool providedMeals;
        private string notes;
        private double mealsTotal;
        private double breakfastPerDiemRate;
        private double lunchPerDiemRate;
        private double dinnerPerDiemRate;
        private double totalMealsPerDiemRate;
        private string perDiemLoactionZipCode;

        public int Breakfast
        {
            get { return breakfast; }
            set { breakfast = value; }
        }

        public int Lunch
        {
            get { return lunch; }
            set { lunch = value; }
        }

        public int Dinner
        {
            get { return dinner; }
            set { dinner = value; }
        }

        public bool ProvidedMeals
        {
            get { return providedMeals; }
            set { providedMeals = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public double MealsTotal
        {
            get { return mealsTotal; }
            set { mealsTotal = value; }
        }

        public double BreakfastPerDiemRate
        {
            get { return breakfastPerDiemRate; }
            set { breakfastPerDiemRate = value; }
        }

        public double LunchPerDiemRate
        {
            get { return lunchPerDiemRate; }
            set { lunchPerDiemRate = value; }
        }

        public double DinnerPerDiemRate
        {
            get { return dinnerPerDiemRate; }
            set { dinnerPerDiemRate = value; }
        }

        public double TotalMealsPerDiemRate
        {
            get { return totalMealsPerDiemRate; }
            set { totalMealsPerDiemRate = value; }
        }

        public string PerDiemLoactionZipCode
        {
            get { return perDiemLoactionZipCode; }
            set { perDiemLoactionZipCode = value; }
        }
    }
}
