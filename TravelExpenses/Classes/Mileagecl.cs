using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravelExpenses
{
    class Mileagecl
    {
        private bool districticProvidedVehicle;

        public bool DistricticProvidedVehicle
        {
            get { return districticProvidedVehicle; }
            set { districticProvidedVehicle = value; }
        }

        private bool directorApprovedPersonal;

        public bool DirectorApprovedPersonal
        {
            get { return directorApprovedPersonal; }
            set { directorApprovedPersonal = value; }
        }

        private double mapMileage;

        public double MapMileage
        {
            get { return mapMileage; }
            set { mapMileage = value; }
        }

        private double vicinityMileage;

        public double VicinityMileage
        {
            get { return vicinityMileage; }
            set { vicinityMileage = value; }
        }
        private double totalMileage;

        public double TotalMileage
        {
            get { return totalMileage; }
            set { totalMileage = value; }
        }

        private string notes;

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }



    }
}
    