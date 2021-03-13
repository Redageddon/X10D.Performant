namespace X10D.Performant.DoubleExtensions
{
    public static partial class DoubleExtensions
    {
        /// <summary>
        ///     Performs linear interpolation between two values.
        /// </summary>
        /// <param name="alpha">The percent amount to interpolate 2 values in the range of 0 to 1.</param>
        /// <param name="firstValue">The first value to lerp to.</param>
        /// <param name="secondValue">The second value to lerp to.</param>
        /// <returns>
        ///     A value that is between <paramref name="firstValue"/> and <paramref name="secondValue"/> by a percent of <paramref name="alpha"/>.
        /// </returns>
        public static double Lerp(this double alpha, double firstValue, double secondValue) => (firstValue * (1 - alpha)) + (secondValue * alpha);

        /// <inheritdoc cref="Lerp"/>
        public static double LerpTo(this double firstValue, double secondValue, double alpha) => (firstValue * (1 - alpha)) + (secondValue * alpha);

        /// <summary>
        ///     Performs a clamped linear interpolation between two values.
        /// </summary>
        /// <param name="alpha">The percent amount to interpolate 2 values in the range of 0 to 1.</param>
        /// <param name="firstValue">The first value to lerp to.</param>
        /// <param name="secondValue">The second value to lerp to.</param>
        /// <returns>
        ///     A value that is between <paramref name="firstValue"/> and <paramref name="secondValue"/> by a percent of <paramref name="alpha"/>.
        ///     The result cannot be less than <paramref name="firstValue"/> or greater than <paramref name="secondValue"/>.
        /// </returns>
        public static double ClampedLerp(this double alpha, double firstValue, double secondValue) =>
            alpha switch
            {
                <= 0 => firstValue,
                >= 1 => secondValue,
                _    => (firstValue * (1 - alpha)) + (secondValue * alpha),
            };

        /// <inheritdoc cref="ClampedLerp"/>
        public static double ClampedLerpTo(this double firstValue, double secondValue, double alpha) =>
            alpha switch
            {
                <= 0 => firstValue,
                >= 1 => secondValue,
                _    => (firstValue * (1 - alpha)) + (secondValue * alpha),
            };
    }
}