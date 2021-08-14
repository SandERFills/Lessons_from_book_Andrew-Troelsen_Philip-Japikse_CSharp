using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExtansions
{
    static class AnnoyingClass
    {
        public static void PrintDataAndBeep(this System.Collections.IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
                Console.Beep();
            }
        }
    }
}
