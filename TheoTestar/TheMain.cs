using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoTestar
{
    class TheoMain
    {


        static void Main(string[] args)
        {
            TheWorldBuilder world = new TheWorldBuilder();
        
            
            //string listEntry = world.Room[0].Name;
            //Console.WriteLine(listEntry);

            //TheoGraphics graphics = new TheoGraphics();
            


            TheGame Game = new TheGame();

            //start our game loop - we keep running this function until the player quits.
            while (Game.isRunning)
            {
                Game.Update();
            }
        }

    }
}
