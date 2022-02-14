namespace X10D.Performant.GenericExtensions;

/// <summary>
///     General generic extension methods.
/// </summary>
public static partial class GenericExtensions
{
    /// <include file='GenericExtensions.xml' path='members/member[@name="Span"]'/>
    public static void Swap<T>(this ref T first, ref T second)
        where T : struct =>
        (first, second) = (second, first);
}