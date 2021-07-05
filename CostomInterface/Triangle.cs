using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomInterface
{
    class Triangle : Shape, IPointy
    {
        public byte Points { get { return 3; } }

        public override void Draw()
        {
            Console.WriteLine("Draw triangle {0}",PetName);
        }
        public Triangle(string name) : base(name)
        {

        }

    }
}
