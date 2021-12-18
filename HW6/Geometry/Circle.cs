namespace Geometry
{
    public sealed class Circle : Point
    {
        private double _r;
        public double R
        {
            get => _r; set
            {
                if (value < 0)
                {
                    throw new System.Exception("Can't be less than 0");
                }
                _r = value;
            }
        }
        public Circle()
        {
            Name = "Circle";
        }
        public Circle(Color color, double xcentre, double ycentre, double r) : base(color, xcentre, ycentre)
        {
            Name = "Circle";
            R = r;
        }

        public double AreaCalculate() => 3.14 * R * R;
    }
}
