﻿namespace X10D.Performant.IListExtensions;

/// <summary>
///     Extension methods for <see cref="IList{T}"/>
/// </summary>
public static class ListExtensions
{
    /// <include file='ListExtensions.xml' path='members/member[@name="OneOf"]'/>
    public static T? OneOf<T>(this IList<T?> values, Random? random = null) =>
        values[(random ?? RandomExtensions.RandomExtensions.Random).Next(values.Count)];

    /// <include file='ListExtensions.xml' path='members/member[@name="Random"]'/>
    public static void Random<T>(this IList<T?> values, IList<T?> buffer, Random? random = null)
    {
        random ??= RandomExtensions.RandomExtensions.Random;

        for (int i = 0; i < buffer.Count; i++)
        {
            buffer[i] = values[random.Next(0, values.Count)];
        }
    }

    /// <include file='ListExtensions.xml' path='members/member[@name="Shuffle"]'/>
    public static void Shuffle<T>(this IList<T?> values, Random? random = null)
    {
        random ??= RandomExtensions.RandomExtensions.Random;

        int count = values.Count;

        while (count > 0)
        {
            int index = random.Next(count--);

            values.Swap(count, index);
        }
    }

    /// <include file='ListExtensions.xml' path='members/member[@name="Swap"]'/>
    public static void Swap<T>(this IList<T> values, int firstIndex, int secondIndex) =>
        (values[firstIndex], values[secondIndex]) = (values[secondIndex], values[firstIndex]);
}