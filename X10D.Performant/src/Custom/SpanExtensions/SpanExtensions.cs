using System;

namespace X10D.Performant.SpanExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="Span{T}"/>.
    /// </summary>
    public static partial class SpanExtensions
    {
        private const int NoValuePassed = -1;

        /// <include file='SpanExtensions.xml' path='members/member[@name="Swap"]'/>
        public static void Swap<T>(this Span<T> values, int firstIndex, int secondIndex) =>
            (values[firstIndex], values[secondIndex]) = (values[secondIndex], values[firstIndex]);
    }
}