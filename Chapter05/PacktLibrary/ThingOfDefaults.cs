using System;
using System.Collections.Generic;

namespace PacktLibrary
{
    public class ThingOfDefaults
    {
        // Fields.
        public int Population;
        public DateTime When;
        public string Name;
        public List<Person> People;
        
        // Constructor.
        public ThingOfDefaults()
        {
            // C# 2.0 and later.
            Population = default;
            When = default;
            Name = default;
            People = default;
        }
    }
}