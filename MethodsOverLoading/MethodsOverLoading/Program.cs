using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOverLoading
{
    class Program
    {
        static int Add(int a, int b) {
            
            return a + b; 
        }
        static double Add(double a, double b)
        {

            return a + b;
        }
        static long Add(long a, long b)
        {

            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(100_1111_111,111_222_333_444));
            Console.ReadLine();
        }
    }
}
