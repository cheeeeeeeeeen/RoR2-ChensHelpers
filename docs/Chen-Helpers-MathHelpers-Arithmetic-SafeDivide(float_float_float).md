
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.MathHelpers](./Chen-Helpers-MathHelpers 'Chen.Helpers.MathHelpers').[Arithmetic](./Chen-Helpers-MathHelpers-Arithmetic 'Chen.Helpers.MathHelpers.Arithmetic')

## Arithmetic.SafeDivide(float, float, float) Method
Performs division with a safety check when the divisor is 0.  
The parameter fallbackResult will be returned instead if the divisor is 0.  
```csharp
public static float SafeDivide(this float dividend, float divisor, float fallbackResult=float.PositiveInfinity);
```

#### Parameters
<a name='Chen-Helpers-MathHelpers-Arithmetic-SafeDivide(float_float_float)-dividend'></a>
`dividend` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The number being divided  
  
<a name='Chen-Helpers-MathHelpers-Arithmetic-SafeDivide(float_float_float)-divisor'></a>
`divisor` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The number that will divide the dividend  
  
<a name='Chen-Helpers-MathHelpers-Arithmetic-SafeDivide(float_float_float)-fallbackResult'></a>
`fallbackResult` [System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
Return value if the divisor is 0  
  

#### Returns
[System.Single](https://docs.microsoft.com/en-us/dotnet/api/System.Single 'System.Single')  
The quotient or the fallbackResult  
