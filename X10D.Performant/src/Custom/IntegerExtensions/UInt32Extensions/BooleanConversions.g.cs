/*This class is auto generated and will be overridden if any changes are made.
To make edits to this class edit the X10D.Generator project.*/

namespace X10D.Performant.UInt32Extensions;

public static partial class UInt32Extensions
{
    /// <include file='UInt32Extensions.g.xml' path='members/member[@name="IsEven"]'/>
    public static bool IsEven(this uint value) => (value & 1) == 0;

    /// <include file='UInt32Extensions.g.xml' path='members/member[@name="IsOdd"]'/>
    public static bool IsOdd(this uint value) => (value & 1) == 1;

    /// <include file='UInt32Extensions.g.xml' path='members/member[@name="ToBoolean"]'/>
    public static bool ToBoolean(this uint value) => value != 0;
}