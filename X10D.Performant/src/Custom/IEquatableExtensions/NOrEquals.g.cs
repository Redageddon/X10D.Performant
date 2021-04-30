// This class is auto generated and will be overridden if any changes are made.
// To make edits to this class edit the X10D.Generator project.

using System;

namespace X10D.Performant.IEquatableExtensions
{
    public static partial class EquatableExtensions
    {
        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals1"]'/>
        public static bool NOrEquals<T>(this T value, params T[] comparisons)
            where T : IEquatable<T> =>
            AdvancedComparison<T, NOr>(value, comparisons);

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals2"]'/>
        public static bool NOrEquals<T>(this T value, T arg1, T arg2)
            where T : IEquatable<T> =>
            !(value.Equals(arg1) || value.Equals(arg2));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals3"]'/>
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3)
            where T : IEquatable<T> =>
            !(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals4"]'/>
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4)
            where T : IEquatable<T> =>
            !(!(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3)) || value.Equals(arg4));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals5"]'/>
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5)
            where T : IEquatable<T> =>
            !(!(!(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3)) || value.Equals(arg4)) || value.Equals(arg5));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals6"]'/>
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6)
            where T : IEquatable<T> =>
            !(!(!(!(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3)) || value.Equals(arg4)) || value.Equals(arg5))
           || value.Equals(arg6));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals7"]'/>
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7)
            where T : IEquatable<T> =>
            !(!(!(!(!(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3)) || value.Equals(arg4)) || value.Equals(arg5))
             || value.Equals(arg6))
           || value.Equals(arg7));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals8"]'/>
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8)
            where T : IEquatable<T> =>
            !(!(!(!(!(!(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3)) || value.Equals(arg4)) || value.Equals(arg5))
               || value.Equals(arg6))
             || value.Equals(arg7))
           || value.Equals(arg8));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals9"]'/>
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9)
            where T : IEquatable<T> =>
            !(!(!(!(!(!(!(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3)) || value.Equals(arg4)) || value.Equals(arg5))
                 || value.Equals(arg6))
               || value.Equals(arg7))
             || value.Equals(arg8))
           || value.Equals(arg9));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals10"]'/>
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10)
            where T : IEquatable<T> =>
            !(!(!(!(!(!(!(!(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3)) || value.Equals(arg4)) || value.Equals(arg5))
                   || value.Equals(arg6))
                 || value.Equals(arg7))
               || value.Equals(arg8))
             || value.Equals(arg9))
           || value.Equals(arg10));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals11"]'/>
        public static bool NOrEquals<T>(this T value, T arg1, T arg2, T arg3, T arg4, T arg5, T arg6, T arg7, T arg8, T arg9, T arg10, T arg11)
            where T : IEquatable<T> =>
            !(!(!(!(!(!(!(!(!(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3)) || value.Equals(arg4)) || value.Equals(arg5))
                     || value.Equals(arg6))
                   || value.Equals(arg7))
                 || value.Equals(arg8))
               || value.Equals(arg9))
             || value.Equals(arg10))
           || value.Equals(arg11));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals12"]'/>
        public static bool NOrEquals<T>(this T value,
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
            !(!(!(!(!(!(!(!(!(!(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3)) || value.Equals(arg4)) || value.Equals(arg5))
                       || value.Equals(arg6))
                     || value.Equals(arg7))
                   || value.Equals(arg8))
                 || value.Equals(arg9))
               || value.Equals(arg10))
             || value.Equals(arg11))
           || value.Equals(arg12));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals13"]'/>
        public static bool NOrEquals<T>(this T value,
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
            !(!(!(!(!(!(!(!(!(!(!(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3)) || value.Equals(arg4)) || value.Equals(arg5))
                         || value.Equals(arg6))
                       || value.Equals(arg7))
                     || value.Equals(arg8))
                   || value.Equals(arg9))
                 || value.Equals(arg10))
               || value.Equals(arg11))
             || value.Equals(arg12))
           || value.Equals(arg13));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals14"]'/>
        public static bool NOrEquals<T>(this T value,
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
            !(!(!(!(!(!(!(!(!(!(!(!(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3)) || value.Equals(arg4)) || value.Equals(arg5))
                           || value.Equals(arg6))
                         || value.Equals(arg7))
                       || value.Equals(arg8))
                     || value.Equals(arg9))
                   || value.Equals(arg10))
                 || value.Equals(arg11))
               || value.Equals(arg12))
             || value.Equals(arg13))
           || value.Equals(arg14));

        /// <include file='EquatableExtensions.g.xml' path='members/member[@name="NOrEquals15"]'/>
        public static bool NOrEquals<T>(this T value,
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
            !(!(!(!(!(!(!(!(!(!(!(!(!(!(value.Equals(arg1) || value.Equals(arg2)) || value.Equals(arg3)) || value.Equals(arg4)) || value.Equals(arg5))
                             || value.Equals(arg6))
                           || value.Equals(arg7))
                         || value.Equals(arg8))
                       || value.Equals(arg9))
                     || value.Equals(arg10))
                   || value.Equals(arg11))
                 || value.Equals(arg12))
               || value.Equals(arg13))
             || value.Equals(arg14))
           || value.Equals(arg15));
    }
}