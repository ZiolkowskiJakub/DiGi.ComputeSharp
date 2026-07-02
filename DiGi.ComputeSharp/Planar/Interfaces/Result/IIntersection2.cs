namespace DiGi.ComputeSharp.Planar.Interfaces
{
    /// <summary>
    /// Represents the result of a geometric intersection operation in the planar (2D) coordinate system.
    /// </summary>
    public interface IIntersection2 : Core.Interfaces.IIntersection
    {
        /// <summary>
        /// Retrieves the geometries resulting from the intersection, optionally overriding the solidity of the result.
        /// </summary>
        /// <param name="solid">An optional override for whether the result should be treated as a solid geometry.</param>
        /// <returns>An array of <see cref="IGeometry2"/> objects representing the intersection, or null if no valid geometry exists.</returns>
        IGeometry2[]? GetIntersectionGeometries(bool? solid = null);
    }
}
