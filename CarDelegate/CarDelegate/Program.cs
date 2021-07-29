using System;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegate fun ******!");
            Car car1 = new("Dog", 20, 100);
            Car.CarEngineHandler handler = new Car.CarEngineHandler(OnCarEngineEvent);
            car1.RegistlerForHandler(handler);
            
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            car1.RegistlerToRemove(handler2);
            Console.WriteLine("speed up");
            //Сообщения в верхнем регистре не выводятся
            for (int i = 0; i < 10; i++)
            {
                car1.Accelerate(10);
            }
            car1.RegistlerForHandler(handler2);
            car1.RegistlerToRemove(handler);
            //Сообщения только в верхнем регистре
            
            for (int i = 0; i < 10; i++)
            {
                car1.Accelerate(20);
            }
        }
       static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("message from car");
            Console.WriteLine("=> {0}",msg);
            Console.WriteLine("*****************");
        }
        static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("message from car");
            Console.WriteLine("=> {0}", msg.ToUpper());
            Console.WriteLine("*****************");
        }
    }
}
