#### [ChensHelpers](index 'index')
### [Chen.Helpers.LogHelpers.Collections](Chen_Helpers_LogHelpers_Collections 'Chen.Helpers.LogHelpers.Collections').[Extensions](Chen_Helpers_LogHelpers_Collections_Extensions 'Chen.Helpers.LogHelpers.Collections.Extensions')
## Extensions.DebugArray&lt;T&gt;(Log, T[], string, string) Method
Logs an array of values using the Debug format. Use the format parameter to control how the log entry will be displayed. Leave as is for plain logs.  
The representation parameter will be the token that will be used to display the data that is specified in the format parameter (default is %DATA%).  
e.g. DebugArray(new string[] { "Chen", "is", "AWESOME" }, "-> %X%..!", "%X%") will yield:  
-> Chen..!  
-> is..!  
-> AWESOME..!  
```csharp
public static void DebugArray<T>(this Chen.Helpers.LogHelpers.Log logger, T[] data, string format="%DATA%", string representation="%DATA%");
```
#### Type parameters
<a name='Chen_Helpers_LogHelpers_Collections_Extensions_DebugArray_T_(Chen_Helpers_LogHelpers_Log_T___string_string)_T'></a>
`T`  
Type of data in the array
  
#### Parameters
<a name='Chen_Helpers_LogHelpers_Collections_Extensions_DebugArray_T_(Chen_Helpers_LogHelpers_Log_T___string_string)_logger'></a>
`logger` [Log](Chen_Helpers_LogHelpers_Log 'Chen.Helpers.LogHelpers.Log')  
Log instance
  
<a name='Chen_Helpers_LogHelpers_Collections_Extensions_DebugArray_T_(Chen_Helpers_LogHelpers_Log_T___string_string)_data'></a>
`data` [T](Chen_Helpers_LogHelpers_Collections_Extensions_DebugArray_T_(Chen_Helpers_LogHelpers_Log_T___string_string)#Chen_Helpers_LogHelpers_Collections_Extensions_DebugArray_T_(Chen_Helpers_LogHelpers_Log_T___string_string)_T 'Chen.Helpers.LogHelpers.Collections.Extensions.DebugArray&lt;T&gt;(Chen.Helpers.LogHelpers.Log, T[], string, string).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array
  
<a name='Chen_Helpers_LogHelpers_Collections_Extensions_DebugArray_T_(Chen_Helpers_LogHelpers_Log_T___string_string)_format'></a>
`format` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The format that will be outputted per item, with the item represented as %DATA%  
            (can be overridden through representation parameter)
  
<a name='Chen_Helpers_LogHelpers_Collections_Extensions_DebugArray_T_(Chen_Helpers_LogHelpers_Log_T___string_string)_representation'></a>
`representation` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Token that will be used as the item when parsing the format
  
