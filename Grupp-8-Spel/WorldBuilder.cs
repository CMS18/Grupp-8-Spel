using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_8_Spel
{
    class WorldBuilder
    {
        int x = 0;
        int y = 0;
        public List<Item> ItemList { get; set; }
        //public List<Room> RoomList { get; set; }      //Ersätter med mapArray, känns som repetiotion
        public Room[,] mapArray { get; set; }

        //exit i room1 i east. 
        //måste ha lista för varje rum med exits
        //exits ska finnas 


        public WorldBuilder()
        {
            ItemList = new List<Item>();
            //RoomList = new List<Room>();
            mapArray = new Room[3, 3];

        }
        public void CreateGame()
        {
            CreateWorld();
            CreateItem();
        }
        public void CreateWorld()
        {
            //Room1
            Exit exit1ForRoom1 = new Exit() { ExitName = "Dörr", Description = "Dörren glider upp utan problem", Direction = "EAST", CanBeOpened = true };
            Exit exit2ForRoom1 = new Exit() { ExitName = "Dörr", Description = "Dörren glider upp utan problem", Direction = "SOUTH", CanBeOpened = false };
            Room room1 = new Room() { Name = "Rum1", Description = "Här är ett vackert rum, med sniglar på väggarna" };
            room1.Exits.Add(exit1ForRoom1);
            room1.Exits.Add(exit2ForRoom1);

            //Room2
            Exit exit1ForRoom2 = new Exit() { ExitName = "Dörr", Description = "Dörren glider upp utan problem", Direction = "WEST", CanBeOpened = true };
            Exit exit2ForRoom2= new Exit() { ExitName = "Dörr", Description = "Dörren glider upp utan problem", Direction = "SOUTH", CanBeOpened = false };
            Room room2 = new Room() { Name = "Rum2", Description = "Oj, vad mycket mögel det var här!" };
            room2.Exits.Add(exit1ForRoom2);
            room2.Exits.Add(exit2ForRoom2);


            //RoomList.Add(room1);

            mapArray[0, 0] = room1;
            mapArray[0, 1] = room2;

            //RoomList.Add(room2);
        }

        public void CreateItem()
        {
            Item itemSpaghetti = new Item() { Name = "Spaghetti", Description = "Perfekt för att göra en pasta på!" };
            Item itemParmesan = new Item() { Name = "Parmesan", Description = "Perfekt för att göra en pasta på!" };
            Item itemBacon = new Item() { Name = "Bacon", Description = "Perfekt för att göra en pasta på!" };
            Item itemCarbonara = new Item() { Name = "Carbonara", Description = "En krämig pasta Carbonara" };
            ItemList.Add(itemBacon);
            ItemList.Add(itemSpaghetti);
            ItemList.Add(itemParmesan);
            ItemList.Add(itemCarbonara);

        }


    }
}
