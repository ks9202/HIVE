﻿using System;
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
            // Display menu.
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

        public static string DisplayOption(string option)
        {
            // User input.
            option = Console.ReadLine();

            // StreamReader and count variable declaration.
            StreamReader read;

            // Room variables
            string room1 = "", room2 = "", room3 = "", room4 = "", room5 = "";
            // Room description variables
            string roomText1 = "", roomText2 = "", roomText3 = "", roomText4 = "", roomText5 = "";

            // Weapon variables
            string weapon1 = "", weapon2 = "", weapon3 = "", weapon4 = "";
            // Weapon description variables
            string weaponText1 = "", weaponText2 = "", weaponText3 = "", weaponText4 = "";

            // Potion variables
            string potion1 = "", potion2 = "";

            // Treasure variables
            string treasure1 = "", treasure2 = "", treasure3 = "";

            // Item variables
            string item1 = "", item2 = "", item3 = "", item4 = "";

            // Mob variables
            string mob1 = "", mob2 = "", mob3 = "", mob4 = "", mob5 = "";
            string mobText1 = "", mobText2 = "", mobText3 = "", mobText4 = "", mobText5 = "";

            // Switch for menu selection. Fallthrough is used to provide multiple
            // options for the same selection.
            switch (option.ToLower())
            {
                case "1":
                case "rooms":
                case "room":
                    // Open rooms file, read rooms into variables, print rooms, close rooms file
                    Console.WriteLine();
                    Console.WriteLine("Rooms:");
                    read = File.OpenText("rooms.txt");
                    while (!read.EndOfStream)
                    {
                        room1 = read.ReadLine();
                        roomText1 = read.ReadLine();
                        room2 = read.ReadLine();
                        roomText2 = read.ReadLine();
                        room3 = read.ReadLine();
                        roomText3 = read.ReadLine();
                        room4 = read.ReadLine();
                        roomText4 = read.ReadLine();
                        room5 = read.ReadLine();
                        roomText5 = read.ReadLine();
                    }
                    read.Close();
                    Console.Write("1 - ");
                    Console.WriteLine(room1);
                    Console.WriteLine(roomText1);
                    Console.Write("2 - ");
                    Console.WriteLine(room2);
                    Console.WriteLine(roomText2);
                    Console.Write("3 - ");
                    Console.WriteLine(room3);
                    Console.WriteLine(roomText3);
                    Console.Write("4 - ");
                    Console.WriteLine(room4);
                    Console.WriteLine(roomText4);
                    Console.Write("5 - ");
                    Console.WriteLine(room5);
                    Console.WriteLine(roomText5);
                    Console.WriteLine("Choose another option?");
                    break;

                case "2":
                case "weapons":
                case "weapon":
                    // Open weapons file, read weapons into variables, print weapons, close weapons file
                    Console.WriteLine();
                    Console.WriteLine("Weapons:");
                    read = File.OpenText("weapons.txt");
                    while (!read.EndOfStream)
                    {
                        weapon1 = read.ReadLine();
                        weaponText1 = read.ReadLine();
                        weapon2 = read.ReadLine();
                        weaponText2 = read.ReadLine();
                        weapon3 = read.ReadLine();
                        weaponText3 = read.ReadLine();
                        weapon4 = read.ReadLine();
                        weaponText4 = read.ReadLine();
                    }
                    read.Close();
                    Console.Write("1 - ");
                    Console.WriteLine(weapon1);
                    Console.WriteLine(weaponText1);
                    Console.Write("2 - ");
                    Console.WriteLine(weapon2);
                    Console.WriteLine(weaponText2);
                    Console.Write("3 - ");
                    Console.WriteLine(weapon3);
                    Console.WriteLine(weaponText3);
                    Console.Write("4 - ");
                    Console.WriteLine(weapon4);
                    Console.WriteLine(weaponText4);
                    Console.WriteLine("Choose another option?");
                    break;

                // Potions
                case "3":
                case "potions":
                case "potion":
                    // Option potions file, read potions into variables, print potions, close potions file
                    Console.WriteLine();
                    Console.WriteLine("Potions:");
                    read = File.OpenText("potions.txt");
                    while (!read.EndOfStream)
                    {
                        potion1 = read.ReadLine();
                        potion2 = read.ReadLine();
                    }
                    read.Close();
                    Console.Write("1 - ");
                    Console.WriteLine(potion1);
                    Console.Write("2 - ");
                    Console.WriteLine(potion2);
                    Console.WriteLine("Choose another option?");
                    break;

                // Treasures
                case "4":
                case "treasures":
                case "treasure":
                    // Open treasure file, read treasure into variables, print treasure, close treasure file
                    Console.WriteLine();
                    Console.WriteLine("Treasure:");
                    read = File.OpenText("treasure.txt");
                    while (!read.EndOfStream)
                    {
                        treasure1 = read.ReadLine();
                        treasure2 = read.ReadLine();
                        treasure3 = read.ReadLine();
                    }
                    read.Close();
                    Console.Write("1 - ");
                    Console.WriteLine(treasure1);
                    Console.Write("2 - ");
                    Console.WriteLine(treasure2);
                    Console.Write("3 - ");
                    Console.WriteLine(treasure3);
                    Console.WriteLine("Choose another option?");
                    break;

                // Items
                case "5":
                case "items":
                case "item":
                    // Open items file, read items into variables, print items, close items file
                    Console.WriteLine();
                    Console.WriteLine("Items:");
                    read = File.OpenText("items.txt");
                    while (!read.EndOfStream)
                    {
                        item1 = read.ReadLine();
                        item2 = read.ReadLine();
                        item3 = read.ReadLine();
                        item4 = read.ReadLine();
                    }
                    read.Close();
                    Console.Write("1 - ");
                    Console.WriteLine(item1);
                    Console.Write("2 - ");
                    Console.WriteLine(item2);
                    Console.Write("3 - ");
                    Console.WriteLine(item3);
                    Console.Write("4 - ");
                    Console.WriteLine(item4);
                    Console.WriteLine("Choose another option?");
                    break;

                case "6":
                case "mobs":
                case "mob":
                    // Open mobs file, reab mobs into variables, print mobs, close mobs file
                    Console.WriteLine();
                    Console.WriteLine("Mobs:");
                    read = File.OpenText("mobs.txt");
                    while (!read.EndOfStream)
                    {
                        mob1 = read.ReadLine();
                        mobText1 = read.ReadLine();
                        mob2 = read.ReadLine();
                        mobText2 = read.ReadLine();
                        mob3 = read.ReadLine();
                        mobText3 = read.ReadLine();
                        mob4 = read.ReadLine();
                        mobText4 = read.ReadLine();
                        mob5 = read.ReadLine();
                        mobText5 = read.ReadLine();
                    }
                    read.Close();
                    Console.Write("1 - ");
                    Console.WriteLine(mob1);
                    Console.WriteLine(mobText1);
                    Console.Write("2 - ");
                    Console.WriteLine(mob2);
                    Console.WriteLine(mobText2);
                    Console.Write("3 - ");
                    Console.WriteLine(mob3);
                    Console.WriteLine(mobText3);
                    Console.Write("4 - ");
                    Console.WriteLine(mob4);
                    Console.WriteLine(mobText4);
                    Console.Write("5 - ");
                    Console.WriteLine(mob5);
                    Console.WriteLine(mobText5);
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