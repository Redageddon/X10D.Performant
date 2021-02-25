using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class Int32Extensions
    {
        /// <inheritdoc cref="DateTime.DaysInMonth(int,int)" />
        public static int DaysInMonth(this int year, int month) => DateTime.DaysInMonth(year, month);

        /// <inheritdoc cref="DateTime.IsLeapYear(int)" />
        public static bool IsLeapYear(this int year) => DateTime.IsLeapYear(year);
    }
}