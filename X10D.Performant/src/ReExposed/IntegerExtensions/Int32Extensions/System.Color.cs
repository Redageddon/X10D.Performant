using System.Drawing;

namespace X10D.Performant.ReExposed
{
    /// <summary>
    ///     Extension methods for <see cref="Color" />.
    /// </summary>
    public static partial class Int32Extensions
    {
        /// <inheritdoc cref="Color.FromArgb(int)" />
        public static Color ToColor(this int value) => Color.FromArgb(value);
    }
}