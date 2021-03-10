using System;
using System.Numerics;

namespace X10D.Performant
{
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Returns a new random <see cref="Vector2"/> with supplied ranges.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="ensureOneNextCall">If true <paramref name="random"/> only has next called once.</param>
        /// <param name="xMin">The inclusive lower bound of <see cref="Vector2.X"/>.</param>
        /// <param name="xMax">The exclusive upper bound of <see cref="Vector2.X"/>.</param>
        /// <param name="yMin">The inclusive lower bound of <see cref="Vector2.Y"/>.</param>
        /// <param name="yMax">The exclusive upper bound of <see cref="Vector2.Y"/>.</param>
        /// <returns>
        ///     A new random <see cref="Vector2"/> with
        ///     <see cref="Vector2.X"/> between <paramref name="xMin"/> and <paramref name="xMax"/> and
        ///     <see cref="Vector2.Y"/> between <paramref name="yMin"/> and <paramref name="yMax"/>.
        /// </returns>
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

        /// <summary>
        ///     Returns a new random <see cref="Vector2"/> with supplied ranges.
        /// </summary>
        /// <param name="randomX">The <see cref="System.Random"/> instance that determines the <see cref="Vector2.X"/> value.</param>
        /// <param name="randomY">The <see cref="System.Random"/> instance that determines the <see cref="Vector2.Y"/> value.</param>
        /// <param name="xMin">The inclusive lower bound of <see cref="Vector2.X"/>.</param>
        /// <param name="xMax">The exclusive upper bound of <see cref="Vector2.X"/>.</param>
        /// <param name="yMin">The inclusive lower bound of <see cref="Vector2.Y"/>.</param>
        /// <param name="yMax">The exclusive upper bound of <see cref="Vector2.Y"/>.</param>
        /// <returns>
        ///     A new random <see cref="Vector2"/> with
        ///     <see cref="Vector2.X"/> between <paramref name="xMin"/> and <paramref name="xMax"/> and
        ///     <see cref="Vector2.Y"/> between <paramref name="yMin"/> and <paramref name="yMax"/> with
        ///     <see cref="Vector2.X"/> chosen by <paramref name="randomX"/> and
        ///     <see cref="Vector2.Y"/> chosen by <paramref name="randomY"/>.
        /// </returns>
        public static Vector2 NextVector2(this Random randomX,
                                          Random randomY,
                                          float xMin = 0,
                                          float xMax = 1,
                                          float yMin = 0,
                                          float yMax = 1) =>
            new(randomX.NextSingle(xMin, xMax), randomY.NextSingle(yMin, yMax));

        /// <summary>
        ///     Returns a new random <see cref="Vector3"/> with supplied ranges.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="ensureOneNextCall">If true <paramref name="random"/> only has next called once.</param>
        /// <param name="xMin">The inclusive lower bound of <see cref="Vector3.X"/>.</param>
        /// <param name="xMax">The exclusive upper bound of <see cref="Vector3.X"/>.</param>
        /// <param name="yMin">The inclusive lower bound of <see cref="Vector3.Y"/>.</param>
        /// <param name="yMax">The exclusive upper bound of <see cref="Vector3.Y"/>.</param>
        /// <param name="zMin">The inclusive lower bound of <see cref="Vector3.Z"/>.</param>
        /// <param name="zMax">The exclusive upper bound of <see cref="Vector3.Z"/>.</param>
        /// <returns>
        ///     A new random <see cref="Vector3"/> with
        ///     <see cref="Vector3.X"/> between <paramref name="xMin"/> and <paramref name="xMax"/>,
        ///     <see cref="Vector3.Y"/> between <paramref name="yMin"/> and <paramref name="yMax"/>, and
        ///     <see cref="Vector3.Z"/> between <paramref name="zMin"/> and <paramref name="zMax"/>.
        /// </returns>
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

        /// <summary>
        ///     Returns a new random <see cref="Vector3"/> with supplied ranges.
        /// </summary>
        /// <param name="randomX">The <see cref="System.Random"/> instance that determines the <see cref="Vector3.X"/> value.</param>
        /// <param name="randomY">The <see cref="System.Random"/> instance that determines the <see cref="Vector3.Y"/> value.</param>
        /// <param name="randomZ">The <see cref="System.Random"/> instance that determines the <see cref="Vector3.Z"/> value.</param>
        /// <param name="xMin">The inclusive lower bound of <see cref="Vector4.X"/>.</param>
        /// <param name="xMax">The exclusive upper bound of <see cref="Vector4.X"/>.</param>
        /// <param name="yMin">The inclusive lower bound of <see cref="Vector4.Y"/>.</param>
        /// <param name="yMax">The exclusive upper bound of <see cref="Vector4.Y"/>.</param>
        /// <param name="zMin">The inclusive lower bound of <see cref="Vector4.Z"/>.</param>
        /// <param name="zMax">The exclusive upper bound of <see cref="Vector4.Z"/>.</param>
        /// <returns>
        ///     A new random <see cref="Vector3"/> with
        ///     <see cref="Vector3.X"/> between <paramref name="xMin"/> and <paramref name="xMax"/>,
        ///     <see cref="Vector3.Y"/> between <paramref name="yMin"/> and <paramref name="yMax"/>, and
        ///     <see cref="Vector3.Z"/> between <paramref name="zMin"/> and <paramref name="zMax"/> with
        ///     <see cref="Vector3.X"/> chosen by <paramref name="randomX"/>,
        ///     <see cref="Vector3.Y"/> chosen by <paramref name="randomY"/>, and
        ///     <see cref="Vector3.Z"/> chosen by <paramref name="randomZ"/>.
        /// </returns>
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

        /// <summary>
        ///     Returns a new random <see cref="Vector4"/> with supplied ranges.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="ensureOneNextCall">If true <paramref name="random"/> only has next called once.</param>
        /// <param name="xMin">The inclusive lower bound of <see cref="Vector4.X"/>.</param>
        /// <param name="xMax">The exclusive upper bound of <see cref="Vector4.X"/>.</param>
        /// <param name="yMin">The inclusive lower bound of <see cref="Vector4.Y"/>.</param>
        /// <param name="yMax">The exclusive upper bound of <see cref="Vector4.Y"/>.</param>
        /// <param name="zMin">The inclusive lower bound of <see cref="Vector4.Z"/>.</param>
        /// <param name="zMax">The exclusive upper bound of <see cref="Vector4.Z"/>.</param>
        /// <param name="wMin">The inclusive lower bound of <see cref="Vector4.W"/>.</param>
        /// <param name="wMax">The exclusive upper bound of <see cref="Vector4.W"/>.</param>
        /// <returns>
        ///     A new random <see cref="Vector4"/> with
        ///     <see cref="Vector4.X"/> between <paramref name="xMin"/> and <paramref name="xMax"/>,
        ///     <see cref="Vector4.Y"/> between <paramref name="yMin"/> and <paramref name="yMax"/>,
        ///     <see cref="Vector4.Z"/> between <paramref name="zMin"/> and <paramref name="zMax"/>, and
        ///     <see cref="Vector4.W"/> between <paramref name="wMin"/> and <paramref name="wMax"/>.
        /// </returns>
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

        /// <summary>
        ///     Returns a new random <see cref="Vector4"/> with supplied ranges.
        /// </summary>
        /// <param name="randomX">The <see cref="System.Random"/> instance that determines the <see cref="Vector4.X"/> value.</param>
        /// <param name="randomY">The <see cref="System.Random"/> instance that determines the <see cref="Vector4.Y"/> value.</param>
        /// <param name="randomZ">The <see cref="System.Random"/> instance that determines the <see cref="Vector4.Z"/> value.</param>
        /// <param name="randomW">The <see cref="System.Random"/> instance that determines the <see cref="Vector4.W"/> value.</param>
        /// <param name="xMin">The inclusive lower bound of <see cref="Vector4.X"/>.</param>
        /// <param name="xMax">The exclusive upper bound of <see cref="Vector4.X"/>.</param>
        /// <param name="yMin">The inclusive lower bound of <see cref="Vector4.Y"/>.</param>
        /// <param name="yMax">The exclusive upper bound of <see cref="Vector4.Y"/>.</param>
        /// <param name="zMin">The inclusive lower bound of <see cref="Vector4.Z"/>.</param>
        /// <param name="zMax">The exclusive upper bound of <see cref="Vector4.Z"/>.</param>
        /// <param name="wMin">The inclusive lower bound of <see cref="Vector4.W"/>.</param>
        /// <param name="wMax">The exclusive upper bound of <see cref="Vector4.W"/>.</param>
        /// <returns>
        ///     A new random <see cref="Vector4"/> with
        ///     <see cref="Vector4.X"/> between <paramref name="xMin"/> and <paramref name="xMax"/>,
        ///     <see cref="Vector4.Y"/> between <paramref name="yMin"/> and <paramref name="yMax"/>,
        ///     <see cref="Vector4.Z"/> between <paramref name="zMin"/> and <paramref name="zMax"/>, and
        ///     <see cref="Vector4.W"/> between <paramref name="wMin"/> and <paramref name="wMax"/> with
        ///     <see cref="Vector4.X"/> chosen by <paramref name="randomX"/>,
        ///     <see cref="Vector4.Y"/> chosen by <paramref name="randomY"/>,
        ///     <see cref="Vector4.Z"/> chosen by <paramref name="randomZ"/>, and
        ///     <see cref="Vector4.W"/> chosen by <paramref name="randomW"/>.
        /// </returns>
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