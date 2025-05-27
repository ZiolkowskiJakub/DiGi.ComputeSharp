using ComputeSharp;

namespace DiGi.ComputeSharp.Classes
{
    public readonly struct Triangle3
    {
        public readonly Point3 Point_1;
        public readonly Point3 Point_2;
        public readonly Point3 Point_3;

        public Triangle3()
        {

        }

        public Triangle3(Point3 point_1, Point3 point_2, Point3 point_3)
        {
            Point_1 = new Point3(point_1); 
            Point_2 = new Point3(point_2); 
            Point_3 = new Point3(point_3);
        }

        public bool IsNaN()
        {
            return Point_1.IsNaN() || Point_2.IsNaN() || Point_3.IsNaN();
        }

        public Point3[] GetPoints()
        {
            return [Point_1, Point_2, Point_3];
        }

        public Segment3 GetSegment_1()
        {
            return new Segment3(Point_1, Point_2);
        }

        public Segment3 GetSegment_2()
        {
            return new Segment3(Point_2, Point_3);
        }

        public Segment3 GetSegment_3()
        {
            return new Segment3(Point_3, Point_1);
        }

        public Segment3[] GetSegments()
        {
            return [GetSegment_1(), GetSegment_2(), GetSegment_3()];
        }

        public Vector3 GetVector_1()
        {
            return new Vector3( Point_1, Point_2);//new Vector3(Point_1[0] - Point_2[0], Point_1[1] - Point_2[1], Point_1[2] - Point_2[2]);
        }

        public Vector3 GetVector_2()
        {
            return new Vector3(Point_2, Point_3);//new Vector3(Point_2[0] - Point_3[0], Point_2[1] - Point_3[1], Point_2[2] - Point_3[2]);
        }

        public Vector3 GetVector_3()
        {
            return new Vector3(Point_3, Point_1);//new Vector3(Point_3[0] - Point_1[0], Point_3[1] - Point_1[1], Point_3[2] - Point_1[2]);
        }

        public Vector3[] GetVectors()
        {
            return [GetVector_1(), GetVector_2(), GetVector_3()];
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", Point_1, Point_2, Point_3);
        }
    }
}



