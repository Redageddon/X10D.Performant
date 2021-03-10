using System;
using System.Numerics;

namespace X10D.Performant
{
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Returns a new random <see cref="Quaternion"/> with supplied ranges.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="ensureOneNextCall">If <see langword="true"/> <paramref name="random"/> only has <see cref="System.Random.Next()"/> called once.</param>
        /// <param name="xMin">The inclusive lower bound of <see cref="Quaternion.X"/>.</param>
        /// <param name="xMax">The exclusive upper bound of <see cref="Quaternion.X"/>.</param>
        /// <param name="yMin">The inclusive lower bound of <see cref="Quaternion.Y"/>.</param>
        /// <param name="yMax">The exclusive upper bound of <see cref="Quaternion.Y"/>.</param>
        /// <param name="zMin">The inclusive lower bound of <see cref="Quaternion.Z"/>.</param>
        /// <param name="zMax">The exclusive upper bound of <see cref="Quaternion.Z"/>.</param>
        /// <param name="wMin">The inclusive lower bound of <see cref="Quaternion.W"/>.</param>
        /// <param name="wMax">The exclusive upper bound of <see cref="Quaternion.W"/>.</param>
        /// <returns>
        ///     A new random <see cref="Quaternion"/> with
        ///     <see cref="Quaternion.X"/> between <paramref name="xMin"/> and <paramref name="xMax"/>,
        ///     <see cref="Quaternion.Y"/> between <paramref name="yMin"/> and <paramref name="yMax"/>,
        ///     <see cref="Quaternion.Z"/> between <paramref name="zMin"/> and <paramref name="zMax"/>, and
        ///     <see cref="Quaternion.W"/> between <paramref name="wMin"/> and <paramref name="wMax"/>.
        /// </returns>
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

        /// <summary>
        ///     Returns a new random <see cref="Quaternion"/> with supplied ranges.
        /// </summary>
        /// <param name="randomX">The <see cref="System.Random"/> instance that determines the <see cref="Quaternion.X"/> value.</param>
        /// <param name="randomY">The <see cref="System.Random"/> instance that determines the <see cref="Quaternion.Y"/> value.</param>
        /// <param name="randomZ">The <see cref="System.Random"/> instance that determines the <see cref="Quaternion.Z"/> value.</param>
        /// <param name="randomW">The <see cref="System.Random"/> instance that determines the <see cref="Quaternion.W"/> value.</param>
        /// <param name="xMin">The inclusive lower bound of <see cref="Vector4.X"/>.</param>
        /// <param name="xMax">The exclusive upper bound of <see cref="Vector4.X"/>.</param>
        /// <param name="yMin">The inclusive lower bound of <see cref="Vector4.Y"/>.</param>
        /// <param name="yMax">The exclusive upper bound of <see cref="Vector4.Y"/>.</param>
        /// <param name="zMin">The inclusive lower bound of <see cref="Vector4.Z"/>.</param>
        /// <param name="zMax">The exclusive upper bound of <see cref="Vector4.Z"/>.</param>
        /// <param name="wMin">The inclusive lower bound of <see cref="Vector4.W"/>.</param>
        /// <param name="wMax">The exclusive upper bound of <see cref="Vector4.W"/>.</param>
        /// <returns>
        ///     A new random <see cref="Quaternion"/> with
        ///     <see cref="Quaternion.X"/> between <paramref name="xMin"/> and <paramref name="xMax"/>,
        ///     <see cref="Quaternion.Y"/> between <paramref name="yMin"/> and <paramref name="yMax"/>,
        ///     <see cref="Quaternion.Z"/> between <paramref name="zMin"/> and <paramref name="zMax"/>, and
        ///     <see cref="Quaternion.W"/> between <paramref name="wMin"/> and <paramref name="wMax"/> with
        ///     <see cref="Quaternion.X"/> chosen by <paramref name="randomX"/>,
        ///     <see cref="Quaternion.Y"/> chosen by <paramref name="randomY"/>,
        ///     <see cref="Quaternion.Z"/> chosen by <paramref name="randomZ"/>, and
        ///     <see cref="Quaternion.W"/> chosen by <paramref name="randomW"/>.
        /// </returns>
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
}