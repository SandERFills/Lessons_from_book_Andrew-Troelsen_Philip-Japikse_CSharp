using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFaceNameClash
{
    class Octagone : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
      void   IDrawToForm.Draw()
        {
            Console.WriteLine("I draw to form");
        }
         void IDrawToMemory.Draw()
        {
            Console.WriteLine("I draw to memory");
        }
         void IDrawToPrinter.Draw()
        {
            Console.WriteLine("I draw to printer");
        }
    }
}
