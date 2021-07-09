using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomEnumeratorWithYield 
{
    class Garage : IEnumerable//mark class garage as enumerable
    {
        private Car[] garageCar = new Car[4];
        public Garage()
        {
            garageCar[0] = new Car("Sosy", 12);
            garageCar[1] = new Car("Sym", 23);
            garageCar[2] = new Car("Morga", 42);
            garageCar[3] = new Car("Bryag", 18);
        }

        public IEnumerator GetEnumerator()//Эта функция возвращает экземпляр перечесляемого типа
        {
            // Это исключение сгенерируется немедленно,
            //throw new Exception("This will get called");
            return actuallmplementation();
            // Закрытая функция.
            IEnumerator actuallmplementation()
            {
                foreach (Car c in garageCar)
                {
                    yield return c;
                }
            }

        }
        public IEnumerable GetTheCars(bool returnReversed)
        {
            // Выполнить проверку на предмет ошибок,
            return actuallmplementation();
            IEnumerable actuallmplementation()
            {
                // Возвратить элементы в обратном порядке,
                if (returnReversed)
                {
                    for (int i = garageCar.Length; i != 0; i--)
                    {
                        yield return garageCar[i - 1];
                    }
                }
                else
                {
                    // Возвратить элементы в том порядке, в каком они размещены в массиве,
                    foreach (Car с in garageCar)
                    {
                        yield return с;
                    }
                }
            }
        }

        }
}
