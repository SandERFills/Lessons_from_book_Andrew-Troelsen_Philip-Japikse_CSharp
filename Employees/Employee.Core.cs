using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    /// <summary>
    /// Partial
    /// </summary>
   partial class Employee
    {
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected readonly string empSsn;
        protected BenefitPerson benefitPerson = new BenefitPerson();
        public double GetBenefirBonus()
        {
            return benefitPerson.ComputeBenefitPay();
        }
        

        public BenefitPerson benefit
        {
            get { return benefitPerson; }
            set { benefitPerson = value; }
        }


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
