using X10D.Performant.Int64Extensions;

namespace X10D.Performant.SByteExtensions
{
    public static partial class SByteExtensions
    {
        /// <inheritdoc cref="Int64Extensions.IsEven"/>
        public static bool IsEven(this sbyte value) => (value & 1) == 0;

        /// <inheritdoc cref="Int64Extensions.IsOdd"/>
        public static bool IsOdd(this sbyte value) => (value & 1) == 1;

        /// <inheritdoc cref="Int64Extensions.ToBoolean"/>
        public static bool ToBoolean(this sbyte value) => value != 0;
    }
}