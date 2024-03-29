﻿namespace X10D.Performant.ReExposed;

[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
public static partial class StringExtensions
{
    /// <inheritdoc cref="float.Parse(string,NumberStyles,IFormatProvider)"/>
    public static float ToSingle(this string value, NumberStyles style = NumberStyles.Number, IFormatProvider? formatProvider = null) =>
        float.Parse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo);

    /// <inheritdoc cref="float.TryParse(string,NumberStyles,IFormatProvider,out float)"/>
    public static bool TryToSingle(this string value,
                                   out float result,
                                   NumberStyles style = NumberStyles.Number,
                                   IFormatProvider? formatProvider = null) =>
        float.TryParse(value, style, formatProvider ?? NumberFormatInfo.CurrentInfo, out result);
}