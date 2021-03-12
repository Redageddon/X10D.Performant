namespace X10D.Performant
{
    public static partial class SByteExtensions
    {
        /// <inheritdoc cref="UInt64Extensions.IsPrime"/>
        public static bool IsPrime(this sbyte value)
        {
            switch (value)
            {
                case 2:
                case 3:
                case 5:
                case 7:
                case 11:
                case 13:
                case 17:
                case 19:
                case 23:
                case 29:
                case 31:
                case 37:
                case 41:
                case 43:
                case 47:
                case 53:
                case 59:
                case 61:
                case 67:
                case 71:
                case 73:
                case 79:
                case 83:
                case 89:
                case 97:
                case 101:
                case 103:
                case 107:
                case 109:
                case 113:
                case 127: return true;
                default: return false;
            }
        }
    }
}