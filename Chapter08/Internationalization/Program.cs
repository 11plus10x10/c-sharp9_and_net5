using System;
using System.Globalization;
using static System.Console;

namespace Internationalization
{
    class Program
    {
        static void Main(string[] args)
        {
            var globalization = CultureInfo.CurrentCulture;
            var localization = CultureInfo.CurrentUICulture;
            
            WriteLine($"The current globalization culture is {globalization.Name}: {globalization.DisplayName}");
            Write($"The current localization culture is {localization.Name}: {localization.DisplayName}");
            WriteLine();
            
            WriteLine("en-US: English (United States)");
            WriteLine("da-DK: Danish (Denmark)");
            WriteLine("fr-CA: French (Canada)");
            Write("Enter an ISO culture code: ");
            var newCulture = ReadLine();

            if (!string.IsNullOrEmpty(newCulture))
            {
                var ci = new CultureInfo(newCulture);
                CultureInfo.CurrentCulture = ci;
                CultureInfo.CurrentUICulture = ci;
            }
            WriteLine();
            
            Write("Enter your name: ");
            var name = ReadLine();
            
            Write("Enter your date of birth:");
            var dob = ReadLine();
            
            Write("Enter your salary: ");
            var salary = ReadLine();

            var date = DateTime.Parse(dob!);
            var minutes = (int) DateTime.Today.Subtract(date).TotalMinutes;
            var earns = decimal.Parse(salary!);
            
            WriteLine($"{name} was born on a {date:dddd}, is {minutes:N0} minutes old, and earns {earns:C}");
        }
    }
}
