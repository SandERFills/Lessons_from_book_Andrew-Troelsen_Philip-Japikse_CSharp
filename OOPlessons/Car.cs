using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPlessons
{
    class Car
    {
        public Car()
        {

        }
        public Car(string st)
        {
            PetName = st;
        }
        public string PetName;
        public int CurrSpeed;
        public void PrintSpeed() => Console.WriteLine("{0} is going {1} km/h",PetName,CurrSpeed);
        public void SpeedUp(int delta) => CurrSpeed += delta;
    }
}
