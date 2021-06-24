using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace ObjectOverride
{
	public class Person : Object
	{
		public Person()
		{
			//
			// TODO: Add constructor logic here
			//
		}
        public int Age { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
		public Person(string name,string lastname,int age) {
			Age = age;
			Name = name;
			LastName = lastname;
		
		}
        public override string ToString()//Переопределение метода ToString класса Object для класса Person
        {
            
            return $"{Age} age,name: {Name},last name: {LastName}";	
        }
        public override bool Equals(object obj)//переопределение метода Equals класса Object для класса Person
        {
            if (obj is Person && obj !=null)
            {
                Person temp;
                temp = (Person)obj;
                if (temp.Age==this.Age &&
                    temp.LastName ==this.LastName &&
                    temp.Name == this.Name)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()//Переопределённый метод GetHashCode будет возвращать хеш-код на основе текущего состояния метод ToString
        {
            return this.ToString().GetHashCode();
        }
    }
}

