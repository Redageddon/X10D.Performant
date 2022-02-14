using System;

namespace X10D.Performant.TypeExtensions;

/// <summary>
///     Extension methods for <see cref="Type"/>.
/// </summary>
public static class TypeExtensions
{
    /// <include file='TypeExtensions.xml' path='members/member[@name="GetContainedType"]'/>
    public static Type? GetContainedType(this Type collectionType) =>
        collectionType.IsGenericType
            ? collectionType.GetGenericArguments()[0]
            : collectionType.GetElementType();
}