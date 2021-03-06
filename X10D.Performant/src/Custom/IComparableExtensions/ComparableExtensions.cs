using System;

namespace X10D.Performant
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
        /// <returns><see langword="true"/> if <paramref name="value"/> is between the bounds, <see langword="false"/> otherwise.</returns>
        public static bool Between<T>(this T value, T lower, T upper)
            where T : IComparable<T> =>
            value.CompareTo(lower) > 0 && value.CompareTo(upper) < 0;

        /// <summary>
        ///     Returns the current value clamped to the inclusive range of <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">The value to be clamped.</param>
        /// <param name="lower">The lower bound of the result.</param>
        /// <param name="upper">The upper bound of the result.</param>
        /// <typeparam name="T">An <see cref="IComparable"/> type.</typeparam>
        /// <returns>
        ///     <paramref name="value"/> if <paramref name="lower"/> ≤ <paramref name="value"/> ≤ <paramref name="upper"/>.
        ///     -or-
        ///     <paramref name="lower"/> if <paramref name="value"/> &lt; <paramref name="lower"/>.
        ///     -or-
        ///     <paramref name="upper"/> if <paramref name="upper"/> &lt; <paramref name="value"/>.
        /// </returns>
        public static T Clamp<T>(this T value, T lower, T upper)
            where T : IComparable<T> =>
            value.Max(lower).Min(upper);

        /// <summary>
        ///     Determines if the current value is greater than another value.
        /// </summary>
        /// <param name="value">The first value.</param>
        /// <param name="other">The second value.</param>
        /// <typeparam name="T1">An <see cref="IComparable{T2}"/> type.</typeparam>
        /// <typeparam name="T2">The comparison operand type.</typeparam>
        /// <returns>
        ///     <see langword="true"/> if <paramref name="value"/> is greater than <paramref name="other"/>
        ///     -or-
        ///     <see langword="false"/> otherwise.
        /// </returns>
        public static bool GreaterThan<T1, T2>(this T1 value, T2 other)
            where T1 : IComparable<T2> =>
            value.CompareTo(other) > 0;

        /// <summary>
        ///     Determines if the current value is less than another value.
        /// </summary>
        /// <param name="value">The first value.</param>
        /// <param name="other">The second value.</param>
        /// <typeparam name="T1">An <see cref="IComparable{T2}"/> type.</typeparam>
        /// <typeparam name="T2">The comparison operand type.</typeparam>
        /// <returns>
        ///     <see langword="true"/> if <paramref name="value"/> is less than <paramref name="other"/>
        ///     -or-
        ///     <see langword="false"/> otherwise.
        /// </returns>
        public static bool LessThan<T1, T2>(this T1 value, T2 other)
            where T1 : IComparable<T2> =>
            value.CompareTo(other) < 0;

        /// <summary>
        ///     Returns the maximum of two values.
        /// </summary>
        /// <param name="value">The first value.</param>
        /// <param name="other">The second value.</param>
        /// <typeparam name="T">A type which implements <see cref="IComparable{T}"/>.</typeparam>
        /// <returns>
        ///     <paramref name="value"/> if <paramref name="value"/> is greater than <paramref name="other"/>
        ///     -or-
        ///     <paramref name="other"/> otherwise.
        /// </returns>
        public static T Max<T>(this T value, T other)
            where T : IComparable<T> =>
            value.GreaterThan(other) ? value : other;

        /// <summary>
        ///     Returns the minimum of two values.
        /// </summary>
        /// <param name="value">The first value.</param>
        /// <param name="other">The second value.</param>
        /// <typeparam name="T">A type which implements <see cref="IComparable{T}"/>.</typeparam>
        /// <returns>
        ///     <paramref name="value"/> if <paramref name="value"/> is less than <paramref name="other"/>
        ///     -or-
        ///     <paramref name="other"/> otherwise.
        /// </returns>
        public static T Min<T>(this T value, T other)
            where T : IComparable<T> =>
            value.LessThan(other) ? value : other;

        /// <summary>
        ///     Determines if <paramref name="value"/> is outside of <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">The value to compare.</param>
        /// <param name="lower">The exclusive lower bound.</param>
        /// <param name="upper">The exclusive upper bound.</param>
        /// <typeparam name="T">The comparable type.</typeparam>
        /// <returns><see langword="true"/> if <paramref name="value"/> is out of the bounds, <see langword="false"/> otherwise.</returns>
        public static bool Outside<T>(this T value, T lower, T upper)
            where T : IComparable<T> =>
            value.CompareTo(lower) < 0 || value.CompareTo(upper) > 0;
    }
}