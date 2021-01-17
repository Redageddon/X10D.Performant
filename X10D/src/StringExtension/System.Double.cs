namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="double.Parse(string)"/>
        public static double ToDouble(this string value) =>
            double.Parse(value);
        
        /// <inheritdoc cref="double.TryParse(string,out double)"/>
        public static bool TryToDouble(this string value, out double result) =>
            double.TryParse(value, out result);
    }
}