using System;
using System.Collections;
using System.IO;

namespace CustomExceptoin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Simple Exception Lesson *********");
            Car car = new Car("Ziggy", 20);
            car.CrankyTunes(true);
            try
            {

                for (int i = 0; i < 10; i++)
                    car.Accselerait(10);
            }
            catch (сarlsDeadException e) when (e.ErrorTimeStamp.DayOfWeek!=DayOfWeek.Friday)
            {
                // Console.WriteLine("** Exception\n***");
                // Console.WriteLine($"Method : {e.TargetSite}");//Имя члена
                // Console.WriteLine("Class define member:{0}",e.TargetSite.DeclaringType);//Класс определяющий член
                // Console.WriteLine("Member type: {0}",e.TargetSite.MemberType);
                // Console.WriteLine($"Message : {e.Message}");
                // Console.WriteLine("Stack : {0}",e.StackTrace);
                // Console.WriteLine($"Source : {e.Source}");
                // Console.WriteLine($"Help Link: {e.HelpLink}");
                // Console.WriteLine("Addisional information :");
                // Console.WriteLine("-> Costom Data ");
                // foreach (DictionaryEntry dateInExcaption in e.Data)
                // {
                //     Console.WriteLine($"-> {dateInExcaption.Key} - {dateInExcaption.Value}");
                // }
                Console.WriteLine("Catching car is dead");
                Console.WriteLine(e.Message);
                //Console.WriteLine(e.ErrorTimeStamp);
                //Console.WriteLine(e.CauseOfError);
                try
                {
                    FileStream fs = File.Open(@"C:\Users\salag\source\repos\OOPlessons\Lessons_from_book_Andrew-Troelsen_Philip-Japikse_CSharp\CustomException\carisdead.txt", FileMode.Open);
                }
                
                catch (Exception e2)
                {
                    //Исключение кото
                    throw new сarlsDeadException(e.Message,e2);
                }
                
                
            }
            catch(ArgumentOutOfRangeException argOut) { }
            catch(Exception e) { }
            finally
            {
                //Этот блок выполнится независимо от того
                //возникло исключение или нет
                car.CrankyTunes(false);
            }
            Console.ReadLine();
        }
    }
}
