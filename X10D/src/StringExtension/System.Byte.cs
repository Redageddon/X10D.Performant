namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="Byte.Parse(string)"/>
        public static short ToByte(this string value) =>
            byte.Parse(value);
        
        /// <inheritdoc cref="Byte.TryParse(string,out byte)"/>
        public static bool TryToByte(this string value, out byte result) =>
            byte.TryParse(value, out result);
    }
}