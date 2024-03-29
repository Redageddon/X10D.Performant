﻿namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
public static partial class StringExtensions
{
    /// <inheritdoc cref="int.Parse(string,NumberStyles,IFormatProvider)"/>
    public static int ToInt32(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? formatProvider = null) =>
        int.Parse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

    /// <inheritdoc cref="int.TryParse(string,NumberStyles,IFormatProvider,out int)"/>
    public static bool TryToInt32(this string value,
                                  out int result,
                                  NumberStyles style = NumberStyles.Number,
                                  IFormatProvider? formatProvider = null) =>
        int.TryParse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
}