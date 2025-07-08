namespace DiGi.ComputeSharp.Spatial.Interfaces
{
    public interface IIntersection3 : Core.Interfaces.IIntersection
    {
        IGeometry3[] GetIntersectionGeometries(bool? solid = null);
    }
}
