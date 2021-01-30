using System;
using static System.Console;
using System.IO;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("There are no arguments");
            }
            else
            {
                WriteLine("There is at least one argument");
            }
            
            // Pattern matching.
            // Add and remove the "" to change the behavior.
            object o = "3";
            var j = 4;

            if (o is int i)
            {
                WriteLine($"{i} * {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it cannot multiply.");
            }
            
            var number = (new Random().Next(1, 7));
            
            WriteLine($"My random number is {number}");
            
            // Label is not working for me?
            A_label:
            switch (number)
            {
                case 1:
                    WriteLine("One");
                    // Jumps to the end of switch statement
                    break;
                case 2:
                    WriteLine("Two");
                    break;
                case 3:
                case 4:
                    WriteLine("Four");
                    goto case 1;
                case 5:
                    // go to sleep for half a second.
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
                
            } // End of switch.

            var path = "/home/shoora/RiderProjects/Chapter03";

            Stream s = File.Open(
                Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

            var message = string.Empty;
            switch (s)
            {
                case FileStream writeableFile when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The stream is a read-only file";
                    break;
                case MemoryStream ms:
                    message = "Tje stream is a memory address.";
                    break;
                // Always evaluated last despite it's current position.
                default:
                    message = "The stream is some other type.";
                    break;
                case null:
                    message = "The stream is null.";
                    break;
            } // End of switch.
            WriteLine(message);
            
            // Switch expression.
            message = s switch
            {
                FileStream writealbeFile when s.CanWrite
                    => "The stream is a file that I can write to.",
                FileStream readOnlyFile
                    => "The stream is read-only file.",
                MemoryStream ms
                    => "The stream is a memory address",
                null
                    => "The stream is null.",
                _
                    => "The stream is some other type."
            };
            WriteLine(message);
        }
    }
}