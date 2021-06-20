using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager: Employee
    {
        public int StockOptions { get; set; }
        public Manager(string fullname,int age,int empID,float currPay,string ssn,int numOfOpts) : base(fullname, age, empID, currPay, ssn)
        {
            //это свойство определено в классе MAnager
            StockOptions = numOfOpts;
            //Присвоить входные, параметры используя
            //Унаследованные свойства родительского класс
            ID = empID;
            Age = age;
            Name = fullname;
            Pay = currPay;
            
        }
        public override void GiveBonus(float amount)
        {

            base.GiveBonus(amount);
            Random random = new Random();
            StockOptions = random.Next(500);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of stocksOption:{0}",StockOptions);
        }
    }
}
