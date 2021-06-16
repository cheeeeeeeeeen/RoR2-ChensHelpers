#### [ChensHelpers](index 'index')
### [Chen.Helpers.MathHelpers](Chen_Helpers_MathHelpers 'Chen.Helpers.MathHelpers').[Arithmetic](Chen_Helpers_MathHelpers_Arithmetic 'Chen.Helpers.MathHelpers.Arithmetic')
## Arithmetic.SafeDivide(int, int, int) Method
Performs division with a safety check when the divisor is 0.  
The parameter fallbackResult will be returned instead if the divisor is 0.  
```csharp
public static int SafeDivide(this int dividend, int divisor, int fallbackResult=0);
```
#### Parameters
<a name='Chen_Helpers_MathHelpers_Arithmetic_SafeDivide(int_int_int)_dividend'></a>
`dividend` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number being divided
  
<a name='Chen_Helpers_MathHelpers_Arithmetic_SafeDivide(int_int_int)_divisor'></a>
`divisor` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The number that will divide the dividend
  
<a name='Chen_Helpers_MathHelpers_Arithmetic_SafeDivide(int_int_int)_fallbackResult'></a>
`fallbackResult` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Return value if the divisor is 0
  
#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The quotient or the fallbackResult
