using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** LINQ begging!");
            QueryOverString();
        }
        static void QueryOverString()
        {
            string[] currentVidoGame = { "Morrowind", "Uncharted 2", "Fallout 2", "Command & Conquared", "System Shock" };
            IEnumerable<string> subset = from g in currentVidoGame where g.Contains(" ") orderby g select g;
            foreach (var s in subset)
            {
                Console.WriteLine("Item: {0}",s);
            }
        }
    }
}
