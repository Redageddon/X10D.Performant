namespace X10D.Performant.DoubleExtensions
{
    public static partial class DoubleExtensions
    {
        /// <summary>
        ///     Determines whether the specified value is finite (zero, subnormal, or normal).
        /// </summary>
        /// <param name="value">A double-precision floating-point number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is zero, subnormal, or normal; otherwise, <see langword="false"/>.</returns>
        public static bool IsFinite(this double value) => double.IsFinite(value);
        
        /// <summary>
        ///     Returns a value indicating whether the specified number evaluates to <see cref="double.NegativeInfinity"/> or <see cref="double.PositiveInfinity"/>.
        /// </summary>
        /// <param name="value">A double-precision floating-point number.</param>
        /// <returns>
        ///     <see langword="true"/> if <paramref name="value"/> is <see cref="double.NegativeInfinity"/> or <see cref="double.PositiveInfinity"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool IsInfinity(this double value) => double.IsInfinity(value);
        
        /// <summary>
        ///     Determines whether the specified value is negative.
        /// </summary>
        /// <param name="value">A double-precision floating-point number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is negative; otherwise, <see langword="false"/></returns>
        public static bool IsNegative(this double value) => double.IsNegative(value);
        
        /// <summary>
        ///     Determines whether the specified value is normal.
        /// </summary>
        /// <param name="value">A double-precision floating-point number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is normal; otherwise, <see langword="false"/>.</returns>
        public static bool IsNormal(this double value) => double.IsNormal(value);
        
        /// <summary>
        ///     Determines whether the specified value is subnormal.
        /// </summary>
        /// <param name="value">A double-precision floating-point number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is subnormal; otherwise, <see langword="false"/>.</returns>
        public static bool IsSubnormal(this double value) => double.IsSubnormal(value);
        
        /// <summary>
        ///      Returns a value that indicates whether the specified value is not a number (<see cref="double.NaN"/>).
        /// </summary>
        /// <param name="value">A double-precision floating-point number.</param>
        /// <returns>
        ///     <see langword="true"/> if <paramref name="value"/> evaluates to <see cref="double.NaN"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool IsNaN(this double value) => double.IsNaN(value);
        
        /// <summary>
        ///     Returns a value indicating whether the specified number evaluates to negative infinity.
        /// </summary>
        /// <param name="value">A double-precision floating-point number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> evaluates to <see cref="double.PositiveInfinity"/>; otherwise, <see langword="false"/>.</returns>
        public static bool IsPositiveInfinity(this double value) => double.IsPositiveInfinity(value);
        
        /// <summary>
        ///     Returns a value indicating whether the specified number evaluates to negative infinity.
        /// </summary>
        /// <param name="value">A double-precision floating-point number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> evaluates to <see cref="double.NegativeInfinity"/>; otherwise, <see langword="false"/>.</returns>
        public static bool IsNegativeInfinity(this double value) => double.IsNegativeInfinity(value);
    }
}