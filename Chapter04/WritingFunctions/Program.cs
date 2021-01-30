using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        /// <summary>
        /// Pass a 32-bit integer and get times table up to 12.
        /// </summary>
        /// <param name="number">Number is a 32-bit integer.</param>
        static void TimesTable(byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (byte row = 1; row <= 12; row++)
            {
                WriteLine($"{row} * {number} = {row * number}");
            }
            WriteLine();
        }

        /// <summary>
        /// Runs TimesTable function.
        /// </summary>
        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");

                isNumber = byte.TryParse(ReadLine(), out var number);

                if (isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number!");
                }
            } while (!isNumber);
        }

        /// <summary>
        /// Pass a decimal number and a region code to get your tax payment.
        /// </summary>
        /// <param name="amount">Decimal number.</param>
        /// <param name="twoLetterRegionCode">Case-insensitive two letter region code.
        /// Default is US states.
        /// </param>
        /// <returns>Returns tax payment decimal number.</returns>
        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            var rate = 0.0M;
            var country = twoLetterRegionCode switch
            {
                // Switzerland.
                "CH" => rate = 0.08M,
                
                // Hungary.
                "HU" => rate = 0.27M,
                
                // California.
                "CA" => rate = 0.0825M,
                
                // Denmark, Norway.
                var code when (code == "DK" | code == "NO") => rate = 0.25M,
                
                // United Kingdom, France.
                var code when (code == "GB" | code == "FR") => rate = 0.2M,
                
                // Oregon, Alaska, Montana.
                var code when (code == "OR" | code == "AK" | code == "MT") => rate = 0.0M,
                
                // North Dakota, Wisconsin, Maryland, Virginia.
                var code when (code == "ND" | code == "WI" | code == "ME" | code == "VA") => rate = 0.05M,
                
                // Most of US states.
                _ => rate = 0.06M
            };
            
            return amount * rate;
        }

        /// <summary>
        /// Runs CalculateTax function.
        /// </summary>
        static void RunCalculateTax()
        {
            bool success;
            decimal amount;
            do
            {
                Write("Enter an amount: ");
                success = decimal.TryParse(ReadLine(), out amount);
            } while (!success);

            Write("Enter a two-letter region code: ");
            var region = ReadLine()!.ToUpper();

            decimal taxToPay = CalculateTax(amount,region);
            WriteLine($"You must pay {taxToPay} in sales tax.");
        }

        /// <summary>
        /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
        /// </summary>
        /// <param name="number">Number is a cardinal value e.g 1, 2, 3 and so on.</param>
        /// <returns>Number as an ordinal value e.g 1st, 2nd, 3rd and so on.</returns>
        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                    return $"{number}th";
                case 12:
                    goto case 11;
                case 13:
                    goto case 11;
                default:
                    var numberAsText = number.ToString();
                    char lastDigit = numberAsText[^1];
                    var suffix = lastDigit switch
                    {
                        '1' => "st",
                        '2' => "nd",
                        '3' => "rd",
                        _ => "th"
                    };
                    return $"{number}{suffix}";
            }
        }

        /// <summary>
        /// Runs CardinalToOrdinal() function.
        /// </summary>
        static void RunCardinalToOridinal()
        {
            for (var number = 1; number <= 40; number++)
            {
                Write($"{CardinalToOrdinal(number)} ");
            }
            WriteLine();
        }
        
        static void Main(string[] args)
        {
            RunTimesTable();
            RunCalculateTax();
            RunCardinalToOridinal();
        }
    }
}
