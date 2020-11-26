
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.GeneralHelpers](./ETEQ0RLckShPNesJc2reiw 'Chen.Helpers.GeneralHelpers').[AssetsManager](./A0AsbIQQ4FDaS87xdtpw-A 'Chen.Helpers.GeneralHelpers.AssetsManager')

## AssetsManager.Add(string, string, Chen.Helpers.GeneralHelpers.AssetsManager.BundleType) Method
Used to add a bundle for the manager to handle.  
This is an overload alternative.  
```csharp
public bool Add(string modPrefix, string source, Chen.Helpers.GeneralHelpers.AssetsManager.BundleType type);
```

#### Parameters
<a name='kschgMzjsq71giJOv3jqpw'></a>
`modPrefix` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Prefix to use for the bundle  
  
<a name='yz+J5YYpqJgmBfAZtcGmdw'></a>
`source` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Embedded resource path of the bundle  
  
<a name='D90DlCHWqFDIdyDHlaoLeg'></a>
`type` [AssetsManager.BundleType](./bFpSSHTQeKl4Z9X-4dZHRw 'Chen.Helpers.GeneralHelpers.AssetsManager.BundleType')  
Bundle Type  
  

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if the bundle is added. False if the bundle already exists or has the same name.  
