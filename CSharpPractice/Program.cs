﻿// See https://aka.ms/new-console-template for more information
using System;
using CSharpPractice.Classes;

namespace CSharpPractice
{
    class Program
    {
        static double numberTwo = 12.34;
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.AddToBalance(100);
            Console.WriteLine(bankAccount.Balance);

            ChildBankAccount childBankAccount= new ChildBankAccount();
            childBankAccount.AddToBalance(10);
            Console.WriteLine(childBankAccount.Balance);
            Console.ReadLine();
        }
    }
    class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

    }

}

