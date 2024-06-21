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
        public string _floor;

        public List<string> Rooms = new List<string>()
        {
            "Kitchen",
            "Bathroom",
            "Livingroom",
            "Laundryroom",
            "Bedroom",
        };

        public House(string Floor)
        {
            _floor = Floor;
        }

        public House()
        {
        }


        public List<string> BuildFloor(House _floor)
        {
            Console.WriteLine($"Welcome to the {_floor}");
            List<string> RoomsOnFloor = new List<string>();
            Console.WriteLine("What rooms do you want on this floor?");
            bool addRooms = true;
            while (addRooms)
            {

                foreach (var Room in Rooms)
                {
                    Console.WriteLine(Room);
                }

                Console.WriteLine("Here are the rooms you have added!");
                Console.WriteLine(Rooms);
                Console.WriteLine("\n Write the name of the room you want to add, exit when done.");
                var FormFloor = Console.ReadLine().ToLower();
                if (FormFloor == "exit")
                {
                    break;

                }

                RoomsOnFloor.Add(RoomMenu(FormFloor));

            }

            return RoomsOnFloor;
        }

        public string RoomMenu(string chosenRoom)
        {
            if (chosenRoom == "kitchen")
            {
                Console.WriteLine("You added a Kitchen to this floor");
                Console.ReadKey();
                return "Kitchen";
            }
            else if (chosenRoom == "bathroom")
            {
                Console.WriteLine("You added a Bathroom to this floor");
                Console.ReadKey();
                return "Bathroom";
            }
            else if (chosenRoom == "livingroom")
            {
                Console.WriteLine("You added a Livingroom to this floor");
                Console.ReadKey();
                return "Livingroom";
            }
            else if (chosenRoom == "laundryroom")
            {
                Console.WriteLine("You added a Laundryroom to this floor");
                Console.ReadKey();
                return "Laundryroom";
            }
            else if (chosenRoom == "bedroom")
            {
                Console.WriteLine("You added a Bedroom to this floor");
                Console.ReadKey();
                return "Bedroom";
            }
            else
            {
                return "This is not a valid room";
            }

        }




    }
}
