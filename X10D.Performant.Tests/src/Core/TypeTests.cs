using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="TypeExtensions"/>
    /// </summary>
    [TestClass]
    public class TypeTests
    {
        /// <summary>
        ///     Tests for <see cref="TypeExtensions.GetContainedType"/>
        /// </summary>
        [TestMethod]
        public void GetContainedType()
        {
            Assert.AreEqual(typeof(int), typeof(int[]).GetContainedType());
            Assert.AreEqual(typeof(double), typeof(List<double>).GetContainedType());
        }
    }
}