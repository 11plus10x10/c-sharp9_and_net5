using System;

namespace Numbers
{
    class Program
    {
        static void Main()
        {
            // Unsigned integer means positive whole number
            // including 0.
            uint naturalNumber = 23;
            
            // Integer means negative or positive whole number
            // including 0.
            var integerNumber = -23;
            
            // Float means double-precision floating point.
            var anotherRealNumber = 2.3;
            
            // Three variables that store the number 2 million.
            var decimalNotation = 2_000_000;
            var binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            var hexadecimalNotation = 0x_001E_8480;
            
            // Checking the three values have the same value.
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
            
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range " +
                              $"{int.MinValue:N0} to {int.MaxValue:N0}");
            
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range " +
                              $"{double.MinValue:N0} to {double.MaxValue:N0}");
            
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range " +
                              $"{decimal.MinValue:N0} to {decimal.MaxValue:N0}");
            
            Console.WriteLine("\nUsing doubles:");

            var a = 0.1;
            var b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equals 0.3");
            }
            
            Console.WriteLine("\nUsing decimals:");

            var c = 0.1M;
            var d = 0.2M;

            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equals 0.3");
            }
        }
    }
}
