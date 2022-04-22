namespace X10D.Performant.RandomExtensions;

public static partial class RandomExtensions
{
    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextPlane"]'/>
    public static Plane NextPlane(this Random random,
                                  bool ensureOneNextCall = false,
                                  float xMin = 0,
                                  float xMax = 1,
                                  float yMin = 0,
                                  float yMax = 1,
                                  float zMin = 0,
                                  float zMax = 1,
                                  float dMin = 0,
                                  float dMax = 1)
    {
        if (ensureOneNextCall)
        {
            Random delegatedRandom = new(random.Next());

            return new Plane(delegatedRandom.NextSingle(xMin, xMax),
                             delegatedRandom.NextSingle(yMin, yMax),
                             delegatedRandom.NextSingle(zMin, zMax),
                             delegatedRandom.NextSingle(dMin, dMax));
        }

        return new Plane(random.NextSingle(xMin, xMax),
                         random.NextSingle(yMin, yMax),
                         random.NextSingle(zMin, zMax),
                         random.NextSingle(dMin, dMax));
    }

    /// <include file='../RandomExtensions.xml' path='members/member[@name="NextPlaneRandom"]'/>
    public static Plane NextPlane(this Random randomX,
                                  Random randomY,
                                  Random randomZ,
                                  Random randomD,
                                  float xMin = 0,
                                  float xMax = 1,
                                  float yMin = 0,
                                  float yMax = 1,
                                  float zMin = 0,
                                  float zMax = 1,
                                  float dMin = 0,
                                  float dMax = 1) =>
        new(randomX.NextSingle(xMin, xMax),
            randomY.NextSingle(yMin, yMax),
            randomZ.NextSingle(zMin, zMax),
            randomD.NextSingle(dMin, dMax));
}