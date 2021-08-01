using System;
using System.Collections;
using System.Collections.ObjectModel;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=10,b=90;
            Console.WriteLine("Before swap: {0},{1}",a,b);
            MyGenericClass.Swap<int>(ref a,ref b);
            System.Console.WriteLine("After swap: {0},{1}",a,b);
            string first ="Hello",second="second";
            MyGenericClass.Swap<string>(ref first,ref second);
            System.Console.WriteLine();
            bool b1=true,b2=false;
            Console.WriteLine("Before swap: {0},{1}",b1,b2);
            MyGenericClass.Swap(ref b1,ref b2);//Обобщённые методы могу автоматически определять тип по параметру
            System.Console.WriteLine("After swap: {0},{1}",b1,b2);
            MyGenericClass.DisplayBaseClass<int>();
            Console.WriteLine();

        }
        static class MyGenericClass
        {
          public  static void Swap<T>(ref T a, ref T b)
            {
                System.Console.WriteLine("You sent the Swap() method a {0}", typeof(T));
                T temp = a;
                a = b;
                b = temp;
            }
            public static void DisplayBaseClass<T>()
            {
                System.Console.WriteLine("Base class of {0} is: {1} ", typeof(T), typeof(T).BaseType);
            }
        }
        //static void Swap(ref int a,ref int b){
        //    int temp=a;
        //    a=b;
        //    b=temp;
        //}
        //static void Swap(ref Person a ,ref Person b){
        //    Person temp=a;
        //    a=b;
        //    b=temp;
        }
       
    }
}
