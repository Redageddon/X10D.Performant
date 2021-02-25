using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="uint.Parse(string,NumberStyles,IFormatProvider)" />
        [CLSCompliant(false)]
        public static uint ToUInt32(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? formatProvider = null) =>
            uint.Parse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="uint.TryParse(string,NumberStyles,IFormatProvider,out uint)" />
        [CLSCompliant(false)]
        public static bool TryToUInt32(
            this string value,
            out uint result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? formatProvider = null) =>
            uint.TryParse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}