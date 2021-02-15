using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class BooleanExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.GetBytes"/>
        public static byte[] GetBytes(this bool value) => BitConverter.GetBytes(value);
    }
}