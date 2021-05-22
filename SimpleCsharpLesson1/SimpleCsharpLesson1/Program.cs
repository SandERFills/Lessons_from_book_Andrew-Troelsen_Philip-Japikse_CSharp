using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCsharpLesson1
{
    class Program
    {
        static void ShowEnvironmentDetails() {
            foreach (string driver in Environment.GetLogicalDrives())
                  Console.WriteLine("Drive: {0}", driver);
            Console.WriteLine("OS: {0}",Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}",Environment.ProcessorCount);
            Console.WriteLine(".NEW Version: {0}",Environment.Version);
           }
        static int Main(string[] args)
        {
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("********************************");
            Console.WriteLine("*****WellCome to my Asowme App***");
            Console.WriteLine("**********************************");
            // Обработать любые входные аргументы,
            string[] theArgs = Environment.GetCommandLineArgs();
            foreach (string arg in theArgs)
                Console.WriteLine("Arg: {0}", arg);
            ShowEnvironmentDetails();
            Console.ReadLine();
            return -1;
        }
    }
}
