
#### [ChensHelpers](index 'index')

### [Chen.Helpers.MathHelpers](Chen_Helpers_MathHelpers 'Chen.Helpers.MathHelpers').[Arithmetic](Chen_Helpers_MathHelpers_Arithmetic 'Chen.Helpers.MathHelpers.Arithmetic')

## Arithmetic.SafeDivide(float, float, float) Method
Performs division with a safety check when the divisor is 0.  
The parameter fallbackResult will be returned instead if the divisor is 0.  
```csharp
public static float SafeDivide(this float dividend, float divisor, float fallbackResult=float.PositiveInfinity);
```

#### Parameters
<a name='Chen_Helpers_MathHelpers_Arithmetic_SafeDivide(float_float_float)_dividend'></a>
`dividend` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The number being divided
  
<a name='Chen_Helpers_MathHelpers_Arithmetic_SafeDivide(float_float_float)_divisor'></a>
`divisor` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The number that will divide the dividend
  
<a name='Chen_Helpers_MathHelpers_Arithmetic_SafeDivide(float_float_float)_fallbackResult'></a>
`fallbackResult` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
Return value if the divisor is 0
  

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The quotient or the fallbackResult
