
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.MathHelpers](./Chen-Helpers-MathHelpers 'Chen.Helpers.MathHelpers').[Arithmetic](./Chen-Helpers-MathHelpers-Arithmetic 'Chen.Helpers.MathHelpers.Arithmetic')

## Arithmetic.Sum(int[], System.Func&lt;int,int&gt;) Method
Adds all the values contained in the array. Preprocessing each item is possible before they are computed by providing the logic.  
e.g. Sum(new int[] { 2, -4, 1 }, item => Mathf.Max(0, item)) will yield a result of 3.  
```csharp
public static int Sum(this int[] numbers, System.Func<int,int> preProcess=null);
```

#### Parameters
<a name='Chen-Helpers-MathHelpers-Arithmetic-Sum(int--_System-Func-int_int-)-numbers'></a>
`numbers` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Array of numbers  
  
<a name='Chen-Helpers-MathHelpers-Arithmetic-Sum(int--_System-Func-int_int-)-preProcess'></a>
`preProcess` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Preprocessor code  
  

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Sum of the values in the array  
