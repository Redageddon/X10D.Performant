using System;

namespace X10D.Performant.IComparableExtensions;

/// <summary>
///     Extension methods for <see cref="IComparable"/>.
/// </summary>
public static class ComparableExtensions
{
    /// <include file='ComparableExtensions.xml' path='members/member[@name="Between"]'/>
    public static bool Between<T>(this T value, T lower, T upper)
        where T : IComparable<T> =>
        value.CompareTo(lower) > 0 && value.CompareTo(upper) < 0;

    /// <include file='ComparableExtensions.xml' path='members/member[@name="Clamp"]'/>
    public static T Clamp<T>(this T value, T lower, T upper)
        where T : IComparable<T> =>
        value.Max(lower).Min(upper);

    /// <include file='ComparableExtensions.xml' path='members/member[@name="GreaterThan"]'/>
    public static bool GreaterThan<T1, T2>(this T1 value, T2 other)
        where T1 : IComparable<T2> =>
        value.CompareTo(other) > 0;

    /// <include file='ComparableExtensions.xml' path='members/member[@name="LessThan"]'/>
    public static bool LessThan<T1, T2>(this T1 value, T2 other)
        where T1 : IComparable<T2> =>
        value.CompareTo(other) < 0;

    /// <include file='ComparableExtensions.xml' path='members/member[@name="Max"]'/>
    public static T Max<T>(this T value, T other)
        where T : IComparable<T> =>
        value.GreaterThan(other) ? value : other;

    /// <include file='ComparableExtensions.xml' path='members/member[@name="Min"]'/>
    public static T Min<T>(this T value, T other)
        where T : IComparable<T> =>
        value.LessThan(other) ? value : other;

    /// <include file='ComparableExtensions.xml' path='members/member[@name="Outside"]'/>
    public static bool Outside<T>(this T value, T lower, T upper)
        where T : IComparable<T> =>
        value.CompareTo(lower) < 0 || value.CompareTo(upper) > 0;
}