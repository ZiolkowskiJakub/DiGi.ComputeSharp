## DiGi\.ComputeSharp\.Geometry\.Spatial Namespace
### Classes

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisDiGi.Geometry.Spatial.Classes.Mesh3D,bool)'></a>

## Convert\.ToComputeSharp\(this Mesh3D, bool\) Method

Converts a Mesh3D instance into a list of ComputeSharp Triangle3 structures\.

```csharp
public static System.Collections.Generic.List<DiGi.ComputeSharp.Spatial.Classes.Triangle3>? ToComputeSharp(this DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D, bool solid);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisDiGi.Geometry.Spatial.Classes.Mesh3D,bool).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The source mesh to be converted\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisDiGi.Geometry.Spatial.Classes.Mesh3D,bool).solid'></a>

`solid` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A flag indicating whether the conversion should treat the mesh as a solid volume\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of Triangle3 objects representing the mesh, or null if the input mesh is null\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisDiGi.Geometry.Spatial.Classes.Point3D)'></a>

## Convert\.ToComputeSharp\(this Point3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') to a [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Coordinate3 ToComputeSharp(this DiGi.Geometry.Spatial.Classes.Point3D? point3D);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisDiGi.Geometry.Spatial.Classes.Point3D).point3D'></a>

`point3D` [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')

The point to convert\.

#### Returns
[DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The equivalent [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3'), or a default instance if the input is null\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisDiGi.Geometry.Spatial.Classes.Triangle3D,bool)'></a>

## Convert\.ToComputeSharp\(this Triangle3D, bool\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') instance to a ComputeSharp [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Triangle3 ToComputeSharp(this DiGi.Geometry.Spatial.Classes.Triangle3D triangle3D, bool solid);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisDiGi.Geometry.Spatial.Classes.Triangle3D,bool).triangle3D'></a>

`triangle3D` [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')

The source triangle to convert\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisDiGi.Geometry.Spatial.Classes.Triangle3D,bool).solid'></a>

`solid` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the resulting triangle should be treated as solid\.

#### Returns
[DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')  
A new [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3') instance representing the converted geometry\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisDiGi.Geometry.Spatial.Classes.Vector3D)'></a>

## Convert\.ToComputeSharp\(this Vector3D\) Method

Converts a [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') to a [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')\.

```csharp
public static DiGi.ComputeSharp.Spatial.Classes.Coordinate3 ToComputeSharp(this DiGi.Geometry.Spatial.Classes.Vector3D? vetcor3D);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisDiGi.Geometry.Spatial.Classes.Vector3D).vetcor3D'></a>

`vetcor3D` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The vector to convert\.

#### Returns
[DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The equivalent [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3'), or a default instance if the input is null\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Triangle3D_,bool)'></a>

## Convert\.ToComputeSharp\(this IEnumerable\<Triangle3D\>, bool\) Method

Converts a collection of [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') elements to a list of ComputeSharp [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3') elements\.

```csharp
public static System.Collections.Generic.List<DiGi.ComputeSharp.Spatial.Classes.Triangle3>? ToComputeSharp(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Triangle3D>? triangle3Ds, bool solid);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Triangle3D_,bool).triangle3Ds'></a>

`triangle3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The source enumerable of [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') objects to convert\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToComputeSharp(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Triangle3D_,bool).solid'></a>

`solid` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A flag indicating whether the conversion should treat the geometry as solid\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of ComputeSharp [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3') objects, or null if the input collection is null\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(thisSystem.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double)'></a>

## Convert\.ToDiGi\(this IEnumerable\<Triangle3\>, double\) Method

Converts a collection of Triangle3 objects into a Mesh3D object\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Mesh3D? ToDiGi(this System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangle3s, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(thisSystem.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).triangle3s'></a>

`triangle3s` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of triangles to be converted\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(thisSystem.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for vertex merging or processing\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')  
A Mesh3D instance if the conversion is successful; otherwise, null\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(thisSystem.Nullable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_)'></a>

## Convert\.ToDiGi\(this Nullable\<Coordinate3\>\) Method

Converts a Coordinate3 instance to a Point3D instance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? ToDiGi(this System.Nullable<DiGi.ComputeSharp.Spatial.Classes.Coordinate3> coordinate3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(thisSystem.Nullable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_).coordinate3'></a>

`coordinate3` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The source Coordinate3 object to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
A Point3D representation of the coordinate, or null if the input is null\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(thisSystem.Nullable_DiGi.ComputeSharp.Spatial.Classes.Line3_)'></a>

## Convert\.ToDiGi\(this Nullable\<Line3\>\) Method

Converts a [DiGi\.ComputeSharp\.Spatial\.Classes\.Line3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') instance to a [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') instance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Segment3D? ToDiGi(this System.Nullable<DiGi.ComputeSharp.Spatial.Classes.Line3> line3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(thisSystem.Nullable_DiGi.ComputeSharp.Spatial.Classes.Line3_).line3'></a>

`line3` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.ComputeSharp\.Spatial\.Classes\.Line3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The [DiGi\.ComputeSharp\.Spatial\.Classes\.Line3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') object to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Segment3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.segment3d 'DiGi\.Geometry\.Spatial\.Classes\.Segment3D') representation of the line, or null if the input is null\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(thisSystem.Nullable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_)'></a>

## Convert\.ToDiGi\(this Nullable\<Triangle3\>\) Method

Converts a [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3') instance to a [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') instance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Triangle3D? ToDiGi(this System.Nullable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangle3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi(thisSystem.Nullable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).triangle3'></a>

`triangle3` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The source [DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3') object to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Triangle3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.triangle3d 'DiGi\.Geometry\.Spatial\.Classes\.Triangle3D') representation of the input triangle, or null if the input is null\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi_Line3D(thisSystem.Nullable_DiGi.ComputeSharp.Spatial.Classes.Line3_)'></a>

## Convert\.ToDiGi\_Line3D\(this Nullable\<Line3\>\) Method

Converts a [DiGi\.ComputeSharp\.Spatial\.Classes\.Line3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') instance to a [DiGi\.Geometry\.Spatial\.Classes\.Line3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.line3d 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') instance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Line3D? ToDiGi_Line3D(this System.Nullable<DiGi.ComputeSharp.Spatial.Classes.Line3> line3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi_Line3D(thisSystem.Nullable_DiGi.ComputeSharp.Spatial.Classes.Line3_).line3'></a>

`line3` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.ComputeSharp\.Spatial\.Classes\.Line3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The source [DiGi\.ComputeSharp\.Spatial\.Classes\.Line3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') instance to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Line3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.line3d 'DiGi\.Geometry\.Spatial\.Classes\.Line3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Line3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.line3d 'DiGi\.Geometry\.Spatial\.Classes\.Line3D') instance if the conversion is successful; otherwise, null\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi_Vector3D(thisSystem.Nullable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_)'></a>

## Convert\.ToDiGi\_Vector3D\(this Nullable\<Coordinate3\>\) Method

Converts a [DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') instance to a [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') instance\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Vector3D? ToDiGi_Vector3D(this System.Nullable<DiGi.ComputeSharp.Spatial.Classes.Coordinate3> coordinate3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Convert.ToDiGi_Vector3D(thisSystem.Nullable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_).coordinate3'></a>

`coordinate3` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The source coordinate to convert\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')  
A [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D') representation of the coordinate, or null if the input is null\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.ComputeSharp.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_,bool,double)'></a>

## Create\.IntersectionResult3D\(this Mesh3D, IEnumerable\<Mesh3D\>, bool, double\) Method

Calculates the 3D intersection between a source mesh and a collection of other meshes\.

```csharp
public static DiGi.Geometry.Spatial.Classes.IntersectionResult3D? IntersectionResult3D(this DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Mesh3D>? mesh3Ds, bool solid, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_,bool,double).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The source mesh to evaluate\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_,bool,double).mesh3Ds'></a>

`mesh3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of meshes to intersect with the source mesh\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_,bool,double).solid'></a>

`solid` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to perform a solid intersection operation\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance for the intersection calculation\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.intersectionresult3d 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')  
An [IntersectionResult3D\(this Mesh3D, IEnumerable&lt;Mesh3D&gt;, bool, double\)](DiGi.ComputeSharp.Geometry.Spatial.md#DiGi.ComputeSharp.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_,bool,double) 'DiGi\.ComputeSharp\.Geometry\.Spatial\.Create\.IntersectionResult3D\(this DiGi\.Geometry\.Spatial\.Classes\.Mesh3D, System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Spatial\.Classes\.Mesh3D\>, bool, double\)') containing the result of the intersection, or null if no valid intersection is found\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Create.IntersectionResult3D_CPU(thisDiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_,bool,double)'></a>

## Create\.IntersectionResult3D\_CPU\(this Mesh3D, IEnumerable\<Mesh3D\>, bool, double\) Method

Computes the 3D intersection between a source mesh and a collection of other meshes using CPU processing\.

```csharp
public static DiGi.Geometry.Spatial.Classes.IntersectionResult3D? IntersectionResult3D_CPU(this DiGi.Geometry.Spatial.Classes.Mesh3D? mesh3D, System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Classes.Mesh3D>? mesh3Ds, bool solid, double tolerance=1E-06);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Create.IntersectionResult3D_CPU(thisDiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_,bool,double).mesh3D'></a>

`mesh3D` [DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')

The source mesh to evaluate for intersections\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Create.IntersectionResult3D_CPU(thisDiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_,bool,double).mesh3Ds'></a>

`mesh3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Classes\.Mesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.mesh3d 'DiGi\.Geometry\.Spatial\.Classes\.Mesh3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of target meshes to intersect with the source mesh\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Create.IntersectionResult3D_CPU(thisDiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_,bool,double).solid'></a>

`solid` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Specifies whether to perform a solid intersection \(volumetric\) or a surface\-based intersection\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Create.IntersectionResult3D_CPU(thisDiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used for numerical precision during the intersection calculation\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.intersectionresult3d 'DiGi\.Geometry\.Spatial\.Classes\.IntersectionResult3D')  
An [IntersectionResult3D\(this Mesh3D, IEnumerable&lt;Mesh3D&gt;, bool, double\)](DiGi.ComputeSharp.Geometry.Spatial.md#DiGi.ComputeSharp.Geometry.Spatial.Create.IntersectionResult3D(thisDiGi.Geometry.Spatial.Classes.Mesh3D,System.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Classes.Mesh3D_,bool,double) 'DiGi\.ComputeSharp\.Geometry\.Spatial\.Create\.IntersectionResult3D\(this DiGi\.Geometry\.Spatial\.Classes\.Mesh3D, System\.Collections\.Generic\.IEnumerable\<DiGi\.Geometry\.Spatial\.Classes\.Mesh3D\>, bool, double\)') containing the intersection data if successful; otherwise, null\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.ComputeSharp.Geometry.Spatial.Query.Shading(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Query\.Shading\(this IEnumerable\<IPolygonalFace3D\>, Vector3D, double\) Method

Performs a shading analysis on a collection of polygonal faces based on a specified direction and tolerance\.

```csharp
public static System.Collections.Generic.List<System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.PolygonalFace3D>?>? Shading(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>? polygonalFace3Ds, DiGi.Geometry.Spatial.Classes.Vector3D? direction, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Query.Shading(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Vector3D,double).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of polygonal faces to be analyzed for shading\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Query.Shading(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Vector3D,double).direction'></a>

`direction` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The vector representing the light source or projection direction\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Query.Shading(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision tolerance used for geometric calculations\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing groups of shaded polygonal faces, or null if the input collection is null\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Query.Shading_CPU(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Vector3D,double)'></a>

## Query\.Shading\_CPU\(this IEnumerable\<IPolygonalFace3D\>, Vector3D, double\) Method

Calculates shading for a collection of polygonal faces based on a specified direction and tolerance using CPU processing\.

```csharp
public static System.Collections.Generic.List<System.Collections.Generic.List<DiGi.Geometry.Spatial.Classes.PolygonalFace3D>?>? Shading_CPU(this System.Collections.Generic.IEnumerable<DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D>? polygonalFace3Ds, DiGi.Geometry.Spatial.Classes.Vector3D? direction, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Spatial.Query.Shading_CPU(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Vector3D,double).polygonalFace3Ds'></a>

`polygonalFace3Ds` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.interfaces.ipolygonalface3d 'DiGi\.Geometry\.Spatial\.Interfaces\.IPolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of polygonal faces to be processed\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Query.Shading_CPU(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Vector3D,double).direction'></a>

`direction` [DiGi\.Geometry\.Spatial\.Classes\.Vector3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.vector3d 'DiGi\.Geometry\.Spatial\.Classes\.Vector3D')

The vector representing the light or view direction used for shading calculations\.

<a name='DiGi.ComputeSharp.Geometry.Spatial.Query.Shading_CPU(thisSystem.Collections.Generic.IEnumerable_DiGi.Geometry.Spatial.Interfaces.IPolygonalFace3D_,DiGi.Geometry.Spatial.Classes.Vector3D,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision tolerance used for geometric comparisons\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.polygonalface3d 'DiGi\.Geometry\.Spatial\.Classes\.PolygonalFace3D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A nested list of shaded polygonal faces, or null if the operation cannot be completed\.