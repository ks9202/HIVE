using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIVELibrary
{
    public class Potion
    {
        private string _id, _name, _price, _val, _desc;

        public Potion()
        {

        }

        public Potion(string id, string name, string price, string val, string desc)
        {
            _id = id;
            _name = name;
            _price = price;
            _val = val;
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

        public string Val
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
