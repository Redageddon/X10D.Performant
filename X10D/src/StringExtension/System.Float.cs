namespace X10D.Performant.StringExtension
{
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="System.Single.Parse(string)"/>
        public static float ToSingle(this string value) =>
            float.Parse(value);
        
        /// <inheritdoc cref="System.Single.TryParse(string,out float)"/>
        public static bool TryToSingle(this string value, out float result) =>
            float.TryParse(value, out result);
    }
}