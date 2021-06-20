using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        public SalesPerson(string name,int age,int empId,float currPay,String ssn,int numOfSales) : base(name, age, empId, currPay, ssn)
        {
            SalesNumber = numOfSales;
        }
        public int SalesNumber { get; set; }
        public override sealed void GiveBonus(float amount)
        {
            int countbonus = 0;
            if (SalesNumber>=0 && SalesNumber<=100)
            {
                countbonus = 10;
            }
            else
            {
                if (SalesNumber>=101 && SalesNumber<=200)
                {
                    countbonus = 15;
                }
                else
                {
                    countbonus = 20;
                }
            }
            base.GiveBonus(amount*countbonus);
        }
        public override void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age : {0}", empAge);
            Console.WriteLine("Pay: {0}", currPay);
            Console.WriteLine("Sale Number: {0}", SalesNumber);
        }
    }
}
