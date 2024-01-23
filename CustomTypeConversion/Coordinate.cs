using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CustomTypeConversion
{
    public class Coordinate
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Coordinate(double x, double y)
        {
            X = x;
            Y = y;
        }
        public static implicit operator Vector(Coordinate coordinate)
        {
            if (coordinate == null)
            {
                throw new InvalidCastException("Cannot convert null Coordinate to Vector.");
            }
            return new Vector(coordinate.X, coordinate.Y);
        }
    }
}
