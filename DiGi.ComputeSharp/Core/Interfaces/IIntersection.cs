namespace DiGi.ComputeSharp.Core.Interfaces
{
    public interface IIntersection : IResult
    {
    }

    public interface IIntersection<TGeometry> : IIntersection where TGeometry : IGeometry
    {
    }
}
