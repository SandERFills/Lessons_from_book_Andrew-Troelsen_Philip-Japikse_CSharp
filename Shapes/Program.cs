using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using AnotherNameSpaces.ThreeDCyrcle;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Polymorphism *****\n");
            Shape[] myShapes ={new Hexagon(),new Cyrcle(),new Hexagon("MIK"),new Cyrcle("Benedickt"),new Hexagon("Linda")};
            //Цикл проходит по всем элементам и взаимодействует с полиморфным интерфейсом
            foreach(Shape s in myShapes){
                s.Draw();
            }
            ThreeDCyrcle the =new ThreeDCyrcle();
            Console.ReadLine();
        }
    }
}
