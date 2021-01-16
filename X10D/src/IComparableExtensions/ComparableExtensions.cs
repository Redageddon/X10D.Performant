using System;

namespace X10D.Performant.IComparableExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="IComparable"/>.
    /// </summary>
    public static class ComparableExtensions
    {
        /// <summary>
        ///     Determines if <paramref name="value"/> is between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="lower">The exclusive lower bound.</param>
        /// <param name="upper">The exclusive upper bound.</param>
        /// <typeparam name="T">The comparable type.</typeparam>
        /// <returns>Returns <see langword="true"/> if <paramref name="value"/> is between the bounds, <see langword="false"/> otherwise.</returns>
        public static bool Between<T>(this T value, T lower, T upper)
            where T : IComparable<T> =>
            value.CompareTo(lower) > 0 && value.CompareTo(upper) < 0;

        /// <summary>
        ///     Determines if <paramref name="value"/> is outside of <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="lower">The exclusive lower bound.</param>
        /// <param name="upper">The exclusive upper bound.</param>
        /// <typeparam name="T">The comparable type.</typeparam>
        /// <returns>Returns <see langword="true"/> if <paramref name="value"/> is out of the bounds, <see langword="false"/> otherwise.</returns>
        public static bool Outside<T>(this T value, T lower, T upper)
            where T : IComparable<T> =>
            value.CompareTo(lower) < 0 || value.CompareTo(upper) > 0;

        /// <summary>
        ///     Determines what value is larger.
        /// </summary>
        /// <param name="value">The first value.</param>
        /// <param name="comparison">The second value.</param>
        /// <typeparam name="T">The comparable type.</typeparam>
        /// <returns>The largest value.</returns>
        public static T Max<T>(this T value, T comparison)
            where T : IComparable<T> =>
            value.CompareTo(comparison) < 0
                ? comparison
                : value;

        /// <summary>
        ///     Determines what value is smaller.
        /// </summary>
        /// <param name="value">The first value.</param>
        /// <param name="comparison">The second value.</param>
        /// <typeparam name="T">The comparable type.</typeparam>
        /// <returns>The smallest value.</returns>
        public static T Min<T>(this T value, T comparison)
            where T : IComparable<T> =>
            value.CompareTo(comparison) < 0
                ? value
                : comparison;

        /// <summary>
        ///     Clamps <paramref name="value"/> between <paramref name="min"/> and <paramref name="max"/>.
        /// </summary>
        /// <param name="value">The value being clamped.</param>
        /// <param name="min">The lower bound.</param>
        /// <param name="max">The higher bound.</param>
        /// <typeparam name="T">The comparable type.</typeparam>
        /// <returns>The <paramref name="min"/> if <paramref name="value"/> is less, or returns <paramref name="max"/> if <paramref name="value"/> is greater.</returns>
        public static T Clamp<T>(this T value, T min, T max)
            where T : IComparable<T> =>
            value.Max(min).Min(max);
    }
}