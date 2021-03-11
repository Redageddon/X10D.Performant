namespace X10D.Performant
{
    public static partial class DoubleExtensions
    {
        /// <summary>
        ///     Converts <paramref name="fahrenheit"/> to Celsius.
        /// </summary>
        /// <param name="fahrenheit">The temperature value measured in fahrenheit.</param>
        /// <returns>A celsius value from a fahrenheit value.</returns>
        public static double FahrenheitToCelsius(this double fahrenheit) => (fahrenheit - 32) * 5 / 9;

        /// <summary>
        ///     Converts <paramref name="fahrenheit"/> to Kelvin.
        /// </summary>
        /// <param name="fahrenheit">The temperature value measured in fahrenheit.</param>
        /// <returns>A kelvin value from a fahrenheit value.</returns>
        public static double FahrenheitToKelvin(this double fahrenheit) => ((fahrenheit - 32) * 5 / 9) + 273.15;

        /// <summary>
        ///     Converts <paramref name="celsius"/> to Fahrenheit.
        /// </summary>
        /// <param name="celsius">The temperature value measured in celsius.</param>
        /// <returns>A celsius value from a fahrenheit value.</returns>
        public static double CelsiusToFahrenheit(this double celsius) => (celsius * 9 / 5) + 32;
    }
}