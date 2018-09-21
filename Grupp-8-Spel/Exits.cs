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


        public void moveExit(string move)
        {
            Player player = new Player();
            string north = "north".ToUpper();
            string south = "south".ToUpper();
            string west = "west".ToUpper();
            string east = "east".ToUpper();
            bool northSouth;
            bool eastWest;


            if( move == north)
            {
               
                northSouth = true;
                if()
                {

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
