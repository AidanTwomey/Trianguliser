using aidantwomey.Trianguliser.Library.Geometry;
using Xunit;

namespace aidantwomey.Trianguliser.Library.Tests
{
    public class Given_A_Pair_Of_DirectedLineSegments
    {
        public static TheoryData<DirectedLineSegment, DirectedLineSegment> Data
        {
            get
            {
                var data = new TheoryData<DirectedLineSegment, DirectedLineSegment>();
                // data.Add(new Point(-1.0, 1.0), new Point(2.0, 2.0), 1.0/3.0);
                // data.Add(new Point(1.0, 1.0), new Point(4.0, 2.0), 1.0/3.0);
                // data.Add(new Point(1.0, 1.0), new Point(2.0, 2.0), 1.0);
                // data.Add(new Point(1.0, 2.0), new Point(2.0, 1.0), -1.0);
                // data.Add(new Point(1.0, 1.0), new Point(2.0, 1.0), 0);
                // data.Add(new Point(1.0, 2.0), new Point(1.0, 1.0), double.PositiveInfinity);
                return data;
            }
        }

        [Fact]
        public void When_First_Segment_Points_Up_And_Second_Segment_Has_Lower_Slope_Then_TurnRight_Returns_True()
        {
            
        }
    }
}