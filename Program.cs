using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VirtualOverridingNew
{//EDNA LYNN LAXA 
//PROGRAMMING III
//APRIL 24, 2023 
//VIRTUAL, OVERRIDING, NEW 
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // RANDOM ACCOUNT # 
            int accountNum = random.Next(458525, 585846);

            BankAccount ba = new BankAccount("Kitana",accountNum); // NEW LIST FOR BANK ACCOUNT 
            CheckingAccount ca = new CheckingAccount("Kitana", accountNum, 50.00); // NEW LIST FOR CHECKING ACCOUNT 
            SavingsAccount sa = new SavingsAccount(); // NEW LIST FOR SAVING ACCOUNT // NEW LIST FOR BANK ACCOUNT 
            RetirementAccount ra = new RetirementAccount();  // NEW LIST FOR RETIREMENT ACCOUNT 

            ba.Deposit(500); // DEPOSITING 500 IN BANK ACCOUNT 
            ca.Deposit(500); // DEPOSITING 500 IN CHECKING ACCOUNT 
            sa.Deposit(500); //DEPOSITING 500 IN SAVINGS ACCOUNT 
            // USING . DEPOSIT TO PROMPT DEPOSIT METHOD 
       

            ba.Deposit(-50000); //DEPOSITING -50000 in BANK ACCOUNT 
            ca.Deposit(-50000); //DEPOSITING -50000 in CHECKING ACCOUNT 
            sa.Deposit(-50000); //DEPOSITING -50000 in SAVING ACCOUNT 



            ba.Withdraw(200); //WITHDRAWING 200 FROM BANK ACCOUNT 
            ca.Withdraw(200); //WITHDRAWING 200 FROM CHECKING ACCOUNT 
            ra.WithDraw(100); //WITHDRAWING 100 FROM RETIREMENT ACCOUNT
            Console.WriteLine(ra.ToString());

            ba.Withdraw(-200000); //WITHDRAWING -200000 FROM BANK ACCOUNT 
            ca.Withdraw(-200000); //WITHDRAWING -200000 FROM CHECKING ACCOUNT 
            

            //Create a savings, checking, and retirement account

            //Saving them all to a list of accounts

            //Deposit 500 in to all accounts(

            //Deposit - 50000 into all accounts

            //Withdraw 200 from all accounts

            //Withdraw - 200000
            // from all accounts

            //Try to overdraw each account

            //Display results(You can do this all from a single loop to make your life much easier. Organize your variables and method calls to do this efficiently)


            //VIRTUAL: 
            // used to modify a method, property, indexer,
            // or event declaration and allow for it to be overridden in a derived class.
            // For example, this method can be overridden by any class that inherits it

            //OVERRIDE 
            //The override modifier is required to extend or modify the abstract
            //or virtual implementation of an inherited method, property, indexer, or event.
            //An override method provides a new implementation of the method inherited from a base class.

            //provides a new version of a method inherited from a parent class inherited method must be:
            //abstract, virtual or already overriden Used w/ ToString(). Polymorphism

            //NEW: 
            //When used as a declaration modifier, the new keyword explicitly hides a member that is inherited from a base class.
            //When you hide an inherited member, the derived version of the member replaces the base class version.
        }
    }
}
