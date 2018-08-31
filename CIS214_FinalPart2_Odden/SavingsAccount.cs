using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS214_FinalPart2_Odden
{
    class SavingsAccount : Account
    {
        private decimal interestRate; // percentage for interest rate

        // SavingsAccount constructor
        public SavingsAccount(decimal bal, decimal interest)
            : base(bal)
        {
            if (interest > 0 && interest < 1)
                interestRate = interest;
            else
                throw new ArgumentOutOfRangeException(
                       "Interest", interest, "Interest Rate must be > 0 and < 1");
        }

        // method to return amount of interest earned on account
        public decimal CalculateInterest()
        {
            return interestRate * Balance;
        } // end method CalculateInterest

        // public property InterestRate
        public decimal InterestRate
        {
            get
            {
                return interestRate;
            } // end get
        } // end property InterestRate  
    }
}
