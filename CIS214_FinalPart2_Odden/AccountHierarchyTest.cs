using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS214_FinalPart2_Odden
{
    class AccountHierarchyTest
    {
        public static void Main(string[] args)
        {
            // account object
            Account ac = new Account(1000M);
            // savings account object
            SavingsAccount sa = new SavingsAccount(1000M, 0.06M);
            // checking account object
            CheckingAccount ca = new CheckingAccount(ac.Balance, 3M); 

            // print initial account objects    
            Console.WriteLine("{0}: {1:C}\n{2}: {3:C}\n",
               "Initial Savings Account balance", sa.Balance,
               "Initial Checking Account balance", ca.Balance);

            // Add interest to the SavingsAccount object by first invoking its CalculateInterest method
            // then pass the returned interest amount to the object’s Credit method.
            sa.Credit(sa.CalculateInterest());
            // print current interest rate, then new Savings Account balance
            Console.WriteLine("{0}: {1:0.00%}\n{2}: {3:C}\n",
                "Current interest rate for Savings Accounts", sa.InterestRate,
                "Savings Account balance after applying interest", sa.Balance);

            // ask user what task they'd like to perform
            while (true)
            {
                Console.Write("Would you like to make a deposit or a withdrawal today?\n" +
                    "Please enter (1) for deposit, (2) for withdrawal, or (-1) to exit.\n" +
                        "Task #");
                int num = 0;
                string task = Console.ReadLine();
                if (!int.TryParse(task, out num))
                {
                    Console.Write("Invalid input.\nPlease enter either (1) for deposit, or (2) for withdrawal.\n" + 
                        "Task #");
                    task = Console.ReadLine();
                }
                else if (num == 1) // deposit
                {
                    while (true)
                    {
                        Console.Write("\nIn which account would you like to make a deposit?\n" +
                        "Please enter (1) for Savings, or (2) for Checking.\n" +
                            "Account #");
                        int num2 = 0;
                        string task2 = Console.ReadLine();
                        if (!int.TryParse(task2, out num2))
                        {
                            Console.Write("Invalid input.\nPlease enter either (1) for Savings, or (2) for Checking.\n" +
                                "Account #");
                            task2 = Console.ReadLine();
                        }
                        else if (num2 == 1) // Savings Account
                        {
                            // testing savings account
                            Console.Write("\nHow much money would you like to deposit into your Savings Account? $");
                            decimal value = 0;
                            string deposit = Console.ReadLine();
                            while (!Decimal.TryParse(deposit, out value))
                            {
                                Console.WriteLine("Please enter a valid number.");
                                deposit = Console.ReadLine();
                            }
                            Console.WriteLine("Depositing {0:C} into Savings Account...", value);
                            sa.Credit(value);
                            Console.WriteLine("{0}: {1:C}\n",
                                "Savings Account balance after credit", sa.Balance);
                            break;
                            // ask user to perform another task or exit
                            //Console.WriteLine("Would you like to perform another task?\n" +
                            //    "Enter (1) to perform another task, or (-1) to exit");
                            //int input1;
                            //if (!int.TryParse(Console.ReadLine(), out input1))
                            //    Console.WriteLine("Invalid input. Try again.");
                            //else if (input1 == 1)
                            //{

                            //}
                            //else if (input1 == -1)
                            //{
                            //    break;
                            //}
                        }
                        else if (num2 == 2) // Checking Account
                        {
                            // testing checking account
                            Console.Write("\nHow much money would you like to deposit into your Checking Account? $");
                            decimal value = 0;
                            string deposit = Console.ReadLine();
                            while (!Decimal.TryParse(deposit, out value))
                            {
                                Console.WriteLine("Please enter a valid number.");
                                deposit = Console.ReadLine();
                            }
                            Console.WriteLine("Depositing {0:C} into Checking Account...", value);
                            Console.WriteLine("{0}: {1:C}\n",
                                "Checking Account balance after credit", ca.Credit(value));
                            break;
                        }
                    }
                }
                else if (num == 2) // withdrawal
                {
                    while (true)
                    {
                        Console.Write("\nFrom which account would you like to make a withdrawal?\n" +
                        "Please enter (1) for Savings, or (2) for Checking.\n" +
                            "Account #");
                        int num3 = 0;
                        string task3 = Console.ReadLine();
                        if (!int.TryParse(task3, out num3))
                        {
                            Console.Write("Invalid input.\nPlease enter either (1) for Savings, or (2) for Checking.\n" +
                                "Account #");
                            task3 = Console.ReadLine();
                        }
                        else if (num3 == 1) // Savings Account
                        {
                            // testing savings account
                            Console.Write("\nHow much money would you like to withdrawal from your Savings Account? $");
                            decimal value = 0;
                            string withdrawal = Console.ReadLine();
                            while (!Decimal.TryParse(withdrawal, out value))
                            {
                                Console.WriteLine("Please enter a valid number.");
                                withdrawal = Console.ReadLine();
                            }
                            Console.WriteLine("Removing {0:C} from Savings Account...", value);
                            sa.Debit(value);
                            Console.WriteLine("{0}: {1:C}\n",
                                "Savings Account balance after debit", sa.Balance);
                            break;
                        }
                        else if (num3 == 2) // Checking Account
                        {
                            // testing checking account
                            Console.Write("\nHow much money would you like to withdrawal from your Checking Account? $");
                            decimal value = 0;
                            string withdrawal = Console.ReadLine();
                            while (!Decimal.TryParse(withdrawal, out value))
                            {
                                Console.WriteLine("Please enter a valid number.");
                                withdrawal = Console.ReadLine();
                            }
                            Console.WriteLine("Removing {0:C} from Checking Account...", value);
                            ca.Debit(value);
                            Console.WriteLine("{0}: {1:C}\n",
                                "Checking Account balance after debit", ca.Balance);
                            break;
                        }
                    }
                }
                else if (num == -1) // exit program
                {
                    break;
                }
            } // end while
            // print results in accounts
        }
    }
}
