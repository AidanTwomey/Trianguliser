using System;

namespace aidantwomey.Trianguliser.Library.Geometry
{
    public class LineSegment
    {
        private readonly Point endpoint1;
        private readonly Point endpoint2;

        public LineSegment(Point endpoint1, Point endpoint2)
        {
            this.endpoint1 = endpoint1;
            this.endpoint2 = endpoint2;
        }

        public double Slope =>
            endpoint2.X == endpoint1.X
                ? double.PositiveInfinity
                : (endpoint2.Y - endpoint1.Y) / (endpoint2.X - endpoint1.X);
    }
}