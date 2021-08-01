using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
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
        public delegate void CarEngineHandler(string msgForCaller);
        private CarEngineHandler listhandler;
        public void RegistlerForHandler(CarEngineHandler methodToCall)
        {
            listhandler += methodToCall;
        }
       public void RegistlerToRemove(CarEngineHandler methodToRemove)
        {
            listhandler -= methodToRemove;
        }
        public void Accelerate(int delta)
        {
            if (CarIsDead)
            {
                if(listhandler!=null)
                listhandler("Sorry.but your car is dead!");
            }
            else
            {
                CurrSpeed += delta;
                if (10==(MaxSpeed-CurrSpeed) && listhandler!=null)
                {
                    listhandler("Wow.slow down,your car is almost in heaven");
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
