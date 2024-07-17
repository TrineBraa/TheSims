using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSims
{
    internal class BuildMode
    {
        public House House = new House();


        public void BuildMenu()
        {
            Console.Clear();
                Console.WriteLine("Here you can build your house or furbish your house");
                Console.WriteLine();
                House.HouseMenu();




                //        var BuildingResponse = Console.ReadLine();
                //        switch (BuildingResponse)
                //        {
                //            case "1":
                //                BuildFirstFloor();
                //                break;
                //            case "2":
                //                if (!isFirstFloorBuilt)
                //                {
                //                    Console.WriteLine("Please built the first floor first!");
                //                }
                //                else
                //                {
                //                    BuildSecoundFloor();
                //                }
                //                break;
                //            case "3":
                //                House.FurbishHouse(House);
                //                break;
                //            case "4":
                //                Building = false;
                //                break;
                //        }
                //    }
                //}

                //public void BuildFirstFloor()
                //{
                //    Console.Clear();
                //    Console.WriteLine("You are building the first floor of your house!");
                //    new House("FirstFloor");
                //    House.BuildFloor("FirstFloor");
                //    isFirstFloorBuilt = true;

                //}


                //public void BuildSecoundFloor()
                //{
                //    Console.Clear();
                //    Console.WriteLine("You are building the secound floor of the house");
                //    Console.WriteLine("Write secound to continue");
                //    Console.WriteLine("If you don't want a secound floor please write exit");
                //    var SecoundResponse = Console.ReadLine().ToLower();

                //    if (SecoundResponse == "secound")
                //    {
                //        new House("SecoundFloor");
                //        House.BuildFloor("SecoundFloor");
                //    }
                //    else if (SecoundResponse == "exit")
                //    {
                //        return;
                //    }
                //    else {
                //        Console.WriteLine("Please input one of the two options!");
                //    }

            
        }
    }
}
