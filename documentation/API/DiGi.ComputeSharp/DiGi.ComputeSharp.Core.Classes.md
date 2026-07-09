#### [DiGi\.ComputeSharp](DiGi.ComputeSharp.Overview.md 'DiGi\.ComputeSharp\.Overview')

## DiGi\.ComputeSharp\.Core\.Classes Namespace
### Structs

<a name='DiGi.ComputeSharp.Core.Classes.Bool'></a>

## Bool Struct

Represents a boolean value stored as an integer, typically used for compatibility with compute shaders or GPU buffers\.

```csharp
public readonly struct Bool
```
### Constructors

<a name='DiGi.ComputeSharp.Core.Classes.Bool.Bool(bool)'></a>

## Bool\(bool\) Constructor

Initializes a new instance of the [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool') struct using a standard boolean value\.

```csharp
public Bool(bool value);
```
#### Parameters

<a name='DiGi.ComputeSharp.Core.Classes.Bool.Bool(bool).value'></a>

`value` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

The boolean value to convert\.

<a name='DiGi.ComputeSharp.Core.Classes.Bool.Bool(int)'></a>

## Bool\(int\) Constructor

Initializes a new instance of the [Bool](DiGi.ComputeSharp.Core.Classes.md#DiGi.ComputeSharp.Core.Classes.Bool 'DiGi\.ComputeSharp\.Core\.Classes\.Bool') struct using an integer value\.

```csharp
public Bool(int value);
```
#### Parameters

<a name='DiGi.ComputeSharp.Core.Classes.Bool.Bool(int).value'></a>

`value` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The integer value to convert \(1 is treated as true, all other values are false\)\.
### Fields

<a name='DiGi.ComputeSharp.Core.Classes.Bool.Value'></a>

## Bool\.Value Field

The underlying integer representation of the boolean value, where 0 is false and 1 is true\.

```csharp
public readonly int Value;
```

#### Field Value
[System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')
### Methods

<a name='DiGi.ComputeSharp.Core.Classes.Bool.ToBool()'></a>

## Bool\.ToBool\(\) Method

Converts the internal integer representation back to a standard C\# boolean\.

```csharp
public bool ToBool();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the internal value is 1; otherwise, false\.

<a name='DiGi.ComputeSharp.Core.Classes.Bool.ToString()'></a>

## Bool\.ToString\(\) Method

Returns a string representation of the boolean value\.

```csharp
public override string ToString();
```

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The string "True" or "False"\.