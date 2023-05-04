using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelExpenses
{
    class Travel
    {
        public string DepartureTime { get; set; }
        public System.DateTime DepartureDate { get; set; }
        public string ReturnTime { get; set; }
        public System.DateTime ReturnDate { get; set; }
        public string TravelEvent { get; set; }
        public string TravelPurpose { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string TravelState { get; set; }
        public System.Guid UserID { get; set; }
        public double TotalTravelAmount { get; set; }
        public double TotalTravelReimbursed { get; set; }
        public double TotalTravelNoReimbursed { get; set; }
        public string Notes { get; set; }

        public bool Meals { get; set; }
        public bool Registration { get; set; }
        public bool Lodgings { get; set; }
        public bool CarRental { get; set; }
        public bool Airfare { get; set; }
        public bool Mileage { get; set; }
        public bool OtherExpeses { get; set; }

        public System.Guid TravelID { get; set; }


    }
}
