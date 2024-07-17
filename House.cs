using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace TheSims
{
    internal class House
    {
        public List<Floor> FloorList = new List<Floor>();
        
        public House()
        {
            
        }


        public void HouseMenu()
        {
            Console.WriteLine("Build your house!");
            Console.WriteLine("What floor do you want to build?");
            Console.WriteLine("\n1. First floor");
            Console.WriteLine("2. Second floor");
            Console.WriteLine("3. Third floor");
            Console.WriteLine("4. Furbish your house");
            Console.WriteLine("\n5. Return to the main Menu");
            var MenuOption = Console.ReadLine();
            Console.WriteLine();
            MenuChoices(MenuOption);
        }

        public void MenuChoices(string MenuOption)
        {
            switch (MenuOption)
            {
                case "1":
                    Console.WriteLine("You are building the first floor!");
                    FloorList.Add(new Floor("First Floor"));
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("You are building the second floor!");
                    FloorList.Add(new Floor("Second Floor"));
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("You are building the Third floor!");
                    FloorList.Add(new Floor("Third Floor"));
                    Console.ReadKey();
                    break;
                case "4":
                    Console.WriteLine("You are furbishing your house!");
                    ChooseAFloor();
                    Console.ReadKey();
                    break;
                case "5":
                    Console.WriteLine("You are returning to main menu!");
                    Thread.Sleep(1000); 
                    break;
                default:
                    Console.WriteLine("Please use a valid input");
                    break;
            }
        }

        public void ChooseAFloor()
        {
            while (true)
            {
                Console.Clear();
                ShowFloors();
                Console.WriteLine("What floor do you want to furbish? exit to return to main menu");
                var FloorChoice = Console.ReadLine();
                var ChosenFloor = FindFloor(FloorChoice);
                if (FloorChoice == "exit")
                {
                    break;

                }
                ChosenFloor?.ChooseARoom();
            }
        }


        public Floor? FindFloor(string ChosenFloor)
        {
            foreach (var floor in FloorList)
            {
                if (ChosenFloor.ToLower() == floor.FloorLevel.ToLower())
                {
                    return floor;
                }
            }
            return null;
        }


        public void ShowFloors()
        {
            foreach (var floor in FloorList)
            {
                Console.WriteLine(floor.FloorLevel);
            }
        }


    }
}
