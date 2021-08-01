using System;

namespace SimpleDelegate
{
    public delegate int BinaryOp(int a, int b);
    class SimpleMath
    {
        
        public static int Add(int a, int b) => a + b;
        public int Substruct(int a, int b) => a - b;
    }
    class Program
    {

        static void Main(string[] args)
        {
            BinaryOp binaryOpAdd = new BinaryOp(SimpleMath.Add);
            SimpleMath simpleMath = new SimpleMath();
            BinaryOp binaryOpSubstruct = new BinaryOp(simpleMath.Substruct);
            Console.WriteLine($"{binaryOpAdd(2,4)}");
            Console.WriteLine($"{binaryOpSubstruct(13,22)}");
            DisplayDelegatInfo(binaryOpAdd);
            DisplayDelegatInfo(binaryOpSubstruct);
        }
        static void DisplayDelegatInfo(Delegate delObje)
        {
            foreach (Delegate d in delObje.GetInvocationList())
            {
                Console.WriteLine("Target: {0}",d.Target);
                Console.WriteLine("Method: {0}",d.Method);
            }
        }
    }
}
