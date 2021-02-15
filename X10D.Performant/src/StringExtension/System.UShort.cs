using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="ushort.Parse(string,NumberStyles,IFormatProvider)"/>
        [CLSCompliant(false)]
        public static ushort ToUInt16(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? formatProvider = null) =>
            ushort.Parse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

        /// <inheritdoc cref="ushort.TryParse(string,NumberStyles,IFormatProvider,out ushort)"/>
        [CLSCompliant(false)]
        public static bool TryToUInt16(
            this string value,
            out ushort result,
            NumberStyles style = NumberStyles.Number,
            IFormatProvider? formatProvider = null) =>
            ushort.TryParse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
    }
}