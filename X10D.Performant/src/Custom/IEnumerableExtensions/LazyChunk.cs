﻿using System.Collections.Generic;

namespace X10D.Performant.IEnumerableExtensions
{
    public static partial class EnumerableExtensions
    {
        /// <include file='EnumerableExtensions.xml' path='members/member[@name="LazyChunk"]'/>
        public static IEnumerable<IEnumerable<TSource?>?> LazyChunk<TSource>(this IEnumerable<TSource?> values, int chunkSize)
        {
            TSource?[]? array = null;
            int count = 0;

            foreach (TSource? item in values)
            {
                array ??= new TSource[chunkSize];

                array[count++] = item;

                if (count == chunkSize)
                {
                    yield return array;
                    array = null;
                    count = 0;
                }
            }

            if (array != null
             && count > 0)
            {
                yield return array;
            }
        }
    }
}