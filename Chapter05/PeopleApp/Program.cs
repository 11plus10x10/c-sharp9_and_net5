using System;
using static System.Console;
using PacktLibrary;

namespace PeopleApp
{
    class Program
    {
        /// <summary>
        /// Method that gets a reference to the Person object
        /// from the sender parameter and outputs some information
        /// about them.
        /// </summary>
        /// <param name="sender">Reference to the Person object.</param>
        /// <param name="e">?</param>
        // Microsoft's convention for method names that handle events is
        // ObjectName_EventName.
        private static void Harry_Shout(object sender, EventArgs e)
        {
            var p = (Person) sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
        }

        static void Main(string[] args)
        {
            // Instantiating Bob.
            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965, 12, 22);
            WriteLine($"{bob.Name} was born on {bob.DateOfBirth:dddd, d MMMM yyyy}. He is {Person.Species} from {bob.HomePlanet}");
            
            bob.FavoriteWonder = Wonders.Colossus;    
            WriteLine(format:"{0}'s favorite wonder is {1}. It's integer is {2}.",
                arg0: bob.Name,
                arg1: bob.FavoriteWonder,
                arg2: (int)bob.FavoriteWonder);
            
            // Like that.
            bob.BucketList = Wonders.HangingGardens | Wonders.Mausoleum;
            // Or with dreadful magic number.
            // bob.BucketList = (Wonders) 18;
            WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
            
            bob.Children.Add(new Person() { Name = "Alfred" });
            bob.Children.Add(new Person() { Name = "Zoe" });
            WriteLine($"{bob.Name} has {bob.Children.Count} children:");

            for (int child = 0; child < bob.Children.Count; child++)
            {
                WriteLine($"    {bob.Children[child].Name}");
            }
            
            WriteLine();
            WriteLine("Same with foreach loop:");
            // The same with foreach.
            foreach (var child in bob.Children)
            {
                WriteLine($"    {child.Name}");
            }

            // Instantiating Alice.
            var alice = new Person()
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7),
                FavoriteWonder = Wonders.StatueOfZeus
            };
            WriteLine($"{alice.Name} was born on {alice.DateOfBirth:dd MMM yy}");

            // Store a shared value.
            BankAccount.InterestRate = 0.012M;
            
            var jonesAccount = new BankAccount()
            {
                AccountName = "Mrs. Jones",
                Balance = 2400,
            };
            WriteLine(jonesAccount);
            WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C}");
            
            var gerrierAccount = new BankAccount()
            {
                AccountName = "Ms. Gerrier",
                Balance = 98
            };
            WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance * BankAccount.InterestRate:C}");
            
            // New person for testing constructor
            var blankPerson = new Person();
            WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at " +
                      $"{blankPerson.Instantiated:T} on a {blankPerson.Instantiated:dddd} ");
            
            // Testing second constructor.
            var gunny = new Person("Gunny", "Mars");
            
            WriteLine(format:
                "{0} of {1} was created at {2:T} on a {2:dddd}",
                arg0: gunny.Name,
                arg1: gunny.HomePlanet,
                arg2: gunny.Instantiated);
            
            // Testing methods.
            bob.WriteToConsole();
            WriteLine(bob.GetOrigin());
            
            // Testing tuples.
            (string, int) fruit = bob.GetFruit();
            WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

            var fruitNamed = bob.GetNamedFruit();
            Write($"There are {fruitNamed.Name} {fruitNamed.Number}");
            
            // Inferring tuple name.
            var thing1 = ("Neville,", 4);
            WriteLine($"{thing1.Item1} has {thing1.Item2} children");

            var thing2 = (bob.Name, bob.Children.Count);
            WriteLine($"{thing2.Name} has {thing2.Count} children");
            
            // Deconstructing a tuple.
            // Same declaration, but without variable name.
            // Any type could be deconstructed. WOAH
            (string fruitName, int fruitNumber) = bob.GetFruit();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");
            
            // Parameters in methods.
            WriteLine(bob.SayHello());
            WriteLine(bob.SayHello("Emily"));
            WriteLine(bob.OptionalParameters());
            WriteLine(bob.OptionalParameters("Jump!", 98.5));
            WriteLine(bob.OptionalParameters(number: 5.0, command: "Hide!"));
            WriteLine(bob.OptionalParameters("Poke!", active: false));
            
            // In, ref, out parameters.
            var a = 10;
            var b = 20;
            var c = 30;
            
            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            
            bob.PassingParameters(a, ref b, out c);
            
            WriteLine($"After: a = {a}, b = {b}, c = {c}");
            
            // Simplified out variables from C# 7.1.
            var d = 10;
            var e = 20;
            
            WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");
            
            bob.PassingParameters(d, ref e, out int f);
            
            WriteLine($"After: d = {d}, e = {e}, f = {f}");
            
            // Having fun with properties.
            var sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };
            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);

            sam.FavoriteIceCream = "Chocolate Fudge";
            
            WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}");

            sam.FavoritePrimaryColor = "Red";
            
            WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}");
            
            // Having fun with indexers.
            sam.Children.Add(new Person { Name = "Charlie"});
            sam.Children.Add(new Person { Name = "Ella"});
            
            WriteLine($"Sam's first child is {sam.Children[0].Name}");
            WriteLine($"Sam's second child is {sam.Children[1].Name}");
            WriteLine($"Sam's first child is {sam[0].Name}");
            WriteLine($"Sam's second child is {sam[1].Name}");
            
            // Chapter 06
            var harry = new Person { Name = "Harry"};
            var mary = new Person {Name = "Mary"};
            var jill = new Person {Name = "Jill"};
            
            // Calling instance method.
            var baby1 = mary.ProcreateWith(harry);
            
            // Calling static method.
            var baby2 = Person.Procreate(harry, jill);
            
            // Calling an operator.
            var baby3 = harry * mary;
            
            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{jill.Name} has {jill.Children.Count} children.");
            
            WriteLine(
                format:"{0}'s first child is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name);
            
            // Calling a method with local function.
            WriteLine($"5! is {Person.Factorial(5)}.");
            
            // Assigning the method to the delegate field.
            harry.Shout += Harry_Shout;
            
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();
            
            // Implementing interfaces.
            Person[] people =
            {
                new Person { Name = "Simon" },
                new Person { Name = "Jenny"},
                new Person { Name = "Adam"},
                new Person { Name = "Richard"}, 
            };
            
            WriteLine();
            
            WriteLine("Initial list of people:");
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }
            
            WriteLine("Use Person's IComparable implementation to sort:");
            Array.Sort(people);
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }
            
            WriteLine();
            
            // IComparer test.
            WriteLine("Use PersonComparer's IComparer implementation to sort:");
            Array.Sort(people, new PersonComparer());
            foreach (var person in people)
            {
                WriteLine($"{person.Name}");
            }
            
            
            WriteLine();
            
            
            // Trying to solve a problem without generics.
            
            var t1 = new Thing { Data = 42};
            WriteLine($"Thing is an integer: {t1.Process(42)}");
            
            var t2 = new Thing { Data = "apple"};
            WriteLine($"Thing is a string: {t2.Process("apple")}");
            
            
            WriteLine();
            // And now with generics.
            
            var gt1 = new GenericThing<int> { Data = 42};
            WriteLine($"GenericThing with an integer: {gt1.Process(42)}");
            
            var gt2 = new GenericThing<string> { Data = "apple"};
            WriteLine($"GenericThing with a string: {gt2.Process("apple")}");
            
            
            WriteLine();
            // Generic method.

            // Specifying type parameter.
            var number1 = "4";
            WriteLine($"{number1} squared is {Squarer.Square<string>(number1)}");

            // Or not.
            var number2 = 3;
            WriteLine($"{number2} squared is {Squarer.Square(number2)}");
            
            
            // Structs
            
            
            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv1.x}, {dv1.y}) + ({dv2.x}, {dv2.y}) = ({dv3.x}, {dv3.y})");
            
            
            // Inheriting from a class.
            
            
            var john = new Employee
            {
                Name = "John Jones",
                DateOfBirth = new DateTime(1990, 7 , 28)
            };
            john.WriteToConsole();
            
            
            // Extending a class.
            john.EmployeeCode = "JJ001";
            john.HireDate = new DateTime(2014, 11, 23);
            WriteLine($"{john.Name} was hired on {john.HireDate} with code: {john.EmployeeCode}");
            WriteLine();
            
            // Overriding the method.
            
            WriteLine(john.ToString());
            
            
            // Polymorphic and non-polymorphic inheritance.
            
            
            var aliceInEmployee = new Employee
            {
                Name = "Alice",
                EmployeeCode = "AA123"
            };

            Person aliceInPerson = aliceInEmployee;
            
            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole();
            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString());
            
            
            // Casting within inheritance hierarchies.

            
            if (aliceInPerson is Employee)
            {
                WriteLine($"{nameof(aliceInPerson)} IS an Employee.");
                
                Employee explicitAlice = (Employee)aliceInPerson;
                // Safely do something with explicitAlice.
            }
            
            Employee aliceAsEmployee = aliceInPerson as Employee;

            if (aliceAsEmployee != null)
            {
                WriteLine($"{nameof(aliceAsEmployee)} AS en Employee.");
                // Safely do something with aliceAsEmployee.
            }
            
            
            // Testing inherited exceptions.

            try
            {
                john.TimeTravel(new DateTime(1990, 12, 31));
                john.TimeTravel(new DateTime(1950, 12, 25));
            }
            catch (PersonException exception)
            {
                WriteLine(exception);
            }
            WriteLine();
            
            
            // Using static methods to reuse functionality.


            var email1 = "pamela@test.com";
            var email2 = "ian&test.com";
            
            WriteLine($"{email1} is a valid email address: {StringExtensions.IsValidEmail(email1)}");
            
            WriteLine($"{email2} is a valid email address: {StringExtensions.IsValidEmail(email2)}");
            WriteLine();
            
            
            // Using extension methods to reuse functionality.
            
            
            WriteLine($"{email1} is a valid email address: {email1.IsValidEmail()}");
            WriteLine($"{email2} is a valid email address: {email2.IsValidEmail()}");
        }
    }
}
