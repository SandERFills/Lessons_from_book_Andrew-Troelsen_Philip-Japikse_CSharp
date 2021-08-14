using System;

namespace Convers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with conversation! ******");
            Rectangle rectangle = new Rectangle(12, 8);
            Square square = (Square)rectangle;
            Console.WriteLine("Rectangle");
            rectangle.Draw();
            Console.WriteLine();
            Console.WriteLine("Square");
            square.Draw();
            int myInt = (int)square;
            Console.WriteLine(myInt);
            rectangle = square;
            rectangle.ToString();
            rectangle.Draw();
        }
    }
}
