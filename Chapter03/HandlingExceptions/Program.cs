using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            
            Write("What is your age? ");
            var input = ReadLine();

            try
            {
                var age = int.Parse(input!);
                WriteLine($"You are {age} years old.");
            }

            catch(OverflowException)
            {
                WriteLine("Your age is a valid number format but ut is either too big or small.");
            }
            
            catch(FormatException)
            {
                WriteLine("The age you entered is not a valid number format.");
            }
            
            // The more general cat clause should be below,
            // because there could be other types of exceptions.
            catch(Exception ex)
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            
            WriteLine("After parsing.");
        }
    }
}