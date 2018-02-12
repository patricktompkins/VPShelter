using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetShelter
{
    class Program
    {
        protected static VirtualPet myPet0;
        protected static VirtualPet myPet1;
        protected static VirtualPet myPet2;
        protected static VirtualPet myPet3;

        static void Main(string[] args)
        {
            bool isEndProgram = false;
            string inputData0 = "";
            string inputData1 = "";
            int createShelterMenu = 10;
            int mainMenu = 0;
            int managerMenu = 0;
            int volunteerMenu = 0;
            int[] myPetArry = new int[4] { 0, 0, 0, 0 };
            int numberOfPets = 4;

            int petChoice = 0;

            VirtualPetShelter myAnimalHouse = new VirtualPetShelter();
            myPet0 = new VirtualPet("Joey", "this is a pet");
            myAnimalHouse.MyPet.Add(myPet0);
            myPetArry[0] = 1;
            myPet1 = new VirtualPet("Johnny", "this is a pet");
            myAnimalHouse.MyPet.Add(myPet1);
            myPetArry[1] = 1;
            myPet2 = new VirtualPet("Dee Dee", "this is a pet");
            myAnimalHouse.MyPet.Add(myPet2);
            myPetArry[2] = 1;
            myPet3 = new VirtualPet("Tommy", "this is a pet");
            myAnimalHouse.MyPet.Add(myPet3);
            myPetArry[3] = 1;

            myAnimalHouse.MyMan.Name = "Peter";
            myAnimalHouse.MyVol.Name = "Tom";

            do
            {
                //tick method
                if (myPetArry[0] == 1)
                {
                    myAnimalHouse.MyPet[0].Tick();

                }
                if (myPetArry[1] == 1)
                {
                    myAnimalHouse.MyPet[1].Tick();

                }
                if (myPetArry[2] == 1)
                {
                    myAnimalHouse.MyPet[2].Tick();

                }
                if (myPetArry[3] == 1)
                {
                    myAnimalHouse.MyPet[3].Tick();

                }



                //place menu here


                Console.WriteLine("Welcome, select from the menu.\n\n");
                Console.WriteLine("1. To View Shelter");
                Console.WriteLine("2. To Setup Employees");
                Console.WriteLine("3. To Add Pet to Shelter");
                Console.WriteLine();
                Console.Write("> ");
                mainMenu = int.Parse(Console.ReadLine());
                Console.WriteLine();

                ; if (mainMenu == 1)
                {




                    //Enter the display output 

                    Console.WriteLine("Welcome to the Unicorn Virtual Pet Shelter. What employee type are you?\n\n");
                    Console.WriteLine("1. Manager");
                    Console.WriteLine("2. Volunteer");
                    Console.WriteLine();
                    Console.Write("> ");
                    createShelterMenu = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (createShelterMenu == 1)

                    {
                        Console.WriteLine("Thank you for working at the Unicorn Pet Shelter!\n\n");
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("1. Adopt a pet");
                        Console.WriteLine("2. Feed the pets");
                        Console.WriteLine("3. Play with a pet");
                        Console.WriteLine("4. Pay the bills");
                        Console.WriteLine("5. Quit\n\n");
                        Console.Write("> ");
                        managerMenu = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        if (managerMenu == 1)
                        {
                            Console.WriteLine("Okay, so you'd like to adopt a pet. Please choose a pet.\n\n");
                            if (myPetArry[0] == 1)
                                Console.WriteLine("For " + myAnimalHouse.MyPet[0].Name + " type 1");
                            if (myPetArry[1] == 1)
                                Console.WriteLine("For " + myAnimalHouse.MyPet[1].Name + " type 2");
                            if (myPetArry[2] == 1)
                                Console.WriteLine("For " + myAnimalHouse.MyPet[2].Name + " type 3");
                            if (myPetArry[3] == 1)
                                Console.WriteLine("For " + myAnimalHouse.MyPet[3].Name + " type 4");
                            Console.WriteLine("Which pet would you like to adopt with?\n\n");
                            Console.Write("> ");
                            petChoice = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            myAnimalHouse.MyMan.AdoptedAPet();
                            if (petChoice == 1 && myPetArry[0] == 1)
                            {
                                myAnimalHouse.MyPet.Remove(myPet0);
                                Console.WriteLine("Okay you adopted with " + myAnimalHouse.MyPet[petChoice].Name + ".");

                            }
                            else if (petChoice == 1 && myPetArry[1] == 1)
                            {
                                myAnimalHouse.MyPet.Remove(myPet1);
                                Console.WriteLine("Okay you adopted with " + myAnimalHouse.MyPet[petChoice].Name + ".");

                            }
                            else if (petChoice == 1 && myPetArry[2] == 1)
                            {
                                myAnimalHouse.MyPet.Remove(myPet2);
                                Console.WriteLine("Okay you adopted with " + myAnimalHouse.MyPet[petChoice].Name + ".");

                            }
                            else if (petChoice == 1 && myPetArry[3] == 1)
                            {
                                myAnimalHouse.MyPet.Remove(myPet3);
                                Console.WriteLine("Okay you adopted with " + myAnimalHouse.MyPet[petChoice].Name + ".");

                            }
                            else
                            {
                                Console.WriteLine("There is a error in adopting pet.");
                            }

                            numberOfPets--;
                            myPetArry[numberOfPets] = 0;

                        }

                        else if (managerMenu == 2)
                        {
                            Console.WriteLine("Okay, so you'd like to feed the pets.\n\n");
                            myAnimalHouse.MyPet[0].FeedMe();
                            Console.WriteLine("All the pets have been feed.\n\n");
                        }

                        else if (managerMenu == 3)
                        {
                            Console.WriteLine("Okay, so you'd  to like play with a pets. Please choose one.\n\n");
                            if (myPetArry[0] == 1)
                                Console.WriteLine("For " + myAnimalHouse.MyPet[0].Name + " type 1");
                            if (myPetArry[1] == 1)
                                Console.WriteLine("For " + myAnimalHouse.MyPet[1].Name + " type 2");
                            if (myPetArry[2] == 1)
                                Console.WriteLine("For " + myAnimalHouse.MyPet[2].Name + " type 3");
                            if (myPetArry[3] == 1)
                                Console.WriteLine("For " + myAnimalHouse.MyPet[3].Name + " type 4");
                            Console.WriteLine("Which pet would you like to play with?\n\n");
                            Console.Write("> ");
                            petChoice = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (myPetArry[petChoice] == 1)
                                myAnimalHouse.MyPet[petChoice].PlayWithMe();
                            Console.WriteLine("Okay you play with " + myAnimalHouse.MyPet[petChoice].Name + ".");

                        }

                        else if (managerMenu == 4)
                        {
                            Console.WriteLine("Okay, you want to pay your pet bills.");
                            myAnimalHouse.MyMan.PayTheBills();
                            Console.WriteLine("You paid the pet bills.");
                        }
                        else
                        {
                            isEndProgram = true;
                        }

                    }

                    else if (createShelterMenu == 2)
                    {
                        Console.WriteLine("Thank you for volunteering at the Unicorn Pet Shelter!\n\n");
                        Console.WriteLine("This is the status of your pets:\n\n");
                        Console.WriteLine("    Name    |   Hunger    |  Thrist    |    Bordom   ");
                        Console.WriteLine("------------|-------------|------------|-------------");
                        if (myPetArry[0] == 1)
                            Console.WriteLine(" {0, 10} | {1, 10}  | {2, 10}  | {3, 10} ", myAnimalHouse.MyPet[0].Name, myAnimalHouse.MyPet[0].Hungry, myAnimalHouse.MyPet[0].Thirst, myAnimalHouse.MyPet[0].Bordom);
                        if (myPetArry[1] == 1)
                            Console.WriteLine(" {0, 10} | {1, 10}  | {2, 10}  | {3, 10}  ", myAnimalHouse.MyPet[1].Name, myAnimalHouse.MyPet[1].Hungry, myAnimalHouse.MyPet[1].Thirst, myAnimalHouse.MyPet[1].Bordom);
                        if (myPetArry[2] == 1)
                            Console.WriteLine(" {0, 10} | {1, 10}  | {2, 10}  | {3, 10}  ", myAnimalHouse.MyPet[2].Name, myAnimalHouse.MyPet[2].Hungry, myAnimalHouse.MyPet[2].Thirst, myAnimalHouse.MyPet[2].Bordom);
                        if (myPetArry[3] == 1)
                            Console.WriteLine(" {0, 10} | {1, 10}  | {2, 10}  | {3, 10}  ", myAnimalHouse.MyPet[3].Name, myAnimalHouse.MyPet[3].Hungry, myAnimalHouse.MyPet[3].Thirst, myAnimalHouse.MyPet[3].Bordom);
                        Console.WriteLine("What would you like to do next?\n\n");
                        Console.WriteLine("1. Feed the pets");
                        Console.WriteLine("2. Water the pets");
                        Console.WriteLine("3.Play with the pets");
                        Console.WriteLine("4. Quit\n\n");
                        Console.Write("> ");
                        volunteerMenu = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (volunteerMenu == 1)
                        {
                            Console.WriteLine("Okay, so you'd like to feed the pets.\n\n");
                            myAnimalHouse.MyVol.FeedAllPets();
                            Console.WriteLine("All the pets hve been feed.\n\n");
                        }

                        else if (volunteerMenu == 2)
                        {
                            Console.WriteLine("Okay, so you'd like to water the pets.\n\n");
                            myAnimalHouse.MyVol.WaterAllPets();
                            Console.WriteLine("All the pets have been water.\n\n");
                        }

                        else if (volunteerMenu == 3)
                        {
                            Console.WriteLine("Okay, so you'd  to like play with a pets. Please choose one.\n\n");
                            if (myPetArry[0] == 1)
                                Console.WriteLine("For " + myAnimalHouse.MyPet[0].Name + " type 1");
                            if (myPetArry[1] == 1)
                                Console.WriteLine("For " + myAnimalHouse.MyPet[1].Name + " type 2");
                            if (myPetArry[2] == 1)
                                Console.WriteLine("For " + myAnimalHouse.MyPet[2].Name + " type 3");
                            if (myPetArry[3] == 1)
                                Console.WriteLine("For " + myAnimalHouse.MyPet[3].Name + " type 4");
                            Console.WriteLine("Which pet would you like to play with?\n\n");
                            Console.Write("> ");
                            petChoice = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            if (myPetArry[petChoice] == 1)
                                myAnimalHouse.MyPet[petChoice].PlayWithMe();
                            Console.WriteLine("Okay you play with " + myAnimalHouse.MyPet[petChoice].Name + ".");


                        }
                        else
                        {
                            isEndProgram = true;
                        }


                    }
                    else
                    {
                        isEndProgram = true;
                    }
                } //mainMenu
                else if (mainMenu == 2) // employee setup
                {

                    myAnimalHouse.MyMan.ShowId();
                    myAnimalHouse.MyMan.ClockIn();

                    myAnimalHouse.MyVol.ShowId();
                    myAnimalHouse.MyVol.ClockIn();


                } //mainMenu
                else if (mainMenu == 3) // pet setup
                {
                    int j = 0;
                    for (int i = 0; i < 4; i++)
                    {
                        if (myPetArry[i] == 0)
                        {
                            Console.WriteLine("There is room to Add Pet in slot: " + i);
                            j = i;
                            break;
                        }


                    }
                    Console.WriteLine("Add Pet Name!");
                    Console.Write("> ");
                    inputData0 = Console.ReadLine();


                    Console.WriteLine("Add Pet Description!");
                    Console.Write("> ");
                    inputData1 = Console.ReadLine();

                    Console.WriteLine();

                    if (j > 0)
                    {
                        myPet0 = new VirtualPet(inputData0, inputData1);
                        myAnimalHouse.MyPet.Add(myPet0);
                        myPetArry[j] = 1;
                        numberOfPets++;
                    }

                    Console.WriteLine(j + " Was added with name: " + myAnimalHouse.MyPet[j].Name);
                    inputData0 = Console.ReadLine();
                    Console.WriteLine("Select enter to continue...");





                } //mainMenu
                else
                {
                    isEndProgram = true;
                } //mainMenu

                Console.WriteLine("\n\n");
            } while (!isEndProgram);
        }
    }
}

