using System;

namespace Employees
{
    partial class Employee
    {
        public Employee(string name, int age, int id, float pay,string ssn) : this(name, age, id, pay) {
            empSsn = ssn;
        }


        //public string SocialSecurityNumber
        //{
        //    get { return empSsn; }
        //}


        public int Age{
            get{return empAge;}
            set{empAge=value;}
        }
        

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
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
        
        public string Name
        {
            get { return empName; }
            set { 
                if (value.Length>15)
                {
                    Console.WriteLine("Lenght Error");
                }
                else
                {
                empName = value;    
                }
                 
                }
        }
        
    }
}
