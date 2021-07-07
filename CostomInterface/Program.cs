using System;

namespace CostomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Hexagon hexagon = new Hexagon("Stive");
            Console.WriteLine("Points = {0}",hexagon.Points);
            ///<summary>
            ///Try to define type IPOINT to Shape
            /// </summary> 
            //Cyrcle triangle = new Cyrcle("Mark");
            //IPointy pointy = null;
            //try
            //{
            //    pointy = (IPointy)triangle;
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            ///<summary>
            ///Using operator "AS" for type conversion
            /// </summary>
            //Cyrcle triangle = new Cyrcle("Mark");
            //IPointy pointy = triangle as IPointy;
            //if (pointy!=null)
            //{
            //    Console.WriteLine("Triangle point = {0}",pointy.Points);
            //}
            //else
            //{
            //    Console.WriteLine("Point = 0 ");
            //}
            ///<summary>
            ///Using operator "IS" for type conversion
            /// </summary>
            Shape[] shapes = { new Hexagon("Larry"), new Cyrcle("Jerry"), new Triangle("Elsford") };
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("-> Pet name {0}",shapes[i].PetName);
                
                    if (shapes[i] is IPointy ip)
                    {
                        Console.WriteLine("Point ={0}",ip.Points);
                    }
                    else
                    {
                        Console.WriteLine("No point");
                    }
                
                
            }
            IPointy firstPointy = FindFistPointyShape(shapes);
            Console.WriteLine("The item has {0} points", firstPointy.Points);
            Console.ReadLine();
            
        }
        static IPointy FindFistPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy ip)
                {
                    return ip;
                }
            }
            return null;
        }
    }
}
