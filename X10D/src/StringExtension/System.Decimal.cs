namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="Decimal.Parse(string)"/>
        public static decimal ToDecimal(this string value) =>
            decimal.Parse(value);
        
        /// <inheritdoc cref="Decimal.TryParse(string,out decimal)"/>
        public static bool TryToDouble(this string value, out decimal result) =>
            decimal.TryParse(value, out result);
    }
}