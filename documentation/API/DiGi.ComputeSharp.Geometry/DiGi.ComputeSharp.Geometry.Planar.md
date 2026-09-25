#### [DiGi\.ComputeSharp\.Geometry](DiGi.ComputeSharp.Geometry.Overview.md 'DiGi\.ComputeSharp\.Geometry\.Overview')

## DiGi\.ComputeSharp\.Geometry\.Planar Namespace
### Classes

<a name='DiGi.ComputeSharp.Geometry.Planar.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.ComputeSharp.Geometry.Planar.Convert.ToDiGi(thisDiGi.ComputeSharp.Spatial.Classes.ShadowPolygon2)'></a>

## Convert\.ToDiGi\(this ShadowPolygon2\) Method

Converts a ComputeSharp [DiGi\.ComputeSharp\.Spatial\.Classes\.ShadowPolygon2](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.shadowpolygon2 'DiGi\.ComputeSharp\.Spatial\.Classes\.ShadowPolygon2') to a [DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D') built from its first [DiGi\.ComputeSharp\.Spatial\.Classes\.ShadowPolygon2\.Count](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.shadowpolygon2.count 'DiGi\.ComputeSharp\.Spatial\.Classes\.ShadowPolygon2\.Count') points\.

```csharp
public static DiGi.Geometry.Planar.Classes.PolygonalFace2D? ToDiGi(this DiGi.ComputeSharp.Spatial.Classes.ShadowPolygon2 shadowPolygon2);
```
#### Parameters

<a name='DiGi.ComputeSharp.Geometry.Planar.Convert.ToDiGi(thisDiGi.ComputeSharp.Spatial.Classes.ShadowPolygon2).shadowPolygon2'></a>

`shadowPolygon2` [DiGi\.ComputeSharp\.Spatial\.Classes\.ShadowPolygon2](https://learn.microsoft.com/en-us/dotnet/api/digi.computesharp.spatial.classes.shadowpolygon2 'DiGi\.ComputeSharp\.Spatial\.Classes\.ShadowPolygon2')

The source shadow polygon\.

#### Returns
[DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.planar.classes.polygonalface2d 'DiGi\.Geometry\.Planar\.Classes\.PolygonalFace2D')  
The face, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') when the point count is not 3 or 4, a used point is NaN, or the face cannot be created\.