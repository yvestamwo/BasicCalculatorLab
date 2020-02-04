using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            int temp;
            int humidity;
            string input;
            Console.WriteLine("enter temperature");

            input = Console.ReadLine();
            temp = int.Parse(input);
            Console.WriteLine("enter humidity");
            input = Console.ReadLine();
            humidity = int.Parse(input);
            int dewpoint;
            dewpoint = temp - 9 * (100 - humidity) / 25;
            Console.WriteLine("dewpoint "+dewpoint);


/*
            Console.WriteLine("Enter the first number");

            // int.Parse will take a string data type and convert it to an int data type
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            Console.WriteLine("The answer is " + sum);
  */
        }
    }
}
