namespace X10D.Performant.DecimalExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="decimal"/>.
    /// </summary>
    public static partial class DecimalExtensions
    {
        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.IsEven"/>
        public static bool IsEven(this decimal value) => value % 2 == 0;

        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.IsOdd"/>
        public static bool IsOdd(this decimal value) => value % 2 != 0;

        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.RadiansToDegrees"/>
        public static decimal RadiansToDegrees(this decimal angle) => angle * 180.0m / 3.1415926535897932384626433832m;

        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.DegreesToRadians"/>
        public static decimal DegreesToRadians(this decimal angle) => 3.1415926535897932384626433832m * angle / 180.0m;
    }
}