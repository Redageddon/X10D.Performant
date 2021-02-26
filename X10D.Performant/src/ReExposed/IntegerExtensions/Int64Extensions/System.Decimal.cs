using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static partial class Int64Extensions
    {
        /// <inheritdoc cref="decimal.FromOACurrency(long)"/>
        public static decimal FromOACurrency(this long value) => decimal.FromOACurrency(value);
    }
}