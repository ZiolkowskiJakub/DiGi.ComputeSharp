namespace DiGi.ComputeSharp.Classes
{
    public readonly struct Segment3
    {
        public readonly Point3 Start;
        public readonly Point3 End;

        public Segment3()
        {

        }

        public Segment3(Point3 start, Point3 end)
        {
            Start = start;
            End = end;
        }

        public bool IsNaN()
        {
            return Start.IsNaN() || End.IsNaN();
        }

        public float GetLength()
        {
            return Start.Distance(End);
        }

        public Segment3 GetInversed()
        {
            return new Segment3(End, Start);
        }

        public Vector3 GetDirection()
        {
            return new Vector3(Start, End).GetUnit();
        }
    }
}



