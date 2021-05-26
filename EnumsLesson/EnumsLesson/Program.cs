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
            Console.ReadLine();

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
