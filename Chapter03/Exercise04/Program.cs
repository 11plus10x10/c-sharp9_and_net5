using static System.Console;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = Input("Enter a number between 0 and 255: ", 1);
            int secondNumber = Input("Enter another number between 0 and 255: ", 2);
            WriteLine($"{firstNumber} divided by {secondNumber} is {firstNumber / secondNumber}");
        }

        static int Input(string prompt, int operand)
        {
            int number;
            bool success;
            
            do
            {
                Write(prompt);
                success = int.TryParse(ReadLine(), out number);
            } while (success != true);

            if (operand == 2 && number == 0)
            {
                WriteLine("Can't divide by zero, try again.");
                number = Input(prompt, 2);
            }

            return number;
        }
    }
}
