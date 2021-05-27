using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsLesson
{
    class Program
    {
        enum ProsentStoke : byte
        {
            One,
            Two,
            Half=6/2
               
        }
        enum EnTypeCurrer  :short
        {
            Maneger=100,
            Grint=1,
            Diliver=9
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ProsentStoke enTypeCurrer = ProsentStoke.Half;
            //AskForBonus(enTypeCurrer);
            Console.WriteLine("Получаем тип перечисления: {0}",Enum.GetUnderlyingType(enTypeCurrer.GetType()));
            Console.WriteLine("Получем тип другим способом {0}",Enum.GetUnderlyingType(typeof(EnTypeCurrer)));
            Console.WriteLine("Получаем строковое значение переменной enum: "+enTypeCurrer.ToString());
            Console.WriteLine("Get digit value of "+enTypeCurrer.ToString()+"="+(double)enTypeCurrer);
            EnTypeCurrer enTypeCurrer1 = EnTypeCurrer.Grint;
            DayOfWeek dayOfWeek = DayOfWeek.Monday;
            ConsoleColor consoleColor = ConsoleColor.White;
            EnumTypes(enTypeCurrer1);
            EnumTypes(dayOfWeek);
            EnumTypes(consoleColor);
            Console.ReadLine();

        }
        static void EnumTypes(System.Enum e)
        {
            Console.WriteLine("=> Information about{0}", e.GetType().Name);
            Console.WriteLine("Underlying storage informaion: {0}", Enum.GetUnderlyingType(e.GetType()));
            //ПОлучаем все пары имя-значение
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} values",enumData.Length);
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Имя {0} = значение {0:D}",enumData.GetValue(i));
            }

        }

        private static void AskForBonus(EnTypeCurrer e)
        {
            switch (e)
            {
                case EnTypeCurrer.Maneger:
                    Console.WriteLine("Wow.little");
                    break;
                case EnTypeCurrer.Grint:
                    Console.WriteLine("Heh.ne");
                    break;
                case EnTypeCurrer.Diliver:
                    Console.WriteLine("Where the pizza?");
                    break;
                default:
                    break;
            }
        }
    }
}
