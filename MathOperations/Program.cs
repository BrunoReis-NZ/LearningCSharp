using System;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = GetNumberFromUser("Enter the first number: ");
            double num2 = GetNumberFromUser("Enter the second number: ");

            DisplayNumberOperations(num1, num2);

            Console.ReadKey();
        }

        /// <summary>
        /// This method prompts the user to enter a number and validates the input
        /// </summary>
        /// <param name="prompt"></param>The message to display to the user</param>
        /// <returns>The number entered by the user</returns>
        static double GetNumberFromUser(string prompt)
        {
            double number;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }
            return number;
        }

        /// <summary>
        /// This method displays the original numbers, rounded, floored, and ceiled versions of the numbers
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        static void DisplayNumberOperations(double num1, double num2)
        {
            double roundedNum1 = Math.Round(num1);
            double roundedNum2 = Math.Round(num2);

            double flooredNum1 = Math.Floor(num1);
            double flooredNum2 = Math.Floor(num2);

            double ceiledNum1 = Math.Ceiling(num1);
            double ceiledNum2 = Math.Ceiling(num2);

            Console.WriteLine($"\nThe numbers you entered are {num1} and {num2}");
            Console.WriteLine($"\nThe numbers rounded are {roundedNum1} and {roundedNum2}");
            Console.WriteLine($"The numbers floored are {flooredNum1} and {flooredNum2}");
            Console.WriteLine($"The numbers ceiled are {ceiledNum1} and {ceiledNum2}");

            Console.WriteLine("\n### Math Operations based on the numbers you entered ###");
            PerformMathOperations(num1, num2);
            Console.WriteLine("\n### Math Operations based on the rounded numbers ###");
            PerformMathOperations(roundedNum1, roundedNum2);
            Console.WriteLine("\n### Math Operations based on the floored numbers ###");
            PerformMathOperations(flooredNum1, flooredNum2);
            Console.WriteLine("\n### Math Operations based on the ceiled numbers ###");
            PerformMathOperations(ceiledNum1, ceiledNum2);
        }

        /// <summary>
        /// This method performs various math operations on two numbers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void PerformMathOperations(double x, double y)
        {
            Console.WriteLine($"\n\tSum: {x} + {y} = {x + y}");
            Console.WriteLine($"\tDifference: {x} - {y} = {x - y}");
            Console.WriteLine($"\tProduct: {x} * {y} = {x * y}");
            Console.WriteLine($"\tQuotient: {x} / {y} = {x / y}");
            Console.WriteLine($"\tRemainder: {x} % {y} = {x % y}");
            Console.WriteLine($"\n\tPower: {x} ^ {y} = {Math.Pow(x, y)}");
            Console.WriteLine($"\tSquare Root of {x} = {Math.Sqrt(x)}");
            Console.WriteLine($"\tSquare Root of {y} = {Math.Sqrt(y)}");
            Console.WriteLine($"\n\tRandom number between {x} and {y}: {GenerateRandomNumber(x, y)}");
        }

        /// <summary>
        /// This method generates a random number between two numbers
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returnns>A random number between x and y</returns>
        public static double GenerateRandomNumber(double x, double y)
        {
            int min = (int)Math.Min(x, y);
            int max = (int)Math.Max(x, y);

            Random random = new Random();
            return random.Next(min, max + 1);
        }
    }
}

/*
Problem: Math Operations
Topic: Math Methods

Write a C# program that takes a sentence from the user and performs the following operations:

Create a C# program that performs the following tasks:

1. Prompt User Input:
    - Ask the user to enter two numbers.
    - Ensure the input is valid, and handle any potential errors gracefully.

2. Perform Rounding Operations:
    - Round each number to the nearest integer.
    - Floor each number (round down to the nearest integer).
    - Ceiling each number (round up to the nearest integer).

4. Display the Results:
    - Display the original numbers.
    - Display the rounded, floored, and ceiled versions of the numbers.

Math Operations:

5. Create a method that performs the following operations on two numbers:
    - Sum
    - Difference
    - Product
    - Quotient
    - Remainder
    - Power (x raised to the power of y)
    - Square Root of each number
    - Generate a random number between the two numbers

6. Display Math Operations for Different Rounding Methods:
    - Display the results of the math operations for the original numbers.
    - Display the results of the math operations for the rounded numbers.
    - Display the results of the math operations for the floored numbers.
    - Display the results of the math operations for the ceiled numbers.

Example

Input:

    Enter the first number: 12.5
    Enter the second number: 7.8

Output:

    The numbers you entered are 12.5 and 7.8

    The numbers rounded are 12 and 8
    The numbers floored are 12 and 7
    The numbers ceiled are 13 and 8

    ### Math Operations based on the numbers you entered ###
        Sum: 12.5 + 7.8 = 20.3
        Difference: 12.5 - 7.8 = 4.7
        Product: 12.5 * 7.8 = 97.5
        Quotient: 12.5 / 7.8 = 1.6025641025641
        Remainder: 12.5 % 7.8 = 4.7

        Power: 12.5 ^ 7.8 = 1.01337228224868E+10
        Square Root of 12.5 = 3.53553390593274
        Square Root of 7.8 = 2.79105714739057

        Random number between 7.8 and 12.5: 9

*/

