using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvent
{
    public class CarEventArgs: EventArgs
    {
        public readonly string msg;
        public CarEventArgs(string messsage)
        {
            msg = messsage;
        }
    }
    class Car
    {
        /*
            1. Определить новый тип делегата, который будет использоваться для отправки уведомлений вызывающему коду.
            2. Объявить переменную-член этого типа делегата в классе Саг.
            3. Создать в классе Саг вспомогательную функцию, которая позволяет вызывающему коду указывать метод для обратного вызова.
            4. Реализовать метод Accelerate () для обращения к списку вызовов делегата в подходящих обстоятельствах.
        Это нужно реализовать для создания мета уведомлений о состоянии мотора
        */
        public int CurrSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string CarName { get; set; }
        private bool CarIsDead=false;
        public Car() { }
        public Car(string petname, int carspeed, int maxspeed)
        {
            CurrSpeed = carspeed;
            CarName = petname;
            MaxSpeed = maxspeed;
        }
        //1.определить тип делегата
        public delegate void CarEngineHandler(object sender,CarEventArgs e);
        public event EventHandler<CarEventArgs> Exploded;
        public event EventHandler<CarEventArgs> AboutToBlow;
        public void Accelerate(int delta)
        {
            if (CarIsDead)
            {
                
                    Exploded?.Invoke(this,new CarEventArgs("Sorry.but your car is dead!"));
            }
            else
            {
                CurrSpeed += delta;
                if (10==MaxSpeed-CurrSpeed)
                {
                    AboutToBlow?.Invoke(this, new CarEventArgs("Wow.slow down,your car is almost in heaven"));
                }
                if (CurrSpeed>=MaxSpeed)
                {
                    CarIsDead = true;
                }
                else
                {
                    Console.WriteLine("Current speed = {0}",CurrSpeed);
                }
            }
        }
    }
}
