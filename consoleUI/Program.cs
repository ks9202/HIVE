using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HIVELibrary;

namespace consoleUI
{
    /*
    * 4/23/2023
    * CSC 153
    * Kayla Smith
    * A program with options to move north or south through rooms,
    * and to display rooms, weapons, potions, treasures, items
    * or mobs.
    */

    class Program
    {
        static void Main(string[] args)
        {
            string option = "none";

            // Print welcome and current room, loop
            HIVEMenu.PrintWelcome();
            // Rooms must be loaded before display
            LoadGame.LoadRooms();
            DisplayRequested.DisplayCurrentRoom();
            while (option.ToLower() != "exit")
            {
                option = HIVEMenu.DisplayOption(option);
            }
            // Exit program
            System.Environment.Exit(0);

            // Test for combat
            // HIVEMenu.StartCombat();
            // Console.ReadLine();
        }
    }
}
