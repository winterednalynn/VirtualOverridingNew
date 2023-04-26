using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverridingNew
{
    public class RetirementAccount : SavingsAccount
    {
        public new bool WithDraw(double amount)
        {
            if (amount > 0)
            {
                
            }
            return true;
        }
        public override string ToString()
        {
            return $"Unable to withdraw from Retirement Account"; 
        }
    }
}
