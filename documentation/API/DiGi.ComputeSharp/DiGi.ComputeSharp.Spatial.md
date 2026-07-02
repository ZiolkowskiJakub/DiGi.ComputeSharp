#### [DiGi\.ComputeSharp](index.md 'index')

## DiGi\.ComputeSharp\.Spatial Namespace
### Classes

<a name='DiGi.ComputeSharp.Spatial.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.ComputeSharp.Spatial.Create.Coordinate3s(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Enums.LineAlignment,double,bool,double)'></a>

## Create\.Coordinate3s\(Line3, LineAlignment, double, bool, double\) Method

Generates a sequence of 3D coordinates along a specified line based on the provided distance and alignment\.

```csharp
public static System.Collections.Generic.List<DiGi.ComputeSharp.Spatial.Classes.Coordinate3>? Coordinate3s(DiGi.ComputeSharp.Spatial.Classes.Line3 line, DiGi.ComputeSharp.Spatial.Enums.LineAlignment lineAlignment, double distance, bool includeShorter, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.Coordinate3s(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Enums.LineAlignment,double,bool,double).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The line along which to generate coordinates\.

<a name='DiGi.ComputeSharp.Spatial.Create.Coordinate3s(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Enums.LineAlignment,double,bool,double).lineAlignment'></a>

`lineAlignment` [LineAlignment](DiGi.ComputeSharp.Spatial.Enums.md#DiGi.ComputeSharp.Spatial.Enums.LineAlignment 'DiGi\.ComputeSharp\.Spatial\.Enums\.LineAlignment')

The alignment used to distribute the points \(Start, End, or Centered\)\.

<a name='DiGi.ComputeSharp.Spatial.Create.Coordinate3s(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Enums.LineAlignment,double,bool,double).distance'></a>

`distance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance between each generated coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Create.Coordinate3s(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Enums.LineAlignment,double,bool,double).includeShorter'></a>

`includeShorter` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to include endpoints when the total length is not a perfect multiple of the distance\.

<a name='DiGi.ComputeSharp.Spatial.Create.Coordinate3s(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Enums.LineAlignment,double,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric calculations and comparisons\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of coordinates along the line, or `null` if the line is shorter than the tolerance and [includeShorter](DiGi.ComputeSharp.Spatial.md#DiGi.ComputeSharp.Spatial.Create.Coordinate3s(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Enums.LineAlignment,double,bool,double).includeShorter 'DiGi\.ComputeSharp\.Spatial\.Create\.Coordinate3s\(DiGi\.ComputeSharp\.Spatial\.Classes\.Line3, DiGi\.ComputeSharp\.Spatial\.Enums\.LineAlignment, double, bool, double\)\.includeShorter') is false\.

<a name='DiGi.ComputeSharp.Spatial.Create.InsertPoint(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Create\.InsertPoint\(Triangle3, Coordinate3, double\) Method

Splits a single triangle at a point that lies at a vertex \(no split\), on an edge \(two triangles\),
or strictly inside it \(three triangles\)\. Every produced triangle inherits the source triangle's
[Solid](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3.Solid 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3\.Solid') flag and includes the point as a vertex\.

```csharp
private static System.Collections.Generic.List<DiGi.ComputeSharp.Spatial.Classes.Triangle3> InsertPoint(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.InsertPoint(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

<a name='DiGi.ComputeSharp.Spatial.Create.InsertPoint(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Create.InsertPoint(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

<a name='DiGi.ComputeSharp.Spatial.Create.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Classes.Line3,double)'></a>

## Create\.Line3Intersection\(Line3, Line3, double\) Method

Calculates the intersection of two 3D lines within a specified tolerance\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Line3Intersection Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3 line_1, DiGi.ComputeSharp.Spatial.Classes.Line3 line_2, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Classes.Line3,double).line_1'></a>

`line_1` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The first 3D line\.

<a name='DiGi.ComputeSharp.Spatial.Create.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Classes.Line3,double).line_2'></a>

`line_2` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The second 3D line\.

<a name='DiGi.ComputeSharp.Spatial.Create.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Classes.Line3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numerical tolerance used for geometric comparisons and proximity checks\.

#### Returns
[Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection')  
A [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection') object containing the intersection result, which may be empty, a single point, or a line segment in the case of coincident lines\.

<a name='DiGi.ComputeSharp.Spatial.Create.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,double)'></a>

## Create\.Line3Intersection\(Line3, Triangle3, double\) Method

Calculates the intersection between a line and a triangle in 3D space based on a specified tolerance\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Line3Intersection Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3 line, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The line to test for intersection\.

<a name='DiGi.ComputeSharp.Spatial.Create.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The triangle to test for intersection\.

<a name='DiGi.ComputeSharp.Spatial.Create.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for floating\-point comparisons and proximity checks\.

#### Returns
[Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection')  
A [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection') object representing the intersection result \(e\.g\., a point, a line segment, or no intersection\)\.

<a name='DiGi.ComputeSharp.Spatial.Create.Line3Intersections(DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,double)'></a>

## Create\.Line3Intersections\(Line3, IEnumerable\<Line3\>, double\) Method

Calculates the intersections between a specified line and a collection of other lines using GPU acceleration\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Line3Intersection>? Line3Intersections(DiGi.ComputeSharp.Spatial.Classes.Line3 line, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Line3>? lines, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.Line3Intersections(DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,double).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The primary line to check for intersections\.

<a name='DiGi.ComputeSharp.Spatial.Create.Line3Intersections(DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,double).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of lines to test against the primary line\.

<a name='DiGi.ComputeSharp.Spatial.Create.Line3Intersections(DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used to determine if two lines are intersecting\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection') results, or `null` if the input line is invalid, the lines collection is empty/null, or the graphics device is unavailable\.

<a name='DiGi.ComputeSharp.Spatial.Create.ToTriangulation3(System.Collections.Generic.List_DiGi.ComputeSharp.Spatial.Classes.Triangle3_)'></a>

## Create\.ToTriangulation3\(List\<Triangle3\>\) Method

Packs a list of up to five sub\-triangles into a [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3')\.

```csharp
private static DiGi.ComputeSharp.Spatial.Classes.Triangulation3 ToTriangulation3(System.Collections.Generic.List<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.ToTriangulation3(System.Collections.Generic.List_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).triangles'></a>

`triangles` [System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')

#### Returns
[Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3')

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Line3,double)'></a>

## Create\.Triangle3Intersection\(Triangle3, Line3, double\) Method

Calculates the intersection between a 3D triangle and a 3D line\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, DiGi.ComputeSharp.Spatial.Classes.Line3 line, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Line3,double).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The 3D triangle to intersect\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Line3,double).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The 3D line to intersect\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Line3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for the intersection calculation\.

#### Returns
[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')  
A [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') representing the result of the intersection\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,bool,bool,double)'></a>

## Create\.Triangle3Intersection\(Triangle3, Triangle3, Coordinate3, bool, bool, double\) Method

Calculates the intersection between two 3D triangles based on a projection vector and specific side constraints\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle_1, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle_2, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector, bool frontSide, bool backSide, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,bool,bool,double).triangle_1'></a>

`triangle_1` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The first triangle\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,bool,bool,double).triangle_2'></a>

`triangle_2` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The second triangle\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,bool,bool,double).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The vector used for projecting the triangles\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,bool,bool,double).frontSide'></a>

`frontSide` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to consider intersections on the front side\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,bool,bool,double).backSide'></a>

`backSide` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Whether to consider intersections on the back side\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,bool,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for precision calculations\.

#### Returns
[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')  
A [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') object containing the intersection details, or an empty instance if constraints are not met\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,double)'></a>

## Create\.Triangle3Intersection\(Triangle3, Triangle3, double\) Method

Calculates the intersection between two 3D triangles based on a specified tolerance\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle_1, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle_2, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).triangle_1'></a>

`triangle_1` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The first triangle\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).triangle_2'></a>

`triangle_2` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The second triangle\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for precision calculations\.

#### Returns
[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')  
A [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') object containing the intersection details\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double)'></a>

## Create\.Triangle3Intersections\(this GraphicsDevice, IEnumerable\<Triangle3\>, ReadOnlyBuffer\<Triangle3\>, double\) Method

Calculates the intersections between a collection of triangles and a GPU read\-only buffer of triangles\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection>? Triangle3Intersections(this ComputeSharp.GraphicsDevice graphicsDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles_1, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles_2, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice') to be used for the computation\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).triangles_1'></a>

`triangles_1` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The first collection of triangles\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).triangles_2'></a>

`triangles_2` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

A read\-only buffer containing the second collection of triangles\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numerical tolerance used for intersection calculations\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') results, or `null` if any input parameters are null\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisDiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double)'></a>

## Create\.Triangle3Intersections\(this Triangle3, IEnumerable\<Triangle3\>, double\) Method

Calculates the intersections between a single triangle and a collection of triangles using GPU acceleration\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection>? Triangle3Intersections(this DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisDiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The source triangle to check for intersections\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisDiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of triangles to intersect against\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisDiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numerical tolerance used for intersection calculations\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') results, or `null` if the input is invalid or no graphics device is available\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisSystem.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double)'></a>

## Create\.Triangle3Intersections\(this IEnumerable\<Triangle3\>, IEnumerable\<Triangle3\>, double\) Method

Calculates the intersections between two collections of triangles using GPU acceleration\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection>? Triangle3Intersections(this System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles_1, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles_2, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisSystem.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).triangles_1'></a>

`triangles_1` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The first collection of triangles\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisSystem.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).triangles_2'></a>

`triangles_2` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The second collection of triangles\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangle3Intersections(thisSystem.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numerical tolerance used for intersection calculations\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') results, or `null` if either input collection is null or empty, or no graphics device is available\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Create\.Triangulation3\(Triangle3, Coordinate3, double\) Method

Splits a triangle into smaller triangles based on a provided point and tolerance\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Triangulation3 Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The original triangle to be triangulated\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The coordinate point used for splitting the triangle\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision tolerance for range, interior, and boundary checks\.

#### Returns
[Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3')  
A [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3') object containing the resulting sub\-triangles; returns an empty triangulation if the point is outside the triangle\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Line3,double)'></a>

## Create\.Triangulation3\(Triangle3, Line3, double\) Method

Splits a triangle into smaller triangles based on its intersection with a provided line and tolerance\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Triangulation3 Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, DiGi.ComputeSharp.Spatial.Classes.Line3 line, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Create.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Line3,double).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The original triangle to be triangulated\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Line3,double).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The line segment used for splitting the triangle\.

<a name='DiGi.ComputeSharp.Spatial.Create.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Line3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision tolerance for intersection and boundary calculations\.

#### Returns
[Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3')  
A [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3') object containing the sub\-triangles; returns an empty triangulation if no intersection occurs\.

<a name='DiGi.ComputeSharp.Spatial.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Modify\.Add\(Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3, double\) Method

Adds a coordinate point based on six reference points and a specified tolerance\.

```csharp
public static bool Add(ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_3, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_4, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_5, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_6, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_1'></a>

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

A reference to the first coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

A reference to the second coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_3'></a>

`point_3` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

A reference to the third coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_4'></a>

`point_4` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

A reference to the fourth coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_5'></a>

`point_5` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

A reference to the fifth coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_6'></a>

`point_6` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

A reference to the sixth coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The coordinate point to be added\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value for the operation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point was successfully added; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Line3Intersection,double)'></a>

## Modify\.Add\(Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3, Line3Intersection, double\) Method

Adds six coordinate points to calculate a 3D line intersection within the specified tolerance\.

```csharp
public static bool Add(ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_3, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_4, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_5, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_6, DiGi.ComputeSharp.Spatial.Classes.Line3Intersection line3Intersection, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Line3Intersection,double).point_1'></a>

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

A reference to the first coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Line3Intersection,double).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

A reference to the second coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Line3Intersection,double).point_3'></a>

`point_3` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

A reference to the third coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Line3Intersection,double).point_4'></a>

`point_4` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

A reference to the fourth coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Line3Intersection,double).point_5'></a>

`point_5` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

A reference to the fifth coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Line3Intersection,double).point_6'></a>

`point_6` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

A reference to the sixth coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Line3Intersection,double).line3Intersection'></a>

`line3Intersection` [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection')

The Line3Intersection object used to store or evaluate the intersection result\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Line3Intersection,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision tolerance for the intersection calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the operation was successful; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Modify\.Add\(Coordinate3, Coordinate3, Coordinate3, double\) Method

Adds a point to the line segment defined by two points within the specified tolerance\.

```csharp
public static bool Add(ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_1'></a>

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first endpoint of the line segment\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second endpoint of the line segment\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The point to be added\.

<a name='DiGi.ComputeSharp.Spatial.Modify.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value for the operation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point was successfully added; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.ComputeSharp.Spatial.Query.Centroid(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Query\.Centroid\(Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3\) Method

Calculates the centroid of up to six 3D coordinates, ignoring any that are NaN\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Centroid(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_3, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_4, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_5, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_6);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Centroid(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.Centroid(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.Centroid(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_3'></a>

`point_3` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The third coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.Centroid(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_4'></a>

`point_4` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The fourth coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.Centroid(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_5'></a>

`point_5` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The fifth coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.Centroid(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_6'></a>

`point_6` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The sixth coordinate\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The calculated centroid as a Coordinate3, or a default Coordinate3 if no valid points are provided\.

<a name='DiGi.ComputeSharp.Spatial.Query.Centroid(DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection)'></a>

## Query\.Centroid\(Triangle3Intersection\) Method

Calculates the centroid of a triangle intersection\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Centroid(DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection triangle3Intersection);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Centroid(DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection).triangle3Intersection'></a>

`triangle3Intersection` [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')

The triangle intersection containing the points to evaluate\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The calculated centroid as a Coordinate3, or a default Coordinate3 if the intersection is NaN\.

<a name='DiGi.ComputeSharp.Spatial.Query.CompareClockwise(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Query\.CompareClockwise\(Coordinate2, Coordinate2, Coordinate2\) Method

Compares two coordinates to determine their clockwise relationship with respect to a center point\.

```csharp
internal static int CompareClockwise(DiGi.ComputeSharp.Planar.Classes.Coordinate2 a, DiGi.ComputeSharp.Planar.Classes.Coordinate2 b, DiGi.ComputeSharp.Planar.Classes.Coordinate2 c);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.CompareClockwise(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).a'></a>

`a` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.CompareClockwise(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).b'></a>

`b` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The second coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.CompareClockwise(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).c'></a>

`c` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The center point\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
\-1 if a is clockwise from b, 1 if a is counter\-clockwise, or 0 if they are collinear\.

<a name='DiGi.ComputeSharp.Spatial.Query.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,int)'></a>

## Query\.Coordinate3\(Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3, int\) Method

Returns a specific Coordinate3 from a set of six coordinates based on the provided index\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Coordinate3(ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate_1, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate_2, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate_3, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate_4, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate_5, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate_6, int index);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,int).coordinate_1'></a>

`coordinate_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,int).coordinate_2'></a>

`coordinate_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,int).coordinate_3'></a>

`coordinate_3` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The third coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,int).coordinate_4'></a>

`coordinate_4` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The fourth coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,int).coordinate_5'></a>

`coordinate_5` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The fifth coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,int).coordinate_6'></a>

`coordinate_6` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The sixth coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Query.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the coordinate to retrieve \(1\-6\)\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The Coordinate3 corresponding to the specified index, or a new default Coordinate3 if the index is out of range\.

<a name='DiGi.ComputeSharp.Spatial.Query.First(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Query\.First\(Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3\) Method

Returns the first coordinate from a set of six provided points\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Coordinate3 First(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_3, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_4, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_5, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_6);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.First(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Query.First(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Query.First(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_3'></a>

`point_3` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The third coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Query.First(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_4'></a>

`point_4` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The fourth coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Query.First(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_5'></a>

`point_5` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The fifth coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Query.First(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_6'></a>

`point_6` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The sixth coordinate point\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The resulting Coordinate3 point\.

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_)'></a>

## Query\.Inside\(Coordinate3, IEnumerable\<Triangle3\>\) Method

Determines whether a specified 3D point is located inside a volume defined by a collection of triangles\.

```csharp
public static int Inside(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3>? triangles);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The coordinate of the point to test\.

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of triangles that define the boundary of the volume\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An integer indicating the containment status of the point relative to the volume\.

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_)'></a>

## Query\.Inside\(IEnumerable\<Coordinate3\>, IEnumerable\<Triangle3\>\) Method

Determines which points from a provided collection are located inside a closed volume defined by a set of triangles\.

```csharp
public static System.Collections.Generic.List<int>? Inside(System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Coordinate3>? points, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3>? triangles);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D coordinates to be tested for containment\.

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of triangles defining the boundary of the volume\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the indices of the points that are inside the volume, or null if the operation cannot be performed\.

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_)'></a>

## Query\.Inside\(this GraphicsDevice, Coordinate3, ReadOnlyBuffer\<Triangle3\>\) Method

Determines whether a specified point is located inside the volume defined by the provided triangles\.

```csharp
public static int Inside(this ComputeSharp.GraphicsDevice graphicDevice, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3>? triangles);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).graphicDevice'></a>

`graphicDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device used for the operation\.

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The 3D coordinate to test\.

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

A read\-only buffer containing the triangles that define the boundary of the volume\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An integer indicating the containment status of the point relative to the volume\.

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_)'></a>

## Query\.Inside\(this GraphicsDevice, IEnumerable\<Coordinate3\>, ReadOnlyBuffer\<Triangle3\>\) Method

Determines which of the specified points are located inside the volume defined by the provided triangle mesh\.

```csharp
public static System.Collections.Generic.List<int>? Inside(this ComputeSharp.GraphicsDevice graphicDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Coordinate3>? points, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3>? triangles);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).graphicDevice'></a>

`graphicDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device used to perform the spatial computation\.

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D coordinates to evaluate\.

<a name='DiGi.ComputeSharp.Spatial.Query.Inside(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer containing the triangles that define the boundary of the volume\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of indices of the points that are inside the volume, or null if the operation fails or no points are found\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool)'></a>

## Query\.Intersect\(Line3, IEnumerable\<Triangle3\>, bool, bool\) Method

Determines whether a specified line segment intersects with any triangle in the provided collection\.

```csharp
public static bool Intersect(DiGi.ComputeSharp.Spatial.Classes.Line3 line3, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3>? triangle3s, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).line3'></a>

`line3` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The line segment to evaluate for intersection\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).triangle3s'></a>

`triangle3s` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of triangles to check against the line segment\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the start point of the line should be included in the intersection test\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the end point of the line should be included in the intersection test\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if an intersection is found; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool)'></a>

## Query\.Intersect\(IEnumerable\<Line3\>, IEnumerable\<Triangle3\>, bool, bool\) Method

Determines whether each line in the provided collection intersects with any of the specified 3D triangles\.

```csharp
public static System.Collections.Generic.List<bool>? Intersect(System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Line3>? line3s, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3>? triangle3s, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).line3s'></a>

`line3s` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D lines to evaluate for intersections\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).triangle3s'></a>

`triangle3s` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D triangles to test against\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, the start point of the line is included in the intersection calculation\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, the end point of the line is included in the intersection calculation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of boolean values indicating the intersection result for each input line, or `null` if the input collections are null\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool)'></a>

## Query\.Intersect\(this GraphicsDevice, Line3, ReadOnlyBuffer\<Triangle3\>, bool, bool\) Method

Determines whether a 3D line intersects any of the triangles contained within the specified read\-only buffer\.

```csharp
public static bool Intersect(this ComputeSharp.GraphicsDevice graphicDevice, DiGi.ComputeSharp.Spatial.Classes.Line3 line3, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangle3s, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).graphicDevice'></a>

`graphicDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device used to perform the intersection calculation\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).line3'></a>

`line3` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The 3D line to test for intersection\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).triangle3s'></a>

`triangle3s` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

A read\-only buffer containing the triangles to be tested against the line\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, includes the start point of the line in the intersection test\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, includes the end point of the line in the intersection test\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if an intersection is found; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool)'></a>

## Query\.Intersect\(this GraphicsDevice, IEnumerable\<Line3\>, ReadOnlyBuffer\<Triangle3\>, bool, bool\) Method

Performs an intersection test between a collection of 3D lines and a buffer of 3D triangles using the specified graphics device\.

```csharp
public static System.Collections.Generic.List<bool>? Intersect(this ComputeSharp.GraphicsDevice? graphicDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Line3>? line3s, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3>? triangle3s, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).graphicDevice'></a>

`graphicDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device used to perform the intersection calculations\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).line3s'></a>

`line3s` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An enumerable collection of 3D lines to be tested for intersections\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).triangle3s'></a>

`triangle3s` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

A read\-only buffer containing the 3D triangles to test against\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, includes the start point of each line in the intersection check\.

<a name='DiGi.ComputeSharp.Spatial.Query.Intersect(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, includes the end point of each line in the intersection check\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of boolean values indicating whether each corresponding line intersects any triangle, or `null` if the operation failed\.

<a name='DiGi.ComputeSharp.Spatial.Query.Round(double,double)'></a>

## Query\.Round\(double, double\) Method

Rounds a double\-precision floating\-point number to the nearest multiple of the specified tolerance\.

```csharp
public static double Round(double value, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Round(double,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numeric value to round\.

<a name='DiGi.ComputeSharp.Spatial.Query.Round(double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision or step size used for rounding\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The rounded double\-precision floating\-point number\.

<a name='DiGi.ComputeSharp.Spatial.Query.SameHalf(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Query\.SameHalf\(Coordinate3, Coordinate3, double\) Method

Determines whether two vectors are oriented in the same half\-space or direction within a specified tolerance\.

```csharp
public static bool SameHalf(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector_1, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector_2, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.SameHalf(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).vector_1'></a>

`vector_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate vector to evaluate\.

<a name='DiGi.ComputeSharp.Spatial.Query.SameHalf(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).vector_2'></a>

`vector_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate vector to evaluate\.

<a name='DiGi.ComputeSharp.Spatial.Query.SameHalf(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision threshold used for the comparison\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the vectors are in the same half; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Query.Shading(thisComputeSharp.GraphicsDevice,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Query\.Shading\(this GraphicsDevice, ReadOnlyBuffer\<Triangle3\>, Coordinate3\) Method

Performs shading calculations on a collection of triangles grouped by shading results, using the specified graphics device\.

```csharp
public static System.Collections.Generic.List<System.Collections.Generic.List<DiGi.ComputeSharp.Spatial.Classes.Triangle3>>? Shading(this ComputeSharp.GraphicsDevice graphicDevice, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangle3s, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Shading(thisComputeSharp.GraphicsDevice,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).graphicDevice'></a>

`graphicDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device used to execute the shading operations\.

<a name='DiGi.ComputeSharp.Spatial.Query.Shading(thisComputeSharp.GraphicsDevice,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).triangle3s'></a>

`triangle3s` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

A read\-only buffer containing the triangle data to be shaded\.

<a name='DiGi.ComputeSharp.Spatial.Query.Shading(thisComputeSharp.GraphicsDevice,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The vector representing the light or view direction for the shading calculation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A nested list of triangles grouped by shading results, or null if the operation could not be completed\.

<a name='DiGi.ComputeSharp.Spatial.Query.Sort(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Query\.Sort\(Plane, Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3, Coordinate3, double\) Method

Sorts six 3D points clockwise relative to their projected centroid on the specified plane\.

```csharp
internal static void Sort(DiGi.ComputeSharp.Spatial.Classes.Plane plane, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_3, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_4, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_5, ref DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_6, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Sort(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).plane'></a>

`plane` [Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')

The projection plane\.

<a name='DiGi.ComputeSharp.Spatial.Query.Sort(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_1'></a>

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate reference\.

<a name='DiGi.ComputeSharp.Spatial.Query.Sort(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate reference\.

<a name='DiGi.ComputeSharp.Spatial.Query.Sort(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_3'></a>

`point_3` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The third coordinate reference\.

<a name='DiGi.ComputeSharp.Spatial.Query.Sort(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_4'></a>

`point_4` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The fourth coordinate reference\.

<a name='DiGi.ComputeSharp.Spatial.Query.Sort(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_5'></a>

`point_5` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The fifth coordinate reference\.

<a name='DiGi.ComputeSharp.Spatial.Query.Sort(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point_6'></a>

`point_6` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The sixth coordinate reference\.

<a name='DiGi.ComputeSharp.Spatial.Query.Sort(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for calculations\.

<a name='DiGi.ComputeSharp.Spatial.Query.Swap(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int,int)'></a>

## Query\.Swap\(Coordinate2, Coordinate2, Coordinate2, int, int\) Method

Swaps two coordinates and their corresponding indices if they are not in clockwise order with respect to the center point\.

```csharp
internal static void Swap(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point, ref DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_1, ref DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_2, ref int index_1, ref int index_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Query.Swap(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int,int).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The center point\.

<a name='DiGi.ComputeSharp.Spatial.Query.Swap(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int,int).point_1'></a>

`point_1` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first coordinate reference\.

<a name='DiGi.ComputeSharp.Spatial.Query.Swap(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int,int).point_2'></a>

`point_2` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The second coordinate reference\.

<a name='DiGi.ComputeSharp.Spatial.Query.Swap(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int,int).index_1'></a>

`index_1` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The first index reference\.

<a name='DiGi.ComputeSharp.Spatial.Query.Swap(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int,int).index_2'></a>

`index_2` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The second index reference\.