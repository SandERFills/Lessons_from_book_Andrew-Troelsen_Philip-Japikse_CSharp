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
            Console.WriteLine("**** The Employee Class Hierarchy and *****");
            SalesPerson salesPerson = new SalesPerson("Boob", 12, 123442, 23, "POsos1", 123);
            salesPerson.GiveBonus(123.2f);
            salesPerson.DisplayStats();
            Manager manager = new Manager("Astofull Mrasish", 32, 222113, 123.2f, "1122-44r5-2", 321);
            manager.GiveBonus(300);
            manager.DisplayStats();
            
            object[] massObj=new object[4];
            massObj[0]=manager;
            massObj[1]=salesPerson;
            massObj[2]=1212;
            massObj[3]=new Hexagon();
     foreach (object item in massObj)
	{Hexagon h=item as Hexagon;
                if (h==null)
	{
                    Console.WriteLine("This is not hexagon");
	}
	}
            Employee employee = new SalesPerson("Astofull Mrasish", 32, 222113, 123.2f, "1122-44r5-2", 321);
            object manObj =new Manager("Ascar",23,112233223,231.23f,"OGO-CHTO-PROISHODIT",331);
            Employee.GivePromoted(salesPerson);
            Employee.GivePromoted(employee);
            Employee.GivePromoted(manager);
            Employee.GivePromoted((Manager)manObj);//Здесь экземпляр класс object стоит выше Employee,
                                                   //Поэтому нужно приводит тип object к типу или наследнику типа Employee
           Employee.SwitchDiscard(salesPerson);
            Console.ReadLine();
        }
         

    }
}
