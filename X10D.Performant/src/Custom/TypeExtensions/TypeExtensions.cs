﻿using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="Type"/>.
    /// </summary>
    public static partial class TypeExtensions
    {
        /// <summary>
        ///     Gets the <see cref="Type"/> contained within this <see cref="Type"/>.
        /// </summary>
        /// <param name="collectionType">The <see cref="Type"/> being checked.</param>
        /// <returns>
        ///     The contained <see cref="Type"/>.
        ///     EX: <see cref="T:List{int}"/> or <see cref="T:int[]"/> will return int.
        /// </returns>
        public static Type? GetContainedType(this Type collectionType) =>
            collectionType.IsGenericType
                ? collectionType.GetGenericArguments()[0]
                : collectionType.GetElementType();
    }
}