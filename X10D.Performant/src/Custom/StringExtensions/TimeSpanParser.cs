using System;
using System.Text.RegularExpressions;

namespace X10D.Performant.StringExtensions;

public static partial class StringExtensions
{
    /// <include file='StringExtensions.xml' path='members/member[@name="ShortHandParse"]'/>
    public static TimeSpan ShortHandParse(this string input, IFormatProvider? formatProvider = null)
    {
        const string realNumberPattern = @"([0-9]*\.[0-9]+|[0-9]+)";

        string pattern =
            $"^(?:{realNumberPattern} *w)? *(?:{realNumberPattern} *d)? *(?:{realNumberPattern} *h)? *(?:{realNumberPattern} *m)? *(?:{realNumberPattern} *s)? *(?:{realNumberPattern} *ms)?$";

        Match match = Regex.Match(input, pattern, RegexOptions.Compiled);
        double weeks = 0, days = 0, hours = 0, minutes = 0, seconds = 0, milliseconds = 0;

        if (match.Groups[1].Success)
        {
            weeks = double.Parse(match.Groups[1].Value, formatProvider);
        }

        if (match.Groups[2].Success)
        {
            days = double.Parse(match.Groups[2].Value, formatProvider);
        }

        if (match.Groups[3].Success)
        {
            hours = double.Parse(match.Groups[3].Value, formatProvider);
        }

        if (match.Groups[4].Success)
        {
            minutes = double.Parse(match.Groups[4].Value, formatProvider);
        }

        if (match.Groups[5].Success)
        {
            seconds = double.Parse(match.Groups[5].Value, formatProvider);
        }

        if (match.Groups[6].Success)
        {
            milliseconds = double.Parse(match.Groups[6].Value, formatProvider);
        }

        TimeSpan span = TimeSpan.Zero;

        span += TimeSpan.FromDays(weeks * 7);
        span += TimeSpan.FromDays(days);
        span += TimeSpan.FromHours(hours);
        span += TimeSpan.FromMinutes(minutes);
        span += TimeSpan.FromSeconds(seconds);
        span += TimeSpan.FromMilliseconds(milliseconds);

        return span;
    }
}