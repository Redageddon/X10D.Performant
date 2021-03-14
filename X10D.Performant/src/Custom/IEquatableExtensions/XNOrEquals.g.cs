// This class is auto generated and will be overridden if any changes are made.
// To make edits to this class edit the X10D.Generator project.

using System;
using System.Runtime.CompilerServices;

namespace X10D.Performant.IEquatableExtensions
{
    public static partial class EquatableExtensions
    {
        /// <include file='EquatableExtensions.xml' path='members/member[@name="XNOrEquals"]'/>
        public static bool XNOrEquals<T>(this T value, params T[] comparisons)
            where T : IEquatable<T> =>
            AdvancedComparison<T, XNOr>(value, comparisons);

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2)
            where T : IEquatable<T> =>
            !(value.Equals(arg1) ^ value.Equals(arg2));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2) ^ value.Equals(arg3));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2, arg3) ^ value.Equals(arg4));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2, arg3, arg4) ^ value.Equals(arg5));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2, arg3, arg4, arg5) ^ value.Equals(arg6));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2, arg3, arg4, arg5, arg6) ^ value.Equals(arg7));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7) ^ value.Equals(arg8));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) ^ value.Equals(arg9));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) ^ value.Equals(arg10));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10, T arg11)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) ^ value.Equals(arg11));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10, T arg11, T arg12)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) ^ value.Equals(arg12));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10, T arg11, T arg12, T arg13)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) ^ value.Equals(arg13));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10, T arg11, T arg12, T arg13, T arg14)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) ^ value.Equals(arg14));

        /// <inheritdoc cref="XNOrEquals{T}(T,T[])"/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool XNOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10, T arg11, T arg12, T arg13, T arg14, T arg15)
            where T : IEquatable<T> =>
            !(value.XNOrEquals(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) ^ value.Equals(arg15));
    }
}