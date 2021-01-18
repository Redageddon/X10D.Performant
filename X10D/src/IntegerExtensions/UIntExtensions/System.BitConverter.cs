﻿using System;

namespace X10D.Performant.UIntExtensions
{
    public static partial class UIntExtensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(uint)"/>
        public static byte[] GetBytes(this uint value) => BitConverter.GetBytes(value);
    }
}