using System;
using System.Collections.Generic;
using static System.Console;

namespace MyMathLib
{
    public class PrimeNumber
    {
        /// <summary>
        /// Takes in an 32-bit integer number and returns its prime factors. Prime factors
        /// are prime numbers greater than one that cannot be made by multiplying other
        /// whole numbers. e.g. 50 = 5 x 5 x 2.
        /// </summary>
        /// <param name="number">32-bit integer.</param>
        /// <returns>Returns a string. e.g. Prime factors of 30 are: 5 x 3 x 2</returns>
        public List<int> GetPrimeFactors(int num)
        {
            var result = new List<int>();

            // Take out the 2s.
            while (num % 2 == 0)
            {
                result.Add(2);
                num /= 2;
            }

            // Take out other primes.
            var factor = 3;
            while (factor * factor <= num)
            {
                if (num % factor == 0)
                {
                    // This is a factor.
                    result.Add(factor);
                    num /= factor;
                }
                else
                {
                    // Go to the next odd number.
                    factor += 2;
                }
            }

            // If num is not 1, then whatever is left is prime.
            if (num > 1) result.Add(num);

            return result;
        }
    }
}
