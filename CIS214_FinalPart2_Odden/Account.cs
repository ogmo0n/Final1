using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS214_FinalPart2_Odden
{
    class Account
    {
        private decimal balance; // private variable for account balance

        // public Account constructor
        public Account(decimal bal)
        {
            if (bal >= 0)
                balance = bal;
            else
                throw new ArgumentOutOfRangeException(
                        "Balance", bal, "Balance must be >= 0");
        } // end constructor

        // public method to add amount to current account
        public virtual bool Credit(decimal value)
        {
            balance = Balance + value;
            return true;
        } // end method Credit

        // public method to withdraw money from current account
        public virtual bool Debit(decimal value)
        {
            if (value >= 0)
                if (value <= balance)
                {
                    balance = Balance - value;
                    return true;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(
                        "Value", value, "Debit amount exceeded account balance");
                }
            else
            {
                throw new ArgumentOutOfRangeException(
                    "Value", value, "Debit amount exceeded account balance");
            }
        } // end method Debit

        // public property Balance
        public decimal Balance
        {
            get
            {
                return balance;
            } // end get
        } // end property Balance    
    }
}