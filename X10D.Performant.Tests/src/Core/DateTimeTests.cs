using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="DateTimeExtensions"/>.
    /// </summary>
    [TestClass]
    public class DateTimeTests
    {
        /// <summary>
        ///     Tests for <see cref="DateTimeExtensions.Age(DateTime,DateTime?)"/>.
        /// </summary>
        [TestMethod]
        public void Age()
        {
            // no choice but to create dynamic based on today's date.
            // age varies with time
            DateTime now = DateTime.Now;
            DateTime dt = new(now.Year - 18, 1, 1);

            Assert.AreEqual(18, dt.Age());
        }

        /// <summary>
        ///     Tests for <see cref="DateTimeExtensions.First"/>.
        /// </summary>
        [TestMethod]
        public void First()
        {
            DateTime dt = new(2018, 6, 20);

            Assert.AreEqual(4, dt.First(DayOfWeek.Monday).Day);
        }

        /// <summary>
        ///     Tests for <see cref="DateTimeExtensions.FirstDayOfMonth"/>.
        /// </summary>
        [TestMethod]
        public void FirstDayOfMonth()
        {
            DateTime dt = new(2018, 6, 20);
            DateTime first = dt.FirstDayOfMonth();

            Assert.AreEqual(dt.Year, first.Year);
            Assert.AreEqual(dt.Month, first.Month);
            Assert.AreEqual(1, first.Day);
        }

        /// <summary>
        ///     Tests for <see cref="DateTimeExtensions.Last"/>.
        /// </summary>
        [TestMethod]
        public void Last()
        {
            {
                DateTime dt = new(2019, 12, 1);
                DateTime last = dt.Last(DayOfWeek.Wednesday);

                Assert.AreEqual(dt.Year, last.Year);
                Assert.AreEqual(dt.Month, last.Month);
                Assert.AreEqual(25, last.Day);
            }

            {
                DateTime dt = new(2020, 4, 14);
                DateTime last = dt.Last(DayOfWeek.Friday);

                Assert.AreEqual(dt.Year, last.Year);
                Assert.AreEqual(dt.Month, last.Month);
                Assert.AreEqual(24, last.Day);

                last = dt.Last(DayOfWeek.Thursday);
                Assert.AreEqual(dt.Year, last.Year);
                Assert.AreEqual(dt.Month, last.Month);
                Assert.AreEqual(30, last.Day);
            }
        }      
        
        /// <summary>
        ///     Tests for <see cref="DateTimeExtensions.Next"/>.
        /// </summary>
        [TestMethod]
        public void Next()
        {
            // Todo: implement this test
        }

        /// <summary>
        ///     Tests for <see cref="DateTimeExtensions.LastDayOfMonth"/>.
        /// </summary>
        [TestMethod]
        public void LastDayOfMonth()
        {
            DateTime dt = new(2016, 2, 4);
            DateTime last = dt.LastDayOfMonth();

            Assert.AreEqual(dt.Year, last.Year);
            Assert.AreEqual(dt.Month, last.Month);
            Assert.AreEqual(29, last.Day); // 2016 is a leap year
        }

        /// <summary>
        ///     Tests for <see cref="DateTimeExtensions.ToUnixTimeStamp"/>.
        /// </summary>
        [TestMethod]
        public void ToUnixTimestamp()
        {
            DateTime dt = new(2015, 10, 21, 1, 0, 0, DateTimeKind.Utc);
            long unix = dt.ToUnixTimeStamp();

            Assert.AreEqual(1445389200L, unix);
        }
    }
}