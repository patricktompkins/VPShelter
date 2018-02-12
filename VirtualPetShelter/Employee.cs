using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    abstract class Employee
    {
        // fields

        private int employeeID;
        private string name;
        private string description;

        //properties

        public int EmployeeID
        {
            get { return this.employeeID; }
            set { this.employeeID = value; }

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        //Constructors
        public Employee()
        {
            //default constructor
        }



        //methods
        public abstract void ClockIn();

        public abstract void ShowId();




    }
}
