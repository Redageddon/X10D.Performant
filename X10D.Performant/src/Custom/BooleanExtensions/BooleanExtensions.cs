namespace X10D.Performant.BooleanExtensions;

/// <summary>
///     Extension methods for <see cref="bool"/>.
/// </summary>
public static class BooleanExtensions
{
    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToByte"]'/>
    public static byte ToByte(this bool value) => value ? (byte)1 : (byte)0;

    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToDecimal"]'/>
    public static decimal ToDecimal(this bool value) => value ? 1 : 0;

    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToDouble"]'/>
    public static double ToDouble(this bool value) => value ? 1 : 0;

    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToInt16"]'/>
    public static short ToInt16(this bool value) => value ? (short)1 : (short)0;

    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToInt32"]'/>
    public static int ToInt32(this bool value) => value ? 1 : 0;

    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToInt64"]'/>
    public static long ToInt64(this bool value) => value ? 1 : 0;

    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToNInt"]'/>
    public static nint ToNInt(this bool value) => value ? 1 : 0;

    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToUNInt"]'/>
    public static nuint ToNUInt(this bool value) => value ? 1 : (nuint)0;

    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToSByte"]'/>
    public static sbyte ToSByte(this bool value) => value ? (sbyte)1 : (sbyte)0;

    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToSingle"]'/>
    public static float ToSingle(this bool value) => value ? 1 : 0;

    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToUInt16"]'/>
    public static ushort ToUInt16(this bool value) => value ? (ushort)1 : (ushort)0;

    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToUInt32"]'/>
    public static uint ToUInt32(this bool value) => value ? 1 : (uint)0;

    /// <include file='BooleanExtensions.xml' path='members/member[@name="ToUInt64"]'/>
    public static ulong ToUInt64(this bool value) => value ? 1 : (ulong)0;
}