using System;
using aidantwomey.Trianguliser.Library.Geometry;
using Shouldly;
using Xunit;

namespace aidantwomey.Trianguliser.Library.Tests
{
    public class Given_A_Pair_Of_Points
    {
        public static TheoryData<Point, Point, double> Data
        {
            get
            {
                var data = new TheoryData<Point, Point, double>();
                data.Add(new Point(-1.0, 1.0), new Point(2.0, 2.0), 1.0/3.0);
                data.Add(new Point(1.0, 1.0), new Point(4.0, 2.0), 1.0/3.0);
                data.Add(new Point(1.0, 1.0), new Point(2.0, 2.0), 1.0);
                data.Add(new Point(1.0, 2.0), new Point(2.0, 1.0), -1.0);
                data.Add(new Point(1.0, 1.0), new Point(2.0, 1.0), 0);
                data.Add(new Point(1.0, 2.0), new Point(1.0, 1.0), double.PositiveInfinity);
                return data;
            }
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void When_Line_Segment_Is_Formed_Slope_Is_Correct(Point p1, Point p2, double expected)
        {
            var segment = new LineSegment(p1,p2);
            segment.Slope.ShouldBe(expected);
        }
    }
}