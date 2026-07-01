#### [DiGi\.ComputeSharp](index.md 'index')

## DiGi\.ComputeSharp\.Planar Namespace
### Classes

<a name='DiGi.ComputeSharp.Planar.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

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