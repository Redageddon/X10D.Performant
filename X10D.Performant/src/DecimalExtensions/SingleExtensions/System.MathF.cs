using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static partial class SingleExtensions
    {
        /// <inheritdoc cref="MathF.Acos(float)"/>
        public static float Acos(this float value) => MathF.Acos(value);

        /// <inheritdoc cref="MathF.Acosh(float)"/>
        public static float Acosh(this float value) => MathF.Acosh(value);

        /// <inheritdoc cref="MathF.Asin(float)"/>
        public static float Asin(this float value) => MathF.Asin(value);

        /// <inheritdoc cref="MathF.Asinh(float)"/>
        public static float Asinh(this float value) => MathF.Asinh(value);

        /// <inheritdoc cref="MathF.Atan(float)"/>
        public static float Atan(this float value) => MathF.Atan(value);

        /// <inheritdoc cref="MathF.Atan2(float,float)"/>
        public static float Atan2(this float value, float value2) => MathF.Atan2(value, value2);

        /// <inheritdoc cref="MathF.Atanh(float)"/>
        public static float Atanh(this float value) => MathF.Atanh(value);

        /// <inheritdoc cref="MathF.BitDecrement(float)"/>
        public static float BitDecrement(this float value) => MathF.BitDecrement(value);

        /// <inheritdoc cref="MathF.BitIncrement(float)"/>
        public static float BitIncrement(this float value) => MathF.BitIncrement(value);

        /// <inheritdoc cref="MathF.Cbrt(float)"/>
        public static float Cbrt(this float value) => MathF.Cbrt(value);

        /// <inheritdoc cref="MathF.Ceiling(float)"/>
        public static float Ceiling(this float value) => MathF.Ceiling(value);

        /// <inheritdoc cref="MathF.CopySign(float,float)"/>
        public static float CopySign(this float value, float value2) => MathF.CopySign(value, value2);

        /// <inheritdoc cref="MathF.Cos(float)"/>
        public static float Cos(this float value) => MathF.Cos(value);

        /// <inheritdoc cref="MathF.Cosh(float)"/>
        public static float Cosh(this float value) => MathF.Cosh(value);

        /// <inheritdoc cref="MathF.Exp(float)"/>
        public static float Exp(this float value) => MathF.Exp(value);

        /// <inheritdoc cref="MathF.Floor(float)"/>
        public static float Floor(this float value) => MathF.Floor(value);

        /// <inheritdoc cref="MathF.FusedMultiplyAdd(float,float,float)"/>
        public static float FusedMultiplyAdd(this float value, float value2, float value3) => MathF.FusedMultiplyAdd(value, value2, value3);

        /// <inheritdoc cref="MathF.Log(float)"/>
        public static float Log(this float value) => MathF.Log(value);

        /// <inheritdoc cref="MathF.Log(float,float)"/>
        public static float Log(this float value, float newBase) => MathF.Log(value, newBase);

        /// <inheritdoc cref="MathF.Log10(float)"/>
        public static float Log10(this float value) => MathF.Log10(value);

        /// <inheritdoc cref="MathF.Log2(float)"/>
        public static float Log2(this float value) => MathF.Log2(value);

        /// <inheritdoc cref="MathF.MaxMagnitude(float,float)"/>
        public static float MaxMagnitude(this float value, float value2) => MathF.MaxMagnitude(value, value2);

        /// <inheritdoc cref="MathF.MinMagnitude(float,float)"/>
        public static float MinMagnitude(this float value, float value2) => MathF.MinMagnitude(value, value2);

        /// <inheritdoc cref="MathF.Pow(float,float)"/>
        public static float Pow(this float value, float power) => MathF.Pow(value, power);

        /// <inheritdoc cref="MathF.Round(float)"/>
        public static float Round(this float value) => MathF.Round(value);

        /// <inheritdoc cref="MathF.Round(float,MidpointRounding)"/>
        public static float Round(this float value, MidpointRounding mode) => MathF.Round(value, mode);

        /// <inheritdoc cref="MathF.Round(float,int)"/>
        public static float Round(this float value, int digits) => MathF.Round(value, digits);

        /// <inheritdoc cref="MathF.Round(float,int,MidpointRounding)"/>
        public static float Round(this float value, int digits, MidpointRounding mode) => MathF.Round(value, digits, mode);

        /// <inheritdoc cref="MathF.ScaleB(float,int)"/>
        public static float ScaleB(this float value, int b) => MathF.ScaleB(value, b);

        /// <inheritdoc cref="MathF.Sin(float)"/>
        public static float Sin(this float value) => MathF.Sin(value);

        /// <inheritdoc cref="MathF.Sinh(float)"/>
        public static float Sinh(this float value) => MathF.Sinh(value);

        /// <inheritdoc cref="MathF.Sqrt(float)"/>
        public static float Sqrt(this float value) => MathF.Sqrt(value);

        /// <inheritdoc cref="MathF.Tan(float)"/>
        public static float Tan(this float value) => MathF.Tan(value);

        /// <inheritdoc cref="MathF.Tanh(float)"/>
        public static float Tanh(this float value) => MathF.Tanh(value);

        /// <inheritdoc cref="MathF.Truncate(float)"/>
        public static float Truncate(this float value) => MathF.Truncate(value);

        /// <inheritdoc cref="MathF.ILogB(float)"/>
        public static int ILogB(this float value) => MathF.ILogB(value);

        /// <inheritdoc cref="MathF.IEEERemainder(float,float)"/>
        public static float IEEERemainder(this float value, float value2) => MathF.IEEERemainder(value, value2);
    }
}