using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS214_FinalPart2_Odden
{
    class CheckingAccount : Account
    {
        // private variable representing the fee charged for a transaction
        private decimal transactionFee;

        // CheckingAccount constructor
        public CheckingAccount(decimal bal, decimal fee)
            : base(bal)
        {
            transactionFee = fee;
        }

        // Debit
        public new decimal Debit(decimal value)
        {
            value = value + transactionFee;
            if (base.Debit(value) == true)
            {
                // return Balance - transactionFee;
                return Balance;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    "Value", value, "Debit amount exceeded account balance");
            }
        } // end method Debit

        // Credit
        // public override bool Credit(decimal value)
        public new decimal Credit(decimal value)
        {
            //if (value < transactionFee)
            //{
            //    Console.WriteLine("Deposits must be greater than ");
            //}
            value = value - transactionFee;
            if (base.Credit(value) == true)
            {
                // return Balance - transactionFee;
                return Balance;
            }
            else
            {
                throw new ArgumentOutOfRangeException(
                    "Value", value, "Credit amount cannot be negative");
            }
        } // end method Credit

        // public property TransactionFee
        public decimal TransactionFee
        {
            get
            {
                return transactionFee;
            } // end get
        } // end property TransactionFee 
    }
}