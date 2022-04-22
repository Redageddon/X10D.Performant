using X10D.Performant.BooleanExtensions;

namespace X10D.Performant.DateTimeExtensions;

/// <summary>
///     Extension methods for <see cref="DateTime"/>.
/// </summary>
public static class DateTimeExtensions
{
    /// <include file='DateTimeExtensions.xml' path='members/member[@name="Age"]'/>
    public static int Age(this DateTime date, DateTime? asOf = null)
    {
        const double daysInYear = 365.2425;
        TimeSpan offset = (asOf ?? DateTime.Today).Date - TimeSpan.FromDays(1) - date.Date;

        return (int)((offset.TotalDays + 1) / daysInYear);
    }

    /// <include file='DateTimeExtensions.xml' path='members/member[@name="First"]'/>
    public static DateTime First(this DateTime current, DayOfWeek dayOfWeek)
    {
        DateTime first = current.FirstDayOfMonth();

        return first.DayOfWeek != dayOfWeek
            ? first.Next(dayOfWeek)
            : first;
    }

    /// <include file='DateTimeExtensions.xml' path='members/member[@name="FirstDayOfMonth"]'/>
    public static DateTime FirstDayOfMonth(this DateTime current) => current.AddDays(1 - current.Day);

    /// <include file='DateTimeExtensions.xml' path='members/member[@name="Last"]'/>
    public static DateTime Last(this DateTime current, DayOfWeek dayOfWeek)
    {
        DateTime last = current.LastDayOfMonth();
        DayOfWeek lastDayOfWeek = last.DayOfWeek;

        int diff = dayOfWeek - lastDayOfWeek;

        return last.AddDays(diff - (7 * (diff > 0).ToByte()));
    }

    /// <include file='DateTimeExtensions.xml' path='members/member[@name="LastDayOfMonth"]'/>
    public static DateTime LastDayOfMonth(this DateTime current)
    {
        int daysInMonth = DateTime.DaysInMonth(current.Year, current.Month);

        return new DateTime(current.Year, current.Month, daysInMonth);
    }

    /// <include file='DateTimeExtensions.xml' path='members/member[@name="Next"]'/>
    public static DateTime Next(this DateTime current, DayOfWeek dayOfWeek)
    {
        int offsetDays = dayOfWeek - current.DayOfWeek;

        return current.AddDays(offsetDays + (7 * (offsetDays <= 0).ToByte()));
    }

    /// <include file='DateTimeExtensions.xml' path='members/member[@name="ToUnixTimeStamp"]'/>
    public static long ToUnixTimeStamp(this DateTime time, bool useMillis = false)
    {
        DateTimeOffset offset = time;

        return useMillis
            ? offset.ToUnixTimeMilliseconds()
            : offset.ToUnixTimeSeconds();
    }
}