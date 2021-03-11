using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Creates a new <see cref="DateTime"/> with supplied values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="ensureOneNextCall">
        ///     If <see langword="true"/> <paramref name="random"/> has <see cref="System.Random.Next()"/> called only one time.
        /// </param>
        /// <param name="minTicks">The inclusive upper bound of ticks.</param>
        /// <param name="maxTicks">The exclusive lower bound of ticks.</param>
        /// <returns>A new <see cref="DateTime"/>.</returns>
        public static DateTime NextDateTime(this Random random, bool ensureOneNextCall = false, long minTicks = 0, long maxTicks = long.MaxValue)
        {
            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                return new DateTime(delegatedRandom.NextInt64(minTicks, maxTicks));
            }

            return new DateTime(random.NextInt64(minTicks, maxTicks));
        }

        /// <summary>
        ///     Creates a new <see cref="DateTime"/> with supplied values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="ensureOneNextCall">
        ///     If <see langword="true"/> <paramref name="random"/> has <see cref="System.Random.Next()"/> called only one time.
        /// </param>
        /// <param name="maxTicks">The exclusive lower bound of ticks.</param>
        /// <returns>A new <see cref="DateTime"/>.</returns>
        public static DateTime NextDateTime(this Random random, bool ensureOneNextCall = false, long maxTicks = long.MaxValue)
        {
            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                return new DateTime(delegatedRandom.NextInt64(maxTicks));
            }

            return new DateTime(random.NextInt64(maxTicks));
        }

        /// <summary>
        ///     Creates a new <see cref="DateTime"/> with supplied values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="ensureOneNextCall">
        ///     If <see langword="true"/> <paramref name="random"/> has <see cref="System.Random.Next()"/> called only one time.
        /// </param>
        /// <param name="yearMin">The inclusive lower bound for the random year.</param>
        /// <param name="yearMax">The exclusive upper bound for the random year.</param>
        /// <param name="monthMin">The inclusive lower bound for the random month.</param>
        /// <param name="monthMax">The exclusive upper bound for the random month.</param>
        /// <param name="dayMin">The inclusive lower bound for the random day.</param>
        /// <param name="dayMax">The exclusive upper bound for the random day.</param>
        /// <param name="hourMin">The inclusive lower bound for the random hour.</param>
        /// <param name="hourMax">The exclusive upper bound for the random hour.</param>
        /// <param name="minuteMin">The inclusive lower bound for the random minute.</param>
        /// <param name="minuteMax">The exclusive upper bound for the random minute.</param>
        /// <param name="secondMin">The inclusive lower bound for the random second.</param>
        /// <param name="secondMax">The exclusive upper bound for the random second.</param>
        /// <param name="millisecondMin">The inclusive lower bound for the random millisecond.</param>
        /// <param name="millisecondMax">The exclusive upper bound for the random millisecond.</param>
        /// <returns>
        ///     A new <see cref="DateTime"/> with
        ///     year between <paramref name="yearMin"/> and <paramref name="yearMax"/>,
        ///     month between <paramref name="monthMin"/> and <paramref name="monthMax"/>,
        ///     day between <paramref name="dayMin"/> and <paramref name="dayMax"/>,
        ///     hour between <paramref name="hourMin"/> and <paramref name="hourMax"/>,
        ///     minute between <paramref name="minuteMin"/> and <paramref name="minuteMax"/>,
        ///     second between <paramref name="secondMin"/> and <paramref name="secondMax"/>, and
        ///     millisecond between <paramref name="millisecondMin"/> and <paramref name="millisecondMax"/>.
        /// </returns>
        [SuppressMessage("ReSharper",
                         "MethodOverloadWithOptionalParameter",
                         Justification = "Other method should be used unless custom params are passed")]
        public static DateTime NextDateTime(this Random random,
                                            bool ensureOneNextCall = false,
                                            int yearMin = 0,
                                            int yearMax = 10000,
                                            int monthMin = 0,
                                            int monthMax = 13,
                                            int dayMin = 0,
                                            int dayMax = 32,
                                            int hourMin = 0,
                                            int hourMax = 25,
                                            int minuteMin = 0,
                                            int minuteMax = 61,
                                            int secondMin = 0,
                                            int secondMax = 61,
                                            int millisecondMin = 0,
                                            int millisecondMax = 1001)
        {
            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                return new DateTime(delegatedRandom.Next(yearMin, yearMax),
                                    delegatedRandom.Next(monthMin, monthMax),
                                    delegatedRandom.Next(dayMin, dayMax),
                                    delegatedRandom.Next(hourMin, hourMax),
                                    delegatedRandom.Next(minuteMin, minuteMax),
                                    delegatedRandom.Next(secondMin, secondMax),
                                    delegatedRandom.Next(millisecondMin, millisecondMax));
            }

            return new DateTime(random.Next(yearMin, yearMax),
                                random.Next(monthMin, monthMax),
                                random.Next(dayMin, dayMax),
                                random.Next(hourMin, hourMax),
                                random.Next(minuteMin, minuteMax),
                                random.Next(secondMin, secondMax),
                                random.Next(millisecondMin, millisecondMax));
        }

        /// <summary>
        ///     Creates a new <see cref="DateTime"/> with supplied values.
        /// </summary>
        /// <param name="randomYear">The <see cref="System.Random"/> instance that determines the value for the year.</param>
        /// <param name="randomMonth">The <see cref="System.Random"/> instance that determines the value for the month.</param>
        /// <param name="randomDay">The <see cref="System.Random"/> instance that determines the value for the day.</param>
        /// <param name="randomHour">The <see cref="System.Random"/> instance that determines the value for the hour.</param>
        /// <param name="randomMinute">The <see cref="System.Random"/> instance that determines the value for the minute.</param>
        /// <param name="randomSecond">The <see cref="System.Random"/> instance that determines the value for the second.</param>
        /// <param name="randomMillisecond">The <see cref="System.Random"/> instance that determines the value for the millisecond.</param>
        /// <param name="yearMin">The inclusive lower bound for the random year.</param>
        /// <param name="yearMax">The exclusive upper bound for the random year.</param>
        /// <param name="monthMin">The inclusive lower bound for the random month.</param>
        /// <param name="monthMax">The exclusive upper bound for the random month.</param>
        /// <param name="dayMin">The inclusive lower bound for the random day.</param>
        /// <param name="dayMax">The exclusive upper bound for the random day.</param>
        /// <param name="hourMin">The inclusive lower bound for the random hour.</param>
        /// <param name="hourMax">The exclusive upper bound for the random hour.</param>
        /// <param name="minuteMin">The inclusive lower bound for the random minute.</param>
        /// <param name="minuteMax">The exclusive upper bound for the random minute.</param>
        /// <param name="secondMin">The inclusive lower bound for the random second.</param>
        /// <param name="secondMax">The exclusive upper bound for the random second.</param>
        /// <param name="millisecondMin">The inclusive lower bound for the random millisecond.</param>
        /// <param name="millisecondMax">The exclusive upper bound for the random millisecond.</param>
        /// <returns>
        ///     A new <see cref="DateTime"/> with
        ///     year between <paramref name="yearMin"/> and <paramref name="yearMax"/>,
        ///     month between <paramref name="monthMin"/> and <paramref name="monthMax"/>,
        ///     day between <paramref name="dayMin"/> and <paramref name="dayMax"/>,
        ///     hour between <paramref name="hourMin"/> and <paramref name="hourMax"/>,
        ///     minute between <paramref name="minuteMin"/> and <paramref name="minuteMax"/>,
        ///     second between <paramref name="secondMin"/> and <paramref name="secondMax"/>, and
        ///     millisecond between <paramref name="millisecondMin"/> and <paramref name="millisecondMax"/> with
        ///     year chosen by <paramref name="randomYear"/>,
        ///     month chosen by <paramref name="randomMonth"/>,
        ///     day chosen by <paramref name="randomDay"/>,
        ///     hour chosen by <paramref name="randomHour"/>,
        ///     minute chosen by <paramref name="randomMinute"/>,
        ///     second chosen by <paramref name="randomSecond"/>, and
        ///     millisecond chosen by <paramref name="randomMillisecond"/>.
        /// </returns>
        public static DateTime NextDateTime(this Random randomYear,
                                            Random randomMonth,
                                            Random randomDay,
                                            Random randomHour,
                                            Random randomMinute,
                                            Random randomSecond,
                                            Random randomMillisecond,
                                            int yearMin = 0,
                                            int yearMax = 10000,
                                            int monthMin = 0,
                                            int monthMax = 13,
                                            int dayMin = 0,
                                            int dayMax = 32,
                                            int hourMin = 0,
                                            int hourMax = 25,
                                            int minuteMin = 0,
                                            int minuteMax = 61,
                                            int secondMin = 0,
                                            int secondMax = 61,
                                            int millisecondMin = 0,
                                            int millisecondMax = 1001) =>
            new(randomYear.Next(yearMin, yearMax),
                randomMonth.Next(monthMin, monthMax),
                randomDay.Next(dayMin, dayMax),
                randomHour.Next(hourMin, hourMax),
                randomMinute.Next(minuteMin, minuteMax),
                randomSecond.Next(secondMin, secondMax),
                randomMillisecond.Next(millisecondMin, millisecondMax));
    }
}