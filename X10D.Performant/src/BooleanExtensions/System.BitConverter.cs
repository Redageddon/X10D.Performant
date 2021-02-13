using System;

namespace X10D.Performant.BooleanExtensions
{
    public static partial class BooleanExtensions
    {
        /// <inheritdoc cref="X10D.Performant.DoubleExtensions.DoubleExtensions.GetBytes"/>
        public static byte[] GetBytes(this bool value) => BitConverter.GetBytes(value);
    }
}