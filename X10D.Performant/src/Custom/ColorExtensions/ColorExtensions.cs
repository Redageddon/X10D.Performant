using System;
using System.Drawing;
#pragma warning disable 8629

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="Color"/>.
    /// </summary>
    public static class ColorExtensions
    {
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
                           | ((blue ?? color.B) << 0));

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
            
            float c = (1 - Math.Abs((2 * (float)brightness) - 1)) * (float)saturation;
            float x = c * (1 - Math.Abs(((float)hue / 60 % 2) - 1));
            float m = (float)brightness - (c / 2);

            
            (double r, double g, double b) prime = (hue % 360.0) switch
            {
                < 60   => (c, x, 0),
                < 120  => (x, c, 0),
                < 180  => (0, c, x),
                < 240  => (0, x, c),
                < 300  => (x, 0, c),
                _      => (c, 0, x),
            };

            byte r = (byte)((prime.r + m) * 255);
            byte g = (byte)((prime.g + m) * 255);
            byte b = (byte)((prime.b + m) * 255);

            return Color.FromArgb((byte)alpha,r, g, b);
        }
    }
}