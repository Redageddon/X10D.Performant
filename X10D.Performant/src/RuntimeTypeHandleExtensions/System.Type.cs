using System;

namespace X10D.Performant
{
    public static partial class RuntimeTypeHandleExtensions
    {
        /// <inheritdoc cref="Type.GetTypeFromHandle(RuntimeTypeHandle)"/>
        public static Type GetTypeFromHandle(this RuntimeTypeHandle handle) => Type.GetTypeFromHandle(handle);
    }
}