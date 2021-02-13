namespace X10D.Performant
{
    /// <summary>
    ///     Extension methods for <see cref="bool"/>.
    /// </summary>
    public static partial class BooleanExtensions
    {
        /// <summary>
        ///     Gets the value of this <see cref="bool"/> as represented by <see cref="byte"/>.
        /// </summary>
        /// <param name="value">A <see cref="bool"/>.</param>
        /// <returns>1 if <paramref name="value"/> is <see langword="true"/>, or 0 otherwise.</returns>
        public static byte ToByte(this bool value) => value ? 1 : 0;

        /// <summary>
        ///     Gets the value of this <see cref="bool"/> as represented by <see cref="short"/>.
        /// </summary>
        /// <param name="value">A <see cref="bool"/>.</param>
        /// <returns>1 if <paramref name="value"/> is <see langword="true"/>, or 0 otherwise.</returns>
        public static short ToShort(this bool value) => value ? 1 : 0;

        /// <summary>
        ///     Gets the value of this <see cref="bool"/> as represented by <see cref="int"/>.
        /// </summary>
        /// <param name="value">A <see cref="bool"/>.</param>
        /// <returns>1 if <paramref name="value"/> is <see langword="true"/>, or 0 otherwise.</returns>
        public static int ToInt(this bool value) => value ? 1 : 0;

        /// <summary>
        ///     Gets the value of this <see cref="bool"/> as represented by <see cref="long"/>.
        /// </summary>
        /// <param name="value">A <see cref="bool"/>.</param>
        /// <returns>1 if <paramref name="value"/> is <see langword="true"/>, or 0 otherwise.</returns>
        public static long ToLong(this bool value) => value ? 1 : 0;        
        
        /// <summary>
        ///     Gets the value of this <see cref="bool"/> as represented by <see cref="decimal"/>.
        /// </summary>
        /// <param name="value">A <see cref="bool"/>.</param>
        /// <returns>1 if <paramref name="value"/> is <see langword="true"/>, or 0 otherwise.</returns>
        public static decimal ToDecimal(this bool value) => value ? 1 : 0;
        
        /// <summary>
        ///     Gets the value of this <see cref="bool"/> as represented by <see cref="double"/>.
        /// </summary>
        /// <param name="value">A <see cref="bool"/>.</param>
        /// <returns>1 if <paramref name="value"/> is <see langword="true"/>, or 0 otherwise.</returns>
        public static double ToDouble(this bool value) => value ? 1 : 0;
        
        /// <summary>
        ///     Gets the value of this <see cref="bool"/> as represented by <see cref="float"/>.
        /// </summary>
        /// <param name="value">A <see cref="bool"/>.</param>
        /// <returns>1 if <paramref name="value"/> is <see langword="true"/>, or 0 otherwise.</returns>
        public static double ToFloat(this bool value) => value ? 1 : 0;
        
        /// <summary>
        ///     Gets the value of this <see cref="bool"/> as represented by <see cref="sbyte"/>.
        /// </summary>
        /// <param name="value">A <see cref="bool"/>.</param>
        /// <returns>1 if <paramref name="value"/> is <see langword="true"/>, or 0 otherwise.</returns>
        public static sbyte ToSByte(this bool value) => value ? 1 : 0;

        /// <summary>
        ///     Gets the value of this <see cref="bool"/> as represented by <see cref="ushort"/>.
        /// </summary>
        /// <param name="value">A <see cref="bool"/>.</param>
        /// <returns>1 if <paramref name="value"/> is <see langword="true"/>, or 0 otherwise.</returns>
        public static ushort ToUShort(this bool value) => value ? 1 : 0;

        /// <summary>
        ///     Gets the value of this <see cref="bool"/> as represented by <see cref="uint"/>.
        /// </summary>
        /// <param name="value">A <see cref="bool"/>.</param>
        /// <returns>1 if <paramref name="value"/> is <see langword="true"/>, or 0 otherwise.</returns>
        public static uint ToUInt(this bool value) => value ? 1 : 0;

        /// <summary>
        ///     Gets the value of this <see cref="bool"/> as represented by <see cref="ulong"/>.
        /// </summary>
        /// <param name="value">A <see cref="bool"/>.</param>
        /// <returns>1 if <paramref name="value"/> is <see langword="true"/>, or 0 otherwise.</returns>
        public static ulong ToULong(this bool value) => value ? 1 : 0;
    }
}