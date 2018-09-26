using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoTestar
{

    class TheWorldBuilder

    {
        public List<Items> items { get; set; }
        public List<Rooms> Room { get; set; }

        public TheWorldBuilder()
        {
            items = new List<Items>();
            Room = new List<Rooms>();
            DescriptionOfRooms();
            DescriptionOfItems();
        }
        public void DescriptionOfRooms()
        {
            Rooms room1 = new Rooms() { Name = "Inside Spaceship", Description = "Looking around you, you can see debris from the crash.\nThe seatbelt on the pilots-chair seem to be stuck and you can't get loose.\nThe computer monitor is buzzing frantically. ", exits = false };
            Rooms room2 = new Rooms() { Name = "Outside SpaceShip", Description = "You look around and realize that the planet you're on\nis very different from what you're used to. The ship's\nengine seems to be broken" };
            Rooms room3 = new Rooms() { Name = "Rum3", Description = "Här finns det ett träd" };
            Room.Add(room1);
            Room.Add(room2);
            Room.Add(room3);
        }

        public void DescriptionOfItems()
        {
            Items item1 = new Items() { Name = "COP", Description = "It's a wire of copper", Usable = true, CombinableItems = 1, ResultItem = 2 };
            Items item2 = new Items() { Name = "STI", Description = "It's a wooden stick", Usable = true, CombinableItems = 0, ResultItem = 2 };
            Items item3 = new Items() { Name = "WIREONASTICK", Description = "It's a wooden stick and a copper wire tied together", Usable = false };

            Items item4 = new Items() { Name = "HUD", Description = "It's Skin", Usable = true , CombinableItems = 4, ResultItem = 5};
            Items item5 = new Items() { Name = "KRÄM", Description = "It's cream", Usable = true , CombinableItems = 3, ResultItem = 5};
            Items item6 = new Items() { Name = "FINTANSIKTE", Description = "It's a face with nice skin", Usable = false };

            items.Add(item1);
            items.Add(item2);
            items.Add(item3);

            items.Add(item4);
            items.Add(item5);
            items.Add(item6);
        }

    }
}
