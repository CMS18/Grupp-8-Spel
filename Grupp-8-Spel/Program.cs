using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_8_Spel
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Game game = new Game();
            Room room1 = new Room() { Name = "Rum1"};
            Room room2 = new Room() { Name = "Rum2"};
            game.RoomList.Add(room1);
            game.RoomList.Add(room2);
            //player.CurrentPosition = room1;
            Console.WriteLine(player.CurrentPosition.Name);
            player.Move(player.CurrentPosition, room2);//Flytta från till.
            Console.WriteLine(player.CurrentPosition.Name);
        }
    }
}
