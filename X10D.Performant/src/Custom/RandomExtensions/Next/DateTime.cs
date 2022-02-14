using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.RandomExtensions;

public static partial class RandomExtensions
{
    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextDateTimeMax"]'/>
    public static DateTime NextDateTime(this Random random, long minTicks, long maxTicks, bool ensureOneNextCall = false)
    {
        if (ensureOneNextCall)
        {
            Random delegatedRandom = new(random.Next());

            return new DateTime(delegatedRandom.NextInt64(minTicks, maxTicks));
        }

        return new DateTime(random.NextInt64(minTicks, maxTicks));
    }

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextDateTime"]'/>
    public static DateTime NextDateTime(this Random random, long maxTicks, bool ensureOneNextCall = false)
    {
        if (ensureOneNextCall)
        {
            Random delegatedRandom = new(random.Next());

            return new DateTime(delegatedRandom.NextInt64(maxTicks));
        }

        return new DateTime(random.NextInt64(maxTicks));
    }

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextDateTimeOverload"]'/>
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

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextDateTimeRandomOverload"]'/>
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