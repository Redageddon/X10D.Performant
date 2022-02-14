using System;
using NUnit.Framework;
using X10D.Performant.DoubleExtensions;

namespace X10D.Performant.Tests.Core;

/// <summary>
///     Tests for <see cref="DoubleExtensions"/>.
/// </summary>
public class DoubleTests
{
    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.AlmostEquals"/>.
    /// </summary>
    [Test]
    public void AlmostEquals()
    {
        Assert.IsTrue(1.5.AlmostEquals(1.6, 0.11));
        Assert.IsFalse(1.4.AlmostEquals(1.6, 0.11));
        Assert.IsFalse(1.8.AlmostEquals(1.6, 0.11));
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.CelsiusToFahrenheit"/>.
    /// </summary>
    [Test]
    public void CelsiusToFahrenheit()
    {
        Assert.AreEqual(32, 0D.CelsiusToFahrenheit());
        Assert.AreEqual(41, 5D.CelsiusToFahrenheit());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.CelsiusToFahrenheit"/>.
    /// </summary>
    [Test]
    public void CelsiusToKelvin()
    {
        Assert.AreEqual(273.15, 0D.CelsiusToKelvin());
        Assert.AreEqual(0, (-273.15).CelsiusToKelvin());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.DegreesToGradians"/>.
    /// </summary>
    [Test]
    public void DegreesToGradians()
    {
        Assert.AreEqual(100, 90.0.DegreesToGradians());
        Assert.AreEqual(150, 135.0.DegreesToGradians());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.DegreesToRadians"/>.
    /// </summary>
    [Test]
    public void DegreesToRadians()
    {
        Assert.AreEqual(Math.PI, 180.0.DegreesToRadians());
        Assert.AreEqual(Math.PI * 1.5, 270.0.DegreesToRadians());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.FahrenheitToCelsius"/>.
    /// </summary>
    [Test]
    public void FahrenheitToCelsius()
    {
        Assert.AreEqual(0, 32D.FahrenheitToCelsius());
        Assert.AreEqual(5, 41D.FahrenheitToCelsius());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.FahrenheitToKelvin"/>.
    /// </summary>
    [Test]
    public void FahrenheitToKelvin()
    {
        Assert.AreEqual(255.37222222222221, 0D.FahrenheitToKelvin());
        Assert.AreEqual(0.14999999999997726, (-459.4).FahrenheitToKelvin());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.GradiansToDegrees"/>.
    /// </summary>
    [Test]
    public void GradiansToDegrees()
    {
        Assert.AreEqual(90, 100.0.GradiansToDegrees());
        Assert.AreEqual(135, 150.0.GradiansToDegrees());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.GradiansToRadians"/>.
    /// </summary>
    [Test]
    public void GradiansToRadians()
    {
        Assert.AreEqual(Math.PI, 200.0.GradiansToRadians());
        Assert.AreEqual(1, (200 / Math.PI).GradiansToRadians());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.InverseSqrt"/>.
    /// </summary>
    [Test]
    public void InverseSqrt()
    {
        Assert.AreEqual(1, 1.0.InverseSqrt());
        Assert.AreEqual(0.5, 4.0.InverseSqrt());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.IsEven"/>.
    /// </summary>
    [Test]
    public void IsEven()
    {
        Assert.IsTrue(2.0.IsEven());
        Assert.IsFalse(1.0.IsEven());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.IsOdd"/>.
    /// </summary>
    [Test]
    public void IsOdd()
    {
        Assert.IsFalse(2.0.IsOdd());
        Assert.IsTrue(1.0.IsOdd());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.KelvinToCelsius"/>.
    /// </summary>
    [Test]
    public void KelvinToCelsius()
    {
        Assert.AreEqual(0, 273.15.KelvinToCelsius());
        Assert.AreEqual(-273.15, 0D.KelvinToCelsius());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.KelvinToFahrenheit"/>.
    /// </summary>
    [Test]
    public void KelvinToFahrenheit()
    {
        Assert.AreEqual(-459.66999999999996, 0D.KelvinToFahrenheit());
        Assert.AreEqual(-0.00039999999993511892, 255.372D.KelvinToFahrenheit());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.Lerp"/>.
    /// </summary>
    [Test]
    public void Lerp()
    {
        Assert.AreEqual(0, 0.25.Lerp(0, 0));
        Assert.AreEqual(0, 0.5.Lerp(0, 0));
        Assert.AreEqual(0, 0.75.Lerp(0, 0));
        Assert.AreEqual(0, (-0.25).Lerp(0, 0));
        Assert.AreEqual(0, (-0.5).Lerp(0, 0));
        Assert.AreEqual(0, (-0.75).Lerp(0, 0));

        Assert.AreEqual(0.25, 0.25.Lerp(0, 1));
        Assert.AreEqual(0.5, 0.5.Lerp(0, 1));
        Assert.AreEqual(0.75, 0.75.Lerp(0, 1));
        Assert.AreEqual(25, 0.25.Lerp(0, 100));
        Assert.AreEqual(50, 0.5.Lerp(0, 100));
        Assert.AreEqual(75, 0.75.Lerp(0, 100));

        Assert.AreEqual(-0.25, (-0.25).Lerp(0, 1));
        Assert.AreEqual(-0.5, (-0.5).Lerp(0, 1));
        Assert.AreEqual(-0.75, (-0.75).Lerp(0, 1));
        Assert.AreEqual(-25, (-0.25).Lerp(0, 100));
        Assert.AreEqual(-50, (-0.5).Lerp(0, 100));
        Assert.AreEqual(-75, (-0.75).Lerp(0, 100));

        Assert.AreEqual(0.25, 0.75.Lerp(1, 0));
        Assert.AreEqual(0.5, 0.5.Lerp(1, 0));
        Assert.AreEqual(0.75, 0.25.Lerp(1, 0));
        Assert.AreEqual(25, 0.75.Lerp(100, 0));
        Assert.AreEqual(50, 0.5.Lerp(100, 0));
        Assert.AreEqual(75, 0.25.Lerp(100, 0));

        Assert.AreEqual(1.75, (-0.75).Lerp(1, 0));
        Assert.AreEqual(1.5, (-0.5).Lerp(1, 0));
        Assert.AreEqual(1.25, (-0.25).Lerp(1, 0));
        Assert.AreEqual(175, (-0.75).Lerp(100, 0));
        Assert.AreEqual(150, (-0.5).Lerp(100, 0));
        Assert.AreEqual(125, (-0.25).Lerp(100, 0));
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.LerpClamped"/>.
    /// </summary>
    [Test]
    public void LerpClamped()
    {
        Assert.AreEqual(0, (-1D).LerpClamped(0, 100));
        Assert.AreEqual(50, 0.5.LerpClamped(0, 100));
        Assert.AreEqual(100, 2.0.LerpClamped(0, 100));
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.LerpTo"/>.
    /// </summary>
    [Test]
    public void LerpTo()
    {
        Assert.AreEqual(0, 0D.LerpTo(0, 0.25));
        Assert.AreEqual(0, 0D.LerpTo(0, 0.5));
        Assert.AreEqual(0, 0D.LerpTo(0, 0.75));
        Assert.AreEqual(0, 0D.LerpTo(0, -0.25));
        Assert.AreEqual(0, 0D.LerpTo(0, -0.5));
        Assert.AreEqual(0, 0D.LerpTo(0, -0.75));

        Assert.AreEqual(0.25, 0D.LerpTo(1, 0.25));
        Assert.AreEqual(0.5, 0D.LerpTo(1, 0.5));
        Assert.AreEqual(0.75, 0D.LerpTo(1, 0.75));
        Assert.AreEqual(25, 0D.LerpTo(100, 0.25));
        Assert.AreEqual(50, 0D.LerpTo(100, 0.5));
        Assert.AreEqual(75, 0D.LerpTo(100, 0.75));

        Assert.AreEqual(-0.25, 0D.LerpTo(1, -0.25));
        Assert.AreEqual(-0.5, 0D.LerpTo(1, -0.5));
        Assert.AreEqual(-0.75, 0D.LerpTo(1, -0.75));
        Assert.AreEqual(-25, 0D.LerpTo(100, -0.25));
        Assert.AreEqual(-50, 0D.LerpTo(100, -0.5));
        Assert.AreEqual(-75, 0D.LerpTo(100, -0.75));

        Assert.AreEqual(0.25, 1D.LerpTo(0, 0.75));
        Assert.AreEqual(0.5, 1D.LerpTo(0, 0.5));
        Assert.AreEqual(0.75, 1D.LerpTo(0, 0.25));
        Assert.AreEqual(25, 100D.LerpTo(0, 0.75));
        Assert.AreEqual(50, 100D.LerpTo(0, 0.5));
        Assert.AreEqual(75, 100D.LerpTo(0, 0.25));

        Assert.AreEqual(1.75, 1D.LerpTo(0, -0.75));
        Assert.AreEqual(1.5, 1D.LerpTo(0, -0.5));
        Assert.AreEqual(1.25, 1D.LerpTo(0, -0.25));
        Assert.AreEqual(175, 100D.LerpTo(0, -0.75));
        Assert.AreEqual(150, 100D.LerpTo(0, -0.5));
        Assert.AreEqual(125, 100D.LerpTo(0, -0.25));
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.LerpToClamped"/>.
    /// </summary>
    [Test]
    public void LerpToClamped()
    {
        Assert.AreEqual(0, 0D.LerpToClamped(100, -1));
        Assert.AreEqual(50, 0D.LerpToClamped(100, 0.5));
        Assert.AreEqual(100, 0D.LerpToClamped(100, 2.0));
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.RadiansToDegrees"/>.
    /// </summary>
    [Test]
    public void RadiansToDegrees()
    {
        Assert.AreEqual(180.0, Math.PI.RadiansToDegrees());
        Assert.AreEqual(360.0, (2.0 * Math.PI).RadiansToDegrees());
    }

    /// <summary>
    ///     Tests for <see cref="DoubleExtensions.RadiansToGradians"/>.
    /// </summary>
    [Test]
    public void RadiansToGradians()
    {
        Assert.AreEqual(200.0, Math.PI.RadiansToGradians());
        Assert.AreEqual(400.0, (2.0 * Math.PI).RadiansToGradians());
    }
}