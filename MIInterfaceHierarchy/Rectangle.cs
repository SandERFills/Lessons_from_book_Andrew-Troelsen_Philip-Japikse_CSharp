using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIInterfaceHierarchy
{
    class Rectangle : IShapes
    {
        void IDrawable.Draw()
        {
            Console.WriteLine();
        }

        void IPrintable.Draw()
        {
            Console.WriteLine();
        }

        int IShapes.GetNumbersOfSides()
        {
            return 1;
        }

        void IPrintable.Print()
        {
            Console.WriteLine();
        }
    }
}
