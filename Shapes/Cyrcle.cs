﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Cyrcle:Shape
    {
        public Cyrcle(){}
        public Cyrcle(string name) : base(name)
        {

        }
        public override void Draw(){
            Console.WriteLine("Drawing {0} the Cyrcle",PetName);
        }
    }
}