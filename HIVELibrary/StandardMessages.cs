using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIVELibrary
{
    public static class StandardMessages
    {
        public static void DisplayMoveError()
        {
            Console.WriteLine("Cannot go that way now.");
            Console.WriteLine("Try another direction?");
            Console.WriteLine();
        }
    }
}
