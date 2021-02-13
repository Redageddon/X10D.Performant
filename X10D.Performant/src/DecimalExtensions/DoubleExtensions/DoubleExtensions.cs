using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="double"/>.
    /// </summary>
    public static partial class DoubleExtensions
    {
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

        /// <summary>
        ///     Converts <paramref name="angle"/> from degrees to radians.
        /// </summary>
        /// <param name="angle">The angle in degrees.</param>
        /// <returns><paramref name="angle"/> in radians.</returns>
        public static double DegreesToRadians(this double angle) => Math.PI * angle / 180.0D;
        
        /// <summary>
        ///     Converts <paramref name="angle"/> from degrees to gradians.
        /// </summary>
        /// <param name="angle">The angle in degrees.</param>
        /// <returns><paramref name="angle"/> in gradians.</returns>
        public static double DegreesToGradians(this double angle) => angle * 10D / 9D;       
        
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
        ///     Takes the inverse square root of <paramref name="value"/>.
        /// </summary>
        /// <param name="value">A double precision floating point value.</param>
        /// <returns>1 divided by the square root of <paramref name="value"/>.</returns>
        public static double InverseSqrt(this double value) => 1D / Math.Sqrt(value);
    }
}