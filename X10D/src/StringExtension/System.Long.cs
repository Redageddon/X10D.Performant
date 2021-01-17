namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="long.Parse(string)"/>
        public static long ToLong(this string value) =>
            long.Parse(value);
        
        /// <inheritdoc cref="long.TryParse(string,out long)"/>
        public static bool TryToLong(this string value, out long result) =>
            long.TryParse(value, out result);
    }
}