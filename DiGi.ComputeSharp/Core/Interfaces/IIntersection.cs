namespace DiGi.ComputeSharp.Core.Interfaces
{
    /// <summary>
    /// Represents the result of a geometric intersection operation.
    /// </summary>
    public interface IIntersection : IResult
    {
    }

    /// <summary>
    /// Represents the result of a geometric intersection operation for a specific geometry type.
    /// </summary>
    /// <typeparam name="TGeometry">The type of geometry resulting from the intersection.</typeparam>
    public interface IIntersection<TGeometry> : IIntersection where TGeometry : IGeometry
    {
    }
}