using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_8_Spel
{
    class Exits
    {
        public List<Room> RoomList { get; set; }
        public string Description { get; set; }
        public string ExitName { get; set; }
        Room[,] mapArray = new Room[3, 3];


        public void moveExit(string move)
        {
            Player player = new Player();
            string north = "north".ToUpper();
            string south = "south".ToUpper();
            string west = "west".ToUpper();
            string east = "east".ToUpper();
            bool northSouth;
            bool eastWest;
            int northSouthInt = 2;
            int eastWestInt = 0;

            if (move == north)
            {
                northSouthInt--;
                northSouth = true;
                if (northSouth)
                {
                    //mapArray[northSouthInt, eastWestInt]
                }
            }
            else if (move == south)
            {
                northSouth = false;
            }
            if (move == east)
            {
                eastWest = true;
            }
            else if (move == west)
            {
                eastWest = false;
            }



        }


    }
}
