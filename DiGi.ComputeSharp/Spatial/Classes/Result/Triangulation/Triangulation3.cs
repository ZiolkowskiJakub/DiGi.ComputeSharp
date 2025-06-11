namespace DiGi.ComputeSharp.Spatial.Classes
{
    public readonly struct Triangulation3
    {
        public readonly Triangle3 trinagle_1;
        public readonly Triangle3 trinagle_2;
        public readonly Triangle3 trinagle_3;
        public readonly Triangle3 trinagle_4;
        public readonly Triangle3 trinagle_5;
        public Triangulation3()
        {
            trinagle_1 = new Triangle3();
            trinagle_2 = new Triangle3();
            trinagle_3 = new Triangle3();
            trinagle_4 = new Triangle3();
            trinagle_5 = new Triangle3();
        }

        public Triangulation3(Triangle3 triangle3)
        {
            trinagle_1 = triangle3;
            trinagle_2 = new Triangle3();
            trinagle_3 = new Triangle3();
            trinagle_4 = new Triangle3();
            trinagle_5 = new Triangle3();
        }

        public Triangulation3(Triangle3 triangle3_1, Triangle3 triangle3_2)
        {
            trinagle_1 = triangle3_1;
            trinagle_2 = triangle3_2;
            trinagle_3 = new Triangle3();
            trinagle_4 = new Triangle3();
            trinagle_5 = new Triangle3();
        }

        public Triangulation3(Triangle3 triangle3_1, Triangle3 triangle3_2, Triangle3 triangle3_3)
        {
            trinagle_1 = triangle3_1;
            trinagle_2 = triangle3_2;
            trinagle_3 = triangle3_3;
            trinagle_4 = new Triangle3();
            trinagle_5 = new Triangle3();
        }

        public Triangulation3(Triangle3 triangle3_1, Triangle3 triangle3_2, Triangle3 triangle3_3, Triangle3 triangle3_4)
        {
            trinagle_1 = triangle3_1;
            trinagle_2 = triangle3_2;
            trinagle_3 = triangle3_3;
            trinagle_4 = triangle3_4;
            trinagle_5 = new Triangle3();
        }

        public Triangulation3(Triangle3 triangle3_1, Triangle3 triangle3_2, Triangle3 triangle3_3, Triangle3 triangle3_4, Triangle3 triangle3_5)
        {
            trinagle_1 = triangle3_1;
            trinagle_2 = triangle3_2;
            trinagle_3 = triangle3_3;
            trinagle_4 = triangle3_4;
            trinagle_5 = triangle3_5;
        }

        public bool IsNaN()
        {
            return trinagle_1.IsNaN();
        }
    }
}
