empusing System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Fun wiyh Encapsulation*****");
            Employee emp=new Employee("Marvin",456,30000);
            emp.GiveBonus(1000);
            emp.DisplayStats();
            emp.SetName("Marv");
            Console.WriteLine("Employee is named : {0}",emp.GetName());
            Console.ReadLine();
        }
    }
}
