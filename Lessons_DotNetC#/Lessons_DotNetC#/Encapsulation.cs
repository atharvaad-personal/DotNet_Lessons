using Lessons_DotNetC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_DotNetC_
{
    public class BankAccount
    {
        private string? accountnumber;
        private /*readonly*/ double balance;
        public string AccountNumber { get { return accountnumber; } set { accountnumber = value; } }
        public double Balance { get { return balance; } }

        public BankAccount(string accountnumber, double balance)
        {
            this.accountnumber = accountnumber;
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += balance;
                Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
                throw new Exception("Balance cannot be negative");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount}. Remaining Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }

        public void DispalayAmountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance: {Balance}");
        }
    }
}
