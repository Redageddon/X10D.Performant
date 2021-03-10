using System;
using System.Numerics;

namespace X10D.Performant
{
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Creates a new random <see cref="Plane"/> with supplied values.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="ensureOneNextCall">
        ///     If <see langword="true"/> <paramref name="random"/> has <see cref="System.Random.Next()"/> called only one time.
        /// </param>
        /// <param name="xMin">The inclusive lower bound of the X value of <see cref="Plane.Normal"/>.</param>
        /// <param name="xMax">The exclusive upper bound of the X value of <see cref="Plane.Normal"/>.</param>
        /// <param name="yMin">The inclusive lower bound of the Y value of <see cref="Plane.Normal"/>.</param>
        /// <param name="yMax">The exclusive upper bound of the Y value of <see cref="Plane.Normal"/>.</param>
        /// <param name="zMin">The inclusive lower bound of the Z value of <see cref="Plane.Normal"/>.</param>
        /// <param name="zMax">The exclusive upper bound of the Z value of <see cref="Plane.Normal"/>.</param>
        /// <param name="dMin">The inclusive lower bound of <see cref="Plane.D"/>.</param>
        /// <param name="dMax">The exclusive upper bound of <see cref="Plane.D"/>.</param>
        /// <returns>
        ///     A new <see cref="Plane"/> with
        ///     the X value of <see cref="Plane.Normal"/> between <paramref name="xMin"/> and <paramref name="xMax"/>,
        ///     the Y value of <see cref="Plane.Normal"/> between <paramref name="yMin"/> and <paramref name="yMax"/>,
        ///     the Z value of <see cref="Plane.Normal"/> between <paramref name="zMin"/> and <paramref name="zMax"/>, and
        ///     <see cref="Plane.D"/> between <paramref name="dMin"/> and <paramref name="dMax"/>.
        /// </returns>
        public static Plane NextPlane(this Random random,
                                      bool ensureOneNextCall = false,
                                      float xMin = 0,
                                      float xMax = 1,
                                      float yMin = 0,
                                      float yMax = 1,
                                      float zMin = 0,
                                      float zMax = 1,
                                      float dMin = 0,
                                      float dMax = 1)
        {
            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                return new Plane(delegatedRandom.NextSingle(xMin, xMax),
                                 delegatedRandom.NextSingle(yMin, yMax),
                                 delegatedRandom.NextSingle(zMin, zMax),
                                 delegatedRandom.NextSingle(dMin, dMax));
            }

            return new Plane(random.NextSingle(xMin, xMax),
                             random.NextSingle(yMin, yMax),
                             random.NextSingle(zMin, zMax),
                             random.NextSingle(dMin, dMax));
        }

        /// <summary>
        ///     Creates a new random <see cref="Plane"/> with supplied values.
        /// </summary>
        /// <param name="randomX">The <see cref="System.Random"/> instance that determines X for the <see cref="Plane.Normal"/> value.</param>
        /// <param name="randomY">The <see cref="System.Random"/> instance that determines Y for the <see cref="Plane.Normal"/> value.</param>
        /// <param name="randomZ">The <see cref="System.Random"/> instance that determines Z for the <see cref="Plane.Normal"/> value.</param>
        /// <param name="randomD">The <see cref="System.Random"/> instance that determines the <see cref="Plane.D"/> value.</param>
        /// <param name="xMin">The inclusive lower bound of the X value of <see cref="Plane.Normal"/>.</param>
        /// <param name="xMax">The exclusive upper bound of the X value of <see cref="Plane.Normal"/>.</param>
        /// <param name="yMin">The inclusive lower bound of the Y value of <see cref="Plane.Normal"/>.</param>
        /// <param name="yMax">The exclusive upper bound of the Y value of <see cref="Plane.Normal"/>.</param>
        /// <param name="zMin">The inclusive lower bound of the Z value of <see cref="Plane.Normal"/>.</param>
        /// <param name="zMax">The exclusive upper bound of the Z value of <see cref="Plane.Normal"/>.</param>
        /// <param name="dMin">The inclusive lower bound of <see cref="Plane.D"/>.</param>
        /// <param name="dMax">The exclusive upper bound of <see cref="Plane.D"/>.</param>
        /// <returns>
        ///     A new <see cref="Plane"/> with
        ///     the X value of <see cref="Plane.Normal"/> between <paramref name="xMin"/> and <paramref name="xMax"/>,
        ///     the Y value of <see cref="Plane.Normal"/> between <paramref name="yMin"/> and <paramref name="yMax"/>,
        ///     the Z value of <see cref="Plane.Normal"/> between <paramref name="zMin"/> and <paramref name="zMax"/>, and
        ///     <see cref="Plane.D"/> between <paramref name="dMin"/> and <paramref name="dMax"/> with
        ///     the X value of<see cref="Plane.Normal"/> chosen by <paramref name="randomX"/>,
        ///     the Y value of<see cref="Plane.Normal"/> chosen by <paramref name="randomY"/>,
        ///     the Z value of<see cref="Plane.Normal"/> chosen by <paramref name="randomZ"/>, and
        ///     <see cref="Plane.D"/> chosen by <paramref name="randomD"/>.
        /// </returns>
        public static Plane NextPlane(this Random randomX,
                                      Random randomY,
                                      Random randomZ,
                                      Random randomD,
                                      float xMin = 0,
                                      float xMax = 1,
                                      float yMin = 0,
                                      float yMax = 1,
                                      float zMin = 0,
                                      float zMax = 1,
                                      float dMin = 0,
                                      float dMax = 1) =>
            new(randomX.NextSingle(xMin, xMax),
                randomY.NextSingle(yMin, yMax),
                randomZ.NextSingle(zMin, zMax),
                randomD.NextSingle(dMin, dMax));
    }
}