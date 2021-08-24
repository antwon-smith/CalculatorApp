﻿using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");
            string firstNumberInput = Console.ReadLine();

            try
            {
                int firstNumber = int.Parse(firstNumberInput);
            }
            
            catch (FormatException)
            {
                Console.WriteLine($"The input entered, \"{firstNumberInput}\", is not a valid number.  The application will now close.");
                Environment.Exit(-1);
            }

            Console.WriteLine("Enter your second number");
            string secondNumberInput = Console.ReadLine();

            try
            {
                int secondNumber = int.Parse(secondNumberInput);
            }

            catch (FormatException)
            {
                Console.WriteLine($"The input entered, \"{secondNumberInput}\", is not a valid number.  The application will now close.");
                Environment.Exit(-1);
            }

            Console.WriteLine("Choose an operation.\nTo add, type 'A'\nTo subtract, type 'S'\nTo multiply, type 'M'\nTo divide, type 'D'");
            string operation = Console.ReadLine();

            if (operation == "A" || operation == "a")
            {
                int result = (Convert.ToInt32(firstNumberInput) + Convert.ToInt32(secondNumberInput));
                Console.WriteLine($"You chose to add the numbers.\nResult: {result}");
            }

            else if (operation == "S" || operation == "s")
            {
                int result = (Convert.ToInt32(firstNumberInput) - Convert.ToInt32(secondNumberInput));
                Console.WriteLine($"You chose to subtract the numbers.\nResult: {result}");
            }

            else if (operation == "M" || operation == "m")
            {
                int result = (Convert.ToInt32(firstNumberInput) * Convert.ToInt32(secondNumberInput));
                Console.WriteLine($"You chose to multiply the numbers.\nResult: {result}");
            }

            else if (operation == "D" || operation == "d")
            {
                double result = (Convert.ToDouble(firstNumberInput) / Convert.ToDouble(secondNumberInput));
                // int remainder = (Convert.ToInt32(firstNumberInput) % Convert.ToInt32(secondNumberInput));
                Console.WriteLine($"You chose to divide the two numbers.\nResult: {result}");
            }

            else
            {
                Console.WriteLine("You did not choose a valid option. The program will now close.");
                Environment.Exit(-1);
            }
        }
    }
}