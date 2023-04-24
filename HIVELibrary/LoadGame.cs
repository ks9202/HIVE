﻿using System;
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
            for (int i = 0; i < 5; i++)
            {
                World.rooms[i] = read.ReadLine();
                World.roomsDesc[i] = read.ReadLine();
            }
            read.Close();
        }
        public static void LoadWeapons()
        {
            StreamReader read = File.OpenText("weapons.txt");
            for (int i = 0; i < 4; i++)
            {
                World.weapons[i] = read.ReadLine();
                World.weaponsDesc[i] = read.ReadLine();
            }
            read.Close();
        }
        public static void LoadPotions()
        {
            StreamReader read = File.OpenText("potions.txt");
            for (int i = 0; i < 2; i++)
            {
                World.potions[i] = read.ReadLine();
            }
            read.Close();
        }
        public static void LoadTreasure()
        {
            StreamReader read = File.OpenText("treasure.txt");
            for (int i = 0; i < 3; i++)
            {
                World.treasures[i] = read.ReadLine();
            }
            read.Close();
        }
        public static void LoadItems()
        {
            StreamReader read = File.OpenText("items.txt");
            while (!read.EndOfStream)
            {
                World.items.Add(read.ReadLine());
            }
            read.Close();
        }
        public static void LoadMobs()
        {
            StreamReader read = File.OpenText("mobs.txt");
            while (!read.EndOfStream)
            {
                World.mobs.Add(read.ReadLine());
                World.mobsDesc.Add(read.ReadLine());
            }
            read.Close();
        }
    }
}
