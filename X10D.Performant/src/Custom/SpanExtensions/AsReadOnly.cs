namespace X10D.Performant.SpanExtensions;

public static partial class SpanExtensions
{
    /// <include file='SpanExtensions.xml' path='members/member[@name="AsReadOnly"]'/>
    public static ReadOnlySpan<T> AsReadOnly<T>(this Span<T> values) => values;
}