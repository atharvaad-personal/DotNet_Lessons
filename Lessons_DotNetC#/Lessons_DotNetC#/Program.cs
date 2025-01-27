﻿using Lessons_DotNetC_;

public class Program
{
    static void Main(string[] args)
    {
        #region Abstract Class
        //Implementing List for having foreach loop
        List<Shape> shapes =
        [
            new Circle(),
                new Rectangle(),
            ];

        foreach (Shape s in shapes)
        {
            s.Draw();
        }
        Dog dog = new();
        dog.MakeSound();
        #endregion

        #region Encapsulation
        BankAccount account = new BankAccount("123456789", 5000);
        account.Deposit(3000);
        account.Withdraw(2000);
        account.DispalayAmountDetails();
        #endregion
    }
}

//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
