
#### [ChensHelpers](index 'index')

### [Chen.Helpers.MathHelpers](Chen_Helpers_MathHelpers 'Chen.Helpers.MathHelpers').[Arithmetic](Chen_Helpers_MathHelpers_Arithmetic 'Chen.Helpers.MathHelpers.Arithmetic')

## Arithmetic.Average(float[], Func&lt;float,float&gt;) Method
Computes for the average of the numbers in the array. Preprocessing each item is possible before they are computed by providing the logic.  
e.g. Average(new float[] { 2f, -4f, 2f }, item => Mathf.Max(2f, item)) will yield a result of 2f.  
```csharp
public static float Average(this float[] numbers, System.Func<float,float> preProcess=null);
```

#### Parameters
<a name='Chen_Helpers_MathHelpers_Arithmetic_Average(float___System_Func_float_float_)_numbers'></a>
`numbers` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Array of numbers
  
<a name='Chen_Helpers_MathHelpers_Arithmetic_Average(float___System_Func_float_float_)_preProcess'></a>
`preProcess` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Preprocessor code
  

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
Average of the values in the array

#### Exceptions
[System.DivideByZeroException](https://docs.microsoft.com/en-us/dotnet/api/System.DivideByZeroException 'System.DivideByZeroException')  
Raised when the array length is 0 when division is performed.
