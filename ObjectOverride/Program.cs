using System;

namespace ObjectOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");
            Person program=new Person(name:"Posos",lastname:"Stricos",12);
            Console.WriteLine("{0}",program.GetHashCode());
            Console.WriteLine("{0} ",program.GetType());
            Console.WriteLine("{0} ",program.ToString());
            Person person=program;
            Object person2=person;
            if (person.Equals(person2) && program.Equals(person))
	{
                Console.WriteLine("insance");
	}
            Console.ReadLine();
        }
    }
}
