using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class VirtualPetShelter
    {
        //fields
        private List<VirtualPet> myPet = new List<VirtualPet>();
        private Manager myMan = new Manager();
        private Volunteer myVol = new Volunteer();

        //properties
        public List<VirtualPet> MyPet
        {
            get { return this.myPet; }
            set { this.myPet = value; }
        }



        public Manager MyMan
        {
            get { return this.myMan; }
            set { this.myMan = value; }
        }

        public Volunteer MyVol
        {
            get { return this.myVol; }
            set { this.myVol = value; }
        }


        //contructors

        public VirtualPetShelter()
        {
            //Default Constructor
        }




    }
}


