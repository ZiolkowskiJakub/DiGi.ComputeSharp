#### [DiGi\.ComputeSharp](index.md 'index')

## DiGi\.ComputeSharp\.Spatial\.Classes Namespace
### Structs

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3'></a>

## Coordinate3 Struct

Represents a three\-dimensional coordinate or vector in a spatial coordinate system\.

```csharp
public readonly struct Coordinate3 : DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3, DiGi.ComputeSharp.Core.Interfaces.IGeometry
```

Implements [IGeometry3](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3'), [IGeometry](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IGeometry 'DiGi\.ComputeSharp\.Core\.Interfaces\.IGeometry')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3()'></a>

## Coordinate3\(\) Constructor

Initializes a new instance of the [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') struct with NaN coordinates\.

```csharp
public Coordinate3();
```

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\(Coordinate3\) Constructor

Initializes a new instance of the [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') struct by copying an existing coordinate\.

```csharp
public Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).coordinate'></a>

`coordinate` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The source coordinate to copy\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\(Coordinate3, Coordinate3\) Constructor

Initializes a new instance of the [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') struct as a vector representing the difference between two points\.

```csharp
public Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 start, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 end);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).start'></a>

`start` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The starting point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).end'></a>

`end` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The ending point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(double,double,double)'></a>

## Coordinate3\(double, double, double\) Constructor

Initializes a new instance of the [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') struct with the specified X, Y, and Z components\.

```csharp
public Coordinate3(double x, double y, double z);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X component\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y component\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(double,double,double).z'></a>

`z` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z component\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(double,double,double,double,double,double)'></a>

## Coordinate3\(double, double, double, double, double, double\) Constructor

Initializes a new instance of the [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') struct as a vector representing the difference between two sets of coordinates\.

```csharp
public Coordinate3(double x_1, double y_1, double z_1, double x_2, double y_2, double z_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(double,double,double,double,double,double).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The starting X component\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(double,double,double,double,double,double).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The starting Y component\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(double,double,double,double,double,double).z_1'></a>

`z_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The starting Z component\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(double,double,double,double,double,double).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The ending X component\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(double,double,double,double,double,double).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The ending Y component\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Coordinate3(double,double,double,double,double,double).z_2'></a>

`z_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The ending Z component\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.X'></a>

## Coordinate3\.X Field

The X\-coordinate of the point or the X\-component of the vector\.

```csharp
public readonly double X;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Y'></a>

## Coordinate3\.Y Field

The Y\-coordinate of the point or the Y\-component of the vector\.

```csharp
public readonly double Y;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Z'></a>

## Coordinate3\.Z Field

The Z\-coordinate of the point or the Z\-component of the vector\.

```csharp
public readonly double Z;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.Add\(Coordinate3\) Method

Performs vector addition of this coordinate and another coordinate\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Add(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).coordinate'></a>

`coordinate` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The coordinate to add\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A new [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the sum\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.AlmostEquals(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Coordinate3\.AlmostEquals\(Coordinate3, double\) Method

Determines whether this coordinate is approximately equal to another coordinate within a specified tolerance\.

```csharp
public bool AlmostEquals(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.AlmostEquals(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).coordinate'></a>

`coordinate` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The coordinate to compare\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.AlmostEquals(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum allowed difference between components\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the coordinates are within the tolerance; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.CrossProduct(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.CrossProduct\(Coordinate3\) Method

Calculates the cross product of this vector and another vector\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 CrossProduct(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.CrossProduct(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The other vector\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A new [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the cross product vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Divide(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.Divide\(Coordinate3\) Method

Performs component\-wise division of this coordinate by another coordinate\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Divide(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Divide(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).coordinate'></a>

`coordinate` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The divisor coordinate\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A new [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the component\-wise quotient\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Divide(double)'></a>

## Coordinate3\.Divide\(double\) Method

Divides this coordinate by a scalar factor\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Divide(double factor);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Divide(double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The divisor value\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A new [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the quotient\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.DotProduct(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.DotProduct\(Coordinate3\) Method

Calculates the dot product of this vector and another vector\.

```csharp
public double DotProduct(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.DotProduct(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The other vector\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The scalar result of the dot product\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.DotProduct(double,double,double)'></a>

## Coordinate3\.DotProduct\(double, double, double\) Method

Calculates the dot product of this vector and specified components\.

```csharp
public double DotProduct(double x, double y, double z);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.DotProduct(double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X component of the other vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.DotProduct(double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y component of the other vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.DotProduct(double,double,double).z'></a>

`z` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z component of the other vector\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The scalar result of the dot product\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Equals(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.Equals\(Coordinate3\) Method

Determines whether this coordinate is exactly equal to another coordinate\.

```csharp
public bool Equals(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Equals(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).coordinate'></a>

`coordinate` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The coordinate to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the coordinates are identical or both are NaN; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Equals(object)'></a>

## Coordinate3\.Equals\(object\) Method

Determines whether this coordinate is equal to the specified object\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object is a [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') and has identical values; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetApproximateDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.GetApproximateDistance\(Coordinate3\) Method

Calculates an approximate distance between this point and another point using a fast approximation formula\.

```csharp
public double GetApproximateDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetApproximateDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The target point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
An approximated Euclidean distance\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetApproximateLength()'></a>

## Coordinate3\.GetApproximateLength\(\) Method

Calculates the approximate length of this vector from the origin \(0,0,0\)\.

```csharp
public double GetApproximateLength();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
An approximated magnitude of the vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetCentroid()'></a>

## Coordinate3\.GetCentroid\(\) Method

Calculates the centroid \(midpoint\) between this coordinate and the origin\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetCentroid();
```

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A new [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the midpoint\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetCentroid(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.GetCentroid\(Coordinate3\) Method

Calculates the centroid \(midpoint\) between this coordinate and another point\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetCentroid(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetCentroid(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The other point\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A new [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the midpoint\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Coordinate3\.GetDistance\(Coordinate3, double\) Method

Calculates the Euclidean distance between this coordinate and another point\.

```csharp
public double GetDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The target point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance used for square root calculation\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance value\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetHashCode()'></a>

## Coordinate3\.GetHashCode\(\) Method

Returns a hash code for the current coordinate\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An integer hash code\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetInversed()'></a>

## Coordinate3\.GetInversed\(\) Method

Returns a coordinate with inverted X, Y, and Z values\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetInversed();
```

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A new [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the inverted vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetLength(double)'></a>

## Coordinate3\.GetLength\(double\) Method

Calculates the magnitude \(length\) of this vector\.

```csharp
public double GetLength(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetLength(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance used for square root calculation\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The length value\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetMoved(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.GetMoved\(Coordinate3\) Method

Translates this coordinate by a given vector\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetMoved(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetMoved(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The translation vector\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A new [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the moved position\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetNormalized(double)'></a>

## Coordinate3\.GetNormalized\(double\) Method

Returns a unit vector in the same direction as this coordinate\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetNormalized(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetNormalized(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance used for length calculation\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A normalized [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') with a magnitude of 1\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetSquaredDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.GetSquaredDistance\(Coordinate3\) Method

Calculates the squared Euclidean distance between this coordinate and another\.

```csharp
public double GetSquaredDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetSquaredDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).coordinate'></a>

`coordinate` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The target coordinate\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The squared distance value\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.GetSquaredLength()'></a>

## Coordinate3\.GetSquaredLength\(\) Method

Calculates the squared length of the coordinate vector \(X\*X \+ Y\*Y \+ Z\*Z\)\.

```csharp
public double GetSquaredLength();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The sum of the squares of the components\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.InRange(DiGi.ComputeSharp.Spatial.Classes.Line3,double)'></a>

## Coordinate3\.InRange\(Line3, double\) Method

Checks if this point is within the range of the specified line's bounding box expanded by a tolerance\.

```csharp
public bool InRange(DiGi.ComputeSharp.Spatial.Classes.Line3 line, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.InRange(DiGi.ComputeSharp.Spatial.Classes.Line3,double).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The line to check against\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.InRange(DiGi.ComputeSharp.Spatial.Classes.Line3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used to expand the bounding box\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is within range; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.InRange(DiGi.ComputeSharp.Spatial.Classes.Triangle3,double)'></a>

## Coordinate3\.InRange\(Triangle3, double\) Method

Checks if this point is within the range of the specified triangle's bounding box expanded by a tolerance\.

```csharp
public bool InRange(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.InRange(DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The triangle to check against\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.InRange(DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance used to expand the bounding box\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is within range; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.IsNaN()'></a>

## Coordinate3\.IsNaN\(\) Method

Determines whether any component of this coordinate is Not\-a\-Number \(NaN\)\.

```csharp
public bool IsNaN();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if X, Y, or Z is NaN; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Multiply(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.Multiply\(Coordinate3\) Method

Performs component\-wise multiplication of this coordinate with another coordinate\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Multiply(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Multiply(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).coordinate'></a>

`coordinate` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The coordinate to multiply by\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A new [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') resulting from the component\-wise multiplication\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Multiply(double)'></a>

## Coordinate3\.Multiply\(double\) Method

Performs scalar multiplication of this coordinate by a specified factor\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Multiply(double factor);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Multiply(double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar value to multiply by\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A new [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') resulting from the scalar multiplication\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.Project\(Coordinate3\) Method

Projects the specified coordinate onto this vector\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).coordinate'></a>

`coordinate` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The coordinate to project\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A new [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the projection of the coordinate onto this vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Substract(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.Substract\(Coordinate3\) Method

Subtracts another coordinate from this coordinate\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Substract(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.Substract(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).coordinate'></a>

`coordinate` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The coordinate to subtract\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A new [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the result of the subtraction\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.ToString()'></a>

## Coordinate3\.ToString\(\) Method

Returns a string representation of the current coordinate\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A formatted string containing the X, Y, and Z components\.
### Operators

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.op_Equality(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.operator ==\(Coordinate3, Coordinate3\) Operator

Determines whether two [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') objects are equal\.

```csharp
public static bool operator ==(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 left, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 right);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.op_Equality(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).left'></a>

`left` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate to compare\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.op_Equality(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).right'></a>

`right` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the coordinates are equal; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.op_Inequality(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Coordinate3\.operator \!=\(Coordinate3, Coordinate3\) Operator

Determines whether two [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') objects are not equal\.

```csharp
public static bool operator !=(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 left, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 right);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.op_Inequality(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).left'></a>

`left` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate to compare\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3.op_Inequality(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).right'></a>

`right` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the coordinates are not equal; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader'></a>

## Coordinate3InsideComputeShader Struct

Represents a compute shader used to determine if a 3D coordinate is inside a set of triangles\.

```csharp
public readonly struct Coordinate3InsideComputeShader : ComputeSharp.IComputeShader, ComputeSharp.Descriptors.IComputeShaderDescriptor<DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader>
```

Implements [ComputeSharp\.IComputeShader](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader 'ComputeSharp\.IComputeShader'), [ComputeSharp\.Descriptors\.IComputeShaderDescriptor&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')[Coordinate3InsideComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3InsideComputeShader')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_)'></a>

## Coordinate3InsideComputeShader\(GraphicsDevice, IEnumerable\<Coordinate3\>, IEnumerable\<Triangle3\>\) Constructor

Initializes a new instance of the [Coordinate3InsideComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3InsideComputeShader') struct\.

```csharp
public Coordinate3InsideComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Coordinate3> points, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D points to test\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D triangles to test against\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double)'></a>

## Coordinate3InsideComputeShader\(GraphicsDevice, IEnumerable\<Coordinate3\>, IEnumerable\<Triangle3\>, double\) Constructor

Initializes a new instance of the [Coordinate3InsideComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3InsideComputeShader') struct with a custom tolerance\.

```csharp
public Coordinate3InsideComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Coordinate3> points, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).points'></a>

`points` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D points to test\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D triangles to test against\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_)'></a>

## Coordinate3InsideComputeShader\(ReadOnlyBuffer\<Coordinate3\>, ReadOnlyBuffer\<Triangle3\>, ReadWriteBuffer\<int\>\) Constructor

Initializes a new instance of the [Coordinate3InsideComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3InsideComputeShader') struct using pre\-allocated buffers\.

```csharp
public Coordinate3InsideComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Coordinate3> points, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, ComputeSharp.ReadWriteBuffer<int> result);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_).points'></a>

`points` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D points\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_).result'></a>

`result` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,double)'></a>

## Coordinate3InsideComputeShader\(ReadOnlyBuffer\<Coordinate3\>, ReadOnlyBuffer\<Triangle3\>, ReadWriteBuffer\<int\>, double\) Constructor

Initializes a new instance of the [Coordinate3InsideComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3InsideComputeShader') struct using pre\-allocated buffers and a custom tolerance\.

```csharp
public Coordinate3InsideComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Coordinate3> points, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, ComputeSharp.ReadWriteBuffer<int> result, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,double).points'></a>

`points` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D points\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,double).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,double).result'></a>

`result` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Coordinate3InsideComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Coordinate3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Coordinate3InsideComputeShader.Result'></a>

## Coordinate3InsideComputeShader\.Result Field

Gets the writeable buffer containing the index of the first containing triangle for each point, or \-1 if the point is outside all triangles\.

```csharp
public readonly ReadWriteBuffer<int> Result;
```

#### Field Value
[ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3'></a>

## Line3 Struct

Represents a three\-dimensional line or line segment in a spatial coordinate system\.

```csharp
public readonly struct Line3 : DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3, DiGi.ComputeSharp.Core.Interfaces.IGeometry
```

Implements [IGeometry3](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3'), [IGeometry](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IGeometry 'DiGi\.ComputeSharp\.Core\.Interfaces\.IGeometry')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3()'></a>

## Line3\(\) Constructor

Initializes a new instance of the [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') struct with default values \(NaN coordinates and not bounded\)\.

```csharp
public Line3();
```

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3\(Bool, Coordinate3, Coordinate3\) Constructor

Initializes a new instance of the [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') struct with specified boundedness between two points\.

```csharp
public Line3(DiGi.ComputeSharp.Core.Classes.Bool bounded, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 start, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 end);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).bounded'></a>

`bounded` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

A value indicating whether the line is bounded\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).start'></a>

`start` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The start point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).end'></a>

`end` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The end point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double)'></a>

## Line3\(Bool, double, double, double, double, double, double\) Constructor

Initializes a new instance of the [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') struct with specified boundedness and coordinates\.

```csharp
public Line3(DiGi.ComputeSharp.Core.Classes.Bool bounded, double x_1, double y_1, double z_1, double x_2, double y_2, double z_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double).bounded'></a>

`bounded` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

A value indicating whether the line is bounded\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X component of the end point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y component of the end point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double).z_1'></a>

`z_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z component of the end point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X component of the start point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y component of the start point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double).z_2'></a>

`z_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z component of the start point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3\(Coordinate3, Coordinate3\) Constructor

Initializes a new instance of the [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') struct as a bounded segment between two points\.

```csharp
public Line3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 start, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 end);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).start'></a>

`start` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The start point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).end'></a>

`end` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The end point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(double,double,double,double,double,double)'></a>

## Line3\(double, double, double, double, double, double\) Constructor

Initializes a new instance of the [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') struct as a bounded segment with specified start and end coordinates\.

```csharp
public Line3(double x_1, double y_1, double z_1, double x_2, double y_2, double z_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(double,double,double,double,double,double).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X component of the end point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(double,double,double,double,double,double).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y component of the end point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(double,double,double,double,double,double).z_1'></a>

`z_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z component of the end point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(double,double,double,double,double,double).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X component of the start point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(double,double,double,double,double,double).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y component of the start point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Line3(double,double,double,double,double,double).z_2'></a>

`z_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z component of the start point\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Bounded'></a>

## Line3\.Bounded Field

A value indicating whether this line is bounded \(representing a finite segment\) or unbounded \(an infinite line\)\.

```csharp
public readonly Bool Bounded;
```

#### Field Value
[Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.End'></a>

## Line3\.End Field

The end point of the line segment\.

```csharp
public readonly Coordinate3 End;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Start'></a>

## Line3\.Start Field

The start point of the line segment\.

```csharp
public readonly Coordinate3 Start;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetApproximateDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3\.GetApproximateDistance\(Coordinate3\) Method

Calculates the approximate distance from a point to this line\.

```csharp
public double GetApproximateDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetApproximateDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The target point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The approximate distance value\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetApproximateLength()'></a>

## Line3\.GetApproximateLength\(\) Method

Calculates the approximate length of this line\.

```csharp
public double GetApproximateLength();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The approximate length of the segment, or positive infinity if the line is unbounded\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetCentroid()'></a>

## Line3\.GetCentroid\(\) Method

Gets the centroid \(midpoint\) of the line segment\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetCentroid();
```

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the centroid\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetClosestPoint(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3\.GetClosestPoint\(Coordinate3\) Method

Finds the point on this line that is closest to the specified point\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetClosestPoint(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetClosestPoint(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The point to project onto the line\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The closest [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') on this line\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetDirection(double)'></a>

## Line3\.GetDirection\(double\) Method

Calculates the unit direction vector of this line\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetDirection(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetDirection(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for length calculation\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The normalized direction [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Line3\.GetDistance\(Coordinate3, double\) Method

Calculates the distance from a point to this line with a specified tolerance\.

```csharp
public double GetDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The target point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for distance calculations\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance value\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetInversed()'></a>

## Line3\.GetInversed\(\) Method

Returns a new line with reversed direction\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Line3 GetInversed();
```

#### Returns
[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')  
A new [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') with start and end swapped\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetLength(double)'></a>

## Line3\.GetLength\(double\) Method

Calculates the length of this line segment\.

```csharp
public double GetLength(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetLength(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for square root calculation\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The length of the line segment, or positive infinity if the line is unbounded\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetMax()'></a>

## Line3\.GetMax\(\) Method

Gets the maximum coordinate bounds of the line segment\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetMax();
```

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the maximum coordinates\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetMin()'></a>

## Line3\.GetMin\(\) Method

Gets the minimum coordinate bounds of the line segment\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetMin();
```

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the minimum coordinates\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetMoved(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3\.GetMoved\(Coordinate3\) Method

Translates the line by the specified offset vector\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Line3 GetMoved(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetMoved(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The translation vector\.

#### Returns
[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')  
A translated [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetSquaredDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3\.GetSquaredDistance\(Coordinate3\) Method

Calculates the squared distance from a point to this line\.

```csharp
public double GetSquaredDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetSquaredDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The target point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The squared distance value\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetSquaredLength()'></a>

## Line3\.GetSquaredLength\(\) Method

Calculates the squared length of the line segment\.

```csharp
public double GetSquaredLength();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The squared length, or positive infinity if the line is unbounded\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.GetVector()'></a>

## Line3\.GetVector\(\) Method

Gets the vector representing this line \(from start to end\)\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetVector();
```

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the line vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.InRange(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Line3\.InRange\(Coordinate3, double\) Method

Checks if a point is within the bounding range of the line\.

```csharp
public bool InRange(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.InRange(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The point to check\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.InRange(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is within range; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.InRange(DiGi.ComputeSharp.Spatial.Classes.Line3,double)'></a>

## Line3\.InRange\(Line3, double\) Method

Checks if another line is within the bounding range of this line\.

```csharp
public bool InRange(DiGi.ComputeSharp.Spatial.Classes.Line3 line3, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.InRange(DiGi.ComputeSharp.Spatial.Classes.Line3,double).line3'></a>

`line3` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The other line to check\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.InRange(DiGi.ComputeSharp.Spatial.Classes.Line3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the lines' bounding boxes overlap; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.InRange(DiGi.ComputeSharp.Spatial.Classes.Triangle3,double)'></a>

## Line3\.InRange\(Triangle3, double\) Method

Checks if a triangle is within the bounding range of the line\.

```csharp
public bool InRange(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.InRange(DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).triangle3'></a>

`triangle3` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The triangle to check\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.InRange(DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the bounding boxes overlap; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.IsNaN()'></a>

## Line3\.IsNaN\(\) Method

Checks if either start or end point of this line is NaN\.

```csharp
public bool IsNaN();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any component is NaN; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.On(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Line3\.On\(Coordinate3, double\) Method

Determines whether a point lies on the line within the specified tolerance\.

```csharp
public bool On(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.On(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The point to test\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.On(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point lies on the line; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3\.Project\(Coordinate3\) Method

Projects a point onto the line\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The point to project\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The projected [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') on the line\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Project(DiGi.ComputeSharp.Spatial.Classes.Line3)'></a>

## Line3\.Project\(Line3\) Method

Projects another line onto this line\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Line3 Project(DiGi.ComputeSharp.Spatial.Classes.Line3 line);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.Project(DiGi.ComputeSharp.Spatial.Classes.Line3).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The line to project\.

#### Returns
[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')  
A projected [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3'), or a default line if the projection degenerates to a point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3.ToString()'></a>

## Line3\.ToString\(\) Method

Returns a string representation of the current line\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A formatted string containing the start and end coordinates\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader'></a>

## Line3IntersectComputeShader Struct

```csharp
public readonly struct Line3IntersectComputeShader : ComputeSharp.IComputeShader, ComputeSharp.Descriptors.IComputeShaderDescriptor<DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader>
```

Implements [ComputeSharp\.IComputeShader](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader 'ComputeSharp\.IComputeShader'), [ComputeSharp\.Descriptors\.IComputeShaderDescriptor&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')[Line3IntersectComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3IntersectComputeShader')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool)'></a>

## Line3IntersectComputeShader\(GraphicsDevice, IEnumerable\<Line3\>, IEnumerable\<Triangle3\>, bool, bool\) Constructor

Initializes a new instance of the [Line3IntersectComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3IntersectComputeShader') struct\.

```csharp
public Line3IntersectComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Line3> lines, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D lines to check for intersections\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D triangles to test against\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the start point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the end point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool,double)'></a>

## Line3IntersectComputeShader\(GraphicsDevice, IEnumerable\<Line3\>, IEnumerable\<Triangle3\>, bool, bool, double\) Constructor

Initializes a new instance of the [Line3IntersectComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3IntersectComputeShader') struct with a custom tolerance\.

```csharp
public Line3IntersectComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Line3> lines, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, bool includeStart, bool includeEnd, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool,double).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool,double).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D lines to check for intersections\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool,double).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D triangles to test against\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool,double).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the start point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool,double).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the end point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,bool,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,bool,bool)'></a>

## Line3IntersectComputeShader\(ReadOnlyBuffer\<Line3\>, ReadOnlyBuffer\<Triangle3\>, ReadWriteBuffer\<int\>, bool, bool\) Constructor

Initializes a new instance of the [Line3IntersectComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3IntersectComputeShader') struct using pre\-allocated buffers\.

```csharp
public Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Line3> lines, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, ComputeSharp.ReadWriteBuffer<int> result, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,bool,bool).lines'></a>

`lines` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D lines\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,bool,bool).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,bool,bool).result'></a>

`result` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing the intersection results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the start point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the end point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool)'></a>

## Line3IntersectComputeShader\(ReadOnlyBuffer\<Line3\>, ReadOnlyBuffer\<Triangle3\>, ReadWriteBuffer\<int\>, double, bool, bool\) Constructor

Initializes a new instance of the [Line3IntersectComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3IntersectComputeShader') struct using pre\-allocated buffers and a custom tolerance\.

```csharp
public Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Line3> lines, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, ComputeSharp.ReadWriteBuffer<int> result, double tolerance, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool).lines'></a>

`lines` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D lines\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool).result'></a>

`result` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing the intersection results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the start point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Line3IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the end point of each line in the intersection tests\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectComputeShader.Result'></a>

## Line3IntersectComputeShader\.Result Field

Gets the writeable buffer containing the index of the first intersecting triangle for each line, or \-1 if no intersection is found\.

```csharp
public readonly ReadWriteBuffer<int> Result;
```

#### Field Value
[ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection'></a>

## Line3Intersection Struct

Represents the result of an intersection operation in 3D space, which can be a single point, two points, or a line segment\.

```csharp
public readonly struct Line3Intersection : DiGi.ComputeSharp.Spatial.Interfaces.IIntersection3, DiGi.ComputeSharp.Core.Interfaces.IIntersection, DiGi.ComputeSharp.Core.Interfaces.IResult
```

Implements [IIntersection3](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IIntersection3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IIntersection3'), [IIntersection](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IIntersection 'DiGi\.ComputeSharp\.Core\.Interfaces\.IIntersection'), [IResult](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IResult 'DiGi\.ComputeSharp\.Core\.Interfaces\.IResult')
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

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

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

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3Intersection\(Coordinate3\) Constructor

Initializes a new instance of the [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection') struct with the first point\.

```csharp
public Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Line3Intersection\(Coordinate3, Coordinate3\) Constructor

Initializes a new instance of the [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection') struct with two coordinate points\.

```csharp
public Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3)'></a>

## Line3Intersection\(Line3\) Constructor

Initializes a new instance of the [Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection') struct from an existing line\.

```csharp
public Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3 line);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Line3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The line to use for initialization\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Point_1'></a>

## Line3Intersection\.Point\_1 Field

The first coordinate point of the intersection\.

```csharp
public readonly Coordinate3 Point_1;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.Point_2'></a>

## Line3Intersection\.Point\_2 Field

The second coordinate point of the intersection, used when the result is a line segment\.

```csharp
public readonly Coordinate3 Point_2;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

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

Implements [GetIntersectionGeometries\(Nullable&lt;bool&gt;\)](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IIntersection3.GetIntersectionGeometries(System.Nullable_bool_) 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IIntersection3\.GetIntersectionGeometries\(System\.Nullable\<bool\>\)')

#### Returns
[IGeometry3](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of [IGeometry3](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3') objects representing the intersection, or null if the primary point is NaN\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.GetLine()'></a>

## Line3Intersection\.GetLine\(\) Method

Converts the intersection result into a line segment if it is marked as solid and contains valid points\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Line3 GetLine();
```

#### Returns
[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')  
A [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') representing the intersection line, or an empty line if not applicable\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3Intersection.IsNaN()'></a>

## Line3Intersection\.IsNaN\(\) Method

Determines whether the intersection result is Not\-a\-Number \(NaN\)\.

```csharp
public bool IsNaN();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the first point is NaN; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader'></a>

## Line3IntersectionComputeShader Struct

```csharp
public readonly struct Line3IntersectionComputeShader : ComputeSharp.IComputeShader, ComputeSharp.Descriptors.IComputeShaderDescriptor<DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader>
```

Implements [ComputeSharp\.IComputeShader](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader 'ComputeSharp\.IComputeShader'), [ComputeSharp\.Descriptors\.IComputeShaderDescriptor&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')[Line3IntersectionComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3IntersectionComputeShader')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_)'></a>

## Line3IntersectionComputeShader\(GraphicsDevice, Line3, IEnumerable\<Line3\>\) Constructor

Initializes a new instance of the [Line3IntersectionComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3IntersectionComputeShader') struct\.

```csharp
public Line3IntersectionComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, DiGi.ComputeSharp.Spatial.Classes.Line3 line, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Line3> lines);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The primary 3D line to intersect with other lines\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D lines to check against the primary line\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,double)'></a>

## Line3IntersectionComputeShader\(GraphicsDevice, Line3, IEnumerable\<Line3\>, double\) Constructor

Initializes a new instance of the [Line3IntersectionComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3IntersectionComputeShader') struct with a custom tolerance\.

```csharp
public Line3IntersectionComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, DiGi.ComputeSharp.Spatial.Classes.Line3 line, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Line3> lines, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,double).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,double).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The primary 3D line to intersect with other lines\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,double).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D lines to check against the primary line\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Line3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Line3_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3Intersection_)'></a>

## Line3IntersectionComputeShader\(Line3, ReadOnlyBuffer\<Line3\>, ReadWriteBuffer\<Line3Intersection\>\) Constructor

Initializes a new instance of the [Line3IntersectionComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3IntersectionComputeShader') struct using pre\-allocated buffers\.

```csharp
public Line3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Line3 line, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Line3> lines, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Spatial.Classes.Line3Intersection> lineIntersections);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3Intersection_).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The primary 3D line to intersect with other lines\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3Intersection_).lines'></a>

`lines` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D lines to check against\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3Intersection_).lineIntersections'></a>

`lineIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing the intersection results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3Intersection_,double)'></a>

## Line3IntersectionComputeShader\(Line3, ReadOnlyBuffer\<Line3\>, ReadWriteBuffer\<Line3Intersection\>, double\) Constructor

Initializes a new instance of the [Line3IntersectionComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3IntersectionComputeShader') struct using pre\-allocated buffers and a custom tolerance\.

```csharp
public Line3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Line3 line, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Line3> lines, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Spatial.Classes.Line3Intersection> lineIntersections, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3Intersection_,double).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The primary 3D line to intersect with other lines\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3Intersection_,double).lines'></a>

`lines` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D lines to check against\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3Intersection_,double).lineIntersections'></a>

`lineIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing the intersection results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Line3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Line3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Line3Intersection_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.LineIntersections'></a>

## Line3IntersectionComputeShader\.LineIntersections Field

Gets the writeable buffer containing the line intersection results\.

```csharp
public readonly ReadWriteBuffer<Line3Intersection> LineIntersections;
```

#### Field Value
[ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Line3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Classes.Line3IntersectionComputeShader.Execute()'></a>

## Line3IntersectionComputeShader\.Execute\(\) Method

Executes the compute shader operation over the designated range of threads\.

```csharp
public void Execute();
```

Implements [Execute\(\)](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader.execute 'ComputeSharp\.IComputeShader\.Execute')

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane'></a>

## Plane Struct

Represents a three\-dimensional plane defined by an origin, a normal vector, and a local Y\-axis\.

```csharp
public readonly struct Plane : DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3, DiGi.ComputeSharp.Core.Interfaces.IGeometry
```

Implements [IGeometry3](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3'), [IGeometry](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IGeometry 'DiGi\.ComputeSharp\.Core\.Interfaces\.IGeometry')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Plane()'></a>

## Plane\(\) Constructor

Initializes a new instance of the [Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane') struct with default values \(NaN coordinates\)\.

```csharp
public Plane();
```

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Plane(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Plane\(Coordinate3, Coordinate3, Coordinate3\) Constructor

Initializes a new instance of the [Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane') struct with specified origin, normal, and local Y\-axis\.

```csharp
public Plane(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 origin, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 normal, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 axisY);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Plane(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).origin'></a>

`origin` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The origin point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Plane(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).normal'></a>

`normal` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The normal vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Plane(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).axisY'></a>

`axisY` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The local Y\-axis direction vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Plane(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Plane\(Coordinate3, Coordinate3, double\) Constructor

Initializes a new instance of the [Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane') struct with specified origin and normal, automatically deriving the local Y\-axis\.

```csharp
public Plane(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 origin, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 normal, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Plane(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).origin'></a>

`origin` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The origin point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Plane(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).normal'></a>

`normal` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The normal vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Plane(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for normalizations\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.AxisY'></a>

## Plane\.AxisY Field

The local Y\-axis direction vector of the plane\.

```csharp
public readonly Coordinate3 AxisY;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Normal'></a>

## Plane\.Normal Field

The normal vector of the plane\.

```csharp
public readonly Coordinate3 Normal;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Origin'></a>

## Plane\.Origin Field

The origin point of the plane\.

```csharp
public readonly Coordinate3 Origin;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Line(DiGi.ComputeSharp.Planar.Classes.Line2,double)'></a>

## Plane\.Convert\_Line\(Line2, double\) Method

Transforms a 2D line on the plane back to a 3D line in space\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Line3 Convert_Line(DiGi.ComputeSharp.Planar.Classes.Line2 line, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Line(DiGi.ComputeSharp.Planar.Classes.Line2,double).line'></a>

`line` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The 2D line on the plane\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Line(DiGi.ComputeSharp.Planar.Classes.Line2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for calculations\.

#### Returns
[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')  
A 3D [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') in space\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Line(DiGi.ComputeSharp.Spatial.Classes.Line3,double)'></a>

## Plane\.Convert\_Line\(Line3, double\) Method

Projects a 3D line onto the plane and converts it to a local 2D line representation\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Line2 Convert_Line(DiGi.ComputeSharp.Spatial.Classes.Line3 line, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Line(DiGi.ComputeSharp.Spatial.Classes.Line3,double).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The 3D line in space\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Line(DiGi.ComputeSharp.Spatial.Classes.Line3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for calculations\.

#### Returns
[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')  
A local 2D [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') on the plane\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Point(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double)'></a>

## Plane\.Convert\_Point\(Coordinate2, double\) Method

Converts local 2D coordinates on the plane back to a 3D point in space\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Convert_Point(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Point(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The local 2D point on the plane\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Point(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for calculations\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A 3D [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') in space\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Point(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Plane\.Convert\_Point\(Coordinate3, double\) Method

Projects a 3D point onto the plane and converts it to local 2D coordinates\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 Convert_Point(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Point(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The 3D point in space\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Point(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for calculations\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A local [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representation on the plane\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Triangle(DiGi.ComputeSharp.Planar.Classes.Triangle2,double)'></a>

## Plane\.Convert\_Triangle\(Triangle2, double\) Method

Converts a local 2D triangle on the plane back to a 3D triangle in space\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Triangle3 Convert_Triangle(DiGi.ComputeSharp.Planar.Classes.Triangle2 triangle, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Triangle(DiGi.ComputeSharp.Planar.Classes.Triangle2,double).triangle'></a>

`triangle` [Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')

The local 2D triangle on the plane\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Triangle(DiGi.ComputeSharp.Planar.Classes.Triangle2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for calculations\.

#### Returns
[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')  
A 3D [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3') in space\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Triangle(DiGi.ComputeSharp.Spatial.Classes.Triangle3,double)'></a>

## Plane\.Convert\_Triangle\(Triangle3, double\) Method

Projects a 3D triangle onto the plane and converts it to a local 2D triangle representation\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Triangle2 Convert_Triangle(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Triangle(DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The 3D triangle in space\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Triangle(DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for calculations\.

#### Returns
[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')  
A local 2D [Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2') on the plane\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Vector(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double)'></a>

## Plane\.Convert\_Vector\(Coordinate2, double\) Method

Converts local 2D coordinates representing a vector on the plane back to a 3D vector\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Convert_Vector(DiGi.ComputeSharp.Planar.Classes.Coordinate2 vector, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Vector(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).vector'></a>

`vector` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The local 2D vector on the plane\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Vector(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for calculations\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A 3D [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') vector in space\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Vector(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Plane\.Convert\_Vector\(Coordinate3, double\) Method

Projects a 3D vector onto the plane and converts it to local 2D coordinates\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 Convert_Vector(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Vector(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The 3D vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Convert_Vector(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for calculations\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A local 2D [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representation of the vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetApproximateDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Plane\.GetApproximateDistance\(Coordinate3\) Method

Calculates the approximate distance from a point to this plane\.

```csharp
public double GetApproximateDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetApproximateDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The target point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The approximate distance value\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetAxisX(double)'></a>

## Plane\.GetAxisX\(double\) Method

Derives the local X\-axis vector of the plane\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetAxisX(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetAxisX(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for normalization\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The derived local X\-axis [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetClosestPoint(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Plane\.GetClosestPoint\(Coordinate3\) Method

Finds the point on this plane that is closest to the specified point\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetClosestPoint(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetClosestPoint(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The point to project onto the plane\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The closest [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') on this plane\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Plane\.GetDistance\(Coordinate3, double\) Method

Calculates the distance from a point to this plane with a specified tolerance\.

```csharp
public double GetDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The target point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for calculations\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance value\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetInversed()'></a>

## Plane\.GetInversed\(\) Method

Returns a new plane with inverted normal and Y\-axis directions\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Plane GetInversed();
```

#### Returns
[Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')  
An inverted [Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetMoved(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Plane\.GetMoved\(Coordinate3\) Method

Translates the plane by the specified offset vector\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Plane GetMoved(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetMoved(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The translation vector\.

#### Returns
[Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')  
A translated [Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetSquaredDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Plane\.GetSquaredDistance\(Coordinate3\) Method

Calculates the squared distance from a point to this plane\.

```csharp
public double GetSquaredDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.GetSquaredDistance(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The target point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The squared distance value\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.IsNaN()'></a>

## Plane\.IsNaN\(\) Method

Checks if any vector or origin defining this plane is NaN\.

```csharp
public bool IsNaN();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if AxisY, Normal, or Origin is NaN; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.On(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Plane\.On\(Coordinate3, double\) Method

Checks if a point lies on the plane within the specified tolerance\.

```csharp
public bool On(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.On(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The point to test\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.On(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point lies on the plane; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Plane\.Project\(Coordinate3\) Method

Orthogonally projects a point onto the plane\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The point to project\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The closest 3D [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') point on the plane\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Plane\.Project\(Coordinate3, Coordinate3, double\) Method

Projects a point onto the plane along a specified direction vector\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The point to project\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The projection direction vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for comparison checks\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The projected 3D [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') point, or NaN if the projection is parallel to the plane\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Line3)'></a>

## Plane\.Project\(Line3\) Method

Orthogonally projects a line onto the plane\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Line3 Project(DiGi.ComputeSharp.Spatial.Classes.Line3 line);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Line3).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The line to project\.

#### Returns
[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')  
The projected [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Plane\.Project\(Line3, Coordinate3, double\) Method

Projects a line onto the plane along a specified direction vector\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Line3 Project(DiGi.ComputeSharp.Spatial.Classes.Line3 line, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The line to project\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The projection direction vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Line3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

#### Returns
[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')  
The projected [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3'), or NaN if any point cannot be projected\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Plane\.Project\(Plane, Coordinate3, double\) Method

Projects another plane onto this plane along a specified direction vector\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Plane Project(DiGi.ComputeSharp.Spatial.Classes.Plane plane, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).plane'></a>

`plane` [Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')

The plane to project\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The projection direction vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Plane,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

#### Returns
[Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')  
The projected [Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Plane,double)'></a>

## Plane\.Project\(Plane, double\) Method

Orthogonally projects another plane onto this plane\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Plane Project(DiGi.ComputeSharp.Spatial.Classes.Plane plane, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Plane,double).plane'></a>

`plane` [Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')

The plane to project\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Plane,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

#### Returns
[Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')  
The projected [Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Triangle3)'></a>

## Plane\.Project\(Triangle3\) Method

Orthogonally projects a triangle onto the plane\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Triangle3 Project(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3'></a>

`triangle3` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The triangle to project\.

#### Returns
[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')  
The projected [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Plane\.Project\(Triangle3, Coordinate3, double\) Method

Projects a triangle onto the plane along a specified direction vector\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Triangle3 Project(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The triangle to project\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The projection direction vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.Project(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

#### Returns
[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')  
The projected [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3'), or NaN if any point cannot be projected\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Plane.ToString()'></a>

## Plane\.ToString\(\) Method

Returns a string representation of the current plane\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A formatted string containing the origin, normal, and local Y\-axis coordinates\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3'></a>

## Triangle3 Struct

Represents a three\-dimensional triangle in a spatial coordinate system\.

```csharp
public readonly struct Triangle3 : DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3, DiGi.ComputeSharp.Core.Interfaces.IGeometry
```

Implements [IGeometry3](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3'), [IGeometry](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IGeometry 'DiGi\.ComputeSharp\.Core\.Interfaces\.IGeometry')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3()'></a>

## Triangle3\(\) Constructor

Initializes a new instance of the [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3') struct with default values \(NaN coordinates and not solid\)\.

```csharp
public Triangle3();
```

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Triangle3\(Bool, Coordinate3, Coordinate3, Coordinate3\) Constructor

Initializes a new instance of the [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3') struct with specified solid state and vertices\.

```csharp
public Triangle3(DiGi.ComputeSharp.Core.Classes.Bool solid, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).solid'></a>

`solid` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

A value indicating whether the triangle is solid\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first vertex\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second vertex\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_3'></a>

`point_3` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The third vertex\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double,double,double,double)'></a>

## Triangle3\(Bool, double, double, double, double, double, double, double, double, double\) Constructor

Initializes a new instance of the [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3') struct with specified solid state and coordinates\.

```csharp
public Triangle3(DiGi.ComputeSharp.Core.Classes.Bool solid, double x_1, double y_1, double z_1, double x_2, double y_2, double z_2, double x_3, double y_3, double z_3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double,double,double,double).solid'></a>

`solid` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

A value indicating whether the triangle is solid\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double,double,double,double).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X component of the first point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double,double,double,double).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y component of the first point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double,double,double,double).z_1'></a>

`z_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z component of the first point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double,double,double,double).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X component of the second point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double,double,double,double).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y component of the second point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double,double,double,double).z_2'></a>

`z_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z component of the second point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double,double,double,double).x_3'></a>

`x_3` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X component of the third point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double,double,double,double).y_3'></a>

`y_3` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y component of the third point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double,double,double,double,double,double).z_3'></a>

`z_3` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z component of the third point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Triangle3\(Coordinate3, Coordinate3, Coordinate3\) Constructor

Initializes a new instance of the [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3') struct with the specified vertices\.

```csharp
public Triangle3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_1, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_2, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point_3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_1'></a>

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first vertex\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second vertex\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_3'></a>

`point_3` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The third vertex\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Spatial.Classes.Triangle3)'></a>

## Triangle3\(Triangle3\) Constructor

Initializes a new instance of the [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3') struct by copying an existing triangle\.

```csharp
public Triangle3(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Triangle3(DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3'></a>

`triangle3` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The source triangle to copy\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Point_1'></a>

## Triangle3\.Point\_1 Field

The first vertex of the triangle\.

```csharp
public readonly Coordinate3 Point_1;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Point_2'></a>

## Triangle3\.Point\_2 Field

The second vertex of the triangle\.

```csharp
public readonly Coordinate3 Point_2;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Point_3'></a>

## Triangle3\.Point\_3 Field

The third vertex of the triangle\.

```csharp
public readonly Coordinate3 Point_3;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Solid'></a>

## Triangle3\.Solid Field

A value indicating whether the triangle is solid \(filled\) or boundary\-only\.

```csharp
public readonly Bool Solid;
```

#### Field Value
[Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetApproximatePerimeter()'></a>

## Triangle3\.GetApproximatePerimeter\(\) Method

Calculates the approximate perimeter of the triangle using fast distance calculations\.

```csharp
public double GetApproximatePerimeter();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The approximate perimeter of the triangle\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetArea(double)'></a>

## Triangle3\.GetArea\(double\) Method

Calculates the area of the 3D triangle with the specified tolerance\.

```csharp
public double GetArea(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetArea(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for distance and projection calculations\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The area of the triangle, or NaN if any component is NaN\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetCentroid()'></a>

## Triangle3\.GetCentroid\(\) Method

Gets the centroid \(geometric center\) of the 3D triangle\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetCentroid();
```

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the centroid of the triangle\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetEquilateralityFactor()'></a>

## Triangle3\.GetEquilateralityFactor\(\) Method

Calculates the equilaterality factor of the triangle, indicating how close it is to an equilateral triangle\.

```csharp
public double GetEquilateralityFactor();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The equilaterality factor \(0 to 1, where 1 is perfectly equilateral\)\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetInversed()'></a>

## Triangle3\.GetInversed\(\) Method

Gets a new triangle with inverted winding order \(reversing normal direction\)\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Triangle3 GetInversed();
```

#### Returns
[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')  
An inverted [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetLine(int)'></a>

## Triangle3\.GetLine\(int\) Method

Gets one of the boundary lines of the triangle by index\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Line3 GetLine(int index);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetLine(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The line index \(0, 1, or 2\)\.

#### Returns
[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')  
The boundary [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') at the specified index\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetLines()'></a>

## Triangle3\.GetLines\(\) Method

Gets all boundary lines of the triangle\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Line3[] GetLines();
```

#### Returns
[Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of three [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3') objects representing the boundary lines\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetMax()'></a>

## Triangle3\.GetMax\(\) Method

Gets the maximum coordinate bounds of the triangle\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetMax();
```

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the maximum X, Y, and Z coordinates\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetMin()'></a>

## Triangle3\.GetMin\(\) Method

Gets the minimum coordinate bounds of the triangle\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetMin();
```

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
A [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3') representing the minimum X, Y, and Z coordinates\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetMoved(DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Triangle3\.GetMoved\(Coordinate3\) Method

Translates the triangle by the specified offset vector\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Triangle3 GetMoved(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetMoved(DiGi.ComputeSharp.Spatial.Classes.Coordinate3).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The translation vector\.

#### Returns
[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')  
A translated [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetNormal(double)'></a>

## Triangle3\.GetNormal\(double\) Method

Calculates the normal vector of the triangle\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Coordinate3 GetNormal(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetNormal(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for vector normalization\.

#### Returns
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')  
The normalized normal vector\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetPerimeter(double)'></a>

## Triangle3\.GetPerimeter\(double\) Method

Calculates the perimeter of the triangle with the specified tolerance\.

```csharp
public double GetPerimeter(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetPerimeter(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for distance calculations\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The perimeter of the triangle\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetPlane(double)'></a>

## Triangle3\.GetPlane\(double\) Method

Gets the plane defined by the triangle's vertices and its normal vector\.

```csharp
public DiGi.ComputeSharp.Spatial.Classes.Plane GetPlane(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.GetPlane(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for normal calculation\.

#### Returns
[Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane')  
The [Plane](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Plane 'DiGi\.ComputeSharp\.Spatial\.Classes\.Plane') on which the triangle lies\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Triangle3\.InRange\(Coordinate3, double\) Method

Checks if a point is within the range of the triangle's bounding box expanded by a tolerance\.

```csharp
public bool InRange(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The point to check\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance used to expand the bounding box\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is within range; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(DiGi.ComputeSharp.Spatial.Classes.Line3,double)'></a>

## Triangle3\.InRange\(Line3, double\) Method

Checks if a line is within the bounding range of the triangle\.

```csharp
public bool InRange(DiGi.ComputeSharp.Spatial.Classes.Line3 line3, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(DiGi.ComputeSharp.Spatial.Classes.Line3,double).line3'></a>

`line3` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

The line to check\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(DiGi.ComputeSharp.Spatial.Classes.Line3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the bounding boxes overlap; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(DiGi.ComputeSharp.Spatial.Classes.Triangle3,double)'></a>

## Triangle3\.InRange\(Triangle3, double\) Method

Checks if another triangle is within the bounding range of this triangle\.

```csharp
public bool InRange(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).triangle3'></a>

`triangle3` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The other triangle to check\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(DiGi.ComputeSharp.Spatial.Classes.Triangle3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the triangles' bounding boxes overlap; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(double,double,double,double)'></a>

## Triangle3\.InRange\(double, double, double, double\) Method

Checks if a set of coordinates is within the bounding box of the triangle expanded by a tolerance\.

```csharp
public bool InRange(double x, double y, double z, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(double,double,double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X component of the point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(double,double,double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y component of the point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(double,double,double,double).z'></a>

`z` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Z component of the point\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.InRange(double,double,double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance used to expand the bounding box\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the coordinates are within the expanded bounding box; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Inside(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Triangle3\.Inside\(Coordinate3, double\) Method

Determines whether a point lies inside the triangle using barycentric coordinates in 3D\.

```csharp
public bool Inside(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Inside(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The point to test\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.Inside(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numerical tolerance value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point lies inside or on the boundary of the triangle; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.IsNaN()'></a>

## Triangle3\.IsNaN\(\) Method

Checks if any of the triangle's vertices contain NaN coordinates\.

```csharp
public bool IsNaN();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any vertex is NaN; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.On(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Triangle3\.On\(Coordinate3, double\) Method

Determines whether a point lies on the triangle \(inside if solid, or on boundary lines if not\)\.

```csharp
public bool On(DiGi.ComputeSharp.Spatial.Classes.Coordinate3 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.On(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).point'></a>

`point` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The point to test\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.On(DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point lies on the triangle; otherwise, false\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3.ToString()'></a>

## Triangle3\.ToString\(\) Method

Returns a string representation of the current triangle\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A formatted string describing the triangle vertices\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader'></a>

## Triangle3ExternalShadingComputeShader Struct

```csharp
public readonly struct Triangle3ExternalShadingComputeShader : ComputeSharp.IComputeShader, ComputeSharp.Descriptors.IComputeShaderDescriptor<DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader>
```

Implements [ComputeSharp\.IComputeShader](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader 'ComputeSharp\.IComputeShader'), [ComputeSharp\.Descriptors\.IComputeShaderDescriptor&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')[Triangle3ExternalShadingComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3ExternalShadingComputeShader')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Triangle3ExternalShadingComputeShader\(GraphicsDevice, IEnumerable\<Triangle3\>, IEnumerable\<Triangle3\>, Coordinate3\) Constructor

Initializes a new instance of the [Triangle3ExternalShadingComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3ExternalShadingComputeShader') struct\.

```csharp
public Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> externalTriangles, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of target 3D triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).externalTriangles'></a>

`externalTriangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of external 3D shading/blocking triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The direction vector for the shading calculation\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Triangle3ExternalShadingComputeShader\(GraphicsDevice, IEnumerable\<Triangle3\>, IEnumerable\<Triangle3\>, Coordinate3, double\) Constructor

Initializes a new instance of the [Triangle3ExternalShadingComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3ExternalShadingComputeShader') struct with a custom tolerance\.

```csharp
public Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> externalTriangles, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of target 3D triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).externalTriangles'></a>

`externalTriangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of external 3D shading/blocking triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The direction vector for the shading calculation\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Triangle3ExternalShadingComputeShader\(ReadOnlyBuffer\<Triangle3\>, ReadOnlyBuffer\<Triangle3\>, ReadWriteBuffer\<Triangle3Intersection\>, Coordinate3\) Constructor

Initializes a new instance of the [Triangle3ExternalShadingComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3ExternalShadingComputeShader') struct using pre\-allocated buffers\.

```csharp
public Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> externalTriangles, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection> triangleIntersections, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of target 3D triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).externalTriangles'></a>

`externalTriangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of external 3D shading triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).triangleIntersections'></a>

`triangleIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing intersection results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The direction vector for the shading calculation\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Triangle3ExternalShadingComputeShader\(ReadOnlyBuffer\<Triangle3\>, ReadOnlyBuffer\<Triangle3\>, ReadWriteBuffer\<Triangle3Intersection\>, Coordinate3, double\) Constructor

Initializes a new instance of the [Triangle3ExternalShadingComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3ExternalShadingComputeShader') struct using pre\-allocated buffers and a custom tolerance\.

```csharp
public Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> externalTriangles, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection> triangleIntersections, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of target 3D triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).externalTriangles'></a>

`externalTriangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of external 3D shading triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).triangleIntersections'></a>

`triangleIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing intersection results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The direction vector for the shading calculation\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Triangle3ExternalShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.TriangleIntersections'></a>

## Triangle3ExternalShadingComputeShader\.TriangleIntersections Field

Gets the writeable buffer containing the triangle intersection results\.

```csharp
public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;
```

#### Field Value
[ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ExternalShadingComputeShader.Execute()'></a>

## Triangle3ExternalShadingComputeShader\.Execute\(\) Method

Executes the compute shader operation over the designated range of threads\.

```csharp
public void Execute();
```

Implements [Execute\(\)](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader.execute 'ComputeSharp\.IComputeShader\.Execute')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection'></a>

## Triangle3Intersection Struct

Represents a 3D triangle intersection result containing up to six coordinates and a solidity flag\.

```csharp
public struct Triangle3Intersection : DiGi.ComputeSharp.Spatial.Interfaces.IIntersection3, DiGi.ComputeSharp.Core.Interfaces.IIntersection, DiGi.ComputeSharp.Core.Interfaces.IResult
```

Implements [IIntersection3](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IIntersection3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IIntersection3'), [IIntersection](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IIntersection 'DiGi\.ComputeSharp\.Core\.Interfaces\.IIntersection'), [IResult](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IResult 'DiGi\.ComputeSharp\.Core\.Interfaces\.IResult')
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

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

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

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

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

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_3'></a>

`point_3` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

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

`point_1` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The first coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_2'></a>

`point_2` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The second coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_3'></a>

`point_3` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The third coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_4'></a>

`point_4` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The fourth coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_5'></a>

`point_5` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The fifth coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).point_6'></a>

`point_6` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The sixth coordinate\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3)'></a>

## Triangle3Intersection\(Line3\) Constructor

Initializes a new instance of the [Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection') struct from a [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')\.

```csharp
public Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3 line);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Triangle3Intersection(DiGi.ComputeSharp.Spatial.Classes.Line3).line'></a>

`line` [Line3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Line3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Line3')

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
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Point_2'></a>

## Triangle3Intersection\.Point\_2 Field

The second coordinate of the intersection\.

```csharp
public readonly Coordinate3 Point_2;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Point_3'></a>

## Triangle3Intersection\.Point\_3 Field

The third coordinate of the intersection\.

```csharp
public readonly Coordinate3 Point_3;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Point_4'></a>

## Triangle3Intersection\.Point\_4 Field

The fourth coordinate of the intersection\.

```csharp
public readonly Coordinate3 Point_4;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Point_5'></a>

## Triangle3Intersection\.Point\_5 Field

The fifth coordinate of the intersection\.

```csharp
public readonly Coordinate3 Point_5;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection.Point_6'></a>

## Triangle3Intersection\.Point\_6 Field

The sixth coordinate of the intersection\.

```csharp
public readonly Coordinate3 Point_6;
```

#### Field Value
[Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

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

Implements [GetIntersectionGeometries\(Nullable&lt;bool&gt;\)](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IIntersection3.GetIntersectionGeometries(System.Nullable_bool_) 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IIntersection3\.GetIntersectionGeometries\(System\.Nullable\<bool\>\)')

#### Returns
[IGeometry3](DiGi.ComputeSharp.Spatial.Interfaces.md#DiGi.ComputeSharp.Spatial.Interfaces.IGeometry3 'DiGi\.ComputeSharp\.Spatial\.Interfaces\.IGeometry3')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
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

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader'></a>

## Triangle3IntersectionComputeShader Struct

```csharp
public readonly struct Triangle3IntersectionComputeShader : ComputeSharp.IComputeShader, ComputeSharp.Descriptors.IComputeShaderDescriptor<DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader>
```

Implements [ComputeSharp\.IComputeShader](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader 'ComputeSharp\.IComputeShader'), [ComputeSharp\.Descriptors\.IComputeShaderDescriptor&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')[Triangle3IntersectionComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3IntersectionComputeShader')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_)'></a>

## Triangle3IntersectionComputeShader\(GraphicsDevice, Triangle3, IEnumerable\<Triangle3\>\) Constructor

Initializes a new instance of the [Triangle3IntersectionComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3IntersectionComputeShader') struct\.

```csharp
public Triangle3IntersectionComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The primary 3D triangle to intersect with other triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D triangles to check against the primary triangle\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double)'></a>

## Triangle3IntersectionComputeShader\(GraphicsDevice, Triangle3, IEnumerable\<Triangle3\>, double\) Constructor

Initializes a new instance of the [Triangle3IntersectionComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3IntersectionComputeShader') struct with a custom tolerance\.

```csharp
public Triangle3IntersectionComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The primary 3D triangle to intersect with other triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D triangles to check against the primary triangle\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Spatial.Classes.Triangle3,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Triangle3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_)'></a>

## Triangle3IntersectionComputeShader\(Triangle3, ReadOnlyBuffer\<Triangle3\>, ReadWriteBuffer\<Triangle3Intersection\>\) Constructor

Initializes a new instance of the [Triangle3IntersectionComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3IntersectionComputeShader') struct using pre\-allocated buffers\.

```csharp
public Triangle3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection> triangleIntersections);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Triangle3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The primary 3D triangle to intersect with other triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Triangle3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D triangles to check against\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Triangle3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_).triangleIntersections'></a>

`triangleIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing intersection results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Triangle3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,double)'></a>

## Triangle3IntersectionComputeShader\(Triangle3, ReadOnlyBuffer\<Triangle3\>, ReadWriteBuffer\<Triangle3Intersection\>, double\) Constructor

Initializes a new instance of the [Triangle3IntersectionComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3IntersectionComputeShader') struct using pre\-allocated buffers and a custom tolerance\.

```csharp
public Triangle3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection> triangleIntersections, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Triangle3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,double).triangle'></a>

`triangle` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The primary 3D triangle to intersect with other triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Triangle3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,double).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D triangles to check against\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Triangle3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,double).triangleIntersections'></a>

`triangleIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing intersection results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Triangle3IntersectionComputeShader(DiGi.ComputeSharp.Spatial.Classes.Triangle3,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.TriangleIntersections'></a>

## Triangle3IntersectionComputeShader\.TriangleIntersections Field

Gets the writeable buffer containing the triangle intersection results\.

```csharp
public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;
```

#### Field Value
[ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionComputeShader.Execute()'></a>

## Triangle3IntersectionComputeShader\.Execute\(\) Method

Executes the compute shader operation over the designated range of threads\.

```csharp
public void Execute();
```

Implements [Execute\(\)](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader.execute 'ComputeSharp\.IComputeShader\.Execute')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader'></a>

## Triangle3IntersectionsComputeShader Struct

```csharp
public readonly struct Triangle3IntersectionsComputeShader : ComputeSharp.IComputeShader, ComputeSharp.Descriptors.IComputeShaderDescriptor<DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader>
```

Implements [ComputeSharp\.IComputeShader](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader 'ComputeSharp\.IComputeShader'), [ComputeSharp\.Descriptors\.IComputeShaderDescriptor&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')[Triangle3IntersectionsComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3IntersectionsComputeShader')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader.Triangle3IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_)'></a>

## Triangle3IntersectionsComputeShader\(ReadOnlyBuffer\<Triangle3\>, ReadOnlyBuffer\<Triangle3\>, ReadWriteBuffer\<Triangle3Intersection\>\) Constructor

Initializes a new instance of the [Triangle3IntersectionsComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3IntersectionsComputeShader') struct\.

```csharp
public Triangle3IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles_1, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles_2, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection> triangleIntersections);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader.Triangle3IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_).triangles_1'></a>

`triangles_1` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of the first collection of 3D triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader.Triangle3IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_).triangles_2'></a>

`triangles_2` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of the second collection of 3D triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader.Triangle3IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_).triangleIntersections'></a>

`triangleIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing intersection results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader.Triangle3IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,double)'></a>

## Triangle3IntersectionsComputeShader\(ReadOnlyBuffer\<Triangle3\>, ReadOnlyBuffer\<Triangle3\>, ReadWriteBuffer\<Triangle3Intersection\>, double\) Constructor

Initializes a new instance of the [Triangle3IntersectionsComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3IntersectionsComputeShader') struct with a custom tolerance\.

```csharp
public Triangle3IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles_1, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles_2, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection> triangleIntersections, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader.Triangle3IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,double).triangles_1'></a>

`triangles_1` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of the first collection of 3D triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader.Triangle3IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,double).triangles_2'></a>

`triangles_2` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of the second collection of 3D triangles\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader.Triangle3IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,double).triangleIntersections'></a>

`triangleIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing intersection results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader.Triangle3IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader.TriangleIntersections'></a>

## Triangle3IntersectionsComputeShader\.TriangleIntersections Field

Gets the writeable buffer containing the triangle\-to\-triangle intersection results\.

```csharp
public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;
```

#### Field Value
[ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3IntersectionsComputeShader.Execute()'></a>

## Triangle3IntersectionsComputeShader\.Execute\(\) Method

Executes the compute shader operation over the designated range of threads\.

```csharp
public void Execute();
```

Implements [Execute\(\)](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader.execute 'ComputeSharp\.IComputeShader\.Execute')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader'></a>

## Triangle3ShadingComputeShader Struct

```csharp
public readonly struct Triangle3ShadingComputeShader : ComputeSharp.IComputeShader, ComputeSharp.Descriptors.IComputeShaderDescriptor<DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader>
```

Implements [ComputeSharp\.IComputeShader](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader 'ComputeSharp\.IComputeShader'), [ComputeSharp\.Descriptors\.IComputeShaderDescriptor&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')[Triangle3ShadingComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3ShadingComputeShader')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')
### Constructors

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Triangle3ShadingComputeShader\(GraphicsDevice, IEnumerable\<Triangle3\>, Coordinate3\) Constructor

Initializes a new instance of the [Triangle3ShadingComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3ShadingComputeShader') struct\.

```csharp
public Triangle3ShadingComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D triangles to test against each other for shading\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The direction vector for the shading calculation\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Triangle3ShadingComputeShader\(GraphicsDevice, IEnumerable\<Triangle3\>, Coordinate3, double\) Constructor

Initializes a new instance of the [Triangle3ShadingComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3ShadingComputeShader') struct with a custom tolerance\.

```csharp
public Triangle3ShadingComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 3D triangles to test against each other for shading\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The direction vector for the shading calculation\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3)'></a>

## Triangle3ShadingComputeShader\(ReadOnlyBuffer\<Triangle3\>, ReadWriteBuffer\<Triangle3Intersection\>, Coordinate3\) Constructor

Initializes a new instance of the [Triangle3ShadingComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3ShadingComputeShader') struct using pre\-allocated buffers\.

```csharp
public Triangle3ShadingComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection> triangleIntersections, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D triangles to test against each other\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).triangleIntersections'></a>

`triangleIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing shading results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The direction vector for the shading calculation\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double)'></a>

## Triangle3ShadingComputeShader\(ReadOnlyBuffer\<Triangle3\>, ReadWriteBuffer\<Triangle3Intersection\>, Coordinate3, double\) Constructor

Initializes a new instance of the [Triangle3ShadingComputeShader](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3ShadingComputeShader') struct using pre\-allocated buffers and a custom tolerance\.

```csharp
public Triangle3ShadingComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3> triangles, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection> triangleIntersections, DiGi.ComputeSharp.Spatial.Classes.Coordinate3 vector, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 3D triangles to test against each other\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).triangleIntersections'></a>

`triangleIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing shading results\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).vector'></a>

`vector` [Coordinate3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Coordinate3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Coordinate3')

The direction vector for the shading calculation\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Triangle3ShadingComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection_,DiGi.ComputeSharp.Spatial.Classes.Coordinate3,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.TriangleIntersections'></a>

## Triangle3ShadingComputeShader\.TriangleIntersections Field

Gets the writeable buffer containing the triangle shading intersection results\.

```csharp
public readonly ReadWriteBuffer<Triangle3Intersection> TriangleIntersections;
```

#### Field Value
[ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Triangle3Intersection](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3Intersection 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')
### Methods

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangle3ShadingComputeShader.Execute()'></a>

## Triangle3ShadingComputeShader\.Execute\(\) Method

Executes the compute shader operation over the designated range of threads\.

```csharp
public void Execute();
```

Implements [Execute\(\)](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader.execute 'ComputeSharp\.IComputeShader\.Execute')

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

`triangle3` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The first triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3)'></a>

## Triangulation3\(Triangle3, Triangle3\) Constructor

Initializes a new instance of the [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3') struct with two specified triangles\.

```csharp
public Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_1, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_1'></a>

`triangle3_1` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The first triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_2'></a>

`triangle3_2` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The second triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3)'></a>

## Triangulation3\(Triangle3, Triangle3, Triangle3\) Constructor

Initializes a new instance of the [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3') struct with three specified triangles\.

```csharp
public Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_1, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_2, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_1'></a>

`triangle3_1` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The first triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_2'></a>

`triangle3_2` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The second triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_3'></a>

`triangle3_3` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The third triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3)'></a>

## Triangulation3\(Triangle3, Triangle3, Triangle3, Triangle3\) Constructor

Initializes a new instance of the [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3') struct with four specified triangles\.

```csharp
public Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_1, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_2, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_3, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_4);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_1'></a>

`triangle3_1` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The first triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_2'></a>

`triangle3_2` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The second triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_3'></a>

`triangle3_3` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The third triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_4'></a>

`triangle3_4` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The fourth triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3)'></a>

## Triangulation3\(Triangle3, Triangle3, Triangle3, Triangle3, Triangle3\) Constructor

Initializes a new instance of the [Triangulation3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangulation3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangulation3') struct with five specified triangles\.

```csharp
public Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_1, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_2, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_3, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_4, DiGi.ComputeSharp.Spatial.Classes.Triangle3 triangle3_5);
```
#### Parameters

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_1'></a>

`triangle3_1` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The first triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_2'></a>

`triangle3_2` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The second triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_3'></a>

`triangle3_3` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The third triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_4'></a>

`triangle3_4` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The fourth triangle to assign\.

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.Triangulation3(DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3,DiGi.ComputeSharp.Spatial.Classes.Triangle3).triangle3_5'></a>

`triangle3_5` [Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

The fifth triangle to assign\.
### Fields

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.triangle_1'></a>

## Triangulation3\.triangle\_1 Field

The first triangle in the triangulation\.

```csharp
public readonly Triangle3 triangle_1;
```

#### Field Value
[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.triangle_2'></a>

## Triangulation3\.triangle\_2 Field

The second triangle in the triangulation\.

```csharp
public readonly Triangle3 triangle_2;
```

#### Field Value
[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.triangle_3'></a>

## Triangulation3\.triangle\_3 Field

The third triangle in the triangulation\.

```csharp
public readonly Triangle3 triangle_3;
```

#### Field Value
[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.triangle_4'></a>

## Triangulation3\.triangle\_4 Field

The fourth triangle in the triangulation\.

```csharp
public readonly Triangle3 triangle_4;
```

#### Field Value
[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')

<a name='DiGi.ComputeSharp.Spatial.Classes.Triangulation3.triangle_5'></a>

## Triangulation3\.triangle\_5 Field

The fifth triangle in the triangulation\.

```csharp
public readonly Triangle3 triangle_5;
```

#### Field Value
[Triangle3](DiGi.ComputeSharp.Spatial.Classes.md#DiGi.ComputeSharp.Spatial.Classes.Triangle3 'DiGi\.ComputeSharp\.Spatial\.Classes\.Triangle3')
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