﻿using System;
using System.Numerics;

namespace X10D.Performant.RandomExtensions
{
    public static partial class RandomExtensions
    {
        /// <include file='../RandomExtensions.xml' path='members/member[@name="NextMatrix3X2"]'/>
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

        /// <include file='../RandomExtensions.xml' path='members/member[@name="NextMatrix3X2Ranom"]'/>
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

        /// <include file='../RandomExtensions.xml' path='members/member[@name="NextMatrix4X4"]'/>
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

        /// <include file='../RandomExtensions.xml' path='members/member[@name="NextMatrix4X4Random"]'/>
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