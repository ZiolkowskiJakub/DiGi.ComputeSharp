#### [DiGi\.ComputeSharp](DiGi.ComputeSharp.Overview.md 'DiGi\.ComputeSharp\.Overview')

## DiGi\.ComputeSharp\.Core Namespace
### Classes

<a name='DiGi.ComputeSharp.Core.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.ComputeSharp.Core.Create.List_T_(thisComputeSharp.Resources.Buffer_T_,System.Func_System.Nullable_T_,bool_)'></a>

## Create\.List\<T\>\(this Buffer\<T\>, Func\<Nullable\<T\>,bool\>\) Method

Converts the contents of a [ComputeSharp\.Resources\.Buffer&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.resources.buffer-1 'ComputeSharp\.Resources\.Buffer\`1') into a managed [List&lt;T&gt;\(this Buffer&lt;T&gt;, Func&lt;Nullable&lt;T&gt;,bool&gt;\)](DiGi.ComputeSharp.Core.md#DiGi.ComputeSharp.Core.Create.List_T_(thisComputeSharp.Resources.Buffer_T_,System.Func_System.Nullable_T_,bool_) 'DiGi\.ComputeSharp\.Core\.Create\.List\<T\>\(this ComputeSharp\.Resources\.Buffer\<T\>, System\.Func\<System\.Nullable\<T\>,bool\>\)'),
optionally filtering elements based on the provided predicate\.

```csharp
public static System.Collections.Generic.List<T>? List<T>(this ComputeSharp.Resources.Buffer<T> buffer, System.Func<System.Nullable<T>,bool>? func=null)
    where T : unmanaged;
```
#### Type parameters

<a name='DiGi.ComputeSharp.Core.Create.List_T_(thisComputeSharp.Resources.Buffer_T_,System.Func_System.Nullable_T_,bool_).T'></a>

`T`

The unmanaged type of the elements contained in the buffer\.
#### Parameters

<a name='DiGi.ComputeSharp.Core.Create.List_T_(thisComputeSharp.Resources.Buffer_T_,System.Func_System.Nullable_T_,bool_).buffer'></a>

`buffer` [ComputeSharp\.Resources\.Buffer&lt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.resources.buffer-1 'ComputeSharp\.Resources\.Buffer\`1')[T](DiGi.ComputeSharp.Core.md#DiGi.ComputeSharp.Core.Create.List_T_(thisComputeSharp.Resources.Buffer_T_,System.Func_System.Nullable_T_,bool_).T 'DiGi\.ComputeSharp\.Core\.Create\.List\<T\>\(this ComputeSharp\.Resources\.Buffer\<T\>, System\.Func\<System\.Nullable\<T\>,bool\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/computesharp.resources.buffer-1 'ComputeSharp\.Resources\.Buffer\`1')

The source ComputeSharp buffer to convert\.

<a name='DiGi.ComputeSharp.Core.Create.List_T_(thisComputeSharp.Resources.Buffer_T_,System.Func_System.Nullable_T_,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[T](DiGi.ComputeSharp.Core.md#DiGi.ComputeSharp.Core.Create.List_T_(thisComputeSharp.Resources.Buffer_T_,System.Func_System.Nullable_T_,bool_).T 'DiGi\.ComputeSharp\.Core\.Create\.List\<T\>\(this ComputeSharp\.Resources\.Buffer\<T\>, System\.Func\<System\.Nullable\<T\>,bool\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate used to determine whether an element should be included in the resulting list\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.ComputeSharp.Core.md#DiGi.ComputeSharp.Core.Create.List_T_(thisComputeSharp.Resources.Buffer_T_,System.Func_System.Nullable_T_,bool_).T 'DiGi\.ComputeSharp\.Core\.Create\.List\<T\>\(this ComputeSharp\.Resources\.Buffer\<T\>, System\.Func\<System\.Nullable\<T\>,bool\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list containing the elements from the buffer that satisfy the predicate, or [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') if the source buffer is null\.

<a name='DiGi.ComputeSharp.Core.Query'></a>

## Query Class

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.ComputeSharp.Core.Query.Abs(double)'></a>

## Query\.Abs\(double\) Method

Returns the absolute value of a specified number\.

```csharp
public static double Abs(double value);
```
#### Parameters

<a name='DiGi.ComputeSharp.Core.Query.Abs(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The number to get the absolute value of\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The absolute value of the specified number\.

<a name='DiGi.ComputeSharp.Core.Query.Count(bool,bool,bool,bool,bool,bool,bool)'></a>

## Query\.Count\(bool, bool, bool, bool, bool, bool, bool\) Method

Counts how many of the provided boolean values match a specified target value\.

```csharp
public static int Count(bool value, bool value_1, bool value_2, bool value_3, bool value_4, bool value_5, bool value_6);
```
#### Parameters

<a name='DiGi.ComputeSharp.Core.Query.Count(bool,bool,bool,bool,bool,bool,bool).value'></a>

`value` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The target boolean value to compare against\.

<a name='DiGi.ComputeSharp.Core.Query.Count(bool,bool,bool,bool,bool,bool,bool).value_1'></a>

`value_1` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The first boolean value to evaluate\.

<a name='DiGi.ComputeSharp.Core.Query.Count(bool,bool,bool,bool,bool,bool,bool).value_2'></a>

`value_2` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The second boolean value to evaluate\.

<a name='DiGi.ComputeSharp.Core.Query.Count(bool,bool,bool,bool,bool,bool,bool).value_3'></a>

`value_3` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The third boolean value to evaluate\.

<a name='DiGi.ComputeSharp.Core.Query.Count(bool,bool,bool,bool,bool,bool,bool).value_4'></a>

`value_4` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The fourth boolean value to evaluate\.

<a name='DiGi.ComputeSharp.Core.Query.Count(bool,bool,bool,bool,bool,bool,bool).value_5'></a>

`value_5` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The fifth boolean value to evaluate\.

<a name='DiGi.ComputeSharp.Core.Query.Count(bool,bool,bool,bool,bool,bool,bool).value_6'></a>

`value_6` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The sixth boolean value to evaluate\.

#### Returns
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')  
The number of values among the six provided that are equal to the target value\.

<a name='DiGi.ComputeSharp.Core.Query.IsValid(double)'></a>

## Query\.IsValid\(double\) Method

Determines whether the specified double\-precision floating\-point value is valid and finite\.

```csharp
public static bool IsValid(double value);
```
#### Parameters

<a name='DiGi.ComputeSharp.Core.Query.IsValid(double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The double\-precision floating\-point number to validate\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the value is valid; otherwise, false\.

<a name='DiGi.ComputeSharp.Core.Query.Sqrt(double,double)'></a>

## Query\.Sqrt\(double, double\) Method

Calculates the square root of a specified value using an iterative approximation method until the result is within the given tolerance\.

```csharp
public static double Sqrt(double value, double tolerance);
```
#### Parameters

<a name='DiGi.ComputeSharp.Core.Query.Sqrt(double,double).value'></a>

`value` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The number to calculate the square root of\.

<a name='DiGi.ComputeSharp.Core.Query.Sqrt(double,double).tolerance'></a>

`tolerance` [System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')

The maximum allowable difference between the squared result and the original value for convergence\.

#### Returns
[System\.Double](https://learn.microsoft.com/en-us/dotnet/api/system.double 'System\.Double')  
The approximate square root of the value, or [System\.Double\.NaN](https://learn.microsoft.com/en-us/dotnet/api/system.double.nan 'System\.Double\.NaN') if the value is negative\.