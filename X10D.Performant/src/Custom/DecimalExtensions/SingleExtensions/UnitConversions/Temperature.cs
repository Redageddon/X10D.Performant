namespace X10D.Performant
{
    public static partial class SingleExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.CelsiusToFahrenheit"/>
        public static float CelsiusToFahrenheit(this float celsius) => (celsius * 9 / 5) + 32;

        /// <inheritdoc cref="DoubleExtensions.CelsiusToKelvin"/>
        public static float CelsiusToKelvin(this float celsius) => celsius + 273.15F;

        /// <inheritdoc cref="DoubleExtensions.FahrenheitToCelsius"/>
        public static float FahrenheitToCelsius(this float fahrenheit) => (fahrenheit - 32) * 5 / 9;

        /// <inheritdoc cref="DoubleExtensions.FahrenheitToKelvin"/>
        public static float FahrenheitToKelvin(this float fahrenheit) => ((fahrenheit - 32) * 5 / 9) + 273.15F;

        /// <inheritdoc cref="DoubleExtensions.KelvinToCelsius"/>
        public static float KelvinToCelsius(this float kelvin) => kelvin - 273.15F;

        /// <inheritdoc cref="DoubleExtensions.KelvinToFahrenheit"/>
        public static float KelvinToFahrenheit(this float kelvin) => ((kelvin - 273.15F) * 9 / 5) + 32;
    }
}