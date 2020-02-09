using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter the temperature in fahrenheit");
            int temperature;
            temperature = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the wind speed");
            int windspeed;
            windspeed = int.Parse(Console.ReadLine());
            double windchill = 35.74 + 0.6215 * temperature - 35.75 * windspeed + 0.16 + 0.4275 * temperature * windspeed;
            Console.WriteLine("the wind chill is" + windchill);
        }

  /*          // int.Parse will take a string data type and convert it to an int data type
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;

            Console.WriteLine("The answer is " + sum);
  */
        
    }
}
