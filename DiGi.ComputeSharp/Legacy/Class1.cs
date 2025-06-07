using System.Numerics;

namespace DiGi.ComputeSharp.Legacy
{

    public static partial class Test
    {
        public static bool IntersectRayTriangle(
        Vector3 origin,
        Vector3 direction,
        Vector3 v0,
        Vector3 v1,
        Vector3 v2,
        out float t,
        out Vector3 intersection)
        {
            const float EPSILON = 1e-6f;
            t = 0;
            intersection = Vector3.Zero;

            Vector3 edge1 = v1 - v0;
            Vector3 edge2 = v2 - v0;

            Vector3 h = Vector3.Cross(direction, edge2);
            float a = Vector3.Dot(edge1, h);

            if (a > -EPSILON && a < EPSILON)
                return false; // Ray is parallel to triangle

            float f = 1.0f / a;
            Vector3 s = origin - v0;
            float u = f * Vector3.Dot(s, h);

            if (u < 0.0 || u > 1.0)
                return false;

            Vector3 q = Vector3.Cross(s, edge1);
            float v = f * Vector3.Dot(direction, q);

            if (v < 0.0 || u + v > 1.0)
                return false;

            t = f * Vector3.Dot(edge2, q);

            if (t > EPSILON)
            {
                intersection = origin + t * direction;
                return true;
            }

            return false; // Line intersects, but not a ray
        }
    }
}
