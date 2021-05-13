using System;
using System.Collections.Generic;

namespace X10D.Performant.IEnumerableExtensions
{
    public static partial class EnumerableExtensions
    {
        /// <include file='EnumerableExtensions.xml' path='members/member[@name="SelectWhere"]'/>
        public static IEnumerable<TSource> SelectWhere<TSource>(this IEnumerable<TSource> values,
                                                                Func<TSource, TSource> selector,
                                                                Predicate<TSource> predicate)
        {
            foreach (TSource source in values)
            {
                if (predicate(source))
                {
                    yield return selector(source);
                }
            }
        }
    }
}