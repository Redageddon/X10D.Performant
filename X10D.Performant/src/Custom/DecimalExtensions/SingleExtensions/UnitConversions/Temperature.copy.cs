namespace X10D.Performant.SingleExtensions
{
    public static partial class SingleExtensions
    {
        /// <include file='../SingleExtensions.copy.xml' path='members/member[@name="CelsiusToFahrenheit"]'/>
        public static float CelsiusToFahrenheit(this float celsius) => (celsius * 9 / 5) + 32;

        /// <include file='../SingleExtensions.copy.xml' path='members/member[@name="CelsiusToKelvin"]'/>
        public static float CelsiusToKelvin(this float celsius) => celsius + 273.15F;

        /// <include file='../SingleExtensions.copy.xml' path='members/member[@name="FahrenheitToCelsius"]'/>
        public static float FahrenheitToCelsius(this float fahrenheit) => (fahrenheit - 32) * 5 / 9;

        /// <include file='../SingleExtensions.copy.xml' path='members/member[@name="FahrenheitToKelvin"]'/>
        public static float FahrenheitToKelvin(this float fahrenheit) => ((fahrenheit - 32) * 5 / 9) + 273.15F;

        /// <include file='../SingleExtensions.copy.xml' path='members/member[@name="KelvinToCelsius"]'/>
        public static float KelvinToCelsius(this float kelvin) => kelvin - 273.15F;

        /// <include file='../SingleExtensions.copy.xml' path='members/member[@name="KelvinToFahrenheit"]'/>
        public static float KelvinToFahrenheit(this float kelvin) => ((kelvin - 273.15F) * 9 / 5) + 32;
    }
}