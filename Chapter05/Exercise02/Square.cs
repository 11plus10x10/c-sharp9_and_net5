namespace Exercise02
{
    public class Square : Shape
    {
        public override double Width => Width = Height;

        public Square(double height)
        {
            Height = height;
        }
    }
}