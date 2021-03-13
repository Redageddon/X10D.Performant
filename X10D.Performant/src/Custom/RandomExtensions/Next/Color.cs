using System;
using System.Drawing;
using X10D.Performant.DoubleExtensions;

namespace X10D.Performant.RandomExtensions
{
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Creates a new random <see cref="Color"/> with the supplied hsv values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance that determines the randomness of the color.</param>
        /// <param name="minAlpha">The lowest alpha value to randomize.</param>
        /// <param name="maxAlpha">The highest alpha value to randomize.</param>
        /// <param name="minHue">The lowest hue value to randomize.</param>
        /// <param name="maxHue">The highest hue value to randomize.</param>
        /// <param name="minSaturation">The lowest saturation value to randomize.</param>
        /// <param name="maxSaturation">The highest saturation value to randomize.</param>
        /// <param name="minBrightness">The lowest brightness value to randomize.</param>
        /// <param name="maxBrightness">The highest brightness value to randomize.</param>
        /// <returns>A new <see cref="Color"/> with the supplied ahsb values.</returns>
        public static Color NextColorAhsb(this Random random,
                                          byte minAlpha = byte.MinValue,
                                          byte maxAlpha = byte.MaxValue,
                                          float minHue = 0,
                                          float maxHue = 1,
                                          float minSaturation = 0,
                                          float maxSaturation = 1,
                                          float minBrightness = 0,
                                          float maxBrightness = 1)
        {
            byte a = (byte)random.Next(minAlpha, maxAlpha);
            float h = (float)random.NextDouble().Lerp(minHue, maxHue);
            float s = (float)random.NextDouble().Lerp(minSaturation, maxSaturation);
            float b = (float)random.NextDouble().Lerp(minBrightness, maxBrightness);

            return ColorExtensions.ColorExtensions.ColorFromAhsb(a, h, s, b);
        }

        /// <summary>
        ///     Creates a new random <see cref="Color"/> with the supplied hsv values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance that determines the randomness of the color.</param>
        /// <param name="minAlpha">The lowest alpha value to randomize.</param>
        /// <param name="maxAlpha">The highest alpha value to randomize.</param>
        /// <param name="minRed">The lowest red value to randomize.</param>
        /// <param name="maxRed">The highest red value to randomize.</param>
        /// <param name="minGreen">The lowest green value to randomize.</param>
        /// <param name="maxGreen">The highest green value to randomize.</param>
        /// <param name="minBlue">The lowest blue value to randomize.</param>
        /// <param name="maxBlue">The highest blue value to randomize.</param>
        /// <returns>A new <see cref="Color"/> with the supplied argb values.</returns>
        public static Color NextColorArgb(this Random random,
                                          byte minAlpha = byte.MinValue,
                                          byte maxAlpha = byte.MaxValue,
                                          byte minRed = byte.MinValue,
                                          byte maxRed = byte.MaxValue,
                                          byte minGreen = byte.MinValue,
                                          byte maxGreen = byte.MaxValue,
                                          byte minBlue = byte.MinValue,
                                          byte maxBlue = byte.MaxValue) =>
            Color.FromArgb((random.Next(minAlpha, maxAlpha) << 24)
                         | (random.Next(minRed, maxRed) << 16)
                         | (random.Next(minGreen, maxGreen) << 8)
                         | random.Next(minBlue, maxBlue));
    }
}