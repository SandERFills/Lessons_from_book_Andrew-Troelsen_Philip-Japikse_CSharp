using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomEnumeratorWithYield 
{
    class Garage: IEnumerable //mark class garage as enumerable
    {
        private Car[] garageCar = new Car[4];
        public Garage()
        {
            garageCar[0] = new Car("Sosy", 12);
            garageCar[1] = new Car("Sym", 23);
            garageCar[2] = new Car("Morga", 42);
            garageCar[3] = new Car("Bryag", 18);
        }
        //IEnumerable информирует о том ,
        //что элементы обьекта могу быть перечисляемыми
        //IEnumerable является совместимым с типом IEnumerator
        public IEnumerator GetEnumerator(){
            //IEnumerator позваляет получать элементы контейнера
            foreach(Car c in garageCar){
                yield return c;//yield allows retur value and come back at this string do not interrupt program 
            }
        }
    }
}
