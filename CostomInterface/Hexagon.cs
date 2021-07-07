using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomInterface
{
    class Hexagon : Shape,IPointy,IDraw
    {
        public Hexagon(){}
        public Hexagon(string name) : base(name)
        {

        }
        public void Draw3D()
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Inside Hexagon :{0}",PetName);
        }
        public byte Points { get { return 6; } }
    }
}
