using System;
using System.Collections;
using System.Collections.Generic;

namespace FunWithGenericCollections
{
    public class Person{
       public int Age{get;set;}
       public string FirstName{get;set;}
       public string LastName{get;set;}
       public Person(){}
       public Person(string firstname,string lastname ,int age){
           Age=age;
           FirstName=firstname;
           LastName=lastname;
       }
       public override string ToString(){
           return $"Name: {FirstName} {LastName}, Age= {Age}";
       }
      public  static void UseGenericList(){
           //Создать список объектов Person и заполнить 
           //его с помощью инициализации объектов и коллекции
           List<Person> people=new List<Person>()
                {
               new Person{FirstName="Homer",LastName="Simpson",Age=47},
               new Person{FirstName="Marge",LastName="Simpson",Age=45},
               new Person{FirstName="Lisa",LastName="Simpson",Age=9},
               new Person{FirstName="Bart",LastName="Simpson",Age=8}
               };
           System.Console.WriteLine("Item in list {0}",people.Count);
           foreach (Person famalyMember in people)
           {
               System.Console.WriteLine(famalyMember);
           }
System.Console.WriteLine("\n->Inserting new person.");
people.Insert(2,new Person { FirstName = "Maggie", LastName = "Simpson", Age =2 });
        System.Console.WriteLine("Item in list : {0}",people.Count);
        Person[] arrayOfPeople=people.ToArray();
        foreach (Person p in arrayOfPeople)
        {
            System.Console.WriteLine("First Names: {0}",p.FirstName);
        }
    }
      
    }
}   
