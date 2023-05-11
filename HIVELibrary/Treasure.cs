using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIVELibrary
{
    public class Treasure
    {
        private string _id, _name, _price, _quest, _desc;

        public Treasure()
        {

        }

        public Treasure(string id, string name, string price, string quest, string desc)
        {
            _id = id;
            _name = name;
            _price = price;
            _quest = quest;
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

        public string Price
        {
            get;
            set;
        }

        public string Quest
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
