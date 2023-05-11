using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HIVELibrary
{
    public class HIVEMenu
    {
        public static void PrintMenu()
        {
            // Old menu display. Not currently in use.
            Console.WriteLine();
            Console.WriteLine("1 - Display Rooms");
            Console.WriteLine("2 - Display Weapons");
            Console.WriteLine("3 - Display Potions");
            Console.WriteLine("4 - Display Treasures");
            Console.WriteLine("5 - Display Items");
            Console.WriteLine("6 - Display Mobs");
            Console.WriteLine("7 - Exit");
            Console.WriteLine();
        }

        public static void PrintWelcome()
        {
            // Sprint 4 alternate menu display.
            Console.WriteLine();
            Console.WriteLine("Welcome!");
            Console.WriteLine("Type north or n for north, south or s for south");
            Console.WriteLine("or type a command.");
            Console.WriteLine("Type exit to exit.");
            Console.WriteLine();
        }

        public static string DisplayOption(string option)
        {
            option = Console.ReadLine();
            // Switch for menu selection. Fallthrough is used to provide multiple
            // options for the same selection.
            switch (option.ToLower())
            {
                case "n":
                case "north":
                    StartMovement(option);
                    break;

                case "s":
                case "south":
                    StartMovement(option);
                    break;

                case "rooms":
                case "room":
                    // Load and display rooms
                    LoadGame.LoadRooms();
                    DisplayRequested.DisplayRooms();
                    break;

                case "weapons":
                case "weapon":
                    // Load and display weapons
                    LoadGame.LoadWeapons();
                    DisplayRequested.DisplayWeapons();
                    break;

                case "potions":
                case "potion":
                    // Load and display potions
                    LoadGame.LoadPotions();
                    DisplayRequested.DisplayPotions();
                    break;

                case "treasures":
                case "treasure":
                    // Load and display treasure
                    LoadGame.LoadTreasure();
                    DisplayRequested.DisplayTreasure();
                    break;

                case "items":
                case "item":
                    // Load and display items
                    LoadGame.LoadItems();
                    DisplayRequested.DisplayItems();
                    break;

                case "mobs":
                case "mob":
                    // Load and display mobs
                    LoadGame.LoadMobs();
                    DisplayRequested.DisplayMobs();
                    break;

                // Exit included to prevent switch from defaulting.
                case "exit":
                    break;

                // Invalid input
                default:
                    Console.WriteLine();
                    Console.WriteLine("Invalid selection.");
                    Console.WriteLine("Try again?");
                    break;
            }
            return option;
        }

        public static string StartMovement(string option)
        {
                switch (option.ToLower())
                {
                    // Move player north
                    case "n":
                    case "north":
                        if (World.player >= World.rooms.Length)
                        {
                            StandardMessages.DisplayMoveError();
                        }
                        else
                        {
                            World.player++;
                            DisplayRequested.DisplayCurrentRoom();
                        }
                        break;
                    // Move player south
                    case "s":
                    case "south":
                        if (World.player < 0)
                        {
                            StandardMessages.DisplayMoveError();
                        }
                        else
                        {
                            World.player--;
                            DisplayRequested.DisplayCurrentRoom();
                        }
                        break;
                }
            return option;
        }

        public static void StartCombat()
        {
            // Dice and player/mob health hard coded, variables
            int player = 150, mob = 150, hit = 0;
            int numDice, damage;
            string dice = "1D12";
            
            // Tokens
            string[] tokens = dice.Split('D');
            numDice = int.Parse(tokens[0]);
            damage = int.Parse(tokens[1]);

            // Blank readlines are included as a temporary fix to the hit
            // variable not regenerating. If the readlines are removed, the
            // hit variable will show as the first number generated several
            // times before switching to another number halfway through
            // the execution.
            do
            {
                // Player hits
                if (player > 0)
                {
                    hit = CalcDamage(numDice, damage);
                    mob -= hit;
                    Console.WriteLine("Mob takes " + hit + " damage");
                    Console.WriteLine("Mob - " + mob + "hp");
                }
                Console.ReadLine();

                // Mob hits
                if (mob > 0)
                {
                    hit = CalcDamage(numDice, damage);
                    player -= hit;
                    Console.WriteLine("Player takes " + hit  + " damage");
                    Console.WriteLine("Player - " + player + "hp");
                }
                Console.ReadLine();
            }
            while (!(player < 0 || mob < 0));

            // Death message
            if (player <= 0)
            {
                Console.WriteLine("Player dead");
            }
            if (mob <= 0)
            {
                Console.WriteLine("Mob dead");
            }
        }

        public static int CalcDamage(int numDice, int damage)
        {
            // Generate a random number for hit. For loop runs according
            // to the number of dice.
            int hit = 0;
            Random rand = new Random();

            for (int i = 0; i < numDice; i++)
            {
                hit = rand.Next(1, (damage + 1));
            }

            return hit;
        }
    }
}
