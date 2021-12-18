using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public sealed class Color
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Color()
        {

        }
        public Color(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
