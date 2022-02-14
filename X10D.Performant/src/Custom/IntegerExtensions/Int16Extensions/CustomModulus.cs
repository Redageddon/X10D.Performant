namespace X10D.Performant.Int16Extensions;

public static partial class Int16Extensions
{
    /// <include file='Int16Extensions.copy.xml' path='members/member[@name="Mod"]'/>
    public static short Mod(this short value, short modulus)
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
                case 1 << 6:
                case 1 << 8:
                case 1 << 9:
                case 1 << 10:
                case 1 << 11:
                case 1 << 12:
                case 1 << 13:
                case 1 << 14: return (short)(value & (modulus - 1));
            }
        }

        return (short)(value - (value / modulus * modulus));
    }
}