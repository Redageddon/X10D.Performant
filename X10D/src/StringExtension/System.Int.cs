namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="System.Int32.Parse(string)"/>
        public static int ToInt(this string value) =>
            int.Parse(value);
        
        /// <inheritdoc cref="System.Int32.TryParse(string,out int)"/>
        public static bool TryToInt(this string value, out int result) =>
            int.TryParse(value, out result);
    }
}