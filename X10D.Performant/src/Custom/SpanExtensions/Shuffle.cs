namespace X10D.Performant.SpanExtensions;

public static partial class SpanExtensions
{
    /// <include file='SpanExtensions.xml' path='members/member[@name="Shuffle"]'/>
    public static void Shuffle<T>(this in Span<T?> values, Random? random = null)
    {
        random ??= RandomExtensions.RandomExtensions.Random;

        int count = values.Length;

        while (count > 0)
        {
            int index = random.Next(count--);

            (values[count], values[index]) = (values[index], values[count]);
        }
    }
}