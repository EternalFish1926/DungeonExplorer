using System;
using System.Media;

namespace DungeonExplorer
{
       internal class Game
    {
        private Player player;
        private Room currentRoom;

        public Game()
        {
            player = new Player("Hero", 100);

            currentRoom = new Room("A dark and eerie dungeon room. A single torch flickers on the wall.", "Rusty Key");
        }

        public void Start()
        {
            //Introduction to room
            Console.WriteLine("Welcome to Dungeon Explorer!");
            Console.WriteLine($"You find yourself in: {currentRoom.GetDescription()}");

            bool playing = true;

            while (playing)
            {
                //Asks the player for input
                Console.WriteLine("\nWhat do you want to do? (look/move/take/inventory/quit)");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    //Gets description of room and items inside the room 
                    case "look":
                        Console.WriteLine($"You look around: {currentRoom.GetDescription()}");
                        if (currentRoom.Item != null)
                        {
                            Console.WriteLine($"You see a {currentRoom.Item} on the ground.");
                        }
                        break;
                        //Moves through the room 
                    case "move":
                        Console.WriteLine("You move deeper into the dungeon...");

                        break;
                        //Picks up item(s) in the room if any are seen  
                    case "take":
                        if (currentRoom.Item != null)
                        {
                            player.PickUpItem(currentRoom.Item);
                            Console.WriteLine($"You picked up {currentRoom.Item}.");
                            currentRoom.RemoveItem();
                        }
                        else
                        {
                            Console.WriteLine("There's nothing to take.");
                        }
                        break;
                        //Displays the players inventory
                    case "inventory":
                        Console.WriteLine("Your inventory: " + player.InventoryContents());
                        break;
                        //Quits the game
                    case "quit":
                        playing = false;
                        Console.WriteLine("Thanks for playing!");
                        break;
                        //Any other commands show as invalid
                    default:
                        Console.WriteLine("Invalid command. Try again.");
                        break;
                }
            }
        }
    }
}
