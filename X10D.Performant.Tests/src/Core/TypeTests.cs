using System.Collections.Generic;
using NUnit.Framework;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="TypeExtensions"/>
    /// </summary>
    public class TypeTests
    {
        /// <summary>
        ///     Tests for <see cref="TypeExtensions.GetContainedType"/>
        /// </summary>
        [Test]
        public void GetContainedType()
        {
            Assert.AreEqual(typeof(int), typeof(int[]).GetContainedType());
            Assert.AreEqual(typeof(double), typeof(List<double>).GetContainedType());
        }
    }
}