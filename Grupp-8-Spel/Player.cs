using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_8_Spel
{
    class Player
    {
        public string Name { get; set; }
        public Room CurrentPosition { get; set; }

        public Room Move(Room Position, Room next)
        {
            if (Console.ReadLine().ToUpper() == "UP") {//Byt ut
                Position = next;
            }
            return CurrentPosition = Position;
        }
    }
}
