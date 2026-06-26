using ComputeSharp;
using DiGi.ComputeSharp.Spatial.Classes;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Query
    {
        /// <summary>
        /// Determines which of the specified points are located inside the volume defined by the provided triangle mesh.
        /// </summary>
        /// <param name="graphicDevice">The graphics device used to perform the spatial computation.</param>
        /// <param name="points">The collection of 3D coordinates to evaluate.</param>
        /// <param name="triangles">The read-only buffer containing the triangles that define the boundary of the volume.</param>
        /// <returns>A list of indices of the points that are inside the volume, or null if the operation fails or no points are found.</returns>
        public static List<int>? Inside(this GraphicsDevice graphicDevice, IEnumerable<Coordinate3>? points, ReadOnlyBuffer<Triangle3>? triangles)
        {
            if (points == null || triangles == null || triangles.Length == 0 || graphicDevice == null)
            {
                return null;
            }

            using ReadOnlyBuffer<Coordinate3> points_Temp = graphicDevice.AllocateReadOnlyBuffer(points.ToArray());
            using ReadWriteBuffer<int> result = graphicDevice.AllocateReadWriteBuffer<int>(points_Temp.Length);

            graphicDevice.For(points_Temp.Length, new Coordinate3InsideComputeShader(points_Temp, triangles, result));

            return Core.Create.List(result);
        }

        /// <summary>
        /// Determines whether a specified point is located inside the volume defined by the provided triangles.
        /// </summary>
        /// <param name="graphicDevice">The graphics device used for the operation.</param>
        /// <param name="point">The 3D coordinate to test.</param>
        /// <param name="triangles">A read-only buffer containing the triangles that define the boundary of the volume.</param>
        /// <returns>An integer indicating the containment status of the point relative to the volume.</returns>
        public static int Inside(this GraphicsDevice graphicDevice, Coordinate3 point, ReadOnlyBuffer<Triangle3>? triangles)
        {
            List<int>? result = Inside(graphicDevice, [point], triangles);
            if (result == null || result.Count == 0)
            {
                return -1;
            }

            return result[0];
        }

        /// <summary>
        /// Determines which points from a provided collection are located inside a closed volume defined by a set of triangles.
        /// </summary>
        /// <param name="points">The collection of 3D coordinates to be tested for containment.</param>
        /// <param name="triangles">The collection of triangles defining the boundary of the volume.</param>
        /// <returns>A list containing the indices of the points that are inside the volume, or null if the operation cannot be performed.</returns>
        public static List<int>? Inside(IEnumerable<Coordinate3>? points, IEnumerable<Triangle3>? triangles)
        {
            if (points == null || triangles == null)
            {
                return null;
            }

            GraphicsDevice graphicDevice = GraphicsDevice.GetDefault();
            if (graphicDevice == null)
            {
                return null;
            }

            using ReadOnlyBuffer<Triangle3> triangle3s_Temp = graphicDevice.AllocateReadOnlyBuffer(triangles.ToArray());

            return Inside(graphicDevice, points, triangle3s_Temp);
        }

        /// <summary>
        /// Determines whether a specified 3D point is located inside a volume defined by a collection of triangles.
        /// </summary>
        /// <param name="point">The coordinate of the point to test.</param>
        /// <param name="triangles">The collection of triangles that define the boundary of the volume.</param>
        /// <returns>An integer indicating the containment status of the point relative to the volume.</returns>
        public static int Inside(Coordinate3 point, IEnumerable<Triangle3>? triangles)
        {
            if (point.IsNaN() || triangles == null)
            {
                return -1;
            }

            GraphicsDevice graphicDevice = GraphicsDevice.GetDefault();
            if (graphicDevice == null)
            {
                return -1;
            }

            using ReadOnlyBuffer<Triangle3> triangle3s_Temp = graphicDevice.AllocateReadOnlyBuffer(triangles.ToArray());

            return Inside(graphicDevice, point, triangle3s_Temp);
        }
    }
}