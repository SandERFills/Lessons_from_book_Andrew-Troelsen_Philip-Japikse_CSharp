using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingAccount
    {
        public double currentBalance;
        static public double rait = 0.004;
        public SavingAccount(double balance)
        {
            currentBalance += balance;
            rait = 0.004;
        }
        static public void SetRait(double new_rate)
        {
            rait = new_rate;
        }
        static public double GetRait()
        {
            return rait;
        }
    }
}
