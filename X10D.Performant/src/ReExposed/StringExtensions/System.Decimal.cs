﻿namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
public static partial class StringExtensions
{
    /// <inheritdoc cref="decimal.Parse(string,NumberStyles,IFormatProvider)"/>
    public static decimal ToDecimal(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? provider = null) =>
        decimal.Parse(value, style, provider ?? NumberFormatInfo.CurrentInfo);

    /// <inheritdoc cref="decimal.TryParse(string,NumberStyles,IFormatProvider,out decimal)"/>
    public static bool TryToDecimal(this string value,
                                    out decimal result,
                                    NumberStyles style = NumberStyles.Number,
                                    IFormatProvider? formatProvider = null) =>
        decimal.TryParse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
}