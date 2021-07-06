using System;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmaps bitmaps = new Bitmaps();
            bitmaps.Draw();
            bitmaps.DrawInBoundingBox(1,2,3,4);
            bitmaps.DrawUpSideDown();
            IAdvancedDraw advancedDraw = bitmaps as IAdvancedDraw;
            advancedDraw.DrawUpSideDown();
            Console.ReadLine();
        }
    }
}
