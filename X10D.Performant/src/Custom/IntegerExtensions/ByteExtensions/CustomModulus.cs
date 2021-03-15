namespace X10D.Performant.ByteExtensions
{
    public static partial class ByteExtensions
    {
        /// <include file='../UInt64Extensions/UInt64Extensions.xml' path='members/member[@name="Mod"]'/>
        public static byte Mod(this byte value, byte modulus)
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
                case 1 << 7:
                    return (byte)(value & (modulus - 1));
                default: return (byte)(value - (value / modulus * modulus));
            }
        }
    }
}