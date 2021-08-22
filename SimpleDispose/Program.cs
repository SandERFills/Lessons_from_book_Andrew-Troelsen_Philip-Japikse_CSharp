using System;

namespace SimpleDispose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun With dispose!");
            MyResourseWrapper rw = new MyResourseWrapper();
            if (rw is IDisposable)
            {
                rw.Dispose();
            }
            else
            {
                Console.WriteLine("Dosent released IDisposable");
            }
            

        }
    }
}
