using System;
using System.Text;
using Support;

namespace Geometry
{
    
    public abstract class Figure
    {
        private bool _visible;
        private Color _color;
        private double _xCentre;
        private double _yCentre;
        private Logger _logger = new ConsoleLogger();


        protected bool Visible { get =>_visible; set => _visible = value; }
        protected Color FigureColor { get => _color; set => _color = value; }
        protected double Xcentre { get => _xCentre; set => _xCentre = value; }
        protected double Ycentre { get => _yCentre; set => _yCentre = value; }
        protected string Name { get; set; }
        public  Figure()
        {

        }

        public  Figure(Color color, double xcentre, double ycentre)
        {
            FigureColor = color;
            Xcentre = xcentre;
            Ycentre = ycentre;
        }

        public bool MoveTo(int x, int y)
        {
            Xcentre = x;
            Ycentre = y;
            return true;
        }
        public bool Paint(Color NewColor)
        {
            FigureColor = NewColor;
            return true;
        }

        public bool IsVisible() => Visible;
        public void Show() => Visible = true;
        public void Hide() => Visible = false;

        public void DisplayInformation()
        {
            StringBuilder info = new StringBuilder();
            info.Append($"Name: {Name} \n");
            info.Append($"Color: {FigureColor.Name} \n");
            info.Append($"Centre Position X:{Xcentre} Y:{Ycentre} \n");
            info.Append($"Visible: {Visible} \n");
            _logger.Print(info.ToString());
        }
    }
}
