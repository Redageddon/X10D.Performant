using System;

namespace X10D.Performant
{
    public static partial class Int32Extensions
    {
        /// <inheritdoc cref="Type.MakeGenericMethodParameter(int)"/>
        public static Type MakeGenericMethodParameter(this int value) => Type.MakeGenericMethodParameter(value);
    }
}