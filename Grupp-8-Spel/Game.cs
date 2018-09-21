using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_8_Spel
{
    class Game
    {
        public List<Room> RoomList { get; set; }
        public Game()
        {
            RoomList = new List<Room>();
        }
    }
}
