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
            public List<Furniture> furniture = new List<Furniture>();

            public Room(string type)
            {
                typeOfRoom = type;
            }

            public Room()
            {
                
            }


            public void AddFurnitureToRoom()
            {

            }



        
    }
}
