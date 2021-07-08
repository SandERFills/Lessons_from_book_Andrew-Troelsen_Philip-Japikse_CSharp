using System;
using System.Collections;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Garage garageCar=new Garage();//create instance Garage
            IEnumerator enummerator = garageCar.GetEnumerator();//create instance enumerable type that contain in Garage
            enummerator.MoveNext();//assigning enumerable statment next value
            Car myCar=(Car)enummerator.Current;//assigning value of enum
            Console.WriteLine(myCar.CurrentSpeed);
        }
    }
}
