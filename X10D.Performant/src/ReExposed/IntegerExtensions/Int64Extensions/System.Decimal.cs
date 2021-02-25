namespace X10D.Performant.ReExposed
{
    public static partial class Int64Extensions
    {
        // ReSharper disable once InconsistentNaming
        /// <inheritdoc cref="decimal.FromOACurrency(long)" />
        public static decimal FromOACurrency(this long value) => decimal.FromOACurrency(value);
    }
}