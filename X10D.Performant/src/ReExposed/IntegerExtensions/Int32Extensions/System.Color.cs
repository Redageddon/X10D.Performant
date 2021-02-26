using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace X10D.Performant.ReExposed
{
    /// <summary>
    ///     Extension methods for <see cref="Color"/>.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class Int32Extensions
    {
        /// <inheritdoc cref="Color.FromArgb(int)"/>
        public static Color ToColor(this int value) => Color.FromArgb(value);
    }
}