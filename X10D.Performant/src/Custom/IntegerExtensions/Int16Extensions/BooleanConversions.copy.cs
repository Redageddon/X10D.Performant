namespace X10D.Performant.Int16Extensions;

public static partial class Int16Extensions
{
    /// <include file='Int16Extensions.copy.xml' path='members/member[@name="IsEven"]'/>
    public static bool IsEven(this short value) => (value & 1) == 0;

    /// <include file='Int16Extensions.copy.xml' path='members/member[@name="IsOdd"]'/>
    public static bool IsOdd(this short value) => (value & 1) == 1;

    /// <include file='Int16Extensions.copy.xml' path='members/member[@name="ToBoolean"]'/>
    public static bool ToBoolean(this short value) => value != 0;
}