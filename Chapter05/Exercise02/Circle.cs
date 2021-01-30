using static System.Math;

namespace Exercise02
{
    public class Circle : Square
    {
        public override double Area => (int)(PI * Pow(Height / 2, 2.0));
        public Circle(double height) : base(height)
        {
            Height = height * 2;
        }
    }
}