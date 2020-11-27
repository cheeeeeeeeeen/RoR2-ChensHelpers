using UnityEngine;

namespace Chen.Helpers.MathHelpers
{
    /// <summary>
    /// Math helper for easily computing Wave behaviors.
    /// </summary>
    public static class Wave
    {
        /// <summary>
        /// Computes for a Sine Wave. Always multiply this to the original value.
        /// </summary>
        /// <param name="phase">Offset from time</param>
        /// <param name="frequency">Number of complete cycles in a given time</param>
        /// <param name="amplitude">Maximum and minimum values</param>
        /// <param name="baseValue">Offset from the result</param>
        /// <returns>The computed value for the wave</returns>
        public static float Sine(float phase, float frequency, float amplitude, float baseValue)
        {
            float x = GetX(phase, frequency);
            float y = Mathf.Sin(x * 2 * Mathf.PI);
            return Compute(y, amplitude, baseValue);
        }

        /// <summary>
        /// Computes for a Triangle Wave. Always multiply this to the original value.
        /// </summary>
        /// <param name="phase">Offset from time</param>
        /// <param name="frequency">Number of complete cycles in a given time</param>
        /// <param name="amplitude">Maximum and minimum values</param>
        /// <param name="baseValue">Offset from the result</param>
        /// <returns>The computed value for the wave</returns>
        public static float Triangle(float phase, float frequency, float amplitude, float baseValue)
        {
            float x = GetX(phase, frequency);
            float y;
            if (x < .5f) y = 4f * x - 1f;
            else y = -4f * x + 3f;
            return Compute(y, amplitude, baseValue);
        }

        /// <summary>
        /// Computes for a Square Wave. Always multiply this to the original value.
        /// </summary>
        /// <param name="phase">Offset from time</param>
        /// <param name="frequency">Number of complete cycles in a given time</param>
        /// <param name="amplitude">Maximum and minimum values</param>
        /// <param name="baseValue">Offset from the result</param>
        /// <returns>The computed value for the wave</returns>
        public static float Square(float phase, float frequency, float amplitude, float baseValue)
        {
            float x = GetX(phase, frequency);
            float y;
            if (x < .5f) y = 1f;
            else y = -1f;
            return Compute(y, amplitude, baseValue);
        }

        /// <summary>
        /// Computes for a Sawtooth Wave. Always multiply this to the original value.
        /// </summary>
        /// <param name="phase">Offset from time</param>
        /// <param name="frequency">Number of complete cycles in a given time</param>
        /// <param name="amplitude">Maximum and minimum values</param>
        /// <param name="baseValue">Offset from the result</param>
        /// <returns>The computed value for the wave</returns>
        public static float Sawtooth(float phase, float frequency, float amplitude, float baseValue)
        {
            return Compute(GetX(phase, frequency), amplitude, baseValue);
        }

        /// <summary>
        /// Computes for an Inverted Sawtooth Wave. Always multiply this to the original value.
        /// </summary>
        /// <param name="phase">Offset from time</param>
        /// <param name="frequency">Number of complete cycles in a given time</param>
        /// <param name="amplitude">Maximum and minimum values</param>
        /// <param name="baseValue">Offset from the result</param>
        /// <returns>The computed value for the wave</returns>
        public static float InvertedSawtooth(float phase, float frequency, float amplitude, float baseValue)
        {
            return Compute(1f - GetX(phase, frequency), amplitude, baseValue);
        }

        /// <summary>
        /// Computes for a Noisy Wave. Always multiply this to the original value.
        /// </summary>
        /// <param name="amplitude">Maximum and minimum values</param>
        /// <param name="baseValue">Offset from the result</param>
        /// <returns>The computed value for the wave</returns>
        public static float Noisy(float amplitude, float baseValue)
        {
            return Compute(1f - Random.value * 2, amplitude, baseValue);
        }

        private static float GetX(float phase, float frequency)
        {
            float x = (Time.time + phase) * frequency;
            return x - Mathf.Floor(x);
        }

        private static float Compute(float y, float amplitude, float baseValue)
        {
            return (y * amplitude) + baseValue;
        }
    }
}
