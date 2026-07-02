#### [DiGi\.ComputeSharp](index.md 'index')

## DiGi\.ComputeSharp\.Planar\.Interfaces Namespace
### Interfaces

<a name='DiGi.ComputeSharp.Planar.Interfaces.IGeometry2'></a>

## IGeometry2 Interface

Defines the contract for a two\-dimensional geometric entity within the planar coordinate system\.
This interface extends the base geometry definitions to provide 2D\-specific spatial properties and behaviors\.

```csharp
public interface IGeometry2 : DiGi.ComputeSharp.Core.Interfaces.IGeometry
```

Derived  
↳ [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
↳ [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')  
↳ [Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')

Implements [IGeometry](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IGeometry 'DiGi\.ComputeSharp\.Core\.Interfaces\.IGeometry')

<a name='DiGi.ComputeSharp.Planar.Interfaces.IIntersection2'></a>

## IIntersection2 Interface

Represents the result of a geometric intersection operation in the planar \(2D\) coordinate system\.

```csharp
public interface IIntersection2 : DiGi.ComputeSharp.Core.Interfaces.IIntersection, DiGi.ComputeSharp.Core.Interfaces.IResult
```

Derived  
↳ [Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection')

Implements [IIntersection](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IIntersection 'DiGi\.ComputeSharp\.Core\.Interfaces\.IIntersection'), [IResult](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IResult 'DiGi\.ComputeSharp\.Core\.Interfaces\.IResult')
### Methods

<a name='DiGi.ComputeSharp.Planar.Interfaces.IIntersection2.GetIntersectionGeometries(System.Nullable_bool_)'></a>

## IIntersection2\.GetIntersectionGeometries\(Nullable\<bool\>\) Method

Retrieves the geometries resulting from the intersection, optionally overriding the solidity of the result\.

```csharp
DiGi.ComputeSharp.Planar.Interfaces.IGeometry2[]? GetIntersectionGeometries(System.Nullable<bool> solid=null);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Interfaces.IIntersection2.GetIntersectionGeometries(System.Nullable_bool_).solid'></a>

`solid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional override for whether the result should be treated as a solid geometry\.

#### Returns
[IGeometry2](DiGi.ComputeSharp.Planar.Interfaces.md#DiGi.ComputeSharp.Planar.Interfaces.IGeometry2 'DiGi\.ComputeSharp\.Planar\.Interfaces\.IGeometry2')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of [IGeometry2](DiGi.ComputeSharp.Planar.Interfaces.md#DiGi.ComputeSharp.Planar.Interfaces.IGeometry2 'DiGi\.ComputeSharp\.Planar\.Interfaces\.IGeometry2') objects representing the intersection, or null if no valid geometry exists\.