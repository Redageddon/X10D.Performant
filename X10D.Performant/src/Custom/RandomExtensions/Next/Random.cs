namespace X10D.Performant.RandomExtensions;

public static partial class RandomExtensions
{
    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextRandom"]'/>
    public static Random NextRandom(this Random random) => new(random.Next());
}