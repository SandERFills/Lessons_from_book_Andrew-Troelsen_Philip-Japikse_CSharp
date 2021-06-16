using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlessons
{
    enum PontColor
    {
        LightBlue,RedBlue,GoldBlue
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PontColor Color { get; set; }
        public Point(int x,int y)
        {
            X = x;
            Y = y;
            Color = PontColor.GoldBlue;
        }
        public Point(PontColor pontColor){Color = pontColor;
        }
        public Point():this(PontColor.RedBlue){}
        public void DisplayPoint()
        {
            Console.WriteLine("X={0},Y={1}",X,Y);
            Console.WriteLine("Color is {0}",Color) ;
        }
    }
}
