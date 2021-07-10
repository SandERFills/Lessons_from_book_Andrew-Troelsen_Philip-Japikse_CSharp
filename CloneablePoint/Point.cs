using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        PointDicription pointDicription = new PointDicription();//создаём внутренний экземпляр другого класса
        public Point(int X,int Y,string PetName)//перегружаем конструктор
        {
            this.X = X; 
            this.Y = Y;
            pointDicription.PetName = PetName;
        }
        public Point (int X,int Y){this.X = X;this.Y = Y;}
        public Point() { }
        //переопределение метода,который выводит строку текущего экземпляра
        public override string ToString() => $"X={X},Y={Y} \t {pointDicription.PetName}\t{pointDicription.PointID}";
        //Возвращает копию текущего обьекта
        public object Clone() {
            
            Point newPoint= (Point)this.MemberwiseClone()/*колонируем все поля Point в новый экземпляр*/;
            PointDicription newPointDicription = new PointDicription();//Создаем новый экземпляр PointDicription
            newPointDicription.PetName = this.pointDicription.PetName;//Присваиваем новому экземпляру старое имя,при это ID будет новое
            newPoint.pointDicription = newPointDicription;//присваиваем новый экземпляр новой переменной
            return newPoint;
        }

    }
}
