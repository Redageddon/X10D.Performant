/*This class is auto generated and will be overridden if any changes are made.
To make edits to this class edit the X10D.Generator project.*/

namespace X10D.Performant.SingleExtensions;

public static partial class SingleExtensions
{
    /// <include file='SingleExtensions.g.xml' path='members/member[@name="Lerp"]'/>
    public static float Lerp(this float alpha, float firstValue, float secondValue) => (firstValue * (1 - alpha)) + (secondValue * alpha);

    /// <include file='SingleExtensions.g.xml' path='members/member[@name="ClampedLerp"]'/>
    public static float LerpClamped(this float alpha, float firstValue, float secondValue) =>
        alpha switch
        {
            <= 0 => firstValue,
            >= 1 => secondValue,
            _    => (firstValue * (1 - alpha)) + (secondValue * alpha),
        };

    /// <include file='SingleExtensions.g.xml' path='members/member[@name="Lerp"]'/>
    public static float LerpTo(this float firstValue, float secondValue, float alpha) => (firstValue * (1 - alpha)) + (secondValue * alpha);

    /// <include file='SingleExtensions.g.xml' path='members/member[@name="ClampedLerp"]'/>
    public static float LerpToClamped(this float firstValue, float secondValue, float alpha) =>
        alpha switch
        {
            <= 0 => firstValue,
            >= 1 => secondValue,
            _    => (firstValue * (1 - alpha)) + (secondValue * alpha),
        };
}