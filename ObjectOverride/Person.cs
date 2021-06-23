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
    }
}

