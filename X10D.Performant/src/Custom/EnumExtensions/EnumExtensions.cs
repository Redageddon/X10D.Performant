﻿using System;

namespace X10D.Performant.EnumExtensions
{
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

            int wrapIndex = wrap
                ? 0
                : i - 1;

            return values.Length == i
                ? values[wrapIndex]
                : values[i];
        }

        /// <include file='EnumExtensions.xml' path='members/member[@name="PreviousEnumDeclaration"]'/>
        public static TEnum PreviousEnumDeclaration<TEnum>(this TEnum value, bool wrap = true)
            where TEnum : struct, Enum
        {
            TEnum[] values = EnumMap<TEnum>.Map;
            int i = Array.IndexOf(values, value) - 1;

            int wrapIndex = wrap
                ? values.Length - 1
                : 0;

            return i < 0
                ? values[wrapIndex]
                : values[i];
        }

        internal static class EnumMap<TEnum>
            where TEnum : struct, Enum
        {
            public static TEnum[] Map { get; } = Enum.GetValues<TEnum>();
        }
    }
}