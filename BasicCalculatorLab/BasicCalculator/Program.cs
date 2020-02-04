using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** IF STATEMENT***");
            int temperature;
            int humidity;
            string input;
            
            Console.WriteLine("enter the curent temperature in fahrenheit");
            
            input = Console.ReadLine();
            temperature = int.Parse(input);
            Console.WriteLine("enter the relative humidity");
            input = Console.ReadLine();
            humidity = int.Parse(input);
           
            
            bool isInt = int.TryParse(input, out temperature);
            if (isInt)// only do the calculation if the data entered is an integer;
            {
             int heatindex = 5 * (temperature + 61 + (temperature - 68) * 12/10 + (humidity * 94/100));
                humidity = 30;
                Console.WriteLine("heatindex" +heatindex);
            }
          
          
/*          Console.WriteLine("*** BASIC CALCULATOR ***");

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
