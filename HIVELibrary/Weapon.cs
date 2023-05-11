using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIVELibrary
{
    public class Weapon
    {
        private string _id, _name, _desc, _damageType, _price, _damage;

        public Weapon()
        {

        }

        public Weapon(string id, string name, string desc, string damageType, string price, string damage)
        {
            _id = id;
            _name = name;
            _desc = desc;
            _damageType = damageType;
            _price = price;
            _damage = damage;
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

        public string Desc
        {
            get;
            set;
        }

        public string DamageType
        {
            get;
            set;
        }

        public string Price
        {
            get;
            set;
        }

        public string Damage
        {
            get;
            set;
        }
    }
}
