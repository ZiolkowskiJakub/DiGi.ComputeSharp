#### [DiGi\.ComputeSharp](index.md 'index')

## DiGi\.ComputeSharp\.Spatial\.Classes Namespace
### Structs

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection'></a>

## Line3Intersection Struct

Represents the result of an intersection operation in 3D space, which can be a single point, two points, or a line segment\.

```csharp
public readonly struct Line3Intersection : DiGi.ComputeSharp.Spatial.Interfaces.IIntersection3, DiGi.ComputeSharp.Core.Interfaces.IIntersection, DiGi.ComputeSharp.Core.Interfaces.IResult
```

Implements [DiGi\.ComputeSharp\.Spatial\.Interfaces\.IIntersection3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.interfaces.iintersection3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IIntersection3'), [IIntersection](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IIntersection 'DiGi\.ComputeSharp\.Core\.Interfaces\.IIntersection'), [IResult](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IResult 'DiGi\.ComputeSharp\.Core\.Interfaces\.IResult')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection()'></a>

## Line3Intersection\(\) Constructor

Initializes a new instance of the [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection') struct with default values\.

```csharp
public Line3Intersection();
```

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3Intersection\(Bool, Coordinate3\) Constructor

Initializes a new instance of the [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection') struct with specified solidity and the first point\.

```csharp
public Line3Intersection(DiGi.ComputeSharp.Core.Classes.Bool solid, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).solid'></a>

`solid` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

The solidity flag for the intersection\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3Intersection\(Bool, Coordinate3, Coordinate3\) Constructor

Initializes a new instance of the [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection') struct with specified solidity and two coordinate points\.

```csharp
public Line3Intersection(DiGi.ComputeSharp.Core.Classes.Bool solid, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).solid'></a>

`solid` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

The solidity flag for the intersection\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3Intersection\(Coordinate3\) Constructor

Initializes a new instance of the [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection') struct with the first point\.

```csharp
public Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3Intersection\(Coordinate3, Coordinate3\) Constructor

Initializes a new instance of the [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection') struct with two coordinate points\.

```csharp
public Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3)'></a>

## Line3Intersection\(Line3\) Constructor

Initializes a new instance of the [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection') struct from an existing line\.

```csharp
public Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3 line);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3).line'></a>

`line` [DiGi\.ComputeSharp\.Spatial\.Classes\.Line3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The line to use for initialization\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Point_1'></a>

## Line3Intersection\.Point\_1 Field

The first coordinate point of the intersection\.

```csharp
public readonly Coordinate3 Point_1;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Point_2'></a>

## Line3Intersection\.Point\_2 Field

The second coordinate point of the intersection, used when the result is a line segment\.

```csharp
public readonly Coordinate3 Point_2;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Solid'></a>

## Line3Intersection\.Solid Field

Indicates whether the intersection result is a solid line segment rather than discrete points\.

```csharp
public readonly Bool Solid;
```

#### Field Value
[Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.GetIntersectionGeometries(System.Nullable_bool_)'></a>

## Line3Intersection\.GetIntersectionGeometries\(Nullable\<bool\>\) Method

Retrieves the geometries resulting from the intersection, optionally overriding the solidity of the result\.

```csharp
public DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3[]? GetIntersectionGeometries(System.Nullable<bool> solid=null);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.GetIntersectionGeometries(System.Nullable_bool_).solid'></a>

`solid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional override for whether the result should be treated as a solid geometry\.

Implements [GetIntersectionGeometries\(Nullable&lt;bool&gt;\)](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.interfaces.iintersection3.getintersectiongeometries#digi-computesharp-spatial-interfaces-iintersection3-getintersectiongeometries(system-nullable{system-boolean}) 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IIntersection3\.GetIntersectionGeometries\(System\.Nullable\{System\.Boolean\}\)')

#### Returns
[DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.interfaces.igeometry3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of [DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.interfaces.igeometry3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3') objects representing the intersection, or null if the primary point is NaN\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.GetLine()'></a>

## Line3Intersection\.GetLine\(\) Method

Converts the intersection result into a line segment if it is marked as solid and contains valid points\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Line3 GetLine();
```

#### Returns
[DiGi\.ComputeSharp\.Spatial\.Classes\.Line3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')  
A [DiGi\.ComputeSharp\.Spatial\.Classes\.Line3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') representing the intersection line, or an empty line if not applicable\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.IsNaN()'></a>

## Line3Intersection\.IsNaN\(\) Method

Determines whether the intersection result is Not\-a\-Number \(NaN\)\.

```csharp
public bool IsNaN();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the first point is NaN; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection'></a>

## Triangle3Intersection Struct

Represents a 3D triangle intersection result containing up to six coordinates and a solidity flag\.

```csharp
public struct Triangle3Intersection : DiGi.ComputeSharp.Spatial.Interfaces.IIntersection3, DiGi.ComputeSharp.Core.Interfaces.IIntersection, DiGi.ComputeSharp.Core.Interfaces.IResult
```

Implements [DiGi\.ComputeSharp\.Spatial\.Interfaces\.IIntersection3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.interfaces.iintersection3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IIntersection3'), [IIntersection](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IIntersection 'DiGi\.ComputeSharp\.Core\.Interfaces\.IIntersection'), [IResult](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IResult 'DiGi\.ComputeSharp\.Core\.Interfaces\.IResult')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection()'></a>

## Triangle3Intersection\(\) Constructor

Initializes a new instance of the [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') struct with default values\.

```csharp
public Triangle3Intersection();
```

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Triangle3Intersection\(Bool, Coordinate3\) Constructor

Initializes a new instance of the [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') struct with a solidity flag and one point\.

```csharp
public Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool solid, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).solid'></a>

`solid` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

Whether the geometry is solid\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Triangle3Intersection\(Bool, Coordinate3, Coordinate3\) Constructor

Initializes a new instance of the [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') struct with a solidity flag and two points\.

```csharp
public Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool solid, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).solid'></a>

`solid` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

Whether the geometry is solid\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Triangle3Intersection\(Bool, Coordinate3, Coordinate3, Coordinate3\) Constructor

Initializes a new instance of the [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') struct with a solidity flag and three points\.

```csharp
public Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool solid, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).solid'></a>

`solid` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

Whether the geometry is solid\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_3'></a>

`point_3` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The third coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Triangle3Intersection\(Bool, Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3\) Constructor

Initializes a new instance of the [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') struct with a solidity flag and six points\.

```csharp
public Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool solid, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_3, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_4, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_5, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_6);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).solid'></a>

`solid` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

Whether the geometry is solid\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_3'></a>

`point_3` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The third coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_4'></a>

`point_4` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The fourth coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_5'></a>

`point_5` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The fifth coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_6'></a>

`point_6` [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The sixth coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3)'></a>

## Triangle3Intersection\(Line3\) Constructor

Initializes a new instance of the [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') struct from a [DiGi\.ComputeSharp\.Spatial\.Classes\.Line3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')\.

```csharp
public Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3 line);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3).line'></a>

`line` [DiGi\.ComputeSharp\.Spatial\.Classes\.Line3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The line used to initialize the intersection points\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3Intersection)'></a>

## Triangle3Intersection\(Line3Intersection\) Constructor

Initializes a new instance of the [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') struct from a [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection')\.

```csharp
public Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3Intersection line3Intersection);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3Intersection).line3Intersection'></a>

`line3Intersection` [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection')

The line intersection to convert from\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Point_1'></a>

## Triangle3Intersection\.Point\_1 Field

The first coordinate of the intersection\.

```csharp
public readonly Coordinate3 Point_1;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Point_2'></a>

## Triangle3Intersection\.Point\_2 Field

The second coordinate of the intersection\.

```csharp
public readonly Coordinate3 Point_2;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Point_3'></a>

## Triangle3Intersection\.Point\_3 Field

The third coordinate of the intersection\.

```csharp
public readonly Coordinate3 Point_3;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Point_4'></a>

## Triangle3Intersection\.Point\_4 Field

The fourth coordinate of the intersection\.

```csharp
public readonly Coordinate3 Point_4;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Point_5'></a>

## Triangle3Intersection\.Point\_5 Field

The fifth coordinate of the intersection\.

```csharp
public readonly Coordinate3 Point_5;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Point_6'></a>

## Triangle3Intersection\.Point\_6 Field

The sixth coordinate of the intersection\.

```csharp
public readonly Coordinate3 Point_6;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Solid'></a>

## Triangle3Intersection\.Solid Field

Indicates whether the intersection is considered a solid geometry\.

```csharp
public readonly Bool Solid;
```

#### Field Value
[Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.GetIntersectionGeometries(System.Nullable_bool_)'></a>

## Triangle3Intersection\.GetIntersectionGeometries\(Nullable\<bool\>\) Method

Retrieves the intersection geometries based on the available points and solidity\.

```csharp
public DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3[]? GetIntersectionGeometries(System.Nullable<bool> solid=null);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.GetIntersectionGeometries(System.Nullable_bool_).solid'></a>

`solid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

Optional override for the solidity flag\.

Implements [GetIntersectionGeometries\(Nullable&lt;bool&gt;\)](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.interfaces.iintersection3.getintersectiongeometries#digi-computesharp-spatial-interfaces-iintersection3-getintersectiongeometries(system-nullable{system-boolean}) 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IIntersection3\.GetIntersectionGeometries\(System\.Nullable\{System\.Boolean\}\)')

#### Returns
[DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.interfaces.igeometry3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of 3D geometries, or null if no valid points exist\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.IsNaN()'></a>

## Triangle3Intersection\.IsNaN\(\) Method

Determines whether the intersection is not a number \(NaN\), indicating it is invalid or empty\.

```csharp
public bool IsNaN();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the first point is NaN; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3'></a>

## Triangulation3 Struct

Represents a 3D triangulation consisting of up to five triangles\.

```csharp
public readonly struct Triangulation3
```
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3()'></a>

## Triangulation3\(\) Constructor

Initializes a new instance of the [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3') struct with default values\.

```csharp
public Triangulation3();
```

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3)'></a>

## Triangulation3\(Triangle3\) Constructor

Initializes a new instance of the [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3') struct with one specified triangle\.

```csharp
public Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3'></a>

`triangle3` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The first triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3)'></a>

## Triangulation3\(Triangle3, Triangle3\) Constructor

Initializes a new instance of the [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3') struct with two specified triangles\.

```csharp
public Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_1, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_1'></a>

`triangle3_1` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The first triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_2'></a>

`triangle3_2` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The second triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3)'></a>

## Triangulation3\(Triangle3, Triangle3, Triangle3\) Constructor

Initializes a new instance of the [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3') struct with three specified triangles\.

```csharp
public Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_1, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_2, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_1'></a>

`triangle3_1` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The first triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_2'></a>

`triangle3_2` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The second triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_3'></a>

`triangle3_3` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The third triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3)'></a>

## Triangulation3\(Triangle3, Triangle3, Triangle3, Triangle3\) Constructor

Initializes a new instance of the [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3') struct with four specified triangles\.

```csharp
public Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_1, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_2, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_3, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_4);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_1'></a>

`triangle3_1` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The first triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_2'></a>

`triangle3_2` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The second triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_3'></a>

`triangle3_3` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The third triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_4'></a>

`triangle3_4` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The fourth triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3)'></a>

## Triangulation3\(Triangle3, Triangle3, Triangle3, Triangle3, Triangle3\) Constructor

Initializes a new instance of the [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3') struct with five specified triangles\.

```csharp
public Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_1, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_2, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_3, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_4, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_5);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_1'></a>

`triangle3_1` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The first triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_2'></a>

`triangle3_2` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The second triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_3'></a>

`triangle3_3` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The third triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_4'></a>

`triangle3_4` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The fourth triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_5'></a>

`triangle3_5` [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The fifth triangle to assign\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.triangle_1'></a>

## Triangulation3\.triangle\_1 Field

The first triangle in the triangulation\.

```csharp
public readonly Triangle3 triangle_1;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.triangle_2'></a>

## Triangulation3\.triangle\_2 Field

The second triangle in the triangulation\.

```csharp
public readonly Triangle3 triangle_2;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.triangle_3'></a>

## Triangulation3\.triangle\_3 Field

The third triangle in the triangulation\.

```csharp
public readonly Triangle3 triangle_3;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.triangle_4'></a>

## Triangulation3\.triangle\_4 Field

The fourth triangle in the triangulation\.

```csharp
public readonly Triangle3 triangle_4;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.triangle_5'></a>

## Triangulation3\.triangle\_5 Field

The fifth triangle in the triangulation\.

```csharp
public readonly Triangle3 triangle_5;
```

#### Field Value
[DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.IsNaN()'></a>

## Triangulation3\.IsNaN\(\) Method

Checks if the triangulation contains NaN values by evaluating the first triangle\.

```csharp
public bool IsNaN();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the first triangle is NaN; otherwise, false\.