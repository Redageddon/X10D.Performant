using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
public static partial class StringExtensions
{
    /// <inheritdoc cref="byte.Parse(string,NumberStyles,IFormatProvider)"/>
    public static byte ToByte(this string value, NumberStyles style = NumberStyles.Integer, IFormatProvider? formatProvider = null) =>
        byte.Parse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

    /// <inheritdoc cref="byte.TryParse(string,NumberStyles,IFormatProvider,out byte)"/>
    public static bool TryToByte(this string value,
                                 out byte result,
                                 NumberStyles style = NumberStyles.Integer,
                                 IFormatProvider? formatProvider = null) =>
        byte.TryParse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
}