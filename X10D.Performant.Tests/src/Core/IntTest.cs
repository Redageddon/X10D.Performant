﻿using System;
using System.Diagnostics;
using System.Globalization;
using NUnit.Framework;
using X10D.Performant.Int32Extensions;
using X10D.Performant.UInt32Extensions;

namespace X10D.Performant.Tests.Core;

/// <summary>
///     Tests for <see cref="Int32Extensions"/>.
/// </summary>
public class IntTests
{
    /// <summary>
    ///     Tests for <see cref="Int32Extensions.FromUnixTimestamp"/>.
    /// </summary>
    [Test]
    public void FromUnixTimestamp()
    {
        Assert.AreEqual(DateTime.Parse("1970-01-01 00:20:34", CultureInfo.InvariantCulture), 1234.FromUnixTimestamp());
        Assert.AreEqual(DateTime.Parse("1970-01-01 00:00:01.234", CultureInfo.InvariantCulture), 1234.FromUnixTimestamp(true));
    }

    /// <summary>
    ///     Tests for <see cref="UInt32Extensions.FromUnixTimestamp"/>.
    /// </summary>
    [Test]
    public void FromUnixTimestampU()
    {
        Assert.AreEqual(DateTime.Parse("1970-01-01 00:20:34", CultureInfo.InvariantCulture), 1234U.FromUnixTimestamp());
        Assert.AreEqual(DateTime.Parse("1970-01-01 00:00:01.234", CultureInfo.InvariantCulture), 1234U.FromUnixTimestamp(true));
    }

    /// <summary>
    ///     Tests for <see cref="Int32Extensions.IsEven"/>.
    /// </summary>
    [Test]
    public void IsEven()
    {
        Assert.IsTrue(2.IsEven());
        Assert.IsFalse(1.IsEven());
    }

    /// <summary>
    ///     Tests for <see cref="UInt32Extensions.IsEven"/>.
    /// </summary>
    [Test]
    public void IsEvenU()
    {
        Assert.IsTrue(2u.IsEven());
        Assert.IsFalse(1u.IsEven());
    }

    /// <summary>
    ///     Tests for <see cref="Int32Extensions.IsOdd"/>.
    /// </summary>
    [Test]
    public void IsOdd()
    {
        Assert.IsFalse(2.IsOdd());
        Assert.IsTrue(1.IsOdd());
    }

    /// <summary>
    ///     Tests for <see cref="UInt32Extensions.IsOdd"/>.
    /// </summary>
    [Test]
    public void IsOddU()
    {
        Assert.IsFalse(2u.IsOdd());
        Assert.IsTrue(1u.IsOdd());
    }

    /// <summary>
    ///     Tests for <see cref="Int32Extensions.IsPrime"/>.
    /// </summary>
    [Test]
    public void IsPrime()
    {
        int[] primes = { 2, 11, 101, 1_009, 10_007, 100_003, 1_003_001, 10_000_019, 100_000_007, 1_000_000_007 };

        for (int i = 0; i < primes.Length; i++)
        {
            Trace.WriteLineIf(!primes[i].IsPrime(), primes[i]);
            Assert.IsTrue(primes[i].IsPrime());
        }

        int[] nonPrimes =
        {
            -1_000_000_007, -100_000_007, -10_000_019, -1_003_001, -100_001, -10_007, -1_009, -101, -11, -2, -1, 0, 1, 4, 29_001,
        };

        for (int i = 0; i < nonPrimes.Length; i++)
        {
            Trace.WriteLineIf(nonPrimes[i].IsPrime(), nonPrimes[i]);
            Assert.IsFalse(nonPrimes[i].IsPrime());
        }
    }

    /// <summary>
    ///     Tests for <see cref="UInt32Extensions.IsPrime"/>.
    /// </summary>
    [Test]
    public void IsPrimeU()
    {
        uint[] primes = { 2, 11, 101, 1_009, 10_007, 100_003, 1_003_001, 10_000_019, 100_000_007, 1_000_000_007, 4_294_967_291 };

        for (uint i = 0; i < primes.Length; i++)
        {
            Trace.WriteLineIf(!primes[i].IsPrime(), primes[i]);
            Assert.IsTrue(primes[i].IsPrime());
        }

        uint[] nonPrimes = { 0, 1, 4, 29_001 };

        for (uint i = 0; i < nonPrimes.Length; i++)
        {
            Trace.WriteLineIf(nonPrimes[i].IsPrime(), nonPrimes[i]);
            Assert.IsFalse(nonPrimes[i].IsPrime());
        }
    }

    /// <summary>
    ///     Tests for <see cref="Int32Extensions.Mod"/>.
    /// </summary>
    [Test]
    public void Mod()
    {
        for (int i = -100; i < 100; i++)
        {
            for (int j = -100; j < 100; j++)
            {
                if (j == 0)
                {
                    continue;
                }

                Assert.AreEqual(i % j, i.Mod(j));
            }
        }
    }

    /// <summary>
    ///     Tests for <see cref="UInt32Extensions.Mod"/>.
    /// </summary>
    [Test]
    public void ModU()
    {
        for (uint i = 1; i < 200; i++)
        {
            for (uint j = 1; j < 200; j++)
            {
                Assert.AreEqual(i % j, i.Mod(j));
            }
        }
    }

    /// <summary>
    ///     Tests for <see cref="Int32Extensions.ToBoolean"/>.
    /// </summary>
    [Test]
    public void ToBool()
    {
        Assert.IsTrue(2.ToBoolean());
        Assert.IsTrue(1.ToBoolean());
        Assert.IsFalse(0.ToBoolean());
    }

    /// <summary>
    ///     Tests for <see cref="UInt32Extensions.ToBoolean"/>.
    /// </summary>
    [Test]
    public void ToBoolU()
    {
        Assert.IsFalse(0u.ToBoolean());
        Assert.IsTrue(1u.ToBoolean());
        Assert.IsTrue(2u.ToBoolean());
    }
}