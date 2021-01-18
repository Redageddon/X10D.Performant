using System;

namespace X10D.Performant.GenericExtensions
{
    public static partial class GenericExtensions
    {
        /// <inheritdoc cref="Enum.GetNames{T}"/>
        public static string[] GetNames<T>() 
            where T : struct, Enum
            => Enum.GetNames<T>();
        
        /// <inheritdoc cref="Enum.GetValues{T}"/>
        public static T[] GetValues<T>()
            where T : struct, Enum =>
            Enum.GetValues<T>();
    }
}