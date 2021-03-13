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
        /// <summary>
        ///     Gets the value set in this <see cref="MemberInfo"/>'s annotated <see cref="DefaultValueAttribute"/>, or <see langword="default"/> if none
        ///     exists.
        /// </summary>
        /// <param name="member">A <see cref="MemberInfo"/>.</param>
        /// <returns>
        ///     Returns an <see cref="object"/> representing the value stored in this <see cref="MemberInfo"/>'s <see cref="DefaultValueAttribute"/>.
        /// </returns>
        public static object? GetDefaultValue(this MemberInfo member) => member.GetDefaultValue<object>();

        /// <summary>
        ///     Gets the value set in this <see cref="MemberInfo"/>'s annotated <see cref="DefaultValueAttribute"/>, or <see langword="default"/> if none
        ///     exists.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <typeparam name="T">The type to which the value should cast.</typeparam>
        /// <returns>
        ///     Returns an instance of <typeparamref name="T"/> representing the value stored in this member's <see cref="DefaultValueAttribute"/>.
        /// </returns>
        public static T? GetDefaultValue<T>(this MemberInfo member)
        {
            DefaultValueAttribute? customAttribute = member.GetCustomAttribute<DefaultValueAttribute>();

            object? obj = customAttribute?.Value;

            return obj != null
                ? (T)obj
                : default;
        }

        /// <summary>
        ///     Gets the value set in this <see cref="MemberInfo"/>'s annotated <see cref="DescriptionAttribute"/>.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns>
        ///     Returns a <see cref="string"/> representing the value stored in this member's <see cref="DescriptionAttribute"/>.
        /// </returns>
        public static string GetDescription(this MemberInfo member)
        {
            DescriptionAttribute? customAttribute = member.GetCustomAttribute<DescriptionAttribute>();

            return customAttribute?.Description ?? string.Empty;
        }

        /// <summary>
        ///     Retrieves a custom attribute of a specified type that is applied to the specified member, and passes it to a selector delegate in
        ///     order to select one or more the members in the attribute.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <param name="selector">The selector delegate.</param>
        /// <typeparam name="TAttribute">The attribute type.</typeparam>
        /// <typeparam name="TReturn">The return type of the <paramref name="selector"/> delegate.</typeparam>
        /// <returns>
        ///     Returns an instance of <typeparamref name="TReturn"/> as provided from <paramref name="selector"/>.
        /// </returns>
        public static TReturn? SelectFromCustomAttribute<TAttribute, TReturn>(this MemberInfo member,
                                                                              Func<TAttribute, TReturn> selector)
            where TAttribute : Attribute
        {
            TAttribute? customAttribute = member.GetCustomAttribute<TAttribute>();

            return (object?)customAttribute == null
                ? default
                : selector(customAttribute);
        }
    }
}