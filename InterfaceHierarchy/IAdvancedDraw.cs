using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    interface IAdvancedDraw : IDrawable//We epand interface
    {
        void DrawInBoundingBox(int left, int top, int right, int botton);
        void DrawUpSideDown();
    }
}
