using System;

namespace X10D.Performant.CharExtensions
{
    public static partial class CharExtensions
    {
        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.GetBytes"/>
        public static byte[] GetBytes(this char value) => BitConverter.GetBytes(value);
    }
}