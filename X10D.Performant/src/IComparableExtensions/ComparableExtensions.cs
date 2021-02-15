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