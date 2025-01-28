using Lessons_DotNetC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_DotNetC_
{
    //we have assigned a primary constructor
    public class BankAccount(string accountnumber, double balance)
    {
        //private fields to restrict unauthorized access
        private double balance = balance;
        private string AccountNumber { get; set; } = accountnumber;
        private double Balance { get { return balance; } }

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

//How do you achieve Encapsulation in C#?
//-> 1) Access Modifiers: private, public, protected, etc.
//   2) Properties: ToString provides controlled access to private fields.
//   3) Methods: To define behavior and enforce rules.

//Why is Encapsulation important?
//-> It ensures data securtiy by preventing unauthorized access.
//-> It allows for cotrolled modification of data through methods
//-> It improves code maintainability and flexibility
//-> It promotes resueablity of code.

//Encapsulation - Buldling data and methods into a single unit and restricting access to the data