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
                HIVEMenu.PrintMenu();
                option = HIVEMenu.DisplayOption(option);
            }

            // Exit program
            // System.Environment.Exit(0);

            // Wasn't sure when to run combat, so it runs after the menu is exited.
            HIVEMenu.StartCombat();
            Console.ReadLine();
        }
    }
}
