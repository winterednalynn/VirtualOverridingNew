using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverridingNew
{
    internal class CheckingAccount : BankAccount //CHECKING ACCOUNT INHERITED BANK ACCOUNT 
    {
        //FIELDS 
        double _overdraftFees;

        //CONSTRUCTOR 
        public CheckingAccount(string name,  int accountNumber, double overdraftFees) : base(name,  accountNumber)
        {
            OverdraftFees = overdraftFees; 
        }

        //PROPERTY 
        public double OverdraftFees { get => _overdraftFees; set => _overdraftFees = value; }

        //Method
        //override Withdraw(double amount) : If the withdraw fails, have it withdraw the overdraft fee from the _balance;
        //override ToString - Add fee to base.ToString()

        //CREATED WITHDRAW METHOD 
        public new void Withdraw(double amount)
        {
           if (Balance < 0)
            {
                OverdraftFees -= Balance;
            }
        }
        
        public override string ToString()
        {
            return $"Overdraft FEE {OverdraftFees}" + base.ToString();  
        }
    }
}
