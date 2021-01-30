using System;
using static System.Console;

namespace PacktLibrary
{
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }

        public new void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dd/MM/yy} and hired on {HireDate:dd/MM/yy}");
        }
        
        // Overriden methods.
        public override string ToString()
        {
            return $"{Name}'s code is {EmployeeCode}";
        }
        
        
        // Preventing inheritance.
        public sealed class ScroogeMcDuck
        {
            
        }
    }
}