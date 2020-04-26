using aidantwomey.Trianguliser.Library.Geometry;
using Shouldly;
using Xunit;

namespace aidantwomey.Trianguliser.Library.Tests
{
    public class Given_A_Pair_Of_DirectedLineSegments
    {
        public static TheoryData<DirectedLineSegment, DirectedLineSegment> TurnRightData
        {
            get
            {
                var data = new TheoryData<DirectedLineSegment, DirectedLineSegment>();
                data.Add(
                    new DirectedLineSegment(new Point(-1.0, 1.0), new Point(2.0, 2.0)),
                    new DirectedLineSegment(new Point(2.0, 2.0), new Point(5.0, 2.0)));
                return data;
            }
        }

        public static TheoryData<DirectedLineSegment, DirectedLineSegment> TurnLeftData
        {
            get
            {
                var data = new TheoryData<DirectedLineSegment, DirectedLineSegment>();
                data.Add(
                    new DirectedLineSegment(new Point(-1.0, 1.0), new Point(2.0, 2.0)),
                    new DirectedLineSegment(new Point(2.0, 2.0), new Point(5.0, 6.0)));
                return data;
            }
        }

        
        [Theory]
        [MemberData(nameof(TurnRightData))]
        public void When_First_Segment_Points_Up_And_Second_Segment_Has_Lower_Slope_Then_TurnRight_Returns_True(DirectedLineSegment upSegment, DirectedLineSegment nextSegment)
        {
            upSegment.TurnsRight(nextSegment).ShouldBeTrue();
        }

        [Theory]
        [MemberData(nameof(TurnLeftData))]
        public void When_First_Segment_Points_Up_And_Second_Segment_Has_Greater_Slope_Then_TurnRight_Returns_False(DirectedLineSegment upSegment, DirectedLineSegment nextSegment)
        {
            upSegment.TurnsRight(nextSegment).ShouldBeFalse();
        }
    }
}