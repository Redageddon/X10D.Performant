using System;
using X10D.Performant.BooleanExtensions;

namespace X10D.Performant.EnumExtensions;

/// <summary>
///     Extension methods for <see cref="Enum"/> types.
/// </summary>
public static class EnumExtensions
{
    /// <include file='EnumExtensions.xml' path='members/member[@name="NextEnumDeclaration"]'/>
    public static TEnum NextEnumDeclaration<TEnum>(this TEnum value, bool wrap = true)
        where TEnum : struct, Enum
    {
        TEnum[] values = EnumMap<TEnum>.Map;
        int i = Array.IndexOf(values, value) + 1;

        int index = values.Length == i
            ? (!wrap).ToByte() * (i - 1)
            : i;

        return values[index];
    }

    /// <include file='EnumExtensions.xml' path='members/member[@name="PreviousEnumDeclaration"]'/>
    public static TEnum PreviousEnumDeclaration<TEnum>(this TEnum value, bool wrap = true)
        where TEnum : struct, Enum
    {
        TEnum[] values = EnumMap<TEnum>.Map;
        int location = Array.IndexOf(values, value);

        int index = location == 0
            ? wrap.ToByte() * (values.Length - 1)
            : location - 1;

        return values[index];
    }

    internal static class EnumMap<TEnum>
        where TEnum : struct, Enum
    {
        public static readonly TEnum[] Map = Enum.GetValues<TEnum>();
    }
}