using System;

namespace X10D.Performant
{
    public static partial class ReflectionExtensions
    {
        /// <inheritdoc cref="Type.GetTypeCode(Type)" />
        public static TypeCode GetTypeCode(this Type type) => Type.GetTypeCode(type);

        /// <inheritdoc cref="Type.MakeGenericSignatureType(Type,Type[])" />
        public static Type MakeGenericSignatureType(this Type type, params Type[] types) => Type.MakeGenericSignatureType(type, types);
    }
}