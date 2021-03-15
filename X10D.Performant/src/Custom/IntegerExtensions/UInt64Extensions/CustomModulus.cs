namespace X10D.Performant.UInt64Extensions
{
    public static partial class UInt64Extensions
    {
        /// <include file='UInt64Extensions.xml' path='members/member[@name="Mod"]'/>
        public static ulong Mod(this ulong value, ulong modulus)
        {
            if (value < modulus)
            {
                return value;
            }

            if (value == modulus)
            {
                return 0;
            }

            switch (modulus)
            {
                case 1: return 0;
                case 1L << 1:
                case 1L << 2:
                case 1L << 3:
                case 1L << 4:
                case 1L << 5:
                case 1L << 6:
                case 1L << 7:
                case 1L << 8:
                case 1L << 9:
                case 1L << 10:
                case 1L << 11:
                case 1L << 12:
                case 1L << 13:
                case 1L << 14:
                case 1L << 15:
                case 1L << 16:
                case 1L << 17:
                case 1L << 18:
                case 1L << 19:
                case 1L << 20:
                case 1L << 21:
                case 1L << 22:
                case 1L << 23:
                case 1L << 24:
                case 1L << 25:
                case 1L << 26:
                case 1L << 27:
                case 1L << 28:
                case 1L << 29:
                case 1L << 30:
                case 1L << 31:
                case 1L << 32:
                case 1L << 33:
                case 1L << 34:
                case 1L << 35:
                case 1L << 36:
                case 1L << 37:
                case 1L << 38:
                case 1L << 39:
                case 1L << 40:
                case 1L << 41:
                case 1L << 42:
                case 1L << 43:
                case 1L << 44:
                case 1L << 45:
                case 1L << 46:
                case 1L << 47:
                case 1L << 48:
                case 1L << 49:
                case 1L << 50:
                case 1L << 51:
                case 1L << 52:
                case 1L << 53:
                case 1L << 54:
                case 1L << 55:
                case 1L << 56:
                case 1L << 57:
                case 1L << 58:
                case 1L << 59:
                case 1L << 60:
                case 1L << 61:
                case 1L << 62:
                case 1UL << 63:
                    return value & (modulus - 1);
                default:
                    return value - (value / modulus * modulus);
            }
        }
    }
}