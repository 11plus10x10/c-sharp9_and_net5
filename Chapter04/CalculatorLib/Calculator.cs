using System;

namespace Packt
{
    public class Calculator
    {
        /// <summary>
        /// Adds two double numbers 'a' and 'b'. There is a deliberate bug (* instead of +)
        /// </summary>
        /// <param name="a">Double value</param>
        /// <param name="b">Double value</param>
        /// <returns>Should return sum, but returns  multiplication deliberately</returns>
        public double Add(double a, double b)
        {
            return a * b;
        }
    }
}
