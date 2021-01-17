namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="byte.Parse(string)"/>
        public static short ToByte(this string value) =>
            byte.Parse(value);
        
        /// <inheritdoc cref="byte.TryParse(string,out byte)"/>
        public static bool TryToByte(this string value, out byte result) =>
            byte.TryParse(value, out result);
    }
}