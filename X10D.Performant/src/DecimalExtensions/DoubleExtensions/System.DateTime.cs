using System;

namespace X10D.Performant.DoubleExtensions
{
    public static partial class DoubleExtensions
    {
        // ReSharper disable once InconsistentNaming
        /// <inheritdoc cref="DateTime.FromOADate(double)"/>
        public static DateTime FromOADate(this double value) => DateTime.FromOADate(value);
    }
}