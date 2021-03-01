using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

#pragma warning disable 8629

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="Color"/>.
    /// </summary>
    public static class ColorExtensions
    {
        [SuppressMessage("ReSharper", "IdentifierTypo")]
        internal static Color ColorFromAhsb(byte alpha, float hue, float saturation, float brightness)
        {
            float c = (1 - Math.Abs((2 * brightness) - 1)) * saturation;
            float x = c * (1 - Math.Abs((hue / 60 % 2) - 1));
            float m = brightness - (c / 2);

            (float red, float green, float blue) = (hue % 360.0f) switch
            {
                < 60  => (c + m, x + m, m),
                < 120 => (x + m, c + m, m),
                < 180 => (m, c + m, x + m),
                < 240 => (m, x + m, c + m),
                < 300 => (x + m, m, c + m),
                _     => (c + m, m, x + m),
            };

            int r = (int)(red * byte.MaxValue);
            int g = (int)(green * byte.MaxValue);
            int b = (int)(blue * byte.MaxValue);

            return Color.FromArgb((alpha << 24) | (r << 16) | (g << 8) | b);
        }

        /// <summary>
        ///     Changes any of the rgb values from a <see cref="Color"/>.
        /// </summary>
        /// <param name="color">The initial <see cref="Color"/>.</param>
        /// <param name="alpha">The new alpha.</param>
        /// <param name="red">The new red.</param>
        /// <param name="green">The new green.</param>
        /// <param name="blue">The new blue.</param>
        /// <returns>A new <see cref="Color"/> with any of the supplied rgb values overridden.</returns>
        public static Color With(this Color color, byte? alpha = null, byte? red = null, byte? green = null, byte? blue = null) =>
            Color.FromArgb(((alpha ?? color.A) << 24)
                         | ((red ?? color.R) << 16)
                         | ((green ?? color.G) << 8)
                         | (blue ?? color.B));

        /// <summary>
        ///     Changes any of the hsb values from a <see cref="Color"/>.
        /// </summary>
        /// <param name="color">The initial <see cref="Color"/>.</param>
        /// <param name="alpha">The new alpha.</param>
        /// <param name="hue">The new hue within the range of 0 - 360.</param>
        /// <param name="saturation">The new saturation within the range of 0.0 - 1.0.</param>
        /// <param name="brightness">The new brightness within the range of 0.0 - 1.0.</param>
        /// <returns>A new <see cref="Color"/> with any of the supplied hsb values overridden.</returns>
        public static Color With(this Color color, byte? alpha = null, float? hue = null, float? saturation = null, float? brightness = null)
        {
            hue ??= color.GetHue();
            saturation ??= color.GetSaturation();
            brightness ??= color.GetBrightness();
            alpha ??= color.A;

            return ColorFromAhsb((byte)alpha, (float)hue, (float)saturation, (float)brightness);
        }
    }
}