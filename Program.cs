using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructLesson
{
    class Program
    {
        struct Point
        {
           public Point(int PosX,int PosY) { //Конструктор для объявления переменных
                X = PosX;
                Y = PosY;
            }
            private int X;
            private int Y;
            public void Increment()
            {
                X++;
                Y++;
            }
           public void Decrement()
            {
                X--;
                Y--;
            }
            public void Display()
            {
                Console.WriteLine("X :{0} , Y :{1}",X,Y);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*****First look at struct*****");
            Point point=new Point(12,32);
            
            point.Increment();
            point.Display();
            point.Decrement();
            point.Display();
            Console.ReadLine();
        }
    }
}
