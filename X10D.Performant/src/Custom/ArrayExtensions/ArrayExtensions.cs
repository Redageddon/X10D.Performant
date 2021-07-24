namespace X10D.Performant.ArrayExtensions
{
    /// <summary>
    ///     Array generic extension methods.
    /// </summary>
    public static class ArrayExtensions
    {
        /// <include file='ArrayExtensions.xml' path='members/member[@name="Span"]'/>
        public static void Swap<T>(this T[] values, int firstIndex, int secondIndex) =>
            (values[firstIndex], values[secondIndex]) = (values[secondIndex], values[firstIndex]);
    }
}