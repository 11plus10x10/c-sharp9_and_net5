namespace PacktLibrary
{
    public struct DisplacementVector
    {
        // Fields.
        public int x;
        public int y;

        // Constructor.
        public DisplacementVector(int initialX, int initialY)
        {
            x = initialX;
            y = initialY;
        }
        
        // Operator.
        public static DisplacementVector operator +(
            DisplacementVector vector1,
            DisplacementVector vector2)
        {
            return new DisplacementVector(
                vector1.x + vector2.x,
                vector2.y + vector2.y);
        }
    }
}
