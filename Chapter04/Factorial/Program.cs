using System;
using static System.Console;

namespace Factorial
{
    class Program
    {
        /// <summary>
        /// Pass a 32-bit integer to get its factorial. Recursive implementation.
        /// </summary>
        /// <param name="number">32-bit integer number.</param>
        /// <returns>Returns 32-bit integer.</returns>
        static int Factorial(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        /// <summary>
        /// Runs Factorial() function with basic input validation.
        /// </summary>
        static void RunFactorial()
        {
            bool isNumber;
            do
            {
                Write("Enter a number: ");
                isNumber = int.TryParse(ReadLine(), out var number);

                WriteLine(isNumber ? $"{number:N0}! = {Factorial(number):N0}" : "You did not enter a valid number!");
            } while (!isNumber);
        }
        
        static void Main(string[] args)
        {
            RunFactorial();
        }
    }
}