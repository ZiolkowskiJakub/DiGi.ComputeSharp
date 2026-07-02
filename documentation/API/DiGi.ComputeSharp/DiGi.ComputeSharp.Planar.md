#### [DiGi\.ComputeSharp](index.md 'index')

## DiGi\.ComputeSharp\.Planar Namespace
### Classes

<a name='DiGi.ComputeSharp.Planar.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2,DiGi.ComputeSharp.Planar.Classes.Line2,double)'></a>

## Create\.Line2Intersection\(Line2, Line2, double\) Method

Calculates the intersection of two 2D lines within a specified tolerance\.

```csharp
public static DiGi.ComputeSharp.Planar.Classes.Line2Intersection Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2 line_1, DiGi.ComputeSharp.Planar.Classes.Line2 line_2, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2,DiGi.ComputeSharp.Planar.Classes.Line2,double).line_1'></a>

`line_1` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The first 2D line\.

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2,DiGi.ComputeSharp.Planar.Classes.Line2,double).line_2'></a>

`line_2` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The second 2D line\.

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2,DiGi.ComputeSharp.Planar.Classes.Line2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numerical tolerance used for geometric comparisons and proximity checks\.

#### Returns
[Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection')  
A [Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection') object containing the intersection result, which may be empty, a single point, or a line segment in the case of coincident lines\.

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2,DiGi.ComputeSharp.Planar.Classes.Triangle2,double)'></a>

## Create\.Line2Intersection\(Line2, Triangle2, double\) Method

Calculates the intersection between a line and a triangle in 2D space based on a specified tolerance\.

```csharp
public static DiGi.ComputeSharp.Planar.Classes.Line2Intersection Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2 line, DiGi.ComputeSharp.Planar.Classes.Triangle2 triangle, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2,DiGi.ComputeSharp.Planar.Classes.Triangle2,double).line'></a>

`line` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The line to test for intersection\.

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2,DiGi.ComputeSharp.Planar.Classes.Triangle2,double).triangle'></a>

`triangle` [Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')

The triangle to test for intersection\.

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2,DiGi.ComputeSharp.Planar.Classes.Triangle2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for floating\-point comparisons and proximity checks\.

#### Returns
[Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection')  
A [Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection') object representing the intersection result \(e\.g\., a point, a line segment, or no intersection\)\.

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersections(DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,double)'></a>

## Create\.Line2Intersections\(Line2, IEnumerable\<Line2\>, double\) Method

Calculates the intersections between a specified line and a collection of other lines using GPU acceleration\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Line2Intersection>? Line2Intersections(DiGi.ComputeSharp.Planar.Classes.Line2 line, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Line2>? lines, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersections(DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,double).line'></a>

`line` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The primary line to check for intersections\.

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersections(DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,double).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of lines to test against the primary line\.

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersections(DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used to determine if two lines are intersecting\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of [Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection') results, or `null` if the input line is invalid, the lines collection is empty/null, or the graphics device is unavailable\.

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersections(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,double)'></a>

## Create\.Line2Intersections\(IEnumerable\<Line2\>, IEnumerable\<Triangle2\>, double\) Method

Calculates the intersections between a collection of lines and a collection of triangles using GPU acceleration\.

```csharp
public static System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Line2Intersection>? Line2Intersections(System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Line2>? lines, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Triangle2>? triangles, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersections(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,double).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of lines to test\.

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersections(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,double).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of triangles to intersect against\.

<a name='DiGi.ComputeSharp.Planar.Create.Line2Intersections(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used to determine intersections\.

#### Returns
[System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')  
A collection of [Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection') results laid out row\-major \(row = line index, column = triangle index\) with NaN results filtered out, or `null` if either input collection is null/empty or the graphics device is unavailable\.

<a name='DiGi.ComputeSharp.Planar.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.ComputeSharp.Planar.Modify.Add(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,double)'></a>

## Modify\.Add\(Coordinate2, Coordinate2, Coordinate2, double\) Method

Adds a point to the pair of points defined by two coordinates within the specified tolerance, filling the first free \(NaN\) slot\.

```csharp
public static bool Add(ref DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_1, ref DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_2, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Modify.Add(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).point_1'></a>

`point_1` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first endpoint of the pair\.

<a name='DiGi.ComputeSharp.Planar.Modify.Add(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).point_2'></a>

`point_2` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The second endpoint of the pair\.

<a name='DiGi.ComputeSharp.Planar.Modify.Add(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The point to be added\.

<a name='DiGi.ComputeSharp.Planar.Modify.Add(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value for the operation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point was successfully added; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Modify.SwapIfCrossProductNegative(int,int,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Modify\.SwapIfCrossProductNegative\(int, int, Coordinate2, Coordinate2\) Method

Swaps two provided indices if the cross product of the given vectors is negative,
or if the first vector is NaN while the second is not\.

```csharp
public static bool SwapIfCrossProductNegative(ref int index_1, ref int index_2, DiGi.ComputeSharp.Planar.Classes.Coordinate2 vector_1, DiGi.ComputeSharp.Planar.Classes.Coordinate2 vector_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Modify.SwapIfCrossProductNegative(int,int,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).index_1'></a>

`index_1` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

A reference to the first index to be potentially swapped\.

<a name='DiGi.ComputeSharp.Planar.Modify.SwapIfCrossProductNegative(int,int,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).index_2'></a>

`index_2` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

A reference to the second index to be potentially swapped\.

<a name='DiGi.ComputeSharp.Planar.Modify.SwapIfCrossProductNegative(int,int,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).vector_1'></a>

`vector_1` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first coordinate vector used for the cross product calculation\.

<a name='DiGi.ComputeSharp.Planar.Modify.SwapIfCrossProductNegative(int,int,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).vector_2'></a>

`vector_2` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The second coordinate vector used for the cross product calculation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the indices were swapped; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.ComputeSharp.Planar.Query.Centroid(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Query\.Centroid\(Coordinate2, Coordinate2, Coordinate2, Coordinate2, Coordinate2, Coordinate2\) Method

Calculates the centroid of up to six 2D coordinates, ignoring any coordinates that are NaN\.

```csharp
internal static DiGi.ComputeSharp.Planar.Classes.Coordinate2 Centroid(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_1, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_2, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_3, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_4, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_5, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_6);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Query.Centroid(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_1'></a>

`point_1` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first coordinate\.

<a name='DiGi.ComputeSharp.Planar.Query.Centroid(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_2'></a>

`point_2` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The second coordinate\.

<a name='DiGi.ComputeSharp.Planar.Query.Centroid(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_3'></a>

`point_3` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The third coordinate\.

<a name='DiGi.ComputeSharp.Planar.Query.Centroid(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_4'></a>

`point_4` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The fourth coordinate\.

<a name='DiGi.ComputeSharp.Planar.Query.Centroid(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_5'></a>

`point_5` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The fifth coordinate\.

<a name='DiGi.ComputeSharp.Planar.Query.Centroid(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_6'></a>

`point_6` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The sixth coordinate\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A new [Coordinate2\(Coordinate2, Coordinate2, Coordinate2, Coordinate2, Coordinate2, Coordinate2, int\)](DiGi.ComputeSharp.Planar.md#DiGi.ComputeSharp.Planar.Query.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int) 'DiGi\.ComputeSharp\.Planar\.Query\.Coordinate2\(DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2, DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2, DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2, DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2, DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2, DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2, int\)') representing the centroid of the valid coordinates\.

<a name='DiGi.ComputeSharp.Planar.Query.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int)'></a>

## Query\.Coordinate2\(Coordinate2, Coordinate2, Coordinate2, Coordinate2, Coordinate2, Coordinate2, int\) Method

Selects one of the six 2D coordinates by its index \(1\-based\)\.

```csharp
internal static DiGi.ComputeSharp.Planar.Classes.Coordinate2 Coordinate2(ref DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate_1, ref DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate_2, ref DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate_3, ref DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate_4, ref DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate_5, ref DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate_6, int index);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Query.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int).coordinate_1'></a>

`coordinate_1` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first coordinate reference\.

<a name='DiGi.ComputeSharp.Planar.Query.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int).coordinate_2'></a>

`coordinate_2` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The second coordinate reference\.

<a name='DiGi.ComputeSharp.Planar.Query.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int).coordinate_3'></a>

`coordinate_3` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The third coordinate reference\.

<a name='DiGi.ComputeSharp.Planar.Query.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int).coordinate_4'></a>

`coordinate_4` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The fourth coordinate reference\.

<a name='DiGi.ComputeSharp.Planar.Query.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int).coordinate_5'></a>

`coordinate_5` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The fifth coordinate reference\.

<a name='DiGi.ComputeSharp.Planar.Query.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int).coordinate_6'></a>

`coordinate_6` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The sixth coordinate reference\.

<a name='DiGi.ComputeSharp.Planar.Query.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The 1\-based index of the coordinate to select\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
The selected [Coordinate2\(Coordinate2, Coordinate2, Coordinate2, Coordinate2, Coordinate2, Coordinate2, int\)](DiGi.ComputeSharp.Planar.md#DiGi.ComputeSharp.Planar.Query.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,int) 'DiGi\.ComputeSharp\.Planar\.Query\.Coordinate2\(DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2, DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2, DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2, DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2, DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2, DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2, int\)'), or a default coordinate if index is out of bounds\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool)'></a>

## Query\.Intersect\(Line2, IEnumerable\<Triangle2\>, bool, bool\) Method

Determines whether a specified line segment intersects with any triangle in the provided collection\.

```csharp
public static bool Intersect(DiGi.ComputeSharp.Planar.Classes.Line2 line2, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Triangle2>? triangle2s, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).line2'></a>

`line2` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The line segment to evaluate for intersection\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).triangle2s'></a>

`triangle2s` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

A collection of triangles to check against the line segment\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the start point of the line should be included in the intersection test\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the end point of the line should be included in the intersection test\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if an intersection is found; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool)'></a>

## Query\.Intersect\(IEnumerable\<Line2\>, IEnumerable\<Triangle2\>, bool, bool\) Method

Determines whether each line in the provided collection intersects with any of the specified 2D triangles\.

```csharp
public static System.Collections.Generic.List<bool>? Intersect(System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Line2>? line2s, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Triangle2>? triangle2s, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).line2s'></a>

`line2s` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 2D lines to evaluate for intersections\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).triangle2s'></a>

`triangle2s` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 2D triangles to test against\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, the start point of the line is included in the intersection calculation\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, the end point of the line is included in the intersection calculation\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of boolean values indicating the intersection result for each input line, or `null` if the input collections are null\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool)'></a>

## Query\.Intersect\(this GraphicsDevice, Line2, ReadOnlyBuffer\<Triangle2\>, bool, bool\) Method

Determines whether a 2D line intersects any of the triangles contained within the specified read\-only buffer\.

```csharp
public static bool Intersect(this ComputeSharp.GraphicsDevice graphicDevice, DiGi.ComputeSharp.Planar.Classes.Line2 line2, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Planar.Classes.Triangle2> triangle2s, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).graphicDevice'></a>

`graphicDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device used to perform the intersection calculation\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).line2'></a>

`line2` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The 2D line to test for intersection\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).triangle2s'></a>

`triangle2s` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

A read\-only buffer containing the triangles to be tested against the line\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, includes the start point of the line in the intersection test\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(thisComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, includes the end point of the line in the intersection test\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if an intersection is found; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool)'></a>

## Query\.Intersect\(this GraphicsDevice, IEnumerable\<Line2\>, ReadOnlyBuffer\<Triangle2\>, bool, bool\) Method

Performs an intersection test between a collection of 2D lines and a buffer of 2D triangles using the specified graphics device\.

```csharp
public static System.Collections.Generic.List<bool>? Intersect(this ComputeSharp.GraphicsDevice? graphicDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Line2>? line2s, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Planar.Classes.Triangle2>? triangle2s, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).graphicDevice'></a>

`graphicDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device used to perform the intersection calculations\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).line2s'></a>

`line2s` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An enumerable collection of 2D lines to be tested for intersections\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).triangle2s'></a>

`triangle2s` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

A read\-only buffer containing the 2D triangles to test against\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, includes the start point of each line in the intersection check\.

<a name='DiGi.ComputeSharp.Planar.Query.Intersect(thisComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

If set to `true`, includes the end point of each line in the intersection check\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of boolean values indicating whether each corresponding line intersects any triangle, or `null` if the operation failed\.