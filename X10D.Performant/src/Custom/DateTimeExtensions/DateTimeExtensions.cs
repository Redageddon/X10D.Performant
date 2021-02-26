using System;

namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="DateTime"/>.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        ///     Returns an <see cref="int"/> of the number of years since <see cref="DateTime"/> as of <see cref="DateTime"/>.
        /// </summary>
        /// <param name="date">The date from which to start.</param>
        /// <param name="asOf">The date at which to stop counting.</param>
        /// <returns>An <see cref="int"/> representing the number of years since <paramref name="date"/> as of <paramref name="asOf"/>.</returns>
        public static int Age(this DateTime date, DateTime? asOf = null)
        {
            const double daysInYear = 365.2425;
            TimeSpan offset = (asOf ?? DateTime.Today).Date - TimeSpan.FromDays(1) - date.Date;

            return (int)((offset.TotalDays + 1) / daysInYear);
        }

        /// <summary>
        ///     Gets a <see cref="DateTime"/> representing the first occurence of a specified day in the current month.
        /// </summary>
        /// <param name="current">The current day.</param>
        /// <param name="dayOfWeek">The current day of week.</param>
        /// <returns>A <see cref="DateTime"/> representing the first occurence of <paramref name="dayOfWeek"/>.</returns>
        public static DateTime First(this DateTime current, DayOfWeek dayOfWeek)
        {
            DateTime first = current.FirstDayOfMonth();

            if (first.DayOfWeek != dayOfWeek)
            {
                first = first.Next(dayOfWeek);
            }

            return first;
        }

        /// <summary>
        ///     Gets a <see cref="DateTime"/> representing the first day in the current month.
        /// </summary>
        /// <param name="current">The current date.</param>
        /// <returns>A <see cref="DateTime"/> representing the first day of the month>.</returns>
        public static DateTime FirstDayOfMonth(this DateTime current) => current.AddDays(1 - current.Day);

        /// <summary>
        ///     Gets a <see cref="DateTime"/> representing the last specified day in the current month.
        /// </summary>
        /// <param name="current">The current date.</param>
        /// <param name="dayOfWeek">The current day of week.</param>
        /// <returns>A <see cref="DateTime"/> representing the final occurence of <paramref name="dayOfWeek"/>.</returns>
        public static DateTime Last(this DateTime current, DayOfWeek dayOfWeek)
        {
            DateTime last = current.LastDayOfMonth();
            DayOfWeek lastDayOfWeek = last.DayOfWeek;

            int diff = dayOfWeek - lastDayOfWeek;
            int offset = diff > 0 ? diff - 7 : diff;

            return last.AddDays(offset);
        }

        /// <summary>
        ///     Gets a <see cref="DateTime"/> representing the last day in the current month.
        /// </summary>
        /// <param name="current">The current date.</param>
        /// <returns>A <see cref="DateTime"/> representing the last day of the month>.</returns>
        public static DateTime LastDayOfMonth(this DateTime current)
        {
            int daysInMonth = DateTime.DaysInMonth(current.Year, current.Month);

            return new DateTime(current.Year, current.Month, daysInMonth);
        }

        /// <summary>
        ///     Gets a <see cref="DateTime"/> representing the first date following the current date which falls on the given day of the week.
        /// </summary>
        /// <param name="current">The current date.</param>
        /// <param name="dayOfWeek">The day of week for the next date to get.</param>
        /// <returns>A <see cref="DateTime"/> representing the next occurence of <paramref name="dayOfWeek"/>.</returns>
        public static DateTime Next(this DateTime current, DayOfWeek dayOfWeek)
        {
            int offsetDays = dayOfWeek - current.DayOfWeek;

            if (offsetDays <= 0)
            {
                offsetDays += 7;
            }

            return current.AddDays(offsetDays);
        }

        /// <summary>
        ///     Converts the <see cref="DateTime"/> to a Unix timestamp.
        /// </summary>
        /// <param name="time">The <see cref="DateTime"/> instance.</param>
        /// <param name="useMillis">
        ///     Whether or not the return value should be represented as milliseconds. Defaults to <see langword="false"/>.
        /// </param>
        /// <returns>A <see cref="long"/> in terms of a Unix timestamp representing the provided <see cref="DateTime"/>.</returns>
        public static long ToUnixTimeStamp(this DateTime time, bool useMillis = false)
        {
            DateTimeOffset offset = time;

            return useMillis
                ? offset.ToUnixTimeMilliseconds()
                : offset.ToUnixTimeSeconds();
        }
    }
}