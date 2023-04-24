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
            Console.WriteLine(World.rooms[0]);
            Console.WriteLine(World.roomsDesc[0]);
            Console.Write("2 - ");
            Console.WriteLine(World.rooms[1]);
            Console.WriteLine(World.roomsDesc[1]);
            Console.Write("3 - ");
            Console.WriteLine(World.rooms[2]);
            Console.WriteLine(World.roomsDesc[2]);
            Console.Write("4 - ");
            Console.WriteLine(World.rooms[3]);
            Console.WriteLine(World.roomsDesc[3]);
            Console.Write("5 - ");
            Console.WriteLine(World.rooms[4]);
            Console.WriteLine(World.roomsDesc[4]);
            Console.WriteLine("Choose another option?");
            Console.WriteLine();
        }
        public static void DisplayWeapons()
        {
            Console.WriteLine();
            Console.WriteLine("Weapons:");
            Console.Write("1 - ");
            Console.WriteLine(World.weapons[0]);
            Console.WriteLine(World.weaponsDesc[0]);
            Console.Write("2 - ");
            Console.WriteLine(World.weapons[1]);
            Console.WriteLine(World.weaponsDesc[1]);
            Console.Write("3 - ");
            Console.WriteLine(World.weapons[2]);
            Console.WriteLine(World.weaponsDesc[2]);
            Console.Write("4 - ");
            Console.WriteLine(World.weapons[3]);
            Console.WriteLine(World.weaponsDesc[3]);
            Console.WriteLine("Choose another option?");
            Console.WriteLine();
        }
        public static void DisplayPotions()
        {
            Console.WriteLine();
            Console.WriteLine("Potions:");
            Console.Write("1 - ");
            Console.WriteLine(World.potions[0]);
            Console.Write("2 - ");
            Console.WriteLine(World.potions[1]);
            Console.WriteLine("Choose another option?");
            Console.WriteLine();
        }
        public static void DisplayTreasure()
        {
            Console.WriteLine();
            Console.WriteLine("Treasure:");
            Console.Write("1 - ");
            Console.WriteLine(World.treasures[0]);
            Console.Write("2 - ");
            Console.WriteLine(World.treasures[1]);
            Console.Write("3 - ");
            Console.WriteLine(World.treasures[2]);
            Console.WriteLine("Choose another option?");
            Console.WriteLine();
        }
        public static void DisplayItems()
        {
            Console.WriteLine();
            Console.WriteLine("Items:");
            Console.Write("1 - ");
            Console.WriteLine(World.items[0]);
            Console.Write("2 - ");
            Console.WriteLine(World.items[1]);
            Console.Write("3 - ");
            Console.WriteLine(World.items[2]);
            Console.Write("4 - ");
            Console.WriteLine(World.items[3]);
            Console.WriteLine("Choose another option?");
            Console.WriteLine();
        }
        public static void DisplayMobs()
        {
            Console.WriteLine();
            Console.WriteLine("Mobs:");
            Console.Write("1 - ");
            Console.WriteLine(World.mobs[0]);
            Console.WriteLine(World.mobsDesc[0]);
            Console.Write("2 - ");
            Console.WriteLine(World.mobs[1]);
            Console.WriteLine(World.mobsDesc[1]);
            Console.Write("3 - ");
            Console.WriteLine(World.mobs[2]);
            Console.WriteLine(World.mobsDesc[2]);
            Console.Write("4 - ");
            Console.WriteLine(World.mobs[3]);
            Console.WriteLine(World.mobsDesc[3]);
            Console.Write("5 - ");
            Console.WriteLine(World.mobs[4]);
            Console.WriteLine(World.mobsDesc[4]);
            Console.WriteLine("Choose another option?");
            Console.WriteLine();
        }

        public static void DisplayCurrentRoom()
        {
            if (World.player >= World.rooms.Length)
            {
                StandardMessages.DisplayMoveError();
                World.player--;
            }
            else if (World.player < 0)
            {
                StandardMessages.DisplayMoveError();
                World.player++;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(World.rooms[World.player]);
                Console.WriteLine();
            }
        }
    }
}
