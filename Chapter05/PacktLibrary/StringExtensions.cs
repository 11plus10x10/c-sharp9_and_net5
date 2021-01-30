using System.Text.RegularExpressions;

namespace PacktLibrary
{
    public static class StringExtensions
    {
        public static bool IsValidEmail(this string input)
        {
            // Using simple regular expression to check
            // that the input is a valid email.
            return Regex.IsMatch(input, @"[a-zA-Z0-9\.-_]+@[a-zA-Z0-9\.-_]+");
        }
    }
}