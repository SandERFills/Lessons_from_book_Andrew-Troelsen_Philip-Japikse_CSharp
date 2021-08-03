using System;

namespace LambdaExpressionMultipleParams
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMath simpleMath = new SimpleMath();
            simpleMath.SetMathHandler((msg, result) => { Console.WriteLine("Message:{0} ,Result:{1} ", msg, result); });
            simpleMath.Add(10, 10);
            Console.ReadLine();
        }
        
    }
}
