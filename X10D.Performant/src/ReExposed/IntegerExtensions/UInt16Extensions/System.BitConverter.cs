﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class UInt16Extensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(ushort)"/>
        [CLSCompliant(false)]
        public static byte[] GetBytes(this ushort value) => BitConverter.GetBytes(value);
    }
}