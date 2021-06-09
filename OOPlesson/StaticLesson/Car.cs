using System;

namespace OOPlesson
{
    class Car
    {
        private string name;
        private int currentSpeed;
        public Car(int speed) :this(speed,""){}
        public Car(int speed=0,string name="noname"){
            if (speed>10)
            {
                speed=10;
            }
            currentSpeed=speed;
    if (name=="" || name==String.Empty)
    {
         name=null;
    }
          this.name=name??"noname"; 
        }
        public void PrintStatus(){
            System.Console.WriteLine("Speed ={0},driver name is {1}",currentSpeed,name);
        }
            
        
    }
}
