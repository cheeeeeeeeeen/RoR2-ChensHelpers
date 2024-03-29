#### [ChensHelpers](index 'index')
### [Chen.Helpers.UnityHelpers](Chen_Helpers_UnityHelpers 'Chen.Helpers.UnityHelpers')
## TemporaryParticleSystem Class
A component that should make temporary Particle Systems destroy themselves when the detonate switch is set to true and when the Particle System stops emitting.  
```csharp
public class TemporaryParticleSystem
```

Inheritance [UnityEngine.MonoBehaviour](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.MonoBehaviour 'UnityEngine.MonoBehaviour') &#129106; TemporaryParticleSystem  

| Fields | |
| :--- | :--- |
| [detonate](Chen_Helpers_UnityHelpers_TemporaryParticleSystem_detonate 'Chen.Helpers.UnityHelpers.TemporaryParticleSystem.detonate') | A field switch to signal that the Game Object owning the particle system can be destroyed as soon as the Particle System stops emitting.<br/> |
| [particleSystem](Chen_Helpers_UnityHelpers_TemporaryParticleSystem_particleSystem 'Chen.Helpers.UnityHelpers.TemporaryParticleSystem.particleSystem') | The Particle System partnered with this component.<br/> |

| Methods | |
| :--- | :--- |
| [Awake()](Chen_Helpers_UnityHelpers_TemporaryParticleSystem_Awake() 'Chen.Helpers.UnityHelpers.TemporaryParticleSystem.Awake()') | Overrideable Awake method.<br/> |
| [FixedUpdate()](Chen_Helpers_UnityHelpers_TemporaryParticleSystem_FixedUpdate() 'Chen.Helpers.UnityHelpers.TemporaryParticleSystem.FixedUpdate()') | Overrideable FixedUpdate method.<br/> |
