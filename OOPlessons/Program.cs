using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlessons
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.PetName = "Lisa";
            //car.CurrSpeed = 10;
            //for (int i = 0; i < 10; i++)
            //{
            //    car.PrintSpeed();
            //    car.SpeedUp(5);
            //}
            //Motocycle motocycle = new Motocycle(0);
            //Motocycle motocycle1 = new Motocycle("Henry");
            //Motocycle motocycle2 = new Motocycle(name: "beach", intensi: 10);
            //Console.ReadLine();
            AutoProp autoProp = new AutoProp();
            autoProp.PetName = "Lenin";
            autoProp.Speed = 300_000;
            autoProp.Color = "nice";
            autoProp.Display();
            AutoProp autoProp1 = new AutoProp();
            autoProp.PetName = "Stalin";
            autoProp.Speed = 300;
            autoProp.Color = "mmm";
            Garage garage = new Garage();
            garage.NumbersOfCar = 2;
            garage.MyCar = autoProp;
            garage.MyCar = autoProp1;
            Console.WriteLine("Name car in garage: {0}",garage.MyCar.PetName);
            Console.WriteLine("Name car in garage: {0}", garage.MyCar.PetName);
            Point point = new Point(PontColor.GoldBlue) { X = 2, Y = 13 };
            point.DisplayPoint();
            Rectangle rectangle = new Rectangle() {
                BottonRightProp = new Point(23, 13), 
                TopLeftProp = new Point(22, 13) 
            };
            rectangle.Display();
            Console.ReadLine();
        }
    }
}
