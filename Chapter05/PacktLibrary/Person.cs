using System;
using System.Collections.Generic;
using static System.Console;

namespace PacktLibrary
{
    public partial class Person : IComparable<Person>
    {
        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
        
        // Constants, avoid them.
        public const string Species = "Homo Sapien";
        
        // Read-only fields.
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        
        // Constructors
        public Person()
        {
            // Set default values for fields
            // including read-only fields.
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        // Fields.
        public string Name;
        public DateTime DateOfBirth;
        public Wonders FavoriteWonder;
        public Wonders BucketList;
        public List<Person> Children = new List<Person>();
        
        // Children indexer.
        public Person this[int index]
        {
            get => Children[index];
            set => Children[index] = value;
        }
        
        // Methods.

        /// <summary>
        /// Static method to "multiply".
        /// </summary>
        /// <param name="partner1">First partner of Person type.</param>
        /// <param name="partner2">Second partner of Person type.</param>
        /// <returns>Returns child of two partners of Person type.</returns>
        public static Person Procreate(Person partner1, Person partner2)
        {
            var baby = new Person
            {
                Name = $"Baby of {partner1.Name} and {partner2.Name}"
            };
            partner1.Children.Add(baby);
            partner2.Children.Add(baby);

            return baby;
        }

        /// <summary>
        /// Instance method to "multiply".
        /// </summary>
        /// <param name="partner">Partner of Person type to multiply with.</param>
        /// <returns>Returns child of two partners of Person type.</returns>
        public Person ProcreateWith(Person partner)
        {
            return Procreate(this, partner);
        }

        /// <summary>
        /// Operator to "multiply".
        /// </summary>
        /// <param name="partner1">First partner of Person type.</param>
        /// <param name="partner2">Second partner of Person type.</param>
        /// <returns>Returns child of two partners of Person type.</returns>
        public static Person operator *(Person partner1, Person partner2)
        {
            return Person.Procreate(partner1, partner2);
        }
        
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 5);
        }

        public string SayHello()
        {
            return $"{Name} says \"Hello\"";
        }

        public string SayHello(string name)
        {
            return $"{name} says \"Hello\"";
        }
        
        // Optional parameters.
        public string OptionalParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true)
        {
            return string.Format(
                format: $"command is {command} is {number}, active is {active}");
        }
        
        // In, ref, out parameters.
        public void PassingParameters(
            int x,
            ref int y,
            out int z)
        {
            // Out parameters cannot have a default.
            // And must be initialized inside the method.
            z = 99;
            
            // Increment each parameter.
            x++;
            y++;
            z++;
        }
        
        // Method for testing inherited exception.
        public void TimeTravel(DateTime when)
        {
            if (when <= DateOfBirth)
            {
                throw new PersonException("If you travel back in time to a date earlier your own birth," +
                                          " then the universe will explode");
            }
            else
            {
                WriteLine($"Welcome to {when:yyyy}");
            }
        }
    }
}
