using X10D.Performant.Int64Extensions;

namespace X10D.Performant.Int16Extensions
{
    public static partial class Int16Extensions
    {
        /// <inheritdoc cref="Int64Extensions.IsEven"/>
        public static bool IsEven(this short value) => (value & 1) == 0;

        /// <inheritdoc cref="Int64Extensions.IsOdd"/>
        public static bool IsOdd(this short value) => (value & 1) == 1;

        /// <inheritdoc cref="Int64Extensions.ToBoolean"/>
        public static bool ToBoolean(this short value) => value != 0;
    }
}