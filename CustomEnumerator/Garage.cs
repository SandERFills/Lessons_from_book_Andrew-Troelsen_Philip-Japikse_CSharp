using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumerator
{
    class Garage
    {
        private Car[] garageCar = new Car[4];
        public Garage()
        {
            garageCar[0] = new Car("Sosy", 12);
            garageCar[1] = new Car("Sym", 23);
            garageCar[2] = new Car("Morga", 42);
            garageCar[3] = new Car("Bryag", 18);

        }
    }
}
