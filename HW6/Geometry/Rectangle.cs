namespace Geometry
{
    public sealed class Rectangle : Point
    {
        private double _high;
        private double _width;
        public double High
        {
            get => _high;
            set
            {
                if (value < 0)
                {
                    throw new System.Exception("Can't be less than 0");
                }
                _high = value;
            }
        }
        public double Width
        {
            get => _width; set
            {
                if (value < 0)
                {
                    throw new System.Exception("Can't be less than 0");
                }
                _width = value;
            }
        }
        public Rectangle()
        {
            Name = "Rectangle";
        }
        public Rectangle(Color color, double xcentre, double ycentre, double high, double width) : base(color, xcentre, ycentre)
        {
            Name = "Rectangle";
            Width = width;
            High = high;
        }

        public double AreaCalculate() => Width * High;

    }
}
