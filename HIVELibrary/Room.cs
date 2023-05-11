using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIVELibrary
{
    public class Room
    {
        private string _id, _name, _desc, _exits;

        public Room()
        {

        }

        public Room(string id, string name, string desc, string exits)
        {
            _id = id;
            _name = name;
            _desc = desc;
            _exits = exits;
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

        public string Exits
        {
            get;
            set;
        }
    }
}
