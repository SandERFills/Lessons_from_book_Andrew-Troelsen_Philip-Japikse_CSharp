using System;

namespace FinalizableDisposableClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyResourseWrapper rw = new MyResourseWrapper();
            //rw.Dispose();
            MyResourseWrapper rw2 = new MyResourseWrapper();
            
        }
    }
}
