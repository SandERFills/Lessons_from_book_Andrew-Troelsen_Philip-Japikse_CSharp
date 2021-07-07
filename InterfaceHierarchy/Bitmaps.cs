using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class Bitmaps : IAdvancedDraw
    {
       public void Draw()//We use method from basic interface
        {
            Console.WriteLine("Drawing");
        }

        public void DrawInBoundingBox(int left, int top, int right, int botton)
        {
            Console.WriteLine("Box drawing");
        }

        public void DrawUpSideDown()
        {
            Console.WriteLine("Draw up side down");
        }
    }
}
