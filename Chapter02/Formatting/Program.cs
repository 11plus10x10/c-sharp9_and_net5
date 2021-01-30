using System;
using static System.Console;

namespace Formatting
{
    class Program
    {
        static void Main()
        {
            var numberOfApples = 12;
            var pricePerApple = 0.35M;
            
            // Formatting using numbered
            // positional arguments.
            Console.WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);
                
            string formatted = string.Format(format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples);
            
            // Nonexistent method used to illustrate the idea.
            // WriteToFile(formatted);
            
            Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");
            
            // Alignment and :formatString.
            var applesText = "Apples";
            var applesCount = 1234;
            var bananasText = "Bananas";
            var bananasCount = 56789;
            
            WriteLine(
                format: "{0, -8} {1, 6}",
                arg0: "Name",
                arg1: "Count");
            
            WriteLine(
                format: "{0, -8} {1, 6}",
                arg0: applesText,
                arg1: applesCount);
            
            WriteLine(
                format: "{0, -8} {1, 6}",
                arg0: bananasText,
                arg1: bananasCount);
            
            Write("Type your first name and press ENTER: ");
            var firstName = ReadLine();
            
            Write("Type yor age and press ENTER: ");
            var age = ReadLine();
            
            WriteLine($"Hello {firstName}, you look gor for {age}.");
            
            // Reading key value.
            Write("Press any key combination: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine($"Key: {key.Key}, Char: {key.KeyChar}, Modifiers: {key.Modifiers}");
        }
    }
}
