using System;

namespace X10D.Performant.DoubleExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="double"/>.
    /// </summary>
    public static partial class DoubleExtensions
    {
        /// <summary>
        ///     Converts the <paramref name="value"/> to a <see cref="T:byte[]"/>.
        /// </summary>
        /// <param name="value">The number to convert.</param>
        /// <returns>Returns a <see cref="byte"/>[].</returns>
        public static byte[] GetBytes(this double value) => BitConverter.GetBytes(value);

        /// <summary>
        ///     Determines if the <paramref name="value"/> is even.
        /// </summary>
        /// <param name="value">The number.</param>
        /// <returns>Returns <see langword="true"/> if <paramref name="value"/> is even, <see langword="false"/> otherwise.</returns>
        public static bool IsEven(this double value) => value % 2 == 0;

        /// <summary>
        ///     Determines if the <paramref name="value"/> is odd.
        /// </summary>
        /// <param name="value">The number.</param>
        /// <returns>Returns <see langword="true"/> if <paramref name="value"/> is odd, <see langword="false"/> otherwise.</returns>
        public static bool IsOdd(this double value) => value % 2 != 0;

        /// <summary>
        ///     Converts <paramref name="angle"/> from radians to degrees.
        /// </summary>
        /// <param name="angle">The angle in radians.</param>
        /// <returns>Returns <paramref name="angle"/> in degrees.</returns>
        public static double RadiansToDegrees(this double angle) => angle * 180.0 / Math.PI;

        /// <summary>
        ///     Converts <paramref name="angle"/> from degrees to radians.
        /// </summary>
        /// <param name="angle">The angle in degrees.</param>
        /// <returns>Returns <paramref name="angle"/> in radians.</returns>
        public static double DegreesToRadians(this double angle) => Math.PI * angle / 180.0;

        /// <summary>
        ///     Rounds to the nearest value.
        /// </summary>
        /// <param name="value">The value to round.</param>
        /// <param name="nearest">The nearest value.</param>
        /// <returns>Returns the rounded value.</returns>
        public static double Round(this double value, double nearest = 1) => Math.Round(value / nearest) * nearest;
    }
}