using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class Manager : Employee
    {
        //fields
        private int hoursAvailable;
        private int yearsEmployed;
        private int department;

        //properties
        public int HoursAvailable
        {
            get { return this.hoursAvailable; }
            set { this.hoursAvailable = value; }
        }



        //Constructors
        public Manager()
        {
            //default constructor
        }

        //methods
        public override void ClockIn()
        {
            Console.WriteLine("Manager clocked in");
        }

        public override void ShowId()
        {
            Console.WriteLine("Show ID" + EmployeeID);
        }

        public void AdoptedAPet()
        {
            Console.WriteLine("Manager Apopted a pet.");
        }

        public void PayTheBills()
        {
            Console.WriteLine("Manager Pays the Bills");
        }


    }
}