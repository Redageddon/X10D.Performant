using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="EnumExtensions"/>.
    /// </summary>
    [TestClass]
    public class EnumTests
    {
        /// <summary>
        ///     Tests for <see cref="EnumExtensions.NextEnumDeclaration{T}(T,bool)"/>.
        /// </summary>
        [TestMethod]
        public void NextEnumDeclaration()
        {
            Assert.AreEqual(Test.B, Test.A.NextEnumDeclaration());
            Assert.AreEqual(Test.A, Test.D.NextEnumDeclaration());
            Assert.AreEqual(Test.D, Test.D.NextEnumDeclaration(false));
        }

        /// <summary>
        ///     Tests for <see cref="EnumExtensions.PreviousEnumDeclaration{T}(T,bool)"/>.
        /// </summary>
        [TestMethod]
        public void PreviousEnumDeclaration()
        {
            Assert.AreEqual(Test.C, Test.D.PreviousEnumDeclaration());
            Assert.AreEqual(Test.D, Test.A.PreviousEnumDeclaration());
            Assert.AreEqual(Test.A, Test.A.PreviousEnumDeclaration(false));
        }

        private enum Test
        {
            A,
            B,
            C,
            D,
        }
    }
}