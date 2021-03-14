using X10D.Performant.UInt64Extensions;

namespace X10D.Performant.UInt32Extensions
{
    public static partial class UInt32Extensions
    {
        /// <inheritdoc cref="UInt64Extensions.IsEven"/>
        public static bool IsEven(this uint value) => (value & 1) == 0;

        /// <inheritdoc cref="UInt64Extensions.IsOdd"/>
        public static bool IsOdd(this uint value) => (value & 1) == 1;

        /// <inheritdoc cref="UInt64Extensions.ToBoolean"/>
        public static bool ToBoolean(this uint value) => value != 0;
    }
}