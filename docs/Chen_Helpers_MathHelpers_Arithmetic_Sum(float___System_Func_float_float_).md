#### [ChensHelpers](index 'index')
### [Chen.Helpers.MathHelpers](Chen_Helpers_MathHelpers 'Chen.Helpers.MathHelpers').[Arithmetic](Chen_Helpers_MathHelpers_Arithmetic 'Chen.Helpers.MathHelpers.Arithmetic')
## Arithmetic.Sum(float[], Func&lt;float,float&gt;) Method
Adds all the values contained in the array. Preprocessing each item is possible before they are computed by providing the logic.  
e.g. Sum(new float[] { 2f, -4f, 1f }, item => Mathf.Max(0f, item)) will yield a result of 3f.  
```csharp
public static float Sum(this float[] numbers, System.Func<float,float> preProcess=null);
```
#### Parameters
<a name='Chen_Helpers_MathHelpers_Arithmetic_Sum(float___System_Func_float_float_)_numbers'></a>
`numbers` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Array of numbers
  
<a name='Chen_Helpers_MathHelpers_Arithmetic_Sum(float___System_Func_float_float_)_preProcess'></a>
`preProcess` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Preprocessor code
  
#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
Sum of the values in the array
