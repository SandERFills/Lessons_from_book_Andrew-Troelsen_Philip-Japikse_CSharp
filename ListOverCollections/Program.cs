using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOverCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Car> myCars = new List<Car>()
            {
                new Car { PetName = "Henry", Color = "Silver ", Speed = 100, Make = "BMW" },
                new Car { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
                new Car { PetName = "Mary", Color = " Black", Speed = 55, Make = "VW" },
                new Car { PetName = "Clunker ", Color = "Rust ", Speed = 5, Make = "Yugo" },
                new Car { PetName = "Melvin", Color = "White ", Speed = 43, Make = "Ford" }
            };
            GetFastCars(myCars);
        }
        static void GetFastCars(List<Car> cars)
        {
            var fastCars = from c in cars where c.Speed > 55 select c;
            foreach (var item in fastCars)
            {
                Console.WriteLine("Fasters car is {0}",item.PetName);
            }
        }
    }
}
