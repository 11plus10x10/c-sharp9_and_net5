using System;
using System.IO;
using System.Net;

namespace Variables
{
    class Program
    {
        static void Main()
        {
            // Storing a double in an object.
            object height = 1.88;
            
            // Storing a string in an object.
            object name = "Amir";
            
            Console.WriteLine($"{name} is {height} metres tall.");
            
            // Gives compile error!
            // var length1 = name.Length;
            
            // Tell compiler it is a string.
            var length2 = ((string)name).Length;
            
            Console.WriteLine($"{name} has {length2} characters.");
            
            // Storing a string in a dynamic object.
            dynamic anotherName = "Ahmed";
            
            // This compiles but would throw an exception at run-time
            // if you later store a data type that does not have a
            // property named Length.
            dynamic length = anotherName.Length;
            length = 2;
            Console.WriteLine($"now {nameof(length)} is {length}");
            
            // 66 million in UK.
            int population = 66_000_000;
            
            // KG.
            double weight = 1.88;
            
            // Sterling pounds.
            decimal price = 4.99M;
            
            // String.
            string fruit = "Apples";
            
            // Char.
            char letter = 'Z';
            
            // Bool.
            bool happy = true;

            // Bad idea.
            var file1 = File.CreateText(@"C:\penis.txt");
            
            // Good idea.
            StreamWriter file2 = File.CreateText(@"C:\penis.txt");
        }
    }
}
