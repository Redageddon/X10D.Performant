using System;

namespace X10D.Performant
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.GetBytes"/>
        public static byte[] GetBytes(this char value) => BitConverter.GetBytes(value);
    }
}