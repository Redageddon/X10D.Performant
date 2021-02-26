using System;
using System.Diagnostics.CodeAnalysis;

namespace X10D.Performant.ReExposed
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "UnusedType.Global")]
    public static partial class StringExtensions
    {
        /// <inheritdoc cref="Guid.Parse(string)"/>
        public static Guid ToGuid(this string value) => Guid.Parse(value);

        /// <inheritdoc cref="Guid.ParseExact(string,string)"/>
        public static Guid ToGuidExact(this string value, string format) => Guid.ParseExact(value, format);

        /// <inheritdoc cref="Guid.TryParse(string,out Guid)"/>
        public static bool TryToGuid(this string value, out Guid result) => Guid.TryParse(value, out result);

        /// <inheritdoc cref="Guid.TryParseExact(string,string,out Guid)"/>
        public static bool TryToGuidExact(this string value, string format, out Guid result) => Guid.TryParseExact(value, format, out result);
    }
}