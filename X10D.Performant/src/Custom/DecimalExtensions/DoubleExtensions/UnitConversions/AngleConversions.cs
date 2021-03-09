using System;

namespace X10D.Performant
{
    public static partial class DoubleExtensions
    {
        /// <summary>
        ///     Converts <paramref name="angle"/> from degrees to gradians.
        /// </summary>
        /// <param name="angle">The angle in degrees.</param>
        /// <returns><paramref name="angle"/> in gradians.</returns>
        public static double DegreesToGradians(this double angle) => angle * 10D / 9D;

        /// <summary>
        ///     Converts <paramref name="angle"/> from degrees to radians.
        /// </summary>
        /// <param name="angle">The angle in degrees.</param>
        /// <returns><paramref name="angle"/> in radians.</returns>
        public static double DegreesToRadians(this double angle) => Math.PI * angle / 180.0D;

        /// <summary>
        ///     Converts <paramref name="angle"/> from gradians to degrees.
        /// </summary>
        /// <param name="angle">The angle in gradians.</param>
        /// <returns><paramref name="angle"/> in degrees.</returns>
        public static double GradiansToDegrees(this double angle) => angle * 9D / 10D;

        /// <summary>
        ///     Converts <paramref name="angle"/> from gradians to radians.
        /// </summary>
        /// <param name="angle">The angle in gradians.</param>
        /// <returns><paramref name="angle"/> in radians.</returns>
        public static double GradiansToRadians(this double angle) => angle * Math.PI / 200D;

        /// <summary>
        ///     Converts <paramref name="angle"/> from radians to degrees.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns><paramref name="angle"/> in degrees.</returns>
        public static double RadiansToDegrees(this double angle) => angle * 180.0D / Math.PI;

        /// <summary>
        ///     Converts <paramref name="angle"/> from radians to gradians.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns><paramref name="angle"/> in gradians.</returns>
        public static double RadiansToGradians(this double angle) => angle * 200D / Math.PI;
    }
}