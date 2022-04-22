/*This class is auto generated and will be overridden if any changes are made.
To make edits to this class edit the X10D.Generator project.*/

namespace X10D.Performant.Int64Extensions;

public static partial class Int64Extensions
{
    /// <include file='Int64Extensions.g.xml' path='members/member[@name="IsEven"]'/>
    public static bool IsEven(this long value) => (value & 1) == 0;

    /// <include file='Int64Extensions.g.xml' path='members/member[@name="IsOdd"]'/>
    public static bool IsOdd(this long value) => (value & 1) == 1;

    /// <include file='Int64Extensions.g.xml' path='members/member[@name="ToBoolean"]'/>
    public static bool ToBoolean(this long value) => value != 0;
}