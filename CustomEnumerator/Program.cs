using System;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with IEnumerable/IEnumerator *****");
            Garage garage = new Garage();
            foreach (Car car in garage)
            {
                Console.WriteLine("Car name :{0} is {1} km/h",car.PetName,car.CurrentSpeed);
            }
        }
    }
}
