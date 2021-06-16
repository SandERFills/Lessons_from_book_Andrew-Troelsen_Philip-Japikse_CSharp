using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlessons
{
    class Motocycle
    {
        public string driverName;
        public int driverSpeed;
        public Motocycle() { }
        public Motocycle(int intensi)
        : this("", intensi) { Console.WriteLine("This is call int constract"); }
        public Motocycle(string name)
        : this(name,0) { Console.WriteLine("This is call string constract"); }
        public Motocycle(string name,int intensi)
        {
            if (intensi>10)
            {
                intensi = 10;
            }
            driverSpeed = intensi;
            driverName = name;
            Console.WriteLine("This is call main     constract");
        }
    }
}
