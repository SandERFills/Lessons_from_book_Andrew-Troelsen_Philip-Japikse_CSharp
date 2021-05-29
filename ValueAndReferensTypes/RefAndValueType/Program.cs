using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValueType
{
    class Program
    {
        class Person
        {
            public string name;
            public int age;
            public Person(string name_me,int myage)
            {
                name = name_me;
                age = myage;
            }
            public Person() { }
            public void Display()
            {
                Console.WriteLine("Age{0},Name{1}",age ,name);
            }
        }
        static void SwapMeth( ref Person e)//изменение переменной по ссылке
        {
            e = new Person(" AssHole", 12);
        }
        static void Main(string[] args)
        {
            Person person = new Person(" Frigail", 22);
            person.Display();
            Console.WriteLine();
            SwapMeth(ref person);//передача переменной по ссылке
            person.Display();
            Console.ReadLine();
        }
    }
}
