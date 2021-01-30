using static System.Console;

namespace PacktLibrary
{
    public class Singer
    {
        // Virtual allows this method to be overridden.
        public virtual void Sing()
        {
            WriteLine("Singing...");
        }
    }
}