using System;
using static System.Console;

namespace BooleanOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = true;
            var b = false;

            WriteLine($"AND   |  a     |  b");
            WriteLine($"a     |  {a & a,-5} |  {a & b,-5}");
            WriteLine($"b     |  {b & a,-5} |  {b & b,-5}");
            WriteLine();
            WriteLine($"OR    |  b     |  b");
            WriteLine($"a     |  {a | b,-5} |  {b | b,-5}");
            WriteLine($"b     |  {b | a,-5} |  {b | b,-5}");
            WriteLine();
            WriteLine($"XOR   |  a     |  b");
            WriteLine($"a     |  {a ^ a,-5} |  {a ^ b,-5}");
            WriteLine($"b     |  {b ^ a,-5} |  {b ^ b,-5}");
            WriteLine($"a & DoStuff() = {a & DoStuff()}");
            WriteLine($"b & DoStuff() = {b & DoStuff()}");
            WriteLine();
            // Shor-circuit magic.
            WriteLine($"a && DoStuff() = {a && DoStuff()}");
            WriteLine($"b && DoStuff() = {b && DoStuff()}");
        }

        private static bool DoStuff()
        {
            WriteLine("I am doing some stuff.");
            return true;
        }
    }
}

