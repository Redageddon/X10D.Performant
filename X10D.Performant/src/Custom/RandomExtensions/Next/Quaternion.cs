using System;
using System.Numerics;

namespace X10D.Performant.RandomExtensions;

public static partial class RandomExtensions
{
    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextQuaternion"]'/>
    public static Quaternion NextQuaternion(this Random random,
                                            bool ensureOneNextCall = false,
                                            float xMin = 0,
                                            float xMax = 1,
                                            float yMin = 0,
                                            float yMax = 1,
                                            float zMin = 0,
                                            float zMax = 1,
                                            float wMin = 0,
                                            float wMax = 1)
    {
        if (ensureOneNextCall)
        {
            Random delegatedRandom = new(random.Next());

            return new Quaternion(delegatedRandom.NextSingle(xMin, xMax),
                                  delegatedRandom.NextSingle(yMin, yMax),
                                  delegatedRandom.NextSingle(zMin, zMax),
                                  delegatedRandom.NextSingle(wMin, wMax));
        }

        return new Quaternion(random.NextSingle(xMin, xMax),
                              random.NextSingle(yMin, yMax),
                              random.NextSingle(zMin, zMax),
                              random.NextSingle(wMin, wMax));
    }

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextQuaternionRandom"]'/>
    public static Quaternion NextQuaternion(this Random randomX,
                                            Random randomY,
                                            Random randomZ,
                                            Random randomW,
                                            float xMin = 0,
                                            float xMax = 1,
                                            float yMin = 0,
                                            float yMax = 1,
                                            float zMin = 0,
                                            float zMax = 1,
                                            float wMin = 0,
                                            float wMax = 1) =>
        new(randomX.NextSingle(xMin, xMax),
            randomY.NextSingle(yMin, yMax),
            randomZ.NextSingle(zMin, zMax),
            randomW.NextSingle(wMin, wMax));
}