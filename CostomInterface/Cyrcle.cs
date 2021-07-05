using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomInterface
{
    class Cyrcle:Shape,IDraw
    {
        public Cyrcle(){}
        public Cyrcle(string name) : base(name)
        {

        }
        public void Draw3D()
        {

        }
        public override void Draw(){
            Console.WriteLine("Drawing {0} the Cyrcle",PetName);
        }
    }
}
