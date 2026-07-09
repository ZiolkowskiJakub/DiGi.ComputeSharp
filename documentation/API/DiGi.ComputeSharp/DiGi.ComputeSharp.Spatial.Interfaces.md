#### [DiGi\.ComputeSharp](DiGi.ComputeSharp.Overview.md 'DiGi\.ComputeSharp\.Overview')

## DiGi\.ComputeSharp\.Spatial\.Interfaces Namespace
### Interfaces

<a name='DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3'></a>

## IGeometry3 Interface

Defines the contract for a three\-dimensional geometric entity in a spatial coordinate system\.

```csharp
public interface IGeometry3 : DiGi.ComputeSharp.Core.Interfaces.IGeometry
```

Derived  
↳ [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
↳ [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')  
↳ [Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')  
↳ [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

Implements [IGeometry](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IGeometry 'DiGi\.ComputeSharp\.Core\.Interfaces\.IGeometry')

<a name='DiGi.ComputeSharp.Spatial.Interfaces.IIntersection3'></a>

## IIntersection3 Interface

Defines the contract for an intersection result in a three\-dimensional spatial system\.

```csharp
public interface IIntersection3 : DiGi.ComputeSharp.Core.Interfaces.IIntersection, DiGi.ComputeSharp.Core.Interfaces.IResult
```

Derived  
↳ [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection')  
↳ [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')

Implements [IIntersection](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IIntersection 'DiGi\.ComputeSharp\.Core\.Interfaces\.IIntersection'), [IResult](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IResult 'DiGi\.ComputeSharp\.Core\.Interfaces\.IResult')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Interfaces.IIntersection3.GetIntersectionGeometries(System.Nullable_bool_)'></a>

## IIntersection3\.GetIntersectionGeometries\(Nullable\<bool\>\) Method

Retrieves the geometric entities resulting from the intersection\.

```csharp
DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3[]? GetIntersectionGeometries(System.Nullable<bool> solid=null);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Interfaces.IIntersection3.GetIntersectionGeometries(System.Nullable_bool_).solid'></a>

`solid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional filter to specify whether to retrieve solid geometries, boundary\-only geometries, or all geometries\.

#### Returns
[IGeometry3](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of [IGeometry3](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3') objects representing the intersection result, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if no geometries are available\.

<a name='DiGi.ComputeSharp.Spatial.Interfaces.ITriangulation3'></a>

## ITriangulation3 Interface

Defines the contract for a three\-dimensional triangulation result in a spatial coordinate system\.

```csharp
public interface ITriangulation3 : DiGi.ComputeSharp.Core.Interfaces.ITriangulation, DiGi.ComputeSharp.Core.Interfaces.IResult
```

Implements [ITriangulation](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.ITriangulation 'DiGi\.ComputeSharp\.Core\.Interfaces\.ITriangulation'), [IResult](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IResult 'DiGi\.ComputeSharp\.Core\.Interfaces\.IResult')