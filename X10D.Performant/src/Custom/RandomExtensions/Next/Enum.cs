using System;

namespace X10D.Performant.RandomExtensions
{
    public static partial class RandomExtensions
    {
        /// <include file='../RandomExtensions.xml' path='members/member[@name="NextEnum"]'/>
        public static TEnum NextEnum<TEnum>(this Random random)
            where TEnum : struct, Enum
        {
            TEnum[] values = EnumExtensions.EnumExtensions.EnumMap<TEnum>.Map;

            return values[random.Next(values.Length)];
        }
    }
}