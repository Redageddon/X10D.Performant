using System;

namespace X10D.Performant.DoubleExtensions;

public static partial class DoubleExtensions
{
    /// <include file='../DoubleExtensions.xml' path='members/member[@name="DegreesToGradians"]'/>
    public static double DegreesToGradians(this double degree) => degree * 10D / 9D;

    /// <include file='../DoubleExtensions.xml' path='members/member[@name="DegreesToRadians"]'/>
    public static double DegreesToRadians(this double degree) => Math.PI * degree / 180.0D;

    /// <include file='../DoubleExtensions.xml' path='members/member[@name="GradiansToDegrees"]'/>
    public static double GradiansToDegrees(this double gradian) => gradian * 9D / 10D;

    /// <include file='../DoubleExtensions.xml' path='members/member[@name="GradiansToRadians"]'/>
    public static double GradiansToRadians(this double gradian) => gradian * Math.PI / 200D;

    /// <include file='../DoubleExtensions.xml' path='members/member[@name="RadiansToDegrees"]'/>
    public static double RadiansToDegrees(this double radian) => radian * 180.0D / Math.PI;

    /// <include file='../DoubleExtensions.xml' path='members/member[@name="RadiansToGradians"]'/>
    public static double RadiansToGradians(this double radian) => radian * 200D / Math.PI;
}