using System;
using System.Collections;
using System.Collections.Generic;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            TraditionalDelegateSyntax();
            AnonumousDelegateSyntax();
            LambdaExpressionSyntax();
        }
        static void TraditionalDelegateSyntax() 
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 6, 3, 5, 12 });
            Predicate<int> callBack = IsEvenNumber;//Predicate<T> принимает такой же тип,что и List<T>. Возвращает булевое значение
            List<int> evenNumbers = list.FindAll(callBack);
            Console.WriteLine("Here are you even numbers");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t",evenNumber);
            }
            Console.WriteLine();
        }
        static void AnonumousDelegateSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 6, 3, 5, 12 });
            List<int> evenNumbers = list.FindAll(delegate (int i) { return i % 2 == 0; });//использование анонимного метода
            foreach (var evenNumber in evenNumbers)
            {
                Console.Write("{0}\t",evenNumber);
            }
            Console.WriteLine();
        }
        static void LambdaExpressionSyntax()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 6, 3, 5, 12 });
            List<int> evenNumbers = list.FindAll(i => {//Здесь с лямбдой-выражения применятеся блок кода для вывода
                Console.WriteLine("Current value: {0}",i);
                bool EvenNum = i % 2==0;
                return EvenNum;
            });
            foreach (var evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }
       static bool IsEvenNumber(int i) {
            return i % 2 == 0;
        }
    }
}
