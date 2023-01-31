// See https://aka.ms/new-console-template for more information
using System;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
            numberOne = 23;
            Console.WriteLine(numberOne);
            var message = Console.ReadLine();
            Console.WriteLine($"Echo:{message}");
            Console.ReadLine();
        }
    }
}

