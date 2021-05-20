using System;

namespace X10D.Performant.SpanExtensions
{
    //TODO: DOCUMENT
    //TODO: TEST
    public static partial class SpanExtensions
    {
        public static bool All<T>(ReadOnlySpan<T?> values, Predicate<T?> predicate)
        {
            foreach (T? value in values)
            {
                if (!predicate(value))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool All<T>(Span<T?> values, Predicate<T?> predicate) => All(values.AsReadOnly(), predicate);
    }
}