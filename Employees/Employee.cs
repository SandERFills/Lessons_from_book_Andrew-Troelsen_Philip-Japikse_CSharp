using System;

namespace Employees
{
   abstract partial  class Employee
    {
        public Employee(string name, int age, int id, float pay,string ssn) : this(name, age, id, pay) {
            empSsn = ssn;
        }
        public class BenefitLevel
        {
            public enum BenefitEnum 
            {
                Silver=2,
                Gold=5,
                Platinum=6

            }
        }
        public static void GivePromoted(Employee employeer)
        {
            Console.WriteLine("{0} has promoted",employeer.Name);
            if (employeer is SalesPerson)
	            {
                Console.WriteLine("{0} had sale {1} stuff",employeer.Name,((SalesPerson)employeer).SalesNumber);
	            }
            else if(employeer is Manager)
	            {
                    Console.WriteLine("{0} had {1} stocks",employeer.Name,((Manager)employeer).StockOptions);    
	            }

        }
        public static void SwitchDiscard(Employee emp)
        {
            switch (emp)
	{
                case SalesPerson s when s.SalesNumber>5:
                    Console.WriteLine("{0} made {1} sale(s)!", emp.Name, s.SalesNumber);
                    break;
		default:
 break;
	}
        }
        public BenefitLevel benefitLevel = new BenefitLevel();
        //public BenefitLevel level
        //{
        //    get { return level; }
        //    set
        //    {
        //        level = value;
        //    }
        //}

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


        
        public virtual void DisplayStats(){
            Console.WriteLine("Name: {0}",empName);
            Console.WriteLine("ID: {0}",empID);
            Console.WriteLine("Age : {0}",empAge);
            Console.WriteLine("Pay: {0}",currPay);
        }
        public virtual void GiveBonus(float amount){
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
