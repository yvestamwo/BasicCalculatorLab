using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter the first number");

            // int.Parse will take a string data type and convert it to an int data type
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            Console.WriteLine("The answer is " + sum);
        }
    }
}
