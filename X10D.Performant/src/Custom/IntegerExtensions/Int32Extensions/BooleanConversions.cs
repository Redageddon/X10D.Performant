using X10D.Performant.Int64Extensions;

namespace X10D.Performant.Int32Extensions
{
    public static partial class Int32Extensions
    {
        /// <inheritdoc cref="Int64Extensions.IsEven"/>
        public static bool IsEven(this int value) => (value & 1) == 0;

        /// <inheritdoc cref="Int64Extensions.IsOdd"/>
        public static bool IsOdd(this int value) => (value & 1) == 1;

        /// <inheritdoc cref="Int64Extensions.ToBoolean"/>
        public static bool ToBoolean(this int value) => value != 0;
    }
}