using System;

namespace aidantwomey.Trianguliser.Library.Geometry
{


    public struct Point
    {
        public readonly double X;
        public readonly double Y;

        public Point(double x, double y) : this()
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            return obj is Point point &&
                   X == point.X &&
                   Y == point.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}