namespace X10D.Performant
{
    public static partial class DoubleExtensions
    {
        /// <summary>
        ///     Converts <paramref name="fahrenheit"/> to Celsius.
        /// </summary>
        /// <param name="fahrenheit"></param>
        /// <returns></returns>
        public static double FahrenheitToCelsius(this double fahrenheit) => (fahrenheit - 32) * 5 / 9;
    }
}