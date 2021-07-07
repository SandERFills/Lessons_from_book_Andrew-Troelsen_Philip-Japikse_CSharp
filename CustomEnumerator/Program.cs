using System;
using System.Collections;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with IEnumerable/IEnumerator *****");
            Garage garage = new Garage();
            IEnumerator i =garage.GetEnumerator();
            i.MoveNext();
            Car myCar=(Car)i.Current;
            Console.WriteLine("{0} is going {1} MPH",myCar.PetName,myCar.CurrentSpeed);
            i.MoveNext();
            myCar=(Car)i.Current;
            Console.WriteLine("{0} is going {1} MPH",myCar.PetName,myCar.CurrentSpeed);
        }
    }
}
