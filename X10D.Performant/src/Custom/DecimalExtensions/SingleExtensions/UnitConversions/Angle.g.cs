/*This class is auto generated and will be overridden if any changes are made.
To make edits to this class edit the X10D.Generator project.*/

namespace X10D.Performant.SingleExtensions;

public static partial class SingleExtensions
{
    /// <include file='../SingleExtensions.g.xml' path='members/member[@name="DegreesToGradians"]'/>
    public static float DegreesToGradians(this float degree) => degree * 10F / 9F;

    /// <include file='../SingleExtensions.g.xml' path='members/member[@name="DegreesToRadians"]'/>
    public static float DegreesToRadians(this float degree) => MathF.PI * degree / 180.0F;

    /// <include file='../SingleExtensions.g.xml' path='members/member[@name="GradiansToDegrees"]'/>
    public static float GradiansToDegrees(this float gradian) => gradian * 9F / 10F;

    /// <include file='../SingleExtensions.g.xml' path='members/member[@name="GradiansToRadians"]'/>
    public static float GradiansToRadians(this float gradian) => gradian * MathF.PI / 200F;

    /// <include file='../SingleExtensions.g.xml' path='members/member[@name="RadiansToDegrees"]'/>
    public static float RadiansToDegrees(this float radian) => radian * 180.0F / MathF.PI;

    /// <include file='../SingleExtensions.g.xml' path='members/member[@name="RadiansToGradians"]'/>
    public static float RadiansToGradians(this float radian) => radian * 200F / MathF.PI;
}