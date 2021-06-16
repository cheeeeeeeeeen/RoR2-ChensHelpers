#### [ChensHelpers](index 'index')
### [Chen.Helpers.LogHelpers.Collections](Chen_Helpers_LogHelpers_Collections 'Chen.Helpers.LogHelpers.Collections').[Extensions](Chen_Helpers_LogHelpers_Collections_Extensions 'Chen.Helpers.LogHelpers.Collections.Extensions')
## Extensions.ErrorArray&lt;T&gt;(Log, T[], Func&lt;T,string&gt;) Method
Logs an array of values using the Error format. Use code logic to control the format directly.  
```csharp
public static void ErrorArray<T>(this Chen.Helpers.LogHelpers.Log logger, T[] data, System.Func<T,string> formatter);
```
#### Type parameters
<a name='Chen_Helpers_LogHelpers_Collections_Extensions_ErrorArray_T_(Chen_Helpers_LogHelpers_Log_T___System_Func_T_string_)_T'></a>
`T`  
Type of data in the array
  
#### Parameters
<a name='Chen_Helpers_LogHelpers_Collections_Extensions_ErrorArray_T_(Chen_Helpers_LogHelpers_Log_T___System_Func_T_string_)_logger'></a>
`logger` [Log](Chen_Helpers_LogHelpers_Log 'Chen.Helpers.LogHelpers.Log')  
Log instance
  
<a name='Chen_Helpers_LogHelpers_Collections_Extensions_ErrorArray_T_(Chen_Helpers_LogHelpers_Log_T___System_Func_T_string_)_data'></a>
`data` [T](Chen_Helpers_LogHelpers_Collections_Extensions_ErrorArray_T_(Chen_Helpers_LogHelpers_Log_T___System_Func_T_string_)#Chen_Helpers_LogHelpers_Collections_Extensions_ErrorArray_T_(Chen_Helpers_LogHelpers_Log_T___System_Func_T_string_)_T 'Chen.Helpers.LogHelpers.Collections.Extensions.ErrorArray&lt;T&gt;(Chen.Helpers.LogHelpers.Log, T[], System.Func&lt;T,string&gt;).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array
  
<a name='Chen_Helpers_LogHelpers_Collections_Extensions_ErrorArray_T_(Chen_Helpers_LogHelpers_Log_T___System_Func_T_string_)_formatter'></a>
`formatter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Chen_Helpers_LogHelpers_Collections_Extensions_ErrorArray_T_(Chen_Helpers_LogHelpers_Log_T___System_Func_T_string_)#Chen_Helpers_LogHelpers_Collections_Extensions_ErrorArray_T_(Chen_Helpers_LogHelpers_Log_T___System_Func_T_string_)_T 'Chen.Helpers.LogHelpers.Collections.Extensions.ErrorArray&lt;T&gt;(Chen.Helpers.LogHelpers.Log, T[], System.Func&lt;T,string&gt;).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Logic formatter where T is the item for use
  
