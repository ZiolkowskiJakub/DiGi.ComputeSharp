#### [DiGi\.ComputeSharp](index.md 'index')

## DiGi\.ComputeSharp\.Planar\.Classes Namespace
### Structs

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2'></a>

## Coordinate2 Struct

Represents a two\-dimensional coordinate or vector in a planar system\.

```csharp
public readonly struct Coordinate2 : DiGi.ComputeSharp.Planar.Interfaces.IGeometry2, DiGi.ComputeSharp.Core.Interfaces.IGeometry
```

Implements [IGeometry2](DiGi.ComputeSharp.Planar.Interfaces.md#DiGi.ComputeSharp.Planar.Interfaces.IGeometry2 'DiGi\.ComputeSharp\.Planar\.Interfaces\.IGeometry2'), [IGeometry](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IGeometry 'DiGi\.ComputeSharp\.Core\.Interfaces\.IGeometry')
### Constructors

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Coordinate2()'></a>

## Coordinate2\(\) Constructor

Initializes a new instance of the [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') struct with NaN values\.

```csharp
public Coordinate2();
```

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\(Coordinate2\) Constructor

Initializes a new instance of the [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') struct by copying an existing coordinate\.

```csharp
public Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2).coordinate'></a>

`coordinate` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The source coordinate to copy\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\(Coordinate2, Coordinate2\) Constructor

Initializes a new instance of the [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') struct as a vector representing the difference between two points\.

```csharp
public Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2 start, DiGi.ComputeSharp.Planar.Classes.Coordinate2 end);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).start'></a>

`start` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The starting point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Coordinate2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).end'></a>

`end` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The ending point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Coordinate2(double,double)'></a>

## Coordinate2\(double, double\) Constructor

Initializes a new instance of the [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') struct with specified X and Y coordinates\.

```csharp
public Coordinate2(double x, double y);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Coordinate2(double,double).x'></a>

`x` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X\-coordinate\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Coordinate2(double,double).y'></a>

`y` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y\-coordinate\.
### Fields

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.X'></a>

## Coordinate2\.X Field

The X\-coordinate of the point or the X\-component of the vector\.

```csharp
public readonly double X;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Y'></a>

## Coordinate2\.Y Field

The Y\-coordinate of the point or the Y\-component of the vector\.

```csharp
public readonly double Y;
```

#### Field Value
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')
### Methods

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Add(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.Add\(Coordinate2\) Method

Performs vector addition of this coordinate and another coordinate\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 Add(DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Add(DiGi.ComputeSharp.Planar.Classes.Coordinate2).coordinate'></a>

`coordinate` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The coordinate to add\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A new [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the sum\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.AlmostEquals(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double)'></a>

## Coordinate2\.AlmostEquals\(Coordinate2, double\) Method

Determines whether this coordinate is approximately equal to another coordinate within a specified tolerance\.

```csharp
public bool AlmostEquals(DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.AlmostEquals(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).coordinate'></a>

`coordinate` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The coordinate to compare\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.AlmostEquals(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum allowed difference between coordinates\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the coordinates are within the tolerance; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.CrossProduct(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.CrossProduct\(Coordinate2\) Method

Calculates the 2D cross product of this vector and another vector\.

```csharp
public double CrossProduct(DiGi.ComputeSharp.Planar.Classes.Coordinate2 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.CrossProduct(DiGi.ComputeSharp.Planar.Classes.Coordinate2).vector'></a>

`vector` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The other vector\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The scalar result of the 2D cross product\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Divide(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.Divide\(Coordinate2\) Method

Performs component\-wise division of this coordinate by another coordinate\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 Divide(DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Divide(DiGi.ComputeSharp.Planar.Classes.Coordinate2).coordinate'></a>

`coordinate` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The divisor coordinate\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A new [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the result of the division\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Divide(double)'></a>

## Coordinate2\.Divide\(double\) Method

Divides this coordinate by a scalar factor\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 Divide(double factor);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Divide(double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The divisor value\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A new [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the result of the division\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.DotProduct(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.DotProduct\(Coordinate2\) Method

Calculates the dot product of this vector and another vector\.

```csharp
public double DotProduct(DiGi.ComputeSharp.Planar.Classes.Coordinate2 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.DotProduct(DiGi.ComputeSharp.Planar.Classes.Coordinate2).vector'></a>

`vector` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The other vector\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The scalar result of the dot product\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Equals(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.Equals\(Coordinate2\) Method

Determines whether this coordinate is equal to another coordinate based on exact values\.

```csharp
public bool Equals(DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Equals(DiGi.ComputeSharp.Planar.Classes.Coordinate2).coordinate'></a>

`coordinate` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The coordinate to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the coordinates are identical or both are NaN; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Equals(object)'></a>

## Coordinate2\.Equals\(object\) Method

Determines whether this instance is equal to a specified object\.

```csharp
public override bool Equals(object? obj);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Equals(object).obj'></a>

`obj` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to compare with the current instance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the object is a [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') and has identical values; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetApproximateDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.GetApproximateDistance\(Coordinate2\) Method

Calculates an approximate distance between this point and another point using a fast approximation formula\.

```csharp
public double GetApproximateDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetApproximateDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The target point\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
An approximated Euclidean distance\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetApproximateLength()'></a>

## Coordinate2\.GetApproximateLength\(\) Method

Calculates the approximate length of this vector from the origin \(0,0\)\.

```csharp
public double GetApproximateLength();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
An approximated magnitude of the vector\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetCentroid()'></a>

## Coordinate2\.GetCentroid\(\) Method

Calculates the centroid \(midpoint\) between this coordinate and the origin\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetCentroid();
```

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A new [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the midpoint\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetCentroid(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.GetCentroid\(Coordinate2\) Method

Calculates the centroid \(midpoint\) between this coordinate and another point\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetCentroid(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetCentroid(DiGi.ComputeSharp.Planar.Classes.Coordinate2).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The other point\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A new [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the midpoint\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double)'></a>

## Coordinate2\.GetDistance\(Coordinate2, double\) Method

Calculates the Euclidean distance between this coordinate and another point\.

```csharp
public double GetDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The target point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance used for the square root calculation\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance between the two points\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetHashCode()'></a>

## Coordinate2\.GetHashCode\(\) Method

Returns a hash code for the current coordinate\.

```csharp
public override int GetHashCode();
```

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
An integer hash code representing the coordinate's value\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetInversed()'></a>

## Coordinate2\.GetInversed\(\) Method

Returns a coordinate with inverted X and Y values\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetInversed();
```

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A new [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the inverse vector\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetLength(double)'></a>

## Coordinate2\.GetLength\(double\) Method

Calculates the magnitude \(length\) of this vector\.

```csharp
public double GetLength(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetLength(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance used for the square root calculation\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The length of the vector\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetMoved(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.GetMoved\(Coordinate2\) Method

Translates this coordinate by a given vector\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetMoved(DiGi.ComputeSharp.Planar.Classes.Coordinate2 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetMoved(DiGi.ComputeSharp.Planar.Classes.Coordinate2).vector'></a>

`vector` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The translation vector\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A new [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the moved position\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetNormalized(double)'></a>

## Coordinate2\.GetNormalized\(double\) Method

Returns a unit vector in the same direction as this coordinate\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetNormalized(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetNormalized(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

Tolerance used for length calculation\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A normalized [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') with a magnitude of 1\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetSquaredDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.GetSquaredDistance\(Coordinate2\) Method

Calculates the squared Euclidean distance between this coordinate and another\.

```csharp
public double GetSquaredDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetSquaredDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2).coordinate'></a>

`coordinate` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The target coordinate\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The squared distance value\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.GetSquaredLength()'></a>

## Coordinate2\.GetSquaredLength\(\) Method

Calculates the squared length of the coordinate vector \(X\*X \+ Y\*Y\)\.

```csharp
public double GetSquaredLength();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The sum of the squares of the X and Y components\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.InRange(DiGi.ComputeSharp.Planar.Classes.Line2,double)'></a>

## Coordinate2\.InRange\(Line2, double\) Method

Checks if this point is within the range of the specified line's bounding box expanded by a tolerance\.

```csharp
public bool InRange(DiGi.ComputeSharp.Planar.Classes.Line2 line, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.InRange(DiGi.ComputeSharp.Planar.Classes.Line2,double).line'></a>

`line` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The line to check against\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.InRange(DiGi.ComputeSharp.Planar.Classes.Line2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance used to expand the bounding box\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is within the expanded bounding box; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.InRange(DiGi.ComputeSharp.Planar.Classes.Triangle2,double)'></a>

## Coordinate2\.InRange\(Triangle2, double\) Method

Checks if this point is within the bounding box of the specified triangle expanded by a tolerance\.

```csharp
public bool InRange(DiGi.ComputeSharp.Planar.Classes.Triangle2 triangle, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.InRange(DiGi.ComputeSharp.Planar.Classes.Triangle2,double).triangle'></a>

`triangle` [DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.planar.classes.triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')

The triangle to check against\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.InRange(DiGi.ComputeSharp.Planar.Classes.Triangle2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance used to expand the bounding box\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is within the expanded bounding box; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.IsNaN()'></a>

## Coordinate2\.IsNaN\(\) Method

Determines whether either the X or Y component of this coordinate is Not\-a\-Number \(NaN\)\.

```csharp
public bool IsNaN();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if X or Y is NaN; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Multiply(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.Multiply\(Coordinate2\) Method

Performs a component\-wise multiplication of this coordinate with another coordinate\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 Multiply(DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Multiply(DiGi.ComputeSharp.Planar.Classes.Coordinate2).coordinate'></a>

`coordinate` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The coordinate to multiply by\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A new [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') resulting from the component\-wise multiplication\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Multiply(double)'></a>

## Coordinate2\.Multiply\(double\) Method

Performs scalar multiplication of this coordinate by a specified factor\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 Multiply(double factor);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Multiply(double).factor'></a>

`factor` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The scalar value to multiply by\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A new [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') resulting from the scalar multiplication\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Project(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.Project\(Coordinate2\) Method

Projects the specified coordinate onto this vector\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 Project(DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Project(DiGi.ComputeSharp.Planar.Classes.Coordinate2).coordinate'></a>

`coordinate` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The coordinate to project\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A new [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the projection of the given coordinate onto this vector\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Substract(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.Substract\(Coordinate2\) Method

Subtracts another coordinate from this coordinate\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 Substract(DiGi.ComputeSharp.Planar.Classes.Coordinate2 coordinate);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.Substract(DiGi.ComputeSharp.Planar.Classes.Coordinate2).coordinate'></a>

`coordinate` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The coordinate to subtract\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A new [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the result of the subtraction\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.ToString()'></a>

## Coordinate2\.ToString\(\) Method

Returns a string representation of the current coordinate\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A formatted string containing the X and Y components\.
### Operators

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.op_Equality(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.operator ==\(Coordinate2, Coordinate2\) Operator

Determines whether two [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') objects are equal\.

```csharp
public static bool operator ==(DiGi.ComputeSharp.Planar.Classes.Coordinate2 left, DiGi.ComputeSharp.Planar.Classes.Coordinate2 right);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.op_Equality(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).left'></a>

`left` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first coordinate to compare\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.op_Equality(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).right'></a>

`right` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The second coordinate to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the coordinates are equal; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.op_Inequality(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Coordinate2\.operator \!=\(Coordinate2, Coordinate2\) Operator

Determines whether two [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') objects are not equal\.

```csharp
public static bool operator !=(DiGi.ComputeSharp.Planar.Classes.Coordinate2 left, DiGi.ComputeSharp.Planar.Classes.Coordinate2 right);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.op_Inequality(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).left'></a>

`left` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first coordinate to compare\.

<a name='DiGi.ComputeSharp.Planar.Classes.Coordinate2.op_Inequality(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).right'></a>

`right` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The second coordinate to compare\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the coordinates are not equal; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2'></a>

## Line2 Struct

Represents a 2D line segment or an infinite line in a planar coordinate system\.

```csharp
public readonly struct Line2 : DiGi.ComputeSharp.Planar.Interfaces.IGeometry2, DiGi.ComputeSharp.Core.Interfaces.IGeometry
```

Implements [IGeometry2](DiGi.ComputeSharp.Planar.Interfaces.md#DiGi.ComputeSharp.Planar.Interfaces.IGeometry2 'DiGi\.ComputeSharp\.Planar\.Interfaces\.IGeometry2'), [IGeometry](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IGeometry 'DiGi\.ComputeSharp\.Core\.Interfaces\.IGeometry')
### Constructors

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2()'></a>

## Line2\(\) Constructor

Initializes a new instance of the [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') struct with default NaN values and unbounded flag\.

```csharp
public Line2();
```

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Line2\(Bool, Coordinate2, Coordinate2\) Constructor

Initializes a new instance of the [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') struct with specified boundedness and coordinate objects\.

```csharp
public Line2(DiGi.ComputeSharp.Core.Classes.Bool bounded, DiGi.ComputeSharp.Planar.Classes.Coordinate2 start, DiGi.ComputeSharp.Planar.Classes.Coordinate2 end);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).bounded'></a>

`bounded` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

Whether the line is bounded\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).start'></a>

`start` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The starting coordinate\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).end'></a>

`end` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The ending coordinate\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double)'></a>

## Line2\(Bool, double, double, double, double\) Constructor

Initializes a new instance of the [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') struct with specified boundedness and coordinates\.

```csharp
public Line2(DiGi.ComputeSharp.Core.Classes.Bool bounded, double x_1, double y_1, double x_2, double y_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double).bounded'></a>

`bounded` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

Whether the line is bounded\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the first point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the first point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the second point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Core.Classes.Bool,double,double,double,double).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the second point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Line2\(Coordinate2, Coordinate2\) Constructor

Initializes a new instance of the [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') struct as a bounded line using start and end coordinates\.

```csharp
public Line2(DiGi.ComputeSharp.Planar.Classes.Coordinate2 start, DiGi.ComputeSharp.Planar.Classes.Coordinate2 end);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).start'></a>

`start` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The starting coordinate\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).end'></a>

`end` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The ending coordinate\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(double,double,double,double)'></a>

## Line2\(double, double, double, double\) Constructor

Initializes a new instance of the [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') struct as a bounded line using specific coordinates\.

```csharp
public Line2(double x_1, double y_1, double x_2, double y_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(double,double,double,double).x_1'></a>

`x_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the first point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(double,double,double,double).y_1'></a>

`y_1` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the first point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(double,double,double,double).x_2'></a>

`x_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The X coordinate of the second point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Line2(double,double,double,double).y_2'></a>

`y_2` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The Y coordinate of the second point\.
### Fields

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Bounded'></a>

## Line2\.Bounded Field

Indicates whether the line is bounded \(a segment\) or unbounded \(an infinite line\)\.

```csharp
public readonly Bool Bounded;
```

#### Field Value
[Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.End'></a>

## Line2\.End Field

The end coordinate of the line\.

```csharp
public readonly Coordinate2 End;
```

#### Field Value
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Start'></a>

## Line2\.Start Field

The start coordinate of the line\.

```csharp
public readonly Coordinate2 Start;
```

#### Field Value
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')
### Methods

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetApproximateDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Line2\.GetApproximateDistance\(Coordinate2\) Method

Calculates the approximate distance from a given point to the line\.

```csharp
public double GetApproximateDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetApproximateDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The point to measure distance from\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The approximate distance as a double\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetApproximateLength()'></a>

## Line2\.GetApproximateLength\(\) Method

Calculates the approximate length of the line\.

```csharp
public double GetApproximateLength();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The distance between start and end, or positive infinity if the line is unbounded\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetCentroid()'></a>

## Line2\.GetCentroid\(\) Method

Calculates the centroid of the line\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetCentroid();
```

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
The coordinate representing the center point of the line\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetClosestPoint(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Line2\.GetClosestPoint\(Coordinate2\) Method

Finds the closest point on the line to a specified target point\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetClosestPoint(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetClosestPoint(DiGi.ComputeSharp.Planar.Classes.Coordinate2).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The target point\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
The coordinate on the line closest to the provided point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetDirection(double)'></a>

## Line2\.GetDirection\(double\) Method

Gets the normalized direction vector of the line\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetDirection(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetDirection(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for normalization\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A normalized coordinate representing the direction\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetInversed()'></a>

## Line2\.GetInversed\(\) Method

Creates a new line that is the inverse of the current line \(swapping start and end points\)\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Line2 GetInversed();
```

#### Returns
[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')  
A new [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') instance with inverted coordinates\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetLength(double)'></a>

## Line2\.GetLength\(double\) Method

Calculates the actual length of the line using a specified tolerance for the square root operation\.

```csharp
public double GetLength(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetLength(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The precision tolerance\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The length of the line as a double\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetMax()'></a>

## Line2\.GetMax\(\) Method

Gets the maximum coordinate \(top\-right corner\) of the line's axis\-aligned bounding box\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetMax();
```

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
The maximum X and Y coordinates as a [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetMin()'></a>

## Line2\.GetMin\(\) Method

Gets the minimum coordinate \(bottom\-left corner\) of the line's axis\-aligned bounding box\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetMin();
```

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
The minimum X and Y coordinates as a [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetMoved(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Line2\.GetMoved\(Coordinate2\) Method

Moves the line by a specified translation vector\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Line2 GetMoved(DiGi.ComputeSharp.Planar.Classes.Coordinate2 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetMoved(DiGi.ComputeSharp.Planar.Classes.Coordinate2).vector'></a>

`vector` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The translation vector\.

#### Returns
[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')  
A new [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') instance shifted by the provided vector\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetSquaredDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Line2\.GetSquaredDistance\(Coordinate2\) Method

Calculates the squared distance from a given point to the closest point on the line\.

```csharp
public double GetSquaredDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetSquaredDistance(DiGi.ComputeSharp.Planar.Classes.Coordinate2).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The point to measure distance from\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The squared distance as a double\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetSquaredLength()'></a>

## Line2\.GetSquaredLength\(\) Method

Calculates the squared length of the line\.

```csharp
public double GetSquaredLength();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The squared distance between start and end, or positive infinity if the line is unbounded\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.GetVector()'></a>

## Line2\.GetVector\(\) Method

Gets the vector representing the direction and magnitude from the start to the end of the line\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetVector();
```

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the direction and magnitude of the line\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.InRange(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double)'></a>

## Line2\.InRange\(Coordinate2, double\) Method

Determines whether a given point is within the range of this line's bounding box\.

```csharp
public bool InRange(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.InRange(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The point to check\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.InRange(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The overlap tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is in range; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.InRange(DiGi.ComputeSharp.Planar.Classes.Line2,double)'></a>

## Line2\.InRange\(Line2, double\) Method

Determines whether this line's bounding box overlaps with another line's bounding box within a given tolerance\.

```csharp
public bool InRange(DiGi.ComputeSharp.Planar.Classes.Line2 line, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.InRange(DiGi.ComputeSharp.Planar.Classes.Line2,double).line'></a>

`line` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The other line to check\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.InRange(DiGi.ComputeSharp.Planar.Classes.Line2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The overlap tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the lines are in range; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.InRange(DiGi.ComputeSharp.Planar.Classes.Triangle2,double)'></a>

## Line2\.InRange\(Triangle2, double\) Method

Determines whether this line's bounding box overlaps with a triangle's bounding box within a given tolerance\.

```csharp
public bool InRange(DiGi.ComputeSharp.Planar.Classes.Triangle2 triangle, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.InRange(DiGi.ComputeSharp.Planar.Classes.Triangle2,double).triangle'></a>

`triangle` [DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.planar.classes.triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')

The triangle to check\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.InRange(DiGi.ComputeSharp.Planar.Classes.Triangle2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The overlap tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the line and triangle are in range; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.IsNaN()'></a>

## Line2\.IsNaN\(\) Method

Checks if either the start or end coordinates of the line are Not\-a\-Number \(NaN\)\.

```csharp
public bool IsNaN();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any coordinate is NaN; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.On(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double)'></a>

## Line2\.On\(Coordinate2, double\) Method

Determines whether a point lies on the line within a specified squared distance tolerance\.

```csharp
public bool On(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.On(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The point to check\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.On(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The squared distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is on the line; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Project(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Line2\.Project\(Coordinate2\) Method

Projects a given point onto the line, returning the closest point on the line\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 Project(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Project(DiGi.ComputeSharp.Planar.Classes.Coordinate2).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The point to project\.

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
The closest [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') on this line to the given point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Project(DiGi.ComputeSharp.Planar.Classes.Line2)'></a>

## Line2\.Project\(Line2\) Method

Projects another line onto this line by finding the closest points for the start and end of the given line\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Line2 Project(DiGi.ComputeSharp.Planar.Classes.Line2 line);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.Project(DiGi.ComputeSharp.Planar.Classes.Line2).line'></a>

`line` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The line to project onto this line\.

#### Returns
[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')  
A new [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') representing the projected line, or a default [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') if the projection collapses to a point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2.ToString()'></a>

## Line2\.ToString\(\) Method

Returns a string representation of the line showing start and end coordinates\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A formatted string containing the start and end coordinates\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection'></a>

## Line2Intersection Struct

Represents the result of an intersection operation in 2D space, which can be a single point, two points, or a line segment\.

```csharp
public readonly struct Line2Intersection : DiGi.ComputeSharp.Planar.Interfaces.IIntersection2, DiGi.ComputeSharp.Core.Interfaces.IIntersection, DiGi.ComputeSharp.Core.Interfaces.IResult
```

Implements [IIntersection2](DiGi.ComputeSharp.Planar.Interfaces.md#DiGi.ComputeSharp.Planar.Interfaces.IIntersection2 'DiGi\.ComputeSharp\.Planar\.Interfaces\.IIntersection2'), [IIntersection](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IIntersection 'DiGi\.ComputeSharp\.Core\.Interfaces\.IIntersection'), [IResult](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IResult 'DiGi\.ComputeSharp\.Core\.Interfaces\.IResult')
### Constructors

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection()'></a>

## Line2Intersection\(\) Constructor

Initializes a new instance of the [Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection') struct with default values\.

```csharp
public Line2Intersection();
```

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Line2Intersection\(Bool, Coordinate2\) Constructor

Initializes a new instance of the [Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection') struct with specified solidity and the first point\.

```csharp
public Line2Intersection(DiGi.ComputeSharp.Core.Classes.Bool solid, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_1);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2).solid'></a>

`solid` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

The solidity flag for the intersection\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_1'></a>

`point_1` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first coordinate point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Line2Intersection\(Bool, Coordinate2, Coordinate2\) Constructor

Initializes a new instance of the [Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection') struct with specified solidity and two coordinate points\.

```csharp
public Line2Intersection(DiGi.ComputeSharp.Core.Classes.Bool solid, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_1, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).solid'></a>

`solid` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

The solidity flag for the intersection\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_1'></a>

`point_1` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first coordinate point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_2'></a>

`point_2` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The second coordinate point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Line2Intersection\(Coordinate2\) Constructor

Initializes a new instance of the [Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection') struct with the first point\.

```csharp
public Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_1);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_1'></a>

`point_1` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first coordinate point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Line2Intersection\(Coordinate2, Coordinate2\) Constructor

Initializes a new instance of the [Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection') struct with two coordinate points\.

```csharp
public Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_1, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_1'></a>

`point_1` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first coordinate point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_2'></a>

`point_2` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The second coordinate point\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2)'></a>

## Line2Intersection\(Line2\) Constructor

Initializes a new instance of the [Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection') struct from an existing line\.

```csharp
public Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2 line);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Line2Intersection(DiGi.ComputeSharp.Planar.Classes.Line2).line'></a>

`line` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The line to use for initialization\.
### Fields

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Point_1'></a>

## Line2Intersection\.Point\_1 Field

The first coordinate point of the intersection\.

```csharp
public readonly Coordinate2 Point_1;
```

#### Field Value
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Point_2'></a>

## Line2Intersection\.Point\_2 Field

The second coordinate point of the intersection, used when the result is a line segment\.

```csharp
public readonly Coordinate2 Point_2;
```

#### Field Value
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.Solid'></a>

## Line2Intersection\.Solid Field

Indicates whether the intersection result is a solid line segment rather than discrete points\.

```csharp
public readonly Bool Solid;
```

#### Field Value
[Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')
### Methods

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.GetIntersectionGeometries(System.Nullable_bool_)'></a>

## Line2Intersection\.GetIntersectionGeometries\(Nullable\<bool\>\) Method

Retrieves the geometries resulting from the intersection, optionally overriding the solidity of the result\.

```csharp
public DiGi.ComputeSharp.Planar.Interfaces.IGeometry2[]? GetIntersectionGeometries(System.Nullable<bool> solid=null);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.GetIntersectionGeometries(System.Nullable_bool_).solid'></a>

`solid` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

An optional override for whether the result should be treated as a solid geometry\.

Implements [GetIntersectionGeometries\(Nullable&lt;bool&gt;\)](DiGi.ComputeSharp.Planar.Interfaces.md#DiGi.ComputeSharp.Planar.Interfaces.IIntersection2.GetIntersectionGeometries(System.Nullable_bool_) 'DiGi\.ComputeSharp\.Planar\.Interfaces\.IIntersection2\.GetIntersectionGeometries\(System\.Nullable\<bool\>\)')

#### Returns
[IGeometry2](DiGi.ComputeSharp.Planar.Interfaces.md#DiGi.ComputeSharp.Planar.Interfaces.IGeometry2 'DiGi\.ComputeSharp\.Planar\.Interfaces\.IGeometry2')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of [IGeometry2](DiGi.ComputeSharp.Planar.Interfaces.md#DiGi.ComputeSharp.Planar.Interfaces.IGeometry2 'DiGi\.ComputeSharp\.Planar\.Interfaces\.IGeometry2') objects representing the intersection, or null if the primary point is NaN\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.GetLine()'></a>

## Line2Intersection\.GetLine\(\) Method

Converts the intersection result into a line segment if it is marked as solid and contains valid points\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Line2 GetLine();
```

#### Returns
[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')  
A [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') representing the intersection line, or an empty line if not applicable\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2Intersection.IsNaN()'></a>

## Line2Intersection\.IsNaN\(\) Method

Determines whether the intersection result is Not\-a\-Number \(NaN\)\.

```csharp
public bool IsNaN();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the first point is NaN; otherwise, false\.