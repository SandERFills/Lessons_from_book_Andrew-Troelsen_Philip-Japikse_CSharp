using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlessons
{
    class Garage
    {
        public Garage()
        {
            NumbersOfCar = 1;
            MyCar = new AutoProp();
        }
        public Garage(int numOfCar,AutoProp autoProp)
        {
            NumbersOfCar = 1;
            MyCar = autoProp;
        }
        public int NumbersOfCar { get; set; }
        public AutoProp MyCar { get; set; }
    }
}
