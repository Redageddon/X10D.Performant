using System;
using System.Reflection;

namespace X10D.Performant
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="Type.GetType(string,bool,bool)" />
        public static Type? GetType(this string value, bool throwOnError = false, bool ignoreCase = false) =>
            Type.GetType(value, throwOnError, ignoreCase);

        /// <inheritdoc cref="Type.GetType(string,Func{AssemblyName,Assembly},Func{Assembly,string,bool,Type},bool,bool)" />
        public static Type? GetType(
            this string typeName,
            Func<AssemblyName, Assembly?>? assemblyResolver,
            Func<Assembly?, string, bool, Type?>? typeResolver,
            bool throwOnError = false,
            bool ignoreCase = false) =>
            Type.GetType(typeName, assemblyResolver, typeResolver, throwOnError, ignoreCase);

        // ReSharper disable once InconsistentNaming
        /// <inheritdoc cref="Type.GetTypeFromProgID(string,string,bool)" />
        public static Type? GetTypeFromProgID(this string value, string? server = null, bool throwOnError = false) =>
            Type.GetTypeFromProgID(value, server, throwOnError);

        /// <inheritdoc cref="Type.ReflectionOnlyGetType(string,bool,bool)" />
        public static Type? ReflectionOnlyGetType(this string value, bool throwIfNotFound, bool ignoreCase) =>
            Type.ReflectionOnlyGetType(value, throwIfNotFound, ignoreCase);
    }
}