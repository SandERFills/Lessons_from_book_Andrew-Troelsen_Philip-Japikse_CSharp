using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDispose
{
    class MyResourseWrapper : IDisposable
    {
       public void Dispose()
        {
            Console.Beep();
            Console.WriteLine("I Dispose");
        }
    }
}
