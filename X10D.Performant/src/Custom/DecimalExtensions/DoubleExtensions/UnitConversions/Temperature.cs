namespace X10D.Performant.DoubleExtensions
{
    public static partial class DoubleExtensions
    {
        /// <include file='../DoubleExtensions.xml' path='members/member[@name="CelsiusToFahrenheit"]'/>
        public static double CelsiusToFahrenheit(this double celsius) => (celsius * 9 / 5) + 32;

        /// <include file='../DoubleExtensions.xml' path='members/member[@name="CelsiusToKelvin"]'/>
        public static double CelsiusToKelvin(this double celsius) => celsius + 273.15D;

        /// <include file='../DoubleExtensions.xml' path='members/member[@name="FahrenheitToCelsius"]'/>
        public static double FahrenheitToCelsius(this double fahrenheit) => (fahrenheit - 32) * 5 / 9;

        /// <include file='../DoubleExtensions.xml' path='members/member[@name="FahrenheitToKelvin"]'/>
        public static double FahrenheitToKelvin(this double fahrenheit) => ((fahrenheit - 32) * 5 / 9) + 273.15D;

        /// <include file='../DoubleExtensions.xml' path='members/member[@name="KelvinToCelsius"]'/>
        public static double KelvinToCelsius(this double kelvin) => kelvin - 273.15D;

        /// <include file='../DoubleExtensions.xml' path='members/member[@name="KelvinToFahrenheit"]'/>
        public static double KelvinToFahrenheit(this double kelvin) => ((kelvin - 273.15D) * 9 / 5) + 32;
    }
}