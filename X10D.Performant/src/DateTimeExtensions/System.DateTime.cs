using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class DateTimeExtensions
    {
        /// <inheritdoc cref="DateTime.Compare(DateTime,DateTime)"/>
        public static int Compare(this DateTime value, DateTime comparison) => DateTime.Compare(value, comparison);

        /// <inheritdoc cref="DateTime.SpecifyKind(DateTime,DateTimeKind)"/>
        public static DateTime SpecifyKind(this DateTime value, DateTimeKind kind) => DateTime.SpecifyKind(value, kind);
    }
}