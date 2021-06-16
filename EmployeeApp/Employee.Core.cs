using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    /// <summary>
    /// Partial
    /// </summary>
   partial class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            empAge = age;
            empID = id;
            empName = name;
            currPay = pay;
        }
    }
}
