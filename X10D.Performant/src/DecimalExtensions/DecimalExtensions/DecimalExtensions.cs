﻿namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="decimal"/>.
    /// </summary>
    public static partial class DecimalExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.IsEven"/>
        public static bool IsEven(this decimal value) => value % 2 == 0;

        /// <inheritdoc cref="DoubleExtensions.IsOdd"/>
        public static bool IsOdd(this decimal value) => value % 2 != 0;

        /// <inheritdoc cref="DoubleExtensions.RadiansToDegrees"/>
        public static decimal RadiansToDegrees(this decimal angle) => angle * 180.0m / 3.1415926535897932384626433832m;

        /// <inheritdoc cref="DoubleExtensions.DegreesToRadians"/>
        public static decimal DegreesToRadians(this decimal angle) => 3.1415926535897932384626433832m * angle / 180.0m;
    }
}