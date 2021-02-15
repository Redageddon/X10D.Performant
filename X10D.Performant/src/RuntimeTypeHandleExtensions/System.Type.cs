using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class RuntimeTypeHandleExtensions
    {
        /// <inheritdoc cref="Type.GetTypeFromHandle(RuntimeTypeHandle)"/>
        public static Type GetTypeFromHandle(this RuntimeTypeHandle handle) => Type.GetTypeFromHandle(handle);
    }
}