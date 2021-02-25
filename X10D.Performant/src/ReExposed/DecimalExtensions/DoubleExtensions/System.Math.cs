using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static partial class DoubleExtensions
    {
        /// <inheritdoc cref="Math.Abs(double)" />
        public static double Abs(this double value) => Math.Abs(value);

        /// <inheritdoc cref="Math.Acos(double)" />
        public static double Acos(this double value) => Math.Acos(value);

        /// <inheritdoc cref="Math.Acosh(double)" />
        public static double Acosh(this double value) => Math.Acosh(value);

        /// <inheritdoc cref="Math.Asin(double)" />
        public static double Asin(this double value) => Math.Asin(value);

        /// <inheritdoc cref="Math.Asinh(double)" />
        public static double Asinh(this double value) => Math.Asinh(value);

        /// <inheritdoc cref="Math.Atan(double)" />
        public static double Atan(this double value) => Math.Atan(value);

        /// <inheritdoc cref="Math.Atan2(double,double)" />
        public static double Atan2(this double value, double value2) => Math.Atan2(value, value2);

        /// <inheritdoc cref="Math.Atanh(double)" />
        public static double Atanh(this double value) => Math.Atanh(value);

        /// <inheritdoc cref="Math.BitDecrement(double)" />
        public static double BitDecrement(this double value) => Math.BitDecrement(value);

        /// <inheritdoc cref="Math.BitIncrement(double)" />
        public static double BitIncrement(this double value) => Math.BitIncrement(value);

        /// <inheritdoc cref="Math.Cbrt(double)" />
        public static double Cbrt(this double value) => Math.Cbrt(value);

        /// <inheritdoc cref="Math.Ceiling(double)" />
        public static double Ceiling(this double value) => Math.Ceiling(value);

        /// <inheritdoc cref="Math.Clamp(double,double,double)" />
        public static double Clamp(this double value, double min, double max) => Math.Clamp(value, min, max);

        /// <inheritdoc cref="Math.CopySign(double,double)" />
        public static double CopySign(this double value, double value2) => Math.CopySign(value, value2);

        /// <inheritdoc cref="Math.Cos(double)" />
        public static double Cos(this double value) => Math.Cos(value);

        /// <inheritdoc cref="Math.Cosh(double)" />
        public static double Cosh(this double value) => Math.Cosh(value);

        /// <inheritdoc cref="Math.Exp(double)" />
        public static double Exp(this double value) => Math.Exp(value);

        /// <inheritdoc cref="Math.Floor(double)" />
        public static double Floor(this double value) => Math.Floor(value);

        /// <inheritdoc cref="Math.FusedMultiplyAdd(double,double,double)" />
        public static double FusedMultiplyAdd(this double value, double value2, double value3) => Math.FusedMultiplyAdd(value, value2, value3);

        /// <inheritdoc cref="Math.IEEERemainder(double,double)" />
        public static double IEEERemainder(this double value, double value2) => Math.IEEERemainder(value, value2);

        /// <inheritdoc cref="Math.ILogB(double)" />
        public static int ILogB(this double value) => Math.ILogB(value);

        /// <inheritdoc cref="Math.Log(double)" />
        public static double Log(this double value) => Math.Log(value);

        /// <inheritdoc cref="Math.Log(double,double)" />
        public static double Log(this double value, double newBase) => Math.Log(value, newBase);

        /// <inheritdoc cref="Math.Log10(double)" />
        public static double Log10(this double value) => Math.Log10(value);

        /// <inheritdoc cref="Math.Log2(double)" />
        public static double Log2(this double value) => Math.Log2(value);

        /// <inheritdoc cref="Math.Max(double,double)" />
        public static double Max(this double value, double value2) => Math.Max(value, value2);

        /// <inheritdoc cref="Math.MaxMagnitude(double,double)" />
        public static double MaxMagnitude(this double value, double value2) => Math.MaxMagnitude(value, value2);

        /// <inheritdoc cref="Math.Min(double,double)" />
        public static double Min(this double value, double value2) => Math.Min(value, value2);

        /// <inheritdoc cref="Math.MinMagnitude(double,double)" />
        public static double MinMagnitude(this double value, double value2) => Math.MinMagnitude(value, value2);

        /// <inheritdoc cref="Math.Pow(double,double)" />
        public static double Pow(this double value, double power) => Math.Pow(value, power);

        /// <inheritdoc cref="Math.Round(double)" />
        public static double Round(this double value) => Math.Round(value);

        /// <inheritdoc cref="Math.Round(double,MidpointRounding)" />
        public static double Round(this double value, MidpointRounding mode) => Math.Round(value, mode);

        /// <inheritdoc cref="Math.Round(double,int)" />
        public static double Round(this double value, int digits) => Math.Round(value, digits);

        /// <inheritdoc cref="Math.Round(double,int,MidpointRounding)" />
        public static double Round(this double value, int digits, MidpointRounding mode) => Math.Round(value, digits, mode);

        /// <inheritdoc cref="Math.ScaleB(double,int)" />
        public static double ScaleB(this double value, int b) => Math.ScaleB(value, b);

        /// <inheritdoc cref="Math.Sign(double)" />
        public static int Sign(this double value) => Math.Sign(value);

        /// <inheritdoc cref="Math.Sin(double)" />
        public static double Sin(this double value) => Math.Sin(value);

        /// <inheritdoc cref="Math.Sinh(double)" />
        public static double Sinh(this double value) => Math.Sinh(value);

        /// <inheritdoc cref="Math.Sqrt(double)" />
        public static double Sqrt(this double value) => Math.Sqrt(value);

        /// <inheritdoc cref="Math.Tan(double)" />
        public static double Tan(this double value) => Math.Tan(value);

        /// <inheritdoc cref="Math.Tanh(double)" />
        public static double Tanh(this double value) => Math.Tanh(value);

        /// <inheritdoc cref="Math.Truncate(double)" />
        public static double Truncate(this double value) => Math.Truncate(value);
    }
}