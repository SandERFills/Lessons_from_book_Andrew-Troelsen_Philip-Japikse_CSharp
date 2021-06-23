using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Shapes
{
    class THreeDCyrcle:Cyrcle
	{
        public new void Draw()
        {
            Console.WriteLine("tHIS is 3d Circle");
        }
	}
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
           THreeDCyrcle hreeDCyrcle =new THreeDCyrcle();
            hreeDCyrcle.Draw();
            Console.ReadLine();
        }
    }
}
