namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="Boolean.Parse(string)"/>
        public static bool ToBool(this string value) =>
            bool.Parse(value);
        
        /// <inheritdoc cref="Boolean.TryParse(string,out bool)"/>
        public static bool TryToBool(this string value, out bool result) =>
            bool.TryParse(value, out result);
    }
}