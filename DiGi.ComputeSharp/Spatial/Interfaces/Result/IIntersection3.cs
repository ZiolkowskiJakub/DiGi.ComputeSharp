namespace DiGi.ComputeSharp.Spatial.Interfaces
{
    /// <summary>
    /// Defines the contract for an intersection result in a three-dimensional spatial system.
    /// </summary>
    public interface IIntersection3 : Core.Interfaces.IIntersection
    {
        /// <summary>
        /// Retrieves the geometric entities resulting from the intersection.
        /// </summary>
        /// <param name="solid">An optional filter to specify whether to retrieve solid geometries, boundary-only geometries, or all geometries.</param>
        /// <returns>An array of <see cref="IGeometry3"/> objects representing the intersection result, or <see langword="null"/> if no geometries are available.</returns>
        IGeometry3[]? GetIntersectionGeometries(bool? solid = null);
    }
}