using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Hexagon : Shape
    {
        public Hexagon(string name) : base(name)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("Inside Hexagon :{0}",PetName);
        }
    }
}
