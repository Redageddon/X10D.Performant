// This class is auto generated and will be overridden if any changes are made.
// To make edits to this class edit the X10D.Generator project.

using System;
using System.Runtime.CompilerServices;

namespace X10D.Performant.IEquatableExtensions
{
    public static partial class EquatableExtensions
    {
        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals1"]'/>
        public static bool NOrEquals<T>(this T value, params T[] comparisons)
            where T : IEquatable<T> =>
            AdvancedComparison<T, NOr>(value, comparisons);

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals2"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2)
            where T : IEquatable<T> =>
            !(value.Equals(arg1) || value.Equals(arg2));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals3"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2) || value.Equals(arg3));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals4"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2, arg3) || value.Equals(arg4));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals5"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2, arg3, arg4) || value.Equals(arg5));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals6"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2, arg3, arg4, arg5) || value.Equals(arg6));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals7"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2, arg3, arg4, arg5, arg6) || value.Equals(arg7));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals8"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7) || value.Equals(arg8));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals9"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) || value.Equals(arg9));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals10"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) || value.Equals(arg10));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals11"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10, T arg11)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) || value.Equals(arg11));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals12"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10, T arg11, T arg12)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) || value.Equals(arg12));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals13"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10, T arg11, T arg12, T arg13)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) || value.Equals(arg13));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals14"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10, T arg11, T arg12, T arg13, T arg14)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) || value.Equals(arg14));

        /// <include file='EquatableExtensions.xml' path='members/member[@name="NOrEquals15"]'/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10, T arg11, T arg12, T arg13, T arg14, T arg15)
            where T : IEquatable<T> =>
            !(value.NOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) || value.Equals(arg15));
    }
}