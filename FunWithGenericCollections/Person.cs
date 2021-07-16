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
      
      static void UseGenericList(){
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
 public   static void UseGenericStack()
    {
        Stack<Person> stackOfPeople=new Stack<Person>();
        stackOfPeople.Push(new Person{FirstName="Фёдр",LastName="Михайлович",Age=72});
        stackOfPeople.Push(new Person{FirstName="Лев",LastName="Николаевич",Age=86});
        stackOfPeople.Push(new Person{FirstName="Александр",LastName="Сергеевич",Age=34});
        //Посмотреть верхний элемент ,вытолкнуть его и посмотреть снова
        System.Console.WriteLine("First person is: {0}",stackOfPeople.Peek());
        System.Console.WriteLine("Popped of {0}\n",stackOfPeople.Pop());
        System.Console.WriteLine("First person is: {0}",stackOfPeople.Peek());
        System.Console.WriteLine("Popped of {0}\n",stackOfPeople.Pop());
        System.Console.WriteLine("First person is: {0}",stackOfPeople.Peek());
        System.Console.WriteLine("Popped of {0}\n",stackOfPeople.Pop());
        try{
System.Console.WriteLine("First person is: {0}",stackOfPeople.Peek());
        System.Console.WriteLine("Popped of {0}\n",stackOfPeople.Pop());
   
        }
        catch(InvalidOperationException ex){
            System.Console.WriteLine("\nError : {0}",ex.Message);
        }
         }
         static void GetCoffee(Person p){
             System.Console.WriteLine("{0} got coffee!",p.FirstName);
         }
       public  static void UseGenericQueue(){
             //Создать очередь из трёх человек
             Queue<Person> peopleQ=new Queue<Person>();
             peopleQ.Enqueue(new Person{FirstName="Фёдр",LastName="Михайлович",Age=72});
             peopleQ.Enqueue(new Person{FirstName="Лев",LastName="Николаевич",Age=86});
             peopleQ.Enqueue(new Person{FirstName="Александр",LastName="Сергеевич",Age=34});
             //Вернуть обьект и удалить его 3 раза
             GetCoffee(peopleQ.Dequeue());
             GetCoffee(peopleQ.Dequeue());
             GetCoffee(peopleQ.Dequeue());
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException e)
            {
                
                System.Console.WriteLine("Error {0}",e.Message);
            }
         }
    }
}   
