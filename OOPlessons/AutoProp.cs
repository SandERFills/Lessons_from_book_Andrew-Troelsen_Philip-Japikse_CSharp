using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlessons
{
    /// <summary>
    /// Example properties
    /// </summary>
    class AutoProp
    {
        public string PetName { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }
        public void Display()
        {
            Console.WriteLine("Name: {0}",PetName);
            Console.WriteLine("Speed: {0}",Speed);
            Console.WriteLine("Color : {0}",Color);
        }
    }
}
