using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Point:Figure
    {

        public Point()
        {
            Name = "Point";
        }

        public Point(Color color, double xcentre, double ycentre):base(color,xcentre,ycentre)
        {
            Name = "Point";
        }
    
        
    }
}
