#### [ChensHelpers](index 'index')
### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers')
## TemporaryParticleSystem Class
A component that should make temporary Particle Systems destroy themselves when the detonate switch is set to true and when the Particle System stops emitting.  
```csharp
public class TemporaryParticleSystem : UnityEngine.MonoBehaviour
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [UnityEngine.Object](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Object 'UnityEngine.Object') &#129106; [UnityEngine.Component](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Component 'UnityEngine.Component') &#129106; [UnityEngine.Behaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.Behaviour 'UnityEngine.Behaviour') &#129106; [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; TemporaryParticleSystem  

| Fields | |
| :--- | :--- |
| [detonate](Chen_Helpers_UnityHelpers_TemporaryParticleSystem_detonate 'Chen.Helpers.UnityHelpers.TemporaryParticleSystem.detonate') | A field switch to signal that the Game Object owning the particle system can be destroyed as soon as the Particle System stops emitting.<br/> |

| Methods | |
| :--- | :--- |
| [Awake()](Chen_Helpers_UnityHelpers_TemporaryParticleSystem_Awake() 'Chen.Helpers.UnityHelpers.TemporaryParticleSystem.Awake()') | Overrideable Awake method.<br/> |
| [FixedUpdate()](Chen_Helpers_UnityHelpers_TemporaryParticleSystem_FixedUpdate() 'Chen.Helpers.UnityHelpers.TemporaryParticleSystem.FixedUpdate()') | Overrideable FixedUpdate method.<br/> |
