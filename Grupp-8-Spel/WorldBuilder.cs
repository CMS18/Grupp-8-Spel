using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupp_8_Spel
{
    class WorldBuilder
    {
        Game game = new Game();
        public List<Item> ItemList { get; set; }
        public List<Room> RoomList { get; set; }
        public void CreateGame()
        {
            CreateWorld();
            CreateItem();
        }
        public void CreateWorld()
        {
          
            Room room1 = new Room() { Name = "Rum1", Description = "Här är ett vackert rum, med sniglar på väggarna" };
            Room room2 = new Room() { Name = "Rum2", Description = "Oj, vad mycket mögel det var här!" };
            game.RoomList.Add(room1);
            game.RoomList.Add(room2);
        }
        public void CreateItem()
        {
            Item itemSpaghetti = new Item() { Name = "Spaghetti", Description = "Perfekt för att göra en pasta på!" }; 
            Item itemParmesan = new Item() { Name = "Parmesan", Description = "Perfekt för att göra en pasta på!" }; 
            Item itemBacon = new Item() { Name = "Bacon", Description = "Perfekt för att göra en pasta på!" }; 
            Item itemCarbonara = new Item() { Name = "Carbonara", Description = "En krämig pasta Carbonara" };
            game.ItemList.Add(itemBacon);
            game.ItemList.Add(itemSpaghetti);
            game.ItemList.Add(itemParmesan);
            game.ItemList.Add(itemCarbonara);

        }
        
        
    }
}
