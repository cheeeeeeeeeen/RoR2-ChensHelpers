
#### [ChensHelpers](./index 'index')

### [Chen.Helpers.UnityHelpers](./Chen-Helpers-UnityHelpers 'Chen.Helpers.UnityHelpers').[Extensions](./Chen-Helpers-UnityHelpers-Extensions 'Chen.Helpers.UnityHelpers.Extensions')

## Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.Component, System.Action&lt;T&gt;) Method
An extension that allows fetching or adding a component through the component of the GameObject.  
This overload contains post-processing logic of the component.  
Only used for cleaner code. Otherwise it is equivalent to assigning values after this method call.  
```csharp
public static T GetOrAddComponent<T>(this UnityEngine.Component component, System.Action<T> action);
```

#### Type parameters
<a name='Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-Component_System-Action-T-)-T'></a>
`T`  
A Unity Component  
  

#### Parameters
<a name='Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-Component_System-Action-T-)-component'></a>
`component` [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')  
The GameObject of the component to fetch from or add to  
  
<a name='Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-Component_System-Action-T-)-action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](#Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-Component_System-Action-T-)-T 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.Component, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Post-Processor code  
  

#### Returns
[T](#Chen-Helpers-UnityHelpers-Extensions-GetOrAddComponent-T-(UnityEngine-Component_System-Action-T-)-T 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.Component, System.Action&lt;T&gt;).T')  
The component specified as T  
