using System;


namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun With System.GC");
            //Выведем оценочное количество байтов ,выделенных в куче
            System.Console.WriteLine("По оценке байт в куче: {0}",GC.GetTotalMemory(false));
            //
            System.Console.WriteLine("Эта ОС имеет {0} поколений объектов",(GC.MaxGeneration+1));
            Car refToMyCar=new Car(100,"Zyppy");
            System.Console.WriteLine(refToMyCar.ToString());
            //вывести поколение объекта refToMyCar
            System.Console.WriteLine("Generation of refToMyCar is {0}",GC.GetGeneration(refToMyCar));
            Console.ReadLine();
            object[] tonsOfObject= new object[50000];
            for (int i = 0; i < 50000; i++)
            {
                tonsOfObject[i]=new object();
            }
            GC.Collect(0,GCCollectionMode.Forced);//Активировать сборку мусора немедленно по поколению ZERO
            GC.WaitForPendingFinalizers();
            System.Console.WriteLine("Generation of refToMyCar is {0}",GC.GetGeneration(refToMyCar));
            //
            if (tonsOfObject[9000]!=null)
            {
                System.Console.WriteLine("geration {0} is {1}",tonsOfObject[9000],GC.GetGeneration(tonsOfObject[9000]));
            }
            else
            {
                System.Console.WriteLine("{0} is no longer alive.",tonsOfObject[9000]);
            }
            System.Console.WriteLine("Gen 0 очищенно {0} раз",GC.CollectionCount(0));
            System.Console.WriteLine("Gen 1 очищенно {0} раз",GC.CollectionCount(1));
            System.Console.WriteLine("Gen 2 очищенно {0} раз",GC.CollectionCount(2));
        }
    }
}
