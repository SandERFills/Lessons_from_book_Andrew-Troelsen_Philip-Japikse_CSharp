using System;
using System.Collections;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with the Yeild KeyWord");
            Garage garageCar=new Garage();//create instance Garage
            //IEnumerator enummerator = garageCar.GetEnumerator();//create instance enumerable type that contain in Garage
            //enummerator.MoveNext();//assigning enumerable statment next value
            //Car myCar=(Car)enummerator.Current;//assigning value of enum
            //Console.WriteLine(myCar.CurrentSpeed);
            foreach (Car C in garageCar)//Take all elements using GetEnumerator()
            {
                Console.WriteLine("{0} is name,{1} is speed",C.PetName,C.CurrentSpeed);
            }
            //revers array
            //foreach (Car C in garageCar.GetEnumerator())
            //{

            //}
        }
    }
}
