namespace DiGi.ComputeSharp.Classes
{
    public readonly struct Line3
    {
        public readonly Vector3 Direction;
        public readonly Point3 Origin;
        
        public Line3()
        {

        }

        public Line3(Point3 origin, Vector3 direction)
        {
            Origin = origin;
            Direction = direction;
        }

        public bool IsNaN()
        {
            return Origin.IsNaN() || Direction.IsNaN();
        }
    }
}



