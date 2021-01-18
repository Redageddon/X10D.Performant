﻿using System;

namespace X10D.Performant.IntExtensions
{
    public static partial class IntExtensions
    {
        /// <inheritdoc cref="BitConverter.GetBytes(long)"/>
        public static byte[] GetBytes(this int value) => BitConverter.GetBytes(value);
    }
}