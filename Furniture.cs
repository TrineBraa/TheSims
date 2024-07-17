using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class Furniture
    {

        public string Name;
        public string InteractWithFurniture;

        public Furniture(string name, string Interact)
        {
            Name = name;
            InteractWithFurniture = Interact;
        }

        public Furniture(string name)
        {
            Name = name;
        }



    }
}
