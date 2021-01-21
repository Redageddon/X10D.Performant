using System;

namespace X10D.Performant.ArrayExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="Array"/>
    /// </summary>
    public static class ArrayExtensions
    {
        /// <inheritdoc cref="Array.Clear(Array,int,int)"/>
        public static void Clear(this Array value, int index, int length) => Array.Clear(value, index, length);
        
        /// <inheritdoc cref="Array.Copy(Array,int,Array,int,int)"/>
        public static void Copy(this Array value, int valueIndex, Array value2, int value2Index, int length) =>
            Array.Copy(value, valueIndex, value2, value2Index, length);
        
        /// <inheritdoc cref="Array.Copy(Array,long,Array,long,long)"/>
        public static void Copy(this Array value, long valueIndex, Array value2, long value2Index, long length) =>
            Array.Copy(value, valueIndex, value2, value2Index, length);

        
    }
}