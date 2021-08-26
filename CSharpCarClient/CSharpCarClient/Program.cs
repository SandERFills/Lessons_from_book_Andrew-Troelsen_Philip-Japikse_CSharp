using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarLib;
namespace CSharpCarClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** C# Carlibrary Client App");
            SportCar sportCar = new SportCar("Viper",120,340);
            sportCar.TurboBoost();
            MiniVan miniVan = new MiniVan();
            miniVan.TurboBoost();
            Console.WriteLine("Нажмите любую кнопку для уничтожения");
            Console.ReadLine();
        }
    }
}
