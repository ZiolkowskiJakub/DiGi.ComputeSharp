namespace DiGi.ComputeSharp.Classes
{
    public readonly struct LineIntersectionResult
    {
        public readonly Line3 Line;
        public readonly Triangle3 Triangle;
        public readonly Point3 Point;
        public readonly float Distance;

        public LineIntersectionResult()
        {
            Distance = float.NaN;
        }

        public LineIntersectionResult(Line3 line, Triangle3 triangle, Point3 point, float distance)
        {
            Line = line;
            Triangle = triangle;
            Point = point;
            Distance = distance;
        }

        public bool IsNaN()
        {
            return Distance != Distance || Point.IsNaN() || Triangle.IsNaN() || Line.IsNaN();
        }

    }
}
