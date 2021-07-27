using System;

namespace SimpleDelegate
{
    //Объявление делегата ,который будет указывать на метод
    //типа INT и принимать параметры типа INT
    public delegate int BinaryOp(int x,int y);
//  Класс с методами,которые будут переданы в делегат
    public class SimpleMath
    {
        public  int Add(int a,int b)=>a+b;
        public  int Substruct(int a,int b)=>a-b;
    }
    
    class Program
    {
        static void DisplayDelegateInfo(Delegate delObj){
            foreach (Delegate d in delObj.GetInvocationList())
            {
                System.Console.WriteLine("Method Name: {0}",d.Method);//method name
                System.Console.WriteLine("Type Name: {0}",d.Target);//type name
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("*******  Simple Delegate Expample    *********");
            SimpleMath sm=new SimpleMath();
            BinaryOp b=new BinaryOp(sm.Add);//Создаётся объект делегата и ему передаётся только имя метода,который будет делегирован
            // b=new BinaryOp(SimpleMath.Substruct);
            DisplayDelegateInfo(b);
            System.Console.WriteLine("is {0}",b(10,10));
            Console.ReadLine();
        }
    }
    
}
