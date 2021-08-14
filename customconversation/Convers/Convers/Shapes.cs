using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convers
{
   public struct Rectangle
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public Rectangle(int hg,int wh) : this()
        {
            Weight = wh;
            Height = hg;
        }
       public void Draw() 
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Weight; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public override string ToString() => $"[{Weight};{Height}]";
        public static implicit operator Rectangle(Square s)
        {
            Rectangle r = new Rectangle { Height = s.Lenght * 2, Weight = s.Lenght };
            return r;
        }
    }
    public struct Square
    {
        public int Lenght { get; set; }
        public Square(int len):this()
        {
            Lenght = len;
        }
        public void Draw() { 
        for (int i = 0; i<Lenght; i++)
			{
                for (int j = 0; j < Lenght; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
			}
        }
        public override string ToString() => $"[{Lenght}]";
        public static explicit operator Square(Rectangle r) {
            Square s = new() { Lenght = r.Height };
            return s;
        }
        public static explicit operator int(Square s)=>s.Lenght;//Процедура явного преобразования в тип INT 
        
        
    }
}
