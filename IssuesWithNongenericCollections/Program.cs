using System;
using System.Collections;

namespace IssuesWithNongenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //SimpleBoxUnboxOperation();
            WorkWithArrayList();
            PersonCollection collPer=new PersonCollection();
            collPer.AddPerson(new Person(firstname:"Homer",secondname:"Simpsom",age:40));
            collPer.AddPerson(new Person("Marge", "Simpson", 38)); 
            collPer.AddPerson(new Person("Lisa", "Simpson", 9)); 
            collPer.AddPerson(new Person("Bart", "Simpson", 7)); 
            collPer.AddPerson(new Person("Maggie", "Simpson", 2) ); 
            foreach(Person pers in collPer){
               Console.WriteLine(pers.ToString()); 
            }
        UseGenericList();

            Console.WriteLine();
        }
        static void SimpleBoxUnboxOperation()
        {
            //Создаём значимую переменную
            int myVal = 233;
            //Упаковываем переменную в ссылочный тип
            //Упаковка - означает размещение в управляемой куче 
            object myBoxVal = myVal;
            //Расковка означает приведение к предыдущему типу
            long unboxedInt = (long)myBoxVal;//Здесь происходит ошибка распаковки из-за несовпадения типов
        }
        static void WorkWithArrayList()
        {
            //Типы значений автоматически упаковываются,
            //когда передаются члену,принимающему object
            ArrayList intarray = new ArrayList();
            intarray.Add(19);
            intarray.Add(20);
            intarray.Add(14);
            //Распаковка происходит,когда объект преобразуется 
            //обратно в данные,расположенные в стеке
            int iInt =(int) intarray[0];
            //Теперь значение вновь упаковывается , т.к.
            //метод WriteLine() требует типа object
            Console.WriteLine("Value :{0}",iInt);
        }
        static void ArrayListOfRandomObjects(){
            ArrayList allRanObj=new ArrayList();
            allRanObj.Add(true);
            allRanObj.Add(new OperatingSystem(PlatformID.MacOSX,new Version(10,0)));
            allRanObj.Add(66);
            allRanObj.Add(3.14);
        }
        static void UseGenericList(){
            Console.WriteLine("**** Fun with Generics ****\n");
            //этот объект List<> объект может хранить только объекты Person
            List<Person> morePeople =new List<People>();
            morePeople.Add(new Person("Frank","Black",50));
            Console.WriteLine(morePeople[0]);

            //Этот объект List<> может хранить только целые числа
            List<int> moreInts =new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum =moreInts[0]+moreInts[1];

        }
    }
}
