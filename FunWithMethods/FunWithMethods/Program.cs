using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void StringSwap(ref string str1,ref string str2)
        {
            string temp = str1;
            str1 = str2;
            str2 = temp;
        }
       static void Add(int a,int b,out int ans)
        {
            a=100;
            b = 200;
             ans= a + b;
        }
        static ref string  PositionArr(string[] array,int position)
        {
            return ref array[position];
        }
        static double DoubleAvenger(params double[] doubleArray)
        {
            double sum = 0;
            if (doubleArray.Length==0)
            {
                return sum;
            }
            foreach (var item in doubleArray)
            {
                sum += item;
            }
            return sum;
        }
        static  void ErrorData(string massage,string owner = "Programmer")
        {
            Console.Beep();
            Console.WriteLine($"Error : {massage}");
            Console.WriteLine("ownre is {0}",owner);
        }
        static void DisplaybeautifullyText(string massage,ConsoleColor consoleColor,ConsoleColor backgroundColor)
        {
            ConsoleColor oldForeground = Console.ForegroundColor;
            ConsoleColor oldBackground = Console.BackgroundColor;

            Console.ForegroundColor = consoleColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(massage);

            Console.BackgroundColor = oldBackground;
            Console.ForegroundColor = oldForeground;
        }


        static void Main(string[] args)
        {
            //  Add(1, 1, out int ans);
            //  string str1="Flip";
            //  string str2="Flop";
            //  Console.WriteLine("{0} , {1}",str1,str2);
            //  StringSwap(ref str1,ref str2);
            //  Console.WriteLine("{0} , {1}", str1, str2);
            //  DateTime dateTime = DateTime.Now;
            //  DateTime dateString =  DateTime.Now;
            //  string date = String.Empty;
            //  string[] stringArray = { "pos", "sos", "sis" };
            //ref string howis =ref PositionArr(stringArray, 1);
            //  howis = "new";
            //  foreach (var item in stringArray)
            //  {
            //      Console.Write(item+", ");
            //  }
            //  Console.WriteLine();
            //double[] arry = { 1.2, 22.3, 142.4, 12, 1.00001 };
            //Console.WriteLine(DoubleAvenger(arry));
            //Console.WriteLine(DoubleAvenger(1.2,132.4,4.2,24.2,14.2,1442.1,2.232324));
            //Console.ReadLine();

            ////Console.Beep();
            //ErrorData("MAAAAAAAAN WTF");
            //String str = "DamnSon";
            //string owner = "mew";
            //ErrorData(str, owner);
            //Console.ReadKey();
            DisplaybeautifullyText(backgroundColor: ConsoleColor.Yellow, consoleColor: ConsoleColor.Blue, massage: "Leason pOsOsI    ");
            Console.ReadLine();
        }
    }
}
