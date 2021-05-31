using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string StringLine = "Hello world this is my releasation of string splitter!";
            
            string oneWord=String.Empty;
            for (int i = 0; i < StringLine.Length; i++)
            {
              
                if (!Char.IsWhiteSpace(StringLine[i]))
                {
                    oneWord =String.Concat(oneWord, StringLine[i]);
                }
                else if (Char.IsWhiteSpace(StringLine[i]))
                {
                    Console.WriteLine(oneWord);
                    oneWord = String.Empty;
                }
                
            }
            Console.WriteLine(oneWord);
            Console.ReadLine();
        }
    }
}
