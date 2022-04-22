using X10D.Performant.ReExposed;

namespace X10D.Performant.StringExtensions;

public static partial class StringExtensions
{
    /// <include file='StringExtensions.xml' path='members/member[@name="Base64Decode"]'/>
    public static string Base64Decode(this string value, Encoding? encoding = null) =>
        (encoding ?? Encoding.Default).GetString(Convert.FromBase64String(value));

    /// <include file='StringExtensions.xml' path='members/member[@name="Base64Encode"]'/>
    public static string Base64Encode(this string value, Encoding? encoding = null) => Convert.ToBase64String(value.GetBytes(encoding));

    /// <include file='StringExtensions.xml' path='members/member[@name="ChangeEncoding"]'/>
    public static string ChangeEncoding(this string value, Encoding from, Encoding to) => to.GetString(value.GetBytes(from));
}