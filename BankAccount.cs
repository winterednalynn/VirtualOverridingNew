using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverridingNew
{
    public class BankAccount
    {
        //FIELDS , NAME ; BALANCE ; ACCOUNT NUMBER 
        string _name;
        double _balance = 5000;
        int _accountNumber;

        Random rand = new Random();

        //CONSTRUCTOR 
        public BankAccount(string name, int accountNumber)
        {
            Name = name;
            
            _accountNumber = accountNumber = rand.Next(458525, 585846); //ADDED RANDOM IN CONSTRUCTOR 
        }

        //PROPERTY 
        public string Name { get => _name; set => _name = value; }
        public double Balance {get => _balance;  }
        public int AccountNumber {get => _accountNumber;  }

        //VALUING POSITIVE AMOUNT 
        private bool PositiveAmount(double amount) // FOR POSITVE 
        {
            return amount > 0; 
        }
        //VALUING NEGATIVE AMOUNT 
        private bool NegativeAmount(double amount) // FOR NEGATIVE 
        {
            return amount < 0; 
        }
        //CREATING A BOOL METHOD FOR DEPOSIT 
        public virtual bool Deposit (double amount)
        {
            if (PositiveAmount(amount))
            {
                _balance += amount;
                
            }
            return true; 
            
        }
        //CREATING BOOL METHOD FOR WITHDRAW 
        public virtual bool Withdraw(double amount)
        {
            if(PositiveAmount(amount))
            {
                _balance -= amount;
                return true; 
 
            }
            else
            {
                return false; 
            }
         
        }
        public override string ToString()
        {
            return $" Name {_name} - Account Number {_accountNumber} - Balance {_balance}";

            //this.GetType() - Display Name - Account Number - Balance // When i place get type it prompts this VirtualOverridingNew.BankAccount 
        }
    }
}
////virtual bool Deposit ( double amount ) :
//Add Money(make sure to validate if amount is positive )
//Return true if the transaction goes through
//Return false if the amount is negative
