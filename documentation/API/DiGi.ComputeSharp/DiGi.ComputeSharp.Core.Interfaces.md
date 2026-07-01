#### [DiGi\.ComputeSharp](index.md 'index')

## DiGi\.ComputeSharp\.Core\.Interfaces Namespace
### Interfaces

<a name='DiGi.ComputeSharp.Core.Interfaces.IGeometry'></a>

## IGeometry Interface

Defines the base contract for geometry\-related types within the ComputeSharp core framework\.

```csharp
public interface IGeometry
```

Derived  
↳ [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
↳ [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')  
↳ [IGeometry2](DiGi.ComputeSharp.Planar.Interfaces.md#DiGi.ComputeSharp.Planar.Interfaces.IGeometry2 'DiGi\.ComputeSharp\.Planar\.Interfaces\.IGeometry2')

<a name='DiGi.ComputeSharp.Core.Interfaces.IIntersection'></a>

## IIntersection Interface

Represents the result of a geometric intersection operation\.

```csharp
public interface IIntersection : DiGi.ComputeSharp.Core.Interfaces.IResult
```

Derived  
↳ [IIntersection&lt;TGeometry&gt;](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IIntersection_TGeometry_ 'DiGi\.ComputeSharp\.Core\.Interfaces\.IIntersection\<TGeometry\>')  
↳ [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection')  
↳ [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')

Implements [IResult](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IResult 'DiGi\.ComputeSharp\.Core\.Interfaces\.IResult')

<a name='DiGi.ComputeSharp.Core.Interfaces.IIntersection_TGeometry_'></a>

## IIntersection\<TGeometry\> Interface

Represents the result of a geometric intersection operation for a specific geometry type\.

```csharp
public interface IIntersection<TGeometry> : DiGi.ComputeSharp.Core.Interfaces.IIntersection, DiGi.ComputeSharp.Core.Interfaces.IResult
    where TGeometry : DiGi.ComputeSharp.Core.Interfaces.IGeometry
```
#### Type parameters

<a name='DiGi.ComputeSharp.Core.Interfaces.IIntersection_TGeometry_.TGeometry'></a>

`TGeometry`

The type of geometry resulting from the intersection\.

Implements [IIntersection](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IIntersection 'DiGi\.ComputeSharp\.Core\.Interfaces\.IIntersection'), [IResult](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IResult 'DiGi\.ComputeSharp\.Core\.Interfaces\.IResult')

<a name='DiGi.ComputeSharp.Core.Interfaces.IResult'></a>

## IResult Interface

Defines a marker interface for objects that represent the result of a computation operation within the ComputeSharp framework\.

```csharp
public interface IResult
```

Derived  
↳ [IIntersection](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IIntersection 'DiGi\.ComputeSharp\.Core\.Interfaces\.IIntersection')  
↳ [IIntersection&lt;TGeometry&gt;](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IIntersection_TGeometry_ 'DiGi\.ComputeSharp\.Core\.Interfaces\.IIntersection\<TGeometry\>')  
↳ [ITriangulation](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.ITriangulation 'DiGi\.ComputeSharp\.Core\.Interfaces\.ITriangulation')  
↳ [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection')  
↳ [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')

<a name='DiGi.ComputeSharp.Core.Interfaces.ITriangulation'></a>

## ITriangulation Interface

Defines the contract for a triangulation result, extending the base result functionality\.

```csharp
public interface ITriangulation : DiGi.ComputeSharp.Core.Interfaces.IResult
```

Implements [IResult](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IResult 'DiGi\.ComputeSharp\.Core\.Interfaces\.IResult')