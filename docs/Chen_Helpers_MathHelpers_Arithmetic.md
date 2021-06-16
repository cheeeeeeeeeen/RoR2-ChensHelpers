#### [ChensHelpers](index 'index')
### [Chen.Helpers.MathHelpers](Chen_Helpers_MathHelpers 'Chen.Helpers.MathHelpers')
## Arithmetic Class
Extensions related to computations involving numbers.  
```csharp
public static class Arithmetic
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Arithmetic  

| Methods | |
| :--- | :--- |
| [Average(float[], Func&lt;float,float&gt;)](Chen_Helpers_MathHelpers_Arithmetic_Average(float___System_Func_float_float_) 'Chen.Helpers.MathHelpers.Arithmetic.Average(float[], System.Func&lt;float,float&gt;)') | Computes for the average of the numbers in the array. Preprocessing each item is possible before they are computed by providing the logic.<br/>e.g. Average(new float[] { 2f, -4f, 2f }, item => Mathf.Max(2f, item)) will yield a result of 2f.<br/> |
| [Average(int[], Func&lt;int,int&gt;)](Chen_Helpers_MathHelpers_Arithmetic_Average(int___System_Func_int_int_) 'Chen.Helpers.MathHelpers.Arithmetic.Average(int[], System.Func&lt;int,int&gt;)') | Computes for the average of the numbers in the array. Preprocessing each item is possible before they are computed by providing the logic.<br/>e.g. Average(new int[] { 2, -4, 2 }, item => Mathf.Max(2, item)) will yield a result of 2.<br/> |
| [SafeDivide(float, float, float)](Chen_Helpers_MathHelpers_Arithmetic_SafeDivide(float_float_float) 'Chen.Helpers.MathHelpers.Arithmetic.SafeDivide(float, float, float)') | Performs division with a safety check when the divisor is 0.<br/>The parameter fallbackResult will be returned instead if the divisor is 0.<br/> |
| [SafeDivide(int, int, int)](Chen_Helpers_MathHelpers_Arithmetic_SafeDivide(int_int_int) 'Chen.Helpers.MathHelpers.Arithmetic.SafeDivide(int, int, int)') | Performs division with a safety check when the divisor is 0.<br/>The parameter fallbackResult will be returned instead if the divisor is 0.<br/> |
| [Sum(float[], Func&lt;float,float&gt;)](Chen_Helpers_MathHelpers_Arithmetic_Sum(float___System_Func_float_float_) 'Chen.Helpers.MathHelpers.Arithmetic.Sum(float[], System.Func&lt;float,float&gt;)') | Adds all the values contained in the array. Preprocessing each item is possible before they are computed by providing the logic.<br/>e.g. Sum(new float[] { 2f, -4f, 1f }, item => Mathf.Max(0f, item)) will yield a result of 3f.<br/> |
| [Sum(int[], Func&lt;int,int&gt;)](Chen_Helpers_MathHelpers_Arithmetic_Sum(int___System_Func_int_int_) 'Chen.Helpers.MathHelpers.Arithmetic.Sum(int[], System.Func&lt;int,int&gt;)') | Adds all the values contained in the array. Preprocessing each item is possible before they are computed by providing the logic.<br/>e.g. Sum(new int[] { 2, -4, 1 }, item => Mathf.Max(0, item)) will yield a result of 3.<br/> |
