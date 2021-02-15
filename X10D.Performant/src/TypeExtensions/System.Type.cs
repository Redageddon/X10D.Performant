using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class TypeExtensions
    {
        /// <inheritdoc cref="Type.GetTypeCode(Type)" />
        public static TypeCode GetTypeCode(this Type type) => Type.GetTypeCode(type);

        /// <inheritdoc cref="Type.MakeGenericSignatureType(Type,Type[])" />
        public static Type MakeGenericSignatureType(this Type type, params Type[] types) => Type.MakeGenericSignatureType(type, types);
    }
}