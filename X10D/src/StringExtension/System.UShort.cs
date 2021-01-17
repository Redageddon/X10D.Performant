namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="UInt16.Parse(string)"/>
        public static ushort ToUShort(this string value) =>
            ushort.Parse(value);
        
        /// <inheritdoc cref="UInt16.TryParse(string,out ushort)"/>
        public static bool TryToUShort(this string value, out ushort result) =>
            ushort.TryParse(value, out result);
    }
}