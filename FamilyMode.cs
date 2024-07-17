using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class Sim
    {
        private FamilyMode Family;

        public string Name { get; set; }
        public string Gender { get; set; }
        public string Hobby { get; set; }
        public string Age { get; set; }



        public void PrintSim()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Hobby: {Hobby}");
            Console.WriteLine($"This sim is: {Age}");
        }
    }


    internal class FamilyMode
    {
        private bool leaveCreating = true;
        private Sim sim;
        public string Lastname;
        public List<Sim> Family = new List<Sim>();
        
        public FamilyMode(string lastname)
        {
            Lastname = lastname;
        }

        public FamilyMode()
        {
            
        }


        public void CreateFamily()
        {
            while (leaveCreating)
            {
                Console.WriteLine("Here you can create your family of sims!");
                Console.WriteLine("\nPlease give your family a lastname: ");
                var lastname = Console.ReadLine();
                Console.WriteLine($"\n Your chosen lastname is {lastname}");
                Console.WriteLine("Are you happy with this lastname? y/n");
                var Response = Console.ReadLine().ToLower();
                if (Response == "y")
                {
                    Lastname = lastname;
                    CreationMenu();
                }
                else if (Response == "n")
                {
                    Console.WriteLine("Please choose a new lastname!");
                }
                else
                {
                    Console.WriteLine("please use either y or n:");
                }
            }
        }

        public void PrintFamily()
        {
            foreach (Sim simMember  in Family)
            {
                simMember.PrintSim();
            }
        }

      

        public void CreationMenu()
        {
            bool Creating = true;
            while (Creating)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Family mode");
                Console.WriteLine("\nCreate your sim");
                Console.WriteLine("Lastname: " + Lastname);
                Console.WriteLine("Family members:");
                PrintFamily();
                Console.WriteLine();
                Console.WriteLine("\n\tOptions:");
                Console.WriteLine("Create an Adult or a Child, exit to return to main menu.");
                var creation = Console.ReadLine().ToLower();
                if (creation == "adult")
                {
                    Console.WriteLine("You are creating an adult sim.");
                    Console.ReadKey();
                    CreateAdult();
                }
                else if (creation == "child") 
                {
                    Console.WriteLine("You are creating a child sim.");
                    Console.ReadKey();
                    CreateChild();
                }
                else if (creation == "exit")
                {
                    Console.WriteLine("You will return to the main menu");
                    Creating = false;
                    leaveCreating = false;
                    return List<Sim> Family;
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("Please choose one of the options given!");
                    Thread.Sleep(1000);
                }

            }
        }


        public void CreateAdult()
        {
            CreateSim("Adult");
        }

        public void CreateChild()
        {
            CreateSim("Child");
        }


        public void CreateSim(string AgeCategory)
        {

            if (SimInfo(out var name, out var gender, out var hobby)) return;


            Console.WriteLine($"\n\tName: {name} \n\tGender: {gender} \n\tHobby: {hobby}");
            Console.WriteLine("Are you happy with this sim? y or n");
            var AcceptSim = Console.ReadLine().ToLower();

            if (AcceptSim == "y")
            {
                var newSim = new Sim { Name = name, Gender = gender, Hobby = hobby, Age = AgeCategory};
                Family.Add(newSim);
                Console.WriteLine("New Child created successfully!");
            }
            else if (AcceptSim == "n")
            {
                Console.WriteLine("Returning you to the creation menu!");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("please use either y or n to respond!");
            }
        }

        private bool SimInfo(out string? name, out string? gender, out string? hobby)
        {
            Console.Clear();
            Console.WriteLine("Name:");
            name = Console.ReadLine();

            Console.WriteLine("\nGender:");
            gender = Console.ReadLine();

            Console.WriteLine("\nHobby:");
            hobby = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty!");
                return true;
            }
            else if (string.IsNullOrWhiteSpace(gender))
            {
                Console.WriteLine("Gender cannot be empty!");
            }
            else if (string.IsNullOrWhiteSpace(hobby))
            {
                Console.WriteLine("Hobby cannot be empty!");
            }

            return false;
        }
    }
}
