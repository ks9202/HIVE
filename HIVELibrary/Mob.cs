using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIVELibrary
{
    public class Mob
    {
        private string _id, _name, _race, _type, _hp, _ac, _weapon, _inventory, _desc;

        public Mob()
        {

        }

        // "type" used in place of "class" to avoid keyword
        public Mob(string id, string name, string race, string type, string hp, string ac, string weapon, string inventory, string desc)
        {
            _id = id;
            _name = name;
            _race = race;
            _type = type;
            _hp = hp;
            _ac = ac;
            _weapon = weapon;
            _inventory = inventory;
            _desc = desc;
        }

        public string Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Race
        {
            get;
            set;
        }

        public string Type
        {
            get;
            set;
        }

        public string Hp
        {
            get;
            set;
        }

        public string Ac
        {
            get;
            set;
        }

        public string Weapon
        {
            get;
            set;
        }

        public string Inventory
        {
            get;
            set;
        }

        public string Desc
        {
            get;
            set;
        }
    }
}
