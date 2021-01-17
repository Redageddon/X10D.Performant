namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="ulong.Parse(string)"/>
        public static ulong ToULong(this string value) =>
            ulong.Parse(value);
        
        /// <inheritdoc cref="ulong.TryParse(string,out ulong)"/>
        public static bool TryToULong(this string value, out ulong result) =>
            ulong.TryParse(value, out result);
    }
}