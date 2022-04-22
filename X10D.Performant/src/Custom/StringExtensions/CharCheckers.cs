namespace X10D.Performant.StringExtensions;

[SuppressMessage("ReSharper", "ForeachCanBeConvertedToQueryUsingAnotherGetEnumerator")]
public static partial class StringExtensions
{
    /// <include file='StringExtensions.xml' path='members/member[@name="IsAlpha"]'/>
    public static bool IsAlpha(this string value)
    {
        foreach (char t in value)
        {
            if (!char.IsLetter(t))
            {
                return false;
            }
        }

        return true;
    }

    /// <include file='StringExtensions.xml' path='members/member[@name="IsLower"]'/>
    public static bool IsLower(this string value)
    {
        foreach (char t in value)
        {
            if (char.IsLetter(t)
             && !char.IsLower(t))
            {
                return false;
            }
        }

        return true;
    }

    /// <include file='StringExtensions.xml' path='members/member[@name="IsNumerical"]'/>
    public static bool IsNumerical(this string value)
    {
        foreach (char t in value)
        {
            if (!char.IsNumber(t))
            {
                return false;
            }
        }

        return true;
    }

    /// <include file='StringExtensions.xml' path='members/member[@name="IsUpper"]'/>
    public static bool IsUpper(this string value)
    {
        foreach (char t in value)
        {
            if (char.IsLetter(t)
             && !char.IsUpper(t))
            {
                return false;
            }
        }

        return true;
    }
}