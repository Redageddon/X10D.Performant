using System;

namespace X10D.Performant.ShortExtensions
{
    /// <summary>
    ///     Extension methods for <see cref="short"/>.
    /// </summary>
    public static partial class ShortExtensions
    {
        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.FromUnixTimestamp"/>
        public static DateTime FromUnixTimestamp(this short timestamp, bool isMillis = false)
        {
            DateTimeOffset offset = isMillis
                ? DateTimeOffset.FromUnixTimeMilliseconds(timestamp)
                : DateTimeOffset.FromUnixTimeSeconds(timestamp);

            return offset.DateTime;
        }

        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.IsEven"/>
        public static bool IsEven(this short value) => value % 2 == 0;

        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.IsOdd"/>
        public static bool IsOdd(this short value) => value % 2 != 0;

        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.ToBoolean"/>
        public static bool ToBoolean(this short value) => value != 0;
        
        /// <inheritdoc cref="X10D.Performant.LongExtensions.LongExtensions.IsPrime"/>
        public static bool IsPrime(this short value)
        {
            switch (value)
            {
                case < 2: return false;
                case 2:
                case 3: return true;
            }

            if (value % 2 == 0 ||
                value % 3 == 0)
            {
                return false;
            }

            if ((value + 1) % 6 != 0 &&
                (value - 1) % 6 != 0)
            {
                return false;
            }

            for (short i = 5; i * i <= value; i += 6)
            {
                if (value % i == 0 ||
                    value % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}