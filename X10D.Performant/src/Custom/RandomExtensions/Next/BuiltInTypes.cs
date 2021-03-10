using System;

namespace X10D.Performant
{
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Returns either <see langword="true"/> or <see langword="false"/> based on <paramref name="random"/>'s next generation.
        /// </summary>
        /// <param name="random">The <see cref="Random"/> instance.</param>
        /// <returns>
        ///     <see langword="true"/> if <see cref="System.Random.NextDouble()"/> is greater than or equal to 0.5, else <see langword="false"/>.
        /// </returns>
        public static bool NextBoolean(this Random random) => random.NextDouble() >= 0.5;

        /// <summary>
        ///     Returns a random <see cref="byte"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. This value must be greater than or equal to 0.</param>
        /// <returns>A random <see cref="byte"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static byte NextByte(this Random random, byte maxValue = byte.MaxValue) => (byte)(maxValue * random.NextDouble());

        /// <summary>
        ///     Returns a random <see cref="byte"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="byte"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static byte NextByte(this Random random, byte minValue, byte maxValue) =>
            (byte)(((maxValue - minValue) * random.NextDouble()) + minValue);

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
        ///     Returns a random <see cref="double"/> that is within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number returned. This value must be greater than or equal to 0.
        /// </param>
        /// <returns>A random <see cref="double"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static double NextDouble(this Random random, double maxValue) => maxValue * random.NextDouble();

        /// <summary>
        ///     Returns a random <see cref="double"/> that is within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="double"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static double NextDouble(this Random random, double minValue, double maxValue) =>
            ((maxValue - minValue) * random.NextDouble()) + minValue;

        /// <summary>
        ///     Returns a random <see cref="short"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. This value must be greater than or equal to 0.</param>
        /// <returns>A random <see cref="short"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static short NextInt16(this Random random, short maxValue = short.MaxValue) => (short)(maxValue * random.NextDouble());

        /// <summary>
        ///     Returns a random <see cref="short"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="short"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static short NextInt16(this Random random, short minValue, short maxValue) =>
            (short)(((maxValue - minValue) * random.NextDouble()) + minValue);

        /// <summary>
        ///     Returns a random <see cref="long"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. This value must be greater than or equal to 0.</param>
        /// <returns>A random <see cref="long"/> between 0 and <paramref name="maxValue"/>.</returns>
        // TODO: remove decimal usage and ensure only 1 random.Next is called
        public static long NextInt64(this Random random, long maxValue = long.MaxValue)
        {
            // Introduces a larger range of distribution but all values are still included so random.NextDecimal() is safe to use here.
            decimal value = (decimal)random.Next() / long.MaxValue;

            return (long)(maxValue * value);
        }

        /// <summary>
        ///     Returns a random <see cref="long"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="long"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        // TODO: remove decimal usage and ensure only 1 random.Next is called
        public static long NextInt64(this Random random, long minValue, long maxValue)
        {
            // Introduces a larger range of distribution but all values are still included so random.NextDecimal() is safe to use here.
            decimal value = (decimal)random.Next() / long.MaxValue;

            return (long)((maxValue * value) - (minValue * value) + minValue);
        }

        /// <summary>
        ///     Returns a random <see cref="sbyte"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. This value must be greater than or equal to 0.</param>
        /// <returns>A random <see cref="sbyte"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static sbyte NextSByte(this Random random, sbyte maxValue = sbyte.MaxValue) => (sbyte)(maxValue * random.NextDouble());

        /// <summary>
        ///     Returns a random <see cref="sbyte"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="sbyte"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static sbyte NextSByte(this Random random, sbyte minValue, sbyte maxValue) =>
            (sbyte)(((maxValue - minValue) * random.NextDouble()) + minValue);

        /// <summary>
        ///     Returns a random <see cref="float"/> between 0 and <paramref name="maxValue"/>.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number returned. This value must be greater than or equal to 0.
        /// </param>
        /// <returns>A random <see cref="float"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static float NextSingle(this Random random, float maxValue = 1F) => maxValue * (float)random.NextDouble();

        /// <summary>
        ///     Returns a random <see cref="float"/> that is within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="float"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static float NextSingle(this Random random, float minValue, float maxValue) =>
            ((maxValue - minValue) * (float)random.NextDouble()) + minValue;

        /// <summary>
        ///     Returns a random <see cref="ushort"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. This value must be greater than or equal to 0.</param>
        /// <returns>A random <see cref="ushort"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static ushort NextUInt16(this Random random, ushort maxValue = ushort.MaxValue) => (ushort)(random.NextDouble() * maxValue);

        /// <summary>
        ///     Returns a random <see cref="ushort"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="ushort"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static ushort NextUInt16(this Random random, ushort minValue, ushort maxValue) =>
            (ushort)(((maxValue - minValue) * random.NextDouble()) + minValue);

        /// <summary>
        ///     Returns a random <see cref="uint"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. This value must be greater than or equal to 0.</param>
        /// <returns>A random <see cref="uint"/> between 0 and <paramref name="maxValue"/>.</returns>
        public static uint NextUInt32(this Random random, uint maxValue = uint.MaxValue) => (uint)(maxValue * random.NextDouble());

        /// <summary>
        ///     Returns a random <see cref="uint"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="uint"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        public static uint NextUInt32(this Random random, uint minValue, uint maxValue) =>
            (uint)(((maxValue - minValue) * random.NextDouble()) + minValue);

        /// <summary>
        ///     Returns a random <see cref="ulong"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. This value must be greater than or equal to 0.</param>
        /// <returns>A random <see cref="ulong"/> between 0 and <paramref name="maxValue"/>.</returns>
        // TODO: remove decimal usage and ensure only 1 random.Next is called
        public static ulong NextUInt64(this Random random, ulong maxValue = ulong.MaxValue)
        {
            // Introduces a larger range of distribution but all values are still included so random.NextDecimal() is safe to use here.
            decimal value = (decimal)random.Next() / ulong.MaxValue;

            return (ulong)(maxValue * value);
        }

        /// <summary>
        ///     Returns a random <see cref="ulong"/> within a specified range.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">
        ///     The exclusive upper bound of the random number returned. This value must be greater than or equal to <paramref name="minValue"/>.
        /// </param>
        /// <returns>A random <see cref="ulong"/> between <paramref name="minValue"/> and <paramref name="maxValue"/>.</returns>
        // TODO: remove decimal usage and ensure only 1 random.Next is called
        public static ulong NextUInt64(this Random random, ulong minValue, ulong maxValue)
        {
            // Introduces a larger range of distribution but all values are still included so random.NextDecimal() is safe to use here.
            decimal value = (decimal)random.Next() / ulong.MaxValue;

            return (ulong)(((maxValue - minValue) * value) + minValue);
        }
    }
}