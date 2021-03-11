using System;

namespace X10D.Performant
{
    public static partial class DoubleExtensions
    {
        /// <summary>
        ///     Converts <paramref name="degree"/> from degrees to gradians.
        /// </summary>
        /// <param name="degree">The angle in degrees.</param>
        /// <returns><paramref name="degree"/> in gradians.</returns>
        public static double DegreesToGradians(this double degree) => degree * 10D / 9D;

        /// <summary>
        ///     Converts <paramref name="degree"/> from degrees to radians.
        /// </summary>
        /// <param name="degree">The angle in degrees.</param>
        /// <returns><paramref name="degree"/> in radians.</returns>
        public static double DegreesToRadians(this double degree) => Math.PI * degree / 180.0D;

        /// <summary>
        ///     Converts <paramref name="gradian"/> from gradians to degrees.
        /// </summary>
        /// <param name="gradian">The angle in gradians.</param>
        /// <returns><paramref name="gradian"/> in degrees.</returns>
        public static double GradiansToDegrees(this double gradian) => gradian * 9D / 10D;

        /// <summary>
        ///     Converts <paramref name="gradian"/> from gradians to radians.
        /// </summary>
        /// <param name="gradian">The angle in gradians.</param>
        /// <returns><paramref name="gradian"/> in radians.</returns>
        public static double GradiansToRadians(this double gradian) => gradian * Math.PI / 200D;

        /// <summary>
        ///     Converts <paramref name="radian"/> from radians to degrees.
        /// </summary>
        /// <param name="radian">The angle in radians.</param>
        /// <returns><paramref name="radian"/> in degrees.</returns>
        public static double RadiansToDegrees(this double radian) => radian * 180.0D / Math.PI;

        /// <summary>
        ///     Converts <paramref name="radian"/> from radians to gradians.
        /// </summary>
        /// <param name="radian">The angle in radians.</param>
        /// <returns><paramref name="radian"/> in gradians.</returns>
        public static double RadiansToGradians(this double radian) => radian * 200D / Math.PI;
    }
}