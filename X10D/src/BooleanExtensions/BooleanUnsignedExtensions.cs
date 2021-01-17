namespace X10D.Performant.BooleanExtensions
{
    public static partial class BooleanExtensions
    {
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