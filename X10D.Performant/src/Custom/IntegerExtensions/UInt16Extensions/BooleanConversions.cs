using X10D.Performant.UInt64Extensions;

namespace X10D.Performant.UInt16Extensions
{
    public static partial class UInt16Extensions
    {
        /// <inheritdoc cref="UInt64Extensions.IsEven"/>
        public static bool IsEven(this ushort value) => (value & 1) == 0;

        /// <inheritdoc cref="UInt64Extensions.IsOdd"/>
        public static bool IsOdd(this ushort value) => (value & 1) != 0;

        /// <inheritdoc cref="UInt64Extensions.ToBoolean"/>
        public static bool ToBoolean(this ushort value) => value != 0;
    }
}