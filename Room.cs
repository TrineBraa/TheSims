using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class Room
    {
        
            public string typeOfRoom { get; set; }
            public List<Furniture> furniture = new List<Furniture>()
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

            public Room()
            {
                
            }

            public void FurnishRoom(House floor ,List<Room>RoomsOnFloor)
            {
                
            }



        
    }
}
