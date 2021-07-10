using System;

namespace CloneablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Chill With Object Cloning");
            Point point = new Point(13, 24,"Wow");//создаём копию обьекта
            Point point1 = point;//оба обьекта указывают на одну область в памяти
            point1.X = 0;//изменение одного обьекта приводит к изменению другого
            Console.WriteLine(point1);
            Console.WriteLine(point);
            Point point2 = new Point(50, 50,"Malkos");//создаем копию обьекта 
            Point point3 = (Point)point2.Clone();//клонируем NEW копию обьекта point2
            point3.Y = 0;//изменения не влияют на первый обьект point2
            Console.WriteLine(point2);
            Console.WriteLine(point3);
        }
    }
}
