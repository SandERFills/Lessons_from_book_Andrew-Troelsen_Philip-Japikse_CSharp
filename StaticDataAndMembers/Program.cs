using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount savingAccount = new SavingAccount(50);
            Console.WriteLine(SavingAccount.GetRait());
            SavingAccount.SetRait(0.008);
            Console.WriteLine(SavingAccount.GetRait());
            SavingAccount savingAccount1 = new SavingAccount(200);
            Console.WriteLine(SavingAccount.GetRait());
            
            Console.ReadLine();
        }
    }
}
