/*This class is auto generated and will be overridden if any changes are made.
To make edits to this class edit the X10D.Generator project.*/

namespace X10D.Performant.SingleExtensions;

/// <summary>
///     Extension methods for <see cref="float"/>.
/// </summary>
public static partial class SingleExtensions
{
    /// <include file='SingleExtensions.g.xml' path='members/member[@name="AlmostEquals"]'/>
    public static bool AlmostEquals(this float value1, float value2, float tolerance = float.Epsilon) =>
        MathF.Abs(value1 - value2) < MathF.Abs(tolerance);

    /// <include file='SingleExtensions.g.xml' path='members/member[@name="InverseSqrt"]'/>
    public static float InverseSqrt(this float value) => 1F / MathF.Sqrt(value);

    /// <include file='SingleExtensions.g.xml' path='members/member[@name="IsEven"]'/>
    public static bool IsEven(this float value) => value % 2F == 0F;

    /// <include file='SingleExtensions.g.xml' path='members/member[@name="IsOdd"]'/>
    public static bool IsOdd(this float value) => value % 2F != 0F;
}