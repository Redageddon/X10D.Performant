namespace X10D.Performant.SByteExtensions;

public static partial class SByteExtensions
{
    /// <include file='SByteExtensions.g.xml' path='members/member[@name="Mod"]'/>
    public static sbyte Mod(this sbyte value, sbyte modulus)
    {
        if (value == modulus)
        {
            return 0;
        }

        if (value > 0)
        {
            if (value < modulus)
            {
                return value;
            }

            switch (modulus)
            {
                case 1: return 0;
                case 1 << 1:
                case 1 << 2:
                case 1 << 3:
                case 1 << 4:
                case 1 << 5:
                case 1 << 6: return (sbyte)(value & (modulus - 1));
            }
        }

        return (sbyte)(value - (value / modulus * modulus));
    }
}