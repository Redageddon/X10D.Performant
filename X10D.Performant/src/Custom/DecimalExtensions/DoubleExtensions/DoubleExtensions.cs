using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="double"/>.
    /// </summary>
    public static partial class DoubleExtensions
    {
        /// <summary>
        ///     Returns true if 2 numbers are within a certain tolerance of each other.
        /// </summary>
        /// <param name="value1">The first value to compare.</param>
        /// <param name="value2">The second value to compare.</param>
        /// <param name="tolerance">The difference allowed between the two values before <see langword="false"/> is returned.</param>
        /// <returns>
        ///     <see langword="true"/> if <paramref name="value1"/> and <paramref name="value2"/> are within <paramref name="tolerance"/> distance,
        ///     else <see langword="false"/>.
        /// </returns>
        public static bool AlmostEquals(this double value1, double value2, double tolerance = double.Epsilon) =>
            Math.Abs(value1 - value2) < Math.Abs(tolerance);

        /// <summary>
        ///     Takes the inverse square root of <paramref name="value"/>.
        /// </summary>
        /// <param name="value">A double precision floating point value.</param>
        /// <returns>1 divided by the square root of <paramref name="value"/>.</returns>
        public static double InverseSqrt(this double value) => 1D / Math.Sqrt(value);

        /// <summary>
        ///     Determines if the <paramref name="value"/> is even.
        /// </summary>
        /// <param name="value">The number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is even, <see langword="false"/> otherwise.</returns>
        public static bool IsEven(this double value) => value % 2D == 0D;

        /// <summary>
        ///     Determines if the <paramref name="value"/> is odd.
        /// </summary>
        /// <param name="value">The number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is odd, <see langword="false"/> otherwise.</returns>
        public static bool IsOdd(this double value) => value % 2D != 0D;
    }
}