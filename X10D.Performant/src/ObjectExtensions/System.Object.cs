using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static partial class ObjectExtensions
    {
        /// <inheritdoc cref="object.ReferenceEquals(object,object)" />
        public new static bool ReferenceEquals(this object value, object value2) => object.ReferenceEquals(value, value2);
    }
}