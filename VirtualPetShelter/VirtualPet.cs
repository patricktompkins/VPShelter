using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class VirtualPet
   {
        //fields 
        private int petId;
        private string petType;
        private int age;
        private bool likesToTalk;
       
        private string petDiet;
        private string name;
        private string description;
        private int thirst;
        private int bordom;
        private int hungry;

        //properties

        public int PetId
        {
            get { return this.petId; }
            set { this.petId = value; }
        }

        public string PetType
        {
            get { return this.petType; }
            set { this.petType = value; }
        }
    
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public bool LikesToTalk
        {
            get { return this.likesToTalk; }
            set { this.likesToTalk = value; }
        }

        public int Hungry
        {
            get { return this.hungry; }
            set { this.hungry = value; }
        }
        public int Bordom
        {
            get { return this.bordom; }
            set { this.bordom = value; }
        }
        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public string PetDiet
        {
            get { return this.petDiet; }
            set { this.petDiet = value; }

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

        public VirtualPet()
        {

            //default constructor
        }

     
        public VirtualPet(string name, string description)
        {
            this.petId = 0;
            this.petType = "Horse";
            this.age = 0;
            this.likesToTalk = true;
            this.hungry = 12;
            this.thirst = 12;
            this.bordom = 12;
            this.petDiet = "Wheaties";
            this.name = name;
            this.description = description;
        }

        public VirtualPet(int id, string petType, int age, bool likesToTalk, int hungaryLevel, int thirst, int bordom, string petDiet, string name, string description)
        {
            this.petId = id;
            this.petType = petType;
            this.age = age;
            this.likesToTalk = likesToTalk;
            this.hungry = hungaryLevel;
            this.thirst = thirst;
            this.bordom = bordom;
            this.petDiet = petDiet;
            this.name = name;
            this.description = description;

        }

        //Methods
        public void TalkToThePet()
        {
            if (likesToTalk)
            {
                Console.WriteLine("Yes I like to talk.");
            }
            else
            {
                Console.WriteLine("No I don't like to talk");
            }

        }

        public void ProvideInformation()
        {
            Console.WriteLine("I am a {0} years old {1} that {2} to talk.", age, petType, likesToTalk);
        }

        public void AskQuestion(int question)
        {
            switch (question)
            {
                case 1:
                    Console.WriteLine(age);
                    break;

                case 2:
                    Console.WriteLine(likesToTalk);
                    break;
                case 3:
                    Console.WriteLine(petType);
                    break;

                default:
                    break;


            }
        }

        

        public void FeedMe()
        {
            Hungry--;
            Thirst++;
            Bordom--;
        }

        public void PlayWithMe()
        {
            Hungry++;
            Thirst++;
            Bordom--;
        }
        
        //TICK METHOD
        public void Tick()
        {
            string level;
            string speak;

            Console.Clear();

            Hungry++;
            Thirst++;
            Bordom++;


           
            if (Hungry < 10)
            {
                level = "I am not hungary.";
            }
            else
            {
                level = "I am hungry.";
            }

            if (Thirst < 10)
            {
                level = "I am not thirsty.";
            }
            else
            {
                level = "I am thirsty.";
            }

            if (Bordom < 10)
            {
                level = "I am not bored.";
            }
            else
            {
                level = "I am bored.";
            }
            Console.WriteLine();
        }











    }
}