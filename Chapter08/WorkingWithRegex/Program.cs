using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace WorkingWithRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your age: ");
            var input = ReadLine();

            var ageChecker = new Regex(@"^\d+$");

            if (ageChecker.IsMatch(input!))
            {
                WriteLine("Thank you!");
            }
            else
            {
                WriteLine($"This is not a valid age: {input}!");
            }

            var films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";

            var filmsDumb = films.Split(',');
            WriteLine("Dumb attempt at splitting:");
            foreach (var film in filmsDumb)
            {
                WriteLine(film);
            }

            var csv = new Regex("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");
            var filmsSmart = csv.Matches(films);
            
            WriteLine("Smart attempt at splitting:");
            foreach (Match film in filmsSmart)
            {
                WriteLine(film.Groups[2].Value);
            }
        }
    }
}

