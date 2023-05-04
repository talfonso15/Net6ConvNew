using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelExpenses
{
    class OtherExpensescl
    {
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        private string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        private bool prepaid;

        public bool Prepaid
        {
            get { return prepaid; }
            set { prepaid = value; }
        }



    }
}
