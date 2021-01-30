using System;
using static System.Console;

namespace Arguments
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length < 4)
            {
                WriteLine("You must specify two colors and dimensions, e.g.");
                WriteLine("dotnet run --project red yellow 80 40");
                // Stop running.
                return;
            }

            ForegroundColor = (ConsoleColor) Enum.Parse(typeof(ConsoleColor), args[0], true);

            BackgroundColor = (ConsoleColor) Enum.Parse(typeof(ConsoleColor), args[1], true);

            try
            {
                WindowWidth = int.Parse(args[2]);
                WindowHeight = int.Parse(args[3]);
            }
            catch (PlatformNotSupportedException)
            {
                WriteLine("The current platform does not support changing the size of a console window");
            }

            WriteLine($"There are {args.Length} arguments");

            foreach (var arg in args) WriteLine(arg);
        }
    }
}
