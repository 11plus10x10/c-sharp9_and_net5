namespace Exercise02
{
    public class Shape
    {
        // Properties.
        public double Height { get; set; }
        public virtual double Width { get; set; }
        public virtual double Area => Height * Width;
    }
}