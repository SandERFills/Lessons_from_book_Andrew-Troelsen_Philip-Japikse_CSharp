using System;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void DisplayMessage(string msg,ConsoleColor consoleColor,int printCount)
        {
            //Объявляем метод ,который будет делегирован и включает три параметра
            

            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = consoleColor;
            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }
            Console.ForegroundColor = previous;
        }
        static int Add(int A, int B) => A + B;
        static string StringSum(int a, int b) { return (a + b).ToString(); }
        static void Main(string[] args)
        {
            Console.WriteLine("****** FUN with Action<> and Func<> ********");
            Action<string, ConsoleColor, int> action = new Action<string, ConsoleColor, int>(DisplayMessage);//Action принимает методы с возвращаемым значением void
            string msg = Console.ReadLine();

            action(msg,ConsoleColor.Cyan,4);
            Func<int, int, int> func = new Func<int, int, int>(Add);//Делегат,который принимает до 16 параметро ,а последний всегда должен быть возвращаемым типом
            int funresult = func.Invoke(1, 3);
            Console.WriteLine(funresult);
            Func<int, int, string> func1 = new Func<int, int, string>(StringSum);//Делегат,который принимает до 16 параметро ,а последний всегда должен быть возвращаемым типом
            string stringresult = func1(14, 23);
            Console.WriteLine(stringresult) ;
            
        }
    }
}
