namespace X10D.Performant.CharExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="char"/>.
    /// </summary>
    public static partial class CharExtensions
    {
        /// <summary>
        ///     Repeats a <see cref="char"/> a specified number of times.
        /// </summary>
        /// <param name="value">The <see cref="char"/> to repeat.</param>
        /// <param name="count">The amount of times to repeat.</param>
        /// <returns>A <see cref="string"/> whose value is <paramref name="value"/> repeated <paramref name="count"/> times.</returns>
        public static string Repeat(this char value, int count) => new(value, count);
    }
}