using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Car:IComparable
    {
        public Car()
        {

        }
        public Car(string st,int curspeed,int id)
        {
            CurrSpeed = curspeed;
            CarID = id;
            PetName = st;
        }
        public string PetName { get; set; }
        public int CurrSpeed { get; set; }
        public int CarID { get; set; }

        public int CompareTo(object obj)//Реализация метода интерфейса IComparable
        //Который передаётся в класс Array и нужен для выбора цели сортировки
        {
            Car temp = obj as Car;
            if (temp !=null)
            {
                return this.CarID.CompareTo(temp.CarID);
            }
            else
            {
                throw new ArgumentException("Parametr is not a Car");
            }
        }
        //special property for IComparer intance 
    public static IComparer SortByPetName{get{return (IComparer)new PetNameComparer();}}
        public void PrintSpeed() => Console.WriteLine("{0} is going {1} km/h",PetName,CurrSpeed);
        public void SpeedUp(int delta) => CurrSpeed += delta;
    }
}
