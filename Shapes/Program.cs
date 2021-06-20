using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Hexagon hexagon = new Hexagon("Stivr");
            hexagon.Draw();
            Cyrcle cyrcle = new Cyrcle("Who");
            cyrcle.Draw();
            Console.ReadLine();
        }
    }
}
