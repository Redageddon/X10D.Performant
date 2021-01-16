namespace X10D.Performant.FloatExtensions
{
    public static partial class FloatExtensions
    {
        /// <summary>
        ///     Determines whether the specified value is finite (zero, subnormal, or normal).
        /// </summary>
        /// <param name="value">A single-precision floating-point number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is zero, subnormal, or normal; otherwise, <see langword="false"/>.</returns>
        public static bool IsFinite(this float value) => float.IsFinite(value);
        
        /// <summary>
        ///     Returns a value indicating whether the specified number evaluates to <see cref="float.NegativeInfinity"/> or <see cref="float.PositiveInfinity"/>.
        /// </summary>
        /// <param name="value">A single-precision floating-point number.</param>
        /// <returns>
        ///     <see langword="true"/> if <paramref name="value"/> is <see cref="float.NegativeInfinity"/> or <see cref="float.PositiveInfinity"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool IsInfinity(this float value) => float.IsInfinity(value);
        
        /// <summary>
        ///     Determines whether the specified value is negative.
        /// </summary>
        /// <param name="value">A single-precision floating-point number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is negative; otherwise, <see langword="false"/></returns>
        public static bool IsNegative(this float value) => float.IsNegative(value);
        
        /// <summary>
        ///     Determines whether the specified value is normal.
        /// </summary>
        /// <param name="value">A single-precision floating-point number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is normal; otherwise, <see langword="false"/>.</returns>
        public static bool IsNormal(this float value) => float.IsNormal(value);
        
        /// <summary>
        ///     Determines whether the specified value is subnormal.
        /// </summary>
        /// <param name="value">A single-precision floating-point number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> is subnormal; otherwise, <see langword="false"/>.</returns>
        public static bool IsSubnormal(this float value) => float.IsSubnormal(value);
        
        /// <summary>
        ///      Returns a value that indicates whether the specified value is not a number (<see cref="float.NaN"/>).
        /// </summary>
        /// <param name="value">A single-precision floating-point number.</param>
        /// <returns>
        ///     <see langword="true"/> if <paramref name="value"/> evaluates to <see cref="float.NaN"/>; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool IsNaN(this float value) => float.IsNaN(value);
        
        /// <summary>
        ///     Returns a value indicating whether the specified number evaluates to negative infinity.
        /// </summary>
        /// <param name="value">A single-precision floating-point number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> evaluates to <see cref="float.PositiveInfinity"/>; otherwise, <see langword="false"/>.</returns>
        public static bool IsPositiveInfinity(this float value) => float.IsPositiveInfinity(value);
        
        /// <summary>
        ///     Returns a value indicating whether the specified number evaluates to negative infinity.
        /// </summary>
        /// <param name="value">A single-precision floating-point number.</param>
        /// <returns><see langword="true"/> if <paramref name="value"/> evaluates to <see cref="float.NegativeInfinity"/>; otherwise, <see langword="false"/>.</returns>
        public static bool IsNegativeInfinity(this float value) => float.IsNegativeInfinity(value);
    }
}