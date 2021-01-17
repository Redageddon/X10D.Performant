namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="uint.Parse(string)"/>
        public static uint ToUInt(this string value) =>
            uint.Parse(value);
        
        /// <inheritdoc cref="uint.TryParse(string,out uint)"/>
        public static bool TryToUInt(this string value, out uint result) =>
            uint.TryParse(value, out result);
    }
}