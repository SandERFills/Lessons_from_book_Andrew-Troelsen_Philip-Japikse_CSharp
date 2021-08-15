using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ return values");
            IEnumerable<string> subColorArr = GetStringSubset();
            foreach (var c in subColorArr)
            {
                Console.WriteLine(c);
            }
        }
        static IEnumerable<string> GetStringSubset()
        {
            string[] colors = { "Dark Red", "Blue", "Green", "Light Red", "Red" };
            IEnumerable<string> subset = from i in colors where i.Contains("Red") select i;
            return subset;
        }
        static IEnumerable<string> GetStringSubsetArray()
        {
            string[] colors = { "Dark Red", "Blue", "Green", "Light Red", "Red" };
            var subset = from i in colors where i.Contains("Red") select i;
            return subset.ToArray<string>();
        }
    }
}
