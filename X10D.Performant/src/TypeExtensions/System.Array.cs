using System;

namespace X10D.Performant.TypeExtensions
{
    public static partial class ReflectionExtensions
    {
        /// <inheritdoc cref="Array.CreateInstance(Type,int)"/>
        public static Array CreateArray(this Type arrayType, int length) => Array.CreateInstance(arrayType, length);
        
        /// <inheritdoc cref="Array.CreateInstance(Type,int,int)"/>
        public static Array CreateArray(this Type arrayType, int length, int length2) => Array.CreateInstance(arrayType, length, length2);
        
        /// <inheritdoc cref="Array.CreateInstance(Type,int,int,int)"/>
        public static Array CreateArray(this Type arrayType, int length, int length2, int length3) => Array.CreateInstance(arrayType, length, length2, length3);
        
        /// <inheritdoc cref="Array.CreateInstance(Type,int[],int[])"/>
        public static Array CreateArray(this Type arrayType, int[] lengths, int[] loweBounds) => Array.CreateInstance(arrayType, lengths, loweBounds);
        
        /// <inheritdoc cref="Array.CreateInstance(Type,int[])"/>
        public static Array CreateArray(this Type arrayType, params int[] lengths) => Array.CreateInstance(arrayType, lengths);
        
        /// <inheritdoc cref="Array.CreateInstance(Type,long[])"/>
        public static Array CreateArray(this Type arrayType, params long[] lengths) => Array.CreateInstance(arrayType, lengths);
    }
}