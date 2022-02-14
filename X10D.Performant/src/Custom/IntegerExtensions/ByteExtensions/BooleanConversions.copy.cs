namespace X10D.Performant.ByteExtensions;

public static partial class ByteExtensions
{
    /// <include file='ByteExtensions.copy.xml' path='members/member[@name="IsEven"]'/>
    public static bool IsEven(this byte value) => (value & 1) == 0;

    /// <include file='ByteExtensions.copy.xml' path='members/member[@name="IsOdd"]'/>
    public static bool IsOdd(this byte value) => (value & 1) == 1;

    /// <include file='ByteExtensions.copy.xml' path='members/member[@name="ToBoolean"]'/>
    public static bool ToBoolean(this byte value) => value != 0;
}