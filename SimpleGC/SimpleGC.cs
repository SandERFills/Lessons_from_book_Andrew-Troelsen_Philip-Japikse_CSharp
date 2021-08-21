using System;

namespace SimpleGC
{
    class Car{
        public int Speed { get; set; }
        public string Name { get; set; }
        public Car(int speed,string name){
            Speed=speed;
            Name=name;
        }
        public override string ToString()=>$"name is {Name} and current speed is {Speed}";
    }
}