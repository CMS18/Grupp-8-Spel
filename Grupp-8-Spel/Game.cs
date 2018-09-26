using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_8_Spel
{
    class Game
    {
        public List<Item> ItemList { get; set; }
        //public List<Room> RoomList { get; set; }
        public Room[,] mapArray { get; set; } 

        public Game()
        {
            ItemList = new List<Item>();
            //RoomList = new List<Room>();
            mapArray = new Room[3,3];

        }

        public void Start()
        {
            int southNorth = 0;
            int eastWest = 0;

            while (true)
            {
                Console.Write("Du befinner dig i ");
                Console.WriteLine(mapArray[southNorth, eastWest].Name);

                Console.WriteLine("Välj en rikting att gå i (SOUTH/NORTH/EAST/WEST)");
                string chosenDirection = Console.ReadLine().ToUpper();


                switch (chosenDirection)
                {
                    case "NORTH":
                        southNorth--;
                        break;
                    case "SOUTH":
                        southNorth++;
                        break;
                    case "EAST":
                        eastWest++;
                        break;
                    case "WEST":
                        eastWest--;
                        break;
                    default:
                        Console.WriteLine("Välj en giltig riktning att gå!");
                        break;
                }
                //Console.Clear();
                continue;


            }




        }
    }
}
