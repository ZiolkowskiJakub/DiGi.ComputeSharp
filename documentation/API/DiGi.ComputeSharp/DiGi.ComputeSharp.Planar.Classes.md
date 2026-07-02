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

`triangle` [Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')

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

`triangle` [Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')

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

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader'></a>

## Line2IntersectComputeShader Struct

```csharp
public readonly struct Line2IntersectComputeShader : ComputeSharp.IComputeShader, ComputeSharp.Descriptors.IComputeShaderDescriptor<DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader>
```

Implements [ComputeSharp\.IComputeShader](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader 'ComputeSharp\.IComputeShader'), [ComputeSharp\.Descriptors\.IComputeShaderDescriptor&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')[Line2IntersectComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectComputeShader')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')
### Constructors

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool)'></a>

## Line2IntersectComputeShader\(GraphicsDevice, IEnumerable\<Line2\>, IEnumerable\<Triangle2\>, bool, bool\) Constructor

Initializes a new instance of the [Line2IntersectComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectComputeShader') struct\.

```csharp
public Line2IntersectComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Line2> lines, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Triangle2> triangles, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 2D lines to check for intersections\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 2D triangles to test against\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the start point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the end point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool,double)'></a>

## Line2IntersectComputeShader\(GraphicsDevice, IEnumerable\<Line2\>, IEnumerable\<Triangle2\>, bool, bool, double\) Constructor

Initializes a new instance of the [Line2IntersectComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectComputeShader') struct with a custom tolerance\.

```csharp
public Line2IntersectComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Line2> lines, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Triangle2> triangles, bool includeStart, bool includeEnd, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool,double).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool,double).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 2D lines to check for intersections\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool,double).triangles'></a>

`triangles` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 2D triangles to test against\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool,double).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the start point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool,double).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the end point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.GraphicsDevice,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Triangle2_,bool,bool,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,bool,bool)'></a>

## Line2IntersectComputeShader\(ReadOnlyBuffer\<Line2\>, ReadOnlyBuffer\<Triangle2\>, ReadWriteBuffer\<int\>, bool, bool\) Constructor

Initializes a new instance of the [Line2IntersectComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectComputeShader') struct using pre\-allocated buffers\.

```csharp
public Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Planar.Classes.Line2> lines, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Planar.Classes.Triangle2> triangles, ComputeSharp.ReadWriteBuffer<int> result, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,bool,bool).lines'></a>

`lines` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 2D lines\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,bool,bool).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 2D triangles\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,bool,bool).result'></a>

`result` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing the intersection results\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the start point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the end point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool)'></a>

## Line2IntersectComputeShader\(ReadOnlyBuffer\<Line2\>, ReadOnlyBuffer\<Triangle2\>, ReadWriteBuffer\<int\>, double, bool, bool\) Constructor

Initializes a new instance of the [Line2IntersectComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectComputeShader') struct using pre\-allocated buffers and a custom tolerance\.

```csharp
public Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Planar.Classes.Line2> lines, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Planar.Classes.Triangle2> triangles, ComputeSharp.ReadWriteBuffer<int> result, double tolerance, bool includeStart, bool includeEnd);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool).lines'></a>

`lines` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 2D lines\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 2D triangles\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool).result'></a>

`result` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing the intersection results\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool).includeStart'></a>

`includeStart` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the start point of each line in the intersection tests\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Line2IntersectComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_int_,double,bool,bool).includeEnd'></a>

`includeEnd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether to include the end point of each line in the intersection tests\.
### Fields

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectComputeShader.Result'></a>

## Line2IntersectComputeShader\.Result Field

Gets the writeable buffer containing the index of the first intersecting triangle for each line, or \-1 if no intersection is found\.

```csharp
public readonly ReadWriteBuffer<int> Result;
```

#### Field Value
[ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

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

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader'></a>

## Line2IntersectionComputeShader Struct

```csharp
public readonly struct Line2IntersectionComputeShader : ComputeSharp.IComputeShader, ComputeSharp.Descriptors.IComputeShaderDescriptor<DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader>
```

Implements [ComputeSharp\.IComputeShader](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader 'ComputeSharp\.IComputeShader'), [ComputeSharp\.Descriptors\.IComputeShaderDescriptor&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')[Line2IntersectionComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectionComputeShader')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')
### Constructors

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_)'></a>

## Line2IntersectionComputeShader\(GraphicsDevice, Line2, IEnumerable\<Line2\>\) Constructor

Initializes a new instance of the [Line2IntersectionComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectionComputeShader') struct\.

```csharp
public Line2IntersectionComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, DiGi.ComputeSharp.Planar.Classes.Line2 line, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Line2> lines);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_).line'></a>

`line` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The primary 2D line to intersect with other lines\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 2D lines to check against the primary line\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,double)'></a>

## Line2IntersectionComputeShader\(GraphicsDevice, Line2, IEnumerable\<Line2\>, double\) Constructor

Initializes a new instance of the [Line2IntersectionComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectionComputeShader') struct with a custom tolerance\.

```csharp
public Line2IntersectionComputeShader(ComputeSharp.GraphicsDevice graphicsDevice, DiGi.ComputeSharp.Planar.Classes.Line2 line, System.Collections.Generic.IEnumerable<DiGi.ComputeSharp.Planar.Classes.Line2> lines, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,double).graphicsDevice'></a>

`graphicsDevice` [ComputeSharp\.GraphicsDevice](https://learn.microsoft.com/en-us/dotnet/api/computesharp.graphicsdevice 'ComputeSharp\.GraphicsDevice')

The graphics device to use for allocating resources\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,double).line'></a>

`line` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The primary 2D line to intersect with other lines\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,double).lines'></a>

`lines` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of 2D lines to check against the primary line\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(ComputeSharp.GraphicsDevice,DiGi.ComputeSharp.Planar.Classes.Line2,System.Collections.Generic.IEnumerable_DiGi.ComputeSharp.Planar.Classes.Line2_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_)'></a>

## Line2IntersectionComputeShader\(Line2, ReadOnlyBuffer\<Line2\>, ReadWriteBuffer\<Line2Intersection\>\) Constructor

Initializes a new instance of the [Line2IntersectionComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectionComputeShader') struct using pre\-allocated buffers\.

```csharp
public Line2IntersectionComputeShader(DiGi.ComputeSharp.Planar.Classes.Line2 line, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Planar.Classes.Line2> lines, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Planar.Classes.Line2Intersection> lineIntersections);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_).line'></a>

`line` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The primary 2D line to intersect with other lines\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_).lines'></a>

`lines` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 2D lines to check against\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_).lineIntersections'></a>

`lineIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing the intersection results\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_,double)'></a>

## Line2IntersectionComputeShader\(Line2, ReadOnlyBuffer\<Line2\>, ReadWriteBuffer\<Line2Intersection\>, double\) Constructor

Initializes a new instance of the [Line2IntersectionComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectionComputeShader') struct using pre\-allocated buffers and a custom tolerance\.

```csharp
public Line2IntersectionComputeShader(DiGi.ComputeSharp.Planar.Classes.Line2 line, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Planar.Classes.Line2> lines, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Planar.Classes.Line2Intersection> lineIntersections, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_,double).line'></a>

`line` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The primary 2D line to intersect with other lines\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_,double).lines'></a>

`lines` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 2D lines to check against\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_,double).lineIntersections'></a>

`lineIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing the intersection results\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Line2IntersectionComputeShader(DiGi.ComputeSharp.Planar.Classes.Line2,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.
### Fields

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.LineIntersections'></a>

## Line2IntersectionComputeShader\.LineIntersections Field

Gets the writeable buffer containing the line intersection results\.

```csharp
public readonly ReadWriteBuffer<Line2Intersection> LineIntersections;
```

#### Field Value
[ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')
### Methods

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionComputeShader.Execute()'></a>

## Line2IntersectionComputeShader\.Execute\(\) Method

Executes the compute shader operation over the designated range of threads\.

```csharp
public void Execute();
```

Implements [Execute\(\)](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader.execute 'ComputeSharp\.IComputeShader\.Execute')

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader'></a>

## Line2IntersectionsComputeShader Struct

```csharp
public readonly struct Line2IntersectionsComputeShader : ComputeSharp.IComputeShader, ComputeSharp.Descriptors.IComputeShaderDescriptor<DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader>
```

Implements [ComputeSharp\.IComputeShader](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader 'ComputeSharp\.IComputeShader'), [ComputeSharp\.Descriptors\.IComputeShaderDescriptor&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')[Line2IntersectionsComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectionsComputeShader')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.descriptors.icomputeshaderdescriptor-1 'ComputeSharp\.Descriptors\.IComputeShaderDescriptor\`1')
### Constructors

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader.Line2IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_)'></a>

## Line2IntersectionsComputeShader\(ReadOnlyBuffer\<Line2\>, ReadOnlyBuffer\<Triangle2\>, ReadWriteBuffer\<Line2Intersection\>\) Constructor

Initializes a new instance of the [Line2IntersectionsComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectionsComputeShader') struct\.

```csharp
public Line2IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Planar.Classes.Line2> lines, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Planar.Classes.Triangle2> triangles, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Planar.Classes.Line2Intersection> lineIntersections);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader.Line2IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_).lines'></a>

`lines` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 2D lines\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader.Line2IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 2D triangles\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader.Line2IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_).lineIntersections'></a>

`lineIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing the intersection results\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader.Line2IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_,double)'></a>

## Line2IntersectionsComputeShader\(ReadOnlyBuffer\<Line2\>, ReadOnlyBuffer\<Triangle2\>, ReadWriteBuffer\<Line2Intersection\>, double\) Constructor

Initializes a new instance of the [Line2IntersectionsComputeShader](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2IntersectionsComputeShader') struct with a custom tolerance\.

```csharp
public Line2IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Planar.Classes.Line2> lines, ComputeSharp.ReadOnlyBuffer<DiGi.ComputeSharp.Planar.Classes.Triangle2> triangles, ComputeSharp.ReadWriteBuffer<DiGi.ComputeSharp.Planar.Classes.Line2Intersection> lineIntersections, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader.Line2IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_,double).lines'></a>

`lines` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 2D lines\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader.Line2IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_,double).triangles'></a>

`triangles` [ComputeSharp\.ReadOnlyBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readonlybuffer-1 'ComputeSharp\.ReadOnlyBuffer\`1')

The read\-only buffer of 2D triangles\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader.Line2IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_,double).lineIntersections'></a>

`lineIntersections` [ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')

The read\-write buffer for storing the intersection results\.

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader.Line2IntersectionsComputeShader(ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Line2_,ComputeSharp.ReadOnlyBuffer_DiGi.ComputeSharp.Planar.Classes.Triangle2_,ComputeSharp.ReadWriteBuffer_DiGi.ComputeSharp.Planar.Classes.Line2Intersection_,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value used for geometric comparison\.
### Fields

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader.LineIntersections'></a>

## Line2IntersectionsComputeShader\.LineIntersections Field

Gets the writeable buffer containing the line\-to\-triangle intersection results\.

```csharp
public readonly ReadWriteBuffer<Line2Intersection> LineIntersections;
```

#### Field Value
[ComputeSharp\.ReadWriteBuffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')[Line2Intersection](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2Intersection 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2Intersection')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.readwritebuffer-1 'ComputeSharp\.ReadWriteBuffer\`1')
### Methods

<a name='DiGi.ComputeSharp.Planar.Classes.Line2IntersectionsComputeShader.Execute()'></a>

## Line2IntersectionsComputeShader\.Execute\(\) Method

Executes the compute shader operation over the designated range of threads\.

```csharp
public void Execute();
```

Implements [Execute\(\)](https://learn.microsoft.com/en-us/dotnet/api/computesharp.icomputeshader.execute 'ComputeSharp\.IComputeShader\.Execute')

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2'></a>

## Triangle2 Struct

Represents a two\-dimensional triangle in a planar coordinate system\.

```csharp
public readonly struct Triangle2 : DiGi.ComputeSharp.Planar.Interfaces.IGeometry2, DiGi.ComputeSharp.Core.Interfaces.IGeometry
```

Implements [IGeometry2](DiGi.ComputeSharp.Planar.Interfaces.md#DiGi.ComputeSharp.Planar.Interfaces.IGeometry2 'DiGi\.ComputeSharp\.Planar\.Interfaces\.IGeometry2'), [IGeometry](DiGi.ComputeSharp.Core.Interfaces.md#DiGi.ComputeSharp.Core.Interfaces.IGeometry 'DiGi\.ComputeSharp\.Core\.Interfaces\.IGeometry')
### Constructors

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Triangle2()'></a>

## Triangle2\(\) Constructor

Initializes a new instance of the [Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2') struct with default values \(NaN coordinates and not solid\)\.

```csharp
public Triangle2();
```

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Triangle2(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Triangle2\(Bool, Coordinate2, Coordinate2, Coordinate2\) Constructor

Initializes a new instance of the [Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2') struct with the specified solid state and vertices\.

```csharp
public Triangle2(DiGi.ComputeSharp.Core.Classes.Bool solid, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_1, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_2, DiGi.ComputeSharp.Planar.Classes.Coordinate2 point_3);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Triangle2(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).solid'></a>

`solid` [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')

A value indicating whether the triangle is solid\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Triangle2(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_1'></a>

`point_1` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The first vertex\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Triangle2(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_2'></a>

`point_2` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The second vertex\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Triangle2(DiGi.ComputeSharp.Core.Classes.Bool,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2,DiGi.ComputeSharp.Planar.Classes.Coordinate2).point_3'></a>

`point_3` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The third vertex\.
### Fields

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Point_1'></a>

## Triangle2\.Point\_1 Field

The first vertex of the triangle\.

```csharp
public readonly Coordinate2 Point_1;
```

#### Field Value
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Point_2'></a>

## Triangle2\.Point\_2 Field

The second vertex of the triangle\.

```csharp
public readonly Coordinate2 Point_2;
```

#### Field Value
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Point_3'></a>

## Triangle2\.Point\_3 Field

The third vertex of the triangle\.

```csharp
public readonly Coordinate2 Point_3;
```

#### Field Value
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Solid'></a>

## Triangle2\.Solid Field

A value indicating whether the triangle is solid \(filled\) or boundary\-only\.

```csharp
public readonly Bool Solid;
```

#### Field Value
[Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool')
### Methods

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetApproximatePerimeter()'></a>

## Triangle2\.GetApproximatePerimeter\(\) Method

Calculates the approximate perimeter of the triangle using fast distance calculations\.

```csharp
public double GetApproximatePerimeter();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The approximate perimeter of the triangle\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetArea()'></a>

## Triangle2\.GetArea\(\) Method

Calculates the signed area of the triangle\.

```csharp
public double GetArea();
```

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The area of the triangle\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetCentroid()'></a>

## Triangle2\.GetCentroid\(\) Method

Gets the centroid \(geometric center\) of the triangle\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetCentroid();
```

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the centroid of the triangle\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetInversed()'></a>

## Triangle2\.GetInversed\(\) Method

Gets a new triangle with inverted vertex order \(reversing winding direction\)\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Triangle2 GetInversed();
```

#### Returns
[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')  
An inverted [Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetLine(int)'></a>

## Triangle2\.GetLine\(int\) Method

Gets one of the boundary lines of the triangle by index\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Line2 GetLine(int index);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetLine(int).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The line index \(0, 1, or 2\)\.

#### Returns
[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')  
The boundary [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') at the specified index\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetLines()'></a>

## Triangle2\.GetLines\(\) Method

Gets all boundary lines of the triangle\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Line2[] GetLines();
```

#### Returns
[Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of three [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2') objects representing the boundary lines\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetMax()'></a>

## Triangle2\.GetMax\(\) Method

Gets the maximum coordinate bounds of the triangle\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetMax();
```

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the maximum X and Y coordinates\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetMin()'></a>

## Triangle2\.GetMin\(\) Method

Gets the minimum coordinate bounds of the triangle\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Coordinate2 GetMin();
```

#### Returns
[Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')  
A [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2') representing the minimum X and Y coordinates\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetMoved(DiGi.ComputeSharp.Planar.Classes.Coordinate2)'></a>

## Triangle2\.GetMoved\(Coordinate2\) Method

Translates the triangle by the specified offset vector\.

```csharp
public DiGi.ComputeSharp.Planar.Classes.Triangle2 GetMoved(DiGi.ComputeSharp.Planar.Classes.Coordinate2 vector);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetMoved(DiGi.ComputeSharp.Planar.Classes.Coordinate2).vector'></a>

`vector` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The translation vector\.

#### Returns
[Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')  
A translated [Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetPerimeter(double)'></a>

## Triangle2\.GetPerimeter\(double\) Method

Calculates the perimeter of the triangle with the specified tolerance\.

```csharp
public double GetPerimeter(double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.GetPerimeter(double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance used for distance calculations\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The perimeter of the triangle\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.InRange(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double)'></a>

## Triangle2\.InRange\(Coordinate2, double\) Method

Checks if a point is within the bounding range of the triangle\.

```csharp
public bool InRange(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.InRange(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The point to check\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.InRange(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point is within range; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.InRange(DiGi.ComputeSharp.Planar.Classes.Line2,double)'></a>

## Triangle2\.InRange\(Line2, double\) Method

Checks if a line is within the bounding range of the triangle\.

```csharp
public bool InRange(DiGi.ComputeSharp.Planar.Classes.Line2 line, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.InRange(DiGi.ComputeSharp.Planar.Classes.Line2,double).line'></a>

`line` [Line2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Line2 'DiGi\.ComputeSharp\.Planar\.Classes\.Line2')

The line to check\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.InRange(DiGi.ComputeSharp.Planar.Classes.Line2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the line is within range; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.InRange(DiGi.ComputeSharp.Planar.Classes.Triangle2,double)'></a>

## Triangle2\.InRange\(Triangle2, double\) Method

Checks if another triangle is within the bounding range of this triangle\.

```csharp
public bool InRange(DiGi.ComputeSharp.Planar.Classes.Triangle2 triangle, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.InRange(DiGi.ComputeSharp.Planar.Classes.Triangle2,double).triangle'></a>

`triangle` [Triangle2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Triangle2 'DiGi\.ComputeSharp\.Planar\.Classes\.Triangle2')

The other triangle to check\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.InRange(DiGi.ComputeSharp.Planar.Classes.Triangle2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The distance tolerance\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the triangles' bounding boxes overlap; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Inside(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double)'></a>

## Triangle2\.Inside\(Coordinate2, double\) Method

Determines whether a point lies inside the triangle using barycentric coordinates\.

```csharp
public bool Inside(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Inside(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The point to test\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.Inside(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The numerical tolerance value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point lies inside or on the boundary of the triangle; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.IsNaN()'></a>

## Triangle2\.IsNaN\(\) Method

Checks if any of the triangle's vertices contain NaN coordinates\.

```csharp
public bool IsNaN();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if any vertex is NaN; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.On(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double)'></a>

## Triangle2\.On\(Coordinate2, double\) Method

Determines whether a point lies on the triangle \(inside if solid, or on boundary lines if not\)\.

```csharp
public bool On(DiGi.ComputeSharp.Planar.Classes.Coordinate2 point, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.On(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).point'></a>

`point` [Coordinate2](DiGi.ComputeSharp.Planar.Classes.md#DiGi.ComputeSharp.Planar.Classes.Coordinate2 'DiGi\.ComputeSharp\.Planar\.Classes\.Coordinate2')

The point to test\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.On(DiGi.ComputeSharp.Planar.Classes.Coordinate2,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The tolerance value\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the point lies on the triangle; otherwise, false\.

<a name='DiGi.ComputeSharp.Planar.Classes.Triangle2.ToString()'></a>

## Triangle2\.ToString\(\) Method

Returns a string representation of the current triangle\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A formatted string describing the triangle vertices\.