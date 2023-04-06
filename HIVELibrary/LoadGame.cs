using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HIVELibrary
{
    public static class LoadGame
    {
        public static void LoadRooms()
        {
            StreamReader read = File.OpenText("rooms.txt");
            while (!read.EndOfStream)
            {
                World.room1 = read.ReadLine();
                World.roomText1 = read.ReadLine();
                World.room2 = read.ReadLine();
                World.roomText2 = read.ReadLine();
                World.room3 = read.ReadLine();
                World.roomText3 = read.ReadLine();
                World.room4 = read.ReadLine();
                World.roomText4 = read.ReadLine();
                World.room5 = read.ReadLine();
                World.roomText5 = read.ReadLine();
            }
            read.Close();
        }
        public static void LoadWeapons()
        {
            StreamReader read = File.OpenText("weapons.txt");
            while (!read.EndOfStream)
            {
                World.weapon1 = read.ReadLine();
                World.weaponText1 = read.ReadLine();
                World.weapon2 = read.ReadLine();
                World.weaponText2 = read.ReadLine();
                World.weapon3 = read.ReadLine();
                World.weaponText3 = read.ReadLine();
                World.weapon4 = read.ReadLine();
                World.weaponText4 = read.ReadLine();
            }
            read.Close();
        }
        public static void LoadPotions()
        {
            StreamReader read = File.OpenText("potions.txt");
            while (!read.EndOfStream)
            {
                World.potion1 = read.ReadLine();
                World.potion2 = read.ReadLine();
            }
            read.Close();
        }
        public static void LoadTreasure()
        {
            StreamReader read = File.OpenText("treasure.txt");
            while (!read.EndOfStream)
            {
                World.treasure1 = read.ReadLine();
                World.treasure2 = read.ReadLine();
                World.treasure3 = read.ReadLine();
            }
            read.Close();
        }
        public static void LoadItems()
        {
            StreamReader read = File.OpenText("items.txt");
            while (!read.EndOfStream)
            {
                World.item1 = read.ReadLine();
                World.item2 = read.ReadLine();
                World.item3 = read.ReadLine();
                World.item4 = read.ReadLine();
            }
            read.Close();
        }
        public static void LoadMobs()
        {
            StreamReader read = File.OpenText("mobs.txt");
            while (!read.EndOfStream)
            {
                World.mob1 = read.ReadLine();
                World.mobText1 = read.ReadLine();
                World.mob2 = read.ReadLine();
                World.mobText2 = read.ReadLine();
                World.mob3 = read.ReadLine();
                World.mobText3 = read.ReadLine();
                World.mob4 = read.ReadLine();
                World.mobText4 = read.ReadLine();
                World.mob5 = read.ReadLine();
                World.mobText5 = read.ReadLine();
            }
            read.Close();
        }
    }
}
