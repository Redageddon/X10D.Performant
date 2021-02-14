namespace X10D.Performant
{
    public static partial class ObjectExtensions
    {
        /// <inheritdoc cref="string.Concat(object)"/>
        public static string Concat(this object value) => string.Concat(value);

        /// <inheritdoc cref="string.Concat(object,object)"/>
        public static string Concat(this object value, object value2) => string.Concat(value, value2);

        /// <inheritdoc cref="string.Concat(object,object,object)"/>
        public static string Concat(this object value, object value2, object value3) => string.Concat(value, value2, value3);

        /// <inheritdoc cref="string.Concat(object[])"/>
        public static string Concat(this object?[] values) => string.Concat(values);
    }
}