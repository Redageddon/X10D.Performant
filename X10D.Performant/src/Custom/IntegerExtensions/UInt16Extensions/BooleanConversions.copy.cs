namespace X10D.Performant.UInt16Extensions;

public static partial class UInt16Extensions
{
    /// <include file='UInt16Extensions.copy.xml' path='members/member[@name="IsEven"]'/>
    public static bool IsEven(this ushort value) => (value & 1) == 0;

    /// <include file='UInt16Extensions.copy.xml' path='members/member[@name="IsOdd"]'/>
    public static bool IsOdd(this ushort value) => (value & 1) == 1;

    /// <include file='UInt16Extensions.copy.xml' path='members/member[@name="ToBoolean"]'/>
    public static bool ToBoolean(this ushort value) => value != 0;
}