using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class Volunteer : Employee
    {
        //fields
        private int hoursAvailable;
        private int volunteerType;
        private int volunteerSpecialty;

        //properties
        public int HoursAvailable
        {
            get { return this.hoursAvailable; }
            set { this.hoursAvailable = value; }
        }

        public int VolunteerType
        {
            get { return this.volunteerType; }
            set { this.volunteerType = value; }
        }

        public int VolunteerSpecialty
        {
            get { return this.volunteerSpecialty; }
            set { this.volunteerSpecialty = value; }
        }


        //Constructors
        public Volunteer()
        {
            //default constructor
        }

        //methods

        public override void ClockIn()
        {
            Console.WriteLine("Volunteer clocked in");
        }

        public override void ShowId()
        {
            Console.WriteLine("Show ID" + EmployeeID);
        }

        public void FeedAllPets()
        {
            Console.WriteLine("All pets have been feed.");
        }

        public void WaterAllPets()
        {
            Console.WriteLine("Give water to all the pets.");
        }



    }
}
