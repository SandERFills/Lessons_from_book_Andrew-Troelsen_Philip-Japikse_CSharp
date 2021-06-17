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
    }
}
