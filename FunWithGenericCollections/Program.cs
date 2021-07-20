using System;
using System.Collections;

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
        }
        
    

 }
}
