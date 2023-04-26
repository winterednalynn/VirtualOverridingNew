using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace VirtualOverridingNew
{
   public class SavingsAccount 
    {
        //FIELDS 
        double _interest= 100;
        double _amount;
   
        //VIRTUAL VOID FOR DEPOSIT 
        public virtual void Deposit(double amount)
        {
            _amount = amount;
            _interest = Interest; 


        }
        //PROPERTY 
        public double Interest { get => _interest;  }

   
        public override string ToString()
        {
            return $"An interest of {_interest} has been added to your Deposit of {_amount}. Your total for this deposit is: {_interest + _amount}"; 
        }
    }






}


    //Fields
        //interest(double )
        //Constructor
        //Using the base constructor and add the interest parameter
        //Property
        //interest
        //{ get; set; }
        //Method
        //override Deposit : If deposit is successful add interest to the account
        //override ToString: Add Interest to base.ToString();

