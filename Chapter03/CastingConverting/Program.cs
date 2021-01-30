using System;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            // An int can be safely cast into a double
            double b = a;
            WriteLine(b);

            var c = 9.8;
            // Below is an illegal implicit conversion.
            // int d = c;
            
            // This is how it should be done.
            int d = (int) c;
            WriteLine(d);

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e} and f is {f}");

            // This is casting, it just trims off the real part.
            e = long.MaxValue;
            f = (int) e;
            WriteLine($"e is {e:N} and f is {f:N}");

            // This is converting, it rounds up the value.
            var g = 9.8;
            var h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            var doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

            // Banker's rounding.
            foreach (var item in doubles)
            {
                WriteLine($"ToInt({item}) is {ToInt32(item)}");
            } // foreach end

            // Primary school rounding.
            foreach (var item in doubles)
            {
                WriteLine(format:
                    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
                    arg0: item,
                    arg1: Math.Round(value: item,
                        digits: 0,
                        mode: MidpointRounding.AwayFromZero));
            } // foreach end

            var number2 = 12;
            WriteLine(number2.ToString());

            var boolean = true;
            WriteLine(boolean.ToString());
            
            DateTime now = DateTime.Now;
            WriteLine(now.ToString());
            
            object me = new object();
            WriteLine(me.ToString());
            
            // Allocating array of 128 bytes.
            var binaryObject = new byte[128];
            
            // Populating array with random bytes
            new Random().NextBytes(binaryObject);
            
            WriteLine("Binary Object as bytes:");

            foreach (var t in binaryObject)
            {
                Write($"{t:X} ");
            }
            WriteLine();
            
            // Converting to Base64 string and output as text
            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Binary Object as Base64: {encoded}");

            var age = int.Parse("27");
            DateTime birthday = DateTime.Parse("5 July 1992");
            
            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}");
            WriteLine($"My birthday is {birthday:D}");

            Write("How many eggs are there? ");
            var input = ReadLine();
            if (int.TryParse(input, out var count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input");
            }
            
            // The same.
            WriteLine(
                int.TryParse(input, out var count2) ? 
                    $"There are {count2} eggs."
                    : "I could not parse the input");
        }
    }
}
