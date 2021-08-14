using System;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     Fun with anonymous types");
            var myCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            Console.WriteLine("my car is {0} {1}",myCar.Color,myCar.Make);
            BuildAnonType("WMB", "Green", 12);
            Console.WriteLine();
            Console.ReadLine();
            ReflectOverAnnonymousType(myCar);
            Console.WriteLine();
            EqualityTest();
        }
        static void BuildAnonType(string make,string color,int currSp)
        {
            //Построить анонимный тип с приминением входных аргументов
            var car = new { Make = make, Color = color, CurrSp = currSp };
            //Теперь этот тип можно использовать 
            //для получения данных
            Console.WriteLine("You have a {0} {1} going {2} ",car.Make,car.Color,car.CurrSp);
            Console.WriteLine("ToString()=={0}",car.ToString());


        }
        static void ReflectOverAnnonymousType(object obj)
        {
            Console.WriteLine("obj is instance of:{0}",obj.GetType().Name);
            Console.WriteLine("Base class of {0} is {1}",obj.GetType().Name,obj.GetType().BaseType);
            Console.WriteLine("obj.ToString()=={0}",obj.ToString());
            Console.WriteLine("obj.GetHashCode=={0}",obj.GetHashCode());
            Console.WriteLine();
        }
        static void EqualityTest()
        {
            var firstCar=new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
         var secondCar=new   { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
            //Проверка на равество средствами Equals()
            if (firstCar.Equals(secondCar))
            {
                Console.WriteLine("Cars is EQUALS");
            }
            else
            {
                Console.WriteLine("Cars is no EQUALS");
            }
            //Проверка на равенство оператором ==
            if (firstCar==secondCar)
            {
                Console.WriteLine("sama anonymous objects ");
            }
            else
            {
                Console.WriteLine("Not the same anonymous objects");
            }
            //Одинаковые ли типы
            if (firstCar.GetType().Name == secondCar.GetType().Name)
            {
                Console.WriteLine("They both have same types");
            }
            else
            {
                Console.WriteLine("They have different types");
            }
            Console.WriteLine();
            ReflectOverAnnonymousType(firstCar);
            ReflectOverAnnonymousType(secondCar);   
        }
    }
}
