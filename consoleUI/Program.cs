using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace consoleUI
{
    /*
    * 3/12/2023
    * CSC 153
    * Kayla Smith
    * A menu with 6 different options of variables to display, and a 7th
    * option to exit the menu.
    */

    class Program
    {
        static void Main(string[] args)
        {
            // Option string for user input.
            string option = "none";

            // Loop for menu display, input of "7" or "exit" (ignoring case) will exit the loop.
            Console.WriteLine("Welcome. Choose a menu option to display.");
            while (option != "7" && (option.ToLower() != "exit"))
            {
                // Display menu. Blank lines included for cleanliness.
                Console.WriteLine();
                Console.WriteLine("1 - Display Rooms");
                Console.WriteLine("2 - Display Weapons");
                Console.WriteLine("3 - Display Potions");
                Console.WriteLine("4 - Display Treasures");
                Console.WriteLine("5 - Display Items");
                Console.WriteLine("6 - Display Mobs");
                Console.WriteLine("7 - Exit");
                Console.WriteLine();

                // User input.
                option = Console.ReadLine();

                // Open file for variable values
                StreamReader read;
                read = File.OpenText("descriptions.txt");
                int count = 1;

                // Read rooms and room descriptions, add to rooms list
                List<string> roomsList = new List<string>();
                for (int i = 0; i < 10; i++)
                {
                    roomsList.Add(read.ReadLine());
                }

                // Read weapons and weapon descriptions, add to weapons list
                List<string> weaponsList = new List<string>();
                for (int i = 0; i < 8; i++)
                {
                    weaponsList.Add(read.ReadLine());
                }

                // Read mobs and mob descriptions, add to mobs list
                List<string> mobsList = new List<string>();
                for (int i = 0; i < 10; i++)
                {
                    mobsList.Add(read.ReadLine());
                }

                // Potion variables
                string potion1 = "Health Potion";
                string potion2 = "Strength Potion";

                // Treasure variables
                string treasure1 = "Silver Coin";
                string treasure2 = "Antique Locket";
                string treasure3 = "Idol of Polybia";

                // Item variables
                string item1 = "Bundle of Arrows";
                string item2 = "Handheld Shield";
                string item3 = "Household Key";
                string item4 = "Cut of Meat";

                read.Close();

                // Switch for menu selection. Fallthrough is used to provide multiple
                // options for the same selection.
                switch (option.ToLower())
                {
                    case "1":
                    case "rooms":
                    case "room":
                        // Print rooms
                        Console.WriteLine();
                        Console.WriteLine("Rooms:");
                        count = 1;
                        for (int i = 0; i < 9;)
                        {
                            Console.Write(count + " - ");
                            Console.WriteLine(roomsList[i]);
                            Console.WriteLine(roomsList[i + 1]);
                            Console.WriteLine();
                            i += 2;
                            count++;
                        }
                        Console.WriteLine("Choose another option?");
                        break;

                    case "2":
                    case "weapons":
                    case "weapon":
                        // Print weapons
                        Console.WriteLine();
                        Console.WriteLine("Weapons:");
                        count = 1;
                        for (int i = 0; i < 7;)
                        {
                            Console.Write(count + " - ");
                            Console.WriteLine(weaponsList[i]);
                            Console.WriteLine(weaponsList[i + 1]);
                            Console.WriteLine();
                            i += 2;
                            count++;
                        }
                        Console.WriteLine("Choose another option?");
                        break;

                    // Potions
                    case "3":
                    case "potions":
                    case "potion":
                        Console.WriteLine();
                        Console.WriteLine("Potions:");
                        Console.WriteLine("1 - " + potion1);
                        Console.WriteLine("2 - " + potion2);
                        Console.WriteLine();
                        Console.WriteLine("Choose another option?");
                        break;

                    // Treasures
                    case "4":
                    case "treasures":
                    case "treasure":
                        Console.WriteLine();
                        Console.WriteLine("Treasures:");
                        Console.WriteLine("1 - " + treasure1);
                        Console.WriteLine("2 - " + treasure2);
                        Console.WriteLine("3 - " + treasure3);
                        Console.WriteLine();
                        Console.WriteLine("Choose another option?");
                        break;

                    // Items
                    case "5":
                    case "items":
                    case "item":
                        Console.WriteLine();
                        Console.WriteLine("Items:");
                        Console.WriteLine("1 - " + item1);
                        Console.WriteLine("2 - " + item2);
                        Console.WriteLine("3 - " + item3);
                        Console.WriteLine("4 - " + item4);
                        Console.WriteLine();
                        Console.WriteLine("Choose another option?");
                        break;

                    case "6":
                    case "mobs":
                    case "mob":
                        // Print mobs
                        Console.WriteLine();
                        Console.WriteLine("Mobs:");
                        count = 1;
                        for (int i = 0; i < 9;)
                        {
                            Console.Write(count + " - ");
                            Console.WriteLine(mobsList[i]);
                            Console.WriteLine(mobsList[i+1]);
                            Console.WriteLine();
                            i += 2;
                            count++;
                        }
                        Console.WriteLine("Choose another option?");
                        break;

                    // Exit included to prevent switch from defaulting.
                    case "7":
                    case "exit":
                        break;

                    // Invalid input
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid selection.");
                        Console.WriteLine("Try again?");
                        break;
                }
            }
            // Exit program
            System.Environment.Exit(0);
        }
    }
}
