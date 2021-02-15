using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static partial class DoubleExtensions
    {
        /// <inheritdoc cref="DateTime.FromOADate(double)" />
        public static DateTime FromOADate(this double value) => DateTime.FromOADate(value);
    }
}