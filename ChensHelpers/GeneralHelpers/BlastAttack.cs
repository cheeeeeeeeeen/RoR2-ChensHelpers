using RoR2BlastAttack = RoR2.BlastAttack;

namespace Chen.Helpers.GeneralHelpers
{
    /// <summary>
    /// Improvised BlastAttack from Vanilla RoR2 so that it is more helpful for modding.
    /// </summary>
    public class BlastAttack : RoR2BlastAttack
    {
        /// <summary>
        /// Modified Fire method from vanilla BlastAttack. It returns the array of victims instead of number of targets hit.
        /// </summary>
        /// <returns>Array of victims stored in HitPoint</returns>
        public HitPointAndResult InformativeFire()
        {
            HitPoint[] array = CollectHits();
            HandleHits(array);
            return new HitPointAndResult
            {
                hitPoints = array,
                result = new Result { hitCount = array.Length }
            };
        }

        /// <summary>
        /// Combination of BlastAttack.HitPoint and BlastAttack.Result.
        /// </summary>
        public struct HitPointAndResult
        {
            /// <summary>
            /// Array of HitPoint of BlastAttack. Contains all the victims.
            /// </summary>
            public HitPoint[] hitPoints;

            /// <summary>
            /// Result struct of BlastAttack. Only contains the count of the array of HitPoint, but for completeness, this is included as well within the struct.
            /// </summary>
            public Result result;
        }
    }
}