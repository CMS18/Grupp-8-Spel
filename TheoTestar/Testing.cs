using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoTestar
{
    class Testing
    {
        public List<Items> items { get; set; }
        public List<Rooms> Room { get; set; }

        public Testing()
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
            Items item1 = new Items() { Name = "COPPERWIRE", Description = "It's a wire of copper" };
            Items item2 = new Items() { Name = "STICK", Description = "It's a wodden stick" };
            Items item3 = new Items() { Name = "WIREONSTICK", Description = "It's a wooden stick and a copper wire tied together" };
            items.Add(item1);
            items.Add(item2);
            items.Add(item3);
        }
    }
}
