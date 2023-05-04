using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelExpenses
{
    class MealsDatecl
    {
        private bool breakfast;
        private bool dinner;
        private bool lunch;
        private DateTime date;


        public bool Breakfast
        {
            get { return breakfast; }
            set { breakfast = value; }
        }

        public bool Dinner
        {
            get { return dinner; }
            set { dinner = value; }
        }

        public bool Lunch
        {
            get { return lunch; }
            set { lunch = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
