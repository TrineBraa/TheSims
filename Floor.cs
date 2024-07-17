using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class Floor
    {
        public string FloorLevel;
        public List<Room> RoomsOnFloor;

        public Floor(string floorLevel)
        {
           FloorLevel =  floorLevel;
           RoomsOnFloor = new List<Room>();
           AddRoomMenu();
        }

        public List<Room> Rooms = new List<Room>()
        {
            new Room ("Kitchen"),
            new Room ("Livingroom" ),
            new Room ("Bathroom" ),
            new Room ("Laundryroom"),
            new Room ("Bedroom"),
        };


        public void AddRoomMenu()
        {
            Console.WriteLine($"Welcome to the {FloorLevel}");
            Console.WriteLine("What rooms do you want on this floor?");
            bool addRooms = true;
            while (addRooms)
            {
                Console.Clear();
                PrintAvailableRooms();
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
                AddRoom(FormFloor);
            }
        }


        public bool AddRoom(string chosenRoom)
        {
            foreach (Room room in Rooms)
            {
                if(room.typeOfRoom.ToLower() == chosenRoom.ToLower())
                {
                    // var FoundRoom = FindARoomToAdd(chosenRoom);
                    AddChoosenRoom(room);
                    Console.WriteLine($"You added a {chosenRoom} to this floor");
                    Console.ReadKey();
                    return true;
                }
            }
            Console.WriteLine("This is not a valid room");
            Console.ReadKey();
            return false;
        }

        //Gjentar en gjennomgang av rom hvor det ikke trengs.

        //private Room? FindARoomToAdd(string roomType)
        //{
        //    foreach (var room in Rooms)
        //    {
        //        if (roomType.ToLower() == room.typeOfRoom.ToLower())
        //        {
        //            return room;
        //        }
        //    }
        //    return null;
        //}

        private void AddChoosenRoom(Room room)
        {
            if(room != null)
            { 
                RoomsOnFloor.Add(room); 
            }
        }

        //Shitty shit no workie D:

        //private void AddChoosenRoom(string roomType)
        //{
        //    var result = Rooms.Where(room => room.typeOfRoom.ToLower() == roomType);
        //    foreach (var room in result)
        //    {
        //        RoomsOnFloor.Add(room);
        //    }
        //}

        public void PrintAddedRooms()
        {
            foreach (var room in RoomsOnFloor)
            {
                Console.WriteLine(room.typeOfRoom);
            }
        }

        public void PrintAvailableRooms()
        {
            foreach (var room in Rooms)
            {
                Console.WriteLine(room.typeOfRoom);
            }
        }

        public void ChooseARoom()
        {
            Console.Clear();
            PrintAddedRooms();
            Console.WriteLine("What Room do you want to furbish?");
            var RoomOption = Console.ReadLine();
            var ChosenRoom = FindARoomOnFloor(RoomOption);

            ChosenRoom?.FurbishRoom();
        }

        private Room? FindARoomOnFloor(string roomType)
        {
            foreach (var room in RoomsOnFloor)
            {
                if (roomType.ToLower() == room.typeOfRoom.ToLower())
                {
                    return room;
                }
            }
            return null;
        }
    }
}

//Before Audun helped shorten this bit and made it more readable!

//public bool AddRoom(string chosenRoom)
//{
//    if (chosenRoom == "kitchen")
//    {
//        AddChoosenRoom(chosenRoom);
//        Console.WriteLine("You added a Kitchen to this floor");
//        Console.ReadKey();
//        return true;
//    }
//    else if (chosenRoom == "bathroom")
//    {
//        AddChoosenRoom(chosenRoom);
//        Console.WriteLine("You added a Bathroom to this floor");
//        Console.ReadKey();
//        return true;
//    }
//    else if (chosenRoom == "livingroom")
//    {
//        AddChoosenRoom(chosenRoom);
//        Console.WriteLine("You added a Livingroom to this floor");
//        Console.ReadKey();
//        return true;
//    }
//    else if (chosenRoom == "laundryroom")
//    {
//        AddChoosenRoom(chosenRoom);
//        Console.WriteLine("You added a Laundryroom to this floor");
//        Console.ReadKey();
//        return true;
//    }
//    else if (chosenRoom == "bedroom")
//    {
//        AddChoosenRoom(chosenRoom);
//        Console.WriteLine("You added a Bedroom to this floor");
//        Console.ReadKey();
//        return true;
//    }
//    else
//    {
//        Console.WriteLine("This is not a valid room");
//        Console.ReadKey();
//        return false;
//    }
//}