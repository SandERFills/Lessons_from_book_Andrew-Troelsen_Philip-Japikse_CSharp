using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** The Employee Class Hierarchy*****");
            SalesPerson salesPerson = new SalesPerson("Sos",23,1123,12.433f,"kurva",123);
            salesPerson.Age = 23;
            salesPerson.benefit.ComputeBenefitPay();
            Employee.BenefitLevel.BenefitEnum platinum =  Employee.BenefitLevel.BenefitEnum.Platinum;
            //salesPerson.ID = 12332;
            //salesPerson.Name = "The Who";
            //salesPerson.SalesNumber = 12;
            salesPerson.DisplayStats();
            Console.ReadLine();

        }
    }
}
