using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class Room
    {
        List<Furniture> FurnitureInRoom = new List<Furniture>();

        public string typeOfRoom { get; set; }

        public List<Furniture> Possiblefurniture = new List<Furniture>()
        {
            new Furniture("Table"),
            new Furniture("Fridge"),
            new Furniture("Sink"),
            new Furniture("Dishwasher"),
            new Furniture("Washing machine"),
            new Furniture("Bed"),
            new Furniture("Sofa"),
            new Furniture("TV"),
            new Furniture("PC"),
        };

        public Room(string type)
        {
            typeOfRoom = type;
        }


        public void FurbishRoom()
        {
            while (true)
            {
                Console.Clear();
                ShowFurniture();

                Console.WriteLine("What furniture do you want to add to this room ? exit to return");
                var furnitureInput = Console.ReadLine();
                var ChosenFurn = ChosenFurniture(furnitureInput);
                if (furnitureInput == "exit")
                {
                    break;
                }

                AddFurniture(ChosenFurn);
                Console.WriteLine("\nFurniture added to the room:");
                Console.WriteLine(FurnitureInRoom);
            }

        }

        public void ShowFurniture()
        {
            foreach (var furniture in Possiblefurniture)
            {
                Console.WriteLine(furniture.Name);
            }
        }

        public Furniture? ChosenFurniture(string furnitureName)
        {
            foreach (var furniture in Possiblefurniture)
            {
                if (furnitureName.ToLower() == furniture.Name.ToLower())
                {
                    return furniture;
                }
            }
            return null;
        }

        public void AddFurniture(Furniture furniture)
        {
            if (furniture != null)
            {
                FurnitureInRoom.Add(furniture);
            }
        }

    }

        
    
}



