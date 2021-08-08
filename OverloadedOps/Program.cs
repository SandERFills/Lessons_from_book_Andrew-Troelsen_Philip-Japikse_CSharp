using System;

namespace OverloadedOps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with operator override! *******");
            Point p1=new Point(100,20);
            Point p2=new Point(240,30);
            Point p3 =p1-p2;
            Point p4=p2+p1;
            System.Console.WriteLine("{0}",p1);
            System.Console.WriteLine("{0}",p2);
            System.Console.WriteLine("{0}",p3);
            System.Console.WriteLine("{0}",p4);
        }
    }
}
