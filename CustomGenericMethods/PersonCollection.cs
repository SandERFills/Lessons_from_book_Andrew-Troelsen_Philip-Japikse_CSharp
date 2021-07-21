using System;
using System.Collections;
using System.Collections.ObjectModel;


namespace CustomGenericMethods 
{
   public class Person{
       public int Age{get;set;}
       public string FirstName{get;set;}
       public string SecondName{get;set;}
       public Person(){}
       public Person(string firstname,string secondname ,int age){
           Age=age;
           FirstName=firstname;
           SecondName=secondname;
       }
       public override string ToString(){
           return $"Name: {FirstName} {SecondName}, Age= {Age}";
       }
   }
   public class PersonCollection: IEnumerable
    {
        private ArrayList arPeople=new ArrayList();
        //приведение для вызывающего кода
        public Person GetPerson(int pos)=>(Person)arPeople[pos];
         //вставка только объектов Person
         public void AddPerson(Person p){
             arPeople.Add(p);
         }
         public void ClearPeople(){
             arPeople.Clear();
         }
         public int Count=>arPeople.Count;
         //ПОддержка перечисления с помощью foreach
         IEnumerator IEnumerable.GetEnumerator()=>arPeople.GetEnumerator();
    }
}
