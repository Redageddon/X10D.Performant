namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="Int16.Parse(string)"/>
        public static short ToShort(this string value) =>
            short.Parse(value);
        
        /// <inheritdoc cref="Int16.TryParse(string,out short)"/>
        public static bool TryToShort(this string value, out short result) =>
            short.TryParse(value, out result);
    }
}