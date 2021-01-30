using static System.Console;

namespace PacktLibrary
{
    public class LadyGaga : Singer
    {
        // Sealed prevents overriding the method in subclasses.
        // You can only seal an overridden method.
        public override void Sing()
        {
            WriteLine("Singing with style...");
        }
    }
}
