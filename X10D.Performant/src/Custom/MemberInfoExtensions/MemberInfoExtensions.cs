using System;
using System.ComponentModel;
using System.Reflection;

namespace X10D.Performant.MemberInfoExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="MemberInfo"/>.
    /// </summary>
    public static class MemberInfoExtensions
    {
        /// <include file='MemberInfoExtensions.xml' path='members/member[@name="GetDefaultValue"]'/>
        public static object? GetDefaultValue(this MemberInfo member) => member.GetDefaultValue<object>();

        /// <include file='MemberInfoExtensions.xml' path='members/member[@name="GetDefaultValueGeneric"]'/>
        public static T? GetDefaultValue<T>(this MemberInfo member)
        {
            DefaultValueAttribute? customAttribute = member.GetCustomAttribute<DefaultValueAttribute>();

            object? obj = customAttribute?.Value;

            return obj != null
                ? (T)obj
                : default;
        }

        /// <include file='MemberInfoExtensions.xml' path='members/member[@name="GetDescription"]'/>
        public static string GetDescription(this MemberInfo member)
        {
            DescriptionAttribute? customAttribute = member.GetCustomAttribute<DescriptionAttribute>();

            return customAttribute?.Description ?? string.Empty;
        }

        /// <include file='MemberInfoExtensions.xml' path='members/member[@name="SelectFromCustomAttribute"]'/>
        public static TReturn? SelectFromCustomAttribute<TAttribute, TReturn>(this MemberInfo member,
                                                                              Func<TAttribute, TReturn> selector)
            where TAttribute : Attribute
        {
            TAttribute? customAttribute = member.GetCustomAttribute<TAttribute>();

            return customAttribute == null
                ? default
                : selector(customAttribute);
        }
    }
}