using System;
using System.Threading;

namespace PacktLibrary
{
    // Note that the class in not generic.
    public static class Squarer
    {
        // Yet the method is.
        public static double Square<T>(T input) where T : IConvertible
        {
            // Converting using the current culture.
            var d = input.ToDouble(Thread.CurrentThread.CurrentCulture);

            return d * d;
        }
    }
}
