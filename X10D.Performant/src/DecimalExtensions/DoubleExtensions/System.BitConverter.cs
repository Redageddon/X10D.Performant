using System;

namespace X10D.Performant
{
    public static partial class DoubleExtensions
    {
        /// <summary>
        ///     Converts the <paramref name="value"/> to a <see cref="T:byte[]"/>.
        /// </summary>
        /// <param name="value">The number to convert.</param>
        /// <returns>A <see cref="byte"/>[].</returns>
        public static byte[] GetBytes(this double value) => BitConverter.GetBytes(value);
    }
}