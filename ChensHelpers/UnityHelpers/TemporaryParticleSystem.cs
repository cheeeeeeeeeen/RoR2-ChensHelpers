using UnityEngine;

namespace Chen.Helpers.UnityHelpers
{
    /// <summary>
    /// A component that should make temporary Particle Systems destroy themselves when the detonate switch is set to true and when the Particle System stops emitting.
    /// </summary>
    public class TemporaryParticleSystem : MonoBehaviour
    {
        /// <summary>
        /// A field switch to signal that the Game Object owning the particle system can be destroyed as soon as the Particle System stops emitting.
        /// </summary>
        public bool detonate;

        private ParticleSystem particleSystem;

        /// <summary>
        /// Overrideable Awake method.
        /// </summary>
        protected virtual void Awake()
        {
            detonate = true;
            particleSystem = gameObject.GetComponent<ParticleSystem>();
            if (!particleSystem) Destroy(this);
        }

        /// <summary>
        /// Overrideable FixedUpdate method.
        /// </summary>
        protected virtual void FixedUpdate()
        {
            if (detonate && !particleSystem.isEmitting) Destroy(gameObject);
        }
    }
}