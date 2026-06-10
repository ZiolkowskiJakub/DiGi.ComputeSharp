namespace DiGi.ComputeSharp.Spatial.Classes
{
    /// <summary>
    /// Represents a 3D triangulation consisting of up to five triangles.
    /// </summary>
    public readonly struct Triangulation3
    {
        /// <summary>
        /// The first triangle in the triangulation.
        /// </summary>
        public readonly Triangle3 trinagle_1;

        /// <summary>
        /// The second triangle in the triangulation.
        /// </summary>
        public readonly Triangle3 trinagle_2;

        /// <summary>
        /// The third triangle in the triangulation.
        /// </summary>
        public readonly Triangle3 trinagle_3;

        /// <summary>
        /// The fourth triangle in the triangulation.
        /// </summary>
        public readonly Triangle3 trinagle_4;

        /// <summary>
        /// The fifth triangle in the triangulation.
        /// </summary>
        public readonly Triangle3 trinagle_5;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangulation3"/> struct with default values.
        /// </summary>
        public Triangulation3()
        {
            trinagle_1 = new Triangle3();
            trinagle_2 = new Triangle3();
            trinagle_3 = new Triangle3();
            trinagle_4 = new Triangle3();
            trinagle_5 = new Triangle3();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangulation3"/> struct with one specified triangle.
        /// </summary>
        /// <param name="triangle3">The first triangle to assign.</param>
        public Triangulation3(Triangle3 triangle3)
        {
            trinagle_1 = triangle3;
            trinagle_2 = new Triangle3();
            trinagle_3 = new Triangle3();
            trinagle_4 = new Triangle3();
            trinagle_5 = new Triangle3();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangulation3"/> struct with two specified triangles.
        /// </summary>
        /// <param name="triangle3_1">The first triangle to assign.</param>
        /// <param name="triangle3_2">The second triangle to assign.</param>
        public Triangulation3(Triangle3 triangle3_1, Triangle3 triangle3_2)
        {
            trinagle_1 = triangle3_1;
            trinagle_2 = triangle3_2;
            trinagle_3 = new Triangle3();
            trinagle_4 = new Triangle3();
            trinagle_5 = new Triangle3();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangulation3"/> struct with three specified triangles.
        /// </summary>
        /// <param name="triangle3_1">The first triangle to assign.</param>
        /// <param name="triangle3_2">The second triangle to assign.</param>
        /// <param name="triangle3_3">The third triangle to assign.</param>
        public Triangulation3(Triangle3 triangle3_1, Triangle3 triangle3_2, Triangle3 triangle3_3)
        {
            trinagle_1 = triangle3_1;
            trinagle_2 = triangle3_2;
            trinagle_3 = triangle3_3;
            trinagle_4 = new Triangle3();
            trinagle_5 = new Triangle3();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangulation3"/> struct with four specified triangles.
        /// </summary>
        /// <param name="triangle3_1">The first triangle to assign.</param>
        /// <param name="triangle3_2">The second triangle to assign.</param>
        /// <param name="triangle3_3">The third triangle to assign.</param>
        /// <param name="triangle3_4">The fourth triangle to assign.</param>
        public Triangulation3(Triangle3 triangle3_1, Triangle3 triangle3_2, Triangle3 triangle3_3, Triangle3 triangle3_4)
        {
            trinagle_1 = triangle3_1;
            trinagle_2 = triangle3_2;
            trinagle_3 = triangle3_3;
            trinagle_4 = triangle3_4;
            trinagle_5 = new Triangle3();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangulation3"/> struct with five specified triangles.
        /// </summary>
        /// <param name="triangle3_1">The first triangle to assign.</param>
        /// <param name="triangle3_2">The second triangle to assign.</param>
        /// <param name="triangle3_3">The third triangle to assign.</param>
        /// <param name="triangle3_4">The fourth triangle to assign.</param>
        /// <param name="triangle3_5">The fifth triangle to assign.</param>
        public Triangulation3(Triangle3 triangle3_1, Triangle3 triangle3_2, Triangle3 triangle3_3, Triangle3 triangle3_4, Triangle3 triangle3_5)
        {
            trinagle_1 = triangle3_1;
            trinagle_2 = triangle3_2;
            trinagle_3 = triangle3_3;
            trinagle_4 = triangle3_4;
            trinagle_5 = triangle3_5;
        }

        /// <summary>
        /// Checks if the triangulation contains NaN values by evaluating the first triangle.
        /// </summary>
        /// <returns>True if the first triangle is NaN; otherwise, false.</returns>
        public bool IsNaN()
        {
            return trinagle_1.IsNaN();
        }
    }
}