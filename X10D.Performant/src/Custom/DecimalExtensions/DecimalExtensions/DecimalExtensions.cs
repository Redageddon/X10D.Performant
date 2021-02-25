using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="decimal"/>.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class DecimalExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.DegreesToRadians"/>
        public static decimal DegreesToRadians(this decimal angle) => 3.1415926535897932384626433832M * angle / 180.0M;

        /// <inheritdoc cref="DoubleExtensions.IsEven"/>
        public static bool IsEven(this decimal value) => value % 2M == 0M;

        /// <inheritdoc cref="DoubleExtensions.IsOdd"/>
        public static bool IsOdd(this decimal value) => value % 2M != 0M;

        /// <inheritdoc cref="DoubleExtensions.RadiansToDegrees"/>
        public static decimal RadiansToDegrees(this decimal angle) => angle * 180.0M / 3.1415926535897932384626433832M;
    }
}