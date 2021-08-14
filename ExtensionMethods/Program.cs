using MyExtensionMethods;
using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Fun With Extensions!********");
            int MyInt = 123456789;
            MyInt.DisplayDefiningAssambly();
            Console.WriteLine(MyInt.ReverseDigits());
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.DisplayDefiningAssambly();
            
        }
    }
}
