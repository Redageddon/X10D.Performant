// This class is auto generated and will be overridden if any changes are made.
// To make edits to this class edit the X10D.Generator project.

using System;
using System.Runtime.CompilerServices;

namespace X10D.Performant.IEquatableExtensions
{
    public static partial class EquatableExtensions
    {
        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals1"]'/>
        public static bool AndEquals<T>(this T value, params T[] comparisons)
            where T : IEquatable<T> =>
            AdvancedComparison<T, And>(value, comparisons);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals2"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value, T arg1, T arg2)
            where T : IEquatable<T> =>
            value.Equals(arg1) && value.Equals(arg2);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals3"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value, T arg1, T arg2, T arg3)
            where T : IEquatable<T> =>
            value.Equals(arg1) && value.Equals(arg2) && value.Equals(arg3);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals4"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4)
            where T : IEquatable<T> =>
            value.Equals(arg1) && value.Equals(arg2) && value.Equals(arg3) && value.Equals(arg4);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals5"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5)
            where T : IEquatable<T> =>
            value.Equals(arg1) && value.Equals(arg2) && value.Equals(arg3) && value.Equals(arg4) && value.Equals(arg5);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals6"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6)
            where T : IEquatable<T> =>
            value.Equals(arg1) && value.Equals(arg2) && value.Equals(arg3) && value.Equals(arg4) && value.Equals(arg5) && value.Equals(arg6);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals7"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7)
            where T : IEquatable<T> =>
            value.Equals(arg1)
         && value.Equals(arg2)
         && value.Equals(arg3)
         && value.Equals(arg4)
         && value.Equals(arg5)
         && value.Equals(arg6)
         && value.Equals(arg7);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals8"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8)
            where T : IEquatable<T> =>
            value.Equals(arg1)
         && value.Equals(arg2)
         && value.Equals(arg3)
         && value.Equals(arg4)
         && value.Equals(arg5)
         && value.Equals(arg6)
         && value.Equals(arg7)
         && value.Equals(arg8);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals9"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9)
            where T : IEquatable<T> =>
            value.Equals(arg1)
         && value.Equals(arg2)
         && value.Equals(arg3)
         && value.Equals(arg4)
         && value.Equals(arg5)
         && value.Equals(arg6)
         && value.Equals(arg7)
         && value.Equals(arg8)
         && value.Equals(arg9);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals10"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10)
            where T : IEquatable<T> =>
            value.Equals(arg1)
         && value.Equals(arg2)
         && value.Equals(arg3)
         && value.Equals(arg4)
         && value.Equals(arg5)
         && value.Equals(arg6)
         && value.Equals(arg7)
         && value.Equals(arg8)
         && value.Equals(arg9)
         && value.Equals(arg10);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals11"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10, T arg11)
            where T : IEquatable<T> =>
            value.Equals(arg1)
         && value.Equals(arg2)
         && value.Equals(arg3)
         && value.Equals(arg4)
         && value.Equals(arg5)
         && value.Equals(arg6)
         && value.Equals(arg7)
         && value.Equals(arg8)
         && value.Equals(arg9)
         && value.Equals(arg10)
         && value.Equals(arg11);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals12"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value,
                                        T arg1,
                                        T arg2,
                                        T arg3,
                                        T arg4,
                                        T arg5,
                                        T arg6,
                                        T arg7,
                                        T arg8,
                                        T arg9,
                                        T arg10,
                                        T arg11,
                                        T arg12)
            where T : IEquatable<T> =>
            value.Equals(arg1)
         && value.Equals(arg2)
         && value.Equals(arg3)
         && value.Equals(arg4)
         && value.Equals(arg5)
         && value.Equals(arg6)
         && value.Equals(arg7)
         && value.Equals(arg8)
         && value.Equals(arg9)
         && value.Equals(arg10)
         && value.Equals(arg11)
         && value.Equals(arg12);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals13"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value,
                                        T arg1,
                                        T arg2,
                                        T arg3,
                                        T arg4,
                                        T arg5,
                                        T arg6,
                                        T arg7,
                                        T arg8,
                                        T arg9,
                                        T arg10,
                                        T arg11,
                                        T arg12,
                                        T arg13)
            where T : IEquatable<T> =>
            value.Equals(arg1)
         && value.Equals(arg2)
         && value.Equals(arg3)
         && value.Equals(arg4)
         && value.Equals(arg5)
         && value.Equals(arg6)
         && value.Equals(arg7)
         && value.Equals(arg8)
         && value.Equals(arg9)
         && value.Equals(arg10)
         && value.Equals(arg11)
         && value.Equals(arg12)
         && value.Equals(arg13);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals14"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value,
                                        T arg1,
                                        T arg2,
                                        T arg3,
                                        T arg4,
                                        T arg5,
                                        T arg6,
                                        T arg7,
                                        T arg8,
                                        T arg9,
                                        T arg10,
                                        T arg11,
                                        T arg12,
                                        T arg13,
                                        T arg14)
            where T : IEquatable<T> =>
            value.Equals(arg1)
         && value.Equals(arg2)
         && value.Equals(arg3)
         && value.Equals(arg4)
         && value.Equals(arg5)
         && value.Equals(arg6)
         && value.Equals(arg7)
         && value.Equals(arg8)
         && value.Equals(arg9)
         && value.Equals(arg10)
         && value.Equals(arg11)
         && value.Equals(arg12)
         && value.Equals(arg13)
         && value.Equals(arg14);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="AndEquals15"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AndEquals<T>(this T value,
                                        T arg1,
                                        T arg2,
                                        T arg3,
                                        T arg4,
                                        T arg5,
                                        T arg6,
                                        T arg7,
                                        T arg8,
                                        T arg9,
                                        T arg10,
                                        T arg11,
                                        T arg12,
                                        T arg13,
                                        T arg14,
                                        T arg15)
            where T : IEquatable<T> =>
            value.Equals(arg1)
         && value.Equals(arg2)
         && value.Equals(arg3)
         && value.Equals(arg4)
         && value.Equals(arg5)
         && value.Equals(arg6)
         && value.Equals(arg7)
         && value.Equals(arg8)
         && value.Equals(arg9)
         && value.Equals(arg10)
         && value.Equals(arg11)
         && value.Equals(arg12)
         && value.Equals(arg13)
         && value.Equals(arg14)
         && value.Equals(arg15);
    }
}