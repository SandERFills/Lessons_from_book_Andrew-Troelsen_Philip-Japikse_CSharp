using System;

namespace InheritanceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car myCar=new   Car(80);
            // Console.WriteLine(myCar.Speed);
            // myCar.Speed=160;
            // Console.WriteLine(myCar.Speed);
            MiniVan VanDarkWhole=new MiniVan();
            VanDarkWhole.Speed=950;
            Console.WriteLine(VanDarkWhole.Speed);
        }
    }
}
