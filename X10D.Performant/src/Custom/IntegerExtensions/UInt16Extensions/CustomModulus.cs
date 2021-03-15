namespace X10D.Performant.UInt16Extensions
{
    public static partial class UInt16Extensions
    {
        /// <include file='../UInt64Extensions/UInt64Extensions.xml' path='members/member[@name="Mod"]'/>
        public static ushort Mod(this ushort value, ushort modulus)
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
                case 1 << 14:
                    return (ushort)(value & (modulus - 1));
                default:
                    return (ushort)(value - (value / modulus * modulus));
            }
        }
    }
}