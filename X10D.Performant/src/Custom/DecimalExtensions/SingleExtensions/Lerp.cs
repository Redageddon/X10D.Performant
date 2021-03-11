namespace X10D.Performant
{
    public static partial class SingleExtensions
    {
        /// <inheritdoc cref="DoubleExtensions.Lerp"/>
        public static float Lerp(this float alpha, float firstValue, float secondValue) => (firstValue * (1 - alpha)) + (secondValue * alpha);
    }
}