﻿using System;
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
            WorldBuilder worldBuilder = new WorldBuilder();
            Player player = new Player();
            Game game = new Game();
            //game.RoomList = worldBuilder.RoomList;
            game.mapArray = worldBuilder.mapArray;
            worldBuilder.CreateGame();

            game.Start();

            //Room room1 = new Room() { Name = "Rum1", Description = "Här är ett vackert rum, med sniglar på väggarna"};
            //Room room2 = new Room() { Name = "Rum2", Description = "Oj, vad mycket mögel det var här!"};
            //game.RoomList.Add(room1);
            //game.RoomList.Add(room2);


            //foreach (Room item in game.mapArray)
            //{
            //    Console.WriteLine(item.Name + ": " + item.Description);
            //}



            //Console.WriteLine(player.CurrentPosition);

            //Console.WriteLine(player.CurrentPosition.Name + ": " +player.CurrentPosition.Description);
            ////player.Move(player.CurrentPosition, room2);//Flytta från till.
            //Console.WriteLine(player.CurrentPosition.Name + ": " + player.CurrentPosition.Description);
            Console.ReadKey();
            
        }
    }
}
