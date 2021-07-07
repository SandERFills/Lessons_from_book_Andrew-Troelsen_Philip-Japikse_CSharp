using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomInterface
{
    //класс определяет количество вершин
    interface IPointy
    {
        //public byte MyProperty { get; set; }
        //public byte MyPropertySetter {  set; }
        //public byte MyPropertyGetter { get;}
        //Неявно открытый и абстрактный метод
        byte Points { get; }
        //byte GetNumperPoint();
    }

}
