namespace aidantwomey.Trianguliser.Library.Geometry
{
    public static class ExtensionMethods
    {
        public static bool TurnsRight(this DirectedLineSegment l1, DirectedLineSegment l2)
        {
            return l1.Slope > l2.Slope;
        }
    }
}