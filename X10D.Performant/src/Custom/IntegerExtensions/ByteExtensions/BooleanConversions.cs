using X10D.Performant.Int64Extensions;

namespace X10D.Performant.ByteExtensions
{
    public static partial class ByteExtensions
    {
        /// <inheritdoc cref="Int64Extensions.IsEven"/>
        public static bool IsEven(this byte value) => (value & 1) == 0;

        /// <inheritdoc cref="Int64Extensions.IsOdd"/>
        public static bool IsOdd(this byte value) => (value & 1) != 0;

        /// <inheritdoc cref="Int64Extensions.ToBoolean"/>
        public static bool ToBoolean(this byte value) => value != 0;
    }
}