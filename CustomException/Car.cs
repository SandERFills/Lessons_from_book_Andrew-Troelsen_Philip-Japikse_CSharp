using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptoin
{
    class Car
    {
        //В классе "имеется" экземпляр класса радио,что и отражанет наследование - "имеется"
        readonly Radio radio = new();
        public const int MAX_SPEED = 100;
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        public Car() { }
        public Car(string name,int curspeed)
        {
            CurrentSpeed = curspeed;
            PetName = name;
        }
        private bool carIsDead;
        public void CrankyTunes(bool on)
        {
            radio.TurnOn(on);
        }
        public void Accselerait(int delta)
        {
            if (carIsDead)
            {
                Console.WriteLine($"{PetName} is out of order");
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed>MAX_SPEED)
                {
                    
                    CurrentSpeed = 0;
                    carIsDead = true;
                    //throw new Exception($"{PetName} is overheated!");//Кидаем исключение в этом условии и программа закрывается
                    сarlsDeadException e = new сarlsDeadException($"{PetName} is overheated!","You have a lead of foot",DateTime.Now);//Создаём экземпляр класса ,чтобы обратиться к свойству
                    e.HelpLink = "http://www.CarsRus.com";
                    //Специальные данные касающиеся исключения
                    // e.Data.Add("TimeStamp", $"The car explosed at {DateTime.Now}");
                    // e.Data.Add("Cause", "You have a lead foot");
                    throw e;
                }
                else
                {
                    Console.WriteLine("=>Current speed: {0}",CurrentSpeed);
                }
            }
        }
    }
}
