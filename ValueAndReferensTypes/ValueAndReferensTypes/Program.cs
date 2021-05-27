using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferensTypes
{
    class Program
    {
        struct Point
        {
            public Point(int PosX, int PosY)
            { //Конструктор для объявления переменных
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
                Console.WriteLine("X :{0} , Y :{1}", X, Y);
            }
        }
        static void ValuesAndStek()
        {
            Point point1 = new Point(10, 10);
            Point point2 = point1;
            point1.Display();
            point2.Display();
            point1.Increment();
            point1.Display();
            point2.Display();
        }
        class PointRef
        {
            public PointRef(int Xref,int Yref)
            {
                X = Xref;
                Y = Yref;
            }
            public int X;
            public int Y;
            public void Display()
            {
                Console.WriteLine("X :{0} , Y :{1}", X, Y);
            }
        }
        static void RefMethodsOut()
        {
            PointRef pointRef = new PointRef(10, 10);
            PointRef pointRef1 = pointRef;
            pointRef.Display();
            pointRef1.Display();
            pointRef.X = 100;
            pointRef.Display();
            pointRef1.Display();
        }
        class ShapeInfo //Объявление класс
        {
            public string InfoString; //переменная класса
            public ShapeInfo(string info) //Конструктор класса
            {
                InfoString = info;
            }
            
        }
        struct Rectangle
        {
            public ShapeInfo RecInfo; //обьявление переменной типа ShapeInfo
            public int RecBottom, RecTop, RecLeft, RecRight;
            public Rectangle(string info,int recbot,int rectop,int recleft,int recright)
            {
                RecInfo =new ShapeInfo( info);//Передача значение по ссылке в конструктор поэтому будет изменятся у всех объектов 
                //типа Rectangle
                RecBottom = recbot;
                RecLeft = recleft;
                RecRight = recright;
                RecTop = rectop;
            }
            public void Display()
            {
                Console.WriteLine($"Info :{RecInfo.InfoString},bottom={RecBottom},top={RecTop},left={RecLeft},right={RecRight}");
            }
            
        }
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle("First rectangle", 12, 23, 3, 4);
            rectangle.Display();
            Rectangle rectangle1 = rectangle;
            //rectangle1.RecInfo.InfoString
            //rectangle1.RecInfo.InfoString = "Second rectangle";
            rectangle1.RecBottom = 444;
            rectangle1.Display();
           
            Console.ReadLine();
        }

    }
}
