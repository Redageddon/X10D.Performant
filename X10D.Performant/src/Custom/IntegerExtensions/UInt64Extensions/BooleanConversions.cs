namespace X10D.Performant.UInt64Extensions;

public static partial class UInt64Extensions
{
    /// <include file='UInt64Extensions.xml' path='members/member[@name="IsEven"]'/>
    public static bool IsEven(this ulong value) => (value & 1) == 0;

    /// <include file='UInt64Extensions.xml' path='members/member[@name="IsOdd"]'/>
    public static bool IsOdd(this ulong value) => (value & 1) == 1;

    /// <include file='UInt64Extensions.xml' path='members/member[@name="ToBoolean"]'/>
    public static bool ToBoolean(this ulong value) => value != 0;
}