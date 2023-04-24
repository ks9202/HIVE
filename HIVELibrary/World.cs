using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIVELibrary
{
    public static class World
    {
        // Variable for player location. Used to track movement.
        public static int player = 0;

        // Rooms and room description arrays
        public static string[] rooms = new string[5];
        public static string[] roomsDesc = new string[5];

        // Weapons and weapon description arrays
        public static string[] weapons = new string[4];
        public static string[] weaponsDesc = new string[4];

        // Potions array
        public static string[] potions = new string[2];

        // Treasures array
        public static string[] treasures = new string[3];

        // Items list
        public static List<string> items = new List<string>();

        // Mobs and mobs descriptions lists
        public static List<string> mobs = new List<string>();
        public static List<string> mobsDesc = new List<string>();
    }
}
