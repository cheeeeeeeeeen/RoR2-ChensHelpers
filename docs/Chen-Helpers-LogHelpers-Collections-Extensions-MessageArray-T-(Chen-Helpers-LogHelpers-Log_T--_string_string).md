
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.LogHelpers.Collections](./Chen-Helpers-LogHelpers-Collections 'Chen.Helpers.LogHelpers.Collections').[Extensions](./Chen-Helpers-LogHelpers-Collections-Extensions 'Chen.Helpers.LogHelpers.Collections.Extensions')

## Extensions.MessageArray&lt;T&gt;(Chen.Helpers.LogHelpers.Log, T[], string, string) Method
Logs an array of values using the Message format. Use the format parameter to control how the log entry will be displayed. Leave as is for plain logs.  
The representation parameter will be the token that will be used to display the data that is specified in the format parameter (default is %DATA%).  
e.g. MessageArray(new string[] { "Chen", "is", "AWESOME" }, "-> %X%..!", "%X%") will yield:  
-> Chen..!  
-> is..!  
-> AWESOME..!  
```csharp
public static void MessageArray<T>(this Chen.Helpers.LogHelpers.Log logger, T[] data, string format="%DATA%", string representation="%DATA%");
```

#### Type parameters
<a name='Chen-Helpers-LogHelpers-Collections-Extensions-MessageArray-T-(Chen-Helpers-LogHelpers-Log_T--_string_string)-T'></a>
`T`  
Type of data in the array  
  

#### Parameters
<a name='Chen-Helpers-LogHelpers-Collections-Extensions-MessageArray-T-(Chen-Helpers-LogHelpers-Log_T--_string_string)-logger'></a>
`logger` [Log](./Chen-Helpers-LogHelpers-Log 'Chen.Helpers.LogHelpers.Log')  
Log instance  
  
<a name='Chen-Helpers-LogHelpers-Collections-Extensions-MessageArray-T-(Chen-Helpers-LogHelpers-Log_T--_string_string)-data'></a>
`data` [T](#Chen-Helpers-LogHelpers-Collections-Extensions-MessageArray-T-(Chen-Helpers-LogHelpers-Log_T--_string_string)-T 'Chen.Helpers.LogHelpers.Collections.Extensions.MessageArray&lt;T&gt;(Chen.Helpers.LogHelpers.Log, T[], string, string).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The array  
  
<a name='Chen-Helpers-LogHelpers-Collections-Extensions-MessageArray-T-(Chen-Helpers-LogHelpers-Log_T--_string_string)-format'></a>
`format` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The format that will be outputted per item, with the item represented as %DATA%  
            (can be overridden through representation parameter)  
  
<a name='Chen-Helpers-LogHelpers-Collections-Extensions-MessageArray-T-(Chen-Helpers-LogHelpers-Log_T--_string_string)-representation'></a>
`representation` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Token that will be used as the item when parsing the format  
  
