#### [ChensHelpers](./index 'index')
### [Chen.Helpers.UnityHelpers](./Chen-Helpers-UnityHelpers 'Chen.Helpers.UnityHelpers').[Extensions](./Chen-Helpers-UnityHelpers-Extensions 'Chen.Helpers.UnityHelpers.Extensions')
## Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;, System.Action&lt;T&gt;) Method
An extension that allows fetching or adding a component.  
This overload contains post-processing logic of the component depending whether it was created or fetched.  
Only used for advanced logic without having to do an if-else statement after the method call.  
```csharp
public static T GetOrAddComponent<T>(this UnityEngine.GameObject gameObject, System.Action<T> getAction, System.Action<T> addAction);
```
#### Type parameters
<a name='Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-GameObject_System-Action-T-_System-Action-T-)-T'></a>
`T`  
  
  
#### Parameters
<a name='Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-GameObject_System-Action-T-_System-Action-T-)-gameObject'></a>
`gameObject` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
  
  
<a name='Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-GameObject_System-Action-T-_System-Action-T-)-getAction'></a>
`getAction` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](#Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-GameObject_System-Action-T-_System-Action-T-)-T 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
  
  
<a name='Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-GameObject_System-Action-T-_System-Action-T-)-addAction'></a>
`addAction` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](#Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-GameObject_System-Action-T-_System-Action-T-)-T 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
  
  
#### Returns
[T](#Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-GameObject_System-Action-T-_System-Action-T-)-T 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;, System.Action&lt;T&gt;).T')  
The component specified as T  
