using System;
using System.Linq.Expressions;

namespace X10D.Performant
{
    public static partial class GenericExtensions
    {
        /// <summary>
        ///     Converts the <paramref name="value"/> to a <typeparamref name="TTo"/>.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <typeparam name="TFrom">The type to convert from.</typeparam>
        /// <typeparam name="TTo">The type to convert to.</typeparam>
        /// <returns>The value converted to <typeparamref name="TTo"/>.</returns>
        public static TTo? To<TFrom, TTo>(this TFrom value) => Convert<TFrom, TTo>.Function(value);

        /// <summary>
        ///     Converts the <paramref name="value"/> to a <typeparamref name="TTo"/>.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <param name="result">The value converted to <typeparamref name="TTo"/>.</param>
        /// <typeparam name="TFrom">The type to convert from.</typeparam>
        /// <typeparam name="TTo">The type to convert to.</typeparam>
        /// <returns><see langword="true"/> if a conversion was successful, or <see langword="false"/> otherwise.</returns>
        public static bool TryTo<TFrom, TTo>(this TFrom value, out TTo? result)
        {
            try
            {
                result = Convert<TFrom, TTo>.Function(value);

                return true;
            }
            catch (Exception)
            {
                result = default;

                return false;
            }
        }

        /// <summary>
        ///     Converts the <paramref name="value"/> to a <typeparamref name="TTo"/>, returning <paramref name="other"/> on fail.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <param name="other">The backup value.</param>
        /// <typeparam name="TFrom">The type to convert from.</typeparam>
        /// <typeparam name="TTo">The type to convert to.</typeparam>
        /// <returns>The a <typeparamref name="TTo"/> value.</returns>
        public static TTo? ToOrOther<TFrom, TTo>(this TFrom value, TTo? other)
        {
            if (!value.TryTo(out TTo? output))
            {
                output = other;
            }

            return output;
        }

        /// <summary>
        ///     Converts the <paramref name="value"/> to a <typeparamref name="TTo"/>, executing and returning <paramref name="other"/> on fail.
        /// </summary>
        /// <param name="value">The object to convert.</param>
        /// <param name="other">The unloaded value to get.</param>
        /// <typeparam name="TFrom">The type to convert from.</typeparam>
        /// <typeparam name="TTo">The type to convert to.</typeparam>
        /// <returns>The value converted to <typeparamref name="TTo"/>.</returns>
        public static TTo? ToOrOther<TFrom, TTo>(this TFrom value, Func<TTo> other)
        {
            if (!value.TryTo(out TTo? output))
            {
                output = other();
            }

            return output;
        }

        private static class Convert<TFrom, TTo>
        {
            // ReSharper disable once FieldCanBeMadeReadOnly.Local
            internal static Func<TFrom, TTo> Function = tFrom =>
            {
                if (tFrom is TTo to)
                {
                    Convert<TTo, TTo>.Function = v => v;

                    return to;
                }

                Type fromType = typeof(TFrom);
                Type toType = typeof(TTo);
                ParameterExpression from = Expression.Parameter(fromType);
                Expression convert;

                if (toType == typeof(string))
                {
                    Convert<TFrom, string?>.Function = val => val?.ToString();
                }
                else if (tFrom is string)
                {
                    if (toType.IsPrimitive ||
                        toType == typeof(decimal) ||
                        toType == typeof(TimeSpan))
                    {
                        Convert<string, bool>.Function = v => v switch
                        {
                            "1" => true,
                            "0" => false,
                            _   => bool.Parse(v),
                        };

                        Convert<string, char>.Function = char.Parse;
                        Convert<string, sbyte>.Function = sbyte.Parse;
                        Convert<string, byte>.Function = byte.Parse;
                        Convert<string, short>.Function = short.Parse;
                        Convert<string, ushort>.Function = ushort.Parse;
                        Convert<string, int>.Function = int.Parse;
                        Convert<string, uint>.Function = uint.Parse;
                        Convert<string, long>.Function = long.Parse;
                        Convert<string, ulong>.Function = ulong.Parse;
                        Convert<string, float>.Function = float.Parse;
                        Convert<string, double>.Function = double.Parse;
                        Convert<string, decimal>.Function = decimal.Parse;
                        Convert<string, TimeSpan>.Function = v => StringExtensions.ShortHandParse(v);
                    }
                    else
                    {
                        convert = Expression.Call(toType, "Parse", null, from);
                        Function = Expression.Lambda<Func<TFrom, TTo>>(convert, from).Compile();
                    }
                }
                else if (tFrom is char)
                {
                    // ReSharper disable once CompareOfFloatsByEqualityOperator
                    Convert<char, bool>.Function = v => char.GetNumericValue(v) == 1;
                    Convert<char, sbyte>.Function = v => (sbyte)char.GetNumericValue(v);
                    Convert<char, byte>.Function = v => (byte)char.GetNumericValue(v);
                    Convert<char, short>.Function = v => (short)char.GetNumericValue(v);
                    Convert<char, ushort>.Function = v => (ushort)char.GetNumericValue(v);
                    Convert<char, int>.Function = v => (int)char.GetNumericValue(v);
                    Convert<char, uint>.Function = v => (uint)char.GetNumericValue(v);
                    Convert<char, long>.Function = v => (long)char.GetNumericValue(v);
                    Convert<char, ulong>.Function = v => (ulong)char.GetNumericValue(v);
                    Convert<char, float>.Function = v => (float)char.GetNumericValue(v);
                    Convert<char, double>.Function = char.GetNumericValue;
                    Convert<char, decimal>.Function = v => (decimal)char.GetNumericValue(v);
                }
                else if (toType == typeof(bool))
                {
                    if (fromType.IsPrimitive ||
                        fromType == typeof(decimal))
                    {
                        Convert<char, bool>.Function = v => v != 0;
                        Convert<sbyte, bool>.Function = v => v != 0;
                        Convert<byte, bool>.Function = v => v != 0;
                        Convert<short, bool>.Function = v => v != 0;
                        Convert<ushort, bool>.Function = v => v != 0;
                        Convert<int, bool>.Function = v => v != 0;
                        Convert<uint, bool>.Function = v => v != 0;
                        Convert<long, bool>.Function = v => v != 0;
                        Convert<ulong, bool>.Function = v => v != 0;
                        Convert<float, bool>.Function = v => v != 0;
                        Convert<double, bool>.Function = v => v != 0;
                        Convert<decimal, bool>.Function = v => v != 0;
                    }
                    else
                    {
                        convert = Expression.NotEqual(from, Expression.Constant(default(TFrom)));
                        Function = Expression.Lambda<Func<TFrom, TTo>>(convert, from).Compile();
                    }
                }
                else if (tFrom is bool &&
                         toType == typeof(decimal))
                {
                    Convert<bool, decimal>.Function = v => v ? 1 : 0;
                }
                else
                {
                    convert = Expression.Convert(from, toType);
                    Function = Expression.Lambda<Func<TFrom, TTo>>(convert, from).Compile();
                }

                #pragma warning disable 8602
                return Function(tFrom);
            };
        }
    }
}