using System;
using System.Linq;
using System.Reflection;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some unused variables using types
            // in additional assemblies.
            System.Data.DataSet ds;
            System.Net.Http.HttpClient client;
            
            // Loop through the assemblies that this app references.
            foreach (var r in Assembly.GetEntryAssembly()
                .GetReferencedAssemblies())
            {
                // Load the assembly so we can read its details.
                var a = Assembly.Load(new AssemblyName(r.FullName));
                
                // Declare a variable to count the number of methods.
                var methodCount = 0;
                
                // Loop through all the types in the assembly.
                foreach (var t in a.DefinedTypes)
                {
                    // Add up the counts of methods.
                    methodCount += t.GetMethods().Count();
                }
                // Output the count of types and their methods.
                Console.WriteLine($"{a.DefinedTypes.Count()} types with {methodCount} methods in {r.Name} assembly.");
            }
        }
    }
}