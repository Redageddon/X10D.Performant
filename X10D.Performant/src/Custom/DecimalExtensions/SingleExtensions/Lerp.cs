namespace X10D.Performant
{
    public static partial class SingleExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.Lerp"/>
        public static float Lerp(this float alpha, float firstValue, float secondValue) => (firstValue * (1 - alpha)) + (secondValue * alpha);

        /// <inheritdoc cref="Lerp"/>
        public static float LerpTo(this float firstValue, float secondValue, float alpha) => (firstValue * (1 - alpha)) + (secondValue * alpha);
    }
}