using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCsharpLesson1
{
    public class SportCar : Car
    {
        public string GetPetName()
        {
            PetName = "Nani";
            return PetName;
        }
    }
}