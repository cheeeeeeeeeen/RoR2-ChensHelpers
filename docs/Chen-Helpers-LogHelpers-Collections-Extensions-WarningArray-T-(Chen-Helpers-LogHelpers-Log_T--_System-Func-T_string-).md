
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.LogHelpers.Collections](./Chen-Helpers-LogHelpers-Collections 'Chen.Helpers.LogHelpers.Collections').[Extensions](./Chen-Helpers-LogHelpers-Collections-Extensions 'Chen.Helpers.LogHelpers.Collections.Extensions')

## Extensions.WarningArray&lt;T&gt;(Chen.Helpers.LogHelpers.Log, T[], System.Func&lt;T,string&gt;) Method
Logs an array of values using the Warning format. Use code logic to control the format directly.  
```csharp
public static void WarningArray<T>(this Chen.Helpers.LogHelpers.Log logger, T[] data, System.Func<T,string> formatter);
```

#### Type parameters
<a name='Chen-Helpers-LogHelpers-Collections-Extensions-WarningArray-T-(Chen-Helpers-LogHelpers-Log_T--_System-Func-T_string-)-T'></a>
`T`  
Type of data in the array  
  

#### Parameters
<a name='Chen-Helpers-LogHelpers-Collections-Extensions-WarningArray-T-(Chen-Helpers-LogHelpers-Log_T--_System-Func-T_string-)-logger'></a>
`logger` [Log](./Chen-Helpers-LogHelpers-Log 'Chen.Helpers.LogHelpers.Log')  
Log instance  
  
<a name='Chen-Helpers-LogHelpers-Collections-Extensions-WarningArray-T-(Chen-Helpers-LogHelpers-Log_T--_System-Func-T_string-)-data'></a>
`data` [T](#Chen-Helpers-LogHelpers-Collections-Extensions-WarningArray-T-(Chen-Helpers-LogHelpers-Log_T--_System-Func-T_string-)-T 'Chen.Helpers.LogHelpers.Collections.Extensions.WarningArray&lt;T&gt;(Chen.Helpers.LogHelpers.Log, T[], System.Func&lt;T,string&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array  
  
<a name='Chen-Helpers-LogHelpers-Collections-Extensions-WarningArray-T-(Chen-Helpers-LogHelpers-Log_T--_System-Func-T_string-)-formatter'></a>
`formatter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](#Chen-Helpers-LogHelpers-Collections-Extensions-WarningArray-T-(Chen-Helpers-LogHelpers-Log_T--_System-Func-T_string-)-T 'Chen.Helpers.LogHelpers.Collections.Extensions.WarningArray&lt;T&gt;(Chen.Helpers.LogHelpers.Log, T[], System.Func&lt;T,string&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Logic formatter where T is the item for use  
  
