using System;
using System.Numerics;

namespace X10D.Performant
{
    public static partial class RandomExtensions
    {
        /// <summary>
        ///     Returns a new random <see cref="Matrix3x2"/>.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="ensureOneNextCall">If <see langword="true"/> <paramref name="random"/> only has <see cref="System.Random.Next()"/> called once.</param>
        /// <param name="m11Min">The inclusive lower bound of <see cref="Matrix3x2.M11"/>.</param>
        /// <param name="m11Max">The exclusive upper bound of <see cref="Matrix3x2.M11"/>.</param>
        /// <param name="m12Min">The inclusive lower bound of <see cref="Matrix3x2.M12"/>.</param>
        /// <param name="m12Max">The exclusive upper bound of <see cref="Matrix3x2.M12"/>.</param>
        /// <param name="m21Min">The inclusive lower bound of <see cref="Matrix3x2.M21"/>.</param>
        /// <param name="m21Max">The exclusive upper bound of <see cref="Matrix3x2.M21"/>.</param>
        /// <param name="m22Min">The inclusive lower bound of <see cref="Matrix3x2.M22"/>.</param>
        /// <param name="m22Max">The exclusive upper bound of <see cref="Matrix3x2.M22"/>.</param>
        /// <param name="m31Min">The inclusive lower bound of <see cref="Matrix3x2.M31"/>.</param>
        /// <param name="m31Max">The exclusive upper bound of <see cref="Matrix3x2.M31"/>.</param>
        /// <param name="m32Min">The inclusive lower bound of <see cref="Matrix3x2.M32"/>.</param>
        /// <param name="m32Max">The exclusive upper bound of <see cref="Matrix3x2.M32"/>.</param>
        /// <returns>
        ///     A new random <see cref="Matrix3x2"/> with
        ///     <see cref="Matrix3x2.M11"/> between <paramref name="m11Min"/> and <paramref name="m11Min"/>,
        ///     <see cref="Matrix3x2.M12"/> between <paramref name="m12Min"/> and <paramref name="m12Min"/>,
        ///     <see cref="Matrix3x2.M21"/> between <paramref name="m21Min"/> and <paramref name="m21Min"/>,
        ///     <see cref="Matrix3x2.M22"/> between <paramref name="m22Min"/> and <paramref name="m22Min"/>,
        ///     <see cref="Matrix3x2.M31"/> between <paramref name="m31Min"/> and <paramref name="m31Min"/>, and
        ///     <see cref="Matrix3x2.M32"/> between <paramref name="m32Min"/> and <paramref name="m32Min"/>.
        /// </returns>
        public static Matrix3x2 NextMatrix3X2(this Random random,
                                              bool ensureOneNextCall = false,
                                              float m11Min = 0,
                                              float m11Max = 1,
                                              float m12Min = 0,
                                              float m12Max = 1,
                                              float m21Min = 0,
                                              float m21Max = 1,
                                              float m22Min = 0,
                                              float m22Max = 1,
                                              float m31Min = 0,
                                              float m31Max = 1,
                                              float m32Min = 0,
                                              float m32Max = 1)
        {
            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                return new Matrix3x2(delegatedRandom.NextSingle(m11Min, m11Max),
                                     delegatedRandom.NextSingle(m12Min, m12Max),
                                     delegatedRandom.NextSingle(m21Min, m21Max),
                                     delegatedRandom.NextSingle(m22Min, m22Max),
                                     delegatedRandom.NextSingle(m31Min, m31Max),
                                     delegatedRandom.NextSingle(m32Min, m32Max));
            }

            return new Matrix3x2(random.NextSingle(m11Min, m11Max),
                                 random.NextSingle(m12Min, m12Max),
                                 random.NextSingle(m21Min, m21Max),
                                 random.NextSingle(m22Min, m22Max),
                                 random.NextSingle(m31Min, m31Max),
                                 random.NextSingle(m32Min, m32Max));
        }

        /// <summary>
        ///     Returns a new random <see cref="Matrix3x2"/>.
        /// </summary>
        /// <param name="randomM11">The <see cref="System.Random"/> instance that determines the <see cref="Matrix3x2.M11"/> value.</param>
        /// <param name="randomM12">The <see cref="System.Random"/> instance that determines the <see cref="Matrix3x2.M12"/> value.</param>
        /// <param name="randomM21">The <see cref="System.Random"/> instance that determines the <see cref="Matrix3x2.M21"/> value.</param>
        /// <param name="randomM22">The <see cref="System.Random"/> instance that determines the <see cref="Matrix3x2.M22"/> value.</param>
        /// <param name="randomM31">The <see cref="System.Random"/> instance that determines the <see cref="Matrix3x2.M31"/> value.</param>
        /// <param name="randomM32">The <see cref="System.Random"/> instance that determines the <see cref="Matrix3x2.M32"/> value.</param>
        /// <param name="m11Min">The inclusive lower bound of <see cref="Matrix3x2.M11"/>.</param>
        /// <param name="m11Max">The exclusive upper bound of <see cref="Matrix3x2.M11"/>.</param>
        /// <param name="m12Min">The inclusive lower bound of <see cref="Matrix3x2.M12"/>.</param>
        /// <param name="m12Max">The exclusive upper bound of <see cref="Matrix3x2.M12"/>.</param>
        /// <param name="m21Min">The inclusive lower bound of <see cref="Matrix3x2.M21"/>.</param>
        /// <param name="m21Max">The exclusive upper bound of <see cref="Matrix3x2.M21"/>.</param>
        /// <param name="m22Min">The inclusive lower bound of <see cref="Matrix3x2.M22"/>.</param>
        /// <param name="m22Max">The exclusive upper bound of <see cref="Matrix3x2.M22"/>.</param>
        /// <param name="m31Min">The inclusive lower bound of <see cref="Matrix3x2.M31"/>.</param>
        /// <param name="m31Max">The exclusive upper bound of <see cref="Matrix3x2.M31"/>.</param>
        /// <param name="m32Min">The inclusive lower bound of <see cref="Matrix3x2.M32"/>.</param>
        /// <param name="m32Max">The exclusive upper bound of <see cref="Matrix3x2.M32"/>.</param>
        /// <returns>
        ///     A new random <see cref="Matrix3x2"/> with
        ///     <see cref="Matrix3x2.M11"/> between <paramref name="m11Min"/> and <paramref name="m11Min"/>,
        ///     <see cref="Matrix3x2.M12"/> between <paramref name="m12Min"/> and <paramref name="m12Min"/>,
        ///     <see cref="Matrix3x2.M21"/> between <paramref name="m21Min"/> and <paramref name="m21Min"/>,
        ///     <see cref="Matrix3x2.M22"/> between <paramref name="m22Min"/> and <paramref name="m22Min"/>,
        ///     <see cref="Matrix3x2.M31"/> between <paramref name="m31Min"/> and <paramref name="m31Min"/>, and
        ///     <see cref="Matrix3x2.M32"/> between <paramref name="m32Min"/> and <paramref name="m32Min"/> with
        ///     <see cref="Matrix3x2.M11"/> chosen by <paramref name="randomM11"/>,
        ///     <see cref="Matrix3x2.M12"/> chosen by <paramref name="randomM12"/>,
        ///     <see cref="Matrix3x2.M21"/> chosen by <paramref name="randomM21"/>,
        ///     <see cref="Matrix3x2.M22"/> chosen by <paramref name="randomM22"/>,
        ///     <see cref="Matrix3x2.M31"/> chosen by <paramref name="randomM31"/>, and
        ///     <see cref="Matrix3x2.M32"/> chosen by <paramref name="randomM32"/>.
        /// </returns>
        public static Matrix3x2 NextMatrix3X2(this Random randomM11,
                                              Random randomM12,
                                              Random randomM21,
                                              Random randomM22,
                                              Random randomM31,
                                              Random randomM32,
                                              float m11Min = 0,
                                              float m11Max = 1,
                                              float m12Min = 0,
                                              float m12Max = 1,
                                              float m21Min = 0,
                                              float m21Max = 1,
                                              float m22Min = 0,
                                              float m22Max = 1,
                                              float m31Min = 0,
                                              float m31Max = 1,
                                              float m32Min = 0,
                                              float m32Max = 1) =>
            new(randomM11.NextSingle(m11Min, m11Max),
                randomM12.NextSingle(m12Min, m12Max),
                randomM21.NextSingle(m21Min, m21Max),
                randomM22.NextSingle(m22Min, m22Max),
                randomM31.NextSingle(m31Min, m31Max),
                randomM32.NextSingle(m32Min, m32Max));

        /// <summary>
        ///     Returns a new random <see cref="Matrix4x4"/>.
        /// </summary>
        /// <param name="random">The <see cref="System.Random"/> instance.</param>
        /// <param name="ensureOneNextCall">If <see langword="true"/> <paramref name="random"/> only has <see cref="System.Random.Next()"/> called once.</param>
        /// <param name="m11Min">The inclusive lower bound of <see cref="Matrix4x4.M11"/>.</param>
        /// <param name="m11Max">The exclusive upper bound of <see cref="Matrix4x4.M11"/>.</param>
        /// <param name="m12Min">The inclusive lower bound of <see cref="Matrix4x4.M12"/>.</param>
        /// <param name="m12Max">The exclusive upper bound of <see cref="Matrix4x4.M12"/>.</param>
        /// <param name="m13Min">The inclusive lower bound of <see cref="Matrix4x4.M13"/>.</param>
        /// <param name="m13Max">The exclusive upper bound of <see cref="Matrix4x4.M13"/>.</param>
        /// <param name="m14Min">The inclusive lower bound of <see cref="Matrix4x4.M14"/>.</param>
        /// <param name="m14Max">The exclusive upper bound of <see cref="Matrix4x4.M14"/>.</param>
        /// <param name="m21Min">The inclusive lower bound of <see cref="Matrix4x4.M21"/>.</param>
        /// <param name="m21Max">The exclusive upper bound of <see cref="Matrix4x4.M21"/>.</param>
        /// <param name="m22Min">The inclusive lower bound of <see cref="Matrix4x4.M22"/>.</param>
        /// <param name="m22Max">The exclusive upper bound of <see cref="Matrix4x4.M22"/>.</param>
        /// <param name="m23Min">The inclusive lower bound of <see cref="Matrix4x4.M23"/>.</param>
        /// <param name="m23Max">The exclusive upper bound of <see cref="Matrix4x4.M23"/>.</param>
        /// <param name="m24Min">The inclusive lower bound of <see cref="Matrix4x4.M24"/>.</param>
        /// <param name="m24Max">The exclusive upper bound of <see cref="Matrix4x4.M24"/>.</param>
        /// <param name="m31Min">The inclusive lower bound of <see cref="Matrix4x4.M31"/>.</param>
        /// <param name="m31Max">The exclusive upper bound of <see cref="Matrix4x4.M31"/>.</param>
        /// <param name="m32Min">The inclusive lower bound of <see cref="Matrix4x4.M32"/>.</param>
        /// <param name="m32Max">The exclusive upper bound of <see cref="Matrix4x4.M32"/>.</param>
        /// <param name="m33Min">The inclusive lower bound of <see cref="Matrix4x4.M33"/>.</param>
        /// <param name="m33Max">The exclusive upper bound of <see cref="Matrix4x4.M33"/>.</param>
        /// <param name="m34Min">The inclusive lower bound of <see cref="Matrix4x4.M34"/>.</param>
        /// <param name="m34Max">The exclusive upper bound of <see cref="Matrix4x4.M34"/>.</param>
        /// <param name="m41Min">The inclusive lower bound of <see cref="Matrix4x4.M41"/>.</param>
        /// <param name="m41Max">The exclusive upper bound of <see cref="Matrix4x4.M41"/>.</param>
        /// <param name="m42Min">The inclusive lower bound of <see cref="Matrix4x4.M42"/>.</param>
        /// <param name="m42Max">The exclusive upper bound of <see cref="Matrix4x4.M42"/>.</param>
        /// <param name="m43Min">The inclusive lower bound of <see cref="Matrix4x4.M43"/>.</param>
        /// <param name="m43Max">The exclusive upper bound of <see cref="Matrix4x4.M43"/>.</param>
        /// <param name="m44Min">The inclusive lower bound of <see cref="Matrix4x4.M44"/>.</param>
        /// <param name="m44Max">The exclusive upper bound of <see cref="Matrix4x4.M44"/>.</param>
        /// <returns>
        ///     A new random <see cref="Matrix3x2"/> with
        ///     <see cref="Matrix4x4.M11"/> between <paramref name="m11Min"/> and <paramref name="m11Min"/>,
        ///     <see cref="Matrix4x4.M12"/> between <paramref name="m12Min"/> and <paramref name="m12Min"/>,
        ///     <see cref="Matrix4x4.M13"/> between <paramref name="m13Min"/> and <paramref name="m13Min"/>,
        ///     <see cref="Matrix4x4.M14"/> between <paramref name="m14Min"/> and <paramref name="m14Min"/>,
        ///     <see cref="Matrix4x4.M21"/> between <paramref name="m21Min"/> and <paramref name="m21Min"/>,
        ///     <see cref="Matrix4x4.M22"/> between <paramref name="m22Min"/> and <paramref name="m22Min"/>,
        ///     <see cref="Matrix4x4.M23"/> between <paramref name="m23Min"/> and <paramref name="m23Min"/>,
        ///     <see cref="Matrix4x4.M24"/> between <paramref name="m24Min"/> and <paramref name="m24Min"/>,
        ///     <see cref="Matrix4x4.M31"/> between <paramref name="m31Min"/> and <paramref name="m31Min"/>,
        ///     <see cref="Matrix4x4.M32"/> between <paramref name="m32Min"/> and <paramref name="m32Min"/>,
        ///     <see cref="Matrix4x4.M33"/> between <paramref name="m33Min"/> and <paramref name="m33Min"/>,
        ///     <see cref="Matrix4x4.M34"/> between <paramref name="m34Min"/> and <paramref name="m34Min"/>,
        ///     <see cref="Matrix4x4.M41"/> between <paramref name="m41Min"/> and <paramref name="m41Min"/>,
        ///     <see cref="Matrix4x4.M42"/> between <paramref name="m42Min"/> and <paramref name="m42Min"/>,
        ///     <see cref="Matrix4x4.M43"/> between <paramref name="m43Min"/> and <paramref name="m43Min"/>, and
        ///     <see cref="Matrix4x4.M44"/> between <paramref name="m44Min"/> and <paramref name="m44Min"/>.
        /// </returns>
        public static Matrix4x4 NextMatrix4X4(this Random random,
                                              bool ensureOneNextCall = false,
                                              float m11Min = 0,
                                              float m11Max = 1,
                                              float m12Min = 0,
                                              float m12Max = 1,
                                              float m13Min = 0,
                                              float m13Max = 1,
                                              float m14Min = 0,
                                              float m14Max = 1,
                                              float m21Min = 0,
                                              float m21Max = 1,
                                              float m22Min = 0,
                                              float m22Max = 1,
                                              float m23Min = 0,
                                              float m23Max = 1,
                                              float m24Min = 0,
                                              float m24Max = 1,
                                              float m31Min = 0,
                                              float m31Max = 1,
                                              float m32Min = 0,
                                              float m32Max = 1,
                                              float m33Min = 0,
                                              float m33Max = 1,
                                              float m34Min = 0,
                                              float m34Max = 1,
                                              float m41Min = 0,
                                              float m41Max = 1,
                                              float m42Min = 0,
                                              float m42Max = 1,
                                              float m43Min = 0,
                                              float m43Max = 1,
                                              float m44Min = 0,
                                              float m44Max = 1)
        {
            if (ensureOneNextCall)
            {
                Random delegatedRandom = new(random.Next());

                return new Matrix4x4(delegatedRandom.NextSingle(m11Min, m11Max),
                                     delegatedRandom.NextSingle(m12Min, m12Max),
                                     delegatedRandom.NextSingle(m13Min, m13Max),
                                     delegatedRandom.NextSingle(m14Min, m14Max),
                                     delegatedRandom.NextSingle(m21Min, m21Max),
                                     delegatedRandom.NextSingle(m22Min, m22Max),
                                     delegatedRandom.NextSingle(m23Min, m23Max),
                                     delegatedRandom.NextSingle(m24Min, m24Max),
                                     delegatedRandom.NextSingle(m31Min, m31Max),
                                     delegatedRandom.NextSingle(m32Min, m32Max),
                                     delegatedRandom.NextSingle(m33Min, m33Max),
                                     delegatedRandom.NextSingle(m34Min, m34Max),
                                     delegatedRandom.NextSingle(m41Min, m41Max),
                                     delegatedRandom.NextSingle(m42Min, m42Max),
                                     delegatedRandom.NextSingle(m43Min, m43Max),
                                     delegatedRandom.NextSingle(m44Min, m44Max));
            }

            return new Matrix4x4(random.NextSingle(m11Min, m11Max),
                                 random.NextSingle(m12Min, m12Max),
                                 random.NextSingle(m13Min, m13Max),
                                 random.NextSingle(m14Min, m14Max),
                                 random.NextSingle(m21Min, m21Max),
                                 random.NextSingle(m22Min, m22Max),
                                 random.NextSingle(m23Min, m23Max),
                                 random.NextSingle(m24Min, m24Max),
                                 random.NextSingle(m31Min, m31Max),
                                 random.NextSingle(m32Min, m32Max),
                                 random.NextSingle(m33Min, m33Max),
                                 random.NextSingle(m34Min, m34Max),
                                 random.NextSingle(m41Min, m41Max),
                                 random.NextSingle(m42Min, m42Max),
                                 random.NextSingle(m43Min, m43Max),
                                 random.NextSingle(m44Min, m44Max));
        }

        /// <summary>
        ///     Returns a new random <see cref="Matrix4x4"/>.
        /// </summary>
        /// <param name="randomM11">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M11"/> value.</param>
        /// <param name="randomM12">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M12"/> value.</param>
        /// <param name="randomM13">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M13"/> value.</param>
        /// <param name="randomM14">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M14"/> value.</param>
        /// <param name="randomM21">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M21"/> value.</param>
        /// <param name="randomM22">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M22"/> value.</param>
        /// <param name="randomM23">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M23"/> value.</param>
        /// <param name="randomM24">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M24"/> value.</param>
        /// <param name="randomM31">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M31"/> value.</param>
        /// <param name="randomM32">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M32"/> value.</param>
        /// <param name="randomM33">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M33"/> value.</param>
        /// <param name="randomM34">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M34"/> value.</param>
        /// <param name="randomM41">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M41"/> value.</param>
        /// <param name="randomM42">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M42"/> value.</param>
        /// <param name="randomM43">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M43"/> value.</param>
        /// <param name="randomM44">The <see cref="System.Random"/> instance that determines the <see cref="Matrix4x4.M44"/> value.</param>
        /// <param name="m11Min">The inclusive lower bound of <see cref="Matrix4x4.M11"/>.</param>
        /// <param name="m11Max">The exclusive upper bound of <see cref="Matrix4x4.M11"/>.</param>
        /// <param name="m12Min">The inclusive lower bound of <see cref="Matrix4x4.M12"/>.</param>
        /// <param name="m12Max">The exclusive upper bound of <see cref="Matrix4x4.M12"/>.</param>
        /// <param name="m13Min">The inclusive lower bound of <see cref="Matrix4x4.M13"/>.</param>
        /// <param name="m13Max">The exclusive upper bound of <see cref="Matrix4x4.M13"/>.</param>
        /// <param name="m14Min">The inclusive lower bound of <see cref="Matrix4x4.M14"/>.</param>
        /// <param name="m14Max">The exclusive upper bound of <see cref="Matrix4x4.M14"/>.</param>
        /// <param name="m21Min">The inclusive lower bound of <see cref="Matrix4x4.M21"/>.</param>
        /// <param name="m21Max">The exclusive upper bound of <see cref="Matrix4x4.M21"/>.</param>
        /// <param name="m22Min">The inclusive lower bound of <see cref="Matrix4x4.M22"/>.</param>
        /// <param name="m22Max">The exclusive upper bound of <see cref="Matrix4x4.M22"/>.</param>
        /// <param name="m23Min">The inclusive lower bound of <see cref="Matrix4x4.M23"/>.</param>
        /// <param name="m23Max">The exclusive upper bound of <see cref="Matrix4x4.M23"/>.</param>
        /// <param name="m24Min">The inclusive lower bound of <see cref="Matrix4x4.M24"/>.</param>
        /// <param name="m24Max">The exclusive upper bound of <see cref="Matrix4x4.M24"/>.</param>
        /// <param name="m31Min">The inclusive lower bound of <see cref="Matrix4x4.M31"/>.</param>
        /// <param name="m31Max">The exclusive upper bound of <see cref="Matrix4x4.M31"/>.</param>
        /// <param name="m32Min">The inclusive lower bound of <see cref="Matrix4x4.M32"/>.</param>
        /// <param name="m32Max">The exclusive upper bound of <see cref="Matrix4x4.M32"/>.</param>
        /// <param name="m33Min">The inclusive lower bound of <see cref="Matrix4x4.M33"/>.</param>
        /// <param name="m33Max">The exclusive upper bound of <see cref="Matrix4x4.M33"/>.</param>
        /// <param name="m34Min">The inclusive lower bound of <see cref="Matrix4x4.M34"/>.</param>
        /// <param name="m34Max">The exclusive upper bound of <see cref="Matrix4x4.M34"/>.</param>
        /// <param name="m41Min">The inclusive lower bound of <see cref="Matrix4x4.M41"/>.</param>
        /// <param name="m41Max">The exclusive upper bound of <see cref="Matrix4x4.M41"/>.</param>
        /// <param name="m42Min">The inclusive lower bound of <see cref="Matrix4x4.M42"/>.</param>
        /// <param name="m42Max">The exclusive upper bound of <see cref="Matrix4x4.M42"/>.</param>
        /// <param name="m43Min">The inclusive lower bound of <see cref="Matrix4x4.M43"/>.</param>
        /// <param name="m43Max">The exclusive upper bound of <see cref="Matrix4x4.M43"/>.</param>
        /// <param name="m44Min">The inclusive lower bound of <see cref="Matrix4x4.M44"/>.</param>
        /// <param name="m44Max">The exclusive upper bound of <see cref="Matrix4x4.M44"/>.</param>
        /// <returns>
        ///     A new random <see cref="Matrix3x2"/> with
        ///     <see cref="Matrix4x4.M11"/> between <paramref name="m11Min"/> and <paramref name="m11Min"/>,
        ///     <see cref="Matrix4x4.M12"/> between <paramref name="m12Min"/> and <paramref name="m12Min"/>,
        ///     <see cref="Matrix4x4.M13"/> between <paramref name="m13Min"/> and <paramref name="m13Min"/>,
        ///     <see cref="Matrix4x4.M14"/> between <paramref name="m14Min"/> and <paramref name="m14Min"/>,
        ///     <see cref="Matrix4x4.M21"/> between <paramref name="m21Min"/> and <paramref name="m21Min"/>,
        ///     <see cref="Matrix4x4.M22"/> between <paramref name="m22Min"/> and <paramref name="m22Min"/>,
        ///     <see cref="Matrix4x4.M23"/> between <paramref name="m23Min"/> and <paramref name="m23Min"/>,
        ///     <see cref="Matrix4x4.M24"/> between <paramref name="m24Min"/> and <paramref name="m24Min"/>,
        ///     <see cref="Matrix4x4.M31"/> between <paramref name="m31Min"/> and <paramref name="m31Min"/>,
        ///     <see cref="Matrix4x4.M32"/> between <paramref name="m32Min"/> and <paramref name="m32Min"/>,
        ///     <see cref="Matrix4x4.M33"/> between <paramref name="m33Min"/> and <paramref name="m33Min"/>,
        ///     <see cref="Matrix4x4.M34"/> between <paramref name="m34Min"/> and <paramref name="m34Min"/>,
        ///     <see cref="Matrix4x4.M41"/> between <paramref name="m41Min"/> and <paramref name="m41Min"/>,
        ///     <see cref="Matrix4x4.M42"/> between <paramref name="m42Min"/> and <paramref name="m42Min"/>,
        ///     <see cref="Matrix4x4.M43"/> between <paramref name="m43Min"/> and <paramref name="m43Min"/>, and
        ///     <see cref="Matrix4x4.M44"/> between <paramref name="m44Min"/> and <paramref name="m44Min"/> with
        ///     <see cref="Matrix4x4.M11"/> chosen by <paramref name="randomM11"/>,
        ///     <see cref="Matrix4x4.M12"/> chosen by <paramref name="randomM12"/>,
        ///     <see cref="Matrix4x4.M13"/> chosen by <paramref name="randomM13"/>,
        ///     <see cref="Matrix4x4.M14"/> chosen by <paramref name="randomM14"/>,
        ///     <see cref="Matrix4x4.M21"/> chosen by <paramref name="randomM21"/>,
        ///     <see cref="Matrix4x4.M22"/> chosen by <paramref name="randomM22"/>,
        ///     <see cref="Matrix4x4.M23"/> chosen by <paramref name="randomM23"/>,
        ///     <see cref="Matrix4x4.M24"/> chosen by <paramref name="randomM24"/>,
        ///     <see cref="Matrix4x4.M31"/> chosen by <paramref name="randomM31"/>,
        ///     <see cref="Matrix4x4.M32"/> chosen by <paramref name="randomM32"/>,
        ///     <see cref="Matrix4x4.M33"/> chosen by <paramref name="randomM33"/>,
        ///     <see cref="Matrix4x4.M34"/> chosen by <paramref name="randomM34"/>,
        ///     <see cref="Matrix4x4.M41"/> chosen by <paramref name="randomM41"/>,
        ///     <see cref="Matrix4x4.M42"/> chosen by <paramref name="randomM42"/>,
        ///     <see cref="Matrix4x4.M43"/> chosen by <paramref name="randomM43"/> and
        ///     <see cref="Matrix4x4.M44"/> chosen by <paramref name="randomM44"/>.
        /// </returns>
        public static Matrix4x4 NextMatrix4X4(this Random randomM11,
                                              Random randomM12,
                                              Random randomM13,
                                              Random randomM14,
                                              Random randomM21,
                                              Random randomM22,
                                              Random randomM23,
                                              Random randomM24,
                                              Random randomM31,
                                              Random randomM32,
                                              Random randomM33,
                                              Random randomM34,
                                              Random randomM41,
                                              Random randomM42,
                                              Random randomM43,
                                              Random randomM44,
                                              float m11Min = 0,
                                              float m11Max = 1,
                                              float m12Min = 0,
                                              float m12Max = 1,
                                              float m13Min = 0,
                                              float m13Max = 1,
                                              float m14Min = 0,
                                              float m14Max = 1,
                                              float m21Min = 0,
                                              float m21Max = 1,
                                              float m22Min = 0,
                                              float m22Max = 1,
                                              float m23Min = 0,
                                              float m23Max = 1,
                                              float m24Min = 0,
                                              float m24Max = 1,
                                              float m31Min = 0,
                                              float m31Max = 1,
                                              float m32Min = 0,
                                              float m32Max = 1,
                                              float m33Min = 0,
                                              float m33Max = 1,
                                              float m34Min = 0,
                                              float m34Max = 1,
                                              float m41Min = 0,
                                              float m41Max = 1,
                                              float m42Min = 0,
                                              float m42Max = 1,
                                              float m43Min = 0,
                                              float m43Max = 1,
                                              float m44Min = 0,
                                              float m44Max = 1) =>
            new(randomM11.NextSingle(m11Min, m11Max),
                randomM12.NextSingle(m12Min, m12Max),
                randomM13.NextSingle(m13Min, m13Max),
                randomM14.NextSingle(m14Min, m14Max),
                randomM21.NextSingle(m21Min, m21Max),
                randomM22.NextSingle(m22Min, m22Max),
                randomM23.NextSingle(m23Min, m23Max),
                randomM24.NextSingle(m24Min, m24Max),
                randomM31.NextSingle(m31Min, m31Max),
                randomM32.NextSingle(m32Min, m32Max),
                randomM33.NextSingle(m33Min, m33Max),
                randomM34.NextSingle(m34Min, m34Max),
                randomM41.NextSingle(m41Min, m41Max),
                randomM42.NextSingle(m42Min, m42Max),
                randomM43.NextSingle(m43Min, m43Max),
                randomM44.NextSingle(m44Min, m44Max));
    }
}