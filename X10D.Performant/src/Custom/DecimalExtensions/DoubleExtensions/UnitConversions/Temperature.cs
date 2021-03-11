namespace X10D.Performant
{
    public static partial class DoubleExtensions
    {
        /// <summary>
        ///     Converts <paramref name="celsius"/> to fahrenheit.
        /// </summary>
        /// <param name="celsius">The temperature value measured in celsius.</param>
        /// <returns>A celsius value from a fahrenheit value.</returns>
        public static double CelsiusToFahrenheit(this double celsius) => (celsius * 9 / 5) + 32;

        /// <summary>
        ///     Converts <paramref name="celsius"/> to kelvin.
        /// </summary>
        /// <param name="celsius">The temperature value measured in celsius.</param>
        /// <returns>A kelvin value from a celsius value.</returns>
        public static double CelsiusToKelvin(this double celsius) => celsius + 273.15;

        /// <summary>
        ///     Converts <paramref name="fahrenheit"/> to celsius.
        /// </summary>
        /// <param name="fahrenheit">The temperature value measured in fahrenheit.</param>
        /// <returns>A celsius value from a fahrenheit value.</returns>
        public static double FahrenheitToCelsius(this double fahrenheit) => (fahrenheit - 32) * 5 / 9;

        /// <summary>
        ///     Converts <paramref name="fahrenheit"/> to kelvin.
        /// </summary>
        /// <param name="fahrenheit">The temperature value measured in fahrenheit.</param>
        /// <returns>A kelvin value from a fahrenheit value.</returns>
        public static double FahrenheitToKelvin(this double fahrenheit) => ((fahrenheit - 32) * 5 / 9) + 273.15;

        /// <summary>
        ///     Converts <paramref name="kelvin"/> to celsius.
        /// </summary>
        /// <param name="kelvin">The temperature value measured in kelvin.</param>
        /// <returns>A celsius value from a kelvin value.</returns>
        public static double KelvinToCelsius(this double kelvin) => kelvin - 273.15;

        /// <summary>
        ///     Converts <paramref name="kelvin"/> to fahrenheit.
        /// </summary>
        /// <param name="kelvin">The temperature value measured in kelvin.</param>
        /// <returns>A fahrenheit value from a kelvin value.</returns>
        public static double KelvinToFahrenheit(this double kelvin) => ((kelvin - 273.15) * 9 / 5) + 32;
    }
}