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
        public Room room;
        public string _floor;
        public List<Room> RoomsOnFloor = new List<Room>();
        public House(string Floor)
        {
            _floor = Floor;
        }

        public House()
        {
            
        }

        public List<Room> Rooms = new List<Room>()
        {
            new Room ("Kitchen"),
            new Room ("Livingroom" ),
            new Room ("Bathroom" ),
            new Room ("Laundryroom"),
            new Room ("Bedroom"),
        };


        public void BuildFloor(string Floor)
        {
            _floor = Floor;
            Console.WriteLine($"Welcome to the {_floor}");
            Console.WriteLine("What rooms do you want on this floor?");
            bool addRooms = true;
            while (addRooms)
            {
                Console.Clear();
                PrintAvailibleRooms();
                Console.WriteLine();

                Console.WriteLine("Here are the rooms you have added!");
                PrintAddedRooms();
                Console.WriteLine();
                Console.WriteLine("\n Write the name of the room you want to add, exit when done.");
                var FormFloor = Console.ReadLine();
                if (FormFloor == "exit")
                {
                    break;

                }

                AddRoom(FormFloor.ToLower());

            }

        }

        public bool AddRoom(string chosenRoom)
        {
            if (chosenRoom == "kitchen")
            {
                AddChoosenRoom(chosenRoom);
                Console.WriteLine("You added a Kitchen to this floor");
                foreach (var room in RoomsOnFloor)
                {
                    Console.WriteLine(room.typeOfRoom);
                }
                Console.ReadKey();
                return true;
            }
            else if (chosenRoom == "bathroom")
            {
                AddChoosenRoom(chosenRoom);
                Console.WriteLine("You added a Bathroom to this floor");
                Console.ReadKey();
                return true;
            }
            else if (chosenRoom == "livingroom")
            {
                AddChoosenRoom(chosenRoom);
                Console.WriteLine("You added a Livingroom to this floor");
                Console.ReadKey();
                return true;
            }
            else if (chosenRoom == "laundryroom")
            {
                AddChoosenRoom(chosenRoom);
                Console.WriteLine("You added a Laundryroom to this floor");
                Console.ReadKey();
                return true;
            }
            else if (chosenRoom == "bedroom")
            {
                AddChoosenRoom(chosenRoom);
                Console.WriteLine("You added a Bedroom to this floor");
                Console.ReadKey();
                return true;
            }
            else
            {
                Console.WriteLine("This is not a valid room");
                Console.ReadKey();
                return false;
            }
        }


        private void AddChoosenRoom(string roomType)
        { 
            var result  = Rooms.Where(room => room.typeOfRoom.ToLower() == roomType);
            foreach (var room in result)
            {
                RoomsOnFloor.Add(room);
            }
            
        }

        public void PrintAddedRooms()
        {
            foreach (var room in RoomsOnFloor)
            {
                Console.WriteLine(room.typeOfRoom);
            }
        }

        public void PrintAvailibleRooms()
        {
            foreach (var room in Rooms)
            {
                Console.WriteLine(room.typeOfRoom);
            }
        }

        public void FurbishHouse(House house)
        {
            while (true)
            {
                Console.WriteLine("What floor do you want to furbish?");
                Console.WriteLine("1. First Floor");
                Console.WriteLine("2. Secound Floor");
                Console.WriteLine("3. exit");
                var Floor = Console.ReadLine();
                switch (Floor)
                {
                    case "1":
                        room.FurnishRoom("First Floor"), RoomsOnFloor);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Please choose a valid option!");
                        break;
                }

            }
        }


    }
}
