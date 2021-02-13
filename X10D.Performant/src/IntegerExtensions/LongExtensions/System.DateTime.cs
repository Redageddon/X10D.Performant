using System;

namespace X10D.Performant
{
    public static partial class LongExtensions
    {
        /// <inheritdoc cref="DateTime.FromFileTime(long)"/>
        public static DateTime FromFileTime(this long fileTime) => DateTime.FromFileTime(fileTime);
        
        /// <inheritdoc cref="DateTime.FromFileTimeUtc(long)"/>
        public static DateTime FromFileTimeUtc(this long fileTime) => DateTime.FromFileTimeUtc(fileTime);
    }
}