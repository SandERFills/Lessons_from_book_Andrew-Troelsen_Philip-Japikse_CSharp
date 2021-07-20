using System;
using System.Collections;
using System.Collections.Generic;

namespace FunWithGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******* Fun with Generic Collections!");
            // Person.UseGenericList();
            // Person.UseGenericStack();
            Person.UseGenericQueue();
            System.Console.WriteLine("Sorted By");
            Person.UseSortedSet();
            System.Console.WriteLine();
            UseDictionary();
        }
        private static void UseDictionary()
        {
            //Заполнение Dictionary с помощью метода .Add()
            Dictionary<string,Person> peopleA=new Dictionary<string,Person>();
            peopleA.Add("Homer",new Person{FirstName="Homer",LastName="Simpson",Age=47});
            peopleA.Add("Marge",new Person{FirstName="Marge",LastName="Simpson",Age=45});
            peopleA.Add("Lisa",new Person{FirstName="Lisa",LastName="Simpson",Age=9});
            Person homer=peopleA["Homer"];
            System.Console.WriteLine(homer);
            //Заполение Dictionary с помощью конструктора
            Dictionary<string,Person> peopleB=new Dictionary<string,Person>(){
               {"Homer", new Person{FirstName="Homer",LastName="Simpson",Age=47}},
              {"Marge", new Person{FirstName="Marge",LastName="Simpson",Age=45}},
              {"Lisa" ,new Person{FirstName="Lisa",LastName="Simpson",Age=9}}
            
            };
            Person lis=peopleB["Lisa"];
            System.Console.WriteLine(lis);
            //Другой способ инициализации пары ,который доступен только через конструктор-
            //это присваивание обьекта напрямую ключу
            Dictionary<string,Person> peopleC=new Dictionary<string,Person>(){
                ["Homer"]=new Person{FirstName="Homer",LastName="Simpson",Age=47},
                ["Marge"]= new Person{FirstName="Marge",LastName="Simpson",Age=45},
                ["Lisa"] =new Person{FirstName="Lisa",LastName="Simpson",Age=9}
            };
            Person mrg=peopleC["Marge"];
            System.Console.WriteLine(mrg);
        }
    

 }
}
