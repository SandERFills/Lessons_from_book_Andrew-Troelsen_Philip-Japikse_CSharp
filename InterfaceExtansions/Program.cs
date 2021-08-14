using System;
using System.Collections.Generic;

namespace InterfaceExtansions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Extending Interface Compatible types!");

            string[] stringArr = { "Воу", "Эта", "Сортировка", "Раздражает", "но", "весело", "странно" };
            stringArr.PrintDataAndBeep();
            List<int> intList = new List<int>{12, 424, 322, 44};
            intList.PrintDataAndBeep();
            Console.ReadLine();
        }
    }
}
