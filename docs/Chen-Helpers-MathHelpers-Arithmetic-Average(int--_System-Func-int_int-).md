
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.MathHelpers](./Chen-Helpers-MathHelpers 'Chen.Helpers.MathHelpers').[Arithmetic](./Chen-Helpers-MathHelpers-Arithmetic 'Chen.Helpers.MathHelpers.Arithmetic')

## Arithmetic.Average(int[], System.Func&lt;int,int&gt;) Method
Computes for the average of the numbers in the array. Preprocessing each item is possible before they are computed by providing the logic.  
e.g. Average(new int[] { 2, -4, 2 }, item => Mathf.Max(2, item)) will yield a result of 2.  
```csharp
public static float Average(this int[] numbers, System.Func<int,int> preProcess=null);
```

#### Parameters
<a name='Chen-Helpers-MathHelpers-Arithmetic-Average(int--_System-Func-int_int-)-numbers'></a>
`numbers` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Array of numbers  
  
<a name='Chen-Helpers-MathHelpers-Arithmetic-Average(int--_System-Func-int_int-)-preProcess'></a>
`preProcess` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Preprocessor code  
  

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
Average of the values in the array  

#### Exceptions
[System.DivideByZeroException](https://docs.microsoft.com/en-us/dotnet/api/System.DivideByZeroException 'System.DivideByZeroException')  
Raised when the array length is 0 when division is performed.  
