using System;
using System.Collections;

namespace IssuesWithNongenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //SimpleBoxUnboxOperation();
            WorkWithArrayList();
        }
        static void SimpleBoxUnboxOperation()
        {
            //Создаём значимую переменную
            int myVal = 233;
            //Упаковываем переменную в ссылочный тип
            //Упаковка - означает размещение в управляемой куче 
            object myBoxVal = myVal;
            //Расковка означает приведение к предыдущему типу
            long unboxedInt = (long)myBoxVal;//Сдесь происходит ошибка распаковки из-за несовпадения типов
        }
        static void WorkWithArrayList()
        {
            ArrayList intarray = new ArrayList();
            intarray.Add(19);
            intarray.Add(20);
            intarray.Add(14);
            int iInt =(int) intarray[0];
            Console.WriteLine("Value :{0}",iInt);
        }
        
    }
}
