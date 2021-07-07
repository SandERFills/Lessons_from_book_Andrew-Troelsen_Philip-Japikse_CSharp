using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostomInterface
{
  abstract  class Shape
    {
        public Shape(string name = "No_Name")
        {
            PetName = name;
        }
        public string PetName { get; set; }
        public abstract void Draw();
        
    }
}
