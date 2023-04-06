using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIVELibrary
{
    public static class DisplayRequested
    {
        public static void DisplayRooms()
        {
            Console.WriteLine();
            Console.WriteLine("Rooms:");
            Console.Write("1 - ");
            Console.WriteLine(World.room1);
            Console.WriteLine(World.roomText1);
            Console.Write("2 - ");
            Console.WriteLine(World.room2);
            Console.WriteLine(World.roomText2);
            Console.Write("3 - ");
            Console.WriteLine(World.room3);
            Console.WriteLine(World.roomText3);
            Console.Write("4 - ");
            Console.WriteLine(World.room4);
            Console.WriteLine(World.roomText4);
            Console.Write("5 - ");
            Console.WriteLine(World.room5);
            Console.WriteLine(World.roomText5);
            Console.WriteLine("Choose another option?");
        }
        public static void DisplayWeapons()
        {
            Console.WriteLine();
            Console.WriteLine("Weapons:");
            Console.Write("1 - ");
            Console.WriteLine(World.weapon1);
            Console.WriteLine(World.weaponText1);
            Console.Write("2 - ");
            Console.WriteLine(World.weapon2);
            Console.WriteLine(World.weaponText2);
            Console.Write("3 - ");
            Console.WriteLine(World.weapon3);
            Console.WriteLine(World.weaponText3);
            Console.Write("4 - ");
            Console.WriteLine(World.weapon4);
            Console.WriteLine(World.weaponText4);
            Console.WriteLine("Choose another option?");
        }
        public static void DisplayPotions()
        {
            Console.WriteLine();
            Console.WriteLine("Potions:");
            Console.Write("1 - ");
            Console.WriteLine(World.potion1);
            Console.Write("2 - ");
            Console.WriteLine(World.potion2);
            Console.WriteLine("Choose another option?");
        }
        public static void DisplayTreasure()
        {
            Console.WriteLine();
            Console.WriteLine("Treasure:");
            Console.Write("1 - ");
            Console.WriteLine(World.treasure1);
            Console.Write("2 - ");
            Console.WriteLine(World.treasure2);
            Console.Write("3 - ");
            Console.WriteLine(World.treasure3);
            Console.WriteLine("Choose another option?");
        }
        public static void DisplayItems()
        {
            Console.WriteLine();
            Console.WriteLine("Items:");
            Console.Write("1 - ");
            Console.WriteLine(World.item1);
            Console.Write("2 - ");
            Console.WriteLine(World.item2);
            Console.Write("3 - ");
            Console.WriteLine(World.item3);
            Console.Write("4 - ");
            Console.WriteLine(World.item4);
            Console.WriteLine("Choose another option?");
        }
        public static void DisplayMobs()
        {
            Console.WriteLine();
            Console.WriteLine("Mobs:");
            Console.Write("1 - ");
            Console.WriteLine(World.mob1);
            Console.WriteLine(World.mobText1);
            Console.Write("2 - ");
            Console.WriteLine(World.mob2);
            Console.WriteLine(World.mobText2);
            Console.Write("3 - ");
            Console.WriteLine(World.mob3);
            Console.WriteLine(World.mobText3);
            Console.Write("4 - ");
            Console.WriteLine(World.mob4);
            Console.WriteLine(World.mobText4);
            Console.Write("5 - ");
            Console.WriteLine(World.mob5);
            Console.WriteLine(World.mobText5);
            Console.WriteLine("Choose another option?");
        }
    }
}
