using System;
using System.Drawing;

namespace X10D.Performant
{
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Returns a random value that defined in a specified enum.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <typeparam name="TEnum">An enumeration type.</typeparam>
        /// <returns>
        ///     Returns a random enum value from <typeparamref name="TEnum"/> specified by <paramref name="random"/>.
        /// </returns>
        public static TEnum NextEnum<TEnum>(this Random random)
            where TEnum : struct, Enum
        {
            TEnum[] values = EnumExtensions.EnumMap<TEnum>.Map;

            return values[random.Next(values.Length)];
        }

        /// <summary>
        ///     Returns either <see langword="true"/> or <see langword="false"/> based on <paramref name="random"/>'s next generation.
        /// </summary>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <returns>
        ///     <see langword="true"/> if <see cref="System.Random.NextDouble()"/> is greater than or equal to 0.5 else <see langword="false"/>.
        /// </returns>
        public static bool NextBoolean(this Random random) => random.NextDouble() >= 0.5;

        /// <summary>
        ///     Returns a random <see cref="byte"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The inclusive upper bound of the random number returned. This value must be greater than or equal to 0.</param>
        /// <returns>A random <see cref="byte"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static byte NextByte(this Random random, byte maxValue = byte.MaxValue) => (byte)random.Next(maxValue);

        /// <summary>
        ///     Returns a random <see cref="byte"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The inclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="byte"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static byte NextByte(this Random random, byte minValue, byte maxValue) => (byte)random.Next(minValue, maxValue);

        /// <summary>
        ///     Returns a random <see cref="char"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random <see cref="char"/> returned.</param>
        /// <param name="maxValue">
        ///     The inclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="char"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        /// <remarks>Although the input is a <see cref="char"/> it is treated as an int, which is something that should be kept in mind.</remarks>
        public static char NextChar(this Random random, char minValue = 'a', char maxValue = 'z') => (char)random.Next(minValue, maxValue + 1);

        /// <summary>
        ///     Creates a new random color with the supplied hsv values.
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
        /// <returns>A new random color with the supplied ahsv values.</returns>
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

            return ColorExtensions.ColorFromAhsb(a, h, s, b);
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
        /// <returns>A new random color with the supplied argb values.</returns>
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

        /// <summary>
        ///     Returns a random <see cref="double"/> that is within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">
        ///     The inclusive upper bound of the random number returned. This value must be greater than or equal to 0.
        /// </param>
        /// <returns>A random <see cref="double"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static double NextDouble(this Random random, double maxValue) => maxValue * random.NextDouble();

        /// <summary>
        ///     Returns a random <see cref="double"/> that is within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The inclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="double"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static double NextDouble(this Random random, double minValue, double maxValue) =>
            ((maxValue - minValue) * random.NextDouble()) + minValue;

        /// <summary>
        ///     Returns a random <see cref="sbyte"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The inclusive upper bound of the random number returned. This value must be greater than or equal to 0.</param>
        /// <returns>A random <see cref="sbyte"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static sbyte NextSByte(this Random random, sbyte maxValue = sbyte.MaxValue) => (sbyte)random.Next(maxValue);

        /// <summary>
        ///     Returns a random <see cref="sbyte"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The inclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="sbyte"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static sbyte NextSByte(this Random random, sbyte minValue, sbyte maxValue) => (sbyte)random.Next(minValue, maxValue);

        /// <summary>
        ///     Returns a random <see cref="short"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The inclusive upper bound of the random number returned. This value must be greater than or equal to 0.</param>
        /// <returns>A random <see cref="short"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static short NextShort(this Random random, short maxValue = short.MaxValue) => (short)random.Next(maxValue);

        /// <summary>
        ///     Returns a random <see cref="short"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The inclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="short"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static short NextShort(this Random random, short minValue, short maxValue) => (short)random.Next(minValue, maxValue);

        /// <summary>
        ///     Returns a random <see cref="float"/> between 0 and 1.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">
        ///     The inclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="0"/>.
        /// </param>
        /// <returns>A random <see cref="float"/> between 0 and <see cref="maxValue"/>.</returns>
        public static float NextSingle(this Random random, float maxValue = 1F) => maxValue * (float)random.NextDouble();

        /// <summary>
        ///     Returns a random <see cref="float"/> that is within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The inclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="float"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static float NextSingle(this Random random, float minValue, float maxValue) =>
            ((maxValue - minValue) * (float)random.NextDouble()) + minValue;

        /// <summary>
        ///     Returns a random <see cref="uint"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The inclusive upper bound of the random number returned. This value must be greater than or equal to 0.</param>
        /// <returns>A random <see cref="uint"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static uint NextUInt(this Random random, uint maxValue = uint.MaxValue) => (uint)(maxValue * random.NextDouble());

        /// <summary>
        ///     Returns a random <see cref="uint"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The inclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="uint"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static uint NextUInt(this Random random, byte minValue, byte maxValue) =>
            (uint)(((maxValue - minValue) * random.NextDouble()) + minValue);

        /// <summary>
        ///     Returns a random <see cref="ushort"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The inclusive upper bound of the random number returned. This value must be greater than or equal to 0.</param>
        /// <returns>A random <see cref="ushort"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static ushort NextUShort(this Random random, ushort maxValue = ushort.MaxValue) => (ushort)random.Next(maxValue);

        /// <summary>
        ///     Returns a random <see cref="ushort"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The inclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="ushort"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static ushort NextUShort(this Random random, ushort minValue, ushort maxValue) => (ushort)random.Next(minValue, maxValue);
    }
}