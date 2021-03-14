using System;
using System.Numerics;

namespace X10D.Performant.RandomExtensions
{
    public static partial class RandomExtensions
    {
        /// <include file='../RandomExtensions.xml' path='members/member[@name="NextVector2"]'/>
        public static Vector2 NextVector2(this Random random,
                                          bool ensureOneNextCall = false,
                                          float xMin = 0,
                                          float xMax = 1,
                                          float yMin = 0,
                                          float yMax = 1)
        {
            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                return new Vector2(delegatedRandom.NextSingle(xMin, xMax),
                                   delegatedRandom.NextSingle(yMin, yMax));
            }

            return new Vector2(random.NextSingle(), random.NextSingle());
        }

        /// <include file='../RandomExtensions.xml' path='members/member[@name="NextVector2Random"]'/>
        public static Vector2 NextVector2(this Random randomX,
                                          Random randomY,
                                          float xMin = 0,
                                          float xMax = 1,
                                          float yMin = 0,
                                          float yMax = 1) =>
            new(randomX.NextSingle(xMin, xMax), randomY.NextSingle(yMin, yMax));

        /// <include file='../RandomExtensions.xml' path='members/member[@name="NextVector3"]'/>
        public static Vector3 NextVector3(this Random random,
                                          bool ensureOneNextCall = false,
                                          float xMin = 0,
                                          float xMax = 1,
                                          float yMin = 0,
                                          float yMax = 1,
                                          float zMin = 0,
                                          float zMax = 1)
        {
            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                return new Vector3(delegatedRandom.NextSingle(xMin, xMax),
                                   delegatedRandom.NextSingle(yMin, yMax),
                                   delegatedRandom.NextSingle(zMin, zMax));
            }

            return new Vector3(random.NextSingle(xMin, xMax),
                               random.NextSingle(yMin, yMax),
                               random.NextSingle(zMin, zMax));
        }

        /// <include file='../RandomExtensions.xml' path='members/member[@name="NextVector3Random"]'/>
        public static Vector3 NextVector3(this Random randomX,
                                          Random randomY,
                                          Random randomZ,
                                          float xMin = 0,
                                          float xMax = 1,
                                          float yMin = 0,
                                          float yMax = 1,
                                          float zMin = 0,
                                          float zMax = 1) =>
            new(randomX.NextSingle(xMin, xMax),
                randomY.NextSingle(yMin, yMax),
                randomZ.NextSingle(zMin, zMax));

        /// <include file='../RandomExtensions.xml' path='members/member[@name="NextVector4"]'/>
        public static Vector4 NextVector4(this Random random,
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

                return new Vector4(delegatedRandom.NextSingle(xMin, xMax),
                                   delegatedRandom.NextSingle(yMin, yMax),
                                   delegatedRandom.NextSingle(zMin, zMax),
                                   delegatedRandom.NextSingle(wMin, wMax));
            }

            return new Vector4(random.NextSingle(xMin, xMax),
                               random.NextSingle(yMin, yMax),
                               random.NextSingle(zMin, zMax),
                               random.NextSingle(wMin, wMax));
        }

        /// <include file='../RandomExtensions.xml' path='members/member[@name="NextVector4Random"]'/>
        public static Vector4 NextVector4(this Random randomX,
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
}