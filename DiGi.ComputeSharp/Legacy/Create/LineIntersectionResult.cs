using DiGi.ComputeSharp.Legacy.Classes;
using DiGi.ComputeSharp.Legacy.Classes.Result;

namespace DiGi.ComputeSharp.Legacy
{
    public static partial class Create
    {
        public static LineIntersectionResult LineIntersectionResult(Line3 line3, Triangle3 triangle, float tolerance)
        {
            Vector3 vector_1 = new Vector3(triangle.Point_1, triangle.Point_2);
            Vector3 vector_2 = new Vector3(triangle.Point_1, triangle.Point_3);

            Vector3 direction = line3.Direction;

            Vector3 crossProduct = direction.CrossProduct(vector_2);

            float factor = vector_1.DotProduct(crossProduct);

            if (factor > -tolerance && factor < tolerance)
            {
                return new LineIntersectionResult();
            }

            factor = 1.0f / factor;

            Vector3 vector;

            Point3 origin = line3.Origin;

            vector = new Vector3(triangle.Point_1, origin);

            float factor_1 = factor * vector.DotProduct(crossProduct);
            if (factor_1 < 0.0 || factor_1 > 1.0)
            {
                return new LineIntersectionResult();
            }

            vector = vector.CrossProduct(vector_1);
            float factor_2 = factor * direction.DotProduct(vector);
            if (factor_2 < 0.0 || factor_1 + factor_2 > 1.0)
            {
                return new LineIntersectionResult();
            }

            factor = factor * vector_2.DotProduct(vector);

            if (factor < tolerance)
            {
                return new LineIntersectionResult();
            }

            return new LineIntersectionResult(line3, triangle, origin.Add(direction.Multiply(factor)), factor);
        }
    }
}
