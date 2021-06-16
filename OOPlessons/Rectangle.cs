using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlessons
{
    /// <summary>
    /// This class example Declarations features class 
    /// </summary>
    class Rectangle
    {
        private Point TopLeft = new Point() { };
        private Point BottonRight = new Point() { };
        public Point TopLeftProp
        {
            get { return TopLeft; }
            set { TopLeft = value; }
        }
        

        public Point BottonRightProp
        {
            get { return BottonRight; }
            set { BottonRight = value; }
        }
        public void Display()
        {
            TopLeftProp.DisplayPoint();
            BottonRightProp.DisplayPoint();
        }
    }
}
