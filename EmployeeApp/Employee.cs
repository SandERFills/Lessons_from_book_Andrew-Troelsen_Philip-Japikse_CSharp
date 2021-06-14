using System;

namespace EmployeeApp
{
    class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        public int Age{
            get{return empAge;}
            set{empAge=Age;}
        }
        public Employee(){}
        public Employee(string name,int id,float pay):this(name,0,id,float){}
        public Employee(string name,int age,int id,float pay){
empAge=age;
empID=id;
empName=name;
currPay=pay;
        }
        public void DisplayStats(){
            Console.WriteLine("Name: {0}",empName);
            Console.WriteLine("ID: {0}",empID);
            Console.WriteLine("Age : {0}",empAge);
            Console.WriteLine("Pay: {0}",currPay);
        }
        public void GiveBonus(float amount){
            currPay+=amount;
        }
        public string GetName(){
            return empName;
        }
        public void SetName(string name){
            if(name.Length >15)
                Console.WriteLine("Error Nma length")
                else
                empName=name;
        }
    }
}
