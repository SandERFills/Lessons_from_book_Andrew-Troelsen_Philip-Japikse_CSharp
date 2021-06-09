using System;

namespace OOPlesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1=new Car(20){};
            car1.PrintStatus();
            Motocycle moto=new Motocycle();
            Motocycle moto2=new Motocycle();
            System.Console.WriteLine(moto.GetCreditRate());
            moto.SetCreditRate(0.008);
            System.Console.WriteLine(moto.GetCreditRate());
            System.Console.WriteLine(moto2.GetCreditRate());
            Console.ReadLine();
        }
    }
}
