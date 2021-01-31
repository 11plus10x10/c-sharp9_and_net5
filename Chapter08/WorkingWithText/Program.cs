using System;
using static System.Console;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = "London";
            WriteLine($"{city} is {city.Length} characters long.");
            WriteLine($"First char is {city[0]} and third is {city[2]}");

            var cities = "Paris,Berlin,Madrid,New York";

            var citiesArray = cities.Split(',');

            foreach (var item in citiesArray)
            {
                WriteLine(item);
            }

            var fullName = "Alan Jones";
            var indexOfSpace = fullName.IndexOf(' ');

            var firstName = fullName.Substring(0, indexOfSpace);
            var lastName = fullName.Substring(startIndex:indexOfSpace + 1);
            
            WriteLine($"{lastName}, {firstName}");

            var fullname2 = "Jones, Alan";
            var whiteSpace = fullname2.IndexOf(' ');
            var firstName2 = fullname2.Substring(whiteSpace + 1);
            var lastName2 = fullname2.Substring(0, whiteSpace - 1);
            
            WriteLine($"{firstName2} {lastName2}");

            var company = "Microsoft";
            var startsWith = company.StartsWith('M');
            var containsN = company.Contains('N');
            WriteLine($"Starts with M {startsWith}, contains an N: {containsN}");

            var recombined = string.Join(" => ", citiesArray);
            WriteLine(recombined);

            var fruit = "Apples";
            var price = 0.39M;
            var when = DateTime.Today;
            
            WriteLine($"{fruit} cost {price:c} on {when:dddd}s.");
            WriteLine(string.Format("{0} cost {1:C} on {2:dddd}s.", fruit, price, when));
        }
    }
}
