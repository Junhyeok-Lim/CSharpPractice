// See https://aka.ms/new-console-template for more information
using System;
using CSharpPractice.Classes;
using CSharpPractice.Interfaces;

namespace CSharpPractice
{
    class Program
    {
        static double numberTwo = 12.34;
        static void Main(string[] args)
        {
            /*double[] numbers = new double[] { 1, 2, 3, 42, 42154 };
            var result = SimpleMath.Add(numbers);
            Console.WriteLine(result);*/

            //BankAccount bankAccount = new BankAccount(1000);
            ChildBankAccount bankAccount= new ChildBankAccount();
            bankAccount.AddToBalance(100);

            SimpleMath simpleMath = new SimpleMath();

            Console.WriteLine(Information(bankAccount));
            //Console.WriteLine(bankAccount.Balance);
            Console.ReadLine();

            /*ChildBankAccount childBankAccount= new ChildBankAccount();
            childBankAccount.AddToBalance(10);
            Console.WriteLine(childBankAccount.Balance);
            Console.ReadLine();*/
        }

        private static string Information(IInformation information)
        {
            return information.GetInformation();
        }
    }
    class SimpleMath : IInformation
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Add(double[] numbers) //메소드 오버로딩(같은 이름을 갖고 다른 기능을 하는 함수)
        {
            double result = 0;
            foreach(double d in numbers)
            {
                result += d;
            }
            return result;
        }

        public string GetInformation()
        {
            return "Class that solves simple math.";
        }
    }

}

