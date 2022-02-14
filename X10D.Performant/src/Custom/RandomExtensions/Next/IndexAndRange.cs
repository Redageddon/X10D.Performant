using System;

namespace X10D.Performant.RandomExtensions;

public static partial class RandomExtensions
{
    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextIndexMax"]'/>
    public static Index NextIndex(this Random random, int minValue, int maxValue, bool fromEnd = false) =>
        new(random.Next(minValue, maxValue), fromEnd);

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextIndex"]'/>
    public static Index NextIndex(this Random random, int maxValue, bool fromEnd = false) => new(random.Next(maxValue), fromEnd);

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextRangeMax"]'/>
    public static Range NextRange(this Random random,
                                  int indexStartMin,
                                  int indexStartMax,
                                  int indexEndMin,
                                  int indexEndMax,
                                  bool indexStartFromEnd = false,
                                  bool indexEndFromEnd = false,
                                  bool ensureOneNextCall = false)
    {
        if (ensureOneNextCall)
        {
            Random delegatedRandom = new(random.Next());

            return new Range(delegatedRandom.NextIndex(indexStartMin, indexStartMax, indexStartFromEnd),
                             delegatedRandom.NextIndex(indexEndMin, indexEndMax, indexEndFromEnd));
        }

        return new Range(random.NextIndex(indexStartMin, indexStartMax, indexStartFromEnd),
                         random.NextIndex(indexEndMin, indexEndMax, indexEndFromEnd));
    }

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextRange"]'/>
    public static Range NextRange(this Random random,
                                  int indexStartMax,
                                  int indexEndMax,
                                  bool indexStartFromEnd = false,
                                  bool indexEndFromEnd = false,
                                  bool ensureOneNextCall = false)
    {
        if (ensureOneNextCall)
        {
            Random delegatedRandom = new(random.Next());

            return new Range(delegatedRandom.NextIndex(indexStartMax, indexStartFromEnd),
                             delegatedRandom.NextIndex(indexEndMax, indexEndFromEnd));
        }

        return new Range(random.NextIndex(indexStartMax, indexStartFromEnd),
                         random.NextIndex(indexEndMax, indexEndFromEnd));
    }
}