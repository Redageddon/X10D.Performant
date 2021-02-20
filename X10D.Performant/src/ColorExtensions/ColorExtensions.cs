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
        /// <param name="hue">The new hue.</param>
        /// <param name="saturation">The new saturation.</param>
        /// <param name="brightness">The new brightness.</param>
        /// <returns>A new <see cref="Color"/> with any of the supplied hsb values overridden.</returns>
        public static Color With(this Color color, byte? alpha = null, float? hue = null, float? saturation = null, float? brightness = null)
        {
            hue ??= color.GetHue();
            saturation ??= color.GetSaturation();
            brightness ??= color.GetBrightness();
            alpha ??= color.A;

            //Todo: convert hsb to color
            return Color.Transparent;
        }
    }
}