using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using NUnit.Framework;
using X10D.Performant.GenericExtensions;

namespace X10D.Performant.Tests.Core;

/// <summary>
///     Tests for <see cref="GenericExtensions"/>.
/// </summary>
public class GenericTests
{
    /// <summary>
    ///     Tests for <see cref="GenericExtensions.To{TFrom,TTo}"/>.
    /// </summary>
    [Test]
    public void To()
    {
        const bool a = true;
        const char b = '1';
        const sbyte c = 1;
        const byte d = 1;
        const short e = 1;
        const ushort f = 1;
        const int g = 1;
        const uint h = 1;
        const long i = 1;
        const ulong j = 1;
        const float k = 1f;
        const double l = 1d;
        const string m = "1";
        const decimal n = 1;

        Assert.AreEqual(true, a.To<bool, bool>());
        Assert.AreEqual(1, a.To<bool, char>());
        Assert.AreEqual(1, a.To<bool, sbyte>());
        Assert.AreEqual(1, a.To<bool, byte>());
        Assert.AreEqual(1, a.To<bool, short>());
        Assert.AreEqual(1, a.To<bool, ushort>());
        Assert.AreEqual(1, a.To<bool, int>());
        Assert.AreEqual(1u, a.To<bool, uint>());
        Assert.AreEqual(1, a.To<bool, long>());
        Assert.AreEqual(1ul, a.To<bool, ulong>());
        Assert.AreEqual(1f, a.To<bool, float>());
        Assert.AreEqual(1d, a.To<bool, double>());
        Assert.AreEqual("True", a.To<bool, string>());
        Assert.AreEqual(1, a.To<bool, decimal>());

        Assert.AreEqual(true, b.To<char, bool>());
        Assert.AreEqual('1', b.To<char, char>());
        Assert.AreEqual(1, b.To<char, sbyte>());
        Assert.AreEqual(1, b.To<char, byte>());
        Assert.AreEqual(1, b.To<char, short>());
        Assert.AreEqual(1, b.To<char, ushort>());
        Assert.AreEqual(1, b.To<char, int>());
        Assert.AreEqual(1u, b.To<char, uint>());
        Assert.AreEqual(1, b.To<char, long>());
        Assert.AreEqual(1ul, b.To<char, ulong>());
        Assert.AreEqual(1, b.To<char, float>());
        Assert.AreEqual(1, b.To<char, double>());
        Assert.AreEqual("1", b.To<char, string>());
        Assert.AreEqual(1, b.To<char, decimal>());

        Assert.AreEqual(true, c.To<sbyte, bool>());
        Assert.AreEqual(1, c.To<sbyte, char>());
        Assert.AreEqual(1, c.To<sbyte, sbyte>());
        Assert.AreEqual(1, c.To<sbyte, byte>());
        Assert.AreEqual(1, c.To<sbyte, short>());
        Assert.AreEqual(1, c.To<sbyte, ushort>());
        Assert.AreEqual(1, c.To<sbyte, int>());
        Assert.AreEqual(1u, c.To<sbyte, uint>());
        Assert.AreEqual(1, c.To<sbyte, long>());
        Assert.AreEqual(1ul, c.To<sbyte, ulong>());
        Assert.AreEqual(1, c.To<sbyte, float>());
        Assert.AreEqual(1, c.To<sbyte, double>());
        Assert.AreEqual("1", c.To<sbyte, string>());
        Assert.AreEqual(1, c.To<sbyte, decimal>());

        Assert.AreEqual(true, d.To<byte, bool>());
        Assert.AreEqual(1, d.To<byte, char>());
        Assert.AreEqual(1, d.To<byte, sbyte>());
        Assert.AreEqual(1, d.To<byte, byte>());
        Assert.AreEqual(1, d.To<byte, short>());
        Assert.AreEqual(1, d.To<byte, ushort>());
        Assert.AreEqual(1, d.To<byte, int>());
        Assert.AreEqual(1u, d.To<byte, uint>());
        Assert.AreEqual(1, d.To<byte, long>());
        Assert.AreEqual(1ul, d.To<byte, ulong>());
        Assert.AreEqual(1, d.To<byte, float>());
        Assert.AreEqual(1, d.To<byte, double>());
        Assert.AreEqual("1", d.To<byte, string>());
        Assert.AreEqual(1, d.To<byte, decimal>());

        Assert.AreEqual(true, e.To<short, bool>());
        Assert.AreEqual(1, e.To<short, char>());
        Assert.AreEqual(1, e.To<short, sbyte>());
        Assert.AreEqual(1, e.To<short, byte>());
        Assert.AreEqual(1, e.To<short, short>());
        Assert.AreEqual(1, e.To<short, ushort>());
        Assert.AreEqual(1, e.To<short, int>());
        Assert.AreEqual(1u, e.To<short, uint>());
        Assert.AreEqual(1, e.To<short, long>());
        Assert.AreEqual(1ul, e.To<short, ulong>());
        Assert.AreEqual(1, e.To<short, float>());
        Assert.AreEqual(1, e.To<short, double>());
        Assert.AreEqual("1", e.To<short, string>());
        Assert.AreEqual(1, e.To<short, decimal>());

        Assert.AreEqual(true, f.To<ushort, bool>());
        Assert.AreEqual(1, f.To<ushort, char>());
        Assert.AreEqual(1, f.To<ushort, sbyte>());
        Assert.AreEqual(1, f.To<ushort, byte>());
        Assert.AreEqual(1, f.To<ushort, short>());
        Assert.AreEqual(1, f.To<ushort, ushort>());
        Assert.AreEqual(1, f.To<ushort, int>());
        Assert.AreEqual(1u, f.To<ushort, uint>());
        Assert.AreEqual(1, f.To<ushort, long>());
        Assert.AreEqual(1ul, f.To<ushort, ulong>());
        Assert.AreEqual(1, f.To<ushort, float>());
        Assert.AreEqual(1, f.To<ushort, double>());
        Assert.AreEqual("1", f.To<ushort, string>());
        Assert.AreEqual(1, f.To<ushort, decimal>());

        Assert.AreEqual(true, g.To<int, bool>());
        Assert.AreEqual(1, g.To<int, char>());
        Assert.AreEqual(1, g.To<int, sbyte>());
        Assert.AreEqual(1, g.To<int, byte>());
        Assert.AreEqual(1, g.To<int, short>());
        Assert.AreEqual(1, g.To<int, ushort>());
        Assert.AreEqual(1, g.To<int, int>());
        Assert.AreEqual(1u, g.To<int, uint>());
        Assert.AreEqual(1, g.To<int, long>());
        Assert.AreEqual(1ul, g.To<int, ulong>());
        Assert.AreEqual(1, g.To<int, float>());
        Assert.AreEqual(1, g.To<int, double>());
        Assert.AreEqual("1", g.To<int, string>());
        Assert.AreEqual(1, g.To<int, decimal>());

        Assert.AreEqual(true, h.To<uint, bool>());
        Assert.AreEqual(1, h.To<uint, char>());
        Assert.AreEqual(1, h.To<uint, sbyte>());
        Assert.AreEqual(1, h.To<uint, byte>());
        Assert.AreEqual(1, h.To<uint, short>());
        Assert.AreEqual(1, h.To<uint, ushort>());
        Assert.AreEqual(1, h.To<uint, int>());
        Assert.AreEqual(1u, h.To<uint, uint>());
        Assert.AreEqual(1, h.To<uint, long>());
        Assert.AreEqual(1ul, h.To<uint, ulong>());
        Assert.AreEqual(1, h.To<uint, float>());
        Assert.AreEqual(1, h.To<uint, double>());
        Assert.AreEqual("1", h.To<uint, string>());
        Assert.AreEqual(1, h.To<uint, decimal>());

        Assert.AreEqual(true, i.To<long, bool>());
        Assert.AreEqual(1, i.To<long, char>());
        Assert.AreEqual(1, i.To<long, sbyte>());
        Assert.AreEqual(1, i.To<long, byte>());
        Assert.AreEqual(1, i.To<long, short>());
        Assert.AreEqual(1, i.To<long, ushort>());
        Assert.AreEqual(1, i.To<long, int>());
        Assert.AreEqual(1u, i.To<long, uint>());
        Assert.AreEqual(1, i.To<long, long>());
        Assert.AreEqual(1ul, i.To<long, ulong>());
        Assert.AreEqual(1, i.To<long, float>());
        Assert.AreEqual(1, i.To<long, double>());
        Assert.AreEqual("1", i.To<long, string>());
        Assert.AreEqual(1, i.To<long, decimal>());

        Assert.AreEqual(true, j.To<ulong, bool>());
        Assert.AreEqual(1, j.To<ulong, char>());
        Assert.AreEqual(1, j.To<ulong, sbyte>());
        Assert.AreEqual(1, j.To<ulong, byte>());
        Assert.AreEqual(1, j.To<ulong, short>());
        Assert.AreEqual(1, j.To<ulong, ushort>());
        Assert.AreEqual(1, j.To<ulong, int>());
        Assert.AreEqual(1u, j.To<ulong, uint>());
        Assert.AreEqual(1, j.To<ulong, long>());
        Assert.AreEqual(1ul, j.To<ulong, ulong>());
        Assert.AreEqual(1, j.To<ulong, float>());
        Assert.AreEqual(1, j.To<ulong, double>());
        Assert.AreEqual("1", j.To<ulong, string>());
        Assert.AreEqual(1, j.To<ulong, decimal>());

        Assert.AreEqual(true, k.To<float, bool>());
        Assert.AreEqual(1, k.To<float, char>());
        Assert.AreEqual(1, k.To<float, sbyte>());
        Assert.AreEqual(1, k.To<float, byte>());
        Assert.AreEqual(1, k.To<float, short>());
        Assert.AreEqual(1, k.To<float, ushort>());
        Assert.AreEqual(1, k.To<float, int>());
        Assert.AreEqual(1u, k.To<float, uint>());
        Assert.AreEqual(1, k.To<float, long>());
        Assert.AreEqual(1ul, k.To<float, ulong>());
        Assert.AreEqual(1, k.To<float, float>());
        Assert.AreEqual(1, k.To<float, double>());
        Assert.AreEqual("1", k.To<float, string>());
        Assert.AreEqual(1, k.To<float, decimal>());

        Assert.AreEqual(true, l.To<double, bool>());
        Assert.AreEqual(1, l.To<double, char>());
        Assert.AreEqual(1, l.To<double, sbyte>());
        Assert.AreEqual(1, l.To<double, byte>());
        Assert.AreEqual(1, l.To<double, short>());
        Assert.AreEqual(1, l.To<double, ushort>());
        Assert.AreEqual(1, l.To<double, int>());
        Assert.AreEqual(1u, l.To<double, uint>());
        Assert.AreEqual(1, l.To<double, long>());
        Assert.AreEqual(1ul, l.To<double, ulong>());
        Assert.AreEqual(1, l.To<double, float>());
        Assert.AreEqual(1, l.To<double, double>());
        Assert.AreEqual("1", l.To<double, string>());
        Assert.AreEqual(1, l.To<double, decimal>());

        Assert.AreEqual(true, m.To<string, bool>());
        Assert.AreEqual(false, "0".To<string, bool>());
        Assert.AreEqual(true, "true".To<string, bool>());
        Assert.AreEqual('1', m.To<string, char>());
        Assert.AreEqual(1, m.To<string, sbyte>());
        Assert.AreEqual(1, m.To<string, byte>());
        Assert.AreEqual(1, m.To<string, short>());
        Assert.AreEqual(1, m.To<string, ushort>());
        Assert.AreEqual(1, m.To<string, int>());
        Assert.AreEqual(1u, m.To<string, uint>());
        Assert.AreEqual(1, m.To<string, long>());
        Assert.AreEqual(1ul, m.To<string, ulong>());
        Assert.AreEqual(1, m.To<string, float>());
        Assert.AreEqual(1, m.To<string, double>());
        Assert.AreEqual("1", m.To<string, string>());
        Assert.AreEqual(1, m.To<string, decimal>());
        Assert.AreEqual(TimeSpan.Parse("1.00:00:00", CultureInfo.InvariantCulture), m.To<string, TimeSpan>());
        Assert.AreEqual(new CustomParse(1), m.To<string, CustomParse>());

        Assert.AreEqual(true, n.To<decimal, bool>());
        Assert.AreEqual(1, n.To<decimal, char>());
        Assert.AreEqual(1, n.To<decimal, sbyte>());
        Assert.AreEqual(1, n.To<decimal, byte>());
        Assert.AreEqual(1, n.To<decimal, short>());
        Assert.AreEqual(1, n.To<decimal, ushort>());
        Assert.AreEqual(1, n.To<decimal, int>());
        Assert.AreEqual(1u, n.To<decimal, uint>());
        Assert.AreEqual(1, n.To<decimal, long>());
        Assert.AreEqual(1ul, n.To<decimal, ulong>());
        Assert.AreEqual(1, n.To<decimal, float>());
        Assert.AreEqual(1, n.To<decimal, decimal>());
        Assert.AreEqual("1", n.To<decimal, string>());
        Assert.AreEqual(1, n.To<decimal, decimal>());

        Assert.AreEqual(true, new CustomBool(1).To<CustomBool, bool>());
    }

    /// <summary>
    ///     Tests for <see cref="GenericExtensions.ToOrOther{TFrom,TTo}(TFrom,TTo)"/>.
    /// </summary>
    [Test]
    public void ToOrOther()
    {
        Assert.AreEqual(2.0, "Foo".ToOrOther(2.0));
        Assert.AreEqual(2.0, "2".ToOrOther(3));
    }

    /// <summary>
    ///     Tests for <see cref="GenericExtensions.ToOrOther{TFrom,TTo}(TFrom,Func{TTo})"/>.
    /// </summary>
    [Test]
    public void ToOrOtherFunc()
    {
        bool executed = false;

        double DoubleLambda()
        {
            executed = true;

            return 2.0;
        }

        Assert.AreEqual(2D, "Foo".ToOrOther(DoubleLambda));
        Assert.IsTrue(executed);

        executed = false;

        Assert.AreEqual(2D, "2".ToOrOther(DoubleLambda));
        Assert.IsFalse(executed);
    }

    /// <summary>
    ///     Tests for <see cref="GenericExtensions.TryTo{TFrom,TTo}"/>.
    /// </summary>
    [Test]
    public void TryTo()
    {
        Assert.IsTrue("2".TryTo(out int _2));
        Assert.AreEqual(2, _2);
        Assert.IsFalse("q".TryTo(out bool b));
        Assert.IsFalse(b);
    }

    private struct CustomParse
    {
        [SuppressMessage("ReSharper", "NotAccessedField.Local")]
        private int i;

        internal CustomParse(int i)
        {
            this.i = i;
        }

        [SuppressMessage("ReSharper", "UnusedMember.Local")]
        internal static CustomParse Parse(string s) => new() { i = int.Parse(s, CultureInfo.InvariantCulture) };
    }

    private readonly struct CustomBool
    {
        [SuppressMessage("ReSharper", "NotAccessedField.Local")]
        private readonly byte b;

        public CustomBool(byte b)
        {
            this.b = b;
        }

        public static explicit operator bool(CustomBool customBool) => customBool.b != 0;
    }
}