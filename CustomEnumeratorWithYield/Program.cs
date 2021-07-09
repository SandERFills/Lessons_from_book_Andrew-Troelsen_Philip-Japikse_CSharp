using System;
using System.Collections;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with the Yeild KeyWord");
            
            Garage carLot = new Garage();
            // Получить элементы, используя GetEnumerator().
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} MPH",
            c.PetName, c.CurrentSpeed);
            }
            Console.WriteLine();
            // Получить элементы (в обратном порядке!)
            //с. применением именованного итератора.
            foreach (Car с in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} is going {1} MPH",
                с.PetName, с.CurrentSpeed);
            }
            Console.ReadLine();
        }
    }
}
