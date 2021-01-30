using System;
using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Postfix fun.
            var a = 3;
            var b = a++;
            WriteLine($"a is {a}, b is {b}");
            
            //Prefix fun.
            var c = 3;
            var d = ++c;
            WriteLine($"c is {c}, d is {d}");
            
            var e = 11;
            var f = 3;
            WriteLine($"e is {e}, f is {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");

            var g = 11.0;
            WriteLine($"g is {g}, f is {f}");
            WriteLine($"g / f = {g / f}");

            var p = 6;
            // p = p + 3.
            p += 3;
            p -= 3;
            p *= 3;
            p /= 3;
        }
    }
}