using System;

namespace DungeonExplorer
{
    public class Room
    {
        public string Description { get; }
        public string Item { get; private set; }

        public Room(string description, string item = null)
        {
            Description = description;
            Item = item;
        }

        public void RemoveItem()
        {
            Item = null;
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}
