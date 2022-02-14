using System;
using System.Collections.Generic;
using System.Security;
using X10D.Performant.SpanExtensions;

namespace X10D.Performant.StringExtensions;

/// <summary>
///     Extension methods for <see cref="string"/>.
/// </summary>
public static partial class StringExtensions
{
    /// <include file='StringExtensions.xml' path='members/member[@name="Repeat"]'/>
    public static string Repeat(this string value, int count)
    {
        if (value.Length == 0
         || count <= 0)
        {
            return string.Empty;
        }

        int size = value.Length * count;
        Span<char> span = stackalloc char[size];

        int p = 0;
        int i = 0;

        while (i < size)
        {
            if (p == value.Length)
            {
                p = 0;
            }

            span[i++] = value[p++];
        }

        return new string(span);
    }

    /// <include file='StringExtensions.xml' path='members/member[@name="Shuffle"]'/>
    public static string Shuffle(this string value, Random? random = null) => new(value.AsSpan().Shuffled(random));

    /// <include file='StringExtensions.xml' path='members/member[@name="Split"]'/>
    public static IEnumerable<string> Split(this string value, int chunkSize)
    {
        for (int i = 0; i < value.Length; i += chunkSize)
        {
            yield return value.Substring(i, Math.Min(chunkSize, value.Length - i));
        }
    }

    /// <include file='StringExtensions.xml' path='members/member[@name="ToSecureString"]'/>
    public static SecureString ToSecureString(this string value)
    {
        SecureString result = new();

        foreach (char c in value)
        {
            result.AppendChar(c);
        }

        return result;
    }
}