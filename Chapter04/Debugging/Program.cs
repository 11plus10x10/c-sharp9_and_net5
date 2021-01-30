using System;
using static System.Console;

namespace Debugging
{
    class Program
    {
        static double Add(double a, double b)
        {
            // Deliberate bug!
            return a * b;
        }
        
        static void Main(string[] args)
        {
            var a = 4.5;
            var b = 2.5;
            double answer = Add(a, b);
            WriteLine($"{a} + {b} = {answer}");
            // Waiting for enter.
            ReadLine();
        }
    }
}
