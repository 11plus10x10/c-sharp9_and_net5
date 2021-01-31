using System;
using System.Reflection;
using System.Linq;
using System.Runtime.CompilerServices;
using static System.Console;

namespace WorkingWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Assembly metadata:");
            var assembly = Assembly.GetEntryAssembly();
            
            WriteLine($" Full name: {assembly.FullName}");
            WriteLine($" Location: {assembly.Location}");

            var attributes = assembly.GetCustomAttributes();
            
            WriteLine($" Attributes:");
            foreach (var attr in attributes)
            {
                WriteLine($" {attr.GetType()}");
            }

            var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            
            WriteLine($" Version: {version.InformationalVersion}");

            var company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();
            
            WriteLine($" Company: {company.Company}");
            
            WriteLine();
            
            WriteLine($"* Types:");
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                WriteLine();
                WriteLine($"Type: {type.FullName}");
                var members = type.GetMembers();

                foreach (var member in members)
                {
                    WriteLine($"{member.MemberType}: {member.Name} ({member.DeclaringType.Name})");
                    var coders = member.GetCustomAttributes<CoderAttribute>().
                        OrderByDescending(x => x.LastModified);

                    foreach (CoderAttribute coder in coders)
                    {
                        WriteLine($"-> Modified by {coder.Coder} on {coder.LastModified.ToShortDateString()}");
                    }
                }
            }
        }

        [Coder("Bob Bigdickinson", "31 January 2021")]
        [Coder("Bill Gates", "01 February 2021")]
        public static void DoStuff()
        {
            
        }
    }
}
