namespace X10D.Performant.DoubleExtensions
{
    public static partial class DoubleExtensions
    {
        /// <include file='DoubleExtensions.xml' path='members/member[@name="ClampedLerp"]'/>
        public static double LerpClamped(this double alpha, double firstValue, double secondValue) =>
            alpha switch
            {
                <= 0 => firstValue,
                >= 1 => secondValue,
                _    => (firstValue * (1 - alpha)) + (secondValue * alpha),
            };

        /// <include file='DoubleExtensions.xml' path='members/member[@name="ClampedLerp"]'/>
        public static double LerpToClamped(this double firstValue, double secondValue, double alpha) =>
            alpha switch
            {
                <= 0 => firstValue,
                >= 1 => secondValue,
                _    => (firstValue * (1 - alpha)) + (secondValue * alpha),
            };

        /// <include file='DoubleExtensions.xml' path='members/member[@name="Lerp"]'/>
        public static double Lerp(this double alpha, double firstValue, double secondValue) => (firstValue * (1 - alpha)) + (secondValue * alpha);

        /// <include file='DoubleExtensions.xml' path='members/member[@name="Lerp"]'/>
        public static double LerpTo(this double firstValue, double secondValue, double alpha) => (firstValue * (1 - alpha)) + (secondValue * alpha);
    }
}