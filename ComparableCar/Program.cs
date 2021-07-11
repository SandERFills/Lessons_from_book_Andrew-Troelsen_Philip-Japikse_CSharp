using System;
using System.Collections;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("***** Fun with Object Sorting!");
            Car[] cars = new Car[5];
            cars[0] = new Car("Rusty", 80, 1) ;
            cars[1] = new Car("Mary", 40, 234);
            cars[2] = new Car("Viper", 40, 34);
            cars[3] = new Car("Mel", 40, 4);
            cars[4] = new Car("Chucky", 40, 5);
            foreach(Car c in cars)
                Console.WriteLine("{0} {1}",c.CarID,c.PetName);
            Array.Sort(cars);//Принимает реализацию CompareTo()
            Console.WriteLine();
            Console.WriteLine("Here is the ordered set of cars: ");
            foreach(Car c in cars)
                Console.WriteLine("{0} {1}",c.CarID,c.PetName);
            Console.ReadLine();
        }
    }
}
