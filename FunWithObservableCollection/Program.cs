using System;
using System.Collections.ObjectModel;

namespace FunWithObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создаётся наблюдаемая коллекция с объектами Person
            ObservableCollection<Person> people =new ObservableCollection<Person>(){
                new Person{FirstName="Mick",SecondName="Jagger",Age=73},
                new Person{FirstName="Alphred",SecondName="Hitchcoc",Age=63}
            };
            //Привязаться к событию CollectionChanged
            people.CollectionChanged+=people_CollectionChange;//Событие вызывается постоянно
            //и его достаточно вызывать в одной точке программы
            people.Add( new Person{FirstName="Devid",SecondName="Linch",Age=54});
            // people.CollectionChanged+=people_CollectionChange;
        }
        static void people_CollectionChange(object sender,
        //Это и есть событие ,которое обрабатывает вызываемый его код в мэйне
        System.Collections.Specialized.NotifyCollectionChangedEventArgs e){
            System.Console.WriteLine("Action for this event: {0}",e.Action);
            if (e.Action==System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                System.Console.WriteLine("Here are the OLD items:");
                foreach (Person p in e.OldItems)
                {
                    System.Console.WriteLine(p.ToString());
                }
                System.Console.WriteLine();
            }
            if (e.Action==System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                System.Console.WriteLine("Here are the NEW items: ");
                foreach (Person p in e.NewItems)
                {
                    System.Console.WriteLine(p.ToString());
                }

            }

        }
   
    }
}
