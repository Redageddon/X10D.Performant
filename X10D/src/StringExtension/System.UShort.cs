namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="ushort.Parse(string)"/>
        public static ushort ToUShort(this string value) =>
            ushort.Parse(value);
        
        /// <inheritdoc cref="ushort.TryParse(string,out ushort)"/>
        public static bool TryToUShort(this string value, out ushort result) =>
            ushort.TryParse(value, out result);
    }
}