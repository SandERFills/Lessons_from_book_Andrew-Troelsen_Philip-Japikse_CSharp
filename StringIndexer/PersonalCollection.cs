using System;
using System.Collection;
using System.Collection.Generic;

namespace StringIndexer
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
    class PersonalCollection :IEnumerable
    {
        private Dictionary<string,Person> listPeople=new Dictionary<string,Person>();

        public Person this[string name]{

            get=>(Person)listPeople[name];
            set=>listPeople[name]=value;
        }
        public void ClearPeople(){
            listPeople.Clear();
        }
        public int Count=>listPeople.Count;
        IEnumerator IEnumerable.GetEnumerator()=>listPeople.GetEnumerator();
    }
}
