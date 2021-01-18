﻿using System;

namespace X10D.Performant.UShortExtensions
{
    public static partial class UShortExtensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(ushort)"/>
        public static byte[] GetBytes(this ushort value) => BitConverter.GetBytes(value);
    }
}