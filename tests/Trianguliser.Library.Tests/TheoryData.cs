using System.Collections;
using System.Collections.Generic;

namespace aidantwomey.Trianguliser.Library.Tests
{
    public abstract class TheoryData : IEnumerable<object[]>
    {
        readonly List<object[]> data = new List<object[]>();

        protected void AddRow(params object[] values)
        {
            data.Add(values);
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class TheoryData<Point> : TheoryData
    {
        public void Add(Point p1, Point p2, double expected)
        {
            AddRow(p1, p2, expected);
        }
    }
}