using System;

namespace ObjectOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");
            Person person = new Person("Homer", "Simpson", 43);
            Person person1 = new Person("Homer", "Simpson", 43);
            //Вевести поля экземпляров
            Console.WriteLine($"person.ToString() == {person.ToString()}");
            Console.WriteLine($"person1.ToString() == {person1.ToString()}");
            //Проверить их равенство
            Console.WriteLine($"person == person1 : {person.Equals(person1)}");
            //Проверить хеш-коды
            Console.WriteLine($"person.GetHashCode() == person1.GetHashCode(): {person.GetHashCode() == person1.GetHashCode()}");
            //Изменить возраст и проверить всё снова
            person1.Age = 50;
            Console.WriteLine($"person.ToString() == {person.ToString()}");
            Console.WriteLine($"person1.ToString() == {person1.ToString()}");
            Console.WriteLine($"person == person1 : {person.Equals(person1)}");
            Console.WriteLine($"person.GetHashCode() == person1.GetHashCode(): {person.GetHashCode() == person1.GetHashCode()}");
            Console.ReadLine();
        }
    }
}
