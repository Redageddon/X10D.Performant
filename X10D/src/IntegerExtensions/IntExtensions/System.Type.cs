using System;

namespace X10D.Performant.IntExtensions
{
    public static partial class IntExtensions
    {
        /// <inheritdoc cref="Type.MakeGenericMethodParameter(int)"/>
        public static Type MakeGenericMethodParameter(this int value) => Type.MakeGenericMethodParameter(value);
    }
}