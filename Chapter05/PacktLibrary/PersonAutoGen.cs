using System;

namespace PacktLibrary
{
    public partial class Person
    {
        // A property defined using C# 1-5 syntax.
        public string Origin
        {
            get
            {
                return $"{Name} was born on {HomePlanet}";
            }
        }
        
        // Two properties defined using C# 6+ lambda expression syntax.
        public string Greeting => $"{Name} says \"Hello\"";

        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;
        
        // Settable property.
        // Auto-syntax.
        public string FavoriteIceCream { get; set; }

        private string _favoritePrimaryColor;

        public string FavoritePrimaryColor
        {
            get => _favoritePrimaryColor;
            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        _favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException(
                            $"{value} is not a primary color. " +
                            "Choose from: red, green, blue.");
                }
            }
        }
        
        // Method with a local function.
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
            }
            return localFactorial(number);
            
            // Local function 
            int localFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }
        
        // Event delegate field.
        public event EventHandler Shout;
            
        // Data field.
        public int AngerLevel;
            
        // Method.
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                // Pre C# 6.0 style:
                
                // If something is listening...
                // if (Shout != null)
                // {
                //     // ...then call the delegate.
                //     Shout(this, EventArgs.Empty);
                // }
                
                Shout?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
