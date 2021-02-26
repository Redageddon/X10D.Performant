using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static partial class TypeExtensions
    {
        /// <inheritdoc cref="Array.CreateInstance(Type,int)"/>
        public static Array CreateArray(this Type arrayType, int length1d) => Array.CreateInstance(arrayType, length1d);

        /// <inheritdoc cref="Array.CreateInstance(Type,int,int)"/>
        public static Array CreateArray(this Type arrayType, int length1d, int length2d) => Array.CreateInstance(arrayType, length1d, length2d);

        /// <inheritdoc cref="Array.CreateInstance(Type,int,int,int)"/>
        public static Array CreateArray(this Type arrayType, int length1d, int length2d, int length3d) =>
            Array.CreateInstance(arrayType, length1d, length2d, length3d);

        /// <inheritdoc cref="Array.CreateInstance(Type,int[],int[])"/>
        public static Array CreateArray(this Type arrayType, int[] lengths, int[] lowerBounds) =>
            Array.CreateInstance(arrayType, lengths, lowerBounds);

        /// <inheritdoc cref="Array.CreateInstance(Type,int[])"/>
        public static Array CreateArray(this Type arrayType, params int[] lengths) => Array.CreateInstance(arrayType, lengths);

        /// <inheritdoc cref="Array.CreateInstance(Type,long[])"/>
        public static Array CreateArray(this Type arrayType, params long[] lengths) => Array.CreateInstance(arrayType, lengths);
    }
}