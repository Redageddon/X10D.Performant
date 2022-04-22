namespace X10D.Performant.DoubleExtensions;

/// <summary>
///     Extension methods for <see cref="double"/>.
/// </summary>
public static partial class DoubleExtensions
{
    /// <include file='DoubleExtensions.xml' path='members/member[@name="AlmostEquals"]'/>
    public static bool AlmostEquals(this double value1, double value2, double tolerance = double.Epsilon) =>
        Math.Abs(value1 - value2) < Math.Abs(tolerance);

    /// <include file='DoubleExtensions.xml' path='members/member[@name="InverseSqrt"]'/>
    public static double InverseSqrt(this double value) => 1D / Math.Sqrt(value);

    /// <include file='DoubleExtensions.xml' path='members/member[@name="IsEven"]'/>
    public static bool IsEven(this double value) => value % 2D == 0D;

    /// <include file='DoubleExtensions.xml' path='members/member[@name="IsOdd"]'/>
    public static bool IsOdd(this double value) => value % 2D != 0D;
}