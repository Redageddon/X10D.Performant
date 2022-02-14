using System;
using System.Collections.Generic;

namespace X10D.Performant.IEnumerableExtensions;

public static partial class EnumerableExtensions
{
    /// <include file='EnumerableExtensions.xml' path='members/member[@name="ForEach0"]'/>
    public static IEnumerable<TSource?> ForEach<TSource>(this IEnumerable<TSource?> values, Action<TSource?> action)
    {
        using IEnumerator<TSource?> iterator = values.GetEnumerator();

        while (iterator.MoveNext())
        {
            action(iterator.Current);

            yield return iterator.Current;
        }
    }

    /// <include file='EnumerableExtensions.xml' path='members/member[@name="ForEach1"]'/>
    public static IEnumerable<TSource?> ForEach<TSource>(this IEnumerable<TSource?> values, Action action)
    {
        using IEnumerator<TSource?> iterator = values.GetEnumerator();

        while (iterator.MoveNext())
        {
            action();

            yield return iterator.Current;
        }
    }
}