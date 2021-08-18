using System;
using System.Collections;
using System.Linq;

namespace LINQOverArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ over ArrayList");
            //Необобщённая коллекция не реализует интерфейс IEnumerable<T> для работы с LINQ
            ArrayList myCars = new ArrayList()
            {
                new Car { PetName = "Henry", Color = "Silver ", Speed = 100, Make = "BMW" },
                new Car { PetName = "Daisy", Color = "Tan", Speed = 90, Make = "BMW" },
                new Car { PetName = "Mary", Color = " Black", Speed = 55, Make = "VW" },
                new Car { PetName = "Clunker ", Color = "Rust ", Speed = 5, Make = "Yugo" },
                new Car { PetName = "Melvin", Color = "White ", Speed = 43, Make = "Ford" }
            };
            //Трансформировать ArrayList в  IEnumerable<T>
            var MyCarEnum = myCars.OfType<Car>();
            var fastCar = from c in MyCarEnum where c.Speed > 55 select c;
            foreach (var car in MyCarEnum)
            {
                Console.WriteLine("Faster car:{0}",car.PetName);
            }

        }
    }
}
