using System;

namespace InterFaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            Octagone oct = new Octagone();
            //Direct conversion with interface variable
            IDrawToPrinter drawToPrinter = (IDrawToPrinter)oct;
            drawToPrinter.Draw();
            //Short version without interface variable
            ((IDrawToForm)oct).Draw();
            //With "IS" and assigning Interface variable
            if (oct is IDrawToMemory dtm)
            {
                dtm.Draw();
            }
            Console.ReadLine();
        }
    }
}
