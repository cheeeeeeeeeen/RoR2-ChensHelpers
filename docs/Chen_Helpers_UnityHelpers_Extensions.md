
#### [ChensHelpers](index 'index')

### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers')

## Extensions Class
Extensions for Unity objects.  
```csharp
public static class Extensions
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Extensions  

| Methods | |
| :--- | :--- |
| [GetOrAddComponent&lt;T&gt;(Component)](Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component) 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.Component)') | An extension that allows fetching or adding a component through the component of the GameObject.<br/>If the GameObject has the component, it will only fetch it and return the component.<br/>If the GameObject does not have the component, it will add one to it and return the component.<br/> |
| [GetOrAddComponent&lt;T&gt;(Component, Action&lt;T&gt;)](Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component_System_Action_T_) 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.Component, System.Action&lt;T&gt;)') | An extension that allows fetching or adding a component through the component of the GameObject.<br/>This overload contains post-processing logic of the component.<br/>Only used for cleaner code. Otherwise it is equivalent to assigning values after this method call.<br/> |
| [GetOrAddComponent&lt;T&gt;(Component, Action&lt;T&gt;, Action&lt;T&gt;)](Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_Component_System_Action_T__System_Action_T_) 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.Component, System.Action&lt;T&gt;, System.Action&lt;T&gt;)') | An extension that allows fetching or adding a component through the component of the GameObject.<br/>This overload contains post-processing logic of the component depending whether it was created or fetched.<br/>Only used for advanced logic without having to do an if-else statement after the method call.<br/> |
| [GetOrAddComponent&lt;T&gt;(GameObject)](Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_GameObject) 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject)') | An extension that allows fetching or adding a component.<br/>If the GameObject has the component, it will only fetch it and return the component.<br/>If the GameObject does not have the component, it will add one to it and return the component.<br/> |
| [GetOrAddComponent&lt;T&gt;(GameObject, Action&lt;T&gt;)](Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_GameObject_System_Action_T_) 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;)') | An extension that allows fetching or adding a component.<br/>This overload contains post-processing logic of the component.<br/>Only used for cleaner code. Otherwise it is equivalent to assigning values after this method call.<br/> |
| [GetOrAddComponent&lt;T&gt;(GameObject, Action&lt;T&gt;, Action&lt;T&gt;)](Chen_Helpers_UnityHelpers_Extensions_GetOrAddComponent_T_(UnityEngine_GameObject_System_Action_T__System_Action_T_) 'Chen.Helpers.UnityHelpers.Extensions.GetOrAddComponent&lt;T&gt;(UnityEngine.GameObject, System.Action&lt;T&gt;, System.Action&lt;T&gt;)') | An extension that allows fetching or adding a component.<br/>This overload contains post-processing logic of the component depending whether it was created or fetched.<br/>Only used for advanced logic without having to do an if-else statement after the method call.<br/> |
