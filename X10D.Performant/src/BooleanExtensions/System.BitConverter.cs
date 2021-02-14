using System;

namespace X10D.Performant
{
    public static partial class BooleanExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.GetBytes" />
        public static byte[] GetBytes(this bool value) => BitConverter.GetBytes(value);
    }
}