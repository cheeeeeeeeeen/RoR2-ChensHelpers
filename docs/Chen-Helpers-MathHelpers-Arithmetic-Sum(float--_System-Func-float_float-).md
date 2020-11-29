
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.MathHelpers](./Chen-Helpers-MathHelpers 'Chen.Helpers.MathHelpers').[Arithmetic](./Chen-Helpers-MathHelpers-Arithmetic 'Chen.Helpers.MathHelpers.Arithmetic')

## Arithmetic.Sum(float[], System.Func&lt;float,float&gt;) Method
Adds all the values contained in the array. Preprocessing each item is possible before they are computed by providing the logic.  
e.g. Sum(new float[] { 2f, -4f, 1f }, item => Mathf.Max(0f, item)) will yield a result of 3f.  
```csharp
public static float Sum(this float[] numbers, System.Func<float,float> preProcess=null);
```

#### Parameters
<a name='Chen-Helpers-MathHelpers-Arithmetic-Sum(float--_System-Func-float_float-)-numbers'></a>
`numbers` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Array of numbers  
  
<a name='Chen-Helpers-MathHelpers-Arithmetic-Sum(float--_System-Func-float_float-)-preProcess'></a>
`preProcess` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Preprocessor code  
  

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
Sum of the values in the array  
