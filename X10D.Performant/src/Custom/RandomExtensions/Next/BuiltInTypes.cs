using System;

namespace X10D.Performant.RandomExtensions;

public static partial class RandomExtensions
{
    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextBoolean"]'/>
    public static bool NextBoolean(this Random random) => random.NextDouble() >= 0.5;

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextByte"]'/>
    public static byte NextByte(this Random random, byte maxValue = byte.MaxValue) => (byte)(maxValue * random.NextDouble());

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextByteMax"]'/>
    public static byte NextByte(this Random random, byte minValue, byte maxValue) =>
        (byte)(((maxValue - minValue) * random.NextDouble()) + minValue);

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextChar"]'/>
    public static char NextChar(this Random random, char minValue = 'a', char maxValue = '{') => (char)random.Next(minValue, maxValue + 1);

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextDouble"]'/>
    public static double NextDouble(this Random random, double maxValue) => maxValue * random.NextDouble();

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextDoubleMax"]'/>
    public static double NextDouble(this Random random, double minValue, double maxValue) =>
        ((maxValue - minValue) * random.NextDouble()) + minValue;

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextInt16"]'/>
    public static short NextInt16(this Random random, short maxValue = short.MaxValue) => (short)(maxValue * random.NextDouble());

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextInt16Max"]'/>
    public static short NextInt16(this Random random, short minValue, short maxValue) =>
        (short)(((maxValue - minValue) * random.NextDouble()) + minValue);

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextInt64"]'/>
    // TODO: remove decimal usage and ensure only 1 random.Next is called
    public static long NextInt64(this Random random, long maxValue = long.MaxValue)
    {
        // Introduces a larger range of distribution but all values are still included so random.NextDecimal() is safe to use here.
        decimal value = (decimal)random.Next() / long.MaxValue;

        return (long)(maxValue * value);
    }

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextInt64Max"]'/>
    // TODO: remove decimal usage and ensure only 1 random.Next is called
    public static long NextInt64(this Random random, long minValue, long maxValue)
    {
        // Introduces a larger range of distribution but all values are still included so random.NextDecimal() is safe to use here.
        decimal value = (decimal)random.Next() / long.MaxValue;

        return (long)((maxValue * value) - (minValue * value) + minValue);
    }

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextSByte"]'/>
    public static sbyte NextSByte(this Random random, sbyte maxValue = sbyte.MaxValue) => (sbyte)(maxValue * random.NextDouble());

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextSByteMax"]'/>
    public static sbyte NextSByte(this Random random, sbyte minValue, sbyte maxValue) =>
        (sbyte)(((maxValue - minValue) * random.NextDouble()) + minValue);

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextSingle"]'/>
    public static float NextSingle(this Random random, float maxValue = 1F) => maxValue * (float)random.NextDouble();

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextSingleMax"]'/>
    public static float NextSingle(this Random random, float minValue, float maxValue) =>
        ((maxValue - minValue) * (float)random.NextDouble()) + minValue;

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextUInt16"]'/>
    public static ushort NextUInt16(this Random random, ushort maxValue = ushort.MaxValue) => (ushort)(random.NextDouble() * maxValue);

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextUInt16Max"]'/>
    public static ushort NextUInt16(this Random random, ushort minValue, ushort maxValue) =>
        (ushort)(((maxValue - minValue) * random.NextDouble()) + minValue);

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextUInt32"]'/>
    public static uint NextUInt32(this Random random, uint maxValue = uint.MaxValue) => (uint)(maxValue * random.NextDouble());

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextUInt32Max"]'/>
    public static uint NextUInt32(this Random random, uint minValue, uint maxValue) =>
        (uint)(((maxValue - minValue) * random.NextDouble()) + minValue);

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextUInt64"]'/>
    // TODO: remove decimal usage and ensure only 1 random.Next is called
    public static ulong NextUInt64(this Random random, ulong maxValue = ulong.MaxValue)
    {
        // Introduces a larger range of distribution but all values are still included so random.NextDecimal() is safe to use here.
        decimal value = (decimal)random.Next() / ulong.MaxValue;

        return (ulong)(maxValue * value);
    }

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextUInt64Max"]'/>
    // TODO: remove decimal usage and ensure only 1 random.Next is called
    public static ulong NextUInt64(this Random random, ulong minValue, ulong maxValue)
    {
        // Introduces a larger range of distribution but all values are still included so random.NextDecimal() is safe to use here.
        decimal value = (decimal)random.Next() / ulong.MaxValue;

        return (ulong)(((maxValue - minValue) * value) + minValue);
    }
}