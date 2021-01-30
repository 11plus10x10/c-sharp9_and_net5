using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 0;

            while (x < 10)
            {
                WriteLine(x);
                x++;
            } // while end

            var password = string.Empty;
            var attempts = 0;
            do
            {
                Write("Enter your password: ");
                password = ReadLine();
                attempts++;
            } while (password != "Pa$$w0rd" & attempts < 11);

            if (attempts < 10)
            {
                WriteLine("Correct!");
            }
            else
            {
                WriteLine("Too many failed attempts.");
            }

            for (int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }

            var names = new[] { "Adam", "Barry", "Charlie" };
            
            foreach (var name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}