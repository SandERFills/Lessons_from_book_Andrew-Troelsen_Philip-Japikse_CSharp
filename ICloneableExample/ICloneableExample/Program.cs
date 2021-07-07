using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = "My new string";
            System.Data.SqlClient.SqlConnection sqlConnection = new System.Data.SqlClient.SqlConnection();
            OperatingSystem UnixSys = new OperatingSystem(PlatformID.Unix, new Version());
           
        }
        static void CloneMe(ICloneable cloneable)
        {

        }
    }
}
