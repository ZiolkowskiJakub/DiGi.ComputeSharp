using DiGi.ComputeSharp.Spatial.Classes;
using DiGi.ComputeSharp.Spatial.Enums;

namespace DiGi.ComputeSharp.Spatial
{
    public static partial class Create
    {        
        public static List<Coordinate3> Coordinate3s(Line3 line, LineAlignment lineAlignment, double distance, bool includeShorter, double tolerance)
        {
            double length = line.GetLength(tolerance);
            if(length < tolerance)
            {
                if(includeShorter)
                {
                    return [line.Start, line.End];
                }

                return null;
            }

            int count = Convert.ToInt32(Math.Truncate(length / distance));

            List<Coordinate3> result = null;

            if (lineAlignment == LineAlignment.Start)
            {
                Coordinate3 vector = line.GetDirection(tolerance).Multiply(distance);
                Coordinate3 point = line.Start;

                result = new List<Coordinate3>() { point };
                
                for (int i = 0; i < count; i++)
                {
                    point = point.GetMoved(vector);    
                    result.Add(point);
                }

                if(includeShorter && point.GetDistance(line.End, tolerance) > tolerance)
                {
                    result.Add(line.End);
                }
            }
            else if(lineAlignment == LineAlignment.End)
            {
                Coordinate3 vector = line.GetDirection(tolerance).GetInversed().Multiply(distance);
                Coordinate3 point = line.End;

                result = new List<Coordinate3>() { point };

                for (int i = 0; i < count; i++)
                {
                    point = point.GetMoved(vector);
                    result.Add(point);
                }

                if (includeShorter && point.GetDistance(line.Start, tolerance) > tolerance)
                {
                    result.Add(line.Start);
                }
            }
            else
            {
                Coordinate3 vector = line.GetDirection(tolerance).Multiply(distance);
                Coordinate3 point = line.GetCentroid();

                if (count % 2 != 0)
                {
                    point = point.GetMoved(vector.GetInversed().Multiply(0.5));
                }

                result = new List<Coordinate3>() { point };

                for (int i = 1; i <= count; i++)
                {
                    if (i % 2 == 0)
                    {
                        point = result.First().GetMoved(vector);
                        result.Insert(0, point);
                    }
                    else
                    {
                        point = result.Last().GetMoved(vector);
                        result.Add(point);
                    }

                    vector = vector.GetInversed();
                }

                if(includeShorter)
                {
                    if (point.GetDistance(result.First(), tolerance) > tolerance)
                    {
                        result.Insert(0, line.Start);
                    }

                    if (point.GetDistance(result.Last(), tolerance) > tolerance)
                    {
                        result.Add(line.End);
                    }
                }

            }

            return result;
        }
    }
}
