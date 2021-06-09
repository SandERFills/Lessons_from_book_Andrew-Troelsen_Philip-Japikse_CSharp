using System;

namespace OOPlesson
{
    class Motocycle
    {
        private string name;
        private int currentSpeed;
        static private double CreditRate=0.4; //статическое поле вызывается в памяти один раз
        //доступно всем обьектам класс и изменяется для всех
        public Motocycle(){}
        public Motocycle(int speed) :this(speed,""){}
        public Motocycle(int speed=0,string name="noname"){
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
        static Motocycle(){ //статический конструктор нужен для разового вызова без изменения статического поля
            CreditRate=0.4;
        }
        public void PrintStatus(){
            System.Console.WriteLine("Speed ={0},driver name is {1}",currentSpeed,name);
        }
        public void SetCreditRate(double newRate){
            CreditRate=newRate;
        }
        public double GetCreditRate(){
            return CreditRate;
        }
            
        
    }
}
