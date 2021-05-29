using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        class DateBase
        {
            public int? numVul = null;
            public bool? boolVal = true;
            public int? GetIntFromBase() { 
                return numVul; 
            }

                         
            
            public bool? GetBoolFromeBase()
            {
                return boolVal;
            }
        }
        static void Main(string[] args)
        {
            //int? a = null;//численным типам можно присваивать null через оператор ?
            DateBase dateInt = new DateBase();
            int? i = dateInt.GetIntFromBase();
            if (i.HasValue)
            {
                Console.WriteLine("Value i is {0}",i.Value);
            }
            else
            {
                Console.WriteLine("Value is undefind");

            }
            bool? b = dateInt.GetBoolFromeBase();
            if (b!=null)
            {
                Console.WriteLine("Value b is {0}",b.Value);
            }
            else
            {
                Console.WriteLine("Value is udefind");
            }
            Console.ReadLine();
        }
    }
}
