using System;
using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        public string Name { get; private set; }
        public int Health { get; set; }
        private List<string> inventory = new List<string>();

        public Player(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void PickUpItem(string item)
        {
            //Adds item(s) to inventory
            inventory.Add(item);
        }
    
        public string InventoryContents()
        {
            // Inventory contents displays empty if the player has not picked up anything
            return inventory.Count > 0 ? string.Join(", ", inventory) : "empty";
        }

        internal void PickUpItem(object item)
        {
            throw new NotImplementedException();
        }
    }
}
