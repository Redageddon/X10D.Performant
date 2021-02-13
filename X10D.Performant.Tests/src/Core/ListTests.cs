using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using X10D.Performant.IListExtensions;

namespace X10D.Performant.Tests.Core
{
    /// <summary>
    ///     Tests for <see cref="ListExtensions"/>
    /// </summary>
    [TestClass]
    public class ListTests
    {
        /// <summary>
        ///     Tests for <see cref="ListExtensions.Random{T}(IList{T},IList{T},System.Random?)"/>
        /// </summary>
        [TestMethod]
        public void Random()
        {
            int[] array = { 1, 2, 3 };
            int[] buffer = new int[20];
            array.Random(buffer);
            
            Assert.IsTrue(buffer.Contains(1));
            Assert.IsTrue(buffer.Contains(2));
            Assert.IsTrue(buffer.Contains(3));
        }

        /// <summary>
        ///     Tests for <see cref="ListExtensions.Shuffle{T}(IList{T},System.Random?)"/>
        /// </summary>
        [TestMethod]
        public void Shuffle()
        {
            int[] array = { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            int[] buffer = { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
            array.Shuffle();

            CollectionAssert.AreNotEqual(array, buffer);
        }       
        
        /// <summary>
        ///     Tests for <see cref="ListExtensions.OneOf{T}"/>
        /// </summary>
        [TestMethod]
        public void OneOf()
        {
            // Todo: implement this test
        }
    }
}