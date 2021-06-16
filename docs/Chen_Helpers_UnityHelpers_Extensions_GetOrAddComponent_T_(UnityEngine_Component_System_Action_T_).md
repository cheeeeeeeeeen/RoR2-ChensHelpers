
#### [ChensHelpers](index 'index')

### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers').[Extensions](Chen_Helpers_UnityHelpers_Extensions 'Chen.Helpers.UnityHelpers.Extensions')

## Extensions.GetOrAddComponent&lt;T&gt;(Component, Action&lt;T&gt;) Method
An extension that allows fetching or adding a component through the component of the GameObject.  
This overload contains post-processing logic of the component.  
Only used for cleaner code. Otherwise it is equivalent to assigning values after this method call.  
```csharp
public static T GetOrAddComponent<T>(this UnityEngine.Component component, System.Action<T> action)
    where T : UnityEngine.Component;
```

#### Type parameters
<a name='Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component_System_Action_T_)_T'></a>
`T`  
A Unity Component
  

#### Parameters
<a name='Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component_System_Action_T_)_component'></a>
`component` [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component')  
The GameObject of the component to fetch from or add to
  
<a name='Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component_System_Action_T_)_action'></a>
`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component_System_Action_T_)#Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component_System_Action_T_)_T 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.Component, System.Action&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
Post-Processor code
  

#### Returns
[T](Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component_System_Action_T_)#Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component_System_Action_T_)_T 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.Component, System.Action&lt;T&gt;).T')  
The component specified as T
