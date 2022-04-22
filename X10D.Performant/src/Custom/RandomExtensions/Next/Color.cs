using X10D.Performant.DoubleExtensions;

namespace X10D.Performant.RandomExtensions;

public static partial class RandomExtensions
{
    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextColorAhsb"]'/>
    public static Color NextColorAhsb(this Random random,
                                      byte minAlpha = byte.MinValue,
                                      byte maxAlpha = byte.MaxValue,
                                      float minHue = 0,
                                      float maxHue = 1,
                                      float minSaturation = 0,
                                      float maxSaturation = 1,
                                      float minBrightness = 0,
                                      float maxBrightness = 1)
    {
        byte a = (byte)random.Next(minAlpha, maxAlpha);
        float h = (float)random.NextDouble().Lerp(minHue, maxHue);
        float s = (float)random.NextDouble().Lerp(minSaturation, maxSaturation);
        float b = (float)random.NextDouble().Lerp(minBrightness, maxBrightness);

        return ColorExtensions.ColorExtensions.ColorFromAhsb(a, h, s, b);
    }

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextColorArgb"]'/>
    public static Color NextColorArgb(this Random random,
                                      byte minAlpha = byte.MinValue,
                                      byte maxAlpha = byte.MaxValue,
                                      byte minRed = byte.MinValue,
                                      byte maxRed = byte.MaxValue,
                                      byte minGreen = byte.MinValue,
                                      byte maxGreen = byte.MaxValue,
                                      byte minBlue = byte.MinValue,
                                      byte maxBlue = byte.MaxValue) =>
        Color.FromArgb((random.Next(minAlpha, maxAlpha) << 24)
                     | (random.Next(minRed, maxRed) << 16)
                     | (random.Next(minGreen, maxGreen) << 8)
                     | random.Next(minBlue, maxBlue));
}